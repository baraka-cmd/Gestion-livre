using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCGestionLivres : UserControl
    {
        private bool chargementEnCours = false;
        private bool premierChargement = true; // ✅ Pour forcer le premier chargement

        public UCGestionLivres()
        {
            InitializeComponent();
            cmbLivre.SelectedIndexChanged += new EventHandler(cmbLivre_SelectedIndexChanged);
        }

        // ✅ Remplacer Load par VisibleChanged
        private void UCGestionLivres_Load(object sender, EventArgs e)
        {
            // Ne plus utiliser Load
        }

        // ✅ Nouveau : se déclenche quand l'onglet devient visible
        private void UCGestionLivres_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && premierChargement)
            {
                premierChargement = false;
                actualiserTout();
            }
        }

        private void actualiserTout()
        {
            try
            {
                chargementEnCours = true;

                ConnexionBD con = new ConnexionBD();

                // Charger les livres dans le DataGridView
                con.chargerDGV("SELECT * FROM Livre", dgvLivres);

                // Charger les auteurs dans le ComboBox
                con.chargerCBO("SELECT idAuteur, nomAut FROM Auteur", cmbAuteur, "idAuteur", "nomAut");

                // ✅ CORRECTION : Recharger le ComboBox livre sans déclencher l'événement
                cmbLivre.SelectedIndexChanged -= cmbLivre_SelectedIndexChanged; // Détacher
                con.chargerCBO("SELECT idLivre, titre FROM Livre", cmbLivre, "idLivre", "titre");
                cmbLivre.SelectedIndexChanged += cmbLivre_SelectedIndexChanged; // Rattacher

                // Charger les publications
                string rqtJointure = "SELECT Ecrire.idAuteur, Auteur.nomAut, Ecrire.idLivre, Livre.titre, Ecrire.nbrePag, Ecrire.datPub " +
                                     "FROM (Ecrire INNER JOIN Auteur ON Ecrire.idAuteur = Auteur.idAuteur) " +
                                     "INNER JOIN Livre ON Ecrire.idLivre = Livre.idLivre";
                con.chargerDGV(rqtJointure, dgvPublications);

                // ✅ Réinitialiser les champs publication
                numPagesPub.Value = 0;
                dtpDatePub.Value = DateTime.Now;
                if (cmbAuteur.Items.Count > 0) cmbAuteur.SelectedIndex = -1;
                if (cmbLivre.Items.Count > 0) cmbLivre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }
            finally
            {
                chargementEnCours = false;
            }
        }

        // =============================================
        // GESTION DES LIVRES
        // =============================================

        private void btnAjouterLiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdLivre.Text) || string.IsNullOrEmpty(txtTitre.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                Livre liv = new Livre(
                    txtIdLivre.Text.Trim().ToUpper(),
                    txtTitre.Text.Trim(),
                    (int)numPages.Value
                );
                liv.enregistrer();
                actualiserTout();
                reinitialiserLiv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message);
            }
        }

        private void btnModifierLiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdLivre.Text))
                {
                    MessageBox.Show("Sélectionnez d'abord un livre.");
                    return;
                }

                Livre liv = new Livre(
                    txtIdLivre.Text.Trim().ToUpper(),
                    txtTitre.Text.Trim(),
                    (int)numPages.Value
                );
                liv.modifier();
                actualiserTout();
                reinitialiserLiv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de modification : " + ex.Message);
            }
        }

        private void btnSupprimerLiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdLivre.Text))
                {
                    MessageBox.Show("Sélectionnez d'abord un livre à supprimer.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce livre ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Livre liv = new Livre();
                    liv.IdLivre = txtIdLivre.Text.Trim().ToUpper();
                    liv.supprimer();
                    actualiserTout();
                    reinitialiserLiv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message);
            }
        }

        private void txtRechercheLivre_TextChanged(object sender, EventArgs e)
        {
            ConnexionBD con = new ConnexionBD();
            string v = txtRechercheLivre.Text.Replace("'", "''");
            string rqt = "SELECT * FROM Livre WHERE titre LIKE '%" + v + "%' OR idLivre LIKE '%" + v + "%'";
            con.chargerDGV(rqt, dgvLivres);
        }

        private void dgvLivres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLivres.CurrentRow != null)
            {
                txtIdLivre.Text = dgvLivres.CurrentRow.Cells[0].Value.ToString();
                txtTitre.Text = dgvLivres.CurrentRow.Cells[1].Value.ToString();

                if (dgvLivres.CurrentRow.Cells[2].Value != DBNull.Value && dgvLivres.CurrentRow.Cells[2].Value != null)
                {
                    numPages.Value = Convert.ToDecimal(dgvLivres.CurrentRow.Cells[2].Value);
                }
                else
                {
                    numPages.Value = 0;
                }
            }
        }

        // =============================================
        // GESTION DES PUBLICATIONS
        // =============================================

        private void cmbLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chargementEnCours) return;

            if (cmbLivre.SelectedValue != null && cmbLivre.SelectedIndex >= 0)
            {
                string idLiv = cmbLivre.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(idLiv) && idLiv != "System.Data.DataRowView")
                {
                    try
                    {
                        ConnexionBD con = new ConnexionBD();
                        con.connecter();

                        string rqt = "SELECT nbrepage FROM Livre WHERE idLivre = '" + idLiv.Replace("'", "''") + "'";
                        OleDbCommand cmd = new OleDbCommand(rqt, con.cnx);
                        object nbPages = cmd.ExecuteScalar();

                        con.deconnecter();

                        if (nbPages != null && nbPages != DBNull.Value)
                        {
                            numPagesPub.Value = Convert.ToDecimal(nbPages);
                        }
                        else
                        {
                            numPagesPub.Value = 0;
                        }
                    }
                    catch
                    {
                        numPagesPub.Value = 0;
                    }
                }
            }
        }

        private void btnLier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuteur.SelectedValue == null || cmbLivre.SelectedValue == null ||
                    cmbAuteur.SelectedIndex < 0 || cmbLivre.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner un auteur et un livre.");
                    return;
                }

                int idAut = Convert.ToInt32(cmbAuteur.SelectedValue);
                string idLiv = cmbLivre.SelectedValue.ToString();

                Publication pub = new Publication(idAut, idLiv, dtpDatePub.Value, (int)numPagesPub.Value);
                pub.enregistrer();
                actualiserTout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur liaison : " + ex.Message);
            }
        }

        private void btnSupprimerPub_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuteur.SelectedValue == null || cmbLivre.SelectedValue == null ||
                    cmbAuteur.SelectedIndex < 0 || cmbLivre.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner une publication.");
                    return;
                }

                int idAut = Convert.ToInt32(cmbAuteur.SelectedValue);
                string idLiv = cmbLivre.SelectedValue.ToString();

                DialogResult dr = MessageBox.Show("Supprimer cette publication ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Publication pub = new Publication();
                    pub.IdAuteur = idAut;
                    pub.IdLivre = idLiv;
                    pub.supprimer();
                    actualiserTout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message);
            }
        }

        private void dgvPublications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPublications.CurrentRow != null)
            {
                try
                {
                    chargementEnCours = true;

                    cmbAuteur.SelectedValue = Convert.ToInt32(dgvPublications.CurrentRow.Cells[0].Value);
                    cmbLivre.SelectedValue = dgvPublications.CurrentRow.Cells[2].Value.ToString();

                    if (dgvPublications.CurrentRow.Cells[3].Value != DBNull.Value)
                    {
                        numPagesPub.Value = Convert.ToDecimal(dgvPublications.CurrentRow.Cells[3].Value);
                    }

                    if (dgvPublications.CurrentRow.Cells[4].Value != DBNull.Value)
                    {
                        dtpDatePub.Value = Convert.ToDateTime(dgvPublications.CurrentRow.Cells[4].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur sélection : " + ex.Message);
                }
                finally
                {
                    chargementEnCours = false;
                }
            }
        }

        // =============================================
        // UTILITAIRES
        // =============================================

        private void reinitialiserLiv()
        {
            txtIdLivre.Clear();
            txtTitre.Clear();
            numPages.Value = 0;
            txtRechercheLivre.Clear();
            txtIdLivre.Focus();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            reinitialiserLiv();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void UCGestionLivres_Load_1(object sender, EventArgs e) { }
        private void dgvLivres_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvPublications_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmbLivre_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dtpDatePub_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAuteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numPagesPub_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
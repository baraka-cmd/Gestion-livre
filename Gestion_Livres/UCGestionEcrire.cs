using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCGestionEcrire : UserControl
    {
        private bool chargementEnCours = false;

        public UCGestionEcrire()
        {
            InitializeComponent();
            cmbLivre.SelectedIndexChanged += new EventHandler(cmbLivre_SelectedIndexChanged);
        }

        private void UCGestionEcrire_Load(object sender, EventArgs e)
        {
            actualiserPublications();
        }

        
        private void actualiserPublications()
        {
            try
            {
                chargementEnCours = true;
                ConnexionBD con = new ConnexionBD();

                
                con.chargerCBO("SELECT idAuteur, nomAut FROM Auteur ORDER BY nomAut", cmbAuteur, "idAuteur", "nomAut");

                cmbLivre.SelectedIndexChanged -= cmbLivre_SelectedIndexChanged;
                con.chargerCBO("SELECT idLivre, titre FROM Livre ORDER BY titre", cmbLivre, "idLivre", "titre");
                cmbLivre.SelectedIndexChanged += cmbLivre_SelectedIndexChanged;

                
                string rqt = "SELECT Auteur.idAuteur, Auteur.nomAut, Livre.idLivre, Livre.titre, Ecrire.nbrePag, Ecrire.datPub " +
                             "FROM (Ecrire INNER JOIN Auteur ON Ecrire.idAuteur = Auteur.idAuteur) " +
                             "INNER JOIN Livre ON Ecrire.idLivre = Livre.idLivre " +
                             "ORDER BY Ecrire.datPub DESC";
                con.chargerDGV(rqt, dgvPublications);

                
                if (dgvPublications.Columns.Count >= 6)
                {
                    dgvPublications.Columns[0].HeaderText = "ID Auteur";
                    dgvPublications.Columns[1].HeaderText = "Nom Auteur";
                    dgvPublications.Columns[2].HeaderText = "ID Livre";
                    dgvPublications.Columns[3].HeaderText = "Titre Livre";
                    dgvPublications.Columns[4].HeaderText = "Pages";
                    dgvPublications.Columns[5].HeaderText = "Date Publication";
                }

                reinitialiser();
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

        
        private void cmbLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chargementEnCours || cmbLivre.SelectedIndex < 0) return;

            string idLiv = cmbLivre.SelectedValue.ToString();
            if (string.IsNullOrEmpty(idLiv) || idLiv == "System.Data.DataRowView") return;

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
                    MessageBox.Show("Livre trouvé mais aucun nombre de pages défini.", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                numPagesPub.Value = 0;
                MessageBox.Show("Erreur lors de la récupération des pages : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        public void Rafraichir()
        {
            actualiserPublications();
        }

        
        private void btnLier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuteur.SelectedIndex < 0 || cmbLivre.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner un auteur et un livre.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (cmbAuteur.SelectedValue == null || cmbLivre.SelectedValue == null)
                {
                    MessageBox.Show("Sélection invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Publication pub = new Publication(
                    Convert.ToInt32(cmbAuteur.SelectedValue),
                    cmbLivre.SelectedValue.ToString(),
                    dtpDatePub.Value,
                    (int)numPagesPub.Value
                );
                pub.enregistrer();
                actualiserPublications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la liaison : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnSupprimerPub_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuteur.SelectedIndex < 0 || cmbLivre.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner une publication.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("Supprimer cette publication ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Publication pub = new Publication();
                    pub.IdAuteur = Convert.ToInt32(cmbAuteur.SelectedValue);
                    pub.IdLivre = cmbLivre.SelectedValue.ToString();
                    pub.supprimer();
                    actualiserPublications();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message);
            }
        }

       
        private void dgvPublications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPublications.CurrentRow == null) return;

            try
            {
                chargementEnCours = true;

                
                string valIdAuteur = dgvPublications.CurrentRow.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(valIdAuteur))
                {
                    cmbAuteur.SelectedValue = Convert.ToInt32(valIdAuteur);
                }

                
                string valIdLivre = dgvPublications.CurrentRow.Cells[2].Value.ToString();
                if (!string.IsNullOrEmpty(valIdLivre))
                {
                    cmbLivre.SelectedValue = valIdLivre;
                }

                
                if (dgvPublications.CurrentRow.Cells[4].Value != DBNull.Value && dgvPublications.CurrentRow.Cells[4].Value != null)
                {
                    numPagesPub.Value = Convert.ToDecimal(dgvPublications.CurrentRow.Cells[4].Value);
                }
                else
                {
                    numPagesPub.Value = 0;
                }

               
                if (dgvPublications.CurrentRow.Cells[5].Value != DBNull.Value && dgvPublications.CurrentRow.Cells[5].Value != null)
                {
                    dtpDatePub.Value = Convert.ToDateTime(dgvPublications.CurrentRow.Cells[5].Value);
                }
                else
                {
                    dtpDatePub.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                chargementEnCours = false;
            }
        }

        
        private void reinitialiser()
        {
            cmbAuteur.SelectedIndex = -1;
            cmbLivre.SelectedIndex = -1;
            numPagesPub.Value = 0;
            dtpDatePub.Value = DateTime.Now;
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            reinitialiser();
        }
    }
}
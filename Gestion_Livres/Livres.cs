using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class Livres : UserControl
    {
        
        public Livres()
        {
            InitializeComponent();
            numPages.Minimum = 0;    
            numPages.Value = 0;      
        }
        

        private void Livres_Load(object sender, EventArgs e)
        {
            actualiserLivres();
        }

        
        private void actualiserLivres()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                con.chargerDGV("SELECT * FROM Livre ORDER BY idLivre", dgvLivres);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }
        }

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
                actualiserLivres();
                reinitialiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message);
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
                    actualiserLivres();
                    reinitialiser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            ConnexionBD con = new ConnexionBD();
            string v = txtRecherche.Text.Replace("'", "''");
            string rqt = "SELECT * FROM Livre WHERE titre LIKE '%" + v + "%' OR idLivre LIKE '%" + v + "%'";
            con.chargerDGV(rqt, dgvLivres);
        }

        

        
        private void reinitialiser()
        {
            txtIdLivre.Clear();
            txtTitre.Clear();
            numPages.Value = 0;
            txtRecherche.Clear();
            txtIdLivre.Focus();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            reinitialiser();
        }

       

        private void dgvLivres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvLivres.CurrentRow != null)
            {
                txtIdLivre.Text = dgvLivres.CurrentRow.Cells[0].Value.ToString();
                txtTitre.Text = dgvLivres.CurrentRow.Cells[1].Value.ToString();
                numPages.Value = (dgvLivres.CurrentRow.Cells[2].Value != DBNull.Value)
                    ? Convert.ToDecimal(dgvLivres.CurrentRow.Cells[2].Value) : 0;
            }
        }

        private void btnModifierLiv_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdLivre.Text))
                {
                    MessageBox.Show("Sélectionnez d'abord un livre à modifier.");
                    return;
                }

                Livre liv = new Livre(
                    txtIdLivre.Text.Trim().ToUpper(),
                    txtTitre.Text.Trim(),
                    (int)numPages.Value
                );
                liv.modifier();
                actualiserLivres();
                reinitialiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de modification : " + ex.Message);
            }
        }

        private void btnVider_Click_1(object sender, EventArgs e)
        {
            reinitialiser();
        }
    }
}
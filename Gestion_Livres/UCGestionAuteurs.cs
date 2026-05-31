using System;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCGestionAuteurs : UserControl
    {
        public UCGestionAuteurs()
        {
            InitializeComponent();
        }

        private void UCGestionAuteurs_Load(object sender, EventArgs e)
        {
            chargementDgvAut();
        }

        private void chargementDgvAut()
        {
            ConnexionBD con = new ConnexionBD();
            con.chargerDGV("SELECT * FROM Auteur", dgvAuteurs);
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Auteur aut = new Auteur(
                    int.Parse(txtIdAuteur.Text),
                    txtNomAut.Text.Trim().ToUpper(),
                    dtpDateNais.Value,
                    txtPostnomAut.Text.Trim().ToUpper(),
                    txtPrenomAut.Text.Trim()
                );
                aut.enregistrer();
                chargementDgvAut();
                viderChamp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message);
            }
        }

       
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Auteur aut = new Auteur(
                    int.Parse(txtIdAuteur.Text),
                    txtNomAut.Text.Trim().ToUpper(),
                    dtpDateNais.Value,
                    txtPostnomAut.Text.Trim().ToUpper(),
                    txtPrenomAut.Text.Trim()
                );
                aut.modifier();
                chargementDgvAut();
                viderChamp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de modification : " + ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Auteur aut = new Auteur();
                aut.IdAuteur = int.Parse(txtIdAuteur.Text);
                aut.supprimer();
                chargementDgvAut();
                viderChamp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de suppression : " + ex.Message);
            }
        }

    
        private void dgvAuteurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAuteurs.CurrentRow != null)
            {
                
                txtIdAuteur.Text = dgvAuteurs.CurrentRow.Cells[0].Value.ToString();

                
                txtNomAut.Text = dgvAuteurs.CurrentRow.Cells[1].Value.ToString();

                
                if (dgvAuteurs.CurrentRow.Cells[2].Value != DBNull.Value && dgvAuteurs.CurrentRow.Cells[2].Value != null)
                {
                    try
                    {
                        dtpDateNais.Value = Convert.ToDateTime(dgvAuteurs.CurrentRow.Cells[2].Value);
                    }
                    catch
                    {
                        dtpDateNais.Value = DateTime.Now;
                    }
                }
                else
                {
                    dtpDateNais.Value = DateTime.Now;
                }

               
                txtPostnomAut.Text = dgvAuteurs.CurrentRow.Cells[3].Value != DBNull.Value
                    ? dgvAuteurs.CurrentRow.Cells[3].Value.ToString() : "";

                txtPrenomAut.Text = dgvAuteurs.CurrentRow.Cells[4].Value != DBNull.Value
                    ? dgvAuteurs.CurrentRow.Cells[4].Value.ToString() : "";
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            ConnexionBD con = new ConnexionBD();
            string v = txtRecherche.Text.Replace("'", "''");
            string rqt = "SELECT * FROM Auteur WHERE nomAut LIKE '%" + v + "%' OR postnomAut LIKE '%" + v + "%' OR prenomAut LIKE '%" + v + "%' OR idAuteur LIKE '%" + v + "%'";
            con.chargerDGV(rqt, dgvAuteurs);
        }

        
        private void viderChamp()
        {
            txtIdAuteur.Clear();
            txtNomAut.Clear();
            txtPostnomAut.Clear();
            txtPrenomAut.Clear();
            dtpDateNais.Value = DateTime.Now;
            txtIdAuteur.Focus();
        }

        private void dgvAuteurs_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }

        // 1. RENDRE CETTE METHODE PUBLIQUE
        // C'est ce qui permet au Form1 de faire : uc.chargerStatistiques()
        public void chargerStatistiques()
        {
            // On remplit les labels avec les résultats des comptages
            lblTotalAuteurs.Text = compter("SELECT COUNT(*) FROM Auteur").ToString();
            lblTotalLivres.Text = compter("SELECT COUNT(*) FROM Livre").ToString();
            lblTotalPublications.Text = compter("SELECT COUNT(*) FROM Ecrire").ToString();

            // On charge aussi la petite grille des nouveautés
            ConnexionBD con = new ConnexionBD();
            con.chargerDGV("SELECT TOP 5 * FROM Livre ORDER BY idLivre DESC", dgvNouveautes);
        }

        // 2. FONCTION UTILITAIRE (Peut rester privée)
        private int compter(string sql)
        {
            int total = 0;
            ConnexionBD con = new ConnexionBD();
            try
            {
                con.connecter();
                con.cmd.Connection = con.cnx;
                con.cmd.CommandText = sql;
                total = (int)con.cmd.ExecuteScalar();
                con.deconnecter();
            }
            catch { total = 0; }
            return total;
        }

        // 3. EVENEMENT LOAD
        private void UCDashboard_Load(object sender, EventArgs e)
        {
            // On appelle la méthode publique au démarrage
            chargerStatistiques();
        }

        // 4. BOUTON ACTUALISER
        private void btnActualiserStat_Click(object sender, EventArgs e)
        {
            // On appelle la méthode publique
            chargerStatistiques();
            MessageBox.Show("Statistiques mises à jour avec succès !");
        }
    }
}
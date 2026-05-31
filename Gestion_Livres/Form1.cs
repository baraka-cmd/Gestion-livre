using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            // Au lancement, on simule un clic sur le bouton Dashboard pour tout initialiser
            btnNavDashboard_Click(null, null);
        }

        // Méthode pour charger les interfaces dans le panneau central
        public void ChargerInterface(UserControl interfaceCible)
        {
            pnlAffichage.Controls.Clear();
            interfaceCible.Dock = DockStyle.Fill;
            pnlAffichage.Controls.Add(interfaceCible);
        }

        // --- BOUTON DASHBOARD ---
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            UCDashboard uc = new UCDashboard();
            ChargerInterface(uc);
            uc.chargerStatistiques();
            SelectionnerMenu(btnNavDashboard);
        }

        // --- BOUTON AUTEURS ---
        private void btnNavAuteurs_Click(object sender, EventArgs e)
        {
            ChargerInterface(new UCGestionAuteurs());
            SelectionnerMenu(btnNavAuteurs);
        }

        // --- BOUTON LIVRES ---
        private void btnNavLivres_Click(object sender, EventArgs e)
        {
            ChargerInterface(new Livres());
            SelectionnerMenu(btnNavLivres);
        }


        // --- GESTION VISUELLE DU MENU ---
        private void SelectionnerMenu(Button btnActif)
        {
            // Liste de tous les boutons de navigation
            List<Button> boutons = new List<Button> 
            { 
                btnNavDashboard, 
                btnNavAuteurs, 
                btnNavLivres, 
                btnNavEcrire    // ✅ Ajouté
            };

            foreach (var btn in boutons)
            {
                btn.BackColor = Color.FromArgb(44, 62, 80);      // Couleur foncée UAGO
                btn.ForeColor = Color.FromArgb(236, 240, 241);   // Texte clair
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            // Couleur du bouton actif
            if (btnActif != null)
            {
                btnActif.BackColor = Color.FromArgb(52, 152, 219);  // Bleu UAGO
                btnActif.ForeColor = Color.White;
            }
        }

        private void btnNavEcrire_Click_1(object sender, EventArgs e)
        {
            ChargerInterface(new UCGestionEcrire());  // ✅ UserControl, pas Ecrire
            SelectionnerMenu(btnNavEcrire);
        }

        private void btnNavRapports_Click(object sender, EventArgs e)
        {
           
            ChargerInterface(new UCRapportCentre());
            SelectionnerMenu(btnNavRapports);

        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportCentre : UserControl
    {
        private Panel pnlHeader;
        private Label lblTitre;
        private Label lblSousTitre;
        private TableLayoutPanel tlpCartes;
        private Button btnRapport1, btnRapport2, btnRapport3, btnRapport4;
        private Button btnRapport5, btnRapport6, btnRapport7, btnRapport8;

        public UCRapportCentre()
        {
            InitializeComponent();
            this.Size = new Size(750, 520);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Load += UCRapportCentre_Load;
        }

        private void UCRapportCentre_Load(object sender, EventArgs e)
        {
            CreerInterface();
        }

        private void CreerInterface()
        {
            
            pnlHeader = new Panel();
            pnlHeader.Size = new Size(710, 80);
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.None;

            lblTitre = new Label();
            lblTitre.Text = "📊 Centre de Rapports";
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitre.Location = new Point(20, 10);
            lblTitre.AutoSize = true;

            lblSousTitre = new Label();
            lblSousTitre.Text = "Sélectionnez le rapport que vous souhaitez consulter";
            lblSousTitre.Font = new Font("Segoe UI", 11F);
            lblSousTitre.ForeColor = Color.FromArgb(127, 140, 141);
            lblSousTitre.Location = new Point(20, 45);
            lblSousTitre.AutoSize = true;

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

            
            tlpCartes = new TableLayoutPanel();
            tlpCartes.Size = new Size(710, 400);
            tlpCartes.Location = new Point(20, 110);
            tlpCartes.ColumnCount = 2;
            tlpCartes.RowCount = 4;
            tlpCartes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCartes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCartes.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCartes.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCartes.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCartes.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.Controls.Add(tlpCartes);

            
            btnRapport1 = CreerCarte("1", "📋 Répertoire des Auteurs", "Liste complète des auteurs enregistrés", Color.FromArgb(52, 152, 219));
            btnRapport2 = CreerCarte("2", "📚 Catalogue des Ouvrages", "Inventaire des livres disponibles", Color.FromArgb(46, 204, 113));
            btnRapport3 = CreerCarte("3", "✍️ Productions Littéraires", "Ouvrages regroupés par auteur", Color.FromArgb(230, 126, 34));
            btnRapport4 = CreerCarte("4", "📖 Fiche par Ouvrage", "Détail de chaque livre et auteurs", Color.FromArgb(155, 89, 182));
            btnRapport5 = CreerCarte("5", "⏳ Auteurs en Attente", "Auteurs sans publication", Color.FromArgb(231, 76, 60));
            btnRapport6 = CreerCarte("6", "❓ Ouvrages Non Attribués", "Livres sans auteur identifié", Color.FromArgb(243, 156, 18));
            btnRapport7 = CreerCarte("7", "📊 État du Stock", "Inventaire technique et statistiques", Color.FromArgb(26, 188, 156));
            btnRapport8 = CreerCarte("8", "📈 Bilan par Auteur", "Statistiques détaillées par auteur", Color.FromArgb(52, 73, 94));

           
            btnRapport1.Click += (s, ev) => OuvrirRapport("UCRapportAuteurs");
            btnRapport2.Click += (s, ev) => OuvrirRapport("UCRapportLivres");
            btnRapport3.Click += (s, ev) => OuvrirRapport("UCRapportPubAuteur");
            btnRapport4.Click += (s, ev) => OuvrirRapport("UCRapportLivresAuteurs");
            btnRapport5.Click += (s, ev) => OuvrirRapport("UCRapportAuteursSansPub");
            btnRapport6.Click += (s, ev) => OuvrirRapport("UCRapportLivresSansAuteur");
            btnRapport7.Click += (s, ev) => OuvrirRapport("UCRapportInventaire");
            btnRapport8.Click += (s, ev) => OuvrirRapport("UCRapportStatsAuteur");
        }

        /// <summary>
        /// 
        /// </summary>
        private Button CreerCarte(string numero, string titre, string description, Color couleur)
        {
            Button btn = new Button();
            btn.Size = new Size(335, 85);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI", 9F);
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(10);
            btn.Padding = new Padding(15, 0, 0, 0);
            btn.Text = "   " + titre + "\n   " + description;
            btn.ForeColor = Color.FromArgb(44, 62, 80);

         
            btn.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(couleur, 5))
                {
                    e.Graphics.DrawLine(pen, 0, 5, 0, btn.Height - 5);
                }
                
                using (SolidBrush brush = new SolidBrush(couleur))
                using (Font f = new Font("Segoe UI", 11F, FontStyle.Bold))
                {
                    e.Graphics.DrawString(numero, f, brush, 340, 8);
                }
            };

            
            btn.MouseEnter += (s, e) => { btn.BackColor = Color.FromArgb(245, 246, 250); };
            btn.MouseLeave += (s, e) => { btn.BackColor = Color.White; };

            tlpCartes.Controls.Add(btn);
            return btn;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OuvrirRapport(string nomRapport)
        {
            UserControl rapport = null;

           
            Form parentForm = this.FindForm();
            if (parentForm == null) return;

          
            Panel pnlAffichage = null;
            foreach (Control ctrl in parentForm.Controls)
            {
                if (ctrl is Panel && ctrl.Name == "pnlAffichage")
                {
                    pnlAffichage = (Panel)ctrl;
                    break;
                }
            }

            if (pnlAffichage == null) return;

            
            switch (nomRapport)
            {
                case "UCRapportAuteurs":
                    rapport = new UCRapportAuteurs();
                    break;
                case "UCRapportLivres":
                    rapport = new UCRapportLivres();
                    break;
                case "UCRapportPubAuteur":
                    rapport = new UCRapportPubAuteur();
                    break;
                case "UCRapportLivresAuteurs":
                    rapport = new UCRapportLivresAuteurs();
                    break;
                case "UCRapportAuteursSansPub":
                    rapport = new UCRapportAuteursSansPub();
                    break;
                case "UCRapportLivresSansAuteur":
                    rapport = new UCRapportLivresSansAuteur();
                    break;
                case "UCRapportInventaire":
                    rapport = new UCRapportInventaire();
                    break;
                case "UCRapportStatsAuteur":
                    rapport = new UCRapportStatsAuteur();
                    break;
            }

            if (rapport != null)
            {
                pnlAffichage.Controls.Clear();
                rapport.Dock = DockStyle.Fill;
                pnlAffichage.Controls.Add(rapport);
            }
        }
    }
}
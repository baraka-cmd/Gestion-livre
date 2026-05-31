using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportLivresSansAuteur : UserControl
    {
        private Panel pnlHeader, pnlStats, pnlActions, pnlMessage;
        private Label lblTitre, lblSousTitre, lblTotal, lblLabelTotal, lblMessage;
        private DataGridView dgvRapport;
        private Button btnImprimer, btnRetour;

        public UCRapportLivresSansAuteur()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Load += UCRapportLivresSansAuteur_Load;
            CreerInterface();
        }

        private void CreerInterface()
        {
           
            pnlHeader = new Panel
            {
                Size = new Size(670, 60),
                Location = new Point(20, 15),
                BackColor = Color.White
            };

            lblTitre = new Label
            {
                Text = "❓ Ouvrages Non Attribués",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            lblSousTitre = new Label
            {
                Text = "Livres sans auteur identifié dans le système",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, 35),
                AutoSize = true
            };

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

            
            pnlMessage = new Panel
            {
                Size = new Size(670, 70),
                Location = new Point(20, 85),
                BackColor = Color.FromArgb(213, 245, 227),
                Visible = false
            };
            pnlMessage.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(39, 174, 96), 5))
                    e.Graphics.DrawLine(pen, 0, 0, 0, pnlMessage.Height);
            };

            lblMessage = new Label
            {
                Text = "✅  Tous les livres ont au moins un auteur associé !",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 132, 73),
                Location = new Point(20, 22),
                AutoSize = true
            };

            pnlMessage.Controls.Add(lblMessage);
            this.Controls.Add(pnlMessage);

            
            pnlStats = new Panel
            {
                Size = new Size(670, 55),
                Location = new Point(20, 85),
                BackColor = Color.White
            };
            pnlStats.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(243, 156, 18), 4))
                    e.Graphics.DrawLine(pen, 0, 0, 0, pnlStats.Height);
            };

            lblLabelTotal = new Label
            {
                Text = "Livres sans Auteur",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(20, 8),
                AutoSize = true
            };

            lblTotal = new Label
            {
                Text = "0",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(243, 156, 18),
                Location = new Point(20, 25),
                AutoSize = true
            };

            pnlStats.Controls.Add(lblLabelTotal);
            pnlStats.Controls.Add(lblTotal);
            this.Controls.Add(pnlStats);

            
            dgvRapport = new DataGridView
            {
                Size = new Size(670, 260),
                Location = new Point(20, 150),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                EnableHeadersVisualStyles = false
            };

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(30, 40, 55),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Padding = new Padding(8, 0, 0, 0)
            };
            dgvRapport.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvRapport.ColumnHeadersHeight = 40;
            dgvRapport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(44, 62, 80),
                Padding = new Padding(8, 0, 0, 0),
                SelectionBackColor = Color.FromArgb(52, 152, 219),
                SelectionForeColor = Color.White
            };
            dgvRapport.RowsDefaultCellStyle = rowStyle;
            dgvRapport.RowTemplate.Height = 35;
            dgvRapport.GridColor = Color.FromArgb(230, 233, 237);

            this.Controls.Add(dgvRapport);

           
            pnlActions = new Panel
            {
                Size = new Size(670, 50),
                Location = new Point(20, 420),
                BackColor = Color.Transparent
            };

            btnRetour = CreerBouton("⬅  Retour", Color.FromArgb(149, 165, 166));
            btnRetour.Location = new Point(0, 10);
            btnRetour.Click += (s, ev) => RetourCentre();

            btnImprimer = CreerBouton("🖨️  Imprimer", Color.FromArgb(243, 156, 18));
            btnImprimer.Location = new Point(550, 10);
            btnImprimer.Click += (s, ev) => Imprimer();

            pnlActions.Controls.Add(btnRetour);
            pnlActions.Controls.Add(btnImprimer);
            this.Controls.Add(pnlActions);
        }

        private Button CreerBouton(string texte, Color couleur)
        {
            return new Button
            {
                Size = new Size(120, 35),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Text = texte,
                BackColor = couleur,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
        }

        private void UCRapportLivresSansAuteur_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        public void ChargerDonnees()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();

                
                string rqt = @"
                    SELECT Livre.idLivre AS [CODE], 
                           Livre.titre AS [TITRE DE L'OUVRAGE], 
                           Livre.nbrepage AS [NOMBRE DE PAGES]
                    FROM Livre 
                    LEFT JOIN Ecrire ON Livre.idLivre = Ecrire.idLivre
                    WHERE Ecrire.idLivre IS NULL
                    ORDER BY Livre.titre";

                con.chargerDGV(rqt, dgvRapport);

                
                int nbSansAuteur = dgvRapport.Rows.Count;
                lblTotal.Text = nbSansAuteur.ToString();

               
                if (nbSansAuteur == 0)
                {
                    pnlStats.Visible = false;
                    dgvRapport.Visible = false;
                    pnlMessage.Visible = true;
                    pnlMessage.Location = new Point(20, 85);
                }
                else
                {
                    pnlStats.Visible = true;
                    dgvRapport.Visible = true;
                    pnlMessage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void RetourCentre()
        {
            Form frm = this.FindForm();
            if (frm != null)
            {
                foreach (Control ctrl in frm.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == "pnlAffichage")
                    {
                        Panel pnl = (Panel)ctrl;
                        pnl.Controls.Clear();
                        UCRapportCentre centre = new UCRapportCentre();
                        centre.Dock = DockStyle.Fill;
                        pnl.Controls.Add(centre);
                        break;
                    }
                }
            }
        }

        private void Imprimer()
        {
            
            btnImprimer.Visible = false;
            btnRetour.Visible = false;
            pnlActions.Visible = false;

            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                ev.Graphics.DrawImage(bmp, 50, 50);
            };

       
            pd.EndPrint += (s, ev) =>
            {
                btnImprimer.Visible = true;
                btnRetour.Visible = true;
                pnlActions.Visible = true;
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
            ppd.ShowDialog();

            
            btnImprimer.Visible = true;
            btnRetour.Visible = true;
            pnlActions.Visible = true;
        }
    }
}
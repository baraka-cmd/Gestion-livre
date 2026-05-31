using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportInventaire : UserControl
    {
        private Panel pnlHeader, pnlActions;
        private Label lblTitre, lblSousTitre;
        private DataGridView dgvRapport;
        private Button btnImprimer, btnRetour;

     
        private Panel pnlCardTotal, pnlCardPages, pnlCardMoyenne;
        private Label lblIconTotal, lblValueTotal, lblLabelTotal;
        private Label lblIconPages, lblValuePages, lblLabelPages;
        private Label lblIconMoyenne, lblValueMoyenne, lblLabelMoyenne;

        public UCRapportInventaire()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Load += UCRapportInventaire_Load;
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
                Text = "📊 État du Stock",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            lblSousTitre = new Label
            {
                Text = "Inventaire technique avec statistiques globales",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, 35),
                AutoSize = true
            };

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

            
            pnlCardTotal = CreerCarteStat("📚", "0", "Total Livres", Color.FromArgb(52, 152, 219), 0);
            this.Controls.Add(pnlCardTotal);

            
            pnlCardPages = CreerCarteStat("📄", "0", "Total Pages", Color.FromArgb(230, 126, 34), 1);
            this.Controls.Add(pnlCardPages);

            
            pnlCardMoyenne = CreerCarteStat("📐", "0", "Moyenne Pages/Livre", Color.FromArgb(46, 204, 113), 2);
            this.Controls.Add(pnlCardMoyenne);

            
            dgvRapport = new DataGridView
            {
                Size = new Size(670, 210),
                Location = new Point(20, 200),
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

            btnImprimer = CreerBouton("🖨️  Imprimer", Color.FromArgb(26, 188, 156));
            btnImprimer.Location = new Point(550, 10);
            btnImprimer.Click += (s, ev) => Imprimer();

            pnlActions.Controls.Add(btnRetour);
            pnlActions.Controls.Add(btnImprimer);
            this.Controls.Add(pnlActions);
        }

        private Panel CreerCarteStat(string icone, string valeur, string label, Color couleur, int position)
        {
            Panel panel = new Panel
            {
                Size = new Size(210, 100),
                Location = new Point(20 + position * 225, 85),
                BackColor = Color.White
            };

            panel.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(couleur, 4))
                    e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height);
            };

      
            Label lblIcon = new Label
            {
                Text = icone,
                Font = new Font("Segoe UI", 28F),
                Location = new Point(15, 15),
                AutoSize = true
            };
            panel.Controls.Add(lblIcon);

        
            Label lblVal = new Label
            {
                Text = valeur,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = couleur,
                Location = new Point(70, 20),
                AutoSize = true,
                Name = "lblVal"
            };
            panel.Controls.Add(lblVal);

     
            Label lblLab = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, 65),
                AutoSize = true,
                Name = "lblLab"
            };
            panel.Controls.Add(lblLab);

            return panel;
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

        private void UCRapportInventaire_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        public void ChargerDonnees()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();

               
                string rqt = "SELECT idLivre AS [CODE], titre AS [TITRE DE L'OUVRAGE], nbrepage AS [NOMBRE DE PAGES] FROM Livre ORDER BY titre";
                con.chargerDGV(rqt, dgvRapport);

             
                int totalLivres = dgvRapport.Rows.Count;
                int totalPages = 0;

                foreach (DataGridViewRow row in dgvRapport.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                        totalPages += Convert.ToInt32(row.Cells[2].Value);
                }

                double moyenne = totalLivres > 0 ? Math.Round((double)totalPages / totalLivres, 2) : 0;

                
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Panel && ctrl.Name.StartsWith("pnlCard"))
                    {
                        Panel pnl = (Panel)ctrl;
                        foreach (Control lbl in pnl.Controls)
                        {
                            if (lbl is Label && lbl.Name == "lblVal")
                            {
                                // Trouver quel panneau
                                if (pnl == pnlCardTotal) lbl.Text = totalLivres.ToString();
                                else if (pnl == pnlCardPages) lbl.Text = totalPages.ToString();
                                else if (pnl == pnlCardMoyenne) lbl.Text = moyenne.ToString();
                            }
                        }
                    }
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
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportLivres : UserControl
    {
        private Panel pnlHeader, pnlStats, pnlActions;
        private Label lblTitre, lblSousTitre, lblTotal, lblLabelTotal;
        private DataGridView dgvRapport;
        private Button btnImprimer, btnRetour;

        public UCRapportLivres()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Load += UCRapportLivres_Load;
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
                Text = "\U0001F4DA Catalogue des Ouvrages",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            lblSousTitre = new Label
            {
                Text = "Inventaire complet des livres disponibles dans la bibliotheque",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, 35),
                AutoSize = true
            };

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

            
            pnlStats = new Panel
            {
                Size = new Size(670, 55),
                Location = new Point(20, 85),
                BackColor = Color.White
            };
            pnlStats.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(46, 204, 113), 4))
                    e.Graphics.DrawLine(pen, 0, 0, 0, pnlStats.Height);
            };

            lblLabelTotal = new Label
            {
                Text = "Total Ouvrages Enregistres",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(20, 8),
                AutoSize = true
            };

            lblTotal = new Label
            {
                Text = "0",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(46, 204, 113),
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

            btnRetour = CreerBouton("Retour", Color.FromArgb(149, 165, 166));
            btnRetour.Location = new Point(0, 10);
            btnRetour.Click += (s, ev) => RetourCentre();

            btnImprimer = CreerBouton("Imprimer", Color.FromArgb(46, 204, 113));
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
                Text = texte,
                BackColor = couleur,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
        }

        private void UCRapportLivres_Load(object sender, EventArgs e)
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

                DataTable dt = new DataTable();
                con.connecter();
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter("SELECT COUNT(*) FROM Livre", con.cnx);
                da.Fill(dt);
                con.deconnecter();

                if (dt.Rows.Count > 0)
                    lblTotal.Text = dt.Rows[0][0].ToString();
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
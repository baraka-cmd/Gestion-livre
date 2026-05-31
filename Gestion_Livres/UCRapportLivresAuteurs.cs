using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportLivresAuteurs : UserControl
    {
        private Panel pnlHeader, pnlActions;
        private Label lblTitre, lblSousTitre;
        private FlowLayoutPanel flpGroupes;
        private Button btnImprimer, btnRetour;

        public UCRapportLivresAuteurs()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.AutoScroll = true;
            this.Load += UCRapportLivresAuteurs_Load;
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
                Text = "📖 Fiche par Ouvrage",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            lblSousTitre = new Label
            {
                Text = "Détail de chaque livre avec le(s) auteur(s) associé(s)",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(15, 35),
                AutoSize = true
            };

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

         
            flpGroupes = new FlowLayoutPanel
            {
                Size = new Size(670, 350),
                Location = new Point(20, 85),
                AutoScroll = true,
                BackColor = Color.Transparent,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            this.Controls.Add(flpGroupes);

            
            pnlActions = new Panel
            {
                Size = new Size(670, 50),
                Location = new Point(20, 445),
                BackColor = Color.Transparent
            };

            btnRetour = CreerBouton("Retour", Color.FromArgb(149, 165, 166));
            btnRetour.Location = new Point(0, 10);
            btnRetour.Click += (s, ev) => RetourCentre();

            btnImprimer = CreerBouton("Imprimer", Color.FromArgb(155, 89, 182));
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

        private void UCRapportLivresAuteurs_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        public void ChargerDonnees()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                flpGroupes.Controls.Clear();

                string rqtLivres = @"
                    SELECT DISTINCT Livre.idLivre, Livre.titre, Livre.nbrepage
                    FROM (Livre INNER JOIN Ecrire ON Livre.idLivre = Ecrire.idLivre)
                    ORDER BY Livre.titre";

                con.connecter();
                OleDbDataAdapter daLivres = new OleDbDataAdapter(rqtLivres, con.cnx);
                DataTable dtLivres = new DataTable();
                daLivres.Fill(dtLivres);
                con.deconnecter();

                int yPosition = 0;

                foreach (DataRow rowLivre in dtLivres.Rows)
                {
                    string idLivre = rowLivre["idLivre"].ToString();
                    string titre = rowLivre["titre"].ToString();
                    int nbPages = Convert.ToInt32(rowLivre["nbrepage"]);

                    string rqtAuteurs = @"
                        SELECT Auteur.idAuteur, Auteur.nomAut, Auteur.postnomAut, Auteur.prenomAut
                        FROM (Auteur INNER JOIN Ecrire ON Auteur.idAuteur = Ecrire.idAuteur)
                        WHERE Ecrire.idLivre = '" + idLivre.Replace("'", "''") + "' ORDER BY Auteur.nomAut";

                    con.connecter();
                    OleDbDataAdapter daAuteurs = new OleDbDataAdapter(rqtAuteurs, con.cnx);
                    DataTable dtAuteurs = new DataTable();
                    daAuteurs.Fill(dtAuteurs);
                    con.deconnecter();

                    if (dtAuteurs.Rows.Count > 0)
                    {
                        
                        Panel pnlTitreLivre = new Panel
                        {
                            Size = new Size(640, 35),
                            Location = new Point(0, yPosition),
                            BackColor = Color.FromArgb(44, 62, 80)
                        };

                        Label lblTitreLivre = new Label
                        {
                            Text = "  " + titre + "  (" + nbPages + " pages - " + dtAuteurs.Rows.Count + " auteur(s))",
                            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                            ForeColor = Color.White,
                            Location = new Point(10, 7),
                            AutoSize = true
                        };

                        pnlTitreLivre.Controls.Add(lblTitreLivre);
                        flpGroupes.Controls.Add(pnlTitreLivre);

                        
                        DataGridView dgvAuteurs = new DataGridView
                        {
                            Size = new Size(640, dtAuteurs.Rows.Count * 35 + 40),
                            Location = new Point(0, yPosition + 35),
                            BackgroundColor = Color.White,
                            BorderStyle = BorderStyle.None,
                            AllowUserToAddRows = false,
                            AllowUserToDeleteRows = false,
                            ReadOnly = true,
                            RowHeadersVisible = false,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                            EnableHeadersVisualStyles = false,
                            DataSource = dtAuteurs
                        };

                       
                        DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
                        {
                            BackColor = Color.FromArgb(52, 73, 94),
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                            Padding = new Padding(5, 0, 0, 0)
                        };
                        dgvAuteurs.ColumnHeadersDefaultCellStyle = headerStyle;
                        dgvAuteurs.ColumnHeadersHeight = 32;
                        dgvAuteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                       
                        DataGridViewCellStyle rowStyle = new DataGridViewCellStyle
                        {
                            BackColor = Color.White,
                            ForeColor = Color.FromArgb(44, 62, 80),
                            Font = new Font("Segoe UI", 9F),
                            Padding = new Padding(5, 0, 0, 0),
                            SelectionBackColor = Color.FromArgb(52, 152, 219),
                            SelectionForeColor = Color.White
                        };
                        dgvAuteurs.RowsDefaultCellStyle = rowStyle;
                        dgvAuteurs.RowTemplate.Height = 30;
                        dgvAuteurs.GridColor = Color.FromArgb(230, 233, 237);

                        if (dgvAuteurs.Columns.Count >= 4)
                        {
                            dgvAuteurs.Columns[0].HeaderText = "ID";
                            dgvAuteurs.Columns[0].Width = 50;
                            dgvAuteurs.Columns[1].HeaderText = "Nom";
                            dgvAuteurs.Columns[2].HeaderText = "Post-Nom";
                            dgvAuteurs.Columns[3].HeaderText = "Prénom";
                        }

                        flpGroupes.Controls.Add(dgvAuteurs);

                        yPosition += 35 + dgvAuteurs.Height + 10;
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
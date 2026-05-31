using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportPubAuteur : UserControl
    {
        private Panel pnlHeader, pnlActions;
        private Label lblTitre, lblSousTitre;
        private FlowLayoutPanel flpGroupes;
        private Button btnImprimer, btnRetour;

        public UCRapportPubAuteur()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.AutoScroll = true;
            this.Load += UCRapportPubAuteur_Load;
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
                Text = "✍️ Productions Littéraires",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 10),
                AutoSize = true
            };

            lblSousTitre = new Label
            {
                Text = "Ouvrages publiés regroupés par auteur avec dates et volumes",
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

            btnImprimer = CreerBouton("Imprimer", Color.FromArgb(230, 126, 34));
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

        private void UCRapportPubAuteur_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        public void ChargerDonnees()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();
                flpGroupes.Controls.Clear();

                string rqtAuteurs = @"
                    SELECT DISTINCT Auteur.idAuteur, Auteur.nomAut, Auteur.postnomAut, Auteur.prenomAut
                    FROM (Auteur INNER JOIN Ecrire ON Auteur.idAuteur = Ecrire.idAuteur)
                    ORDER BY Auteur.nomAut";

                con.connecter();
                OleDbDataAdapter daAuteurs = new OleDbDataAdapter(rqtAuteurs, con.cnx);
                DataTable dtAuteurs = new DataTable();
                daAuteurs.Fill(dtAuteurs);
                con.deconnecter();

                foreach (DataRow rowAuteur in dtAuteurs.Rows)
                {
                    int idAuteur = Convert.ToInt32(rowAuteur["idAuteur"]);
                    string nomComplet = rowAuteur["nomAut"].ToString() + " " +
                                        rowAuteur["postnomAut"].ToString() + " " +
                                        rowAuteur["prenomAut"].ToString();

                    string rqtLivres = @"
                        SELECT Livre.titre, Ecrire.nbrePag, Ecrire.datPub
                        FROM (Ecrire INNER JOIN Livre ON Ecrire.idLivre = Livre.idLivre)
                        WHERE Ecrire.idAuteur = " + idAuteur + " ORDER BY Ecrire.datPub DESC";

                    con.connecter();
                    OleDbDataAdapter daLivres = new OleDbDataAdapter(rqtLivres, con.cnx);
                    DataTable dtLivres = new DataTable();
                    daLivres.Fill(dtLivres);
                    con.deconnecter();

                    if (dtLivres.Rows.Count > 0)
                    {
                    
                        Panel pnlAuteur = new Panel
                        {
                            Size = new Size(640, 35),
                            BackColor = Color.FromArgb(44, 62, 80)
                        };

                        Label lblAuteur = new Label
                        {
                            Text = "  " + nomComplet.Trim().ToUpper() + "  (" + dtLivres.Rows.Count + " ouvrage(s))",
                            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                            ForeColor = Color.White,
                            Location = new Point(10, 7),
                            AutoSize = true
                        };

                        pnlAuteur.Controls.Add(lblAuteur);
                        flpGroupes.Controls.Add(pnlAuteur);

                       
                        DataGridView dgvLivres = new DataGridView
                        {
                            Size = new Size(640, dtLivres.Rows.Count * 35 + 40),
                            BackgroundColor = Color.White,
                            BorderStyle = BorderStyle.None,
                            AllowUserToAddRows = false,
                            AllowUserToDeleteRows = false,
                            ReadOnly = true,
                            RowHeadersVisible = false,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                            EnableHeadersVisualStyles = false,
                            DataSource = dtLivres
                        };

                        
                        DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
                        {
                            BackColor = Color.FromArgb(52, 73, 94),
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                            Padding = new Padding(5, 0, 0, 0)
                        };
                        dgvLivres.ColumnHeadersDefaultCellStyle = headerStyle;
                        dgvLivres.ColumnHeadersHeight = 32;
                        dgvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                       
                        DataGridViewCellStyle rowStyle = new DataGridViewCellStyle
                        {
                            BackColor = Color.White,
                            ForeColor = Color.FromArgb(44, 62, 80),
                            Font = new Font("Segoe UI", 9F),
                            Padding = new Padding(5, 0, 0, 0),
                            SelectionBackColor = Color.FromArgb(52, 152, 219),
                            SelectionForeColor = Color.White
                        };
                        dgvLivres.RowsDefaultCellStyle = rowStyle;
                        dgvLivres.RowTemplate.Height = 30;
                        dgvLivres.GridColor = Color.FromArgb(230, 233, 237);

                        if (dgvLivres.Columns.Count >= 3)
                        {
                            dgvLivres.Columns[0].HeaderText = "Titre de l'Ouvrage";
                            dgvLivres.Columns[1].HeaderText = "Pages";
                            dgvLivres.Columns[2].HeaderText = "Date Publication";
                            dgvLivres.Columns[1].Width = 80;
                            dgvLivres.Columns[2].Width = 140;
                        }

                        flpGroupes.Controls.Add(dgvLivres);

                        
                        Panel spacer = new Panel { Size = new Size(640, 10), BackColor = Color.Transparent };
                        flpGroupes.Controls.Add(spacer);
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
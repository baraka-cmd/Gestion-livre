using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Livres
{
    public partial class UCRapportAuteurs : UserControl
    {
       
        private Panel pnlHeader;
        private Label lblTitre;
        private Label lblSousTitre;
        private Label lblTotal;
        private Label lblLabelTotal;
        private Panel pnlStats;
        private DataGridView dgvRapport;
        private Panel pnlActions;
        private Button btnImprimer;
        private Button btnRetour;

        public UCRapportAuteurs()
        {
            this.Size = new Size(710, 500);
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Load += UCRapportAuteurs_Load;
            CreerInterface();
        }

        private void CreerInterface()
        {
            
            pnlHeader = new Panel();
            pnlHeader.Size = new Size(670, 60);
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.None;

            lblTitre = new Label();
            lblTitre.Text = "📋 Répertoire des Auteurs";
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitre.Location = new Point(15, 10);
            lblTitre.AutoSize = true;

            lblSousTitre = new Label();
            lblSousTitre.Text = "Liste complète de tous les auteurs enregistrés dans le système";
            lblSousTitre.Font = new Font("Segoe UI", 9F);
            lblSousTitre.ForeColor = Color.FromArgb(127, 140, 141);
            lblSousTitre.Location = new Point(15, 35);
            lblSousTitre.AutoSize = true;

            pnlHeader.Controls.Add(lblTitre);
            pnlHeader.Controls.Add(lblSousTitre);
            this.Controls.Add(pnlHeader);

            
            pnlStats = new Panel();
            pnlStats.Size = new Size(670, 55);
            pnlStats.Location = new Point(20, 85);
            pnlStats.BackColor = Color.White;
            pnlStats.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(52, 152, 219), 4))
                {
                    e.Graphics.DrawLine(pen, 0, 0, 0, pnlStats.Height);
                }
            };

            lblLabelTotal = new Label();
            lblLabelTotal.Text = "Total Auteurs Enregistrés";
            lblLabelTotal.Font = new Font("Segoe UI", 10F);
            lblLabelTotal.ForeColor = Color.FromArgb(127, 140, 141);
            lblLabelTotal.Location = new Point(20, 8);
            lblLabelTotal.AutoSize = true;

            lblTotal = new Label();
            lblTotal.Text = "0";
            lblTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotal.Location = new Point(20, 25);
            lblTotal.AutoSize = true;

            pnlStats.Controls.Add(lblLabelTotal);
            pnlStats.Controls.Add(lblTotal);
            this.Controls.Add(pnlStats);

            
            dgvRapport = new DataGridView();
            dgvRapport.Size = new Size(670, 260);
            dgvRapport.Location = new Point(20, 150);
            dgvRapport.BackgroundColor = Color.White;
            dgvRapport.BorderStyle = BorderStyle.None;
            dgvRapport.AllowUserToAddRows = false;
            dgvRapport.AllowUserToDeleteRows = false;
            dgvRapport.ReadOnly = true;
            dgvRapport.RowHeadersVisible = false;
            dgvRapport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapport.EnableHeadersVisualStyles = false;

           
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(30, 40, 55);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Padding = new Padding(8, 0, 0, 0);
            dgvRapport.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvRapport.ColumnHeadersHeight = 40;
            dgvRapport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

         
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.Font = new Font("Segoe UI", 10F);
            rowStyle.ForeColor = Color.FromArgb(44, 62, 80);
            rowStyle.Padding = new Padding(8, 0, 0, 0);
            rowStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            rowStyle.SelectionForeColor = Color.White;
            dgvRapport.RowsDefaultCellStyle = rowStyle;
            dgvRapport.RowTemplate.Height = 35;
            dgvRapport.GridColor = Color.FromArgb(230, 233, 237);

            this.Controls.Add(dgvRapport);

            
            pnlActions = new Panel();
            pnlActions.Size = new Size(670, 50);
            pnlActions.Location = new Point(20, 420);
            pnlActions.BackColor = Color.Transparent;

            btnRetour = CreerBouton("⬅  Retour au Centre", Color.FromArgb(149, 165, 166));
            btnRetour.Location = new Point(0, 10);
            btnRetour.Click += (s, ev) => RetourCentre();

            btnImprimer = CreerBouton("🖨️  Imprimer", Color.FromArgb(52, 152, 219));
            btnImprimer.Location = new Point(550, 10);
            btnImprimer.Click += (s, ev) => Imprimer();

            pnlActions.Controls.Add(btnRetour);
            pnlActions.Controls.Add(btnImprimer);
            this.Controls.Add(pnlActions);
        }

        private Button CreerBouton(string texte, Color couleur)
        {
            Button btn = new Button();
            btn.Size = new Size(120, 35);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = couleur;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Text = texte;
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void UCRapportAuteurs_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        public void ChargerDonnees()
        {
            try
            {
                ConnexionBD con = new ConnexionBD();

                
                string rqt = "SELECT idAuteur AS [ID], nomAut AS [NOM], postnomAut AS [POST-NOM], prenomAut AS [PRÉNOM], dateNais AS [DATE NAISSANCE] FROM Auteur ORDER BY nomAut";
                con.chargerDGV(rqt, dgvRapport);

               
                DataTable dt = new DataTable();
                con.connecter();
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter("SELECT COUNT(*) FROM Auteur", con.cnx);
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
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                Panel pnlAffichage = null;
                foreach (Control ctrl in parentForm.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == "pnlAffichage")
                    {
                        pnlAffichage = (Panel)ctrl;
                        break;
                    }
                }
                if (pnlAffichage != null)
                {
                    pnlAffichage.Controls.Clear();
                    UCRapportCentre centre = new UCRapportCentre();
                    centre.Dock = DockStyle.Fill;
                    pnlAffichage.Controls.Add(centre);
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
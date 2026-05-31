namespace Gestion_Livres
{
    partial class UCDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitreDashboard = new System.Windows.Forms.Label();
            this.pnlCardLivres = new System.Windows.Forms.Panel();
            this.lblTotalLivres = new System.Windows.Forms.Label();
            this.lblIconLivres = new System.Windows.Forms.Label();
            this.lblLabelLivres = new System.Windows.Forms.Label();
            this.pnlCardAuteurs = new System.Windows.Forms.Panel();
            this.lblTotalAuteurs = new System.Windows.Forms.Label();
            this.lblIconAuteurs = new System.Windows.Forms.Label();
            this.lblLabelAuteurs = new System.Windows.Forms.Label();
            this.pnlCardPublications = new System.Windows.Forms.Panel();
            this.lblTotalPublications = new System.Windows.Forms.Label();
            this.lblIconPublications = new System.Windows.Forms.Label();
            this.lblLabelPublications = new System.Windows.Forms.Label();
            this.dgvNouveautes = new System.Windows.Forms.DataGridView();
            this.btnActualiserStat = new System.Windows.Forms.Button();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlCardLivres.SuspendLayout();
            this.pnlCardAuteurs.SuspendLayout();
            this.pnlCardPublications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNouveautes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreDashboard
            // 
            this.lblTitreDashboard.AutoSize = true;
            this.lblTitreDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitreDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitreDashboard.Location = new System.Drawing.Point(25, 20);
            this.lblTitreDashboard.Name = "lblTitreDashboard";
            this.lblTitreDashboard.Size = new System.Drawing.Size(259, 32);
            this.lblTitreDashboard.TabIndex = 0;
            this.lblTitreDashboard.Text = "Tableau de Bord UAGO";
            // 
            // pnlCardLivres
            // 
            this.pnlCardLivres.BackColor = System.Drawing.Color.White;
            this.pnlCardLivres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardLivres.Controls.Add(this.lblTotalLivres);
            this.pnlCardLivres.Controls.Add(this.lblIconLivres);
            this.pnlCardLivres.Controls.Add(this.lblLabelLivres);
            this.pnlCardLivres.Location = new System.Drawing.Point(30, 80);
            this.pnlCardLivres.Name = "pnlCardLivres";
            this.pnlCardLivres.Size = new System.Drawing.Size(200, 140);
            this.pnlCardLivres.TabIndex = 1;
            // 
            // lblTotalLivres
            // 
            this.lblTotalLivres.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalLivres.Location = new System.Drawing.Point(15, 70);
            this.lblTotalLivres.Name = "lblTotalLivres";
            this.lblTotalLivres.Size = new System.Drawing.Size(170, 51);
            this.lblTotalLivres.TabIndex = 2;
            this.lblTotalLivres.Text = "0";
            this.lblTotalLivres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconLivres
            // 
            this.lblIconLivres.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblIconLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblIconLivres.Location = new System.Drawing.Point(3, 10);
            this.lblIconLivres.Name = "lblIconLivres";
            this.lblIconLivres.Size = new System.Drawing.Size(194, 32);
            this.lblIconLivres.TabIndex = 1;
            this.lblIconLivres.Text = "📚";
            this.lblIconLivres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelLivres
            // 
            this.lblLabelLivres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLabelLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblLabelLivres.Location = new System.Drawing.Point(3, 45);
            this.lblLabelLivres.Name = "lblLabelLivres";
            this.lblLabelLivres.Size = new System.Drawing.Size(194, 25);
            this.lblLabelLivres.TabIndex = 0;
            this.lblLabelLivres.Text = "Ouvrages Enregistrés";
            this.lblLabelLivres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardAuteurs
            // 
            this.pnlCardAuteurs.BackColor = System.Drawing.Color.White;
            this.pnlCardAuteurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAuteurs.Controls.Add(this.lblTotalAuteurs);
            this.pnlCardAuteurs.Controls.Add(this.lblIconAuteurs);
            this.pnlCardAuteurs.Controls.Add(this.lblLabelAuteurs);
            this.pnlCardAuteurs.Location = new System.Drawing.Point(260, 80);
            this.pnlCardAuteurs.Name = "pnlCardAuteurs";
            this.pnlCardAuteurs.Size = new System.Drawing.Size(200, 140);
            this.pnlCardAuteurs.TabIndex = 2;
            // 
            // lblTotalAuteurs
            // 
            this.lblTotalAuteurs.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalAuteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalAuteurs.Location = new System.Drawing.Point(15, 70);
            this.lblTotalAuteurs.Name = "lblTotalAuteurs";
            this.lblTotalAuteurs.Size = new System.Drawing.Size(170, 51);
            this.lblTotalAuteurs.TabIndex = 3;
            this.lblTotalAuteurs.Text = "0";
            this.lblTotalAuteurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconAuteurs
            // 
            this.lblIconAuteurs.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblIconAuteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblIconAuteurs.Location = new System.Drawing.Point(3, 10);
            this.lblIconAuteurs.Name = "lblIconAuteurs";
            this.lblIconAuteurs.Size = new System.Drawing.Size(194, 32);
            this.lblIconAuteurs.TabIndex = 2;
            this.lblIconAuteurs.Text = "👥";
            this.lblIconAuteurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelAuteurs
            // 
            this.lblLabelAuteurs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLabelAuteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblLabelAuteurs.Location = new System.Drawing.Point(3, 45);
            this.lblLabelAuteurs.Name = "lblLabelAuteurs";
            this.lblLabelAuteurs.Size = new System.Drawing.Size(194, 25);
            this.lblLabelAuteurs.TabIndex = 1;
            this.lblLabelAuteurs.Text = "Auteurs Référencés";
            this.lblLabelAuteurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardPublications
            // 
            this.pnlCardPublications.BackColor = System.Drawing.Color.White;
            this.pnlCardPublications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPublications.Controls.Add(this.lblTotalPublications);
            this.pnlCardPublications.Controls.Add(this.lblIconPublications);
            this.pnlCardPublications.Controls.Add(this.lblLabelPublications);
            this.pnlCardPublications.Location = new System.Drawing.Point(490, 80);
            this.pnlCardPublications.Name = "pnlCardPublications";
            this.pnlCardPublications.Size = new System.Drawing.Size(200, 140);
            this.pnlCardPublications.TabIndex = 3;
            // 
            // lblTotalPublications
            // 
            this.lblTotalPublications.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalPublications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblTotalPublications.Location = new System.Drawing.Point(15, 70);
            this.lblTotalPublications.Name = "lblTotalPublications";
            this.lblTotalPublications.Size = new System.Drawing.Size(170, 51);
            this.lblTotalPublications.TabIndex = 4;
            this.lblTotalPublications.Text = "0";
            this.lblTotalPublications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconPublications
            // 
            this.lblIconPublications.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblIconPublications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblIconPublications.Location = new System.Drawing.Point(3, 10);
            this.lblIconPublications.Name = "lblIconPublications";
            this.lblIconPublications.Size = new System.Drawing.Size(194, 32);
            this.lblIconPublications.TabIndex = 3;
            this.lblIconPublications.Text = "📝";
            this.lblIconPublications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelPublications
            // 
            this.lblLabelPublications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLabelPublications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblLabelPublications.Location = new System.Drawing.Point(3, 45);
            this.lblLabelPublications.Name = "lblLabelPublications";
            this.lblLabelPublications.Size = new System.Drawing.Size(194, 25);
            this.lblLabelPublications.TabIndex = 2;
            this.lblLabelPublications.Text = "Publications Établies";
            this.lblLabelPublications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNouveautes
            // 
            this.dgvNouveautes.AllowUserToAddRows = false;
            this.dgvNouveautes.AllowUserToDeleteRows = false;
            this.dgvNouveautes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNouveautes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNouveautes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNouveautes.ColumnHeadersHeight = 35;
            this.dgvNouveautes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNouveautes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNouveautes.EnableHeadersVisualStyles = false;
            this.dgvNouveautes.Location = new System.Drawing.Point(30, 250);
            this.dgvNouveautes.Name = "dgvNouveautes";
            this.dgvNouveautes.ReadOnly = true;
            this.dgvNouveautes.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNouveautes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNouveautes.RowTemplate.Height = 30;
            this.dgvNouveautes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNouveautes.Size = new System.Drawing.Size(660, 200);
            this.dgvNouveautes.TabIndex = 4;
            // 
            // btnActualiserStat
            // 
            this.btnActualiserStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnActualiserStat.FlatAppearance.BorderSize = 0;
            this.btnActualiserStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiserStat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualiserStat.ForeColor = System.Drawing.Color.White;
            this.btnActualiserStat.Location = new System.Drawing.Point(560, 20);
            this.btnActualiserStat.Name = "btnActualiserStat";
            this.btnActualiserStat.Size = new System.Drawing.Size(130, 35);
            this.btnActualiserStat.TabIndex = 5;
            this.btnActualiserStat.Text = "Actualiser";
            this.btnActualiserStat.UseVisualStyleBackColor = false;
            this.btnActualiserStat.Click += new System.EventHandler(this.btnActualiserStat_Click);
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSousTitre.Location = new System.Drawing.Point(27, 52);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(225, 19);
            this.lblSousTitre.TabIndex = 6;
            this.lblSousTitre.Text = "Bienvenue sur votre espace de gestion";
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.btnActualiserStat);
            this.Controls.Add(this.dgvNouveautes);
            this.Controls.Add(this.pnlCardPublications);
            this.Controls.Add(this.pnlCardAuteurs);
            this.Controls.Add(this.pnlCardLivres);
            this.Controls.Add(this.lblTitreDashboard);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(720, 480);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            this.pnlCardLivres.ResumeLayout(false);
            this.pnlCardAuteurs.ResumeLayout(false);
            this.pnlCardPublications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNouveautes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreDashboard;
        private System.Windows.Forms.Panel pnlCardLivres;
        private System.Windows.Forms.Label lblTotalLivres;
        private System.Windows.Forms.Label lblIconLivres;
        private System.Windows.Forms.Label lblLabelLivres;
        private System.Windows.Forms.Panel pnlCardAuteurs;
        private System.Windows.Forms.Label lblTotalAuteurs;
        private System.Windows.Forms.Label lblIconAuteurs;
        private System.Windows.Forms.Label lblLabelAuteurs;
        private System.Windows.Forms.Panel pnlCardPublications;
        private System.Windows.Forms.Label lblTotalPublications;
        private System.Windows.Forms.Label lblIconPublications;
        private System.Windows.Forms.Label lblLabelPublications;
        private System.Windows.Forms.DataGridView dgvNouveautes;
        private System.Windows.Forms.Button btnActualiserStat;
        private System.Windows.Forms.Label lblSousTitre;
    }
}
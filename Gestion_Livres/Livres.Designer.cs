namespace Gestion_Livres
{
    partial class Livres
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
            this.gbSaisie = new System.Windows.Forms.GroupBox();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.txtIdLivre = new System.Windows.Forms.TextBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSupprimerLiv = new System.Windows.Forms.Button();
            this.btnModifierLiv = new System.Windows.Forms.Button();
            this.btnAjouterLiv = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.gbSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSaisie
            // 
            this.gbSaisie.BackColor = System.Drawing.Color.White;
            this.gbSaisie.Controls.Add(this.numPages);
            this.gbSaisie.Controls.Add(this.txtIdLivre);
            this.gbSaisie.Controls.Add(this.btnVider);
            this.gbSaisie.Controls.Add(this.btnSupprimerLiv);
            this.gbSaisie.Controls.Add(this.btnModifierLiv);
            this.gbSaisie.Controls.Add(this.btnAjouterLiv);
            this.gbSaisie.Controls.Add(this.lblPages);
            this.gbSaisie.Controls.Add(this.txtTitre);
            this.gbSaisie.Controls.Add(this.lblTitre);
            this.gbSaisie.Controls.Add(this.lblId);
            this.gbSaisie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gbSaisie.Location = new System.Drawing.Point(15, 55);
            this.gbSaisie.Name = "gbSaisie";
            this.gbSaisie.Size = new System.Drawing.Size(700, 200);
            this.gbSaisie.TabIndex = 0;
            this.gbSaisie.TabStop = false;
            this.gbSaisie.Text = "  Formulaire de Saisie - Livre  ";
            // 
            // numPages
            // 
            this.numPages.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPages.Location = new System.Drawing.Point(140, 140);
            this.numPages.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
                    this.numPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
                    this.numPages.Name = "numPages";
                    this.numPages.Size = new System.Drawing.Size(100, 27);
                    this.numPages.TabIndex = 17;
                    this.numPages.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtIdLivre
            // 
            this.txtIdLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdLivre.Location = new System.Drawing.Point(140, 30);
            this.txtIdLivre.Name = "txtIdLivre";
            this.txtIdLivre.Size = new System.Drawing.Size(220, 27);
            this.txtIdLivre.TabIndex = 11;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVider.FlatAppearance.BorderSize = 0;
            this.btnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(570, 150);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(110, 35);
            this.btnVider.TabIndex = 16;
            this.btnVider.Text = "Effacer";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click_1);
            // 
            // btnSupprimerLiv
            // 
            this.btnSupprimerLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerLiv.FlatAppearance.BorderSize = 0;
            this.btnSupprimerLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerLiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerLiv.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerLiv.Location = new System.Drawing.Point(450, 150);
            this.btnSupprimerLiv.Name = "btnSupprimerLiv";
            this.btnSupprimerLiv.Size = new System.Drawing.Size(110, 35);
            this.btnSupprimerLiv.TabIndex = 15;
            this.btnSupprimerLiv.Text = "Supprimer";
            this.btnSupprimerLiv.UseVisualStyleBackColor = false;
            this.btnSupprimerLiv.Click += new System.EventHandler(this.btnSupprimerLiv_Click);
            // 
            // btnModifierLiv
            // 
            this.btnModifierLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnModifierLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierLiv.FlatAppearance.BorderSize = 0;
            this.btnModifierLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierLiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifierLiv.ForeColor = System.Drawing.Color.White;
            this.btnModifierLiv.Location = new System.Drawing.Point(330, 150);
            this.btnModifierLiv.Name = "btnModifierLiv";
            this.btnModifierLiv.Size = new System.Drawing.Size(110, 35);
            this.btnModifierLiv.TabIndex = 14;
            this.btnModifierLiv.Text = "Modifier";
            this.btnModifierLiv.UseVisualStyleBackColor = false;
            this.btnModifierLiv.Click += new System.EventHandler(this.btnModifierLiv_Click_1);
            // 
            // btnAjouterLiv
            // 
            this.btnAjouterLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterLiv.FlatAppearance.BorderSize = 0;
            this.btnAjouterLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterLiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouterLiv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterLiv.Location = new System.Drawing.Point(210, 150);
            this.btnAjouterLiv.Name = "btnAjouterLiv";
            this.btnAjouterLiv.Size = new System.Drawing.Size(110, 35);
            this.btnAjouterLiv.TabIndex = 13;
            this.btnAjouterLiv.Text = "Ajouter";
            this.btnAjouterLiv.UseVisualStyleBackColor = false;
            this.btnAjouterLiv.Click += new System.EventHandler(this.btnAjouterLiv_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPages.Location = new System.Drawing.Point(30, 142);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(106, 20);
            this.lblPages.TabIndex = 7;
            this.lblPages.Text = "Nb de Pages :";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTitre.Location = new System.Drawing.Point(140, 80);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(540, 27);
            this.txtTitre.TabIndex = 12;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitre.Location = new System.Drawing.Point(77, 83);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(52, 20);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Titre :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblId.Location = new System.Drawing.Point(20, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 20);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Code du Livre :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRecherche.Location = new System.Drawing.Point(515, 18);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(200, 27);
            this.txtRecherche.TabIndex = 14;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRecherche.Location = new System.Drawing.Point(420, 21);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(84, 20);
            this.lblRecherche.TabIndex = 15;
            this.lblRecherche.Text = "Recherche :";
            // 
            // dgvLivres
            // 
            this.dgvLivres.AllowUserToAddRows = false;
            this.dgvLivres.AllowUserToDeleteRows = false;
            this.dgvLivres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivres.BackgroundColor = System.Drawing.Color.White;
            this.dgvLivres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgvLivres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivres.ColumnHeadersHeight = 40;
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLivres.EnableHeadersVisualStyles = false;
            this.dgvLivres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvLivres.Location = new System.Drawing.Point(15, 270);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.ReadOnly = true;
            this.dgvLivres.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLivres.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivres.RowTemplate.Height = 35;
            this.dgvLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivres.Size = new System.Drawing.Size(700, 220);
            this.dgvLivres.TabIndex = 15;
            this.dgvLivres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivres_CellContentClick);
            // 
            // Livres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.dgvLivres);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.gbSaisie);
            this.Name = "Livres";
            this.Size = new System.Drawing.Size(730, 505);
            this.Load += new System.EventHandler(this.Livres_Load);
            this.gbSaisie.ResumeLayout(false);
            this.gbSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaisie;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.TextBox txtIdLivre;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSupprimerLiv;
        private System.Windows.Forms.Button btnModifierLiv;
        private System.Windows.Forms.Button btnAjouterLiv;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.DataGridView dgvLivres;
    }
}
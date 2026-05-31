namespace Gestion_Livres
{
    partial class UCGestionEcrire
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgvPublications = new System.Windows.Forms.DataGridView();
            this.gbSaisie = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimerPub = new System.Windows.Forms.Button();
            this.btnLier = new System.Windows.Forms.Button();
            this.numPagesPub = new System.Windows.Forms.NumericUpDown();
            this.dtpDatePub = new System.Windows.Forms.DateTimePicker();
            this.cmbLivre = new System.Windows.Forms.ComboBox();
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblLivre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublications)).BeginInit();
            this.gbSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagesPub)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(248, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Publications";
            // 
            // dgvPublications
            // 
            this.dgvPublications.AllowUserToAddRows = false;
            this.dgvPublications.AllowUserToDeleteRows = false;
            this.dgvPublications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublications.BackgroundColor = System.Drawing.Color.White;
            this.dgvPublications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvPublications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPublications.ColumnHeadersHeight = 38;
            this.dgvPublications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPublications.EnableHeadersVisualStyles = false;
            this.dgvPublications.Location = new System.Drawing.Point(20, 295);
            this.dgvPublications.Name = "dgvPublications";
            this.dgvPublications.ReadOnly = true;
            this.dgvPublications.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPublications.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublications.RowTemplate.Height = 32;
            this.dgvPublications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublications.Size = new System.Drawing.Size(710, 210);
            this.dgvPublications.TabIndex = 20;
            this.dgvPublications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublications_CellClick);
            // 
            // gbSaisie
            // 
            this.gbSaisie.BackColor = System.Drawing.Color.White;
            this.gbSaisie.Controls.Add(this.btnEffacer);
            this.gbSaisie.Controls.Add(this.btnSupprimerPub);
            this.gbSaisie.Controls.Add(this.btnLier);
            this.gbSaisie.Controls.Add(this.numPagesPub);
            this.gbSaisie.Controls.Add(this.dtpDatePub);
            this.gbSaisie.Controls.Add(this.cmbLivre);
            this.gbSaisie.Controls.Add(this.cmbAuteur);
            this.gbSaisie.Controls.Add(this.lblPages);
            this.gbSaisie.Controls.Add(this.lblLivre);
            this.gbSaisie.Controls.Add(this.lblDate);
            this.gbSaisie.Controls.Add(this.lblAuteur);
            this.gbSaisie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gbSaisie.Location = new System.Drawing.Point(20, 55);
            this.gbSaisie.Name = "gbSaisie";
            this.gbSaisie.Size = new System.Drawing.Size(710, 220);
            this.gbSaisie.TabIndex = 21;
            this.gbSaisie.TabStop = false;
            this.gbSaisie.Text = "Formulaire de Publication";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(570, 175);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(110, 35);
            this.btnEffacer.TabIndex = 31;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnSupprimerPub
            // 
            this.btnSupprimerPub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerPub.FlatAppearance.BorderSize = 0;
            this.btnSupprimerPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerPub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerPub.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerPub.Location = new System.Drawing.Point(570, 130);
            this.btnSupprimerPub.Name = "btnSupprimerPub";
            this.btnSupprimerPub.Size = new System.Drawing.Size(110, 35);
            this.btnSupprimerPub.TabIndex = 30;
            this.btnSupprimerPub.Text = "Supprimer";
            this.btnSupprimerPub.UseVisualStyleBackColor = false;
            this.btnSupprimerPub.Click += new System.EventHandler(this.btnSupprimerPub_Click);
            // 
            // btnLier
            // 
            this.btnLier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLier.FlatAppearance.BorderSize = 0;
            this.btnLier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLier.ForeColor = System.Drawing.Color.White;
            this.btnLier.Location = new System.Drawing.Point(570, 85);
            this.btnLier.Name = "btnLier";
            this.btnLier.Size = new System.Drawing.Size(110, 35);
            this.btnLier.TabIndex = 29;
            this.btnLier.Text = "Enregistrer";
            this.btnLier.UseVisualStyleBackColor = false;
            this.btnLier.Click += new System.EventHandler(this.btnLier_Click);
            // 
            // numPagesPub
            // 
            this.numPagesPub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPagesPub.Location = new System.Drawing.Point(180, 183);
            this.numPagesPub.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
                    this.numPagesPub.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
                    this.numPagesPub.Name = "numPagesPub";
                    this.numPagesPub.Size = new System.Drawing.Size(120, 27);
                    this.numPagesPub.TabIndex = 28;
            // 
            // dtpDatePub
            // 
            this.dtpDatePub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDatePub.Location = new System.Drawing.Point(180, 140);
            this.dtpDatePub.Name = "dtpDatePub";
            this.dtpDatePub.Size = new System.Drawing.Size(280, 27);
            this.dtpDatePub.TabIndex = 27;
            // 
            // cmbLivre
            // 
            this.cmbLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbLivre.FormattingEnabled = true;
            this.cmbLivre.Location = new System.Drawing.Point(180, 97);
            this.cmbLivre.Name = "cmbLivre";
            this.cmbLivre.Size = new System.Drawing.Size(280, 28);
            this.cmbLivre.TabIndex = 26;
            // 
            // cmbAuteur
            // 
            this.cmbAuteur.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(180, 55);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(280, 28);
            this.cmbAuteur.TabIndex = 25;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPages.Location = new System.Drawing.Point(60, 185);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(105, 20);
            this.lblPages.TabIndex = 24;
            this.lblPages.Text = "Nb de Pages :";
            // 
            // lblLivre
            // 
            this.lblLivre.AutoSize = true;
            this.lblLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLivre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLivre.Location = new System.Drawing.Point(111, 100);
            this.lblLivre.Name = "lblLivre";
            this.lblLivre.Size = new System.Drawing.Size(54, 20);
            this.lblLivre.TabIndex = 23;
            this.lblLivre.Text = "Livre :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDate.Location = new System.Drawing.Point(33, 143);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 20);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date Publication :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAuteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAuteur.Location = new System.Drawing.Point(97, 58);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(68, 20);
            this.lblAuteur.TabIndex = 21;
            this.lblAuteur.Text = "Auteur :";
            // 
            // UCGestionEcrire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.gbSaisie);
            this.Controls.Add(this.dgvPublications);
            this.Controls.Add(this.lblTitre);
            this.Name = "UCGestionEcrire";
            this.Size = new System.Drawing.Size(750, 520);
            this.Load += new System.EventHandler(this.UCGestionEcrire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublications)).EndInit();
            this.gbSaisie.ResumeLayout(false);
            this.gbSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagesPub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvPublications;
        private System.Windows.Forms.GroupBox gbSaisie;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimerPub;
        private System.Windows.Forms.Button btnLier;
        private System.Windows.Forms.NumericUpDown numPagesPub;
        private System.Windows.Forms.DateTimePicker dtpDatePub;
        private System.Windows.Forms.ComboBox cmbLivre;
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblLivre;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAuteur;
    }
}
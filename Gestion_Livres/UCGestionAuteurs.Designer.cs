namespace Gestion_Livres
{
    partial class UCGestionAuteurs
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
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtPrenomAut = new System.Windows.Forms.TextBox();
            this.txtPostnomAut = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblPostnom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtIdAuteur = new System.Windows.Forms.TextBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dtpDateNais = new System.Windows.Forms.DateTimePicker();
            this.txtNomAut = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvAuteurs = new System.Windows.Forms.DataGridView();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.gbSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSaisie
            // 
            this.gbSaisie.BackColor = System.Drawing.Color.White;
            this.gbSaisie.Controls.Add(this.lblDate);
            this.gbSaisie.Controls.Add(this.lblPrenom);
            this.gbSaisie.Controls.Add(this.lblPostnom);
            this.gbSaisie.Controls.Add(this.txtPrenomAut);
            this.gbSaisie.Controls.Add(this.txtPostnomAut);
            this.gbSaisie.Controls.Add(this.txtIdAuteur);
            this.gbSaisie.Controls.Add(this.btnEffacer);
            this.gbSaisie.Controls.Add(this.btnSupprimer);
            this.gbSaisie.Controls.Add(this.btnModifier);
            this.gbSaisie.Controls.Add(this.btnAjouter);
            this.gbSaisie.Controls.Add(this.dtpDateNais);
            this.gbSaisie.Controls.Add(this.txtNomAut);
            this.gbSaisie.Controls.Add(this.lblNom);
            this.gbSaisie.Controls.Add(this.lblId);
            this.gbSaisie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaisie.Location = new System.Drawing.Point(20, 55);
            this.gbSaisie.Name = "gbSaisie";
            this.gbSaisie.Size = new System.Drawing.Size(730, 220);
            this.gbSaisie.TabIndex = 0;
            this.gbSaisie.TabStop = false;
            this.gbSaisie.Text = "Formulaire de Saisie";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(492, 18);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(220, 27);
            this.txtRecherche.TabIndex = 10;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRecherche.Location = new System.Drawing.Point(402, 21);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(84, 20);
            this.lblRecherche.TabIndex = 11;
            this.lblRecherche.Text = "Recherche :";
            // 
            // txtPrenomAut
            // 
            this.txtPrenomAut.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPrenomAut.Location = new System.Drawing.Point(140, 135);
            this.txtPrenomAut.Name = "txtPrenomAut";
            this.txtPrenomAut.Size = new System.Drawing.Size(250, 27);
            this.txtPrenomAut.TabIndex = 13;
            // 
            // txtPostnomAut
            // 
            this.txtPostnomAut.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPostnomAut.Location = new System.Drawing.Point(140, 95);
            this.txtPostnomAut.Name = "txtPostnomAut";
            this.txtPostnomAut.Size = new System.Drawing.Size(250, 27);
            this.txtPostnomAut.TabIndex = 12;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPrenom.Location = new System.Drawing.Point(55, 138);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 20);
            this.lblPrenom.TabIndex = 15;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblPostnom
            // 
            this.lblPostnom.AutoSize = true;
            this.lblPostnom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPostnom.Location = new System.Drawing.Point(36, 98);
            this.lblPostnom.Name = "lblPostnom";
            this.lblPostnom.Size = new System.Drawing.Size(88, 20);
            this.lblPostnom.TabIndex = 14;
            this.lblPostnom.Text = "Post-Nom :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDate.Location = new System.Drawing.Point(450, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 20);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date de Naissance :";
            // 
            // txtIdAuteur
            // 
            this.txtIdAuteur.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdAuteur.Location = new System.Drawing.Point(140, 22);
            this.txtIdAuteur.Name = "txtIdAuteur";
            this.txtIdAuteur.Size = new System.Drawing.Size(100, 27);
            this.txtIdAuteur.TabIndex = 2;
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(598, 172);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(110, 35);
            this.btnEffacer.TabIndex = 9;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(478, 172);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 35);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(358, 172);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 35);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(238, 172);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 35);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpDateNais
            // 
            this.dtpDateNais.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpDateNais.Location = new System.Drawing.Point(595, 58);
            this.dtpDateNais.Name = "dtpDateNais";
            this.dtpDateNais.Size = new System.Drawing.Size(120, 27);
            this.dtpDateNais.TabIndex = 5;
            // 
            // txtNomAut
            // 
            this.txtNomAut.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNomAut.Location = new System.Drawing.Point(140, 58);
            this.txtNomAut.Name = "txtNomAut";
            this.txtNomAut.Size = new System.Drawing.Size(250, 27);
            this.txtNomAut.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNom.Location = new System.Drawing.Point(72, 61);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 20);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblId.Location = new System.Drawing.Point(33, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Auteur :";
            // 
            // dgvAuteurs
            // 
            this.dgvAuteurs.AllowUserToAddRows = false;
            this.dgvAuteurs.AllowUserToDeleteRows = false;
            this.dgvAuteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuteurs.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuteurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAuteurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuteurs.ColumnHeadersHeight = 40;
            this.dgvAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuteurs.EnableHeadersVisualStyles = false;
            this.dgvAuteurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvAuteurs.Location = new System.Drawing.Point(20, 290);
            this.dgvAuteurs.Name = "dgvAuteurs";
            this.dgvAuteurs.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAuteurs.RowHeadersVisible = false;
            this.dgvAuteurs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuteurs.RowTemplate.Height = 35;
            this.dgvAuteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuteurs.Size = new System.Drawing.Size(730, 280);
            this.dgvAuteurs.TabIndex = 1;
            this.dgvAuteurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuteurs_CellClick);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitre.Location = new System.Drawing.Point(15, 10);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(220, 30);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Gestion des Auteurs";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblStats.Location = new System.Drawing.Point(20, 575);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(117, 19);
            this.lblStats.TabIndex = 13;
            this.lblStats.Text = "Total : 0 auteur(s)";
            // 
            // UCGestionAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvAuteurs);
            this.Controls.Add(this.gbSaisie);
            this.Name = "UCGestionAuteurs";
            this.Size = new System.Drawing.Size(770, 605);
            this.Load += new System.EventHandler(this.UCGestionAuteurs_Load);
            this.gbSaisie.ResumeLayout(false);
            this.gbSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaisie;
        private System.Windows.Forms.DataGridView dgvAuteurs;
        private System.Windows.Forms.TextBox txtIdAuteur;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dtpDateNais;
        private System.Windows.Forms.TextBox txtNomAut;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.TextBox txtPrenomAut;
        private System.Windows.Forms.TextBox txtPostnomAut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblPostnom;
    }
}
namespace Gestion_Livres
{
    partial class UCGestionLivres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRechercheLivre = new System.Windows.Forms.TextBox();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.gbSaisie = new System.Windows.Forms.GroupBox();
            this.panelLivre = new System.Windows.Forms.Panel();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.txtIdLivre = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panelBoutonsLivres = new System.Windows.Forms.Panel();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimerLiv = new System.Windows.Forms.Button();
            this.btnModifierLiv = new System.Windows.Forms.Button();
            this.btnAjouterLiv = new System.Windows.Forms.Button();
            this.tabPublications = new System.Windows.Forms.TabPage();
            this.panelPub = new System.Windows.Forms.Panel();
            this.lblPagesPub = new System.Windows.Forms.Label();
            this.lblLivre = new System.Windows.Forms.Label();
            this.lblDatePub = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.numPagesPub = new System.Windows.Forms.NumericUpDown();
            this.dtpDatePub = new System.Windows.Forms.DateTimePicker();
            this.cmbLivre = new System.Windows.Forms.ComboBox();
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.panelBoutonsPub = new System.Windows.Forms.Panel();
            this.btnSupprimerPub = new System.Windows.Forms.Button();
            this.btnLier = new System.Windows.Forms.Button();
            this.dgvPublications = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabLivres.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.gbSaisie.SuspendLayout();
            this.panelLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            this.panelBoutonsLivres.SuspendLayout();
            this.tabPublications.SuspendLayout();
            this.panelPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagesPub)).BeginInit();
            this.panelBoutonsPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublications)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLivres);
            this.tabControl1.Controls.Add(this.tabPublications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 42);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLivres
            // 
            this.tabLivres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabLivres.Controls.Add(this.panel1);
            this.tabLivres.Controls.Add(this.dgvLivres);
            this.tabLivres.Controls.Add(this.gbSaisie);
            this.tabLivres.Location = new System.Drawing.Point(4, 46);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivres.Size = new System.Drawing.Size(772, 500);
            this.tabLivres.TabIndex = 0;
            this.tabLivres.Text = "📚  Gestion des Livres";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRecherche);
            this.panel1.Controls.Add(this.txtRechercheLivre);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 45);
            this.panel1.TabIndex = 15;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRecherche.Location = new System.Drawing.Point(420, 13);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(93, 20);
            this.lblRecherche.TabIndex = 16;
            this.lblRecherche.Text = "🔍 Recherche :";
            // 
            // txtRechercheLivre
            // 
            this.txtRechercheLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRechercheLivre.Location = new System.Drawing.Point(519, 10);
            this.txtRechercheLivre.Name = "txtRechercheLivre";
            this.txtRechercheLivre.Size = new System.Drawing.Size(200, 27);
            this.txtRechercheLivre.TabIndex = 13;
            this.txtRechercheLivre.TextChanged += new System.EventHandler(this.txtRechercheLivre_TextChanged);
            // 
            // dgvLivres
            // 
            this.dgvLivres.AllowUserToAddRows = false;
            this.dgvLivres.AllowUserToDeleteRows = false;
            this.dgvLivres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivres.BackgroundColor = System.Drawing.Color.White;
            this.dgvLivres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgvLivres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLivres.ColumnHeadersHeight = 40;
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLivres.EnableHeadersVisualStyles = false;
            this.dgvLivres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvLivres.Location = new System.Drawing.Point(20, 305);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.ReadOnly = true;
            this.dgvLivres.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLivres.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLivres.RowTemplate.Height = 35;
            this.dgvLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivres.Size = new System.Drawing.Size(732, 180);
            this.dgvLivres.TabIndex = 12;
            this.dgvLivres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivres_CellClick);
            // 
            // gbSaisie
            // 
            this.gbSaisie.BackColor = System.Drawing.Color.White;
            this.gbSaisie.Controls.Add(this.panelLivre);
            this.gbSaisie.Controls.Add(this.panelBoutonsLivres);
            this.gbSaisie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbSaisie.Location = new System.Drawing.Point(20, 70);
            this.gbSaisie.Name = "gbSaisie";
            this.gbSaisie.Size = new System.Drawing.Size(732, 220);
            this.gbSaisie.TabIndex = 11;
            this.gbSaisie.TabStop = false;
            this.gbSaisie.Text = "  Formulaire de Saisie - Livre  ";
            // 
            // panelLivre
            // 
            this.panelLivre.Controls.Add(this.numPages);
            this.panelLivre.Controls.Add(this.txtIdLivre);
            this.panelLivre.Controls.Add(this.lblPages);
            this.panelLivre.Controls.Add(this.txtTitre);
            this.panelLivre.Controls.Add(this.lblTitre);
            this.panelLivre.Controls.Add(this.lblId);
            this.panelLivre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLivre.Location = new System.Drawing.Point(3, 22);
            this.panelLivre.Name = "panelLivre";
            this.panelLivre.Size = new System.Drawing.Size(726, 130);
            this.panelLivre.TabIndex = 14;
            // 
            // numPages
            // 
            this.numPages.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPages.Location = new System.Drawing.Point(140, 95);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(100, 27);
            this.numPages.TabIndex = 10;
            // 
            // txtIdLivre
            // 
            this.txtIdLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdLivre.Location = new System.Drawing.Point(140, 18);
            this.txtIdLivre.Name = "txtIdLivre";
            this.txtIdLivre.Size = new System.Drawing.Size(220, 27);
            this.txtIdLivre.TabIndex = 2;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPages.Location = new System.Drawing.Point(20, 97);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(106, 20);
            this.lblPages.TabIndex = 4;
            this.lblPages.Text = "Nb de Pages :";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTitre.Location = new System.Drawing.Point(140, 55);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(560, 27);
            this.txtTitre.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitre.Location = new System.Drawing.Point(77, 58);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(52, 20);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblId.Location = new System.Drawing.Point(20, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Code du Livre :";
            // 
            // panelBoutonsLivres
            // 
            this.panelBoutonsLivres.Controls.Add(this.btnEffacer);
            this.panelBoutonsLivres.Controls.Add(this.btnSupprimerLiv);
            this.panelBoutonsLivres.Controls.Add(this.btnModifierLiv);
            this.panelBoutonsLivres.Controls.Add(this.btnAjouterLiv);
            this.panelBoutonsLivres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoutonsLivres.Location = new System.Drawing.Point(3, 160);
            this.panelBoutonsLivres.Name = "panelBoutonsLivres";
            this.panelBoutonsLivres.Size = new System.Drawing.Size(726, 57);
            this.panelBoutonsLivres.TabIndex = 13;
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(590, 12);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(120, 35);
            this.btnEffacer.TabIndex = 9;
            this.btnEffacer.Text = "🗑️  Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnSupprimerLiv
            // 
            this.btnSupprimerLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerLiv.FlatAppearance.BorderSize = 0;
            this.btnSupprimerLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerLiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerLiv.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerLiv.Location = new System.Drawing.Point(460, 12);
            this.btnSupprimerLiv.Name = "btnSupprimerLiv";
            this.btnSupprimerLiv.Size = new System.Drawing.Size(120, 35);
            this.btnSupprimerLiv.TabIndex = 8;
            this.btnSupprimerLiv.Text = "❌  Supprimer";
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
            this.btnModifierLiv.Location = new System.Drawing.Point(330, 12);
            this.btnModifierLiv.Name = "btnModifierLiv";
            this.btnModifierLiv.Size = new System.Drawing.Size(120, 35);
            this.btnModifierLiv.TabIndex = 7;
            this.btnModifierLiv.Text = "✏️  Modifier";
            this.btnModifierLiv.UseVisualStyleBackColor = false;
            this.btnModifierLiv.Click += new System.EventHandler(this.btnModifierLiv_Click);
            // 
            // btnAjouterLiv
            // 
            this.btnAjouterLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterLiv.FlatAppearance.BorderSize = 0;
            this.btnAjouterLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterLiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouterLiv.ForeColor = System.Drawing.Color.White;
            this.btnAjouterLiv.Location = new System.Drawing.Point(200, 12);
            this.btnAjouterLiv.Name = "btnAjouterLiv";
            this.btnAjouterLiv.Size = new System.Drawing.Size(120, 35);
            this.btnAjouterLiv.TabIndex = 6;
            this.btnAjouterLiv.Text = "➕  Ajouter";
            this.btnAjouterLiv.UseVisualStyleBackColor = false;
            this.btnAjouterLiv.Click += new System.EventHandler(this.btnAjouterLiv_Click);
            // 
            // tabPublications
            // 
            this.tabPublications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPublications.Controls.Add(this.panelPub);
            this.tabPublications.Controls.Add(this.panelBoutonsPub);
            this.tabPublications.Controls.Add(this.dgvPublications);
            this.tabPublications.Location = new System.Drawing.Point(4, 46);
            this.tabPublications.Name = "tabPublications";
            this.tabPublications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublications.Size = new System.Drawing.Size(772, 500);
            this.tabPublications.TabIndex = 1;
            this.tabPublications.Text = "📝  Publications";
            // 
            // panelPub
            // 
            this.panelPub.BackColor = System.Drawing.Color.White;
            this.panelPub.Controls.Add(this.lblPagesPub);
            this.panelPub.Controls.Add(this.lblLivre);
            this.panelPub.Controls.Add(this.lblDatePub);
            this.panelPub.Controls.Add(this.lblAuteur);
            this.panelPub.Controls.Add(this.numPagesPub);
            this.panelPub.Controls.Add(this.dtpDatePub);
            this.panelPub.Controls.Add(this.cmbLivre);
            this.panelPub.Controls.Add(this.cmbAuteur);
            this.panelPub.Location = new System.Drawing.Point(20, 15);
            this.panelPub.Name = "panelPub";
            this.panelPub.Size = new System.Drawing.Size(620, 205);
            this.panelPub.TabIndex = 18;
            // 
            // lblPagesPub
            // 
            this.lblPagesPub.AutoSize = true;
            this.lblPagesPub.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPagesPub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPagesPub.Location = new System.Drawing.Point(30, 165);
            this.lblPagesPub.Name = "lblPagesPub";
            this.lblPagesPub.Size = new System.Drawing.Size(106, 20);
            this.lblPagesPub.TabIndex = 21;
            this.lblPagesPub.Text = "Nb de Pages :";
            // 
            // lblLivre
            // 
            this.lblLivre.AutoSize = true;
            this.lblLivre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLivre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLivre.Location = new System.Drawing.Point(90, 85);
            this.lblLivre.Name = "lblLivre";
            this.lblLivre.Size = new System.Drawing.Size(52, 20);
            this.lblLivre.TabIndex = 20;
            this.lblLivre.Text = "Livre :";
            // 
            // lblDatePub
            // 
            this.lblDatePub.AutoSize = true;
            this.lblDatePub.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDatePub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDatePub.Location = new System.Drawing.Point(8, 125);
            this.lblDatePub.Name = "lblDatePub";
            this.lblDatePub.Size = new System.Drawing.Size(138, 20);
            this.lblDatePub.TabIndex = 19;
            this.lblDatePub.Text = "Date Publication :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAuteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAuteur.Location = new System.Drawing.Point(70, 45);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(70, 20);
            this.lblAuteur.TabIndex = 18;
            this.lblAuteur.Text = "Auteur :";
            // 
            // numPagesPub
            // 
            this.numPagesPub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPagesPub.Location = new System.Drawing.Point(155, 163);
            this.numPagesPub.Name = "numPagesPub";
            this.numPagesPub.Size = new System.Drawing.Size(100, 27);
            this.numPagesPub.TabIndex = 17;
            // 
            // dtpDatePub
            // 
            this.dtpDatePub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDatePub.Location = new System.Drawing.Point(155, 122);
            this.dtpDatePub.Name = "dtpDatePub";
            this.dtpDatePub.Size = new System.Drawing.Size(280, 27);
            this.dtpDatePub.TabIndex = 16;
            // 
            // cmbLivre
            // 
            this.cmbLivre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbLivre.FormattingEnabled = true;
            this.cmbLivre.Location = new System.Drawing.Point(155, 82);
            this.cmbLivre.Name = "cmbLivre";
            this.cmbLivre.Size = new System.Drawing.Size(400, 28);
            this.cmbLivre.TabIndex = 15;
            // 
            // cmbAuteur
            // 
            this.cmbAuteur.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(155, 42);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(400, 28);
            this.cmbAuteur.TabIndex = 14;
            // 
            // panelBoutonsPub
            // 
            this.panelBoutonsPub.BackColor = System.Drawing.Color.White;
            this.panelBoutonsPub.Controls.Add(this.btnSupprimerPub);
            this.panelBoutonsPub.Controls.Add(this.btnLier);
            this.panelBoutonsPub.Location = new System.Drawing.Point(650, 15);
            this.panelBoutonsPub.Name = "panelBoutonsPub";
            this.panelBoutonsPub.Size = new System.Drawing.Size(102, 205);
            this.panelBoutonsPub.TabIndex = 19;
            // 
            // btnSupprimerPub
            // 
            this.btnSupprimerPub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerPub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerPub.FlatAppearance.BorderSize = 0;
            this.btnSupprimerPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerPub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerPub.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerPub.Location = new System.Drawing.Point(10, 130);
            this.btnSupprimerPub.Name = "btnSupprimerPub";
            this.btnSupprimerPub.Size = new System.Drawing.Size(82, 60);
            this.btnSupprimerPub.TabIndex = 13;
            this.btnSupprimerPub.Text = "❌\r\nSupprimer";
            this.btnSupprimerPub.UseVisualStyleBackColor = false;
            this.btnSupprimerPub.Click += new System.EventHandler(this.btnSupprimerPub_Click);
            // 
            // btnLier
            // 
            this.btnLier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLier.FlatAppearance.BorderSize = 0;
            this.btnLier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLier.ForeColor = System.Drawing.Color.White;
            this.btnLier.Location = new System.Drawing.Point(10, 40);
            this.btnLier.Name = "btnLier";
            this.btnLier.Size = new System.Drawing.Size(82, 60);
            this.btnLier.TabIndex = 11;
            this.btnLier.Text = "💾\r\nLier";
            this.btnLier.UseVisualStyleBackColor = false;
            this.btnLier.Click += new System.EventHandler(this.btnLier_Click);
            // 
            // dgvPublications
            // 
            this.dgvPublications.AllowUserToAddRows = false;
            this.dgvPublications.AllowUserToDeleteRows = false;
            this.dgvPublications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublications.BackgroundColor = System.Drawing.Color.White;
            this.dgvPublications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgvPublications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPublications.ColumnHeadersHeight = 40;
            this.dgvPublications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPublications.EnableHeadersVisualStyles = false;
            this.dgvPublications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvPublications.Location = new System.Drawing.Point(20, 235);
            this.dgvPublications.Name = "dgvPublications";
            this.dgvPublications.ReadOnly = true;
            this.dgvPublications.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPublications.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPublications.RowTemplate.Height = 35;
            this.dgvPublications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublications.Size = new System.Drawing.Size(732, 245);
            this.dgvPublications.TabIndex = 12;
            this.dgvPublications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublications_CellClick);
            // 
            // UCGestionLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "UCGestionLivres";
            this.Size = new System.Drawing.Size(780, 550);
            this.Load += new System.EventHandler(this.UCGestionLivres_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabLivres.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.gbSaisie.ResumeLayout(false);
            this.panelLivre.ResumeLayout(false);
            this.panelLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            this.panelBoutonsLivres.ResumeLayout(false);
            this.tabPublications.ResumeLayout(false);
            this.panelPub.ResumeLayout(false);
            this.panelPub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagesPub)).EndInit();
            this.panelBoutonsPub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRechercheLivre;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.GroupBox gbSaisie;
        private System.Windows.Forms.Panel panelLivre;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.TextBox txtIdLivre;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panelBoutonsLivres;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimerLiv;
        private System.Windows.Forms.Button btnModifierLiv;
        private System.Windows.Forms.Button btnAjouterLiv;
        private System.Windows.Forms.TabPage tabPublications;
        private System.Windows.Forms.Panel panelPub;
        private System.Windows.Forms.Label lblPagesPub;
        private System.Windows.Forms.Label lblLivre;
        private System.Windows.Forms.Label lblDatePub;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.NumericUpDown numPagesPub;
        private System.Windows.Forms.DateTimePicker dtpDatePub;
        private System.Windows.Forms.ComboBox cmbLivre;
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.Panel panelBoutonsPub;
        private System.Windows.Forms.Button btnSupprimerPub;
        private System.Windows.Forms.Button btnLier;
        private System.Windows.Forms.DataGridView dgvPublications;
    }
}
namespace Gestion_Livres
{
    partial class FrmDashboard
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

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNavEcrire = new System.Windows.Forms.Button();
            this.btnNavRapports = new System.Windows.Forms.Button();
            this.btnNavLivres = new System.Windows.Forms.Button();
            this.btnNavAuteurs = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.pnlMenu.Controls.Add(this.btnNavEcrire);
            this.pnlMenu.Controls.Add(this.btnNavRapports);
            this.pnlMenu.Controls.Add(this.btnNavLivres);
            this.pnlMenu.Controls.Add(this.btnNavAuteurs);
            this.pnlMenu.Controls.Add(this.btnNavDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 620);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnNavEcrire
            // 
            this.btnNavEcrire.FlatAppearance.BorderSize = 0;
            this.btnNavEcrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEcrire.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEcrire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNavEcrire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEcrire.Location = new System.Drawing.Point(0, 305);
            this.btnNavEcrire.Name = "btnNavEcrire";
            this.btnNavEcrire.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavEcrire.Size = new System.Drawing.Size(200, 50);
            this.btnNavEcrire.TabIndex = 5;
            this.btnNavEcrire.Text = "     Publications";
            this.btnNavEcrire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEcrire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavEcrire.UseVisualStyleBackColor = true;
            this.btnNavEcrire.Click += new System.EventHandler(this.btnNavEcrire_Click_1);
            // 
            // btnNavRapports
            // 
            this.btnNavRapports.FlatAppearance.BorderSize = 0;
            this.btnNavRapports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRapports.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRapports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNavRapports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRapports.Location = new System.Drawing.Point(0, 355);
            this.btnNavRapports.Name = "btnNavRapports";
            this.btnNavRapports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavRapports.Size = new System.Drawing.Size(200, 50);
            this.btnNavRapports.TabIndex = 4;
            this.btnNavRapports.Text = "     Rapports";
            this.btnNavRapports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRapports.UseVisualStyleBackColor = true;
            this.btnNavRapports.Click += new System.EventHandler(this.btnNavRapports_Click);
            // 
            // btnNavLivres
            // 
            this.btnNavLivres.FlatAppearance.BorderSize = 0;
            this.btnNavLivres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLivres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNavLivres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLivres.Location = new System.Drawing.Point(0, 255);
            this.btnNavLivres.Name = "btnNavLivres";
            this.btnNavLivres.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavLivres.Size = new System.Drawing.Size(200, 50);
            this.btnNavLivres.TabIndex = 3;
            this.btnNavLivres.Text = "     Livres";
            this.btnNavLivres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLivres.UseVisualStyleBackColor = true;
            this.btnNavLivres.Click += new System.EventHandler(this.btnNavLivres_Click);
            // 
            // btnNavAuteurs
            // 
            this.btnNavAuteurs.FlatAppearance.BorderSize = 0;
            this.btnNavAuteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAuteurs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAuteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNavAuteurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAuteurs.Location = new System.Drawing.Point(0, 205);
            this.btnNavAuteurs.Name = "btnNavAuteurs";
            this.btnNavAuteurs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavAuteurs.Size = new System.Drawing.Size(200, 50);
            this.btnNavAuteurs.TabIndex = 2;
            this.btnNavAuteurs.Text = "     Auteurs";
            this.btnNavAuteurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAuteurs.UseVisualStyleBackColor = true;
            this.btnNavAuteurs.Click += new System.EventHandler(this.btnNavAuteurs_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 155);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "     Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblAppVersion);
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 120);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblAppVersion.Location = new System.Drawing.Point(0, 55);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(200, 30);
            this.lblAppVersion.TabIndex = 1;
            this.lblAppVersion.Text = "v1.0.0 - UAGO";
            this.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 85);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(200, 35);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "BIBLIO-TECH";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblDateTime);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(780, 55);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblDateTime.Location = new System.Drawing.Point(580, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(132, 19);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "01/01/2025 - 00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(109, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAffichage.Location = new System.Drawing.Point(200, 55);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(780, 565);
            this.pnlAffichage.TabIndex = 2;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.pnlAffichage);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIBLIO-TECH UAGO - Gestion de Bibliothèque";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavAuteurs;
        private System.Windows.Forms.Button btnNavLivres;
        private System.Windows.Forms.Button btnNavEcrire;
        private System.Windows.Forms.Button btnNavRapports;
    }
}
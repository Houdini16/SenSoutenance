namespace AppSenSoutenance
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramèToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéeAcadémiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.séssionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encadreurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soutenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mémoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefDeDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sécuritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sideBar = new System.Windows.Forms.Panel();
            this._nav = new System.Windows.Forms.FlowLayoutPanel();
            this._btnAnnee = new System.Windows.Forms.Button();
            this._btnSession = new System.Windows.Forms.Button();
            this._btnProfesseur = new System.Windows.Forms.Button();
            this._btnSoutenance = new System.Windows.Forms.Button();
            this._btnMemoire = new System.Windows.Forms.Button();
            this._btnChefDepartement = new System.Windows.Forms.Button();
            this._btnDepartement = new System.Windows.Forms.Button();
            this._btnUtilisateur = new System.Windows.Forms.Button();
            this.panelSpacer = new System.Windows.Forms.Panel();
            this._btnDeconnexion = new System.Windows.Forms.Button();
            this._btnQuitter = new System.Windows.Forms.Button();
            this._sideHeader = new System.Windows.Forms.Panel();
            this._appSubtitle = new System.Windows.Forms.Label();
            this._appTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this._sideBar.SuspendLayout();
            this._nav.SuspendLayout();
            this._sideHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.paramèToolStripMenuItem,
            this.sécuritéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(260, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItem1.Text = "Action";
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paramèToolStripMenuItem
            // 
            this.paramèToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annéeAcadémiqueToolStripMenuItem,
            this.séssionToolStripMenuItem,
            this.encadreurToolStripMenuItem,
            this.soutenanceToolStripMenuItem,
            this.mémoireToolStripMenuItem,
            this.chefDeDepartementToolStripMenuItem,
            this.departementToolStripMenuItem});
            this.paramèToolStripMenuItem.Name = "paramèToolStripMenuItem";
            this.paramèToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.paramèToolStripMenuItem.Text = "&Paramètre";
            this.paramèToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            // 
            // annéeAcadémiqueToolStripMenuItem
            // 
            this.annéeAcadémiqueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.annéeAcadémiqueToolStripMenuItem.Name = "annéeAcadémiqueToolStripMenuItem";
            this.annéeAcadémiqueToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.annéeAcadémiqueToolStripMenuItem.Text = "&Année académique";
            this.annéeAcadémiqueToolStripMenuItem.Click += new System.EventHandler(this.annéeAcadémiqueToolStripMenuItem_Click);
            // 
            // séssionToolStripMenuItem
            // 
            this.séssionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.séssionToolStripMenuItem.Name = "séssionToolStripMenuItem";
            this.séssionToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.séssionToolStripMenuItem.Text = "&Séssion";
            this.séssionToolStripMenuItem.Click += new System.EventHandler(this.séssionToolStripMenuItem_Click);
            // 
            // encadreurToolStripMenuItem
            // 
            this.encadreurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.encadreurToolStripMenuItem.Name = "encadreurToolStripMenuItem";
            this.encadreurToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.encadreurToolStripMenuItem.Text = "&Professeur";
            this.encadreurToolStripMenuItem.Click += new System.EventHandler(this.encadreurToolStripMenuItem_Click);
            // 
            // soutenanceToolStripMenuItem
            // 
            this.soutenanceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.soutenanceToolStripMenuItem.Name = "soutenanceToolStripMenuItem";
            this.soutenanceToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.soutenanceToolStripMenuItem.Text = "&Soutenance";
            this.soutenanceToolStripMenuItem.Click += new System.EventHandler(this.soutenanceToolStripMenuItem_Click);
            // 
            // mémoireToolStripMenuItem
            // 
            this.mémoireToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.mémoireToolStripMenuItem.Name = "mémoireToolStripMenuItem";
            this.mémoireToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.mémoireToolStripMenuItem.Text = "&Mémoire";
            this.mémoireToolStripMenuItem.Click += new System.EventHandler(this.mémoireToolStripMenuItem_Click);
            // 
            // chefDeDepartementToolStripMenuItem
            // 
            this.chefDeDepartementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.chefDeDepartementToolStripMenuItem.Name = "chefDeDepartementToolStripMenuItem";
            this.chefDeDepartementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.chefDeDepartementToolStripMenuItem.Text = "Chef de departement";
            this.chefDeDepartementToolStripMenuItem.Click += new System.EventHandler(this.chefDeDepartementToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // sécuritéToolStripMenuItem
            // 
            this.sécuritéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem});
            this.sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            this.sécuritéToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sécuritéToolStripMenuItem.Text = "Sécurité";
            this.sécuritéToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // _sideBar
            // 
            this._sideBar.BackColor = System.Drawing.Color.White;
            this._sideBar.Controls.Add(this._nav);
            this._sideBar.Controls.Add(this._sideHeader);
            this._sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this._sideBar.Location = new System.Drawing.Point(0, 0);
            this._sideBar.Name = "_sideBar";
            this._sideBar.Size = new System.Drawing.Size(260, 627);
            this._sideBar.TabIndex = 2;
            // 
            // _nav
            // 
            this._nav.AutoScroll = true;
            this._nav.BackColor = System.Drawing.Color.White;
            this._nav.Controls.Add(this._btnAnnee);
            this._nav.Controls.Add(this._btnSession);
            this._nav.Controls.Add(this._btnProfesseur);
            this._nav.Controls.Add(this._btnSoutenance);
            this._nav.Controls.Add(this._btnMemoire);
            this._nav.Controls.Add(this._btnChefDepartement);
            this._nav.Controls.Add(this._btnDepartement);
            this._nav.Controls.Add(this._btnUtilisateur);
            this._nav.Controls.Add(this.panelSpacer);
            this._nav.Controls.Add(this._btnDeconnexion);
            this._nav.Controls.Add(this._btnQuitter);
            this._nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._nav.Location = new System.Drawing.Point(0, 110);
            this._nav.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this._nav.Name = "_nav";
            this._nav.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this._nav.Size = new System.Drawing.Size(260, 517);
            this._nav.TabIndex = 1;
            this._nav.WrapContents = false;
            // 
            // _btnAnnee
            // 
            this._btnAnnee.BackColor = System.Drawing.Color.White;
            this._btnAnnee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnAnnee.FlatAppearance.BorderSize = 1;
            this._btnAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAnnee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnAnnee.Location = new System.Drawing.Point(13, 15);
            this._btnAnnee.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnAnnee.Name = "_btnAnnee";
            this._btnAnnee.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnAnnee.Size = new System.Drawing.Size(230, 44);
            this._btnAnnee.TabIndex = 0;
            this._btnAnnee.Text = "Année académique";
            this._btnAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAnnee.UseVisualStyleBackColor = false;
            this._btnAnnee.Click += new System.EventHandler(this._btnAnnee_Click);
            // 
            // _btnSession
            // 
            this._btnSession.BackColor = System.Drawing.Color.White;
            this._btnSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnSession.FlatAppearance.BorderSize = 1;
            this._btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSession.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnSession.Location = new System.Drawing.Point(13, 65);
            this._btnSession.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnSession.Name = "_btnSession";
            this._btnSession.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnSession.Size = new System.Drawing.Size(230, 44);
            this._btnSession.TabIndex = 1;
            this._btnSession.Text = "Session";
            this._btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSession.UseVisualStyleBackColor = false;
            this._btnSession.Click += new System.EventHandler(this._btnSession_Click);
            // 
            // _btnProfesseur
            // 
            this._btnProfesseur.BackColor = System.Drawing.Color.White;
            this._btnProfesseur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnProfesseur.FlatAppearance.BorderSize = 1;
            this._btnProfesseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnProfesseur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnProfesseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnProfesseur.Location = new System.Drawing.Point(13, 115);
            this._btnProfesseur.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnProfesseur.Name = "_btnProfesseur";
            this._btnProfesseur.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnProfesseur.Size = new System.Drawing.Size(230, 44);
            this._btnProfesseur.TabIndex = 2;
            this._btnProfesseur.Text = "Professeur";
            this._btnProfesseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProfesseur.UseVisualStyleBackColor = false;
            this._btnProfesseur.Click += new System.EventHandler(this._btnProfesseur_Click);
            // 
            // _btnSoutenance
            // 
            this._btnSoutenance.BackColor = System.Drawing.Color.White;
            this._btnSoutenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnSoutenance.FlatAppearance.BorderSize = 1;
            this._btnSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSoutenance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSoutenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnSoutenance.Location = new System.Drawing.Point(13, 165);
            this._btnSoutenance.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnSoutenance.Name = "_btnSoutenance";
            this._btnSoutenance.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnSoutenance.Size = new System.Drawing.Size(230, 44);
            this._btnSoutenance.TabIndex = 3;
            this._btnSoutenance.Text = "Soutenance";
            this._btnSoutenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSoutenance.UseVisualStyleBackColor = false;
            this._btnSoutenance.Click += new System.EventHandler(this._btnSoutenance_Click);
            // 
            // _btnMemoire
            // 
            this._btnMemoire.BackColor = System.Drawing.Color.White;
            this._btnMemoire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnMemoire.FlatAppearance.BorderSize = 1;
            this._btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMemoire.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMemoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnMemoire.Location = new System.Drawing.Point(13, 215);
            this._btnMemoire.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnMemoire.Name = "_btnMemoire";
            this._btnMemoire.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnMemoire.Size = new System.Drawing.Size(230, 44);
            this._btnMemoire.TabIndex = 4;
            this._btnMemoire.Text = "Mémoire";
            this._btnMemoire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMemoire.UseVisualStyleBackColor = false;
            this._btnMemoire.Click += new System.EventHandler(this._btnMemoire_Click);
            // 
            // _btnChefDepartement
            // 
            this._btnChefDepartement.BackColor = System.Drawing.Color.White;
            this._btnChefDepartement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnChefDepartement.FlatAppearance.BorderSize = 1;
            this._btnChefDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnChefDepartement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChefDepartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnChefDepartement.Location = new System.Drawing.Point(13, 265);
            this._btnChefDepartement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnChefDepartement.Name = "_btnChefDepartement";
            this._btnChefDepartement.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnChefDepartement.Size = new System.Drawing.Size(230, 44);
            this._btnChefDepartement.TabIndex = 5;
            this._btnChefDepartement.Text = "Chef de departement";
            this._btnChefDepartement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnChefDepartement.UseVisualStyleBackColor = false;
            this._btnChefDepartement.Click += new System.EventHandler(this._btnChefDepartement_Click);
            // 
            // _btnDepartement
            // 
            this._btnDepartement.BackColor = System.Drawing.Color.White;
            this._btnDepartement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnDepartement.FlatAppearance.BorderSize = 1;
            this._btnDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDepartement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDepartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnDepartement.Location = new System.Drawing.Point(13, 315);
            this._btnDepartement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnDepartement.Name = "_btnDepartement";
            this._btnDepartement.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnDepartement.Size = new System.Drawing.Size(230, 44);
            this._btnDepartement.TabIndex = 6;
            this._btnDepartement.Text = "Departement";
            this._btnDepartement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDepartement.UseVisualStyleBackColor = false;
            this._btnDepartement.Click += new System.EventHandler(this._btnDepartement_Click);
            // 
            // _btnUtilisateur
            // 
            this._btnUtilisateur.BackColor = System.Drawing.Color.White;
            this._btnUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnUtilisateur.FlatAppearance.BorderSize = 1;
            this._btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnUtilisateur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnUtilisateur.Location = new System.Drawing.Point(13, 365);
            this._btnUtilisateur.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnUtilisateur.Name = "_btnUtilisateur";
            this._btnUtilisateur.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnUtilisateur.Size = new System.Drawing.Size(230, 44);
            this._btnUtilisateur.TabIndex = 7;
            this._btnUtilisateur.Text = "Utilisateur";
            this._btnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUtilisateur.UseVisualStyleBackColor = false;
            this._btnUtilisateur.Click += new System.EventHandler(this._btnUtilisateur_Click);
            // 
            // panelSpacer
            // 
            this.panelSpacer.BackColor = System.Drawing.Color.Transparent;
            this.panelSpacer.Location = new System.Drawing.Point(13, 415);
            this.panelSpacer.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.panelSpacer.Name = "panelSpacer";
            this.panelSpacer.Size = new System.Drawing.Size(1, 14);
            this.panelSpacer.TabIndex = 8;
            // 
            // _btnDeconnexion
            // 
            this._btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnDeconnexion.FlatAppearance.BorderSize = 0;
            this._btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this._btnDeconnexion.Location = new System.Drawing.Point(13, 445);
            this._btnDeconnexion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnDeconnexion.Name = "_btnDeconnexion";
            this._btnDeconnexion.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnDeconnexion.Size = new System.Drawing.Size(230, 44);
            this._btnDeconnexion.TabIndex = 9;
            this._btnDeconnexion.Text = "Se déconnecter";
            this._btnDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDeconnexion.UseVisualStyleBackColor = false;
            this._btnDeconnexion.Click += new System.EventHandler(this._btnDeconnexion_Click);
            // 
            // _btnQuitter
            // 
            this._btnQuitter.BackColor = System.Drawing.Color.White;
            this._btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._btnQuitter.FlatAppearance.BorderSize = 1;
            this._btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnQuitter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this._btnQuitter.Location = new System.Drawing.Point(13, 495);
            this._btnQuitter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this._btnQuitter.Name = "_btnQuitter";
            this._btnQuitter.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this._btnQuitter.Size = new System.Drawing.Size(230, 44);
            this._btnQuitter.TabIndex = 10;
            this._btnQuitter.Text = "Quitter";
            this._btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnQuitter.UseVisualStyleBackColor = false;
            this._btnQuitter.Click += new System.EventHandler(this._btnQuitter_Click);
            // 
            // _sideHeader
            // 
            this._sideHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this._sideHeader.Controls.Add(this._appSubtitle);
            this._sideHeader.Controls.Add(this._appTitle);
            this._sideHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._sideHeader.Location = new System.Drawing.Point(0, 0);
            this._sideHeader.Name = "_sideHeader";
            this._sideHeader.Size = new System.Drawing.Size(260, 110);
            this._sideHeader.TabIndex = 0;
            // 
            // _appSubtitle
            // 
            this._appSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._appSubtitle.ForeColor = System.Drawing.Color.White;
            this._appSubtitle.Location = new System.Drawing.Point(16, 54);
            this._appSubtitle.Name = "_appSubtitle";
            this._appSubtitle.Size = new System.Drawing.Size(228, 26);
            this._appSubtitle.TabIndex = 1;
            this._appSubtitle.Text = "Menu";
            this._appSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _appTitle
            // 
            this._appTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._appTitle.ForeColor = System.Drawing.Color.White;
            this._appTitle.Location = new System.Drawing.Point(16, 18);
            this._appTitle.Name = "_appTitle";
            this._appTitle.Size = new System.Drawing.Size(228, 34);
            this._appTitle.TabIndex = 0;
            this._appTitle.Text = "SenSoutenance";
            this._appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(693, 627);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._sideBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._sideBar.ResumeLayout(false);
            this._nav.ResumeLayout(false);
            this._sideHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramèToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeAcadémiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem séssionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encadreurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soutenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mémoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefDeDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sécuritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.Panel _sideBar;
        private System.Windows.Forms.FlowLayoutPanel _nav;
        private System.Windows.Forms.Button _btnAnnee;
        private System.Windows.Forms.Button _btnSession;
        private System.Windows.Forms.Button _btnProfesseur;
        private System.Windows.Forms.Button _btnSoutenance;
        private System.Windows.Forms.Button _btnMemoire;
        private System.Windows.Forms.Button _btnChefDepartement;
        private System.Windows.Forms.Button _btnDepartement;
        private System.Windows.Forms.Button _btnUtilisateur;
        private System.Windows.Forms.Panel panelSpacer;
        private System.Windows.Forms.Button _btnDeconnexion;
        private System.Windows.Forms.Button _btnQuitter;
        private System.Windows.Forms.Panel _sideHeader;
        private System.Windows.Forms.Label _appSubtitle;
        private System.Windows.Forms.Label _appTitle;
    }
}
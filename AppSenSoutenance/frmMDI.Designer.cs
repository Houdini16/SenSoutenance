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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.paramèToolStripMenuItem,
            this.sécuritéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
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
            this.seDeconnecterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
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
            this.annéeAcadémiqueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.annéeAcadémiqueToolStripMenuItem.Name = "annéeAcadémiqueToolStripMenuItem";
            this.annéeAcadémiqueToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.annéeAcadémiqueToolStripMenuItem.Text = "&Année académique";
            this.annéeAcadémiqueToolStripMenuItem.Click += new System.EventHandler(this.annéeAcadémiqueToolStripMenuItem_Click);
            // 
            // séssionToolStripMenuItem
            // 
            this.séssionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.séssionToolStripMenuItem.Name = "séssionToolStripMenuItem";
            this.séssionToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.séssionToolStripMenuItem.Text = "&Séssion";
            this.séssionToolStripMenuItem.Click += new System.EventHandler(this.séssionToolStripMenuItem_Click);
            // 
            // encadreurToolStripMenuItem
            // 
            this.encadreurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.encadreurToolStripMenuItem.Name = "encadreurToolStripMenuItem";
            this.encadreurToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.encadreurToolStripMenuItem.Text = "&Professeur";
            this.encadreurToolStripMenuItem.Click += new System.EventHandler(this.encadreurToolStripMenuItem_Click);
            // 
            // soutenanceToolStripMenuItem
            // 
            this.soutenanceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.soutenanceToolStripMenuItem.Name = "soutenanceToolStripMenuItem";
            this.soutenanceToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.soutenanceToolStripMenuItem.Text = "&Soutenance";
            this.soutenanceToolStripMenuItem.Click += new System.EventHandler(this.soutenanceToolStripMenuItem_Click);
            // 
            // mémoireToolStripMenuItem
            // 
            this.mémoireToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.mémoireToolStripMenuItem.Name = "mémoireToolStripMenuItem";
            this.mémoireToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.mémoireToolStripMenuItem.Text = "&Mémoire";
            this.mémoireToolStripMenuItem.Click += new System.EventHandler(this.mémoireToolStripMenuItem_Click);
            // 
            // chefDeDepartementToolStripMenuItem
            // 
            this.chefDeDepartementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.chefDeDepartementToolStripMenuItem.Name = "chefDeDepartementToolStripMenuItem";
            this.chefDeDepartementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.chefDeDepartementToolStripMenuItem.Text = "Chef de departement";
            this.chefDeDepartementToolStripMenuItem.Click += new System.EventHandler(this.chefDeDepartementToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
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
            this.utilisateurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(693, 627);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}
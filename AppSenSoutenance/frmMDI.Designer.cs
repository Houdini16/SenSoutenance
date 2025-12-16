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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.paramèToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 26);
            this.toolStripMenuItem1.Text = "Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paramèToolStripMenuItem
            // 
            this.paramèToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annéeAcadémiqueToolStripMenuItem,
            this.séssionToolStripMenuItem,
            this.encadreurToolStripMenuItem});
            this.paramèToolStripMenuItem.Name = "paramèToolStripMenuItem";
            this.paramèToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.paramèToolStripMenuItem.Text = "&Paramètre";
            // 
            // annéeAcadémiqueToolStripMenuItem
            // 
            this.annéeAcadémiqueToolStripMenuItem.Name = "annéeAcadémiqueToolStripMenuItem";
            this.annéeAcadémiqueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.annéeAcadémiqueToolStripMenuItem.Text = "&Année académique";
            this.annéeAcadémiqueToolStripMenuItem.Click += new System.EventHandler(this.annéeAcadémiqueToolStripMenuItem_Click);
            // 
            // séssionToolStripMenuItem
            // 
            this.séssionToolStripMenuItem.Name = "séssionToolStripMenuItem";
            this.séssionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.séssionToolStripMenuItem.Text = "&Séssion";
            this.séssionToolStripMenuItem.Click += new System.EventHandler(this.séssionToolStripMenuItem_Click);
            // 
            // encadreurToolStripMenuItem
            // 
            this.encadreurToolStripMenuItem.Name = "encadreurToolStripMenuItem";
            this.encadreurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.encadreurToolStripMenuItem.Text = "&Professeur";
            this.encadreurToolStripMenuItem.Click += new System.EventHandler(this.encadreurToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 627);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
    }
}
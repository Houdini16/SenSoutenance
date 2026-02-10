using AppSenSoutenance.View.Account;
using AppSenSoutenance.View.Paramètre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmMDI : Form
    {
        public string profil;

        public frmMDI()
        {
            InitializeComponent();
            ApplyBlueTheme();
        }

        private void ApplyBlueTheme()
        {
            Color bg = ColorTranslator.FromHtml("#F8FAFC");

            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackColor = bg;

            if (menuStrip1 != null)
            {
                menuStrip1.Visible = false;
            }

            Load += (_, __) =>
            {
                foreach (Control c in Controls)
                {
                    if (c is MdiClient mdi)
                    {
                        mdi.BackColor = bg;
                    }
                }
            };
        }

        private sealed class BlueColorTable : ProfessionalColorTable
        {
            private readonly Color _barBack;
            private readonly Color _itemSelect;
            private readonly Color _itemHover;

            public BlueColorTable(Color barBack, Color itemSelect, Color itemHover)
            {
                _barBack = barBack;
                _itemSelect = itemSelect;
                _itemHover = itemHover;
                UseSystemColors = false;
            }

            public override Color MenuStripGradientBegin => _barBack;
            public override Color MenuStripGradientEnd => _barBack;
            public override Color ToolStripGradientBegin => _barBack;
            public override Color ToolStripGradientMiddle => _barBack;
            public override Color ToolStripGradientEnd => _barBack;
            public override Color ImageMarginGradientBegin => Color.White;
            public override Color ImageMarginGradientMiddle => Color.White;
            public override Color ImageMarginGradientEnd => Color.White;
            public override Color MenuBorder => _barBack;
            public override Color ToolStripBorder => _barBack;
            public override Color MenuItemSelected => _itemHover;
            public override Color MenuItemBorder => _itemSelect;
            public override Color MenuItemPressedGradientBegin => _itemSelect;
            public override Color MenuItemPressedGradientMiddle => _itemSelect;
            public override Color MenuItemPressedGradientEnd => _itemSelect;
            public override Color MenuItemSelectedGradientBegin => _itemHover;
            public override Color MenuItemSelectedGradientEnd => _itemHover;
        }
        /// <summary>
        /// Méthode pour fermer tous les formulaires enfants ouverts 
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void annéeAcadémiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void séssionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSession f = new frmSession();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void encadreurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            sécuritéToolStripMenuItem.Visible = false;
            if (profil == "Admin")
            {
                sécuritéToolStripMenuItem.Visible = true;
            }

            if (_btnUtilisateur != null)
            {
                _btnUtilisateur.Visible = profil == "Admin";
            }

            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void soutenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSoutenance f = new frmSoutenance();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void mémoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMemoire f = new frmMemoire();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void chefDeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmChefDepartement f = new frmChefDepartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmDepartement f = new frmDepartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void _btnAnnee_Click(object sender, EventArgs e)
        {
            annéeAcadémiqueToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnSession_Click(object sender, EventArgs e)
        {
            séssionToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnProfesseur_Click(object sender, EventArgs e)
        {
            encadreurToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnSoutenance_Click(object sender, EventArgs e)
        {
            soutenanceToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnMemoire_Click(object sender, EventArgs e)
        {
            mémoireToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnChefDepartement_Click(object sender, EventArgs e)
        {
            chefDeDepartementToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnDepartement_Click(object sender, EventArgs e)
        {
            departementToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnUtilisateur_Click(object sender, EventArgs e)
        {
            utilisateurToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnDeconnexion_Click(object sender, EventArgs e)
        {
            seDeconnecterToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void _btnQuitter_Click(object sender, EventArgs e)
        {
            quitterToolStripMenuItem_Click(this, EventArgs.Empty);
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace AppSenSoutenance.Shared
{
    public static class AppTheme
    {
        public static readonly Color TrustBlue = ColorTranslator.FromHtml("#3B82F6");
        public static readonly Color Bg = ColorTranslator.FromHtml("#F8FAFC");
        public static readonly Color Text = ColorTranslator.FromHtml("#1E293B");
        public static readonly Color White = Color.White;

        public static void Apply(Form form)
        {
            if (form == null)
            {
                return;
            }

            form.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            form.BackColor = Bg;
            form.ForeColor = Text;

            ApplyToControls(form.Controls);

            form.Load += (_, __) =>
            {
                foreach (Control c in form.Controls)
                {
                    if (c is MdiClient mdi)
                    {
                        mdi.BackColor = Bg;
                    }
                }
            };
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Panel || c is GroupBox || c is TabPage)
                {
                    c.BackColor = White;
                }

                if (c is Label lbl)
                {
                    lbl.ForeColor = Text;
                }

                if (c is LinkLabel link)
                {
                    link.LinkColor = TrustBlue;
                    link.ActiveLinkColor = TrustBlue;
                    link.VisitedLinkColor = TrustBlue;
                }

                if (c is Button btn)
                {
                    StyleButton(btn);
                }

                if (c is TextBox tb)
                {
                    tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    tb.BackColor = White;
                    tb.ForeColor = Text;
                }

                if (c is ComboBox cb)
                {
                    cb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }

                if (c is DataGridView dgv)
                {
                    StyleGrid(dgv);
                }

                if (c is TabControl tab)
                {
                    tab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }

                if (c.HasChildren)
                {
                    ApplyToControls(c.Controls);
                }
            }
        }

        private static void StyleButton(Button btn)
        {
            if (btn == null)
            {
                return;
            }

            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = TrustBlue;
            btn.Cursor = Cursors.Hand;

            var txt = (btn.Text ?? string.Empty).ToLowerInvariant();
            if (txt.Contains("add") || txt.Contains("ajout") || txt.Contains("enregistrer") || txt.Contains("save"))
            {
                StylePrimary(btn);
            }
            else
            {
                StyleSecondary(btn);
            }
        }

        private static void StylePrimary(Button btn)
        {
            btn.BackColor = TrustBlue;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;
            btn.MouseEnter += (_, __) => btn.BackColor = TrustBlue;
            btn.MouseLeave += (_, __) => btn.BackColor = TrustBlue;
        }

        private static void StyleSecondary(Button btn)
        {
            btn.BackColor = White;
            btn.ForeColor = Text;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = TrustBlue;
            btn.MouseEnter += (_, __) => btn.BackColor = White;
            btn.MouseLeave += (_, __) => btn.BackColor = White;
        }

        private static void StyleGrid(DataGridView dgv)
        {
            if (dgv == null)
            {
                return;
            }

            dgv.BackgroundColor = White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Bg;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = TrustBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);

            dgv.DefaultCellStyle.BackColor = White;
            dgv.DefaultCellStyle.ForeColor = Text;
            dgv.DefaultCellStyle.SelectionBackColor = Bg;
            dgv.DefaultCellStyle.SelectionForeColor = Text;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Bg;
        }
    }
}

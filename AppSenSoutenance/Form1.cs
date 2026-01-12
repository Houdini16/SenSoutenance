using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmConnexion : Form
    {
        private Panel _cardPanel;
        private Label _titleLabel;

        public frmConnexion()
        {
            InitializeComponent();

            ApplyBlueTheme();
        }

        private void ApplyBlueTheme()
        {
            Color bluePrimary = Color.FromArgb(13, 71, 161);
            Color blueHover = Color.FromArgb(10, 56, 131);
            Color blueDark = Color.FromArgb(8, 47, 110);
            Color bg = Color.FromArgb(227, 242, 253);
            Color text = Color.FromArgb(33, 33, 33);

            BackColor = bg;
            ForeColor = text;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            DoubleBuffered = true;

            if (_titleLabel == null && lblTitle != null)
            {
                _titleLabel = lblTitle;
            }

            if (_cardPanel == null && panelCard != null)
            {
                _cardPanel = panelCard;
            }

            if (_titleLabel == null)
            {
                _titleLabel = new Label
                {
                    AutoSize = false,
                    Text = "Connexion",
                    ForeColor = blueDark,
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 28),
                    Size = new Size(ClientSize.Width, 40),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                Controls.Add(_titleLabel);
            }

            if (_cardPanel == null)
            {
                _cardPanel = new Panel
                {
                    BackColor = Color.White,
                    Size = new Size(500, 330)
                };
                Controls.Add(_cardPanel);
            }

            _titleLabel.ForeColor = blueDark;
            _titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            _titleLabel.BringToFront();

            _cardPanel.BackColor = Color.White;
            _cardPanel.BringToFront();
            HookRoundedCorners(_cardPanel, 18);

            if (label1.Parent != _cardPanel) _cardPanel.Controls.Add(label1);
            if (txtIdentifiant.Parent != _cardPanel) _cardPanel.Controls.Add(txtIdentifiant);
            if (label2.Parent != _cardPanel) _cardPanel.Controls.Add(label2);
            if (txtMotDePasse.Parent != _cardPanel) _cardPanel.Controls.Add(txtMotDePasse);
            if (btnQuitter.Parent != _cardPanel) _cardPanel.Controls.Add(btnQuitter);
            if (btnSeConnecter.Parent != _cardPanel) _cardPanel.Controls.Add(btnSeConnecter);

            label1.ForeColor = blueDark;
            label2.ForeColor = blueDark;

            label1.Location = new Point(30, 28);
            txtIdentifiant.Location = new Point(30, 58);
            label2.Location = new Point(30, 118);
            txtMotDePasse.Location = new Point(30, 148);

            int inputWidth = _cardPanel.Width - 60;
            txtIdentifiant.Size = new Size(inputWidth, 30);
            txtMotDePasse.Size = new Size(inputWidth, 30);

            StyleTextBox(txtIdentifiant, text);
            StyleTextBox(txtMotDePasse, text);

            btnQuitter.Size = new Size(200, 46);
            btnSeConnecter.Size = new Size(200, 46);
            btnQuitter.Location = new Point(30, 230);
            btnSeConnecter.Location = new Point(_cardPanel.Width - 30 - btnSeConnecter.Width, 230);

            StylePrimaryButton(btnSeConnecter, bluePrimary, blueHover);
            StyleSecondaryButton(btnQuitter, bluePrimary, Color.FromArgb(232, 245, 255));
            HookRoundedCorners(btnSeConnecter, 12);
            HookRoundedCorners(btnQuitter, 12);

            CenterCard();
            Resize += (_, __) => CenterCard();
        }

        private void CenterCard()
        {
            if (_cardPanel == null)
            {
                return;
            }

            int x = (ClientSize.Width - _cardPanel.Width) / 2;
            int y = 95;
            _cardPanel.Location = new Point(Math.Max(0, x), y);
        }

        private static void StyleTextBox(TextBox tb, Color textColor)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Color.White;
            tb.ForeColor = textColor;
            tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private static void StylePrimaryButton(Button btn, Color baseColor, Color hoverColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = baseColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (_, __) => btn.BackColor = hoverColor;
            btn.MouseLeave += (_, __) => btn.BackColor = baseColor;
        }

        private static void StyleSecondaryButton(Button btn, Color borderColor, Color hoverBg)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = borderColor;
            btn.BackColor = Color.White;
            btn.ForeColor = borderColor;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (_, __) => btn.BackColor = hoverBg;
            btn.MouseLeave += (_, __) => btn.BackColor = Color.White;
        }

        private static void HookRoundedCorners(Control control, int radius)
        {
            void apply()
            {
                if (control.Width <= 0 || control.Height <= 0)
                {
                    return;
                }

                using (GraphicsPath path = CreateRoundedRectPath(new Rectangle(0, 0, control.Width, control.Height), radius))
                {
                    control.Region = new Region(path);
                }
            }

            control.SizeChanged += (_, __) => apply();
            control.HandleCreated += (_, __) => apply();
            apply();
        }

        private static GraphicsPath CreateRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Max(1, radius * 2);

            Rectangle arc = new Rectangle(rect.Location, new Size(d, d));

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - d;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - d;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.profil = "Admin";
            f.Show();
            this.Hide();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

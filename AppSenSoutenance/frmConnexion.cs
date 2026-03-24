using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            SetupPlaceholder(txtIdentifiant, "Entrez votre identifiant", isPassword: false);
            SetupPlaceholder(txtMotDePasse, "Entrez votre mot de passe", isPassword: true);
        }

        private static void SetupPlaceholder(TextBox tb, string placeholder, bool isPassword)
        {
            void showPlaceholder()
            {
                tb.UseSystemPasswordChar = false;
                tb.ForeColor = ColorTranslator.FromHtml("#3B82F6");
                tb.Text = placeholder;
            }

            void hidePlaceholder()
            {
                tb.ForeColor = ColorTranslator.FromHtml("#1E293B");
                tb.Text = "";
                tb.UseSystemPasswordChar = isPassword;
            }

            tb.GotFocus += (_, __) =>
            {
                if (tb.Text == placeholder)
                {
                    hidePlaceholder();
                }
            };

            tb.LostFocus += (_, __) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    showPlaceholder();
                }
            };

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                showPlaceholder();
            }
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BdSenSoutenanceContext())
                {
                    string email = txtIdentifiant.Text.Trim();
                    string password = txtMotDePasse.Text;

                    var user = db.Utilisateurs.FirstOrDefault(u => u.EmailUtilisateur.ToLower() == email.ToLower());
                    
                    if (user != null)
                    {
                        bool isCorrect = false;
                        using (var md5Hash = System.Security.Cryptography.MD5.Create())
                        {
                            isCorrect = Shared.Crypted.VerifyMd5Hash(md5Hash, password, user.MotDePasse);
                        }

                        if (isCorrect)
                        {
                            frmMDI f = new frmMDI();
                            f.profil = (user is Admin) ? "Admin" : "User";
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe incorrect.", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur non trouvé.", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteDataError("frmConnexion-btnSeConnecter_Click", ex.ToString());
                MessageBox.Show("Une erreur est survenue lors de la connexion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

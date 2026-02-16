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
                BdSenSoutenanceContext db = new BdSenSoutenanceContext();
                var leUser = db.Utilisateurs.Where(a => a.EmailUtilisateur.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (leUser != null)
                {
                    // Vérifier le mot de passe
                    string motDePasse = txtMotDePasse.Text;
                    if (txtMotDePasse.Text == "Entrez votre mot de passe")
                    {
                        MessageBox.Show("Veuillez entrer votre mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    using (var md5Hash = System.Security.Cryptography.MD5.Create())
                    {
                        string hashedPassword = Crypted.GetMd5Hash(md5Hash, motDePasse);
                        if (hashedPassword == leUser.MotDePasse)
                        {
                            // Connexion réussie
                            frmMDI f = new frmMDI();
                            f.profil = leUser.Role;
                            f.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                Logger.WriteDataError("frmConnexion-btnSeConnecter_Click", ex.ToString());
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

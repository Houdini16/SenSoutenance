using AppSenSoutenance.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (_, e) => ShowFatalError(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    ShowFatalError(ex);
                    return;
                }

                ShowFatalError(new Exception("Unhandled exception: " + e.ExceptionObject));
            };

            try
            {
                Application.Run(new frmConnexion());
            }
            catch (Exception ex)
            {
                ShowFatalError(ex);
            }
        }

        private static void ShowFatalError(Exception ex)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "startup_error.log");
                File.AppendAllText(path, $"[{DateTime.Now:O}]\r\n{ex}\r\n\r\n");
            }
            catch
            {
            }

            try
            {
                MessageBox.Show(ex.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }
        }

        public static void StartApp()
        {
            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            var adminUser = db.Admin.Count();
            if (adminUser > 0)
            {
                Admin candidat = new Admin();
                candidat.NomUtilisateur = "THIAM";
                candidat.PrenomUtilisateur = "Moussa";
                candidat.TellUtilisateur = "773421212";
                candidat.EmailUtilisateur = "admin@yopmail.com";
                using (MD5 md5Hash = MD5.Create())
                {
                    candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "password");
                }
                db.Admin.Add(candidat);
                db.SaveChanges();
            }
        }
    }
}

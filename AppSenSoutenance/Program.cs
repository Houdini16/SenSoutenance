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
            InitAdmin();
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

        static void InitAdmin()
        {
            BdSenSoutenanceContext db  = new BdSenSoutenanceContext();
            if (db.Admin.Count() == 0)
            {
                Admin a = new Admin();
                a.NomUtilisateur = "Admin";
                a.PrenomUtilisateur = "Admin";
                a.TellUtilisateur = "770000000";
                a.EmailUtilisateur = "admin@yopmail.com";
            using (MD5 md5Hash = MD5.Create())
            {
                a.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            db.Admin.Add(a);
            db.SaveChanges();
            }
        }
    }
}

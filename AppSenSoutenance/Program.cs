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
                StartApp(); // Initialiser la base de données
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
                string path = System.IO.Path.Combine(Application.StartupPath, "startup_error.log");
                System.IO.File.AppendAllText(path, $"[{DateTime.Now:O}]\r\n{ex}\r\n\r\n");
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
            using (BdSenSoutenanceContext db = new BdSenSoutenanceContext())
            {
                // Force la création des tables même si la base de données existe déjà
                System.Data.Entity.Database.SetInitializer(new System.Data.Entity.CreateDatabaseIfNotExists<BdSenSoutenanceContext>());
                db.Database.Initialize(true);

                var adminCount = db.Admin.Count();
                if (adminCount == 0)
                {
                    Admin admin = new Admin();
                    admin.NomUtilisateur = "AIDARA";
                    admin.PrenomUtilisateur = "Moulaye";
                    admin.TellUtilisateur = "770000000";
                    admin.EmailUtilisateur = "moulaye";
                    using (MD5 md5Hash = MD5.Create())
                    {
                        admin.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "123");
                    }
                    db.Admin.Add(admin);
                    db.SaveChanges();
                }
            }
        }
    }
}

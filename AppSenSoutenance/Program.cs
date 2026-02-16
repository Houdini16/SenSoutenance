using AppSenSoutenance.Models;
using System;
using System.IO;
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
            try
            {
                // Essayer de mettre à jour la base de données automatiquement
                UpdateDatabase();
                
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

                Application.Run(new frmConnexion());
            }
            catch (Exception ex)
            {
                ShowFatalError(ex);
            }
        }
        
        static void UpdateDatabase()
        {
            try
            {
                using (var db = new BdSenSoutenanceContext())
                {
                    // Force la création ou mise à jour de la base de données
                    db.Database.CreateIfNotExists();
                    
                    // Vérifier si la colonne Role existe déjà dans la table Utilisateurs
                    bool roleColumnExists = false;
                    try
                    {
                        // Tenter de récupérer un utilisateur et accéder à sa propriété Role
                        var user = db.Utilisateurs.FirstOrDefault();
                        if (user != null)
                        {
                            var role = user.Role;
                            roleColumnExists = true;
                        }
                    }
                    catch
                    {
                        roleColumnExists = false;
                    }
                    
                    // Si la colonne n'existe pas, afficher un message d'erreur
                    if (!roleColumnExists)
                    {
                        MessageBox.Show("La base de données doit être mise à jour. Veuillez utiliser Entity Framework Migrations pour ajouter la colonne 'Role' à la table Utilisateurs.", 
                            "Mise à jour de la base de données requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour de la base de données: {ex.Message}", 
                    "Erreur de base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            if (db.Admin.Count() == 0)
            {
                Admin a = new Admin();
                a.NomUtilisateur = "Admin";
                a.PrenomUtilisateur = "Admin";
                a.TellUtilisateur = "770000000";
                a.EmailUtilisateur = "admin@yopmail.com";
                a.Role = "Admin";
                
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

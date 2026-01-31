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
            Application.Run(new frmConnexion());
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

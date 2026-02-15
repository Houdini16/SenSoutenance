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
            Application.Run(new frmConnexion());
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

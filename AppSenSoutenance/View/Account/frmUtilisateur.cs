using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Account
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

       BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabCandidat_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TellUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create()) 
            {
                candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.Candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }
        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.Utilisateurs.Select(
                a=> new { a.IdUtilisateur, a.NomUtilisateur, a.PrenomUtilisateur, a.TellUtilisateur, a.EmailUtilisateur }).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

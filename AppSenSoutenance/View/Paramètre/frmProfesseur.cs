using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenSoutenance.Models;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmProfesseur : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmProfesseur()
        {
            InitializeComponent();
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        public void Effacer()
        {
            txtSpecialite.Clear();
            dataGridView1.DataSource = db.Professeurs.Select(p => new
            {
                p.IdUtilisateur,
                p.SpecialiteProfesseur
            }).ToList();
            txtSpecialite.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpecialite.Text))
            {
                MessageBox.Show("Veuillez saisir la spécialité.");
                return;
            }

            Professeur professeur = new Professeur
            {
                SpecialiteProfesseur = txtSpecialite.Text,
                NomUtilisateur = "Professeur",
                PrenomUtilisateur = "N/A",
                TellUtilisateur = "000000000",
                EmailUtilisateur = $"{Guid.NewGuid():N}@local.com",
                MotDePasse = "1234"
            };

            db.Professeurs.Add(professeur);
            db.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialite.Text))
            {
                MessageBox.Show("Veuillez saisir la spécialité.");
                return;
            }

            int? id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.Professeurs.Find(id);
            professeur.SpecialiteProfesseur = txtSpecialite.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }

            int? id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.Professeurs.Find(id);
            db.Professeurs.Remove(professeur);
            db.SaveChanges();
            Effacer();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            txtSpecialite.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

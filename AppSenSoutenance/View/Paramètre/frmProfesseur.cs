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

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            dataGridView2.CellClick += dataGridView2_CellClick;
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            Effacer();

            if (tabControl1 != null && tabPage2 != null)
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        public void Effacer()
        {
            textBox1.Clear();
            dataGridView2.DataSource = db.Professeurs.Select(p => new
            {
                p.IdUtilisateur,
                p.SpecialiteProfesseur
            }).ToList();
            textBox1.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Veuillez saisir la spécialité.");
                return;
            }

            Professeur professeur = new Professeur
            {
                SpecialiteProfesseur = textBox1.Text,
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
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Veuillez saisir la spécialité.");
                return;
            }

            int? id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.Professeurs.Find(id);
            professeur.SpecialiteProfesseur = textBox1.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }

            int? id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.Professeurs.Find(id);
            db.Professeurs.Remove(professeur);
            db.SaveChanges();
            Effacer();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                return;
            }

            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

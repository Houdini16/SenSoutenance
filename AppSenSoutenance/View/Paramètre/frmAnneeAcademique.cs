using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            dgAnneeAcademique.DataSource = db.AnneesAcademiques.ToList();
            dgAnneeAcademique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAnneeAcademique.MultiSelect = false;
            dgAnneeAcademique.ReadOnly = true;
            dgAnneeAcademique.AutoGenerateColumns = true;
        }

        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = db.AnneesAcademiques.ToList();
            txtLibelleAnneeAcademique.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé.");
                return;
            }

            if (!int.TryParse(txtAnneeAcademiqueVal.Text, out int val))
            {
                MessageBox.Show("Veuillez saisir une valeur numérique valide.");
                return;
            }

            AnneeAcademique anneeAcademique = new AnneeAcademique
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = val
            };
            db.AnneesAcademiques.Add(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            if (!int.TryParse(txtAnneeAcademiqueVal.Text, out int val))
            {
                MessageBox.Show("Veuillez saisir une valeur numérique valide.");
                return;
            }

            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.AnneesAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = val;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }

            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.AnneesAcademiques.Find(id);
            db.AnneesAcademiques.Remove(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
                return;
            }

            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();    
        }
    }
}

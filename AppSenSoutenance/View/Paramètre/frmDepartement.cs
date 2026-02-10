using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmDepartement : Form
    {
        private readonly BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmDepartement()
        {
            InitializeComponent();

            AppTheme.Apply(this);

            Load += frmDepartement_Load;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellClick += (_, __) => FillFromGridSelection();
        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.Departements.ToList();
        }

        private int? GetSelectedId()
        {
            if (dataGridView1.CurrentRow == null)
            {
                return null;
            }

            if (dataGridView1.CurrentRow.Cells.Count <= 0)
            {
                return null;
            }

            object v = dataGridView1.CurrentRow.Cells[0].Value;
            if (v == null)
            {
                return null;
            }

            if (int.TryParse(v.ToString(), out int id))
            {
                return id;
            }

            return null;
        }

        private void FillFromGridSelection()
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            if (dataGridView1.CurrentRow.Cells.Count >= 2)
            {
                txtLeDepartement.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
            }
        }

        private void Effacer()
        {
            txtLeDepartement.Clear();
            txtLeDepartement.Focus();
            RefreshGrid();
        }

        private void txtLeDepartement_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLeDepartement.Text))
            {
                MessageBox.Show("Veuillez saisir le département.");
                return;
            }

            Departement d = new Departement
            {
                LibelleDepartement = txtLeDepartement.Text.Trim()
            };
            db.Departements.Add(d);
            db.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            Departement d = db.Departements.Find(id.Value);
            if (d == null)
            {
                MessageBox.Show("Département introuvable.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLeDepartement.Text))
            {
                MessageBox.Show("Veuillez saisir le département.");
                return;
            }

            d.LibelleDepartement = txtLeDepartement.Text.Trim();
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }

            Departement d = db.Departements.Find(id.Value);
            if (d == null)
            {
                MessageBox.Show("Département introuvable.");
                return;
            }

            db.Departements.Remove(d);
            db.SaveChanges();
            Effacer();
        }
    }
}

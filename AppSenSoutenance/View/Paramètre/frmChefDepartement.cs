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
using AppSenSoutenance.Shared;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmChefDepartement : Form
    {
        private readonly BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private readonly FillerList filler = new FillerList();

        public frmChefDepartement()
        {
            InitializeComponent();

            Load += frmChefDepartement_Load;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellClick += (_, __) => FillFromGridSelection();
        }

        private void frmChefDepartement_Load(object sender, EventArgs e)
        {
            LoadDepartements();
            RefreshGrid();
            EffacerInputsOnly();
        }

        private void LoadDepartements()
        {
            cbbDepartement.DataSource = filler.FillDepartement();
            cbbDepartement.DisplayMember = "Text";
            cbbDepartement.ValueMember = "Value";
        }

        private int? TryParseSelectedValue(ComboBox cbb)
        {
            object v = cbb.SelectedValue;
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

        private void RefreshGrid()
        {
            var liste = db.ChefDepartements
                .Select(cd => new
                {
                    cd.IdUtilisateur,
                    cd.NomUtilisateur,
                    cd.PrenomUtilisateur,
                    cd.TellUtilisateur,
                    cd.EmailUtilisateur,
                    Departement = cd.Departement != null ? cd.Departement.LibelleDepartement : "",
                    cd.IdDepartement
                })
                .ToList();

            dataGridView1.DataSource = liste;

            if (dataGridView1.Columns["IdDepartement"] != null)
            {
                dataGridView1.Columns["IdDepartement"].Visible = false;
            }
        }

        private int? GetSelectedId()
        {
            if (dataGridView1.CurrentRow == null)
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
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                return;
            }

            ChefDepartement cd = db.ChefDepartements.Find(id.Value);
            if (cd == null)
            {
                return;
            }

            txtNom.Text = cd.NomUtilisateur;
            txtPrenom.Text = cd.PrenomUtilisateur;
            txtTelephone.Text = cd.TellUtilisateur;
            txtMail.Text = cd.EmailUtilisateur;
            cbbDepartement.SelectedValue = cd.IdDepartement?.ToString();
        }

        private void EffacerInputsOnly()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtMail.Clear();
            if (cbbDepartement.Items.Count > 0)
            {
                cbbDepartement.SelectedIndex = 0;
            }
            txtNom.Focus();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            int? depId = TryParseSelectedValue(cbbDepartement);
            if (!depId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un département.");
                return;
            }

            ChefDepartement cd = new ChefDepartement
            {
                NomUtilisateur = txtNom.Text.Trim(),
                PrenomUtilisateur = txtPrenom.Text.Trim(),
                TellUtilisateur = txtTelephone.Text.Trim(),
                EmailUtilisateur = txtMail.Text.Trim(),
                MotDePasse = "1234",
                IdDepartement = depId.Value
            };

            db.ChefDepartements.Add(cd);
            db.SaveChanges();
            RefreshGrid();
            EffacerInputsOnly();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            ChefDepartement cd = db.ChefDepartements.Find(id.Value);
            if (cd == null)
            {
                MessageBox.Show("Chef de département introuvable.");
                return;
            }

            int? depId = TryParseSelectedValue(cbbDepartement);
            if (!depId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un département.");
                return;
            }

            cd.NomUtilisateur = txtNom.Text.Trim();
            cd.PrenomUtilisateur = txtPrenom.Text.Trim();
            cd.TellUtilisateur = txtTelephone.Text.Trim();
            cd.EmailUtilisateur = txtMail.Text.Trim();
            cd.IdDepartement = depId.Value;

            db.SaveChanges();
            RefreshGrid();
            EffacerInputsOnly();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }

            ChefDepartement cd = db.ChefDepartements.Find(id.Value);
            if (cd == null)
            {
                MessageBox.Show("Chef de département introuvable.");
                return;
            }

            db.ChefDepartements.Remove(cd);
            db.SaveChanges();
            RefreshGrid();
            EffacerInputsOnly();
        }
    }
}

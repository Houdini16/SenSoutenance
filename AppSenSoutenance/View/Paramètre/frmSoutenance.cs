using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();

            Load += frmSoutenance_Load;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellClick += (_, __) => FillFromGridSelection();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FillerList filler = new FillerList();

        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            LoadMemoires();
            cbbDateSoutenance.Text = DateTime.Now.ToShortDateString();
            RefreshGrid();
        }

        private void LoadMemoires()
        {
            cbbMemoire.DataSource = filler.FillMemoire();
            cbbMemoire.DisplayMember = "Text";
            cbbMemoire.ValueMember = "Value";
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

        private void RefreshGrid()
        {
            var liste = db.Soutenances
                .Select(s => new
                {
                    s.IdSoutenance,
                    s.DateSoutenance,
                    s.LieuSoutenance,
                    s.ResultatSoutenance,
                    s.MentionSoutenance,
                    s.ObservationsSoutenance,
                    Memoire = s.Mémoire != null ? s.Mémoire.SujetMemoire : "",
                    s.IdMemoire
                })
                .ToList();

            dataGridView1.DataSource = liste;
            if (dataGridView1.Columns["IdMemoire"] != null)
            {
                dataGridView1.Columns["IdMemoire"].Visible = false;
            }
        }

        private void FillFromGridSelection()
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                return;
            }

            Soutenance s = db.Soutenances.Find(id.Value);
            if (s == null)
            {
                return;
            }

            cbbDateSoutenance.Text = s.DateSoutenance.ToShortDateString();
            txtLieuSoutenance.Text = s.LieuSoutenance;
            txtResultatSoutenance.Text = s.ResultatSoutenance;
            txtMentionSoutenance.Text = s.MentionSoutenance;
            txtObservation.Text = s.ObservationsSoutenance;
            cbbMemoire.SelectedValue = s.IdMemoire?.ToString();
        }

        private void cbbDateSoutenance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDateSoutenance.SelectedIndex > -1)
            {
                DateTime selectedDate = DateTime.Parse(cbbDateSoutenance.SelectedItem.ToString());
                // Effectuez les actions nécessaires avec la date sélectionnée
            }
        }

        private void txtLieuSoutenance_TextChanged(object sender, EventArgs e)
        {
            // Vous pouvez ajouter une validation de longueur si nécessaire
            if (txtLieuSoutenance.Text.Length > 2000)
            {
                txtLieuSoutenance.Text = txtLieuSoutenance.Text.Substring(0, 2000);
            }
        }

        private void txtResultatSoutenance_TextChanged(object sender, EventArgs e)
        {
            // Validation de longueur maximale
            if (txtResultatSoutenance.Text.Length > 40)
            {
                txtResultatSoutenance.Text = txtResultatSoutenance.Text.Substring(0, 40);
            }
        }

        private void txtMentionSoutenance_TextChanged(object sender, EventArgs e)
        {
            // Validation de longueur maximale
            if (txtMentionSoutenance.Text.Length > 100)
            {
                txtMentionSoutenance.Text = txtMentionSoutenance.Text.Substring(0, 100);
            }
        }

        private void txtObservation_TextChanged(object sender, EventArgs e)
        {
            // Validation de longueur maximale
            if (txtObservation.Text.Length > 5000)
            {
                txtObservation.Text = txtObservation.Text.Substring(0, 5000);
            }
        }

        private void cbbMemoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMemoire.SelectedIndex != -1)
            {
                // Mise à jour de l'interface ou logique métier si nécessaire
            }
        }

        private void Effacer()
        {
            cbbDateSoutenance.Text = DateTime.Now.ToShortDateString();
            txtLieuSoutenance.Clear();
            txtResultatSoutenance.Clear();
            txtMentionSoutenance.Clear();
            txtObservation.Clear();
            if (cbbMemoire.Items.Count > 0)
            {
                cbbMemoire.SelectedIndex = 0;
            }
            RefreshGrid();
            cbbDateSoutenance.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(cbbDateSoutenance.Text, out DateTime dateSoutenance))
            {
                MessageBox.Show("Veuillez saisir une date valide.");
                return;
            }

            int? memoireId = TryParseSelectedValue(cbbMemoire);
            if (!memoireId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un mémoire.");
                return;
            }

            Soutenance s = new Soutenance
            {
                DateSoutenance = dateSoutenance,
                LieuSoutenance = txtLieuSoutenance.Text,
                ResultatSoutenance = txtResultatSoutenance.Text,
                MentionSoutenance = txtMentionSoutenance.Text,
                ObservationsSoutenance = txtObservation.Text,
                IdMemoire = memoireId.Value
            };

            db.Soutenances.Add(s);
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

            if (!DateTime.TryParse(cbbDateSoutenance.Text, out DateTime dateSoutenance))
            {
                MessageBox.Show("Veuillez saisir une date valide.");
                return;
            }

            int? memoireId = TryParseSelectedValue(cbbMemoire);
            if (!memoireId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un mémoire.");
                return;
            }

            Soutenance s = db.Soutenances.Find(id.Value);
            if (s == null)
            {
                MessageBox.Show("Soutenance introuvable.");
                return;
            }

            s.DateSoutenance = dateSoutenance;
            s.LieuSoutenance = txtLieuSoutenance.Text;
            s.ResultatSoutenance = txtResultatSoutenance.Text;
            s.MentionSoutenance = txtMentionSoutenance.Text;
            s.ObservationsSoutenance = txtObservation.Text;
            s.IdMemoire = memoireId.Value;

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

            Soutenance s = db.Soutenances.Find(id.Value);
            if (s == null)
            {
                MessageBox.Show("Soutenance introuvable.");
                return;
            }

            db.Soutenances.Remove(s);
            db.SaveChanges();
            Effacer();
        }
    }
}

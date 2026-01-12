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
using System.IO;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmMemoire : Form
    {
        private readonly BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private readonly FillerList filler = new FillerList();
        private byte[] _selectedDocumentBytes;

        public frmMemoire()
        {
            InitializeComponent();

            Load += frmMemoire_Load;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellClick += (_, __) => FillFromGridSelection();
        }

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            LoadAnneesAcademiques();
            LoadSessions();
            RefreshGrid();
            EffacerInputsOnly();
        }

        private void LoadAnneesAcademiques()
        {
            cbbAnneeAcademique.DataSource = filler.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
        }

        private void LoadSessions()
        {
            int? anneeId = TryParseSelectedValue(cbbAnneeAcademique);
            cbbSession.DataSource = filler.FillSession(anneeId);
            cbbSession.DisplayMember = "Text";
            cbbSession.ValueMember = "Value";
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
            var liste = db.Mémoires
                .Select(m => new
                {
                    m.IdMemoire,
                    m.SujetMemoire,
                    AnneeAcademique = m.AnneeAcademique != null ? m.AnneeAcademique.LibelleAnneeAcademique : "",
                    Session = m.Session != null ? m.Session.LibelleSession : "",
                    m.AnneeAcademiqueId,
                    m.IdSession,
                    Document = m.DocumentMemoire
                })
                .ToList();

            dataGridView1.DataSource = liste;

            if (dataGridView1.Columns["Document"] != null)
            {
                dataGridView1.Columns["Document"].Visible = false;
            }
            if (dataGridView1.Columns["AnneeAcademiqueId"] != null)
            {
                dataGridView1.Columns["AnneeAcademiqueId"].Visible = false;
            }
            if (dataGridView1.Columns["IdSession"] != null)
            {
                dataGridView1.Columns["IdSession"].Visible = false;
            }
        }

        private void FillFromGridSelection()
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                return;
            }

            Mémoire m = db.Mémoires.Find(id.Value);
            if (m == null)
            {
                return;
            }

            txtSujet.Text = m.SujetMemoire;
            cbbAnneeAcademique.SelectedValue = m.AnneeAcademiqueId.ToString();
            LoadSessions();
            cbbSession.SelectedValue = m.IdSession.ToString();

            _selectedDocumentBytes = null;
            txtDocumentDuMemoire.Text = m.DocumentMemoire != null ? "[Document enregistré]" : "";
        }

        private void EffacerInputsOnly()
        {
            txtSujet.Clear();
            txtDocumentDuMemoire.Clear();
            _selectedDocumentBytes = null;

            if (cbbAnneeAcademique.Items.Count > 0)
            {
                cbbAnneeAcademique.SelectedIndex = 0;
            }

            LoadSessions();
            if (cbbSession.Items.Count > 0)
            {
                cbbSession.SelectedIndex = 0;
            }

            txtSujet.Focus();
        }

        private void txtSujet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbAnneeAcademique_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void cbbSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentDuMemoire_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Tous les fichiers (*.*)|*.*";
                dlg.Title = "Choisir un document";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedDocumentBytes = File.ReadAllBytes(dlg.FileName);
                    txtDocumentDuMemoire.Text = dlg.FileName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSujet.Text))
            {
                MessageBox.Show("Veuillez saisir le sujet.");
                return;
            }

            int? anneeId = TryParseSelectedValue(cbbAnneeAcademique);
            if (!anneeId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return;
            }

            int? sessionId = TryParseSelectedValue(cbbSession);
            if (!sessionId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une session.");
                return;
            }

            Mémoire m = new Mémoire
            {
                SujetMemoire = txtSujet.Text.Trim(),
                AnneeAcademiqueId = anneeId.Value,
                IdSession = sessionId.Value,
                DocumentMemoire = _selectedDocumentBytes
            };

            db.Mémoires.Add(m);
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

            Mémoire m = db.Mémoires.Find(id.Value);
            if (m == null)
            {
                MessageBox.Show("Mémoire introuvable.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSujet.Text))
            {
                MessageBox.Show("Veuillez saisir le sujet.");
                return;
            }

            int? anneeId = TryParseSelectedValue(cbbAnneeAcademique);
            if (!anneeId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return;
            }

            int? sessionId = TryParseSelectedValue(cbbSession);
            if (!sessionId.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une session.");
                return;
            }

            m.SujetMemoire = txtSujet.Text.Trim();
            m.AnneeAcademiqueId = anneeId.Value;
            m.IdSession = sessionId.Value;
            if (_selectedDocumentBytes != null)
            {
                m.DocumentMemoire = _selectedDocumentBytes;
            }

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

            Mémoire m = db.Mémoires.Find(id.Value);
            if (m == null)
            {
                MessageBox.Show("Mémoire introuvable.");
                return;
            }

            db.Mémoires.Remove(m);
            db.SaveChanges();
            RefreshGrid();
            EffacerInputsOnly();
        }
    }
}

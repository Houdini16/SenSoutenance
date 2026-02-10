using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Paramètre
{
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();

            AppTheme.Apply(this);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        FillerList filler = new FillerList();


        private void frmSession_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir la session.");
                return;
            }

            if (cbbAnneeAcademique.SelectedValue == null || string.IsNullOrWhiteSpace(cbbAnneeAcademique.SelectedValue.ToString()))
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return;
            }

            if (!int.TryParse(cbbAnneeAcademique.SelectedValue.ToString(), out int anneeId))
            {
                MessageBox.Show("Année académique invalide.");
                return;
            }

            Models.Session session = new Models.Session();
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = anneeId;
            db.Sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedValue = "";
            dataGridView1.DataSource = db.Sessions.ToList();
            cbbAnneeAcademique.DataSource = filler.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
                return;
            }

            int? id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Models.Session session = db.Sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir la session.");
                return;
            }

            if (cbbAnneeAcademique.SelectedValue == null || string.IsNullOrWhiteSpace(cbbAnneeAcademique.SelectedValue.ToString()))
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return;
            }

            if (!int.TryParse(cbbAnneeAcademique.SelectedValue.ToString(), out int anneeId))
            {
                MessageBox.Show("Année académique invalide.");
                return;
            }

            int? id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Models.Session session = db.Sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = anneeId;
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
            Models.Session session = db.Sessions.Find(id);
            db.Sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.Sessions.ToList();
            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }

            if (txtRanneeAcademique.Text != "")
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text)).ToList();
            }
            dataGridView1.DataSource = liste;
        }
    }
}

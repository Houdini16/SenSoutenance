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
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

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
            cbbDateSoutenance.SelectedValue = "";
            txtLieuSoutenance.Clear();
            txtResultatSoutenance.Clear();
            txtMentionSoutenance.Clear();
            txtObservation.Clear();
            cbbMemoire.SelectedValue = "";
            dataGridView1.DataSource = db.Soutenances.ToList();
            //cbbMemoire.DataSource = filler.FillMemoire();
            cbbMemoire.DisplayMember = "Text";
            cbbMemoire.ValueMember = "Value";
            cbbDateSoutenance.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Soutenance soutenance = new Soutenance();
            //soutenance.DateSoutenance = DateTime.Parse(cbbDateSoutenance.SelectedValue.ToString());
            //soutenance.LieuSoutenance = txtLieuSoutenance.Text;
            //soutenance.ResultatsSoutenance = txtResultatSoutenance.Text;
            //soutenance.MentionSoutenance = txtMentionSoutenance.Text;
            //soutenance.ObservationSoutenance = txtObservation.Text;
            //soutenance.IdMemoire = int.Parse(cbbMemoire.SelectedValue.ToString());

            //db.Soutenances.Add(soutenance);
            //db.SaveChanges();
            //Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}

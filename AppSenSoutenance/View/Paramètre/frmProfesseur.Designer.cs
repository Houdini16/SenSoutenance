namespace AppSenSoutenance.View.Paramètre
{
    // Formulaire Professeur (vue WinForms)
    partial class frmProfesseur
    {
        /// <summary>
        /// Conteneur des composants du formulaire
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libération des ressources utilisées par le formulaire
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être libérées</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                // Libère les composants graphiques
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Méthode générée automatiquement par le Designer
        /// Elle initialise tous les composants graphiques du formulaire
        /// ⚠ Ne pas modifier manuellement
        /// </summary>
        private void InitializeComponent()
        {
            // Déclaration et initialisation des contrôles
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();

            // Initialisation du DataGridView2
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ================= ComboBox1 =================
            // Liste permettant d’afficher les candidatures ou sujets
            this.comboBox1.DisplayMember = "Lister les candidatures";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 28);
            this.comboBox1.ValueMember = "Lister mes propositions ";

            // ================= Boutons d’actions =================
            // Bouton sélectionner une candidature
            this.button6.Text = "&Selectionner";

            // Bouton rejeter une candidature
            this.button5.Text = "&Rejeter";

            // Bouton accepter une candidature
            this.button4.Text = "&Accepter";

            // ================= Label =================
            // Indique le type de liste affichée
            this.label4.Text = "Lister : Candidature / Sujet";

            // ================= DataGridView2 =================
            // Tableau affichant les candidatures ou sujets proposés
            this.dataGridView2.Size = new System.Drawing.Size(511, 342);

            // ================= Boutons CRUD =================
            // Supprimer un sujet
            this.btnRemove.Text = "&Supprimer";

            // Modifier un sujet
            this.btnEdit.Text = "&Modifier";

            // Ajouter un nouveau sujet
            this.btnAdd.Text = "&Ajouter";

            // ================= TextBox =================
            // Champ texte pour saisir le sujet du mémoire
            this.textBox1.Multiline = true;

            // ================= Labels =================
            // Label du champ Sujet
            this.label3.Text = "Sujet";

            // Label pour le choix de la filière
            this.label2.Text = "Choisir une filiere";

            // ================= ComboBox =================
            // Liste déroulante (filière ou date de soutenance)
            this.cbbDateSoutenance.FormattingEnabled = true;

            // ================= TabPage 1 : Mémoires =================
            // Bouton de validation
            this.button7.Text = "&Valider";

            // ComboBox pour filtrer ou sélectionner un mémoire
            this.comboBox2.FormattingEnabled = true;

            // Titre de la section
            this.label1.Text = "Memoire / Resumer";

            // Bouton consulter un mémoire
            this.button3.Text = "&Consulter";

            // Bouton annoter un mémoire
            this.button2.Text = "&Annoter";

            // Bouton sélectionner un mémoire
            this.button1.Text = "&Selectionner";

            // DataGridView affichant la liste des mémoires
            this.dataGridView1.Size = new System.Drawing.Size(904, 325);

            // ================= TabControl =================
            // Contient deux onglets : Mémoires et Proposer un sujet
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);

            // ================= Formulaire =================
            // Paramètres généraux du formulaire Professeur
            this.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.ClientSize = new System.Drawing.Size(1080, 603);
            this.ControlBox = false;
            this.Text = "Profésseur";

            // Événement déclenché au chargement du formulaire
            this.Load += new System.EventHandler(this.frmProfesseur_Load);

            // Fin de l’initialisation
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Déclaration des composants privés du formulaire
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpecialite;
    }
}

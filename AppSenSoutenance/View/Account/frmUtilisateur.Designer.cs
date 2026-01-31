namespace AppSenSoutenance.View.Account
{
    partial class frmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPPrenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabChefDepartement = new System.Windows.Forms.TabPage();
            this.txtCDepartement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCPrenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChefDepartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepartement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabCandidat.Controls.Add(this.btnRemove);
            this.tabCandidat.Controls.Add(this.btnEdit);
            this.tabCandidat.Controls.Add(this.btnAdd);
            this.tabCandidat.Controls.Add(this.txtMatricule);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtTel);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtEmail);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtPrenom);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtNom);
            this.tabCandidat.Controls.Add(this.label1);
            this.tabCandidat.Location = new System.Drawing.Point(4, 25);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(301, 473);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candidat";
            this.tabCandidat.Click += new System.EventHandler(this.tabCandidat_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(23, 285);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(246, 22);
            this.txtMatricule.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricule :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(23, 222);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(246, 22);
            this.txtTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(23, 97);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(246, 22);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(23, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(246, 22);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabProfesseur.Controls.Add(this.button1);
            this.tabProfesseur.Controls.Add(this.button2);
            this.tabProfesseur.Controls.Add(this.button3);
            this.tabProfesseur.Controls.Add(this.txtPSpecialite);
            this.tabProfesseur.Controls.Add(this.label6);
            this.tabProfesseur.Controls.Add(this.txtPTel);
            this.tabProfesseur.Controls.Add(this.label7);
            this.tabProfesseur.Controls.Add(this.txtPEmail);
            this.tabProfesseur.Controls.Add(this.label8);
            this.tabProfesseur.Controls.Add(this.txtPPrenom);
            this.tabProfesseur.Controls.Add(this.label9);
            this.tabProfesseur.Controls.Add(this.txtPNom);
            this.tabProfesseur.Controls.Add(this.label10);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 25);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(301, 473);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.Location = new System.Drawing.Point(29, 287);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(246, 22);
            this.txtPSpecialite.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Specialité :";
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(29, 226);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(246, 22);
            this.txtPTel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Téléphone :";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(29, 164);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(246, 22);
            this.txtPEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email :";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.Location = new System.Drawing.Point(29, 108);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(246, 22);
            this.txtPPrenom.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prenom :";
            // 
            // txtPNom
            // 
            this.txtPNom.Location = new System.Drawing.Point(29, 45);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(246, 22);
            this.txtPNom.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nom :";
            // 
            // tabChefDepartement
            // 
            this.tabChefDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabChefDepartement.Controls.Add(this.button4);
            this.tabChefDepartement.Controls.Add(this.button5);
            this.tabChefDepartement.Controls.Add(this.button6);
            this.tabChefDepartement.Controls.Add(this.txtCDepartement);
            this.tabChefDepartement.Controls.Add(this.label11);
            this.tabChefDepartement.Controls.Add(this.txtCTel);
            this.tabChefDepartement.Controls.Add(this.label12);
            this.tabChefDepartement.Controls.Add(this.txtCEmail);
            this.tabChefDepartement.Controls.Add(this.label13);
            this.tabChefDepartement.Controls.Add(this.txtCPrenom);
            this.tabChefDepartement.Controls.Add(this.label14);
            this.tabChefDepartement.Controls.Add(this.txtCNom);
            this.tabChefDepartement.Controls.Add(this.label15);
            this.tabChefDepartement.Location = new System.Drawing.Point(4, 25);
            this.tabChefDepartement.Name = "tabChefDepartement";
            this.tabChefDepartement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDepartement.Size = new System.Drawing.Size(301, 473);
            this.tabChefDepartement.TabIndex = 2;
            this.tabChefDepartement.Text = "Chef departement";
            // 
            // txtCDepartement
            // 
            this.txtCDepartement.Location = new System.Drawing.Point(29, 272);
            this.txtCDepartement.Name = "txtCDepartement";
            this.txtCDepartement.Size = new System.Drawing.Size(246, 22);
            this.txtCDepartement.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Departement :";
            // 
            // txtCTel
            // 
            this.txtCTel.Location = new System.Drawing.Point(29, 212);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(246, 22);
            this.txtCTel.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Téléphone :";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(29, 154);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(246, 22);
            this.txtCEmail.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Email :";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.Location = new System.Drawing.Point(29, 98);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(246, 22);
            this.txtCPrenom.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Prenom :";
            // 
            // txtCNom
            // 
            this.txtCNom.Location = new System.Drawing.Point(29, 45);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(246, 22);
            this.txtCNom.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nom :";
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(348, 37);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(637, 473);
            this.dgUtilisateur.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(167, 408);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 27);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(167, 371);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 27);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(167, 335);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 27);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "&Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(173, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "&Modifier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(173, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 27);
            this.button3.TabIndex = 23;
            this.button3.Text = "&Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(173, 429);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 27);
            this.button4.TabIndex = 38;
            this.button4.Text = "&Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(173, 392);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 27);
            this.button5.TabIndex = 37;
            this.button5.Text = "&Modifier";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(173, 356);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 27);
            this.button6.TabIndex = 36;
            this.button6.Text = "&Ajouter";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(997, 586);
            this.ControlBox = false;
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChefDepartement.ResumeLayout(false);
            this.tabChefDepartement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepartement;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPPrenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPNom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCDepartement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCPrenom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
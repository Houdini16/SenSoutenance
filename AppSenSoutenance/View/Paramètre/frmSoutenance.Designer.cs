namespace AppSenSoutenance.View.Paramètre
{
    partial class frmSoutenance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbMemoire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLieuSoutenance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultatSoutenance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMentionSoutenance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDateSoutenance = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(348, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(629, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(227, 562);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 34);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(227, 516);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbMemoire
            // 
            this.cbbMemoire.FormattingEnabled = true;
            this.cbbMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMemoire.Location = new System.Drawing.Point(12, 427);
            this.cbbMemoire.Name = "cbbMemoire";
            this.cbbMemoire.Size = new System.Drawing.Size(306, 28);
            this.cbbMemoire.TabIndex = 6;
            this.cbbMemoire.SelectedIndexChanged += new System.EventHandler(this.cbbMemoire_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(8, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Memoire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date Soutenance";
            // 
            // txtLieuSoutenance
            // 
            this.txtLieuSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLieuSoutenance.Location = new System.Drawing.Point(12, 170);
            this.txtLieuSoutenance.Name = "txtLieuSoutenance";
            this.txtLieuSoutenance.Size = new System.Drawing.Size(311, 26);
            this.txtLieuSoutenance.TabIndex = 2;
            this.txtLieuSoutenance.TextChanged += new System.EventHandler(this.txtLieuSoutenance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lieu Soutenance";
            // 
            // txtResultatSoutenance
            // 
            this.txtResultatSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultatSoutenance.Location = new System.Drawing.Point(12, 233);
            this.txtResultatSoutenance.Name = "txtResultatSoutenance";
            this.txtResultatSoutenance.Size = new System.Drawing.Size(311, 26);
            this.txtResultatSoutenance.TabIndex = 3;
            this.txtResultatSoutenance.TextChanged += new System.EventHandler(this.txtResultatSoutenance_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Resultat Soutenance";
            // 
            // txtMentionSoutenance
            // 
            this.txtMentionSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMentionSoutenance.Location = new System.Drawing.Point(12, 296);
            this.txtMentionSoutenance.Name = "txtMentionSoutenance";
            this.txtMentionSoutenance.Size = new System.Drawing.Size(311, 26);
            this.txtMentionSoutenance.TabIndex = 4;
            this.txtMentionSoutenance.TextChanged += new System.EventHandler(this.txtMentionSoutenance_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(13, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mention Soutenance";
            // 
            // txtObservation
            // 
            this.txtObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservation.Location = new System.Drawing.Point(12, 366);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(311, 26);
            this.txtObservation.TabIndex = 5;
            this.txtObservation.TextChanged += new System.EventHandler(this.txtObservation_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(13, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Observation";
            // 
            // cbbDateSoutenance
            // 
            this.cbbDateSoutenance.FormattingEnabled = true;
            this.cbbDateSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDateSoutenance.Location = new System.Drawing.Point(12, 108);
            this.cbbDateSoutenance.Name = "cbbDateSoutenance";
            this.cbbDateSoutenance.Size = new System.Drawing.Size(306, 28);
            this.cbbDateSoutenance.TabIndex = 1;
            this.cbbDateSoutenance.SelectedIndexChanged += new System.EventHandler(this.cbbDateSoutenance_SelectedIndexChanged);
            // 
            // frmSoutenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1006, 629);
            this.ControlBox = false;
            this.Controls.Add(this.cbbDateSoutenance);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMentionSoutenance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultatSoutenance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLieuSoutenance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMemoire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSoutenance";
            this.Text = "Soutenance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbMemoire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLieuSoutenance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultatSoutenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMentionSoutenance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDateSoutenance;
    }
}
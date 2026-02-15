namespace AppSenSoutenance.View.Paramètre
{
    partial class frmSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRanneeAcademique = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(318, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSelect.Location = new System.Drawing.Point(176, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 39);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Année Académique :";
            // 
            // txtSession
            // 
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSession.Location = new System.Drawing.Point(12, 105);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(276, 22);
            this.txtSession.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Séssion :";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(12, 209);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(276, 24);
            this.cbbAnneeAcademique.TabIndex = 15;
            // 
            // txtRSession
            // 
            this.txtRSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSession.Location = new System.Drawing.Point(315, 40);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(276, 22);
            this.txtRSession.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(315, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Séssion :";
            // 
            // txtRanneeAcademique
            // 
            this.txtRanneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRanneeAcademique.Location = new System.Drawing.Point(616, 40);
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";
            this.txtRanneeAcademique.Size = new System.Drawing.Size(276, 22);
            this.txtRanneeAcademique.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(616, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Année Académique :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(940, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 39);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.White;
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAjout.FlatAppearance.BorderSize = 2;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.ForeColor = System.Drawing.Color.Black;
            this.btnAjout.Location = new System.Drawing.Point(173, 345);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(115, 39);
            this.btnAjout.TabIndex = 23;
            this.btnAjout.Text = "&Ajouter";
            this.btnAjout.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(173, 435);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 39);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(173, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 39);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1080, 603);
            this.ControlBox = false;
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRanneeAcademique);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSession";
            this.Text = "Séssion";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRanneeAcademique;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
    }
}
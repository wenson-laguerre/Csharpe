
namespace Examen_Finale__Hinde_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListeConsultation = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.gboxPatient = new System.Windows.Forms.GroupBox();
            this.txtPatientNom = new System.Windows.Forms.TextBox();
            this.lblPatientNom = new System.Windows.Forms.Label();
            this.txtPatientPrenom = new System.Windows.Forms.TextBox();
            this.lblPatientPrenom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxMedcin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedcinNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbGeneralist = new System.Windows.Forms.RadioButton();
            this.rbSpecialiste = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNon = new System.Windows.Forms.RadioButton();
            this.rbOui = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxMatricule = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeConsultation)).BeginInit();
            this.gboxPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxMedcin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeConsultation
            // 
            this.dgvListeConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeConsultation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvListeConsultation.Location = new System.Drawing.Point(37, 260);
            this.dgvListeConsultation.Name = "dgvListeConsultation";
            this.dgvListeConsultation.Size = new System.Drawing.Size(649, 160);
            this.dgvListeConsultation.TabIndex = 15;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(692, 384);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(96, 36);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(37, 209);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(101, 35);
            this.btnInitialiser.TabIndex = 2;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(204, 209);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 35);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(389, 209);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(90, 35);
            this.btnSupp.TabIndex = 5;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // gboxPatient
            // 
            this.gboxPatient.Controls.Add(this.txtPatientNom);
            this.gboxPatient.Controls.Add(this.lblPatientNom);
            this.gboxPatient.Controls.Add(this.txtPatientPrenom);
            this.gboxPatient.Controls.Add(this.lblPatientPrenom);
            this.gboxPatient.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gboxPatient.Location = new System.Drawing.Point(168, 12);
            this.gboxPatient.Name = "gboxPatient";
            this.gboxPatient.Size = new System.Drawing.Size(226, 86);
            this.gboxPatient.TabIndex = 6;
            this.gboxPatient.TabStop = false;
            this.gboxPatient.Text = "Informations du Patient";
            // 
            // txtPatientNom
            // 
            this.txtPatientNom.Location = new System.Drawing.Point(62, 44);
            this.txtPatientNom.Name = "txtPatientNom";
            this.txtPatientNom.Size = new System.Drawing.Size(100, 20);
            this.txtPatientNom.TabIndex = 4;
            // 
            // lblPatientNom
            // 
            this.lblPatientNom.AutoSize = true;
            this.lblPatientNom.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNom.Location = new System.Drawing.Point(6, 51);
            this.lblPatientNom.Name = "lblPatientNom";
            this.lblPatientNom.Size = new System.Drawing.Size(36, 14);
            this.lblPatientNom.TabIndex = 3;
            this.lblPatientNom.Text = "Nom :";
            // 
            // txtPatientPrenom
            // 
            this.txtPatientPrenom.Location = new System.Drawing.Point(62, 17);
            this.txtPatientPrenom.Name = "txtPatientPrenom";
            this.txtPatientPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPatientPrenom.TabIndex = 1;
            // 
            // lblPatientPrenom
            // 
            this.lblPatientPrenom.AutoSize = true;
            this.lblPatientPrenom.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientPrenom.Location = new System.Drawing.Point(6, 20);
            this.lblPatientPrenom.Name = "lblPatientPrenom";
            this.lblPatientPrenom.Size = new System.Drawing.Size(50, 14);
            this.lblPatientPrenom.TabIndex = 0;
            this.lblPatientPrenom.Text = "Prenom :";
            this.lblPatientPrenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen_Finale__Hinde_.Properties.Resources._415;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gboxMedcin
            // 
            this.gboxMedcin.Controls.Add(this.cboxMatricule);
            this.gboxMedcin.Controls.Add(this.label2);
            this.gboxMedcin.Controls.Add(this.txtMedcinNom);
            this.gboxMedcin.Controls.Add(this.label4);
            this.gboxMedcin.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMedcin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gboxMedcin.Location = new System.Drawing.Point(434, 12);
            this.gboxMedcin.Name = "gboxMedcin";
            this.gboxMedcin.Size = new System.Drawing.Size(273, 86);
            this.gboxMedcin.TabIndex = 8;
            this.gboxMedcin.TabStop = false;
            this.gboxMedcin.Text = "Informations du Medcin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // txtMedcinNom
            // 
            this.txtMedcinNom.Location = new System.Drawing.Point(62, 17);
            this.txtMedcinNom.Name = "txtMedcinNom";
            this.txtMedcinNom.ReadOnly = true;
            this.txtMedcinNom.Size = new System.Drawing.Size(100, 20);
            this.txtMedcinNom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Matricule :";
            // 
            // rbGeneralist
            // 
            this.rbGeneralist.AutoSize = true;
            this.rbGeneralist.Location = new System.Drawing.Point(20, 32);
            this.rbGeneralist.Name = "rbGeneralist";
            this.rbGeneralist.Size = new System.Drawing.Size(78, 17);
            this.rbGeneralist.TabIndex = 9;
            this.rbGeneralist.TabStop = true;
            this.rbGeneralist.Text = "Généraliste";
            this.rbGeneralist.UseVisualStyleBackColor = true;
            // 
            // rbSpecialiste
            // 
            this.rbSpecialiste.AutoSize = true;
            this.rbSpecialiste.Location = new System.Drawing.Point(20, 65);
            this.rbSpecialiste.Name = "rbSpecialiste";
            this.rbSpecialiste.Size = new System.Drawing.Size(76, 17);
            this.rbSpecialiste.TabIndex = 10;
            this.rbSpecialiste.TabStop = true;
            this.rbSpecialiste.Text = "Spécialiste";
            this.rbSpecialiste.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type de Consulation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Urgence";
            // 
            // rbNon
            // 
            this.rbNon.AutoSize = true;
            this.rbNon.Location = new System.Drawing.Point(380, 159);
            this.rbNon.Name = "rbNon";
            this.rbNon.Size = new System.Drawing.Size(45, 17);
            this.rbNon.TabIndex = 13;
            this.rbNon.TabStop = true;
            this.rbNon.Text = "Non";
            this.rbNon.UseVisualStyleBackColor = true;
            // 
            // rbOui
            // 
            this.rbOui.AutoSize = true;
            this.rbOui.Location = new System.Drawing.Point(380, 126);
            this.rbOui.Name = "rbOui";
            this.rbOui.Size = new System.Drawing.Size(41, 17);
            this.rbOui.TabIndex = 12;
            this.rbOui.TabStop = true;
            this.rbOui.Text = "Oui";
            this.rbOui.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom Patient";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenom Patient";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom Medcin";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Matricule du Medcin";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type de Consulation";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Urgence";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cboxMatricule
            // 
            this.cboxMatricule.FormattingEnabled = true;
            this.cboxMatricule.Items.AddRange(new object[] {
            "JAD123",
            "NAH234",
            "QA567",
            "SO9876"});
            this.cboxMatricule.Location = new System.Drawing.Point(62, 44);
            this.cboxMatricule.Name = "cboxMatricule";
            this.cboxMatricule.Size = new System.Drawing.Size(121, 21);
            this.cboxMatricule.TabIndex = 17;
            this.cboxMatricule.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cboxMatricule.TextChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpecialiste);
            this.groupBox2.Controls.Add(this.rbGeneralist);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(154, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbNon);
            this.Controls.Add(this.rbOui);
            this.Controls.Add(this.gboxMedcin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxPatient);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvListeConsultation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Consultation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeConsultation)).EndInit();
            this.gboxPatient.ResumeLayout(false);
            this.gboxPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxMedcin.ResumeLayout(false);
            this.gboxMedcin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeConsultation;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.GroupBox gboxPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPatientPrenom;
        private System.Windows.Forms.Label lblPatientPrenom;
        private System.Windows.Forms.TextBox txtPatientNom;
        private System.Windows.Forms.Label lblPatientNom;
        private System.Windows.Forms.GroupBox gboxMedcin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedcinNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbGeneralist;
        private System.Windows.Forms.RadioButton rbSpecialiste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNon;
        private System.Windows.Forms.RadioButton rbOui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cboxMatricule;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


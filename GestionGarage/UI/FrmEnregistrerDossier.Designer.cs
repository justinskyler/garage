namespace UI
{
    partial class FrmEnregistrerCLientEtVoiture
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblreslt = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.TxtDossier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbCouleur = new System.Windows.Forms.ComboBox();
            this.NudAnnee = new System.Windows.Forms.NumericUpDown();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.TxtPlaque = new System.Windows.Forms.TextBox();
            this.TxtModele = new System.Windows.Forms.TextBox();
            this.TxtMarque = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdBNIF = new System.Windows.Forms.RadioButton();
            this.RdBCIN = new System.Windows.Forms.RadioButton();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskNif = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfenetre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnnee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblreslt);
            this.groupBox1.Controls.Add(this.BtnEnregistrer);
            this.groupBox1.Controls.Add(this.TxtDossier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblfenetre);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblreslt
            // 
            this.lblreslt.AutoSize = true;
            this.lblreslt.Location = new System.Drawing.Point(562, 307);
            this.lblreslt.Name = "lblreslt";
            this.lblreslt.Size = new System.Drawing.Size(0, 13);
            this.lblreslt.TabIndex = 16;
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(65, 264);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregistrer.TabIndex = 15;
            this.BtnEnregistrer.Text = "&Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // TxtDossier
            // 
            this.TxtDossier.Location = new System.Drawing.Point(733, 42);
            this.TxtDossier.Name = "TxtDossier";
            this.TxtDossier.Size = new System.Drawing.Size(118, 20);
            this.TxtDossier.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "No dossier";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbCouleur);
            this.groupBox3.Controls.Add(this.NudAnnee);
            this.groupBox3.Controls.Add(this.TxtSerie);
            this.groupBox3.Controls.Add(this.TxtType);
            this.groupBox3.Controls.Add(this.TxtPlaque);
            this.groupBox3.Controls.Add(this.TxtModele);
            this.groupBox3.Controls.Add(this.TxtMarque);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(377, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 204);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehicule";
            // 
            // CmbCouleur
            // 
            this.CmbCouleur.FormattingEnabled = true;
            this.CmbCouleur.Items.AddRange(new object[] {
            "Rouge",
            "Noir",
            "Jaune",
            "Marron",
            "Bleu",
            "Vert"});
            this.CmbCouleur.Location = new System.Drawing.Point(354, 70);
            this.CmbCouleur.Name = "CmbCouleur";
            this.CmbCouleur.Size = new System.Drawing.Size(102, 28);
            this.CmbCouleur.TabIndex = 13;
            // 
            // NudAnnee
            // 
            this.NudAnnee.Location = new System.Drawing.Point(354, 38);
            this.NudAnnee.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.NudAnnee.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.NudAnnee.Name = "NudAnnee";
            this.NudAnnee.Size = new System.Drawing.Size(102, 26);
            this.NudAnnee.TabIndex = 12;
            this.NudAnnee.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(91, 169);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(171, 26);
            this.TxtSerie.TabIndex = 11;
            // 
            // TxtType
            // 
            this.TxtType.Location = new System.Drawing.Point(91, 137);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(171, 26);
            this.TxtType.TabIndex = 10;
            // 
            // TxtPlaque
            // 
            this.TxtPlaque.Location = new System.Drawing.Point(91, 105);
            this.TxtPlaque.Name = "TxtPlaque";
            this.TxtPlaque.Size = new System.Drawing.Size(171, 26);
            this.TxtPlaque.TabIndex = 9;
            // 
            // TxtModele
            // 
            this.TxtModele.Location = new System.Drawing.Point(91, 73);
            this.TxtModele.Name = "TxtModele";
            this.TxtModele.Size = new System.Drawing.Size(171, 26);
            this.TxtModele.TabIndex = 8;
            // 
            // TxtMarque
            // 
            this.TxtMarque.Location = new System.Drawing.Point(91, 38);
            this.TxtMarque.Name = "TxtMarque";
            this.TxtMarque.Size = new System.Drawing.Size(171, 26);
            this.TxtMarque.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Couleur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Annee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Serie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Plaque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Modele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marque";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdBNIF);
            this.groupBox2.Controls.Add(this.RdBCIN);
            this.groupBox2.Controls.Add(this.TxtAdresse);
            this.groupBox2.Controls.Add(this.MskTel);
            this.groupBox2.Controls.Add(this.TxtPrenom);
            this.groupBox2.Controls.Add(this.TxtNom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MskNif);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proprietaire";
            // 
            // RdBNIF
            // 
            this.RdBNIF.AutoSize = true;
            this.RdBNIF.Location = new System.Drawing.Point(10, 101);
            this.RdBNIF.Name = "RdBNIF";
            this.RdBNIF.Size = new System.Drawing.Size(53, 24);
            this.RdBNIF.TabIndex = 12;
            this.RdBNIF.TabStop = true;
            this.RdBNIF.Text = "NIF";
            this.RdBNIF.UseVisualStyleBackColor = true;
            this.RdBNIF.CheckedChanged += new System.EventHandler(this.RdBNIF_CheckedChanged);
            // 
            // RdBCIN
            // 
            this.RdBCIN.AutoSize = true;
            this.RdBCIN.Location = new System.Drawing.Point(69, 101);
            this.RdBCIN.Name = "RdBCIN";
            this.RdBCIN.Size = new System.Drawing.Size(54, 24);
            this.RdBCIN.TabIndex = 11;
            this.RdBCIN.TabStop = true;
            this.RdBCIN.Text = "CIN";
            this.RdBCIN.UseVisualStyleBackColor = true;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Location = new System.Drawing.Point(146, 163);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(171, 26);
            this.TxtAdresse.TabIndex = 9;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(146, 131);
            this.MskTel.Mask = "+(5\\0\\9) 0000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(171, 26);
            this.MskTel.TabIndex = 8;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(146, 67);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(171, 26);
            this.TxtPrenom.TabIndex = 6;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(146, 35);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(171, 26);
            this.TxtNom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adresse";
            // 
            // MskNif
            // 
            this.MskNif.Location = new System.Drawing.Point(146, 99);
            this.MskNif.Mask = "000-000-000-0";
            this.MskNif.Name = "MskNif";
            this.MskNif.Size = new System.Drawing.Size(171, 26);
            this.MskNif.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // lblfenetre
            // 
            this.lblfenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfenetre.Location = new System.Drawing.Point(333, 9);
            this.lblfenetre.Name = "lblfenetre";
            this.lblfenetre.Size = new System.Drawing.Size(201, 39);
            this.lblfenetre.TabIndex = 1;
            this.lblfenetre.Text = "Ajouter Un vehicule";
            this.lblfenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEnregistrerCLientEtVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEnregistrerCLientEtVoiture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulaire d\'Enregistrement de Dossier";
            this.Load += new System.EventHandler(this.FrmEnregistrerCLientEtVoiture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnnee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblreslt;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.TextBox TxtDossier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbCouleur;
        private System.Windows.Forms.NumericUpDown NudAnnee;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.TextBox TxtPlaque;
        private System.Windows.Forms.TextBox TxtModele;
        private System.Windows.Forms.TextBox TxtMarque;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdBNIF;
        private System.Windows.Forms.RadioButton RdBCIN;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskNif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfenetre;


    }
}


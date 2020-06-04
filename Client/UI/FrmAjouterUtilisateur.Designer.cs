namespace UI
{
    partial class FrmAjouterUtilisateur
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFonction = new System.Windows.Forms.ComboBox();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMotdePasseConfirmation = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblconfirmerMotdePasse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblfonction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Location = new System.Drawing.Point(21, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 54);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(212, 19);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(131, 19);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(50, 19);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFonction);
            this.groupBox1.Controls.Add(this.txtMotdePasse);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.txtMotdePasseConfirmation);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.lblPseudo);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.lblMotdePasse);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.lblconfirmerMotdePasse);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.lblfonction);
            this.groupBox1.Location = new System.Drawing.Point(21, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 207);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cmbFonction
            // 
            this.cmbFonction.FormattingEnabled = true;
            this.cmbFonction.Items.AddRange(new object[] {
            "Secretaire",
            "Agent de vente",
            "Admin",
            "AdminSys"});
            this.cmbFonction.Location = new System.Drawing.Point(192, 166);
            this.cmbFonction.Name = "cmbFonction";
            this.cmbFonction.Size = new System.Drawing.Size(121, 21);
            this.cmbFonction.TabIndex = 12;
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotdePasse.Location = new System.Drawing.Point(192, 109);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.PasswordChar = '.';
            this.txtMotdePasse.Size = new System.Drawing.Size(121, 20);
            this.txtMotdePasse.TabIndex = 10;
            this.txtMotdePasse.UseSystemPasswordChar = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNom.Location = new System.Drawing.Point(33, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // txtMotdePasseConfirmation
            // 
            this.txtMotdePasseConfirmation.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.txtMotdePasseConfirmation.Location = new System.Drawing.Point(192, 136);
            this.txtMotdePasseConfirmation.Name = "txtMotdePasseConfirmation";
            this.txtMotdePasseConfirmation.PasswordChar = '.';
            this.txtMotdePasseConfirmation.Size = new System.Drawing.Size(121, 20);
            this.txtMotdePasseConfirmation.TabIndex = 11;
            this.txtMotdePasseConfirmation.UseSystemPasswordChar = true;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrenom.Location = new System.Drawing.Point(33, 60);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPseudo.Location = new System.Drawing.Point(33, 85);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(55, 16);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(192, 81);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(121, 20);
            this.txtPseudo.TabIndex = 9;
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMotdePasse.Location = new System.Drawing.Point(33, 113);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(91, 16);
            this.lblMotdePasse.TabIndex = 4;
            this.lblMotdePasse.Text = "Mot de Passe";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(192, 56);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // lblconfirmerMotdePasse
            // 
            this.lblconfirmerMotdePasse.AutoSize = true;
            this.lblconfirmerMotdePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblconfirmerMotdePasse.Location = new System.Drawing.Point(33, 140);
            this.lblconfirmerMotdePasse.Name = "lblconfirmerMotdePasse";
            this.lblconfirmerMotdePasse.Size = new System.Drawing.Size(151, 16);
            this.lblconfirmerMotdePasse.TabIndex = 5;
            this.lblconfirmerMotdePasse.Text = "Confirmer Mot de Passe";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(192, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 7;
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfonction.Location = new System.Drawing.Point(33, 166);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(59, 16);
            this.lblfonction.TabIndex = 6;
            this.lblfonction.Text = "Fonction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ajouter Utilisateur";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjouterUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Utilisateur";
            this.Load += new System.EventHandler(this.FrmAjouterUtilisateur_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFonction;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMotdePasseConfirmation;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblconfirmerMotdePasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblfonction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
    }
}
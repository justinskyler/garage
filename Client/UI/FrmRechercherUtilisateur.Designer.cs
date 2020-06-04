namespace UI
{
    partial class FrmRechercherUtilisateur
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPseudoRech = new System.Windows.Forms.Label();
            this.txtPseudoRech = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.txtDateAjout = new System.Windows.Forms.TextBox();
            this.lblDateAjout = new System.Windows.Forms.Label();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPseudoRech);
            this.groupBox2.Controls.Add(this.txtPseudoRech);
            this.groupBox2.Controls.Add(this.btnRechercher);
            this.groupBox2.Location = new System.Drawing.Point(23, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 50);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // lblPseudoRech
            // 
            this.lblPseudoRech.AutoSize = true;
            this.lblPseudoRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPseudoRech.Location = new System.Drawing.Point(13, 22);
            this.lblPseudoRech.Name = "lblPseudoRech";
            this.lblPseudoRech.Size = new System.Drawing.Size(55, 16);
            this.lblPseudoRech.TabIndex = 0;
            this.lblPseudoRech.Text = "Pseudo";
            // 
            // txtPseudoRech
            // 
            this.txtPseudoRech.Location = new System.Drawing.Point(79, 18);
            this.txtPseudoRech.Name = "txtPseudoRech";
            this.txtPseudoRech.Size = new System.Drawing.Size(100, 20);
            this.txtPseudoRech.TabIndex = 7;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(205, 15);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 16;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPseudo);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.lblFonction);
            this.groupBox1.Controls.Add(this.lblEtat);
            this.groupBox1.Controls.Add(this.txtDateAjout);
            this.groupBox1.Controls.Add(this.lblDateAjout);
            this.groupBox1.Controls.Add(this.txtEtat);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtFonction);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Location = new System.Drawing.Point(23, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 190);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPseudo.Location = new System.Drawing.Point(47, 75);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(55, 16);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblnom.Location = new System.Drawing.Point(47, 17);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(37, 16);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrenom.Location = new System.Drawing.Point(47, 47);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFonction.Location = new System.Drawing.Point(47, 103);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(59, 16);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction";
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEtat.Location = new System.Drawing.Point(47, 131);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(31, 16);
            this.lblEtat.TabIndex = 5;
            this.lblEtat.Text = "Etat";
            // 
            // txtDateAjout
            // 
            this.txtDateAjout.Location = new System.Drawing.Point(160, 158);
            this.txtDateAjout.Name = "txtDateAjout";
            this.txtDateAjout.Size = new System.Drawing.Size(100, 20);
            this.txtDateAjout.TabIndex = 13;
            // 
            // lblDateAjout
            // 
            this.lblDateAjout.AutoSize = true;
            this.lblDateAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDateAjout.Location = new System.Drawing.Point(47, 159);
            this.lblDateAjout.Name = "lblDateAjout";
            this.lblDateAjout.Size = new System.Drawing.Size(70, 16);
            this.lblDateAjout.TabIndex = 6;
            this.lblDateAjout.Text = "Date Ajout";
            // 
            // txtEtat
            // 
            this.txtEtat.Location = new System.Drawing.Point(160, 130);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(100, 20);
            this.txtEtat.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(160, 16);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(160, 102);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(100, 20);
            this.txtFonction.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(160, 46);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(160, 74);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 20);
            this.txtPseudo.TabIndex = 10;
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(88, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(195, 24);
            this.lblEntete.TabIndex = 20;
            this.lblEntete.Text = "Rechercher Utilisateur";
            // 
            // FrmRechercherUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEntete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRechercherUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher un Utilisateur";
            this.Load += new System.EventHandler(this.FrmRechercherUtilisateur_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPseudoRech;
        private System.Windows.Forms.TextBox txtPseudoRech;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.TextBox txtDateAjout;
        private System.Windows.Forms.Label lblDateAjout;
        private System.Windows.Forms.TextBox txtEtat;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label lblEntete;
    }
}
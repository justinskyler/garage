namespace UI
{
    partial class FrmModifierUtilisateur
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbFonction = new System.Windows.Forms.ComboBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPseudoRech = new System.Windows.Forms.Label();
            this.txtPseudoRech = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModifier);
            this.groupBox3.Controls.Add(this.btnQuitter);
            this.groupBox3.Controls.Add(this.btnAnnuler);
            this.groupBox3.Location = new System.Drawing.Point(10, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 54);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(23, 19);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(185, 19);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 25;
            this.btnQuitter.Text = "Qu&itter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(104, 19);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbFonction);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.lblFonction);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Location = new System.Drawing.Point(10, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 126);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // CmbFonction
            // 
            this.CmbFonction.FormattingEnabled = true;
            this.CmbFonction.Items.AddRange(new object[] {
            "Secretaire",
            "Agent de Vente",
            "Admin",
            "AdminSys"});
            this.CmbFonction.Location = new System.Drawing.Point(139, 84);
            this.CmbFonction.Name = "CmbFonction";
            this.CmbFonction.Size = new System.Drawing.Size(121, 21);
            this.CmbFonction.TabIndex = 10;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblnom.Location = new System.Drawing.Point(47, 25);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(37, 16);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrenom.Location = new System.Drawing.Point(47, 53);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFonction.Location = new System.Drawing.Point(47, 84);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(59, 16);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(139, 16);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(139, 46);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(75, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(162, 24);
            this.lblEntete.TabIndex = 27;
            this.lblEntete.Text = "Modifier Utilisateur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPseudoRech);
            this.groupBox2.Controls.Add(this.txtPseudoRech);
            this.groupBox2.Controls.Add(this.btnRechercher);
            this.groupBox2.Location = new System.Drawing.Point(10, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 50);
            this.groupBox2.TabIndex = 29;
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
            // FrmModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmModifierUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un Utilisateur";
            this.Load += new System.EventHandler(this.FrmModifierUtilisateur_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPseudoRech;
        private System.Windows.Forms.TextBox txtPseudoRech;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ComboBox CmbFonction;
    }
}
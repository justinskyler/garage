namespace UI
{
    partial class FrmConnexion
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
            this.lblentete = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblentete
            // 
            this.lblentete.AutoSize = true;
            this.lblentete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblentete.Location = new System.Drawing.Point(148, 9);
            this.lblentete.Name = "lblentete";
            this.lblentete.Size = new System.Drawing.Size(168, 25);
            this.lblentete.TabIndex = 10;
            this.lblentete.Text = "Connectez-vous";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomUtilisateur);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblMotdePasse);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.btnConnecter);
            this.groupBox1.Controls.Add(this.txtMotdePasse);
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(151, 21);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(99, 16);
            this.lblNomUtilisateur.TabIndex = 0;
            this.lblNomUtilisateur.Text = "Nom Utilisateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Connexion;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 109);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdePasse.Location = new System.Drawing.Point(159, 64);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(91, 16);
            this.lblMotdePasse.TabIndex = 1;
            this.lblMotdePasse.Text = "Mot de Passe";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(277, 105);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(252, 19);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 20);
            this.txtPseudo.TabIndex = 2;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(163, 104);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(75, 23);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "&Connexion";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.txtMotdePasse.Location = new System.Drawing.Point(252, 62);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotdePasse.TabIndex = 3;
            this.txtMotdePasse.UseSystemPasswordChar = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 207);
            this.Controls.Add(this.lblentete);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connectez-vous";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblentete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.ErrorProvider error;
    }
}
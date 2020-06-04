namespace UI
{
    partial class FrmModifierMotdePasse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAncien = new System.Windows.Forms.Label();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblConfirmer = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtAncien = new System.Windows.Forms.TextBox();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.txtConfirmer = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblAncien);
            this.groupBox1.Controls.Add(this.lblNouveau);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.lblConfirmer);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.txtAncien);
            this.groupBox1.Controls.Add(this.txtNouveau);
            this.groupBox1.Controls.Add(this.txtConfirmer);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 198);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(13, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblAncien
            // 
            this.lblAncien.AutoSize = true;
            this.lblAncien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAncien.Location = new System.Drawing.Point(126, 41);
            this.lblAncien.Name = "lblAncien";
            this.lblAncien.Size = new System.Drawing.Size(134, 16);
            this.lblAncien.TabIndex = 0;
            this.lblAncien.Text = "Ancien mot de passe";
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNouveau.Location = new System.Drawing.Point(126, 73);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(148, 16);
            this.lblNouveau.TabIndex = 1;
            this.lblNouveau.Text = "Nouveau mot de passe";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(369, 156);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Qu&itter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblConfirmer
            // 
            this.lblConfirmer.AutoSize = true;
            this.lblConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblConfirmer.Location = new System.Drawing.Point(126, 108);
            this.lblConfirmer.Name = "lblConfirmer";
            this.lblConfirmer.Size = new System.Drawing.Size(205, 16);
            this.lblConfirmer.TabIndex = 2;
            this.lblConfirmer.Text = "Confirmer nouveau mot de passe";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(279, 156);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 156);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtAncien
            // 
            this.txtAncien.Location = new System.Drawing.Point(344, 42);
            this.txtAncien.Name = "txtAncien";
            this.txtAncien.Size = new System.Drawing.Size(100, 20);
            this.txtAncien.TabIndex = 3;
            this.txtAncien.UseSystemPasswordChar = true;
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(344, 74);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(100, 20);
            this.txtNouveau.TabIndex = 4;
            this.txtNouveau.UseSystemPasswordChar = true;
            // 
            // txtConfirmer
            // 
            this.txtConfirmer.Location = new System.Drawing.Point(344, 109);
            this.txtConfirmer.Name = "txtConfirmer";
            this.txtConfirmer.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmer.TabIndex = 5;
            this.txtConfirmer.UseSystemPasswordChar = true;
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(157, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(196, 24);
            this.lblEntete.TabIndex = 20;
            this.lblEntete.Text = "Modifier Mot de Passe";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmModifierMotdePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEntete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifierMotdePasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier votre Mot de Passe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAncien;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtAncien;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.TextBox txtConfirmer;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.ErrorProvider error;
    }
}
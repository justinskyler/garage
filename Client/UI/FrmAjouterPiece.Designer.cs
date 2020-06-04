namespace UI
{
    partial class FrmAjouterPiece
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
            this.TxtNomPiece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtQuantite = new System.Windows.Forms.TextBox();
            this.TxtPrixPiece = new System.Windows.Forms.TextBox();
            this.TxtCodePiece = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblQuantite = new System.Windows.Forms.Label();
            this.LblPrix = new System.Windows.Forms.Label();
            this.LblCodePiece = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnregistrerPiece = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNomPiece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.TxtQuantite);
            this.groupBox1.Controls.Add(this.TxtPrixPiece);
            this.groupBox1.Controls.Add(this.TxtCodePiece);
            this.groupBox1.Controls.Add(this.LblDescription);
            this.groupBox1.Controls.Add(this.LblQuantite);
            this.groupBox1.Controls.Add(this.LblPrix);
            this.groupBox1.Controls.Add(this.LblCodePiece);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Pièce";
            // 
            // TxtNomPiece
            // 
            this.TxtNomPiece.Location = new System.Drawing.Point(155, 75);
            this.TxtNomPiece.Name = "TxtNomPiece";
            this.TxtNomPiece.Size = new System.Drawing.Size(151, 26);
            this.TxtNomPiece.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom Produit";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(254, 120);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(215, 85);
            this.TxtDescription.TabIndex = 7;
            // 
            // TxtQuantite
            // 
            this.TxtQuantite.Location = new System.Drawing.Point(409, 72);
            this.TxtQuantite.Name = "TxtQuantite";
            this.TxtQuantite.Size = new System.Drawing.Size(151, 26);
            this.TxtQuantite.TabIndex = 6;
            // 
            // TxtPrixPiece
            // 
            this.TxtPrixPiece.Location = new System.Drawing.Point(409, 40);
            this.TxtPrixPiece.Name = "TxtPrixPiece";
            this.TxtPrixPiece.Size = new System.Drawing.Size(151, 26);
            this.TxtPrixPiece.TabIndex = 5;
            // 
            // TxtCodePiece
            // 
            this.TxtCodePiece.Location = new System.Drawing.Point(155, 43);
            this.TxtCodePiece.Name = "TxtCodePiece";
            this.TxtCodePiece.Size = new System.Drawing.Size(151, 26);
            this.TxtCodePiece.TabIndex = 4;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(140, 151);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(89, 20);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description";
            // 
            // LblQuantite
            // 
            this.LblQuantite.AutoSize = true;
            this.LblQuantite.Location = new System.Drawing.Point(329, 75);
            this.LblQuantite.Name = "LblQuantite";
            this.LblQuantite.Size = new System.Drawing.Size(70, 20);
            this.LblQuantite.TabIndex = 2;
            this.LblQuantite.Text = "Quantite";
            // 
            // LblPrix
            // 
            this.LblPrix.AutoSize = true;
            this.LblPrix.Location = new System.Drawing.Point(329, 43);
            this.LblPrix.Name = "LblPrix";
            this.LblPrix.Size = new System.Drawing.Size(34, 20);
            this.LblPrix.TabIndex = 1;
            this.LblPrix.Text = "Prix";
            // 
            // LblCodePiece
            // 
            this.LblCodePiece.AutoSize = true;
            this.LblCodePiece.Location = new System.Drawing.Point(26, 46);
            this.LblCodePiece.Name = "LblCodePiece";
            this.LblCodePiece.Size = new System.Drawing.Size(90, 20);
            this.LblCodePiece.TabIndex = 0;
            this.LblCodePiece.Text = "Code Pièce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter Pièce";
            // 
            // BtnEnregistrerPiece
            // 
            this.BtnEnregistrerPiece.Location = new System.Drawing.Point(180, 264);
            this.BtnEnregistrerPiece.Name = "BtnEnregistrerPiece";
            this.BtnEnregistrerPiece.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregistrerPiece.TabIndex = 2;
            this.BtnEnregistrerPiece.Text = "&Enregistrer";
            this.BtnEnregistrerPiece.UseVisualStyleBackColor = true;
            this.BtnEnregistrerPiece.Click += new System.EventHandler(this.BtnEnregistrerPiece_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(272, 264);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 3;
            this.BtnAnnuler.Text = "&Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(366, 264);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "&Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmAjouterPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 298);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnEnregistrerPiece);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjouterPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer Un Produit";
            this.Load += new System.EventHandler(this.FrmAjouterPiece_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtQuantite;
        private System.Windows.Forms.TextBox TxtPrixPiece;
        private System.Windows.Forms.TextBox TxtCodePiece;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblQuantite;
        private System.Windows.Forms.Label LblPrix;
        private System.Windows.Forms.Label LblCodePiece;
        private System.Windows.Forms.Button BtnEnregistrerPiece;
        private System.Windows.Forms.TextBox TxtNomPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.ErrorProvider error;
    }
}
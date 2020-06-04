namespace UI
{
    partial class FrmModifierPiece
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkQuantite = new System.Windows.Forms.CheckBox();
            this.ChkPrix = new System.Windows.Forms.CheckBox();
            this.ChkNomPiece = new System.Windows.Forms.CheckBox();
            this.TxtQuantite = new System.Windows.Forms.TextBox();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.TxtNomPiece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TxtCodePiece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier un Pièce";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkQuantite);
            this.groupBox1.Controls.Add(this.ChkPrix);
            this.groupBox1.Controls.Add(this.ChkNomPiece);
            this.groupBox1.Controls.Add(this.TxtQuantite);
            this.groupBox1.Controls.Add(this.TxtPrix);
            this.groupBox1.Controls.Add(this.TxtNomPiece);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnRechercher);
            this.groupBox1.Controls.Add(this.TxtCodePiece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier un Pièce";
            // 
            // ChkQuantite
            // 
            this.ChkQuantite.AutoSize = true;
            this.ChkQuantite.Location = new System.Drawing.Point(298, 167);
            this.ChkQuantite.Name = "ChkQuantite";
            this.ChkQuantite.Size = new System.Drawing.Size(15, 14);
            this.ChkQuantite.TabIndex = 11;
            this.ChkQuantite.UseVisualStyleBackColor = true;
            this.ChkQuantite.CheckedChanged += new System.EventHandler(this.ChkQuantite_CheckedChanged);
            // 
            // ChkPrix
            // 
            this.ChkPrix.AutoSize = true;
            this.ChkPrix.Location = new System.Drawing.Point(298, 135);
            this.ChkPrix.Name = "ChkPrix";
            this.ChkPrix.Size = new System.Drawing.Size(15, 14);
            this.ChkPrix.TabIndex = 10;
            this.ChkPrix.UseVisualStyleBackColor = true;
            this.ChkPrix.CheckedChanged += new System.EventHandler(this.ChkPrix_CheckedChanged);
            // 
            // ChkNomPiece
            // 
            this.ChkNomPiece.AutoSize = true;
            this.ChkNomPiece.Location = new System.Drawing.Point(298, 103);
            this.ChkNomPiece.Name = "ChkNomPiece";
            this.ChkNomPiece.Size = new System.Drawing.Size(15, 14);
            this.ChkNomPiece.TabIndex = 9;
            this.ChkNomPiece.UseVisualStyleBackColor = true;
            this.ChkNomPiece.CheckedChanged += new System.EventHandler(this.ChkNomPiece_CheckedChanged);
            // 
            // TxtQuantite
            // 
            this.TxtQuantite.Location = new System.Drawing.Point(146, 161);
            this.TxtQuantite.Name = "TxtQuantite";
            this.TxtQuantite.Size = new System.Drawing.Size(144, 26);
            this.TxtQuantite.TabIndex = 8;
            // 
            // TxtPrix
            // 
            this.TxtPrix.Location = new System.Drawing.Point(146, 129);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(144, 26);
            this.TxtPrix.TabIndex = 7;
            // 
            // TxtNomPiece
            // 
            this.TxtNomPiece.Location = new System.Drawing.Point(146, 97);
            this.TxtNomPiece.Name = "TxtNomPiece";
            this.TxtNomPiece.Size = new System.Drawing.Size(144, 26);
            this.TxtNomPiece.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom Pièce";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.Location = new System.Drawing.Point(319, 34);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(75, 23);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtCodePiece
            // 
            this.TxtCodePiece.Location = new System.Drawing.Point(146, 32);
            this.TxtCodePiece.Name = "TxtCodePiece";
            this.TxtCodePiece.Size = new System.Drawing.Size(144, 26);
            this.TxtCodePiece.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Piece";
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(88, 251);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(75, 23);
            this.BtnModifier.TabIndex = 9;
            this.BtnModifier.Text = "&Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(178, 251);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 10;
            this.BtnAnnuler.Text = "&Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(265, 251);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 11;
            this.BtnQuitter.Text = "&Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmModifierPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 285);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifierPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un Pièce";
            this.Load += new System.EventHandler(this.FrmModifierPiece_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox TxtCodePiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.TextBox TxtQuantite;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.TextBox TxtNomPiece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkQuantite;
        private System.Windows.Forms.CheckBox ChkPrix;
        private System.Windows.Forms.CheckBox ChkNomPiece;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.ErrorProvider error;
    }
}
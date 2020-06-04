namespace UI
{
    partial class FrmVente
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
            this.lblqte = new System.Windows.Forms.Label();
            this.DgvVente = new System.Windows.Forms.DataGridView();
            this.codepiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtQuantite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtnomPiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TxtCodePiece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEffectuer = new System.Windows.Forms.Button();
            this.lblSomme = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Effectuer Vente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblqte);
            this.groupBox1.Controls.Add(this.DgvVente);
            this.groupBox1.Controls.Add(this.BtnOk);
            this.groupBox1.Controls.Add(this.TxtQuantite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtnomPiece);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnRechercher);
            this.groupBox1.Controls.Add(this.TxtCodePiece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effectuer Vente";
            // 
            // lblqte
            // 
            this.lblqte.Location = new System.Drawing.Point(150, 55);
            this.lblqte.Name = "lblqte";
            this.lblqte.Size = new System.Drawing.Size(215, 19);
            this.lblqte.TabIndex = 11;
            // 
            // DgvVente
            // 
            this.DgvVente.AllowUserToAddRows = false;
            this.DgvVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepiece,
            this.nom,
            this.prix,
            this.quant});
            this.DgvVente.Location = new System.Drawing.Point(20, 133);
            this.DgvVente.Name = "DgvVente";
            this.DgvVente.Size = new System.Drawing.Size(492, 164);
            this.DgvVente.TabIndex = 10;
            // 
            // codepiece
            // 
            this.codepiece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codepiece.DataPropertyName = "codepiece";
            this.codepiece.HeaderText = "Code Piece";
            this.codepiece.Name = "codepiece";
            this.codepiece.Width = 104;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom Piece";
            this.nom.Name = "nom";
            this.nom.Width = 115;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix ";
            this.prix.Name = "prix";
            this.prix.Width = 115;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "quant";
            this.quant.HeaderText = "Quantite";
            this.quant.Name = "quant";
            this.quant.Width = 115;
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(428, 105);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(39, 23);
            this.BtnOk.TabIndex = 9;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtQuantite
            // 
            this.TxtQuantite.Location = new System.Drawing.Point(296, 106);
            this.TxtQuantite.Name = "TxtQuantite";
            this.TxtQuantite.Size = new System.Drawing.Size(94, 22);
            this.TxtQuantite.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantite";
            // 
            // TxtPrix
            // 
            this.TxtPrix.Location = new System.Drawing.Point(175, 106);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(84, 22);
            this.TxtPrix.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix";
            // 
            // TxtnomPiece
            // 
            this.TxtnomPiece.Location = new System.Drawing.Point(20, 106);
            this.TxtnomPiece.Name = "TxtnomPiece";
            this.TxtnomPiece.Size = new System.Drawing.Size(117, 22);
            this.TxtnomPiece.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom Pièce";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.Location = new System.Drawing.Point(357, 21);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(61, 23);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Ok";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtCodePiece
            // 
            this.TxtCodePiece.Location = new System.Drawing.Point(197, 21);
            this.TxtCodePiece.Name = "TxtCodePiece";
            this.TxtCodePiece.Size = new System.Drawing.Size(146, 22);
            this.TxtCodePiece.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(104, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Piece";
            // 
            // BtnEffectuer
            // 
            this.BtnEffectuer.Location = new System.Drawing.Point(120, 346);
            this.BtnEffectuer.Name = "BtnEffectuer";
            this.BtnEffectuer.Size = new System.Drawing.Size(75, 23);
            this.BtnEffectuer.TabIndex = 2;
            this.BtnEffectuer.Text = "&Effectuer";
            this.BtnEffectuer.UseVisualStyleBackColor = true;
            this.BtnEffectuer.Click += new System.EventHandler(this.BtnEffectuer_Click);
            // 
            // lblSomme
            // 
            this.lblSomme.AutoSize = true;
            this.lblSomme.Location = new System.Drawing.Point(40, 20);
            this.lblSomme.Name = "lblSomme";
            this.lblSomme.Size = new System.Drawing.Size(0, 13);
            this.lblSomme.TabIndex = 3;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(216, 346);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "&Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(324, 346);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 5;
            this.BtnQuitter.Text = "&Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 395);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.lblSomme);
            this.Controls.Add(this.BtnEffectuer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Effectuer une Vente";
            this.Load += new System.EventHandler(this.FrmVente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtQuantite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtnomPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox TxtCodePiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnEffectuer;
        private System.Windows.Forms.Label lblSomme;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridView DgvVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.Label lblqte;
    }
}
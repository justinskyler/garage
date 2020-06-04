namespace UI
{
    partial class FrmRechercherPiece
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvPieces = new System.Windows.Forms.DataGridView();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TxtCodepiece = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher un Pièce";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvPieces);
            this.groupBox1.Controls.Add(this.BtnRechercher);
            this.groupBox1.Controls.Add(this.TxtCodepiece);
            this.groupBox1.Controls.Add(this.LblCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // DgvPieces
            // 
            this.DgvPieces.AllowUserToAddRows = false;
            this.DgvPieces.AllowUserToDeleteRows = false;
            this.DgvPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPieces.Location = new System.Drawing.Point(0, 98);
            this.DgvPieces.Name = "DgvPieces";
            this.DgvPieces.ReadOnly = true;
            this.DgvPieces.Size = new System.Drawing.Size(654, 177);
            this.DgvPieces.TabIndex = 3;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.Location = new System.Drawing.Point(369, 25);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(75, 23);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "&Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtCodepiece
            // 
            this.TxtCodepiece.Location = new System.Drawing.Point(158, 25);
            this.TxtCodepiece.Name = "TxtCodepiece";
            this.TxtCodepiece.Size = new System.Drawing.Size(192, 26);
            this.TxtCodepiece.TabIndex = 1;
            this.TxtCodepiece.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(22, 31);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(118, 20);
            this.LblCode.TabIndex = 0;
            this.LblCode.Text = "Code ou Libelle";
            // 
            // FrmRechercherPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmRechercherPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rechercher un Produit";
            this.Load += new System.EventHandler(this.FrmRechercherProduit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvPieces;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox TxtCodepiece;
        private System.Windows.Forms.Label LblCode;
    }
}
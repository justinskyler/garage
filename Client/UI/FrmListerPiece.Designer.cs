namespace UI
{
    partial class FrmListerPiece
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
            this.DgvsListerPieces = new System.Windows.Forms.DataGridView();
            this.CodePiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAjout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvsListerPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvsListerPieces
            // 
            this.DgvsListerPieces.AllowUserToAddRows = false;
            this.DgvsListerPieces.AllowUserToDeleteRows = false;
            this.DgvsListerPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvsListerPieces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodePiece,
            this.NomPiece,
            this.Description,
            this.Quantite,
            this.DateAjout});
            this.DgvsListerPieces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvsListerPieces.Location = new System.Drawing.Point(0, 0);
            this.DgvsListerPieces.Name = "DgvsListerPieces";
            this.DgvsListerPieces.ReadOnly = true;
            this.DgvsListerPieces.Size = new System.Drawing.Size(544, 277);
            this.DgvsListerPieces.TabIndex = 0;
            // 
            // CodePiece
            // 
            this.CodePiece.DataPropertyName = "CodePiece";
            this.CodePiece.HeaderText = "Code";
            this.CodePiece.Name = "CodePiece";
            this.CodePiece.ReadOnly = true;
            // 
            // NomPiece
            // 
            this.NomPiece.DataPropertyName = "NomPiece";
            this.NomPiece.HeaderText = "Nom Piece";
            this.NomPiece.Name = "NomPiece";
            this.NomPiece.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "Quantite";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // DateAjout
            // 
            this.DateAjout.DataPropertyName = "DateAjout";
            this.DateAjout.HeaderText = "DateAjout";
            this.DateAjout.Name = "DateAjout";
            this.DateAjout.ReadOnly = true;
            // 
            // FrmListerPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 277);
            this.Controls.Add(this.DgvsListerPieces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListerPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Pieces";
            this.Load += new System.EventHandler(this.FrmListerPiece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvsListerPieces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvsListerPieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAjout;
    }
}
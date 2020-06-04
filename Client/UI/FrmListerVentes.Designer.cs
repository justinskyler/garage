namespace UI
{
    partial class FrmListerVentes
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
            this.LblEntete = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgvlister = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlister)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEntete
            // 
            this.LblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LblEntete.Location = new System.Drawing.Point(246, 9);
            this.LblEntete.Name = "LblEntete";
            this.LblEntete.Size = new System.Drawing.Size(182, 23);
            this.LblEntete.TabIndex = 5;
            this.LblEntete.Text = "Lister Les ventes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgvlister);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Dgvlister
            // 
            this.Dgvlister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvlister.Location = new System.Drawing.Point(8, 25);
            this.Dgvlister.Name = "Dgvlister";
            this.Dgvlister.Size = new System.Drawing.Size(641, 174);
            this.Dgvlister.TabIndex = 2;
            // 
            // FrmListerVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 265);
            this.Controls.Add(this.LblEntete);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListerVentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister Ventes";
            this.Load += new System.EventHandler(this.FrmListerVentes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblEntete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgvlister;
    }
}
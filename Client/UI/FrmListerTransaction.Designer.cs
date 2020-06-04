namespace UI
{
    partial class FrmListerTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvLister = new System.Windows.Forms.DataGridView();
            this.Btnrechercher = new System.Windows.Forms.Button();
            this.TxtRech = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLister)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvLister);
            this.groupBox1.Controls.Add(this.Btnrechercher);
            this.groupBox1.Controls.Add(this.TxtRech);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DgvLister
            // 
            this.DgvLister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLister.Location = new System.Drawing.Point(6, 75);
            this.DgvLister.Name = "DgvLister";
            this.DgvLister.Size = new System.Drawing.Size(440, 163);
            this.DgvLister.TabIndex = 3;
            // 
            // Btnrechercher
            // 
            this.Btnrechercher.Location = new System.Drawing.Point(253, 34);
            this.Btnrechercher.Name = "Btnrechercher";
            this.Btnrechercher.Size = new System.Drawing.Size(75, 23);
            this.Btnrechercher.TabIndex = 2;
            this.Btnrechercher.Text = "Rechercher";
            this.Btnrechercher.UseVisualStyleBackColor = true;
            this.Btnrechercher.Click += new System.EventHandler(this.Btnrechercher_Click);
            // 
            // TxtRech
            // 
            this.TxtRech.Location = new System.Drawing.Point(130, 36);
            this.TxtRech.Name = "TxtRech";
            this.TxtRech.Size = new System.Drawing.Size(100, 20);
            this.TxtRech.TabIndex = 1;
            this.TxtRech.TextChanged += new System.EventHandler(this.TxtRech_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(111, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechercher transaction";
            // 
            // FrmListerTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListerTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister Transaction";
            this.Load += new System.EventHandler(this.FrmListerTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnrechercher;
        private System.Windows.Forms.TextBox TxtRech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLister;
        private System.Windows.Forms.Label label2;
    }
}
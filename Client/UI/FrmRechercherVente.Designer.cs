namespace UI
{
    partial class FrmRechercherVente
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
            this.Dgvlister = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TxtCoderecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEntete = new System.Windows.Forms.Label();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlister)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgvlister);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Dgvlister
            // 
            this.Dgvlister.AllowUserToAddRows = false;
            this.Dgvlister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvlister.Location = new System.Drawing.Point(3, 104);
            this.Dgvlister.Name = "Dgvlister";
            this.Dgvlister.Size = new System.Drawing.Size(631, 174);
            this.Dgvlister.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRechercher);
            this.groupBox2.Controls.Add(this.TxtCoderecherche);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(110, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Location = new System.Drawing.Point(268, 22);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(75, 23);
            this.BtnRechercher.TabIndex = 1;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtCoderecherche
            // 
            this.TxtCoderecherche.Location = new System.Drawing.Point(124, 25);
            this.TxtCoderecherche.Name = "TxtCoderecherche";
            this.TxtCoderecherche.Size = new System.Drawing.Size(127, 20);
            this.TxtCoderecherche.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Vente";
            // 
            // LblEntete
            // 
            this.LblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LblEntete.Location = new System.Drawing.Point(232, 5);
            this.LblEntete.Name = "LblEntete";
            this.LblEntete.Size = new System.Drawing.Size(191, 23);
            this.LblEntete.TabIndex = 2;
            this.LblEntete.Text = "Rechercher Vente";
            // 
            // Erreur
            // 
            this.Erreur.ContainerControl = this;
            // 
            // FrmRechercherVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEntete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRechercherVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher Vente";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlister)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgvlister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox TxtCoderecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEntete;
        private System.Windows.Forms.ErrorProvider Erreur;
    }
}
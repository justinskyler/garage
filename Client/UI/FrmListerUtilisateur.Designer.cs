namespace UI
{
    partial class FrmListerUtilisateur
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
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblEntete = new System.Windows.Forms.Label();
            this.dgvLister = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAjout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLister)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(303, 56);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(218, 63);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(63, 13);
            this.lblRecherche.TabIndex = 6;
            this.lblRecherche.Text = "Rechercher";
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(217, 15);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(176, 24);
            this.lblEntete.TabIndex = 5;
            this.lblEntete.Text = "Tous les Utilisateurs";
            // 
            // dgvLister
            // 
            this.dgvLister.AllowUserToDeleteRows = false;
            this.dgvLister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.Pseudo,
            this.Fonction,
            this.Etat,
            this.DateAjout});
            this.dgvLister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLister.Location = new System.Drawing.Point(0, 105);
            this.dgvLister.Name = "dgvLister";
            this.dgvLister.ReadOnly = true;
            this.dgvLister.Size = new System.Drawing.Size(643, 137);
            this.dgvLister.TabIndex = 4;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Pseudo
            // 
            this.Pseudo.DataPropertyName = "Pseudo";
            this.Pseudo.HeaderText = "Pseudo";
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.ReadOnly = true;
            // 
            // Fonction
            // 
            this.Fonction.DataPropertyName = "Fonction";
            this.Fonction.HeaderText = "Fonction";
            this.Fonction.Name = "Fonction";
            this.Fonction.ReadOnly = true;
            // 
            // Etat
            // 
            this.Etat.DataPropertyName = "Etat";
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // DateAjout
            // 
            this.DateAjout.DataPropertyName = "DateAjout";
            this.DateAjout.HeaderText = "DateAjout";
            this.DateAjout.Name = "DateAjout";
            this.DateAjout.ReadOnly = true;
            // 
            // FrmListerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 242);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(this.dgvLister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListerUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Utilisateurs";
            this.Load += new System.EventHandler(this.FrmListerUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.DataGridView dgvLister;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAjout;
    }
}
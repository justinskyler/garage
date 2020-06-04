namespace UI
{
    partial class FrmPrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pièceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquerDebloquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.venteToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.pièceToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.utilisateurToolStripMenuItem,
            this.barRestaurantToolStripMenuItem,
            this.transfertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connecterToolStripMenuItem,
            this.deconnecterToolStripMenuItem,
            this.changerMotDePasseToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // connecterToolStripMenuItem
            // 
            this.connecterToolStripMenuItem.Name = "connecterToolStripMenuItem";
            this.connecterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.connecterToolStripMenuItem.Text = "Connecter";
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deconnecterToolStripMenuItem.Text = "Deconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // changerMotDePasseToolStripMenuItem
            // 
            this.changerMotDePasseToolStripMenuItem.Name = "changerMotDePasseToolStripMenuItem";
            this.changerMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.changerMotDePasseToolStripMenuItem.Text = "Changer Mot de Passe";
            this.changerMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMotDePasseToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectuerToolStripMenuItem,
            this.annulerToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.listerToolStripMenuItem});
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.venteToolStripMenuItem.Text = "Vente";
            // 
            // effectuerToolStripMenuItem
            // 
            this.effectuerToolStripMenuItem.Name = "effectuerToolStripMenuItem";
            this.effectuerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.effectuerToolStripMenuItem.Text = "Effectuer";
            this.effectuerToolStripMenuItem.Click += new System.EventHandler(this.effectuerToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.listerToolStripMenuItem.Text = "Lister";
            this.listerToolStripMenuItem.Click += new System.EventHandler(this.listerToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verifierToolStripMenuItem,
            this.ajusterToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // verifierToolStripMenuItem
            // 
            this.verifierToolStripMenuItem.Name = "verifierToolStripMenuItem";
            this.verifierToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.verifierToolStripMenuItem.Text = "Verifier";
            this.verifierToolStripMenuItem.Click += new System.EventHandler(this.verifierToolStripMenuItem_Click);
            // 
            // ajusterToolStripMenuItem
            // 
            this.ajusterToolStripMenuItem.Name = "ajusterToolStripMenuItem";
            this.ajusterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ajusterToolStripMenuItem.Text = "Ajuster";
            this.ajusterToolStripMenuItem.Click += new System.EventHandler(this.ajusterToolStripMenuItem_Click);
            // 
            // pièceToolStripMenuItem
            // 
            this.pièceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.rechercherToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.listerToolStripMenuItem1});
            this.pièceToolStripMenuItem.Name = "pièceToolStripMenuItem";
            this.pièceToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.pièceToolStripMenuItem.Text = "Pièce";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem1
            // 
            this.rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            this.rechercherToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem1.Text = "Rechercher";
            this.rechercherToolStripMenuItem1.Click += new System.EventHandler(this.rechercherToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // listerToolStripMenuItem1
            // 
            this.listerToolStripMenuItem1.Name = "listerToolStripMenuItem1";
            this.listerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.listerToolStripMenuItem1.Text = "Lister";
            this.listerToolStripMenuItem1.Click += new System.EventHandler(this.listerToolStripMenuItem1_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.créerToolStripMenuItem.Text = "Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.rechercherToolStripMenuItem2,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.listerToolStripMenuItem2,
            this.rechercherTransactionToolStripMenuItem});
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem2
            // 
            this.rechercherToolStripMenuItem2.Name = "rechercherToolStripMenuItem2";
            this.rechercherToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.rechercherToolStripMenuItem2.Text = "Rechercher";
            this.rechercherToolStripMenuItem2.Click += new System.EventHandler(this.rechercherToolStripMenuItem2_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierUnUtilisateurToolStripMenuItem,
            this.bloquerDebloquerToolStripMenuItem});
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            // 
            // modifierUnUtilisateurToolStripMenuItem
            // 
            this.modifierUnUtilisateurToolStripMenuItem.Name = "modifierUnUtilisateurToolStripMenuItem";
            this.modifierUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modifierUnUtilisateurToolStripMenuItem.Text = "Modifier un Utilisateur";
            this.modifierUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.modifierUnUtilisateurToolStripMenuItem_Click);
            // 
            // bloquerDebloquerToolStripMenuItem
            // 
            this.bloquerDebloquerToolStripMenuItem.Name = "bloquerDebloquerToolStripMenuItem";
            this.bloquerDebloquerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bloquerDebloquerToolStripMenuItem.Text = "Bloquer / Debloquer";
            this.bloquerDebloquerToolStripMenuItem.Click += new System.EventHandler(this.bloquerDebloquerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // listerToolStripMenuItem2
            // 
            this.listerToolStripMenuItem2.Name = "listerToolStripMenuItem2";
            this.listerToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.listerToolStripMenuItem2.Text = "Lister";
            this.listerToolStripMenuItem2.Click += new System.EventHandler(this.listerToolStripMenuItem2_Click);
            // 
            // rechercherTransactionToolStripMenuItem
            // 
            this.rechercherTransactionToolStripMenuItem.Name = "rechercherTransactionToolStripMenuItem";
            this.rechercherTransactionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.rechercherTransactionToolStripMenuItem.Text = "Rechercher Transaction";
            this.rechercherTransactionToolStripMenuItem.Click += new System.EventHandler(this.rechercherTransactionToolStripMenuItem_Click);
            // 
            // barRestaurantToolStripMenuItem
            // 
            this.barRestaurantToolStripMenuItem.Name = "barRestaurantToolStripMenuItem";
            this.barRestaurantToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.barRestaurantToolStripMenuItem.Text = "Bar Restaurant";
            // 
            // transfertToolStripMenuItem
            // 
            this.transfertToolStripMenuItem.Name = "transfertToolStripMenuItem";
            this.transfertToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.transfertToolStripMenuItem.Text = "Transfert";
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 421);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipale";
            this.Text = "Fenetre Principale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipale_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pièceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquerDebloquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherTransactionToolStripMenuItem;
    }
}
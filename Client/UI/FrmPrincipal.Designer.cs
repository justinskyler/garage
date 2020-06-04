namespace UI
{
    partial class FrmPrincipal
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
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerPièceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.augmenterStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barRestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquerDebloquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblStatut = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.autoPartsToolStripMenuItem,
            this.garageToolStripMenuItem,
            this.barRestoToolStripMenuItem,
            this.transfertToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connecterToolStripMenuItem,
            this.deconnecterToolStripMenuItem,
            this.changerMotDePasseToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // connecterToolStripMenuItem
            // 
            this.connecterToolStripMenuItem.Name = "connecterToolStripMenuItem";
            this.connecterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.connecterToolStripMenuItem.Text = "Connecter";
            this.connecterToolStripMenuItem.Click += new System.EventHandler(this.connecterToolStripMenuItem_Click);
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
            // autoPartsToolStripMenuItem
            // 
            this.autoPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectuerVenteToolStripMenuItem,
            this.annulerVenteToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.listerPièceToolStripMenuItem,
            this.supprimerPieceToolStripMenuItem,
            this.ajouterPieceToolStripMenuItem,
            this.rapportsToolStripMenuItem,
            this.augmenterStockToolStripMenuItem});
            this.autoPartsToolStripMenuItem.Name = "autoPartsToolStripMenuItem";
            this.autoPartsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.autoPartsToolStripMenuItem.Text = "Auto-Parts";
            // 
            // effectuerVenteToolStripMenuItem
            // 
            this.effectuerVenteToolStripMenuItem.Name = "effectuerVenteToolStripMenuItem";
            this.effectuerVenteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.effectuerVenteToolStripMenuItem.Text = "Effectuer Vente";
            this.effectuerVenteToolStripMenuItem.Click += new System.EventHandler(this.effectuerVenteToolStripMenuItem_Click);
            // 
            // annulerVenteToolStripMenuItem
            // 
            this.annulerVenteToolStripMenuItem.Name = "annulerVenteToolStripMenuItem";
            this.annulerVenteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.annulerVenteToolStripMenuItem.Text = "Annuler Vente";
            this.annulerVenteToolStripMenuItem.Click += new System.EventHandler(this.annulerVenteToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rechercherToolStripMenuItem.Text = "Verifier Stock";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // listerPièceToolStripMenuItem
            // 
            this.listerPièceToolStripMenuItem.Name = "listerPièceToolStripMenuItem";
            this.listerPièceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listerPièceToolStripMenuItem.Text = "Lister Pièce";
            this.listerPièceToolStripMenuItem.Click += new System.EventHandler(this.listerPièceToolStripMenuItem_Click);
            // 
            // supprimerPieceToolStripMenuItem
            // 
            this.supprimerPieceToolStripMenuItem.Name = "supprimerPieceToolStripMenuItem";
            this.supprimerPieceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.supprimerPieceToolStripMenuItem.Text = "Supprimer Piece";
            this.supprimerPieceToolStripMenuItem.Click += new System.EventHandler(this.supprimerPieceToolStripMenuItem_Click);
            // 
            // ajouterPieceToolStripMenuItem
            // 
            this.ajouterPieceToolStripMenuItem.Name = "ajouterPieceToolStripMenuItem";
            this.ajouterPieceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ajouterPieceToolStripMenuItem.Text = "Ajouter piece";
            this.ajouterPieceToolStripMenuItem.Click += new System.EventHandler(this.ajouterPieceToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            this.rapportsToolStripMenuItem.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // augmenterStockToolStripMenuItem
            // 
            this.augmenterStockToolStripMenuItem.Name = "augmenterStockToolStripMenuItem";
            this.augmenterStockToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.augmenterStockToolStripMenuItem.Text = "Augmenter Stock";
            this.augmenterStockToolStripMenuItem.Click += new System.EventHandler(this.augmenterStockToolStripMenuItem_Click);
            // 
            // garageToolStripMenuItem
            // 
            this.garageToolStripMenuItem.Name = "garageToolStripMenuItem";
            this.garageToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.garageToolStripMenuItem.Text = "Garage";
            // 
            // barRestoToolStripMenuItem
            // 
            this.barRestoToolStripMenuItem.Name = "barRestoToolStripMenuItem";
            this.barRestoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.barRestoToolStripMenuItem.Text = "Bar Resto";
            // 
            // transfertToolStripMenuItem
            // 
            this.transfertToolStripMenuItem.Name = "transfertToolStripMenuItem";
            this.transfertToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.transfertToolStripMenuItem.Text = "Transfert";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aJouterToolStripMenuItem,
            this.rechercherToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.listerToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // aJouterToolStripMenuItem
            // 
            this.aJouterToolStripMenuItem.Name = "aJouterToolStripMenuItem";
            this.aJouterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aJouterToolStripMenuItem.Text = "AJouter";
            this.aJouterToolStripMenuItem.Click += new System.EventHandler(this.aJouterToolStripMenuItem_Click);
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
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.bloquerDebloquerToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.utilisateurToolStripMenuItem.Text = "Modifier un Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // bloquerDebloquerToolStripMenuItem
            // 
            this.bloquerDebloquerToolStripMenuItem.Name = "bloquerDebloquerToolStripMenuItem";
            this.bloquerDebloquerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bloquerDebloquerToolStripMenuItem.Text = "Bloquer/Debloquer";
            this.bloquerDebloquerToolStripMenuItem.Click += new System.EventHandler(this.bloquerDebloquerToolStripMenuItem_Click);
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.listerToolStripMenuItem.Text = "Lister";
            this.listerToolStripMenuItem.Click += new System.EventHandler(this.listerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // LblStatut
            // 
            this.LblStatut.AutoEllipsis = true;
            this.LblStatut.AutoSize = true;
            this.LblStatut.Location = new System.Drawing.Point(496, 1);
            this.LblStatut.Name = "LblStatut";
            this.LblStatut.Size = new System.Drawing.Size(0, 13);
            this.LblStatut.TabIndex = 2;
            this.LblStatut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 380);
            this.Controls.Add(this.LblStatut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Fenetre Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectuerVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerPièceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barRestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquerDebloquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label LblStatut;
        private System.Windows.Forms.ToolStripMenuItem ajouterPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augmenterStockToolStripMenuItem;
    }
}
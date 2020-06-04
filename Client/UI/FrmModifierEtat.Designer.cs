namespace UI
{
    partial class FrmModifierEtat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdebloque = new System.Windows.Forms.RadioButton();
            this.rdbbloque = new System.Windows.Forms.RadioButton();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.btnEffectuer = new System.Windows.Forms.Button();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Controls.Add(this.lblPseudo);
            this.groupBox2.Controls.Add(this.btnEffectuer);
            this.groupBox2.Controls.Add(this.txtPseudo);
            this.groupBox2.Location = new System.Drawing.Point(26, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdebloque);
            this.groupBox1.Controls.Add(this.rdbbloque);
            this.groupBox1.Location = new System.Drawing.Point(49, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rdbdebloque
            // 
            this.rdbdebloque.AutoSize = true;
            this.rdbdebloque.Location = new System.Drawing.Point(94, 17);
            this.rdbdebloque.Name = "rdbdebloque";
            this.rdbdebloque.Size = new System.Drawing.Size(71, 17);
            this.rdbdebloque.TabIndex = 3;
            this.rdbdebloque.TabStop = true;
            this.rdbdebloque.Text = "Debloqué";
            this.rdbdebloque.UseVisualStyleBackColor = true;
            this.rdbdebloque.CheckedChanged += new System.EventHandler(this.rdbdebloque_CheckedChanged);
            // 
            // rdbbloque
            // 
            this.rdbbloque.AutoSize = true;
            this.rdbbloque.Location = new System.Drawing.Point(21, 17);
            this.rdbbloque.Name = "rdbbloque";
            this.rdbbloque.Size = new System.Drawing.Size(58, 17);
            this.rdbbloque.TabIndex = 2;
            this.rdbbloque.TabStop = true;
            this.rdbbloque.Text = "Bloqué";
            this.rdbbloque.UseVisualStyleBackColor = true;
            this.rdbbloque.CheckedChanged += new System.EventHandler(this.rdbbloque_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(153, 107);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "&Quitter";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPseudo.Location = new System.Drawing.Point(15, 23);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(107, 16);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Entrer le Pseudo";
            // 
            // btnEffectuer
            // 
            this.btnEffectuer.Location = new System.Drawing.Point(53, 107);
            this.btnEffectuer.Name = "btnEffectuer";
            this.btnEffectuer.Size = new System.Drawing.Size(75, 23);
            this.btnEffectuer.TabIndex = 5;
            this.btnEffectuer.Text = "&Effectuer";
            this.btnEffectuer.UseVisualStyleBackColor = true;
            this.btnEffectuer.Click += new System.EventHandler(this.btnEffectuer_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(128, 22);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 20);
            this.txtPseudo.TabIndex = 4;
            this.txtPseudo.TextChanged += new System.EventHandler(this.txtPseudo_TextChanged);
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(108, 7);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(113, 24);
            this.lblEntete.TabIndex = 9;
            this.lblEntete.Text = "Modifier Etat";
            // 
            // FrmModifierEtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEntete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifierEtat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloquer/Debloquer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdebloque;
        private System.Windows.Forms.RadioButton rdbbloque;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Button btnEffectuer;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label lblEntete;
    }
}
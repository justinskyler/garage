namespace UI
{
    partial class FrmConfiguration
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.txtip = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.Label();
            this.lblstatut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Configuration du Serveur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Location = new System.Drawing.Point(212, 142);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(103, 46);
            this.btnenregistrer.TabIndex = 11;
            this.btnenregistrer.Text = "Enregistrer Adresse Serveur";
            this.btnenregistrer.UseVisualStyleBackColor = true;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(50, 140);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(103, 48);
            this.btntest.TabIndex = 10;
            this.btntest.Text = "Tester la connection";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(50, 92);
            this.txtip.MaxLength = 50;
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(265, 29);
            this.txtip.TabIndex = 9;
            this.txtip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(98, 65);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(172, 24);
            this.ip.TabIndex = 8;
            this.ip.Text = "Adresse IP Serveur";
            // 
            // lblstatut
            // 
            this.lblstatut.AutoSize = true;
            this.lblstatut.Location = new System.Drawing.Point(285, 50);
            this.lblstatut.Name = "lblstatut";
            this.lblstatut.Size = new System.Drawing.Size(0, 13);
            this.lblstatut.TabIndex = 13;
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 237);
            this.Controls.Add(this.lblstatut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.ip);
            this.Name = "FrmConfiguration";
            this.Text = "FrmConfiguration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguration_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label lblstatut;
    }
}
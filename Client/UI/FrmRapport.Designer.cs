namespace UI
{
    partial class FrmRapport
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
            this.lblmessage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dtpdebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DgvRapport = new System.Windows.Forms.DataGridView();
            this.text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbMois = new System.Windows.Forms.RadioButton();
            this.RdbJournalier = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRapport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(80, 16);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dtpdebut);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DtpFin);
            this.groupBox2.Location = new System.Drawing.Point(158, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 57);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Dtpdebut
            // 
            this.Dtpdebut.Location = new System.Drawing.Point(71, 23);
            this.Dtpdebut.Name = "Dtpdebut";
            this.Dtpdebut.Size = new System.Drawing.Size(168, 20);
            this.Dtpdebut.TabIndex = 0;
            this.Dtpdebut.ValueChanged += new System.EventHandler(this.Dtpdebut_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Debut";
            // 
            // DtpFin
            // 
            this.DtpFin.Location = new System.Drawing.Point(311, 23);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(162, 20);
            this.DtpFin.TabIndex = 1;
            this.DtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(571, 359);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 13;
            this.BtnPrint.Text = "Imprimer";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DgvRapport
            // 
            this.DgvRapport.AllowUserToAddRows = false;
            this.DgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRapport.Location = new System.Drawing.Point(9, 97);
            this.DgvRapport.Name = "DgvRapport";
            this.DgvRapport.Size = new System.Drawing.Size(637, 256);
            this.DgvRapport.TabIndex = 12;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(115, 187);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 13);
            this.text.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(275, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rapports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbMois);
            this.groupBox1.Controls.Add(this.RdbJournalier);
            this.groupBox1.Location = new System.Drawing.Point(9, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 57);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afficher par";
            // 
            // RdbMois
            // 
            this.RdbMois.AutoSize = true;
            this.RdbMois.Location = new System.Drawing.Point(78, 27);
            this.RdbMois.Name = "RdbMois";
            this.RdbMois.Size = new System.Drawing.Size(47, 17);
            this.RdbMois.TabIndex = 8;
            this.RdbMois.TabStop = true;
            this.RdbMois.Text = "Mois";
            this.RdbMois.UseVisualStyleBackColor = true;
            this.RdbMois.CheckedChanged += new System.EventHandler(this.RdbMois_CheckedChanged);
            // 
            // RdbJournalier
            // 
            this.RdbJournalier.AutoSize = true;
            this.RdbJournalier.Location = new System.Drawing.Point(14, 26);
            this.RdbJournalier.Name = "RdbJournalier";
            this.RdbJournalier.Size = new System.Drawing.Size(45, 17);
            this.RdbJournalier.TabIndex = 7;
            this.RdbJournalier.TabStop = true;
            this.RdbJournalier.Text = "Jour";
            this.RdbJournalier.UseVisualStyleBackColor = true;
            this.RdbJournalier.CheckedChanged += new System.EventHandler(this.RdbJournalier_CheckedChanged);
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DgvRapport);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FrmRapport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRapport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Dtpdebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView DgvRapport;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbMois;
        private System.Windows.Forms.RadioButton RdbJournalier;
    }
}
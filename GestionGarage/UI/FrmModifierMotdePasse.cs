using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controleur;
namespace UI
{
    public partial class FrmModifierMotdePasse : Form
    {
        public ControleurUtilisateurs ctu;
        public string pseud;
        public FrmModifierMotdePasse(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctu = new ControleurUtilisateurs();
            ctu = ctc;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string ancien = txtAncien.Text;
            string nouveau = txtNouveau.Text;
            string con = txtConfirmer.Text;
            error.Clear();
            if (ctu.NumberValidationTextBox(txtAncien.Text) || ancien.Equals(String.Empty))
            {
                error.SetError(txtAncien, "entrer votre ancien mot de passe");
            }
            else
            {
                error.Clear();
                if (ctu.NumberValidationTextBox(txtNouveau.Text) || nouveau.Equals(String.Empty))
                {
                    error.SetError(txtNouveau, "entrer un ancien mot de passe");

                }
                else
                {
                    error.Clear();
                    if (ctu.NumberValidationTextBox(txtConfirmer.Text) || con.Equals(String.Empty))
                    {
                        error.SetError(txtConfirmer, "confirmer votre mot de passe");
                    }
                    else
                    {

                        if (ctu.retournerMotdePasse() != txtAncien.Text.Trim())
                        {

                            MessageBox.Show("Ancien mot de passe incorrect \n entrer votre ancien mot de passe");
                            txtAncien.Text = "";
                            txtNouveau.Text = "";
                            txtConfirmer.Text = "";
                            txtAncien.Focus();
                        }
                        else
                        {

                            if (txtNouveau.Text != txtConfirmer.Text)
                            {
                                MessageBox.Show("Mot de passe et mot de passe confirmation doivent etre identique");
                                txtAncien.Text = "";
                                txtNouveau.Text = "";
                                txtConfirmer.Text = "";
                                txtAncien.Focus();
                            }
                            else
                            {

                                ctu.ModifierMotdePasse(ctu.retournerPseudo(), txtConfirmer.Text);

                                Random co = new Random();
                                int code = co.Next(100000, 900000);

                                ctu.retracerutilisateur("Trans-" + code, ctu.retournerPseudo(), "Modifier mot de passe", DateTime.Now.ToString());
                                
                                
                                txtAncien.Text = "";
                                txtNouveau.Text = "";
                                txtConfirmer.Text = "";
                                this.Close();
                                MessageBox.Show("Votre mot de passe a ete change");

                            }
                        }
                    }
                }
                //ctu.ModifierMotdePasse(pseud, txtNouveau.Text);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtAncien.Text = "";
            txtNouveau.Text = "";
            txtConfirmer.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

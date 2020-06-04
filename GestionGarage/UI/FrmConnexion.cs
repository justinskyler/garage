using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal;
using Domaine;
using Controleur;
namespace UI
{
    public partial class FrmConnexion : Form
    {
        public ControleurUtilisateurs ctutilisateur;
        public Utilisateurs uti;
        public FrmConnexion()
        {
            InitializeComponent();
           ctutilisateur = new ControleurUtilisateurs();
            uti = new Utilisateurs();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {

            string pseudo = txtPseudo.Text;
            string motdepasse = txtMotdePasse.Text;
            error.Clear();

            if (ctutilisateur.NumberValidationTextBox(txtPseudo.Text) || pseudo.Equals(String.Empty))
            {
                error.SetError(txtPseudo, "entrer votre pseudo");
            }
            else {
                if (ctutilisateur.NumberValidationTextBox(txtMotdePasse.Text) || motdepasse.Equals(String.Empty))
                {
                    error.SetError(txtMotdePasse, "entrer votre pseudo");
                }
                else {
                    uti = ctutilisateur.Login(txtPseudo.Text.Trim(), txtMotdePasse.Text.Trim());
                    if (uti != null)
                    {
                        if (uti.getEtat() == "bloquer")
                        {
                            MessageBox.Show("Contactez l'administrateur");
                            txtPseudo.Text = "";
                            txtMotdePasse.Text = "";
                            this.Close();
                        }
                        else
                        {
                            if (uti.getStatut() == "online")
                            {
                                MessageBox.Show("vous etes online"); 
                                txtPseudo.Text = "";
                                txtMotdePasse.Text = "";
                                this.Close();
                            }
                            else
                            {
                                ctutilisateur.Login1(txtPseudo.Text.Trim());
                                FrmConnexion con = new FrmConnexion();
                                txtMotdePasse.Text = "";
                                FrmPrincipal principale = new FrmPrincipal(ctutilisateur);
                                principale.Show();
                                con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nom Utilisateur et ou mot de passe incorrect");
                        txtPseudo.Text = "";
                        txtMotdePasse.Text = "";
                    }
                }                        
            } 
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

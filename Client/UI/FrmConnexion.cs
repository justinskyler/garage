using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Interface;
using Service;
using System.Media;
namespace UI
{
    public partial class FrmConnexion : Form
    {

        public Interface.InterfaceUtilisateur ctutilisateur;

        public FrmConnexion()
        {

            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            InitializeComponent();
        }


        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                string pseudo = txtPseudo.Text.Trim();
                string motdepasse = txtMotdePasse.Text.Trim();
                error.Clear();

                if (ctutilisateur.NumberValidationTextBox(txtPseudo.Text) || pseudo.Equals(String.Empty))
                {
                    error.SetError(txtPseudo, "entrer votre pseudo");
                }
                else
                {
                    if (ctutilisateur.NumberValidationTextBox(txtMotdePasse.Text) || motdepasse.Equals(String.Empty))
                    {
                        error.SetError(txtMotdePasse, "entrer votre pseudo");
                    }
                    else
                    {

                        // bool verif = false;
                        //verif=ctutilisateur.Login(pseudo, motdepasse);
                        bool ut = ctutilisateur.Login(pseudo, motdepasse);

                        if (ut)
                        {
                            //FrmRechercherUtilisateur vt = new FrmRechercherUtilisateur(ctutilisateur);
                            //vt.Show();


                            string Etat = "" + ctutilisateur.retournerEtat();
                            if (Etat == "bloquer")
                            {
                                MessageBox.Show("vous etes bloqué, contactez l'administrateur\n \t Tel: +509 3818-7166");
                                txtPseudo.Text = "";
                                txtMotdePasse.Text = "";
                                this.Close();
                            }
                            else
                            {
                                string Statut = "" + ctutilisateur.retourneStatut();
                                if (Statut == "online")
                                {
                                    MessageBox.Show("user déjà en en ligne");
                                    txtPseudo.Text = "";
                                    txtMotdePasse.Text = "";
                                    this.Close();
                                }
                                else
                                {
                                    ctutilisateur.Login1(txtPseudo.Text.Trim());
                                    FrmConnexion con = new FrmConnexion();
                                    con.Dispose();
                                    txtMotdePasse.Text = "";
                                    // MessageBox.Show("Bienvenue au principale");

                                    FrmPrincipale principale = new FrmPrincipale(ctutilisateur);
                                    principale.Show();

                                    // this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nom Utilisateur et ou mot de passe incorrect");
                            //txtPseudo.Text = "";
                            //txtMotdePasse.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            ChkPass.Enabled = false;
        }

        private void txtMotdePasse_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtMotdePasse.Text != "")
                {
                    ChkPass.Enabled = true;
                }
                else
                {
                    ChkPass.Enabled = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }

        private void ChkPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ChkPass.Checked)
                {

                    txtMotdePasse.UseSystemPasswordChar = false;
                }
                else
                {
                    txtMotdePasse.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex) { 
            
            MessageBox.Show(""+ex);
            }
        }
    }
}

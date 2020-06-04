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

namespace UI
{

    public partial class FrmAjouterUtilisateur : Form
    {
        public Interface.InterfaceUtilisateur ctutilisateur;
        public Interface.InterfaceTranzaction ctt;
        public static string cod;

        public FrmAjouterUtilisateur(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
        }
        private void FrmAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            Random numero = new Random();
            int code = numero.Next(0, 1000);
            cod = string.Format("Util-{0}", code);
            cmbFonction.SelectedIndex = 0;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string Nom, Prenom, Pseudo, Password, ConfPassword, Fonction, message, Dateajout;

                Nom = txtNom.Text.Trim();
                Prenom = txtPrenom.Text.Trim();
                Pseudo = txtPseudo.Text.Trim();
                Password = txtMotdePasse.Text.Trim();
                ConfPassword = txtMotdePasseConfirmation.Text.Trim();

                Dateajout = DateTime.Now.ToString();

                error.Clear();
                if (ctutilisateur.NumberValidationTextBox(txtNom.Text) || Nom.Equals(String.Empty))
                {
                    error.SetError(txtNom, "entrer un nom");
                }
                else
                {
                    error.Clear();
                    if (ctutilisateur.NumberValidationTextBox(Prenom) || Prenom.Equals(String.Empty))
                    {
                        error.SetError(txtPrenom, "entrer un prenom");
                    }
                    else
                    {
                        error.Clear();
                        if (ctutilisateur.NumberValidationTextBox(Pseudo) || Pseudo.Equals(String.Empty))
                        {
                            error.SetError(txtPseudo, "entrer un pseudo");
                        }
                        else
                        {
                            error.Clear();
                            if (ctutilisateur.NumberValidationTextBox(Password) || Password.Equals(String.Empty))
                            {
                                error.SetError(txtMotdePasse, "remplir le champ");
                                MessageBox.Show("votre mot de passe doit contenir 8 a 15 caracteres \n incluant au mois un chiffreet des caracteres speciaux ");
                            }
                            else
                            {
                                error.Clear();
                                if (ctutilisateur.NumberValidationTextBox(ConfPassword) || ConfPassword.Equals(String.Empty))
                                {
                                    error.SetError(txtMotdePasseConfirmation, "remplir le champ");
                                    MessageBox.Show("entrer le meme mot de passe");
                                }
                                else
                                {
                                    if (Password != ConfPassword)
                                    {
                                        MessageBox.Show("Vous devez entrer le meme mot de passe");
                                        txtMotdePasse.Text = "";
                                        txtMotdePasseConfirmation.Text = "";
                                    }
                                    if (Password != ConfPassword)
                                    {
                                        MessageBox.Show("veuillez confirmer votre mot de passe");
                                        txtMotdePasse.Text = "";
                                        txtMotdePasseConfirmation.Text = "";
                                        cmbFonction.ResetText();
                                    }
                                    else
                                    {
                                        bool u = ctutilisateur.RechercheUtilisateur(txtPseudo.Text.Trim());
                                        if (u != false)
                                        {
                                            MessageBox.Show("veuillez utiliser un autre Pseudo");
                                        }
                                        else
                                        {
                                            Fonction = cmbFonction.SelectedItem.ToString();
                                            Random co = new Random();
                                            int code = co.Next(100000, 900000);
                                            string numOp = String.Format("{0}", code);
                                            string codetrans = "Trans-" + code;
                                            ctutilisateur.EnregistrerUtilisateur(cod, Nom, Prenom, Pseudo, ConfPassword, Fonction, "debloquer", Dateajout, "offline");
                                            ctutilisateur.retracerutilisateur(numOp, codetrans, ctutilisateur.retournerPseudo(), "Ajouter Utilisateur", DateTime.Now.ToString());
                                            ctt.EnregistrerTransaction(codetrans, ctutilisateur.retournerPseudo(), "Ajouter Piece", DateTime.Now.ToString());
                                            MessageBox.Show("Utilisateur Enregistré");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }
             

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtPseudo.Text = "";
            txtMotdePasse.Text = "";
            txtMotdePasseConfirmation.Text = "";
            cmbFonction.Text = "";

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}

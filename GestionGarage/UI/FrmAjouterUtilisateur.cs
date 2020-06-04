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

    public partial class FrmAjouterUtilisateur : Form
    {
        public ControleurUtilisateurs ctutilisateur;
        public Utilisateurs ut;
        public static string cod;

        public FrmAjouterUtilisateur(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctutilisateur = ctc;
            ut = new Utilisateurs();
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
                        if (ctutilisateur.NumberValidationTextBox(Password)||Password.Equals(String.Empty))
                        {
                            error.SetError(txtMotdePasse, "remplir le champ");
                            MessageBox.Show("votre mot de passe doit contenir 8 a 15 caracteres \n incluant au mois un chiffreet des caracteres speciaux ");
                        }
                        else
                        {
                            error.Clear();
                            if (ctutilisateur.NumberValidationTextBox(ConfPassword)||ConfPassword.Equals(String.Empty))
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
                                    ut =  ctutilisateur.RechercheUtilisateur(txtPseudo.Text.Trim());
                                    if (ut!=null)
                                    {
                                        MessageBox.Show("veuillez utiliser un autre Pseudo");
                                    }
                                    else
                                    {
                                        Fonction = cmbFonction.SelectedItem.ToString();
                                        Random co = new Random();
                                        int code = co.Next(100000, 900000);
                                        string codetrans=string.Format("Trans-{0}",code);                                            
                                        message = ctutilisateur.EnregistrerUtilisateur(cod, Nom, Prenom, Pseudo, ConfPassword, Fonction, "debloquer", Dateajout,"offline");
                                        ctutilisateur.retracerutilisateur(codetrans, ctutilisateur.retournerPseudo(), "Ajouter Utilisateur", DateTime.Now.ToString());
                                        MessageBox.Show(message);

                                    }
                                }
                            }
                        }
                    }
                }
            }
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

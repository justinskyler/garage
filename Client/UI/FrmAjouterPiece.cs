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
    public partial class FrmAjouterPiece : Form
    {
        public Interface.InterfacePiece  ctpiece;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
        public FrmAjouterPiece(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctc = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "ObjetUtilisateur");
            //ctu = ctc;
        }

        private void BtnEnregistrerPiece_Click(object sender, EventArgs e)
        {
            try
            {
                string codepiece = TxtCodePiece.Text.Trim();
                string nompiece = TxtNomPiece.Text.Trim();
                string desc = TxtDescription.Text.Trim();
                string date = DateTime.Now.ToShortDateString();
                string pri = TxtPrixPiece.Text;
                string quant = TxtQuantite.Text;

                error.Clear();
                if (ctu.NumberValidationTextBox(TxtCodePiece.Text) || codepiece.Equals(String.Empty))
                {
                    error.SetError(TxtCodePiece, "Entrer le code du produit");
                }
                else
                {
                    error.Clear();
                    if (ctu.NumberValidationTextBox(TxtNomPiece.Text) || nompiece.Equals(String.Empty))
                    {
                        error.SetError(TxtNomPiece, "Entrer le nom du produit");
                    }
                    else
                    {

                        error.Clear();
                        if (ctu.StringValidationTextBox(TxtPrixPiece.Text) || pri.Equals(String.Empty))
                        {
                            error.SetError(TxtPrixPiece, "Entrer le prix");
                        }
                        else
                        {

                            error.Clear();
                            if (ctu.StringValidationTextBox(TxtQuantite.Text) || quant.Equals(String.Empty))
                            {
                                error.SetError(TxtQuantite, "Entrer la quantite");
                            }
                            else
                            {
                                error.Clear();
                                if (ctu.NumberValidationTextBox(TxtDescription.Text) || desc.Equals(String.Empty))
                                {
                                    error.SetError(TxtDescription, "Entrer la description");
                                }
                                else
                                {
                                    double prix = Convert.ToDouble(TxtPrixPiece.Text.Trim());
                                    int qte = Convert.ToInt32(TxtQuantite.Text.Trim());

                                    Random co = new Random();
                                    int code = co.Next(100000, 900000);
                                    string numOp = String.Format("{0}", code);
                                    string codetrans = "Trans-" + code;
                                    ctpiece.EnregistrerPiece(codepiece, nompiece, desc, qte, prix, date);
                                    ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Ajouter Piece", DateTime.Now.ToString());
                                    ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Ajouter Piece", DateTime.Now.ToString());

                                    MessageBox.Show("Piece Enregistré");

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }          
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            TxtCodePiece.Text = "";
            TxtNomPiece.Text = "";
            TxtPrixPiece.Text = "";
            TxtDescription.Text = "";
            TxtQuantite.Text = "";
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAjouterPiece_Load(object sender, EventArgs e)
        {
            
        }
    }
}

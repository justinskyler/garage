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
    public partial class FrmModifierPiece : Form
    {
        public Interface.InterfacePiece ctpiece;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
        public static int quantite;
        public FrmModifierPiece(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctu = ctc;
        }

        private void FrmModifierPiece_Load(object sender, EventArgs e)
        {
            TxtNomPiece.Enabled = false;
            TxtPrix.Enabled = false;
            TxtQuantite.Enabled = false;
            this.ClientSize = new Size(421, 130);
            //ChkNomPiece.Enabled = false;
            //ChkPrix.Enabled = false;
            //ChkQuantite.Enabled = false;
        }

        private void ChkQuantite_CheckedChanged(object sender, EventArgs e)
        {
            TxtQuantite.Enabled = true;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                bool piece = ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());
                if (piece == false)
                {
                    MessageBox.Show("Pièce introuvable");

                }
                else
                {
                    TxtCodePiece.Enabled = false;
                    this.ClientSize = new Size(421, 317);
                    TxtNomPiece.Text = ctpiece.retournerNomPiece();
                    TxtPrix.Text = ctpiece.retournerPrix().ToString();
                    TxtQuantite.Text = ctpiece.retournerQuantite().ToString();
                    quantite = Convert.ToInt32(ctpiece.retournerQuantite());
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = TxtNomPiece.Text;
                string prxP = TxtPrix.Text;
                string quant = TxtQuantite.Text;
                error.Clear();
                if (ctu.NumberValidationTextBox(TxtNomPiece.Text) || nom.Equals(String.Empty))
                {
                    error.SetError(TxtNomPiece, "entrer le nom de la pièce");
                }
                else
                {
                    error.Clear();
                    if (ctu.StringValidationTextBox(TxtPrix.Text) || prxP.Equals(String.Empty))
                    {

                        error.SetError(TxtPrix, "entrer le prix");
                    }
                    else
                    {

                        error.Clear();
                        if (ctu.StringValidationTextBox(TxtQuantite.Text) || quant.Equals(String.Empty))
                        {

                            error.SetError(TxtQuantite, "entrer la quantite");
                        }
                        else
                        {


                            int qt = quantite + Convert.ToInt32(TxtQuantite.Text.Trim());

                            ctpiece.ModifierQuantitePiece(TxtCodePiece.Text.Trim(), qt);

                            Random co = new Random();
                            int code = co.Next(100000, 900000);
                            string numOp = String.Format("{0}", code);
                            string codetrans = "Trans-" + code;

                            ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Modifier Piece", DateTime.Now.ToString());
                            ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Modifier Piece", DateTime.Now.ToString());
                            MessageBox.Show("Piece modifié");
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
            TxtNomPiece.Text = "";
            TxtPrix.Text = "";
            TxtQuantite.Text = "";
            TxtCodePiece.Text = "";
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using  Domaine;
using Controleur;
namespace UI
{
    public partial class FrmModifierPiece : Form
    {
        public ControleurPieces ctpiece;
        public ControleurUtilisateurs ctu;

        public FrmModifierPiece(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctpiece = new ControleurPieces();
            ctu = ctc;
        }

        private void FrmModifierPiece_Load(object sender, EventArgs e)
        {
            TxtNomPiece.Enabled = false;
            TxtPrix.Enabled = false;
            TxtQuantite.Enabled = false;
            this.ClientSize=new Size (566,120);
            //ChkNomPiece.Enabled = false;
            //ChkPrix.Enabled = false;
            //ChkQuantite.Enabled = false;
        }


        private void ChkNomPiece_CheckedChanged(object sender, EventArgs e)
        {
            TxtNomPiece.Enabled = false;
        }

        private void ChkPrix_CheckedChanged(object sender, EventArgs e)
        {
            TxtPrix.Enabled =false;
        }

        private void ChkQuantite_CheckedChanged(object sender, EventArgs e)
        {
            TxtQuantite.Enabled = true;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Pieces piece=ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());
            if (piece.getCodePiece()==null)
            {
                MessageBox.Show("Pièce introuvable");

            }
            else {
                TxtCodePiece.Enabled = false;
                this.ClientSize = new Size(566, 400);
                TxtNomPiece.Text = ctpiece.retournerNomPiece();
                TxtPrix.Text = ctpiece.retournerPrix().ToString();
                TxtQuantite.Text = ctpiece.retournerQuantite().ToString();
            
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            string nom=TxtNomPiece.Text;
            string prxP=TxtPrix.Text;
            string quant=TxtQuantite.Text;
            error.Clear();
            if (ctu.NumberValidationTextBox(TxtNomPiece.Text) || nom.Equals(String.Empty))
            {
                error.SetError(TxtNomPiece, "entrer le nom de la pièce");
            }
            else {
            error.Clear();
            if (ctu.StringValidationTextBox(TxtPrix.Text) || prxP.Equals(String.Empty))
            {

                error.SetError(TxtPrix, "entrer le prix");
            }
            else {

                error.Clear();
                if (ctu.StringValidationTextBox(TxtQuantite.Text) || quant.Equals(String.Empty))
                {

                    error.SetError(TxtQuantite, "entrer la quantite");
                }
                else {
                    string mesaj = ctpiece.ModifierQuantitePiece(TxtCodePiece.Text.Trim(), Convert.ToInt32(TxtQuantite.Text.Trim()));
                    
                    Random co = new Random();
                    int code = co.Next(100000, 900000);

                    ctu.retracerutilisateur("Trans-" + code, ctu.retournerPseudo(), "Modifier Piece", DateTime.Now.ToString());
                    
                    
                    MessageBox.Show(mesaj);
                }           
            }           
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

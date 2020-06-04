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
    public partial class FrmVente : Form
    {
        public ControleurPieces ctpiece;
        public ControleurUtilisateurs ctu;
        public ControleurVente ctvente;
        public static Pieces pieces=null; 
        public static string Caissier,CodeVente,nompiece;
        
        public static int quantite;
        public static double montant,qte,montanttotal;

        public FrmVente(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctpiece = new ControleurPieces();
            pieces = new Pieces();
            ctvente = new ControleurVente();
            ctu =ctc;
        }

        private void FrmVente_Load(object sender, EventArgs e)
        {
            Random co = new Random();
            int cod = co.Next(100000, 900000);
            CodeVente = cod.ToString();

            TxtnomPiece.Enabled = false;
            TxtPrix.Enabled = false;
            TxtQuantite.Enabled = false;
            BtnOk.Enabled = false;
            BtnEffectuer.Enabled = false;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            pieces = ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());
            if (pieces.getNomPiece() == null)
            {
                MessageBox.Show("Désolé, pièce introuvable");

            }
            else
            {
                TxtnomPiece.Text = pieces.getNomPiece();
                TxtPrix.Text = pieces.getPrixUnit().ToString();
                TxtQuantite.Enabled = true;
                BtnOk.Enabled = true;
                
            }        
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            BtnEffectuer.Enabled = true;
            Caissier  = "caissier";
            string nom = TxtnomPiece.Text.Trim();
            string codepiece = TxtCodePiece.Text.Trim();
            double  prix =Convert.ToDouble( TxtPrix.Text.Trim());
            qte = Convert.ToInt32(TxtQuantite.Text.Trim());

            DgvVente.Rows.Add(codepiece, nom, prix, qte);

            //TxtCodePiece.Text="";
            //TxtnomPiece.Text="";
            //TxtPrix.Text="";
            //TxtQuantite.Text="";
            TxtnomPiece.Enabled = false;
            TxtPrix.Enabled = false;
            TxtQuantite.Enabled = false;
            BtnOk.Enabled = false;
            TxtCodePiece.Focus();

            //try
            //{
            //    for (int i = 0; i < DgvVente.Rows.Count; i++)
            //    {                   
            //        sum += Convert.ToInt32(DgvVente.Rows[i].Cells[2].Value);
            //    }
            //   // lblSomme.Text = Convert.ToString(sum);
            //    //int montant = Convert.ToInt32(txtmontant.Text.Trim());
            //    //lblsomme.Text = (montant-sum).ToString();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BtnEffectuer_Click(object sender, EventArgs e)
        {

            string codepiece = TxtCodePiece.Text.Trim();
         //  pieces = ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());

           for (int i = 0; i < DgvVente.Rows.Count; i++)
           {
               codepiece = DgvVente.Rows[i].Cells[0].Value.ToString();
               nompiece = DgvVente.Rows[i].Cells[1].Value.ToString();
               montant = Convert.ToInt32(DgvVente.Rows[i].Cells[2].Value.ToString());
               quantite = Convert.ToInt32(DgvVente.Rows[i].Cells[3].Value.ToString());
               montanttotal = montant * quantite;

               double qtinit = Convert.ToDouble(pieces.getQuantite());
               double qte = qtinit - Convert.ToDouble(quantite);

               if (qte <= 0)
               {
                   MessageBox.Show("Limite de stock atteint pour cette piece");
               }
               else
               {
                   ctpiece.ModifierQuantitePiece(codepiece, Convert.ToInt32(qte));   
                   ctvente.EffectuerVente(ctu.retournerPseudo(), CodeVente, nompiece, quantite, montanttotal, DateTime.Now.ToShortDateString());                                                                      
               }
               
           }
           MessageBox.Show("vente effectue");

           //this.Close();
           
           // Form1 fm = new Form1(CodeVente);
           //fm.Show();
           
           Random co = new Random();
           int code = co.Next(100000, 900000);
           ctu.retracerutilisateur(CodeVente, ctu.retournerPseudo(), "Effectuer Vente", DateTime.Now.ToString());
            //quantite=Convert.ToDouble(TxtQuantite.Text.Trim());
            //montant=pieces.getPrixUnit()*quantite;

            //MessageBox.Show ( vente.EffectuerVente(Caissier, CodeVente, pieces.getNomPiece(), quantite, montant));
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            TxtCodePiece.Text = "";
            TxtnomPiece.Text = "";
            TxtQuantite.Text = "";
            TxtPrix.Text = "";
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

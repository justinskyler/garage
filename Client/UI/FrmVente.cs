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
    public partial class FrmVente : Form
    {
        public Interface.InterfacePiece ctpiece;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceVente ctvente;
        public Interface.InterfaceTranzaction ctt;
        public static string Caissier,CodeVente,nompiece;
        
        public static int quantite;
        public static double montant,qte,montanttotal;

        public FrmVente(InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctvente = (Interface.InterfaceVente)Activator.GetObject(typeof(Interface.InterfaceVente), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vente");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctu =ctc;
        }

        private void FrmVente_Load(object sender, EventArgs e)
        {
            Random co = new Random();
            int cod = co.Next(100000, 900000);
            CodeVente = "Vent-" + cod;

            TxtnomPiece.Enabled = false;
            TxtPrix.Enabled = false;
            TxtQuantite.Enabled = false;
            BtnOk.Enabled = false;
            BtnEffectuer.Enabled = false;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {

                
                bool p = ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());
                if (p)
                {
                    if (ctpiece.retournerQuantite() == 0)
                    {
                        MessageBox.Show("Votre Stock est à zéro: (" + ctpiece.retournerQuantite() + ")");
                        BtnOk.Enabled = false;
                        TxtQuantite.Enabled = false;

                    }
                    else
                    {
                        TxtnomPiece.Text = ctpiece.retournerNomPiece();
                        TxtPrix.Text = ctpiece.retournerPrix().ToString();
                        TxtQuantite.Enabled = true;
                        BtnOk.Enabled = true;

                        if (ctpiece.retournerQuantite() <= 20)
                        {
                            lblqte.Text = "";
                            lblqte.ForeColor = Color.Red;
                            lblqte.Text = "Seuil de stock atteint: " + ctpiece.retournerQuantite();
                        }
                        else
                        {
                            lblqte.ForeColor = Color.Black;
                            lblqte.Text = "Quantite disponible:  " + ctpiece.retournerQuantite();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Désolé, article introuvable");


                }
            }
            catch (Exception ex) {

                MessageBox.Show("" + ex);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BtnEffectuer.Enabled = true;
                Caissier = "caissier";
                string nom = TxtnomPiece.Text.Trim();
                string codepiece = TxtCodePiece.Text.Trim();
                double prix = Convert.ToDouble(TxtPrix.Text.Trim());
                qte = Convert.ToInt32(TxtQuantite.Text.Trim());
                
                 double qe = ctpiece.retournerQuantite() - Convert.ToDouble(qte);
                 if (qe < 0)
                 {
                     MessageBox.Show("Desolée quantité disponible insuffisante: " + nompiece);                    
                     TxtCodePiece.Text = "";
                     TxtnomPiece.Text = "";
                     TxtPrix.Text = "";
                     TxtQuantite.Text = "";
                     TxtQuantite.Enabled=false;
                     BtnEffectuer.Enabled = false;
                     BtnOk.Enabled = false;
                     lblqte.Text = "";
                    
                 }
                 else {

                     if(qte<0 ){
                         error.SetError(TxtQuantite, "valeur negative");
                         BtnEffectuer.Enabled = false;
                     }else{

                     DgvVente.Rows.Add(codepiece, nom, prix, qte);

                     TxtCodePiece.Text = "";
                     TxtnomPiece.Text = "";
                     TxtPrix.Text = "";
                     TxtQuantite.Text = "";
                     TxtnomPiece.Enabled = false;
                     TxtPrix.Enabled = false;
                     TxtQuantite.Enabled = false;
                     BtnOk.Enabled = false;
                     TxtCodePiece.Focus();
                 
                }

                 int qt = ctpiece.retournerQuantite();               
                if (qt <= 20)
                {
                    lblqte.ForeColor = Color.Red;
                    lblqte.Text = "Quantite restant: " + qt;
                }
                else
                {
                    int q = ctpiece.retournerQuantite() - Convert.ToInt32(qte);
                    if (q < 0)
                    { 
                        lblqte.Text = "";
                    } 
                    
                    else {
                        if(qte<0){

                            lblqte.Text = "";
                        
                        }else{
                        lblqte.ForeColor = Color.Black;
                        lblqte.Text = "Quantite restant: " + q;
                    }
                    }
                }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            
            }
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

            string codepiece ;
           //bool pi = ctpiece.rechercherPiece(TxtCodePiece.Text.Trim());
            try
            {
                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);

                for (int i = 0; i < DgvVente.Rows.Count; i++)
                {

                    if (DgvVente.Rows == null)
                    {

                        error.Clear();
                        error.SetError(DgvVente, "");
                    }
                    else
                    {
                        codepiece = DgvVente.Rows[i].Cells[0].Value.ToString();
                        nompiece = DgvVente.Rows[i].Cells[1].Value.ToString();
                        montant = Convert.ToInt32(DgvVente.Rows[i].Cells[2].Value.ToString());
                        quantite = Convert.ToInt32(DgvVente.Rows[i].Cells[3].Value.ToString());
                        montanttotal = montant * quantite;
                        double qe = ctpiece.retournerQuantite() - Convert.ToDouble(quantite);                        
                        string codetrans = "Trans-" + code;
                        ctpiece.ModifierQuantitePiece(codepiece, Convert.ToInt32(qe));
                        ctvente.EffectuerVente(ctu.retournerPseudo(), CodeVente, nompiece, quantite, montanttotal, DateTime.Now.ToString());
                        ctu.retracerutilisateur(numOp, CodeVente, ctu.retournerPseudo(), "Effectuer Vente", DateTime.Now.ToString());
                        ctt.EnregistrerTransaction(CodeVente, ctu.retournerPseudo(), "EfFectuer Vente", DateTime.Now.ToString());
                    }

                }
                Form1 fm = new Form1(CodeVente);
                fm.Show();
            }
            catch (Exception ex) {

                MessageBox.Show("" + ex);
            }

           //this.Close();
           
          

        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            TxtCodePiece.Text = "";
            TxtnomPiece.Text = "";
            TxtQuantite.Text = "";
            TxtPrix.Text = "";
            TxtQuantite.Enabled = false;
            BtnOk.Enabled = false;
            lblqte.Text = "";
            BtnEffectuer.Enabled = false;
            DgvVente.Rows.Clear();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

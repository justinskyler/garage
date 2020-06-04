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
    public partial class FrmRechercherPiece : Form
    {
        public Interface.InterfacePiece ctpiece;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
      public DataSet dt;
      public FrmRechercherPiece(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctu = ctc;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                DgvPieces.DataSource = ctpiece.ListerPieces();
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void FrmRechercherProduit_Load(object sender, EventArgs e)
        {
            try
            {
                dt = ctpiece.ListerPieces();
                DgvPieces.AutoGenerateColumns = true;
                DgvPieces.DataSource = dt;
                DgvPieces.DataMember = "Pieces";

                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;

                ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Rechercher Piece", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Rechercher Piece", DateTime.Now.ToString());
            }
            catch (Exception ex) {

                MessageBox.Show("" + ex);
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = ctpiece.ListerPiecess(TxtCodepiece.Text.Trim());
                DgvPieces.AutoGenerateColumns = true;
                DgvPieces.DataSource = dt;
                DgvPieces.DataMember = "Pieces";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}

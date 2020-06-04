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
    public partial class FrmVerifierStock : Form
    {
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfacePiece ctpiece;
        public Interface.InterfaceTranzaction ctt;
        public FrmVerifierStock(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctc = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "ObjetUtilisateur");
            //ctu = ctc;
        }

        private void FrmVerifierStock_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = ctpiece.ListerPieces();
                DgvStock.AutoGenerateColumns = true;
                DgvStock.DataSource = dt;
                DgvStock.DataMember = "Pieces";
                DgvStock.DataSource = ctpiece.ListerPieces();


                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;
                ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());

            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DgvStock.Refresh();
                DataSet dt = ctpiece.ListerPiecess(TxtCodePiece.Text.Trim());
                DgvStock.AutoGenerateColumns = true;
                DgvStock.DataSource = dt;
                DgvStock.DataMember = "Pieces";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                DgvStock.Refresh();
                DataSet dt = ctpiece.ListerPiecess(TxtCodePiece.Text.Trim());
                DgvStock.AutoGenerateColumns = true;
                DgvStock.DataSource = dt;
                DgvStock.DataMember = "Pieces";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}

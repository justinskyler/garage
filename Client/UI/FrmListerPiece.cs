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
    public partial class FrmListerPiece : Form
    {
        public Interface.InterfacePiece ctpiece;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
        public FrmListerPiece(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
           
            //ctu = ctc;
        }

        private void FrmListerPiece_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet dt = ctpiece.ListerPieces();
                DgvsListerPieces.AutoGenerateColumns = false;
                DgvsListerPieces.DataSource = dt;
                DgvsListerPieces.DataMember = "Pieces";
                DgvsListerPieces.DataSource = ctpiece.ListerPieces();

                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;
                ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Lister Piece", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Lister Piece", DateTime.Now.ToString());

            }
            catch (Exception ex) {

                MessageBox.Show("" + ex);
            }
        }
    }
}

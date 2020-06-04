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
    public partial class FrmSupprimerPiece : Form
    {
        public Interface.InterfacePiece ctpiece;
        public FrmSupprimerPiece()
        {
            InitializeComponent();
            ctpiece = (Interface.InterfacePiece)Activator.GetObject(typeof(Interface.InterfacePiece), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Piece");
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
         //ctpiece.supprimerPiece(TxtCodePiece.Text.Trim());
         //ctu.retracerutilisateur("Vent-" + code, ctu.retournerPseudo(), "Effectuer Vente", DateTime.Now.ToString());
         //  MessageBox.Show("Piece Supprimé");
        }
    }
}

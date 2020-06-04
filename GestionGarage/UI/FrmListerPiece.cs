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
using Controleur;
namespace UI
{
    public partial class FrmListerPiece : Form
    {
        public ControleurPieces ctpiece;
        public ControleurUtilisateurs ctu;
        public FrmListerPiece(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctpiece = new ControleurPieces(); 
            ctu = ctc;
        }

        private void FrmListerPiece_Load(object sender, EventArgs e)
        {


            DataSet  dt = ctpiece.ListerPieces();
            DgvsListerPieces.AutoGenerateColumns = false;
            DgvsListerPieces.DataSource = dt;
            DgvsListerPieces.DataMember = "Pieces";
            DgvsListerPieces.DataSource = ctpiece.ListerPieces();
            
            Random co = new Random();
            int code = co.Next(100000, 900000);

            ctu.retracerutilisateur("Trans-" + code, ctu.retournerPseudo(), "Lister Piece", DateTime.Now.ToString());

        }
    }
}

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
    public partial class FrmRechercherPiece : Form
    {
      public   ControleurPieces ctpiece;
      public ControleurUtilisateurs ctu;
      public DataSet dt;
      public FrmRechercherPiece(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctpiece=new ControleurPieces() ;
            ctu = ctc;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            DgvPieces.DataSource = ctpiece.ListerPieces();
        }

        private void FrmRechercherProduit_Load(object sender, EventArgs e)
        {
            dt = ctpiece.ListerPieces();
            DgvPieces.AutoGenerateColumns = true;
            DgvPieces.DataSource = dt;
            DgvPieces.DataMember = "Pieces";
            
            Random co = new Random();
            int code = co.Next(100000, 900000);

            ctu.retracerutilisateur("Trans-" + code, ctu.retournerPseudo(), "Rechercher Piece", DateTime.Now.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt = ctpiece.ListerPiecess(TxtCodepiece.Text.Trim());
            DgvPieces.AutoGenerateColumns = true;
            DgvPieces.DataSource = dt;
            DgvPieces.DataMember = "Pieces";
        }
    }
}

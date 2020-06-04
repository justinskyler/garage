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
    public partial class FrmVerifierStock : Form
    {
        public ControleurUtilisateurs ctu;
        public ControleurPieces ctpiece;
        public FrmVerifierStock(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctpiece = new ControleurPieces();
            ctu = ctc;
        }

        private void FrmVerifierStock_Load(object sender, EventArgs e)
        {
            DataSet dt = ctpiece.ListerPieces();
            DgvStock.AutoGenerateColumns = true;
            DgvStock.DataSource = dt;
            DgvStock.DataMember = "Pieces";
            DgvStock.DataSource = ctpiece.ListerPieces();


            Random co = new Random();
            int code = co.Next(100000, 900000);
            ctu.retracerutilisateur("Trans-" + code, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DgvStock.Refresh();
            DataSet dt = ctpiece.ListerPiecess(TxtCodePiece.Text.Trim());
            DgvStock.AutoGenerateColumns = true;
            DgvStock.DataSource = dt;
            DgvStock.DataMember = "Pieces";
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            DgvStock.Refresh();
            DataSet dt = ctpiece.ListerPiecess(TxtCodePiece.Text.Trim());
            DgvStock.AutoGenerateColumns = true;
            DgvStock.DataSource = dt;
            DgvStock.DataMember = "Pieces";
        }
    }
}

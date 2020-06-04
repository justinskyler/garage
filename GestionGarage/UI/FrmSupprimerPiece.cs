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
    public partial class FrmSupprimerPiece : Form
    {
        public ControleurPieces ctpiece;
        public FrmSupprimerPiece()
        {
            InitializeComponent();
            ctpiece = new ControleurPieces();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
           string message= ctpiece.supprimerPiece(TxtCodePiece.Text.Trim());
           MessageBox.Show(message);
        }
    }
}

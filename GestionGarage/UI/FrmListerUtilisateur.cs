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
    public partial class FrmListerUtilisateur : Form
    {
        public ControleurUtilisateurs ctutilisateur;
        public FrmListerUtilisateur(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctutilisateur = ctc;
        }

        private void FrmListerUtilisateur_Load(object sender, EventArgs e)
        {
            dgvLister.AutoGenerateColumns = false;
            dgvLister.DataSource = ctutilisateur.ListerUtilisateur();
            dgvLister.DataMember = "Utilisateurs";

            Random co = new Random();
            int code = co.Next(100000, 900000);

            ctutilisateur.retracerutilisateur("Trans-" + code, ctutilisateur.retournerPseudo(), "Lister User", DateTime.Now.ToString());

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

            dgvLister.DataSource = ctutilisateur.ListerUtilisateur(txtRecherche.Text);
            dgvLister.AutoGenerateColumns = false;
            dgvLister.DataMember = "Utilisateurs";
        }
    }
}

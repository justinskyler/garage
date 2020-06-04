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
using Domaine;
using Controleur;
namespace UI
{
    public partial class FrmRechercherUtilisateur : Form
    {
        public ControleurUtilisateurs  ctutilisateur;
        public Utilisateurs uti;
        public FrmRechercherUtilisateur(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
           ctutilisateur = ctc;
           uti = new Utilisateurs();
            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
          uti= ctutilisateur.RechercheUtilisateur(txtPseudoRech.Text.Trim());
            
            if (uti!=null)

            {
                txtNom.Text = ctutilisateur.retournerNom();
                txtPrenom.Text = ctutilisateur.retournerPrenom();
                txtPseudo.Text = ctutilisateur.retournerPseudo();
                txtFonction.Text = ctutilisateur.retournerFonction();
                txtEtat.Text = ctutilisateur.retournerEtat();
                txtDateAjout.Text = ctutilisateur.retournerDateAjout();

                Random co = new Random();
                int code = co.Next(100000, 900000);

                ctutilisateur.retracerutilisateur("Trans-" + code, ctutilisateur.retournerPseudo(), "Rechercher utilisateur", DateTime.Now.ToString());
            }
            else {
                MessageBox.Show("Utilisateur introuvable");
            }
        }

        private void FrmRechercherUtilisateur_Load(object sender, EventArgs e)
        {
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtPseudo.Enabled = false;
            txtFonction.Enabled = false;
            txtEtat.Enabled = false;
            txtDateAjout.Enabled = false;
        }
    }
}

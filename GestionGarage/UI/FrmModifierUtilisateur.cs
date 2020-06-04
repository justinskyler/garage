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
    public partial class FrmModifierUtilisateur : Form
    {
        public ControleurUtilisateurs ctutilisateur;
        Utilisateurs uti = new Utilisateurs();
        public FrmModifierUtilisateur(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctutilisateur = ctc;
            uti = new Utilisateurs();
        }

        private void FrmModifierUtilisateur_Load(object sender, EventArgs e)
        {
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            CmbFonction.Enabled = false;
            btnModifier.Enabled = false;
            btnAnnuler.Enabled = false;
            btnQuitter.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtPseudoRech.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            CmbFonction.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
             uti = ctutilisateur.RechercheUtilisateur(txtPseudoRech.Text.Trim());
           if (uti.getCode() == "")
           {

               MessageBox.Show("utilisateur introuvable");
           }
           else {
               txtNom.Enabled = true;
               txtPrenom.Enabled = true;
               CmbFonction.Enabled = true;
               btnModifier.Enabled = true;
               btnAnnuler.Enabled = true;
               btnQuitter.Enabled = true;
               txtNom.Text = uti.getNom();
               txtPrenom.Text = uti.getPrenom();
            CmbFonction.Text = uti.getFonction();              
           }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            Random co = new Random();
            int code = co.Next(100000, 900000);

            ctutilisateur.retracerutilisateur("Trans-" + code, ctutilisateur.retournerPseudo(), "Lister Piece", DateTime.Now.ToString());
            string message = ctutilisateur.ModifierUtilisateur(txtPseudoRech.Text.Trim(), txtNom.Text.Trim(), txtPrenom.Text.Trim(), CmbFonction.SelectedItem.ToString ());
            MessageBox.Show(message);
        }
    }
}

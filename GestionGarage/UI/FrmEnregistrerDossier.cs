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
    public partial class FrmEnregistrerCLientEtVoiture : Form
    {
        public  ControleurClient ctcli;
        public static ControleurVehicule  ve;
        public ControleurUtilisateurs ctu;
        public static string nif;
        public FrmEnregistrerCLientEtVoiture(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ve = new ControleurVehicule();
            ctcli = new ControleurClient();
            ctu = new ControleurUtilisateurs();
        }

        private void FrmEnregistrerCLientEtVoiture_Load(object sender, EventArgs e)
        {
            TxtDossier.Enabled = false;
            Random co = new Random();
            int code = co.Next(100000, 900000);
            TxtDossier.Text = code.ToString();
            RdBNIF.Checked = true;
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            string nif = MskNif.Text.Trim();


            string nodossier, nom, prenom, adresse, telephone, marque, modele, plaque, type, serie, annee, couleur;

            nodossier = TxtDossier.Text;
            nom = TxtNom.Text;
            prenom = TxtPrenom.Text;
            adresse = TxtAdresse.Text;
            telephone = MskTel.Text;
            marque = TxtMarque.Text;
            modele = TxtModele.Text;
            plaque = TxtPlaque.Text;
            type = TxtType.Text;
            serie = TxtSerie.Text;
            annee = NudAnnee.Value.ToString();
            couleur = CmbCouleur.SelectedItem.ToString();

            Random co = new Random();
            int code = co.Next(100000, 900000);
            
             ctcli.EnregistrerClient(nodossier, nom, prenom, adresse, telephone, nif);                             
            string mes = ve.EnregistrerVehicule(nodossier, marque, modele, plaque, type, serie, annee, couleur);
            ctu.retracerutilisateur("Trans-{0}" + code, ctu.retournerPseudo(), "Enregistrer Dossier", DateTime.Now.ToString());
            MessageBox.Show(mes);

            TxtNom.Text = "";
            TxtDossier.Text = "";
            TxtPrenom.Text = "";
            TxtAdresse.Text = "";
            TxtNom.Text = "";
            MskTel.Text = "";
            MskNif.Text = "";
            TxtMarque.Text = "";
            TxtModele.Text = "";
            TxtPlaque.Text = "";
            TxtType.Text = "";
            TxtSerie.Text = "";
            NudAnnee.Value = 1990;
            CmbCouleur.ValueMember = "";
        }

        private void RdBNIF_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBCIN.Checked == true)
            {
                MskNif.Clear();
                MskNif.Mask = "00-00-00-0000-00-00000";

            }
            else
            {

                MskNif.Clear();
                MskNif.Mask = "000-000-000-0";

            }
        }

        
    }
}

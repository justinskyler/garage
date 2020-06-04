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
    public partial class FrmEnregistrerCLientEtVoiture : Form
    {
        public  Interface.InterfaceClient  ctcli;
        public Interface.InterfaceVehicule   ve;
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
        public static string nif;
        public FrmEnregistrerCLientEtVoiture(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ve = (Interface.InterfaceVehicule)Activator.GetObject(typeof(Interface.InterfaceVehicule), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vehicule");
            ctcli = (Interface.InterfaceClient)Activator.GetObject(typeof(Interface.InterfaceClient), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Client");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctu = ctc;
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
            string numOp = String.Format("{0}", code);
            //string codetrans = "Trans-" + code;        
            
             ctcli.EnregistrerClient(nodossier, nom, prenom, adresse, telephone, nif);                             
             ve.EnregistrerVehicule(nodossier, marque, modele, plaque, type, serie, annee, couleur);
             ctu.retracerutilisateur(numOp, nodossier, ctu.retournerPseudo(), "Enregistrer Dossier", DateTime.Now.ToString());
             ctt.EnregistrerTransaction(nodossier, ctu.retournerPseudo(), "Enregistrer Dossier", DateTime.Now.ToString());

            MessageBox.Show("Vehicule Enregistré");

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

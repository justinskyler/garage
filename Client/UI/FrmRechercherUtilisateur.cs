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
    public partial class FrmRechercherUtilisateur : Form
    {
        public Interface.InterfaceUtilisateur  ctutilisateur;
        public Interface.InterfaceTranzaction ctt;
        public FrmRechercherUtilisateur(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctutilisateur = ctc;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                bool ut = ctutilisateur.RechercheUtilisateur(txtPseudoRech.Text.Trim());

                if (ut != false)
                {
                    txtNom.Text = ctutilisateur.retournerNom();
                    txtPrenom.Text = ctutilisateur.retournerPrenom();
                    txtPseudo.Text = ctutilisateur.retournerPseudo();
                    txtFonction.Text = ctutilisateur.retournerFonction();
                    txtEtat.Text = ctutilisateur.retournerEtat();
                    txtDateAjout.Text = ctutilisateur.retournerDateAjout();

                    Random co = new Random();
                    int code = co.Next(100000, 900000);
                    string numOp = String.Format("{0}", code);
                    string codetrans = "Trans-" + code;

                    ctutilisateur.retracerutilisateur(numOp, codetrans, ctutilisateur.retournerPseudo(), "Rechercher utilisateur", DateTime.Now.ToString());
                    ctt.EnregistrerTransaction(codetrans, ctutilisateur.retournerPseudo(), "Rechercher utilisateur", DateTime.Now.ToString());
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
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

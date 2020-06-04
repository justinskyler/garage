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
    public partial class FrmModifierUtilisateur : Form
    {
        public Interface.InterfaceUtilisateur ctutilisateur;
        public Interface.InterfaceTranzaction ctt;
        public FrmModifierUtilisateur(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
           // ctc = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "ObjetUtilisateur");
            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
        }

        private void FrmModifierUtilisateur_Load(object sender, EventArgs e)
        {
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            CmbFonction.Enabled = false;
            TxtStatut.Enabled = false;
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
            TxtStatut.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                bool uti = ctutilisateur.RechercheUtilisateur(txtPseudoRech.Text.Trim());
                if (uti == false)
                {

                    MessageBox.Show("utilisateur introuvable");
                }
                else
                {
                    txtNom.Enabled = true;
                    txtPrenom.Enabled = true;
                    CmbFonction.Enabled = true;
                    TxtStatut.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnQuitter.Enabled = true;
                    txtNom.Text = ctutilisateur.retournerNom();
                    txtPrenom.Text = ctutilisateur.retournerPrenom();
                    CmbFonction.Text = ctutilisateur.retournerFonction();
                    TxtStatut.Text = ctutilisateur.retourneStatut();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;

                ctutilisateur.retracerutilisateur(numOp, codetrans, ctutilisateur.retournerPseudo(), "Modifier Utilisateur", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctutilisateur.retournerPseudo(), "Modifier Utilisateur", DateTime.Now.ToString());
                ctutilisateur.ModifierUtilisateur(txtPseudoRech.Text.Trim(), txtNom.Text.Trim(), txtPrenom.Text.Trim(), CmbFonction.SelectedItem.ToString(),ctutilisateur.retourneStatut());
                MessageBox.Show("Utilisateur modifié");
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}

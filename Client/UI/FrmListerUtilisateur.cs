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
    public partial class FrmListerUtilisateur : Form
    {
        public Interface.InterfaceUtilisateur ctutilisateur;
        public Interface.InterfaceTranzaction ctt;

        public FrmListerUtilisateur(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            //ctutilisateur = ctc;
        }

        private void FrmListerUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLister.AutoGenerateColumns = false;
                dgvLister.DataSource = ctutilisateur.ListerUtilisateur();
                dgvLister.DataMember = "Utilisateurs";

                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;

                ctutilisateur.retracerutilisateur(numOp, codetrans, ctutilisateur.retournerPseudo(), "Lister User", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctutilisateur.retournerPseudo(), "Lister user", DateTime.Now.ToString());

            }
            catch (Exception ex) { 
            MessageBox.Show(""+ex);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLister.DataSource = ctutilisateur.ListerUtilisateur(txtRecherche.Text);
                dgvLister.AutoGenerateColumns = false;
                dgvLister.DataMember = "Utilisateurs";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}

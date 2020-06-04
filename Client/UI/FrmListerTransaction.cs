using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;

namespace UI
{
    public partial class FrmListerTransaction : Form
    {
        public Interface.InterfaceTranzaction ctt;
        public Interface.InterfaceUtilisateur ctu;
        public FrmListerTransaction(Interface.InterfaceUtilisateur ctc)
        {
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            InitializeComponent();
        }

        private void FrmListerTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = ctt.ListerTranzactions();
                DgvLister.AutoGenerateColumns = true;
                DgvLister.DataSource = dt;
                DgvLister.DataMember = "Trans";
                DgvLister.DataSource = ctt.ListerTranzactions();

                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;
                ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void TxtRech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DgvLister.Refresh();
                DataSet dt = ctt.ListerTranzaction(TxtRech.Text.Trim());
                DgvLister.AutoGenerateColumns = true;
                DgvLister.DataSource = dt;
                DgvLister.DataMember = "Trans";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void Btnrechercher_Click(object sender, EventArgs e)
        {
            try
            {
                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;
                ctu.retracerutilisateur(numOp, codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctu.retournerPseudo(), "Verifier Stock", DateTime.Now.ToString());

            }
            catch (Exception ex) {

                MessageBox.Show("" + ex);
            }
        }
    }
}

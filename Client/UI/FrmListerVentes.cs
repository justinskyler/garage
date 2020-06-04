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
    public partial class FrmListerVentes : Form
    {
        public static Interface.InterfaceVente ctv;
        public static Interface.InterfaceUtilisateur ctu;
        public static DataSet dt;
        public FrmListerVentes( Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctv = (Interface.InterfaceVente)Activator.GetObject(typeof(Interface.InterfaceVente), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vente");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");

        }

        private void FrmListerVentes_Load(object sender, EventArgs e)
        {
            try
            {
                dt = ctv.ListerVentes(ctu.retournerPseudo());
                Dgvlister.AutoGenerateColumns = true;
                Dgvlister.DataSource = dt;
                Dgvlister.DataMember = "Vente";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}

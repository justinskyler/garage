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
    public partial class FrmRechercherVente : Form
    {
        public static Interface.InterfaceVente ctv;
        public static Interface.InterfaceUtilisateur ctu;
        public static DataSet dt;
        public FrmRechercherVente(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();

            ctv = (Interface.InterfaceVente)Activator.GetObject(typeof(Interface.InterfaceVente), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vente");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");

        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string codevente = TxtCoderecherche.Text;

                dt = ctv.ListerVente(codevente);
                if (codevente.Equals(String.Empty))
                {
                    Erreur.SetError(TxtCoderecherche, "Vide");
                }
                else
                {
                    if (dt != null)
                    {
                        Dgvlister.AutoGenerateColumns = true;
                        Dgvlister.DataSource = dt;
                        Dgvlister.DataMember = "Vente";
                        // tr.EnregistrerTransaction("caissier", "Lister Vente", System.DateTime.Now.ToShortDateString(), co);
                    }
                    else
                    {
                        MessageBox.Show("Aucune Vente ne correspond a ce numero");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}
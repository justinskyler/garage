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
    public partial class FrmModifierEtat : Form
    {
        public Interface.InterfaceUtilisateur ctutilisateur;
        public Interface.InterfaceTranzaction ctt;
        public string var;
        public FrmModifierEtat(Interface.InterfaceUtilisateur  ctc)
        {
            ctutilisateur = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/tranzaction");
            InitializeComponent();
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            if (ctutilisateur.RechercheUtilisateur(txtPseudo.Text.Trim()))
            {
                if (ctutilisateur.retournerEtat() == "bloquer")
                {
                    rdbbloque.Enabled = false;
                    rdbbloque.Checked = true;
                }
                else
                {
                    rdbdebloque.Enabled = false;
                    rdbdebloque.Checked = true;
                }
            }
            else
            {
                //if (!ctu.RechercheUtilisateur(txtPseudo.Text.Trim()) ) {
                //    MessageBox.Show("Pseudo invalide"); 
                //}                
            }
        }

        private void rdbbloque_CheckedChanged(object sender, EventArgs e)
        {
            var = "bloquer";
        }

        private void rdbdebloque_CheckedChanged(object sender, EventArgs e)
        {
            var = "debloquer";
        }

        private void btnEffectuer_Click(object sender, EventArgs e)
        {
            try
            {
                Random co = new Random();
                int code = co.Next(100000, 900000);
                string numOp = String.Format("{0}", code);
                string codetrans = "Trans-" + code;

                ctutilisateur.BloquerDebloquerUtilisateur(txtPseudo.Text.Trim(), var);
                ctutilisateur.retracerutilisateur(numOp, codetrans, ctutilisateur.retournerPseudo(), var, DateTime.Now.ToString());
                ctt.EnregistrerTransaction(codetrans, ctutilisateur.retournerPseudo(), var, DateTime.Now.ToString());
                MessageBox.Show("Utilisateur " + var);
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}

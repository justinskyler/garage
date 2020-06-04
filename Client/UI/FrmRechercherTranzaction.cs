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
    public partial class FrmRechercherTranzaction : Form
    {
        public Interface.InterfaceUtilisateur ctu;
        public Interface.InterfaceTranzaction ctt;
        public DataSet dt;
        public FrmRechercherTranzaction(Interface.InterfaceUtilisateur ctc)
        {
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctt = (Interface.InterfaceTranzaction)Activator.GetObject(typeof(Interface.InterfaceTranzaction), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Tranzaction");
            InitializeComponent();
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string rech = TxtRech.Text.Trim();
                error.Clear();
                if (ctu.NumberValidationTextBox(TxtRech.Text.Trim()) || rech.Equals(String.Empty))
                {
                    error.SetError(TxtRech, "Entrer le nom");
                }
                else
                {

                    bool u = ctu.RechercheUtilisateurTrans(TxtRech.Text.Trim());

                    if (u)
                    {
                        dt = ctt.ListerTranzaction(ctu.retournerPseudo());
                        DgvUser.AutoGenerateColumns = true;
                        DgvUser.DataSource = dt;
                        DgvUser.DataMember = "Trans";
                    }
                    else
                    {

                        MessageBox.Show("Utilisateur Introuvable");
                    }

                }
            }
            catch (Exception ex) {

                MessageBox.Show( ""+ex);
            
            }
            
            }
        }
    }



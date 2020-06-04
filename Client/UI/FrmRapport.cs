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
    public partial class FrmRapport : Form
    {
        public Interface.InterfaceVente ctv;
        public Interface.InterfaceUtilisateur ctu;
        public static string datedebut, datefin;
        public FrmRapport(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            ctv = (Interface.InterfaceVente)Activator.GetObject(typeof(Interface.InterfaceVente), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vente");
        }

        private void FrmRapport_Load(object sender, EventArgs e)
        {
            Dtpdebut.Enabled = false;
            DtpFin.Enabled = false;
        }

        private void Dtpdebut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = ctv.ListerRapportJournalier(Dtpdebut.Value.ToShortDateString(), "grenzimix");
                DgvRapport.AutoGenerateColumns = true;
                DgvRapport.DataSource = dt;
                DgvRapport.DataMember = "Vente";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void RdbJournalier_CheckedChanged(object sender, EventArgs e)
        {

            Dtpdebut.Enabled = true;
            DtpFin.Enabled = false;
            datefin = "";
        }

        private void RdbMois_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Dtpdebut.Enabled = true;
                DtpFin.Enabled = true;
                DgvRapport.Refresh();

                DataSet dt = ctv.ListerRapportMensuel(Dtpdebut.Value.ToShortDateString(), DtpFin.Value.ToShortDateString(), "grenzimix");
                DgvRapport.AutoGenerateColumns = true;
                DgvRapport.DataSource = dt;
                DgvRapport.DataMember = "Vente";
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Dtpdebut.Enabled = true;
                DtpFin.Enabled = true;
                DgvRapport.Refresh();
                DataSet dt = ctv.ListerRapportMensuel(Dtpdebut.Value.ToShortDateString(), DtpFin.Value.ToShortDateString(), "grenzimix");
                DgvRapport.AutoGenerateColumns = true;
                DgvRapport.DataSource = dt;
                DgvRapport.DataMember = "Vente";
                // lblmessage.Text = DtpFin.Value.ToShortDateString();
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdbJournalier.Checked)
                {

                    datedebut = Dtpdebut.Value.ToShortDateString();
                    FrmImpRapport imp = new FrmImpRapport(ctu, datedebut, datefin);
                    imp.Show();
                }
                else
                {
                    datedebut = Dtpdebut.Value.ToShortDateString();
                    datefin = DtpFin.Value.ToShortDateString();
                    FrmImpRapport imp = new FrmImpRapport(ctu, datedebut, datefin);
                    imp.Show();

                }
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex);
            }
        }
    }
}

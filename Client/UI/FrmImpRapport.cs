using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Interface;

namespace UI
{
    public partial class FrmImpRapport : Form
    {
        public Interface.InterfaceVente ctv;
        public string datdebut, datefin;
        public Interface.InterfaceUtilisateur ctu;
        DataSet ds;
        public FrmImpRapport(Interface.InterfaceUtilisateur ctc, string fromdate, string todate)
        {
            InitializeComponent();
            ctv = (Interface.InterfaceVente)Activator.GetObject(typeof(Interface.InterfaceVente), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Vente");
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
            datdebut = fromdate;
            datefin = todate;
        }

        private void FrmImpRapport_Load(object sender, EventArgs e)
        {
            try
            {
                if (datefin == "")
                {
                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load("C:/Users/Angelot Mentus/Documents/Visual Studio 2012/Projects/GestionGarage/UI/CrystalRapport.rpt");
                    ds = ctv.ListerRapportJournalier(datdebut, ctu.retournerPseudo());
                    cryRpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cryRpt;
                    //cryRpt.Load();
                }
                else
                {

                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load("C:/Users/Angelot Mentus/Documents/Visual Studio 2012/Projects/GestionGarage/UI/CrystalRapport.rpt");
                    ds = ctv.ListerRapportMensuel(datdebut, datefin, ctu.retournerPseudo());
                    cryRpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cryRpt;

                }
            }
            catch (Exception ex) { 
            MessageBox.Show(""+ex);
            }
        }
    }
}

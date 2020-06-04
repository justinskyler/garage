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
using Controleur;

namespace UI
{
    public partial class Form1 : Form
    {
        public ControleurVente ctv;
        public  string codevent;
        public Form1( string codevente)
        {
            InitializeComponent();
            ctv = new ControleurVente();
            codevent = codevente;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/Angelot Mentus/documents/visual studio 2012/Projects/GestionGarage/UI/CrystalReport1.rpt ");
            //cryRpt.Load();
            DataSet ds=ctv.ListerVente(codevent);
            cryRpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cryRpt;


        //    
        //    ReportDocument _rpt = new ReportDocument();
        //EmployeeDAC employee = new EmployeeDAC();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    _rpt.Load(Server.MapPath("EmployeeReport.rpt"));
        //    DataSet ds = employee.SelectAll_();
        //    _rpt.SetDataSource(ds);
        //    CrystalReportViewer1.ReportSource = _rpt;
        //cryRpt.Load ("C:/Users/Angelot Mentus/documents/visual studio 2012/Projects/GestionGarage/UI/CrystalReport1.rpt ") ;
        //crystalReportViewer1.ReportSource = cryRpt ;
        //crystalReportViewer1.Refresh();
        }
    }
}

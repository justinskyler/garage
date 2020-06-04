using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

using UI;
namespace UI
{
    static class Program
    {
        public static Interface.InterfaceUtilisateur ut;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                string r = Service.ServeurService .getConfiguration();
            //if (r.Equals(""))
            //{
            //    Application.Run(new FrmConfiguration(ut));
            //}
            //else
            //{
                //Application.Run(new FenMenu(cl,u,c));
               // Application.Run(new FrmModifierEtat());
           // }
           //Application.Run(new FrmEnregistrerCLientEtVoiture());
            //Application.Run(new FrmModifierPiece());
            //Application.Run(new FrmRechercherPiece());
            Application.Run(new FrmConnexion());
                      
        }
    }
}

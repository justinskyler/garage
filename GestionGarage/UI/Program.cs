using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controleur;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new FrmEnregistrerCLientEtVoiture());
            //Application.Run(new FrmModifierPiece());
            //Application.Run(new FrmRechercherPiece());
            Application.Run(new FrmConnexion());
                      
        }
    }
}

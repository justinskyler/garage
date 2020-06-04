using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using System.IO;
using System.Net.NetworkInformation;

namespace Service
{
   public class ServeurService
    {
        public static bool IsServeurOn()
        {
            bool resultat = false;
            try
            {
                Interface.InterfaceServeur se;

                se = (Interface.InterfaceServeur)Activator.GetObject(typeof(Interface.InterfaceServeur), Service.ServeurService.getConfiguration() + "ObjetServeur");
                se.Serveur();
                resultat = true;
            }
            catch (Exception)
            {
                resultat = false;
            }
            return resultat;
        }

        public static string getConfiguration()
        {
            string r = "";
            if (File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Documents\\configuration.config"))
            {
                //StreamWriter ecrire = new StreamWriter(@"C:\\Users\\" + Environment.UserName + "\\Documents\\c.config");
                StreamReader lire = new StreamReader(@"C:\\Users\\" + Environment.UserName + "\\Documents\\configuration.config");
                string ligne = lire.ReadLine();

                r = "tcp://" + ligne + "/";
                lire.Close();
            }
            else
            {
                r = "";
            }
            return r;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public interface InterfaceClient
    {
       void modifierNoDossier(string codecli);
       string retournerNoDossier();
      void modifierNomclient(string nomcli);
      string retournerNomClient();
      void modifierPrenomclient(string prenomcli);
      string retournerPrenomClient();
      void modifierAdresseClient(string adressecli);
      string retournerAdresseClient();
      void modifierTelephoneClient(string telephonecli);
      string retournerTelephoneClient();
      void modifierNifClient(string nifcli);
      string retournerNifClient();


       bool EnregistrerClient(string nodossier, string nom, string prenom, string adresse, string telephone, string nif);
        

    }
}

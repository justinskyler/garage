using Dal;
using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    public class ControleurClient
    {
        public Client client;

         public ControleurClient()
        {
            client = new Client();
        }

         public void modifierNoDossier(string codecli) { client.setNodossier(codecli); }
         public string retournerNoDossier() { return client.getNoDossier(); }
         public void modifierNomclient(string nomcli) { client.setNom(nomcli); }
         public string retournerNomClient() { return client.getNom(); }
         public void modifierPrenomclient(string prenomcli) { client.setPrenom(prenomcli); }
         public string retournerPrenomClient() { return client.getPrenom(); }
         public void modifierAdresseClient(string adressecli) { client.setAdresse(adressecli ); }
         public string retournerAdresseClient() { return client.getAdresse(); }
         public void modifierTelephoneClient(string telephonecli) { client.setTelephone(telephonecli); }
         public string retournerTelephoneClient() { return client.getTelephone(); }
         public void modifierNifClient(string nifcli) { client.setNif(nifcli); }
         public string retournerNifClient() { return client.getNif(); }


         public string EnregistrerClient(string nodossier, string nom, string prenom, string adresse, string telephone, string nif)
         {

             string resultat = "";
             client = new Client(nodossier , nom, prenom, adresse, telephone, nif);
             resultat = DalClient.EnregistrerClient(client);
             return resultat;
         }

    }
}

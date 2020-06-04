using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Client
    {
        private string NoDossier;
        private string Nom;
        private string Prenom;
        private string Adresse;
        private string Telephone;
        private string Nif;

        public Client() { }
        public Client(string Nodossier, string nom, string prenom, string adresse, string telephone, string nif)
        {

            this.NoDossier = Nodossier;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Nif = nif;
        }

        public string getNoDossier()
        {
            return NoDossier;
        }
        public string getNom()
        {
            return Nom;
        }
        public string getPrenom()
        {
            return Prenom;
        }
        public string getAdresse()
        {
            return Adresse;
        }
        public string getTelephone()
        {
            return Telephone;
        }
        public string getNif()
        {
            return Nif;
        }


        public void setNodossier(string nodossier)
        {
            this.NoDossier = nodossier;
        }
        public void setNom(string nom)
        {
            this.Nom = nom;
        }
        public void setPrenom(string prenom)
        {
            this.Prenom = prenom;
        }
        public void setAdresse(string adresse)
        {
            this.Adresse = adresse;
        }
        public void setTelephone(string Telephone)
        {
            this.Telephone = Telephone;
        }
        public void setNif(string nif)
        {
            this.Nif = nif;
        }


    }
}

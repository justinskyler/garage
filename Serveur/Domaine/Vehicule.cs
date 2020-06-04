using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Vehicule
    {
        private string NoDossier;
        private string Marque;
        private string Modele;
        private string Plaque;
        private string Type;
        private string Serie;
        private string Annee;
        private string Couleur;

        public Vehicule() { }
        public Vehicule(string nodossier, string marque, string modele, string plaque, string type, string serie, string annee, string couleur)
        {

            this.NoDossier = nodossier;
            this.Plaque = plaque;
            this.Marque = marque;
            this.Modele = modele;
            this.Serie = serie;
            this.Type = type;
            this.Couleur = couleur;
            this.Annee = annee;

        }


        public string getNoDossier()
        {
            return NoDossier;
        }
        public string getPlaque()
        {
            return Plaque;
        }
        public string getMarque()
        {
            return Marque;
        }
        public string getModele()
        {
            return Modele;
        }
        public string getSerie()
        {
            return Serie;
        }
        public string getType()
        {
            return Type;
        }
        public string getCouleur()
        {
            return Couleur;
        }
        public string getAnnee()
        {
            return Annee;
        }


        public void setNodossier(string nodossier)
        {
            this.NoDossier = nodossier;
        }
        public void setPlaque(string plaque)
        {
            this.Plaque = plaque;
        }
        public void setMarque(string marque)
        {
            this.Marque = marque;
        }
        public void setModele(string modele)
        {
            this.Modele = modele;
        }
        public void setSerie(string serie)
        {
            this.Serie = serie;
        }
        public void setType(string type)
        {
            this.Type = type;
        }
        public void setCouleur(string couleur)
        {
            this.Couleur = couleur;
        }
        public void setAnnee(string annee)
        {
            this.Annee = annee;
        }

    }
}

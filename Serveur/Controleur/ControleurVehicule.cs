using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Domaine;
namespace Controleur
{
    public class ControleurVehicule : Interface.InterfaceVehicule
    {
        public Vehicule vehi;
        public ControleurVehicule()
        {
            vehi = new Vehicule();
        }

        public void modifierNoDossier(string codevehi) { vehi.setNodossier(codevehi); }
        public string retournerNoDossier() { return vehi.getNoDossier(); }
        public void modifierMarque(string  marque) { vehi.setMarque(marque); }
        public string retournerMarque() { return vehi.getMarque(); }
        public void modifierModele(string modele) { vehi.setModele(modele); }
        public string retournerModele() { return vehi.getModele(); }
        public void modifierPlaque(string plaque) { vehi.setPlaque(plaque ); }
        public string retournerPlaque() { return vehi.getPlaque(); }
        public void modifierType(string type) { vehi.setType(type); }
        public string retournerType() { return vehi.getType(); }
        public void modifierSerie(string serie) { vehi.setSerie(serie); }
        public string retournerSerie() { return vehi.getSerie(); }
        public void modifierAnnee(string annee) { vehi.setAnnee(annee); }
        public string retournerAnnee() { return vehi.getAnnee(); }
        public void modifierCouleur(string couleur) { vehi.setCouleur(couleur); }
        public string retournerCouleur() { return vehi.getCouleur(); }

        public bool EnregistrerVehicule(string nodossier, string marque, string modele, string plaque, string type, string serie, string annee, string couleur)
        {

            bool resultat =false;
            vehi = new Vehicule(nodossier, marque,modele,plaque,type,serie,annee,couleur);
            resultat = DalVehicule.EnregistrerVehicule(vehi);
            return resultat;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface InterfaceVehicule
    {
        void modifierNoDossier(string codevehi);
        string retournerNoDossier();
        void modifierMarque(string marque);
         string retournerMarque();
        void modifierModele(string modele);
        string retournerModele();
        void modifierPlaque(string plaque);
       string retournerPlaque();
        void modifierType(string type);
        string retournerType();
         void modifierSerie(string serie);
         string retournerSerie();
        void modifierAnnee(string annee);
        string retournerAnnee();
        void modifierCouleur(string couleur);
       string retournerCouleur();

         bool EnregistrerVehicule(string nodossier, string marque, string modele, string plaque, string type, string serie, string annee, string couleur);

    }
}

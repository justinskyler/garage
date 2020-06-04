using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interface
{
   public interface InterfaceUtilisateur
    {

        void modifierCode(string code);
        string retournerCode();
        void modifierNom(string nom);
        string retournerNom();
        void modifierPrenom(string prenom);
        string retournerPrenom();
        void modifierPseudo(string pseudo);
        string retournerPseudo();
        void modifierMotdePasse(string motdepasse);
        string retournerMotdePasse();
        void modifierFonction(string fonc);
        string retournerFonction();
        void modifierEtat(string etat);
        string retournerEtat();
        void modifierDateAjout(string dateajout);
        string retournerDateAjout();

        void modifierStatut(string statut);
        string retourneStatut();

        bool NumberValidationTextBox(string entrer);
        bool ValidationMotdePasse(string entrer);
        bool StringValidationTextBox(string entrer);
        bool EnregistrerUtilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string fonction, string etat, string dateajout, string statut);
        bool RechercheUtilisateur(string critere);
        bool RechercheUtilisateurTrans(string critere);

        bool ModifierUtilisateur(string pseudo, string nom, string prenom, string fonction,string statut);
        DataSet ListerUtilisateur();
        DataSet ListerUtilisateur(string critere);
        bool ModifierMotdePasse(string pseudo, string modepasse);
        bool BloquerDebloquerUtilisateur(string critere, string etat);
       
       
       
       
       bool Login(string pseudo, string motdepasse);
       
       
       
       
       
       
       
       
       
       
       bool Login1(string pseudo);
        bool Deconnexion(string pseudo);

        bool retracerutilisateur(string numOp, string codeoperation, string pseudo, string operation, string dateop);
    }

}

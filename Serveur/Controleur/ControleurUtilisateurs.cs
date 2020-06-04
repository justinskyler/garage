using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;
using Dal;
using System.Data;
namespace Controleur
{
    public class ControleurUtilisateurs : MarshalByRefObject, Interface.InterfaceUtilisateur
    {
        public Utilisateurs util;
        public ControleurUtilisateurs() { util = new Utilisateurs(); }
        public void modifierCode(string code) { util.setCode(code); }
        public string retournerCode() { return util.getCode(); }
        public void modifierNom(string nom) { util.setNom(nom); }
        public string retournerNom() { return util.getNom(); }
        public void modifierPrenom(string prenom) { util.setPrenom(prenom); }
        public string retournerPrenom() { return util.getPrenom(); }
        public void modifierPseudo(string pseudo) { util.setPseudo(pseudo); }
        public string retournerPseudo() { return util.getPseudo(); }
        public void modifierMotdePasse(string motdepasse) { util.setMotdePasse(motdepasse); }
        public string retournerMotdePasse() { return util.getMotdePasse(); }
        public void modifierFonction(string fonc) { util.setFonction(fonc); }
        public string retournerFonction() { return util.getFonction(); }
        public void modifierEtat(string etat) { util.setEtat(etat); }
        public string retournerEtat() { return util.getEtat(); }
        public void modifierDateAjout(string dateajout) { util.setDateAjout(dateajout); }
        public string retournerDateAjout() { return util.getDateAjout(); }

        public void modifierStatut(string statut) { util.setEtat(statut); }
        public string retourneStatut() { return util.getStatut(); }

        public bool NumberValidationTextBox(string entrer)
        {
            Contrainte co = new Contrainte();
            return co.NumberValidationTextBox(entrer);
        }
        public bool ValidationMotdePasse(string entrer)
        {
            bool chaine = false;
            Contrainte co = new Contrainte();
            chaine = co.ValidationMotdePasse(entrer);

            return chaine;
        }
        public bool StringValidationTextBox(string entrer)
        {
            bool chaine = false;
            Contrainte co = new Contrainte();
            chaine = co.StringValidationTextBox(entrer);

            return chaine;
        }
        public bool EnregistrerUtilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string fonction, string etat, string dateajout, string statut)
        {

            bool resultat;
            util = new Utilisateurs(code, nom, prenom, pseudo, motdepasse, fonction, etat, dateajout, statut);
            resultat = DalUtilisateurs.EnregistrerUtilisateur(util);
            return resultat;
        }
        public bool RechercheUtilisateur(string critere)
        {

            bool verif = false;
            try
            {
                util = new Utilisateurs();
                util = DalUtilisateurs.RechercherUtilisateur(critere);

                if (util.getCode() != null)
                {
                    verif = true;
                }
                else { verif = false; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
            return verif;         
        }
        public bool RechercheUtilisateurTrans(string critere)
        {

            bool verif = false;
            try
            {
                util = new Utilisateurs();
                util = DalUtilisateurs.RechercherUtilisateurTrans(critere);

                if (util.getCode() != null)
                {
                    verif = true;
                }
                else { verif = false; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return verif;
        }
        
        public bool  ModifierUtilisateur(string pseudo, string nom,string prenom,string fonction,string statut )
        {

           bool resultat = false;
           
            resultat = DalUtilisateurs.ModifierUtilisateur( pseudo,  nom,prenom,fonction ,statut);
            return resultat;
        } 
        public DataSet ListerUtilisateur()
        {
            DataSet ds = new DataSet();
            ds = DalUtilisateurs.ListerUtilisateur();
            return ds;
        }
        public DataSet ListerUtilisateur(string critere)
        {
            DataSet ds = new DataSet();
            ds = DalUtilisateurs.ListerUtilisateur(critere);
            return ds;
        }    
        public bool ModifierMotdePasse(string pseudo,string modepasse) {
            bool mess = false; ;
            mess = DalUtilisateurs.ModifierMotdePasse(pseudo, modepasse);
            return mess;
        
        }

        public bool Login(string pseudo, string motdepasse)
        {

            bool verif = false;
            try
            {
                util = new Utilisateurs();
                util = DalUtilisateurs.Login(pseudo,motdepasse);

                if (util.getCode() != null)
                {
                    verif = true;
                }
                else { verif = false; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return verif;
        }
        public bool Login1(string pseudo)
        {
            bool result =false;
            result = DalUtilisateurs.Login1(pseudo);
            return result;
        }      
        public bool Deconnexion(string pseudo) {
            bool result = false;
            result = DalUtilisateurs.Deconnexion(pseudo);
            return result;
        }

        public bool BloquerDebloquerUtilisateur(string critere, string etat)
        {
            bool resultat = false;
            resultat = DalUtilisateurs.BloquerDebloquerUtilisateur(critere, etat);
            return resultat;
        }

        public bool retracerutilisateur(string numOp,string codeoperation,string pseudo,string operation,string dateop) {

            Tranzaction trans = new Tranzaction(codeoperation, pseudo, operation, dateop);
            return DalUtilisateurs.retracerUtilisateur(numOp,trans);
        
        }

    }
}

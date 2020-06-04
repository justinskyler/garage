using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Utilisateurs
    {
        private string Code;
        private string Nom;
        private string Prenom;
        private string Pseudo;
        private string MotdePasse;
        private string Fontion;
        private string Etat;
        private string DateAjout;
        private string Statut;
        

        public Utilisateurs() { }
        public Utilisateurs(string Code, string Nom, string Prenom, string Pseudo, string MotdePasse, string Fontion, string Etat, string DateAjout, string statut)
        {
            this.Code = Code;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Pseudo = Pseudo;
            this.MotdePasse = MotdePasse;
            this.Fontion = Fontion;
            this.Etat = Etat;
            this.DateAjout = DateAjout;
            this.Statut = statut;
            
        }
        public string getCode()
        {
            return Code;
        }
        public string getNom()
        {
            return Nom;
        }
        public string getPrenom()
        {
            return Prenom;
        }
        public string getPseudo()
        {
            return Pseudo;
        }
        public string getMotdePasse()
        {
            return MotdePasse;
        }
        public string getFonction()
        {
            return Fontion;
        }
        public string getEtat()
        {
            return Etat;
        }
        public string getDateAjout()
        {
            return DateAjout;
        }
        public string getStatut()
        {
            return Statut;
        }
       

        public void setCode(string code)
        {
            this.Code = code;
        }
        public void setNom(string nom)
        {
            this.Nom = nom;
        }
        public void setPrenom(string prenom)
        {
            this.Prenom = prenom;
        }
        public void setPseudo(string pseudo)
        {
            this.Pseudo = pseudo;
        }
        public void setMotdePasse(string motdepasse)
        {
            this.MotdePasse = motdepasse;
        }
        public void setFonction(string fonction)
        {
            this.Fontion = fonction;
        }
        public void setEtat(string etat)
        {
            this.Etat = etat;
        }
        public void setDateAjout(string dateajout)
        {
            this.DateAjout = dateajout;
        }
        public void setStatut(string statut)
        {
            this.Statut= statut;
        }
        
    }
}

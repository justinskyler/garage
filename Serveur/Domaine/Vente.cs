using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Vente
    {
        private string NomAgent;
        private string CodeVente;
        private string CodeProduit;
        private int Quantite;
        private double Montant;
        private string DateVente;
        public Vente() { }

        public Vente(string nomagent, string codevente, string codeproduit, int quantite, double montant,string datevente)
        {
            this.CodeVente = codevente;
            this.CodeProduit = codeproduit;
            this.Quantite = quantite;
            this.Montant = montant;
            this.NomAgent = nomagent;
            this.DateVente = datevente;
        }


        public void setCodevente(string codev)
        {
            this.CodeVente = codev;
        }
        public string getCodevente()
        {
            return CodeVente;
        }

        public void setCodeproduit(string codep)
        {
            this.CodeProduit = codep;
        }
        public string getCodeproduit()
        {
            return CodeProduit;
        }

        public void setMontant(double montant)
        {
            this.Montant = montant;
        }
        public double getMontant()
        {
            return Montant;
        }

        public void setNomAgent(string nom)
        {
            this.NomAgent = nom;
        }
        public string getNomAgent()
        {
            return NomAgent;
        }

        public void setQuantite(int quantite)
        {
            this.Quantite = quantite;
        }
        public int getQuantite()
        {
            return Quantite;
        }

        public void setDateVente(string datevente)
        {
            this.DateVente = datevente;
        }
        public string getDatevente()
        {
            return DateVente;
        }
   
   
   }
}

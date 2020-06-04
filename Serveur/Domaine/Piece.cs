using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Pieces
    {
        private string CodePiece;
        private string Nom;
        private string Description;
        private int Quantite;
        private double PrixUnit;
        private string DateAjout;
        public Pieces() { }

        public Pieces(string codepiece,string nompiece ,string description, int qte, double prixunit, string date)
        {

            this.CodePiece = codepiece;
            this.Nom = nompiece;
            this.Description = description;
            this.Quantite = qte;
            this.PrixUnit = prixunit;
            this.DateAjout = date;

        }

        public string getCodePiece()
        {
            return CodePiece;
        }
        public string getNomPiece()
        {
            return Nom;
        }
        public string getDescription()
        {
            return Description;
        }
        public int getQuantite()
        {
            return Quantite;
        }
        public double getPrixUnit()
        {
            return PrixUnit;
        }
        public string getDateAjout()
        {
            return DateAjout;
        }


        public void setCodePiece(string codepiece)
        {
            this.CodePiece = codepiece;
        }

        public void setNomPiece(string nompiece)
        {
            this.Nom = nompiece;
        }
        public void setDescription(string description)
        {
            this.Description = description;
        }
        public void setQuantite(int quantite)
        {
            this.Quantite = quantite;
        }
        public void setPrixUnit(double prixunit)
        {
            this.PrixUnit = prixunit;
        }
        public void setDateAjout(string dateajout)
        {
            this.DateAjout = dateajout;
        }


    }
}

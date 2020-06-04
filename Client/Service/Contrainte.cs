using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Contrainte
    {
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Domaine
{
    public class Contrainte
    {

        public bool NumberValidationTextBox(string enter)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(enter))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool StringValidationTextBox(string enter)
        {
            Regex regex = new Regex("^[A-Za-z][a-zA-Z '\\-]+$");
            if (regex.IsMatch(enter))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ValidationMotdePasse(string enter)
        {
            Regex regex = new Regex("#^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\\W)#");
            if (regex.IsMatch(enter))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

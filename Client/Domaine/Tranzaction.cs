using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Tranzaction
    {
        private string CodeTrans;
        public string Pseudo;
        public string Operation;
        public string DateHeureOp;

        public Tranzaction() { }
        public Tranzaction(string codetrans,string pseudo, string operation, string date) {

            this.CodeTrans = codetrans;
            this.Pseudo = pseudo;
            this.Operation = operation;
            this.DateHeureOp = date;
        }

        public string getCodeTrans(){
            return CodeTrans;
        }

        public string getPseudo()
        {
            return Pseudo;
        }

        public string getOperation() {
            return Operation;
        }

        public string getDateOp() {
            return DateHeureOp;
        }

        public void setCodetrans(string codetrans)
        {
            this.CodeTrans = codetrans;
        }

        public void setPseudo(string pseudo)
        {
            this.Pseudo = pseudo;
        }


        public void setOperation(string operation)
        {
            this.Operation = operation;
        }

        public void setDateheure(string dateheure)
        {
            this.DateHeureOp = dateheure;
        }

    }
}

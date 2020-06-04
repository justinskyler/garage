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
    public class ControleurTransaction : MarshalByRefObject, Interface.InterfaceTranzaction
    {
        public Tranzaction trans;
        public ControleurTransaction()
        {
            trans = new Tranzaction();
        }

        public void modifierCodeTrans(string codetrans) { trans.setCodetrans(codetrans); }
        public string retournerCodeTrans() { return trans.getCodeTrans(); }

        public void modifierPseudo(string pseudo) { trans.setPseudo(pseudo); }
        public string retournerPseudo() { return trans.getPseudo(); }

        public void modifierOperation(string operation) { trans.setOperation(operation); }
        public string retournerOperation() { return trans.getOperation(); }

        public void modifierDateOp(string dateOp) { trans.setDateheure(dateOp); }
        public string retournerDateOp() { return trans.getDateOp(); }

        public bool EnregistrerTransaction(string codetrans,string pseudo,string operation,string dateop)
        {
            Tranzaction trans = new Tranzaction(codetrans,pseudo,operation,dateop);
            return DalTranzaction.EnregistrerTrans(trans);
        }

        public DataSet ListerTranzaction(string critere)
        {
            DataSet ds = new DataSet();
            ds = DalTranzaction.ListerTransaction(critere);
            return ds;
        }
        public DataSet ListerTranzactions()
        {
            DataSet ds = new DataSet();
            ds = DalTranzaction.ListerAllTransaction();
            return ds;
        }    



    }
}

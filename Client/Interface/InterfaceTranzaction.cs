using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Interface
{
    public interface InterfaceTranzaction
    {
        void modifierCodeTrans(string codetrans);
        string retournerCodeTrans();

        void modifierPseudo(string pseudo);
        string retournerPseudo();

        void modifierOperation(string operation);
        string retournerOperation();

        void modifierDateOp(string dateOp);
        string retournerDateOp();

        bool EnregistrerTransaction(string codetrans, string pseudo, string operation, string dateop);
        DataSet ListerTranzaction(string critere);
        DataSet ListerTranzactions();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Interface
{
   public  interface InterfaceVente
    {
        void modifierAgent(string agent);
        string retournerAgent();
        void modifierCodeVente(string codevente);
        string retournerCodeVente();
        void modifierCodeProduit(string codeproduit);
        string retournerProduit();
        void modifierQuantite(int quantite);
        int retournerQuantite();
        void modifierDatevente(string datevente);
        string retournerDateDente();
        bool EffectuerVente(string agent, string codev, string codep, int qte, double mont, string date);
        DataSet ListerVente(string codevente);
        DataSet ListerVentes();
        DataSet ListerVentes(string pseudo);
        DataSet ListerRapportJournalier(string date, string pseudo);

        DataSet ListerRapportMensuel(string fromdate, string todate, string pseudo);
    }
}

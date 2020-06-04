using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Domaine;
using System.Data;

namespace Controleur
{
    public class ControleurVente
    {
        public Vente vent;
        public ControleurVente() {
            vent = new Vente ();
        }

        public void modifierAgent(string agent) { vent.setNomAgent(agent); }
        public string retournerAgent() { return vent.getNomAgent(); }
        public void modifierCodeVente(string codevente) { vent.setCodevente(codevente); }
        public string retournerCodeVente() { return vent.getCodevente(); }
        public void modifierCodeProduit(string codeproduit) { vent.setCodeproduit(codeproduit); }
        public string retournerProduit() { return vent.getCodeproduit(); }
        public void modifierQuantite(int quantite) { vent.setQuantite(quantite); }
        public int retournerQuantite() { return vent.getQuantite(); }
        public void modifierDatevente(string datevente) { vent.setDateVente(datevente); }
        public string retournerDateDente() { return vent.getDatevente(); }

        public string EffectuerVente(string agent, string codev, string codep, int qte, double mont, string date)
        {

            string result = "";
            vent = new Vente(agent, codev, codep, qte, mont, date);
            result = DalVente.EffectuerVente(vent);
            return result;
        }
        public DataSet ListerVente(string codevente) { 
        
            DataSet dt=null;
        dt=DalVente.ListerVente (codevente);
        return dt;
        }

    }
}

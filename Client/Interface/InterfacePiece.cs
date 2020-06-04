using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interface
{
    public interface InterfacePiece
    {
        void modifierCodePiece(string codepiece);
        string retournerCodePiece();
        void modifierNomPiece(string nompiece);
        string retournerNomPiece();
        void modifierDescription(string description);
        string retournerDescription();
        void modifierQuantite(int quantite);
        int retournerQuantite();
        void modifierPrix(double prix);
        double retournerPrix();
        void modifierDateAjout(string dateajout);
        string retournerDateAjout();

        bool EnregistrerPiece(string codepiece, string nompiece, string description, int quantite, double prix, string dateajout);

        DataSet ListerPieces();

        DataSet ListerPiecess(string critere);

        bool rechercherPiece(string critere);

        bool ModifierQuantitePiece(string codepiece, int qte);

        bool supprimerPiece(string code);
    }
}

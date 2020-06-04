﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
using Domaine;
namespace Controleur
{
    public class ControleurPieces
    {
        public Pieces piece;
        public ControleurPieces() {
            piece = new Pieces();
        }

        public void modifierCodePiece(string codepiece) { piece.setCodePiece(codepiece); }
        public string retournerCodePiece() { return piece.getCodePiece(); }
        public void modifierNomPiece(string nompiece) { piece.setNomPiece(nompiece); }
        public string retournerNomPiece() { return piece.getNomPiece(); }
        public void modifierDescription(string description) { piece.setDescription(description); }
        public string retournerDescription() { return piece.getDescription(); }
        public void modifierQuantite(int quantite) { piece.setQuantite(quantite); }
        public int retournerQuantite() { return piece.getQuantite(); }
        public void modifierPrix(double prix) { piece.setPrixUnit(prix); }
        public double retournerPrix() { return piece.getPrixUnit(); }
        public void modifierDateAjout(string dateajout) { piece.setDateAjout(dateajout); }
        public string retournerDateAjout() { return piece.getDateAjout(); }

        public string EnregistrerPiece(string codepiece, string nompiece, string description, int quantite, double prix, string dateajout)
        {

            string resultat = "";
            piece = new Pieces(codepiece, nompiece, description, quantite, prix, dateajout);
            resultat = DalPiece.AjouterPiece(piece);
            return resultat;
        }

        public DataSet ListerPieces()
        {

            DataSet dt = new DataSet();
            dt = DalPiece.ListerPieces();
            return dt;
        }

        public DataSet ListerPiecess(string critere)
        {

            DataSet dt = new DataSet();
            dt = DalPiece.ListerPiecess(critere);
            return dt;
        }

        public Pieces  rechercherPiece(string critere) {

            return piece= DalPiece.rechercherPieces(critere);
        }

        public string ModifierQuantitePiece(string codepiece, int qte)
        {
            string resutl;
            return resutl = DalPiece.ModifierQuantitePiece(codepiece, qte);
        
        }

        public string supprimerPiece(string code) {
            string result = "";
            result=DalPiece.supprimerPiece(code);
            return result;
        }


    }
}

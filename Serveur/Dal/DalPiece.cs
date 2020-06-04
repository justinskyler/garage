using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domaine;
using System.Data;

namespace Dal
{
    public class DalPiece
    {
        public static string chaine = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader rd = null;
        public static SqlDataAdapter sda = new SqlDataAdapter();
        public static SqlCommandBuilder com = new SqlCommandBuilder();
        //public Pieces pieces;


        public static bool AjouterPiece(Pieces piece)
        {
            bool message = false;
            
            string query = "insert into Pieces (CodePiece,NomPiece ,Description,Quantite,Prix,DateAjout) values('" + piece.getCodePiece() + "','" + piece.getNomPiece() + "','" + piece.getDescription() + "','" + piece.getQuantite() + "','" + piece.getPrixUnit() + "','" + piece.getDateAjout() + "')";


            con = new SqlConnection(chaine);
            int verif = 0;
           
            try
            {

                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message = true;

                }
               

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return message;
        }

        public static string rechercherPiece(string codepiece)
        {
            string vent = "";
            string query = "select *from Pieces where CodePiece='" + codepiece + "'or  Description='" + codepiece + "'or  NomPiece='" + codepiece + "'";

            try
            {


                con = new SqlConnection(chaine);
                con.Open();
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();


                if (rd.Read())
                {

                    vent = rd.GetString(1);

                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return vent;
        }

        public static Pieces rechercherPieces(string codepiece)
        {
            Pieces pieces = new Pieces();
            string query = "select *from Pieces where CodePiece='" + codepiece + "'";

            try
            {


                con = new SqlConnection(chaine);
                con.Open();
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();


                while (rd.Read())
                {

                    pieces.setCodePiece(rd.GetString(0));
                    pieces.setNomPiece(rd.GetString(1));
                    pieces.setDescription(rd.GetString(2));
                    pieces.setQuantite(rd.GetInt32(3));
                    pieces.setPrixUnit(rd.GetDouble(4));
                    pieces.setDateAjout(rd.GetString(5));


                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return pieces;
        }

        public  static bool supprimerPiece(string codepiece)
        {
            string query = "Delete from Pieces where CodePiece='" + codepiece +  "'";


            con = new SqlConnection(chaine);
            int verif = 0;
            bool message = false;
            try
            {

                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message =true;

                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }




            return message;
        }

        public static  bool ModifierStockPiece(string codepiece, int qte,double prix,string nompiece )
        {
            string query = "Update Pieces set Quantite= '" + qte + "', Prix= '" + prix + "', NomPiece= '" + nompiece + "' where CodePiece='" + codepiece + "'";


            con = new SqlConnection(chaine);
            int verif = 0;
            bool message = false;
            try
            {

                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message = true;

                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }




            return message;

        }

        public static bool ModifierQuantitePiece(string codepiece, double qte)
        {
            string query = "Update Pieces set Quantite= '" + qte + "' where CodePiece='" + codepiece + "'";


            con = new SqlConnection(chaine);
            int verif = 0;
            bool message = false;
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message =true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return message;
        }

        public static DataSet ListerPieces()
        {
            DataSet dataset = new DataSet();
            string req = "SELECT * from Pieces";
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                dataset = new DataSet();
                sda = new SqlDataAdapter(req, con);
                sda.Fill(dataset, "Pieces");
                com = new SqlCommandBuilder(sda);
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return dataset;
        }

        public static DataSet ListerPiecess(string codepiece)
        {
            DataSet dataset = new DataSet();
            string req = "select *from Pieces where CodePiece like'%" + codepiece + "%'or  Description like'%" + codepiece + "%'or  NomPiece like'%" + codepiece + "%'";
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                dataset = new DataSet();
                sda = new SqlDataAdapter(req, con);
                sda.Fill(dataset, "Pieces");
                com = new SqlCommandBuilder(sda);
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return dataset;
        }


    }
}

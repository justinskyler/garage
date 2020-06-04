using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domaine;

namespace Dal
{
    public class DalClient
    {
        public static string chaine = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader rd = null;

        public static string  EnregistrerClient(Client cli)
        {
            string query = "insert into Client (NoDossier,Nom,Prenom,Adresse,Telephone,NIF) values('" + cli.getNoDossier()  + "','" + cli.getNom() + "','" + cli.getPrenom() + "','" + cli.getAdresse() + "','" + cli.getTelephone() + "','" + cli.getNif() + "')";


            con = new SqlConnection(chaine);
            int verif = 0;
            string message = "";
            try
            {

                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message = "Client enregistré";

                }

            }
            catch (SqlException ex)
            {
                message = "Error" + ex.Message;

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


    }
}

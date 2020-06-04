using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domaine;
namespace Dal
{
    public class DalVehicule
    {
        public static string chaine = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader rd = null;

        public static bool EnregistrerVehicule(Vehicule vehi)
        {
            string query = "insert into Vehicule (NoDossier,Marque,Modele,Plaque,Type,Serie,Annee,Couleur) values('" + vehi.getNoDossier() + "','" + vehi.getMarque() + "','" + vehi.getModele() + "','" + vehi.getPlaque() + "','" + vehi.getType() + "','" +vehi.getSerie() + "','" + vehi.getAnnee() + "','" +vehi.getCouleur() + "')";


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
                    message = false;

                }

            }
            catch (SqlException ex)
            {
                throw ex;

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

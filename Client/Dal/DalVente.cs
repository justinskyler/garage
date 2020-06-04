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
    public class DalVente
    {
        public static string chaine = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader rd = null;
        public Vente vent;
        public static SqlDataAdapter sda = new SqlDataAdapter();
        public static SqlCommandBuilder com = new SqlCommandBuilder();

        public static string EffectuerVente(Vente vt)
        {
            string query = "insert into Vente (Agent,CodeVente,CodeProduit,Quantite,Montant,DateVente) values('" + vt.getNomAgent() + "','" + vt.getCodevente() + "','" + vt.getCodeproduit() + "','" + vt.getQuantite() + "','" + vt.getMontant() + "','" + vt.getDatevente() + "')";


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
                    message = "Vente effectuee";

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
        public static DataSet ListerVente(string codevente)
        {
            DataSet dataset = new DataSet();
            string req = "select *from Vente where Codevente ='" + codevente + "'";
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                dataset = new DataSet();
                sda = new SqlDataAdapter(req, con);
                sda.Fill(dataset, "Vente");
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

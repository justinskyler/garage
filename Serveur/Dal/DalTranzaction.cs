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
    public class DalTranzaction
    {

        public static string chaine = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public Tranzaction trans;
        public static bool EnregistrerTrans(Tranzaction trans)
        {
            string query = "insert into Trans (CodeTrans,Pseudo,Operation,DateHeureOp) values ('" + trans.getCodeTrans() + "','" + trans.getPseudo() + "','" + trans.getOperation() + "','" + trans.getDateOp() + "')";
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
        public static DataSet ListerTransaction(string pseudo)
        {

            string query = "select * from Trans where Pseudo='" + pseudo + "'";
            SqlCommandBuilder com = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet dt = new DataSet();
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                dt = new DataSet();
                sda = new SqlDataAdapter(query, con);
                sda.Fill(dt, "Trans");
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
            return dt;
        }
        public static DataSet ListerAllTransaction()
        {

            string query = "select * from Trans ";
            SqlCommandBuilder com = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet dt = new DataSet();
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                dt = new DataSet();
                sda = new SqlDataAdapter(query, con);
                sda.Fill(dt, "Trans");
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


            return dt;
        }
    }
}

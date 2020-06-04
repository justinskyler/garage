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
    public class DalUtilisateurs
    {

        public static string chaine_connection = "Data Source=.;Initial Catalog=Garage;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader rd = null;
        public static SqlCommandBuilder com = null;
        public static SqlDataAdapter sda = new SqlDataAdapter();

        public static string EnregistrerUtilisateur(Utilisateurs u1)
        {
            bool resultat = false;
            string message = "";
            string req = "insert into Utilisateurs (Code,Nom,Prenom,Pseudo,MotdePasse,Fonction,Etat,DateAjout,Statut) values ('" + u1.getCode() + "','" + u1.getNom() + "','" + u1.getPrenom() + "','" + u1.getPseudo() + "','" + u1.getMotdePasse() + "','" + u1.getFonction() + "','" + u1.getEtat() + "','" + DateTime.Now.ToShortDateString() + "','" + u1.getStatut() + "')";
            try
            {
                con = new SqlConnection(chaine_connection);
                int verif = 0;
                
                

                    con.Open();
                    cmd = new SqlCommand(req, con);
                    verif = cmd.ExecuteNonQuery();
                    if (verif != 0)
                    {
                        message = "Utilisateur enregistré";

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
        public static Utilisateurs RechercherUtilisateur(string pseudo)
        {
            Utilisateurs u = null;

            string req = "select * from Utilisateurs where Pseudo='" + pseudo + "'or Code='" + pseudo + "'";
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    u = new Utilisateurs(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetString(7), rd.GetString(8));

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

            return u;
        }
        public static Utilisateurs Login(string pseudo, string motdepasse)
        {
            string req = "select * from Utilisateurs where Pseudo='" + pseudo + "' and MotdePasse='" + motdepasse + "'";
            Utilisateurs utt = null;
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    utt = new Utilisateurs(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetString(7), rd.GetString(8));

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("" + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return utt;
        }
        public static string Login1(string pseudo)
        {
            string resultat = "";
            string req = "update Utilisateurs set Statut='online' where pseudo='" + pseudo + "' and Etat='debloquer' ";
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    resultat = "Mot de Passe Modifé";
                }
            }
            catch (Exception ex)
            {
                resultat = "modification echoué" + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return resultat;

        }

        public static string retracerUtilisateur(Tranzaction trans)
        {
            string query = "insert into Tracabilite (CodeOperation,Pseudo,Operation,DateHeureOp) values('" + trans.getCodeTrans() + "','" + trans.getPseudo() + "','" + trans.getOperation() + "','" + System.DateTime.Now.ToString() + "')";

            con = new SqlConnection(chaine_connection);
            int verif = 0;
            string message = "";
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                verif = cmd.ExecuteNonQuery();
                if (verif != 0)
                {
                    message = "succes";
                }
            }
            catch (SqlException ex)
            {
                message = "insertion echouee" + ex.Message;
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
          
        public static string Deconnexion(string pseudo)
        {
            string resultat = "";
            string req = "update Utilisateurs set Statut='offline' where pseudo='" + pseudo + "' and Etat='debloquer' ";
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    resultat = "Mot de Passe Modifé";
                }
            }
            catch (Exception ex)
            {
                resultat = "modification echoué" + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return resultat;

        }
        public static  DataSet ListerUtilisateur()
        {


            string req = "select * from Utilisateurs ";
            SqlCommandBuilder com = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            con = new SqlConnection(chaine_connection);
            try
            {
                con.Open();
                dataset = new DataSet();
                sda = new SqlDataAdapter(req, con);
                sda.Fill(dataset, "Utilisateurs");
                com = new SqlCommandBuilder(sda);
            }
            catch (Exception ex)
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

            return dataset;
        }
        public static DataSet ListerUtilisateur(string critere)
        {


            string req = "select * from Utilisateurs where Code like'%" + critere + "%' or Nom like'%" + critere + "%' or Prenom like'%" + critere + "%' or Pseudo like'%" + critere + "%'";
            SqlCommandBuilder com = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            con = new SqlConnection(chaine_connection);
            try
            {
                con.Open();
                dataset = new DataSet();
                sda = new SqlDataAdapter(req, con);
                sda.Fill(dataset, "Utilisateurs");
                com = new SqlCommandBuilder(sda);
            }
            catch (Exception ex)
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

            return dataset;
        }
        public static string ModifierUtilisateur(string pseudo, string nom,string prenom,string fonction )
        {
            string resultat = "";
            string req = "update Utilisateurs set nom='" + nom + "',prenom='" + prenom + "',Fonction='" +fonction + "' where pseudo='" + pseudo + "' and Etat='debloquer' ";
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    resultat = "Utilisateur modifié";
                    }
               
                }
            catch (Exception ex)
            {
                resultat  = "modification  echouee" + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return resultat;
        }
        public static string ModifierMotdePasse(string pseudo, string motdepasse)
        {
          string resultat = "";
            string req = "update Utilisateurs set MotdePasse='" + motdepasse + "' where pseudo='" + pseudo + "' and Etat='debloquer' ";
            try
            {
                con = new SqlConnection(chaine_connection);
                con.Open();
                cmd = new SqlCommand(req, con);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    resultat = "Mot de Passe Modifé";
                }               
            }
            catch (Exception ex)
            {
                resultat = "modification echoué" + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return resultat;
            
        }

    }
}
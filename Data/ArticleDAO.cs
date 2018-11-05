using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Model;

namespace Data
{
    public class ArticleDAO
    {

        public static List<ArticlePOJO> getAll()
        {
            try
            {
                var list = new List<ArticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM articles;");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    list.Add(DataRowAObjeto(dr));

                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static ArticlePOJO getOneById(int idArticle)
        {
            try
            {
                var list = new List<ArticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM articles WHERE idArticle = @P0;");
                cmd.Parameters.AddWithValue("@P0", idArticle);

                DataTable dt = con.ejecutarConsulta(cmd);

                if (dt.Rows.Count != 1)
                    return null;

                return DataRowAObjeto(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static int getTotalQuantity(int idArticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(s.quantity) as totalQuantity FROM " +
                    "articles a JOIN subarticles s USING(idArticle) WHERE idArticle = @P0;");
                cmd.Parameters.AddWithValue("@P0", idArticle);

                DataTable dt = con.ejecutarConsulta(cmd);

                if (dt.Rows.Count != 1)
                    return 0;

                return int.Parse(dt.Rows[0]["totalQuantity"].ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static int insertArticle(ArticlePOJO newArticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO articles VALUES(@P0,@P1,@P2,@P3);");

                cmd.Parameters.AddWithValue("@P0", newArticle.IdArticle);
                cmd.Parameters.AddWithValue("@P1", newArticle.Name);
                cmd.Parameters.AddWithValue("@P2", newArticle.Description);
                cmd.Parameters.AddWithValue("@P3", newArticle.Image);

                return con.ejecutarSentencia(cmd, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static void updateArticle(ArticlePOJO newArticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE articles SET idArticle = @P0, name = @P1, " +
                    "description = @P2, image = @P3 WHERE idArticle = @P0;");
                cmd.Parameters.AddWithValue("@P0", newArticle.IdArticle);
                cmd.Parameters.AddWithValue("@P1", newArticle.Name);
                cmd.Parameters.AddWithValue("@P2", newArticle.Description);
                cmd.Parameters.AddWithValue("@P3", newArticle.Image);

                con.ejecutarSentencia(cmd, false);
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static int deleteById(int idArticle)
        {
            try
            {

                SubarticleDAO.deleteByIdArticle(idArticle);

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM articles WHERE idArticle = @P0");
                cmd.Parameters.AddWithValue("@P0", idArticle);
                con.ejecutarSentencia(cmd, true);
                Conexion.conexion.Close();
                return con.ejecutarSentencia(cmd, true);
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static ArticlePOJO DataRowAObjeto(DataRow dr)
        {
            return new ArticlePOJO(
                int.Parse(dr["idArticle"].ToString()),
                dr["name"].ToString(),
                dr["description"].ToString(),
                dr["image"].ToString()
            );

        }

    }
}

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
    /// <summary>
    /// Objeto de acceso a datos del artículo.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del artículo.
    /// </remarks>
    public class ArticleDAO
    {
        /// <summary>
        /// Obtiene a todos los artículos con sus atributos almacenados en la base de datos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con los artículos obtenidos a través de la consulta.
        /// </returns>
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

        /// <summary>
        /// Busca y obtiene al artículo que coincida con la clave ingresada
        /// como parámetro.
        /// </summary>
        /// <param name="idArticle"></param>
        /// Clave utilizada para identificar al artículo.
        /// <returns>
        /// Retorna el artículo si es encontrado, de otro modo retorna null.
        /// </returns>
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

        /// <summary>
        /// Obtiene la cantidad de subartículos con los que cuenta el artículo que coincida con la clave ingresada
        /// como parámetro.
        /// </summary>
        /// <param name="idArticle"></param>
        /// Clave utilizada para identificar al artículo.
        /// <returns>
        /// Retorna la cantidad de subartículos si es que existen, de otro modo retorna null.
        /// </returns>
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

        /// <summary>
        /// Inserta un nuevo artículo en la base de datos.
        /// </summary>
        /// <param name="newArticle"></param>
        /// Contiene los datos que conforman un artículo.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
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

        /// <summary>
        /// Actualiza los datos del artículo ingresado como parámetro.
        /// </summary>
        /// <param name="newArticle"></param>
        /// Contiene los datos que sobrescribirán a los anteriores.
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

        /// <summary>
        /// Elimina de la base de datos el artículo que coincida con la clave ingresada como parámetro.
        /// </summary>
        /// <param name="idArticle"></param>
        /// Clave utilizada para identificar al artículo.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
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

        /// <summary>
        /// Construye un artículo con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al artículo.
        /// <returns>
        /// Retorna el artículo creado.
        /// </returns>
        public static ArticlePOJO DataRowAObjeto(DataRow dr)
        {
            return new ArticlePOJO(
                int.Parse(dr["idArticle"].ToString()),
                dr["name"].ToString(),
                dr["description"].ToString(),
                dr["image"].ToString()
            );

        }

        public static ArticlePOJO getOneById(String nameArticle)
        {
            try
            {
                var list = new List<ArticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM articles WHERE name = @P0;");
                cmd.Parameters.AddWithValue("@P0", nameArticle);

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


    }
}

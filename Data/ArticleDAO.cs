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
    class ArticleDAO
    {

        public static List<ArticlePOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<ArticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM alumno");

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
        /// Construye un alumno con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al alumno.
        /// <returns>
        /// Retorna el alumno creado.
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

    }
}

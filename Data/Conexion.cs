using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public class Conexion
    {
        public static MySqlConnection conexion = null;

        /// <summary>
        /// Crea la conexión hacia la base de datos.
        /// </summary>
        /// <returns>
        /// Retorna true si la conexión fue exitosa, de otro modo retorna false.
        /// </returns>
        static public bool Conectar()
        {
            //String parametrosConexion = "Server=127.0.0.1;Database=SCIET;Uid=root;Pwd=root;Port=3306;SslMode=None;";
            String parametrosConexion = "Server=127.0.0.1;Database=SCIET;Uid=root;Pwd=root;Port=3306;";
            /*String parametrosConexion = 
                String.Format("Server={0};Database=SCIET;Uid={1};Pwd={2};Port={3}",
                                Common.Properties.Settings.Default.DB_HOST,
                                Common.Properties.Settings.Default.DB_USER,
                                Common.Properties.Settings.Default.DB_PASS,
                                Common.Properties.Settings.Default.DB_PORT);*/

            conexion = new MySqlConnection(parametrosConexion);
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// Ejecuta una consulta en la base de datos.
        /// </summary>
        /// <param name="com"></param>
        /// Contiene la consulta a ingresar en la base de datos.
        /// <returns>
        /// Retorna todas las columnas y filas obtenidas por la consulta.
        /// </returns>
        /// XS,S,M,L,XL,XXL,XXXL
        public DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            try
            {
                if (Conectar())
                {
                    consulta.Connection = conexion;
                    MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter(consulta);
                    DataTable resultado = new DataTable();
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }

        /// <summary>
        /// Ejecuta una sentencia en la base de datos.
        /// </summary>
        /// <param name="objComando"></param>
        /// Contiene la sentencia a ingresar en la base de datos.
        /// <param name="esInsert"></param>
        /// <returns>
        /// Retorna 0 si la sentencia fue ingresada correctamente, 
        /// de otro modo retorna 1.
        /// </returns>
        public int ejecutarSentencia(MySqlCommand objComando, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    objComando.Connection = conexion;
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter(objComando);
                    if (esInsert)
                    {
                        resultado = int.Parse(objComando.ExecuteScalar().ToString());
                    }
                    else
                    {
                        objComando.ExecuteNonQuery();
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
    }
}

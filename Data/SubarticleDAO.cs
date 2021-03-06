﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Model;
using Data;

namespace Data
{
    /// <summary>
    /// Objeto de acceso a datos del subartículo.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del subartículo.
    /// </remarks>
    public class SubarticleDAO
    {
        /// <summary>
        /// Busca y obtiene a todos los subartículos del artículo que coincida con la clave ingresada 
        /// como parámetro.
        /// </summary>
        /// <param name="idArticle"></param>
        /// Clave utilizada para identificar al artículo.
        /// <returns>
        /// Retorna una lista de subartículos si son encontrados, de otro modo retorna null.
        /// </returns>
        public static List<SubarticlePOJO> getAllById(int idArticle)
        {
            try
            {
                var list = new List<SubarticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subarticles WHERE idArticle = @P0;");
                cmd.Parameters.AddWithValue("@P0", idArticle);

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
        /// Busca y obtiene al subartículo que coincida con la clave ingresada
        /// como parámetro.
        /// </summary>
        /// <param name="idSubarticle"></param>
        /// Clave utilizada para identificar al subartículo.
        /// <returns>
        /// Retorna el subartículo si es encontrado, de otro modo retorna null.
        /// </returns>
        public static SubarticlePOJO getOneById(string idSubarticle)
        {
            try
            {
                var list = new List<ArticlePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subarticles WHERE idSubarticle = @P0;");
                cmd.Parameters.AddWithValue("@P0", idSubarticle);

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
        /// Inserta un nuevo subartículo en la base de datos.
        /// </summary>
        /// <param name="newSubarticle"></param>
        /// Contiene los datos que conforman un subartículo.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int insertSubarticle(SubarticlePOJO newSubarticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO subarticles VALUES (@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9);");

                cmd.Parameters.AddWithValue("@P0", newSubarticle.IdSubarticle);
                cmd.Parameters.AddWithValue("@P1", newSubarticle.Size);
                cmd.Parameters.AddWithValue("@P2", newSubarticle.Color);
                cmd.Parameters.AddWithValue("@P3", newSubarticle.Cost);
                cmd.Parameters.AddWithValue("@P4", newSubarticle.Price1);
                cmd.Parameters.AddWithValue("@P5", newSubarticle.Price2);
                cmd.Parameters.AddWithValue("@P6", newSubarticle.Price3);
                cmd.Parameters.AddWithValue("@P7", newSubarticle.Price4);
                cmd.Parameters.AddWithValue("@P8", newSubarticle.Quantity);
                cmd.Parameters.AddWithValue("@P9", newSubarticle.IdArticle);

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
        /// Actualiza los datos del subartículo ingresado como parámetro.
        /// </summary>
        /// <param name="newSubarticle"></param>
        /// Contiene los datos que sobrescribirán a los anteriores.
        public static void updateSubarticle(SubarticlePOJO newSubarticle, string idSubarticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE subarticles SET idSubarticle = @P0, size = @P1, " +
                    "color = @P2, cost = @P3, price1 = @P4, price2 = @P5, price3 = @P6, price4 = @P7, " +
                    "quantity = @P8, idArticle = @P9 WHERE idSubarticle = @P10;");
                cmd.Parameters.AddWithValue("@P0", newSubarticle.IdSubarticle);
                cmd.Parameters.AddWithValue("@P1", newSubarticle.Size);
                cmd.Parameters.AddWithValue("@P2", newSubarticle.Color);
                cmd.Parameters.AddWithValue("@P3", newSubarticle.Cost);
                cmd.Parameters.AddWithValue("@P4", newSubarticle.Price1);
                cmd.Parameters.AddWithValue("@P5", newSubarticle.Price2);
                cmd.Parameters.AddWithValue("@P6", newSubarticle.Price3);
                cmd.Parameters.AddWithValue("@P7", newSubarticle.Price4);
                cmd.Parameters.AddWithValue("@P8", newSubarticle.Quantity);
                cmd.Parameters.AddWithValue("@P9", newSubarticle.IdArticle);
                cmd.Parameters.AddWithValue("@P10", idSubarticle);

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
        /// Elimina de la base de datos el subartículo que coincida con la clave ingresada como parámetro.
        /// </summary>
        /// <param name="idSubarticle"></param>
        /// Clave utilizada para identificar al subartículo.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int deleteByIdSubarticle(string idSubarticle)
        {
            try
            {

                List<BatchPOJO> batchesList = BatchDAO.getAllById(idSubarticle);
                if (batchesList.Count > 0)
                {
                    BatchDAO.deleteAllById(idSubarticle, batchesList);
                }

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM subarticles WHERE idSubarticle = @P0");
                cmd.Parameters.AddWithValue("@P0", idSubarticle);
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
        /// Elimina de la base de datos todos los subartículos del artículo que coincida con la clave ingresada 
        /// como parámetro.
        /// </summary>
        /// <param name="idArticle"></param>
        /// Clave utilizada para identificar al artículo.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int deleteByIdArticle(int idArticle)
        {
            try
            {

                List<SubarticlePOJO> subarticlesList = getAllById(idArticle);
                List<BatchPOJO> batchesList;
                for (int i = 0; i < subarticlesList.Count; i++)
                {
                    batchesList = BatchDAO.getAllById(subarticlesList[i].IdSubarticle);
                    if (batchesList.Count > 0)
                    {
                        BatchDAO.deleteAllById(subarticlesList[i].IdSubarticle, batchesList);
                    }
                }

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM subarticles WHERE idArticle = @P0");
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
        /// Construye un subartículo con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al subartículo.
        /// <returns>
        /// Retorna el subartículo creado.
        /// </returns>
        public static SubarticlePOJO DataRowAObjeto(DataRow dr)
        {
            return new SubarticlePOJO(
                dr["idSubarticle"].ToString(),
                dr["size"].ToString(),
                dr["color"].ToString(),
                double.Parse(dr["cost"].ToString()),
                double.Parse(dr["price1"].ToString()),
                double.Parse(dr["price2"].ToString()),
                double.Parse(dr["price3"].ToString()),
                double.Parse(dr["price4"].ToString()),
                int.Parse(dr["quantity"].ToString()),
                int.Parse(dr["idArticle"].ToString())
            );

        }

    }
}

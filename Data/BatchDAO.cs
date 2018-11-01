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
    public class BatchDAO
    {

        public static List<BatchPOJO> getAllById(int idSubarticle)
        {
            try
            {
                var list = new List<BatchPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT b.* FROM batches b JOIN detailbatch d " +
                    "USING(idBatch) WHERE d.idSubarticles = @P0;");
                cmd.Parameters.AddWithValue("@P0", idSubarticle);

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

        public static int insertBatch(BatchPOJO newBatch)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO batches VALUES (@P0,@P1,@P2,@P3);");

                cmd.Parameters.AddWithValue("@P0", newBatch.IdBatch);
                cmd.Parameters.AddWithValue("@P1", newBatch.Date);
                cmd.Parameters.AddWithValue("@P2", newBatch.Reason);
                cmd.Parameters.AddWithValue("@P3", newBatch.Quantity);

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

        public static int insertDetailBatch(int idBatch, int idSubarticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO detailbatch VALUES(null,@P0,@P1);");

                cmd.Parameters.AddWithValue("@P0", idBatch);
                cmd.Parameters.AddWithValue("@P1", idSubarticle);

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

        public static int deleteAllById(int idSubarticle, List<BatchPOJO> batches)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM detailbatch WHERE idSubarticle = @P0");
                cmd.Parameters.AddWithValue("@P0", idSubarticle);
                con.ejecutarSentencia(cmd, true);
                Conexion.conexion.Close();

                for (int i = 0; i < batches.Count; i++)
                {
                    cmd = new MySqlCommand("DELETE FROM batches WHERE idBatch = @P1");
                    cmd.Parameters.AddWithValue("@P1", batches[i].IdBatch);
                    con.ejecutarSentencia(cmd, true);
                }

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

        public static BatchPOJO DataRowAObjeto(DataRow dr)
        {
            return new BatchPOJO(
                int.Parse(dr["idBatch"].ToString()),
                DateTime.Parse(dr["date"].ToString()),
                dr["reason"].ToString(),
                int.Parse(dr["quantity"].ToString())
            );

        }

    }
}

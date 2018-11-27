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
    public class SaleDAO
    {

        public SaleDAO() { }

        public static List<SalePOJO> getAll()
        {
            try
            {
                var list = new List<SalePOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.idsale, s.date,s.tipoVenta, s.total, s.Estatus from sales s;");

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

        public static List<SalePOJO> getAllDate(String incio, String fin)
        {
            try
            {
                var list = new List<SalePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from sales where date >= '"+incio+"' and date <= '"+fin+"';");
                Console.WriteLine(cmd.CommandText);

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

        public static SalePOJO getSale(int id)
        {
            try
            {
                SalePOJO sale = null;

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.idsale, s.date,s.tipoVenta, s.total, s.Estatus from sales s where s.idsale = "+ id +";");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    sale = DataRowAObjeto(dr);

                return sale;
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

        public static List<Model.SaleArticleDetail> getArticleList(int id)
        {
            try
            {
                var list = new List<SaleArticleDetail>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.name, s.quantity, s.price, s.total from detailsale d join salearticle s where d.idsalearticle = idsart and d.idSale = "+ id +";");
                DataTable dt = con.ejecutarConsulta(cmd);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(DataRowAObjeto2(dr));
                }
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


        public static SalePOJO DataRowAObjeto(DataRow dr)
        {
            return new SalePOJO(
                int.Parse(dr["idsale"].ToString()),
                dr["date"].ToString(),
                dr["tipoVenta"].ToString(),
                double.Parse(dr["total"].ToString()),
                dr["Estatus"].ToString()
            );

        }

        public static SaleArticleDetail DataRowAObjeto2(DataRow dr)
        {
            return new SaleArticleDetail(
                dr[0].ToString(),
                int.Parse(dr[1].ToString()),
                Double.Parse(dr[2].ToString()),
                Double.Parse(dr[3].ToString())
            );

        }

        public static int insertSale(String fecha, double total, string tipoVenta, string estatus, double pagoDado)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("insert into sales values(null, @P0, @P1, @P2, @P3, @P4); Select last_insert_id();");

                cmd.Parameters.AddWithValue("@P0", fecha);
                cmd.Parameters.AddWithValue("@P1", total);
                cmd.Parameters.AddWithValue("@P2", tipoVenta);
                cmd.Parameters.AddWithValue("@P3", estatus);
                cmd.Parameters.AddWithValue("@P4", pagoDado);

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

        public static int insertSaleArticles(string name, int quantity,double price, double total)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("insert into saleArticle values(null, @P0, @P1, @P2,@P3); Select last_insert_id();");

                cmd.Parameters.AddWithValue("@P0", name);
                cmd.Parameters.AddWithValue("@P1", quantity);
                cmd.Parameters.AddWithValue("@P2", price);
                cmd.Parameters.AddWithValue("@P3", total);

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

        public static int insertDetail(int idSale, int saleArticle)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("insert into detailsale values(null, @P0, @P1); Select last_insert_id();");

                cmd.Parameters.AddWithValue("@P0", idSale);
                cmd.Parameters.AddWithValue("@P1", saleArticle);

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

        public static double seDebe(int id)
        {
            try
            {
                double valor = 0;
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select (total - (pagodado + if((select sum(payment) from payments where idsale = "+ id +") > 0, (select sum(payment) from payments where idsale = "+ id +"), 0))) from sales where idsale =" + id + ";");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    valor = Double.Parse(dr[0].ToString());
                return valor;
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

        public static List<payments> getPayments(int id)
        {
            try
            {
                var list = new List<payments>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from payments where idsale = "+id+";");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    list.Add(DataRowAObjeto3(dr));

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

        public static payments DataRowAObjeto3(DataRow dr)
        {
            return new payments(
                Double.Parse(dr[2].ToString()),
                dr[3].ToString()
            );

        }

        public static double totalAbono(int id)
        {
            try
            {
                double valor = 0;
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select (if((select sum(payment) from payments where idsale = " + id + ") > 0, (select sum(payment) from payments where idsale = " + id + "), 0) + pagodado) from sales where idsale = " + id + ";");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    valor = Double.Parse(dr[0].ToString());
                return valor;
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

        public static int insertPayment(int idSale, double payment, String date)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("insert into payments values(null, @P1, @P2,@P3); Select last_insert_id();");

                cmd.Parameters.AddWithValue("@P1", idSale);
                cmd.Parameters.AddWithValue("@P2", payment);
                cmd.Parameters.AddWithValue("@P3", date);

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

        public static void pagado(int id)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE sales SET Estatus = \"Pagado\" WHERE idSale = "+id+";");
            
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

    }
}

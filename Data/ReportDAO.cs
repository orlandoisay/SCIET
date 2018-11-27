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
    public class ReportDAO
    {
        public static List<ReportPOJO> getAllReportSales(string init, string finish)
        {
            try
            {
                var list = new List<ReportPOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.idSale, s.date, c.name, s.total from sales s join customers c " +
                                                       "where s.idSale = c.idSale " +
                                                       "And s.date >=  @f1 " +
                                                       "And s.date <= @f2;");
                cmd.Parameters.AddWithValue("@f1", init);
                cmd.Parameters.AddWithValue("@f2", finish);

                DataTable dt = con.ejecutarConsulta(cmd);
                ReportPOJO report = null;
                foreach (DataRow dr in dt.Rows)
                {
                    report = new ReportPOJO(
                        int.Parse(dr["idSale"].ToString()),
                        dr["date"].ToString(),
                        dr["name"].ToString(),
                        Double.Parse(dr["total"].ToString())
                        );
                    list.Add(report);
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

        public static List<ReportPOJO> getAllReportInOut(string init, string finish)
        {
            try
            {
                var list = new List<ReportPOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from batches " +
                                                       "where date >=  @f1 " +
                                                       "And date <= @f2;");
                cmd.Parameters.AddWithValue("@f1", init);
                cmd.Parameters.AddWithValue("@f2", finish);

                DataTable dt = con.ejecutarConsulta(cmd);
                ReportPOJO report = null;
                foreach (DataRow dr in dt.Rows)
                {
                    report = new ReportPOJO(
                        int.Parse(dr["idBatch"].ToString()),
                        dr["date"].ToString(),
                        dr["reason"].ToString(),
                        int.Parse(dr["quantity"].ToString())
                        );
                    list.Add(report);
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

        public static List<ReportPOJO> getAllReportCost(string init, string finish)
        {
            try
            {
                var list = new List<ReportPOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(/*"select d.idSale, d.date, " +
                    "e.Name, sum(( select sum((select sum(s.cost) " +
                    "from subarticles s where s.idArticle = a.idArticle)) " +
                    "from articles a where a.idArticle = c.idSaleArticle)) as cost " +
                    "from detailsale c join sales d join customers e " +
                    "where c.idSale = d.idSale and d.idSale = e.idSale " +
                    "and d.date >=  @f1 and d.date <=  @f2;"*/
                    "select s.idSale, s.date, c.name, " +
                    "s.total from sales s join customers c " +
                    "where s.idSale = c.idSale " +
                    "And s.date >=  @f1 " +
                    "And s.date <= @f2;"
                    );
                cmd.Parameters.AddWithValue("@f1", init);
                cmd.Parameters.AddWithValue("@f2", finish);

                DataTable dt = con.ejecutarConsulta(cmd);
                ReportPOJO report = null;
                foreach (DataRow dr in dt.Rows)
                {
                    report = new ReportPOJO(
                        int.Parse(dr["idSale"].ToString()),
                        dr["date"].ToString(),
                        dr["name"].ToString(),
                        Double.Parse(dr["total"].ToString())
                        );
                    list.Add(report);
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

        public static List<ReportPOJO> getAllReportInventory()
        {
            try
            {
                var list = new List<ReportPOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.idSubarticle, a.name, s.size, s.color, s.cost, s.price1, s.price2, s.price3, s.price4, s.quantity from subarticles s join articles a where s.idArticle =  a.idArticle;");

                DataTable dt = con.ejecutarConsulta(cmd);
                ReportPOJO report = null;
                foreach (DataRow dr in dt.Rows)
                {
                    report = new ReportPOJO(
                       dr["idSubarticle"].ToString(),
                       dr["name"].ToString(),
                       dr["color"].ToString(),
                       dr["size"].ToString(),
                       double.Parse(dr["price1"].ToString()),
                       double.Parse(dr["price2"].ToString()),
                       double.Parse(dr["price3"].ToString()),
                       double.Parse(dr["price4"].ToString()),
                       double.Parse(dr["cost"].ToString()),
                       int.Parse(dr["quantity"].ToString())
                        );
                    list.Add(report);
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
    }
}

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
        public static List<ReportPOJO> getAllReportSales(DateTime init, DateTime finish)
        {
            try
            {
                var list = new List<ReportPOJO>();
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select s.idSale, s.date, c.name, s.total from sales s join customers c " +
                                                       "where s.idSale = c.idSale " +
                                                       "And s.date >=  '@f1'" +
                                                       "And s.date <= '@f2';");
                cmd.Parameters.AddWithValue("@f1", init);
                cmd.Parameters.AddWithValue("@f2", finish);

                DataTable dt = con.ejecutarConsulta(cmd);
                ReportPOJO report = null;
                foreach (DataRow dr in dt.Rows)
                {
                    report = new ReportPOJO(
                        int.Parse(dr["idSale"].ToString()),
                        DateTime.Parse(dr["date"].ToString()),
                        dr["name"].ToString(),
                        Double.Parse(dr["total"].ToString())
                        );
                }
                list.Add(report);

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

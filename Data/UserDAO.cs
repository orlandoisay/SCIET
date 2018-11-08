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
   public class UserDAO
    {
        public Boolean Exist(UserPOJO user)
        {
            try
            {
                String command = "SELECT * FROM USERS WHERE nickname = @P0 and password = @P1 LIMIT 1";
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(command);

                cmd.Parameters.AddWithValue("@P0", user.Nickname);
                cmd.Parameters.AddWithValue("@P1", user.Password);

                DataTable dtUsers = con.ejecutarConsulta(cmd);

                if (dtUsers != null && dtUsers.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conexion.conexion != null)
                {
                    Conexion.conexion.Close();
                }
            }
        }
    }
}

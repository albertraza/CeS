using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//Para acceder al string de conexion;
using Cely_Sistema.Properties;
using System.Configuration;

namespace Cely_Sistema
{
    public class DBcomun
    {
        public static string StringConexion()
        {
            return Settings.Default.CelyDBConnectionString;
        }
        public static SqlConnection ObetenerConexion()
        {
            SqlConnection conexion = new SqlConnection(StringConexion());
            conexion.Open();

            return conexion;
        }
    }
}

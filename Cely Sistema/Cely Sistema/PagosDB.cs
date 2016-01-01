using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class PagosDB
    {
        public static double ObtenerPagoMensual()
        {
            double P = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select Pago_Mensual from CantidadPago where ID = 1", conexion);
                P = Convert.ToDouble(comando.ExecuteScalar());
                conexion.Close();
            }
            return P;
        }
        public static double ObtenerPagoSemanal()
        {
            double P = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select Pago_Semanal from CantidadPago where ID = 1", conexion);
                P = Convert.ToDouble(comando.ExecuteScalar());
                conexion.Close();
            }
            return P;
        }
    }
}

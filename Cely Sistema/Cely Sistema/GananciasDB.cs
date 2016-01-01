using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class GananciasDB
    {
        public static int RegistrarGanancias(Ganancias pGanancias)
        {
            int Retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into Ganancias (Fecha_Ganancias, Ingresos) values ('{0}', {1})", pGanancias.Fecha_Ganancia, pGanancias.Ganancia), conexion);
                Retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Retorno;
        }
        public static string ObtenerCantidad(string pfecha)
        {
            string g = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select Ingresos from Ganancias where Fecha_Ganancias = '{0}'", pfecha), conexion);
                    g = comando.ExecuteScalar().ToString();
                    conexion.Close();
                }
                catch (Exception)
                {
                    g = null;
                }
            }
            return g;
        }
        public static string ObtenerID(string pFecha)
        {
            string g = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select ID From Ganancias where Fecha_Ganancias = '{0}'", pFecha), conexion);
                    g = comando.ExecuteScalar().ToString();
                    conexion.Close();
                }
                catch (Exception)
                {
                    g = null;
                }
            }
            return g;
        }
        public static int ActualizarGanancias(Ganancias pGanancias)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Ingresos = {0} where ID = {1}", pGanancias.Ganancia, pGanancias.ID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int ActualizarGananciasF(string pFechaGanancia, Decimal pCantidad)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Ingresos = {0} where Fecha_Ganancias = '{1}'", pCantidad, pFechaGanancia), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerDescuentos(string pFechaGanancias)
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select Total_Descuentos from Ganancias where Fecha_Ganancias = '{0}'", pFechaGanancias), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerTotalIngresos(string pFechaGanancia)
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select Total_Ganancias from Ganancias where Fecha_Ganancias = '{0}'", pFechaGanancia), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static int RegistrarIngresos(double TotalDescuentos, double TotalGanancias, string pFechaGanancias)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Total_Descuentos = {0}, Total_Ganancias = {1} where Fecha_Ganancias = '{2}'", TotalDescuentos, TotalGanancias, pFechaGanancias), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static List<Ganancias> Buscar(string fecha)
        {
            List<Ganancias> list = new List<Ganancias>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Ganancias where Fecha_Ganancias like '{0}%'", fecha), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Ganancias g = new Ganancias();
                    g.Fecha_Ganancia = Convert.ToDateTime(re["Fecha_Ganancias"]).ToString("dd-MM-yyyy");
                    g.Ganancia = Convert.ToDouble(re["Ingresos"]);
                    g.ID = Convert.ToInt32(re["ID"]);
                    list.Add(g);
                }
                con.Close();
            }
            return list;
        }
    }
}
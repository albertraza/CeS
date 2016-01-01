using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class MoraDB
    {
        public static int Registrar(Mora pMora)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Mora (Mora_Mensual, Mora_Semanal) values ({0}, {1})", pMora.Mora_Mensual, pMora.Mora_Semanal), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int Modificar(Mora pMora)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Mora set Mora_Mensual = {0}, Mora_Semanal = {1} where ID = 1 update CantidadPago set Pago_Mensual = {2}, Pago_Semanal = {3} where CantidadPago.ID = 1", pMora.Mora_Mensual, pMora.Mora_Semanal, pMora.Pago_Mensual, pMora.Pago_Semanal), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerMoraMensual()
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select Mora_Mensual from Mora where ID = 1"), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerMoraSemanal()
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Mora_Semanal from Mora where ID = 1"), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static List<Mora> VerMorayPagos()
        {
            List<Mora> List = new List<Mora>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select CantidadPago.Pago_Mensual, Mora.Mora_Mensual, CantidadPago.Pago_Semanal, Mora.Mora_Semanal from CantidadPago, Mora where CantidadPago.ID = Mora.ID"), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Mora pM = new Mora();
                    pM.Pago_Mensual = reader.GetDecimal(0).ToString("f2");
                    pM.Mora_Mensual = reader.GetDecimal(1).ToString("f2");
                    pM.Pago_Semanal = reader.GetDecimal(2).ToString("f2");
                    pM.Mora_Semanal = reader.GetDecimal(3).ToString("f2");
                    List.Add(pM);
                }
                conexion.Close();
            }
            return List;
        }
    }
}

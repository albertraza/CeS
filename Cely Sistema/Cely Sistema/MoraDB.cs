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
        public static List<Mora> VerMorayPagosVIP()
        {
            List<Mora> list = new List<Mora>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from CantidadPagoVIP"), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Mora pM = new Mora();
                    pM.Mora_Mensual = reader["Mora_Mensual"].ToString();
                    pM.Mora_Semanal = reader["Mora_Semanal"].ToString();
                    pM.Pago_Mensual = reader["Pago_VIP"].ToString();
                    pM.Pago_Semanal = reader["Pago_Semanal"].ToString();
                    list.Add(pM);
                }
                con.Close();
            }
            return list;
        }
        public static int ModificarVIP(Mora pM)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update CantidadPagoVIP set Pago_VIP = {0}, Pago_Semanal = {1}, Mora_Semanal = {2}, Mora_Mensual = {3} where ID = 1", pM.Pago_Mensual, pM.Pago_Semanal, pM.Mora_Semanal, pM.Mora_Mensual), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}

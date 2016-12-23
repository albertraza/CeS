using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class PagosDB
    {
        public int matricula { get; set; }
        public double precio { get; set; }
        public double mora { get; set; }

        public PagosDB() { }
        public PagosDB(int ma, double p, double m)
        {
            matricula = ma;
            precio = p;
            mora = m;
        }

        public static int registerPrecio(int matricula, double precio, double mora)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;
                comand.CommandText = "savePrecios";

                comand.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int));
                comand.Parameters["@ID"].Value = matricula;

                comand.Parameters.Add(new SqlParameter("@pago", System.Data.SqlDbType.Money));
                comand.Parameters["@pago"].Value = precio;

                comand.Parameters.Add(new SqlParameter("@Mora", System.Data.SqlDbType.Money));
                comand.Parameters["@Mora"].Value = mora;

                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }

        public static PagosDB getPrecio(int matricula)
        {
            PagosDB pago = new PagosDB();

            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "getPrecio";
                comand.Connection = con;

                comand.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.Int));
                comand.Parameters["@matricula"].Value = matricula;

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pago.matricula = Convert.ToInt32(reader["Matricula"].ToString());
                    pago.precio = Convert.ToDouble(reader["Pago"].ToString());
                    pago.mora = Convert.ToDouble(reader["Mora"].ToString());
                }
                con.Close();
            }
            return pago;
        }

        public static int modifyPrecio(int matricula, double precio, double mora)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "modifyPrecio";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.Int));
                comand.Parameters["@matricula"].Value = matricula;

                comand.Parameters.Add(new SqlParameter("@precio", System.Data.SqlDbType.Money));
                comand.Parameters["@precio"].Value = precio;

                comand.Parameters.Add(new SqlParameter("@mora", System.Data.SqlDbType.Money));
                comand.Parameters["@mora"].Value = mora;

                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }

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

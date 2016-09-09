using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class AsistenciaDB
    {
        public static int RegistrarAsistencia(Asistencia pA, int codigoGrupo)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "registerAsistencia";

                comando.Parameters.Add(new SqlParameter("", System.Data.SqlDbType.Int));
                comando.Parameters["@Matricula"].Value = pA.Matricula;

                comando.Parameters.Add(new SqlParameter("", System.Data.SqlDbType.Int));
                comando.Parameters["@CodigoGrupo"].Value = codigoGrupo;

                comando.Parameters.Add(new SqlParameter("", System.Data.SqlDbType.Date));
                comando.Parameters["@fecha"].Value = pA.Fecha;

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static List<Asistencia> MostrarTodasLasAsistencias()
        {
            List<Asistencia> List = new List<Asistencia>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "listAllAsistencias";

                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Asistencia pA = new Asistencia();

                    pA.Matricula = Convert.ToInt32(reader["Matricula"]);
                    pA.Nombre = reader["NombreE"].ToString();
                    pA.Nivel = reader["Nivel"].ToString();
                    pA.Fecha = DateTime.Parse(Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"));

                    List.Add(pA);
                }
                conexion.Close();
            }
            return List;
        }
        public static List<Asistencia> BuscarAsistencia(string pMatricula, string nivel, string fecha, string nombre)
        {
            List<Asistencia> List = new List<Asistencia>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "searchAsistencia";

                comando.Parameters.Add(new SqlParameter("@Matricula", System.Data.SqlDbType.VarChar));
                comando.Parameters["@Matricula"].Value = pMatricula;

                comando.Parameters.Add(new SqlParameter("@Nivel", System.Data.SqlDbType.VarChar));
                comando.Parameters["@Nivel"].Value = nivel;

                comando.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.VarChar));
                comando.Parameters["@Fecha"].Value = fecha;

                comando.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comando.Parameters["@Nombre"].Value = nombre;

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Asistencia pA = new Asistencia();

                    pA.Matricula = Convert.ToInt32(reader["Matricula"]);
                    pA.Nombre = reader["NombreE"].ToString();
                    pA.Nivel = reader["Nivel"].ToString();
                    pA.Fecha = DateTime.Parse(Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"));

                    List.Add(pA);
                }
                conexion.Close();
            }
            return List;
        }
        public static int ObtenerTotalAsistencia(int pMatricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            int retorno = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "getTotalAsistencia";

                comando.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.Int));
                comando.Parameters["@matricula"].Value = pMatricula;

                comando.Parameters.Add(new SqlParameter("@fechaDesde", System.Data.SqlDbType.Date));
                comando.Parameters["@fechaDesde"].Value = fechaDesde;

                comando.Parameters.Add(new SqlParameter("@fechaHasta", System.Data.SqlDbType.Date));
                comando.Parameters["@fechaHasta"].Value = fechaHasta;


                retorno = Convert.ToInt32(comando.ExecuteScalar());

                conexion.Close();
            }
            return retorno;
        }
    }
}

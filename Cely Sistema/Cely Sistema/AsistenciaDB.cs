using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class AsistenciaDB
    {
        public static int RegistrarAsistencia(Asistencia pA)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into Asistencia (Matricula, Nombre, Asistencia, Mes_Inicio, Ultima_Asistencia) values ('{0}', '{1}', {2}, '{3}', '{4}')", pA.Matricula, pA.Nombre, pA.CAsistencia, pA.Fecha_Inicio, pA.Ultima_Asistencia), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarAsistencia(Asistencia pA)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Asistencia set Nombre = '{0}', Asistencia = {1}, Mes_Inicio = '{2}', Ultima_Asistencia = '{3}' where Matricula = {4}", pA.Nombre, pA.CAsistencia, pA.Fecha_Inicio, pA.Ultima_Asistencia, pA.Matricula), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static Asistencia ObtenerDatosAsistencia(int pMatricula)
        {
            Asistencia pA = new Asistencia();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Asistencia where Matricula = {0}", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    pA.ID = reader.GetInt32(0);
                    pA.Matricula = reader.GetInt32(1);
                    pA.Nombre = reader.GetString(2);
                    pA.CAsistencia = reader.GetInt32(3);
                    pA.Fecha_Inicio = reader.GetDateTime(4).ToString();
                    pA.Ultima_Asistencia = reader.GetDateTime(5).ToString();
                }
                conexion.Close();
            }
            return pA;
        }
        public static List<Asistencia> MostrarTodasLasAsistencias()
        {
            List<Asistencia> List = new List<Asistencia>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from Asistencia"), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Asistencia pA = new Asistencia();
                    pA.ID = reader.GetInt32(0);
                    pA.Matricula = reader.GetInt32(1);
                    pA.Nombre = reader.GetString(2);
                    pA.CAsistencia = reader.GetInt32(3);
                    pA.Fecha_Inicio = reader.GetDateTime(4).ToString();
                    pA.Ultima_Asistencia = reader.GetDateTime(5).ToString();

                    List.Add(pA);
                }
                conexion.Close();
            }
            return List;
        }
        public static List<Asistencia> BuscarAsistencia(int pMatricula)
        {
            List<Asistencia> List = new List<Asistencia>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from Asistencia Where Matricula = {0}", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Asistencia pA = new Asistencia();
                    pA.ID = reader.GetInt32(0);
                    pA.Matricula = reader.GetInt32(1);
                    pA.Nombre = reader.GetString(2);
                    pA.CAsistencia = reader.GetInt32(3);
                    pA.Fecha_Inicio = reader.GetDateTime(4).ToString();
                    pA.Ultima_Asistencia = reader.GetDateTime(5).ToString();
                    List.Add(pA);
                }
                conexion.Close();
            }
            return List;
        }
        public static string ObtenerTotalAsistencia(Int32 pMatricula)
        {
            string retorno = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Asistencia from Asistencia where MAtricula = {0}", pMatricula), conexion);
                retorno = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return retorno;
        }
        public static int ActualizarCAsistencia(int pMatricula, int pCA)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Asistencia set Asistencia = {0} where Matricula = {1}", pCA, pMatricula), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ActualizarUltimaAsistencia(int pMatricula, string pFechaUA)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Asistencia set Ultima_Asistencia = '{0}' where Matricula = {1}", pFechaUA, pMatricula), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}

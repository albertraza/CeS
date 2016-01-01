using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class NotaAsistenciaDB
    {
        public static int RegistrarCalificacion(NotaAsistencia pN)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into NotaAsistencia (Matricula, Nombre, Calificacion_Asistencia, Fecha_Calificada) values ({0}, '{1}', {2}, '{3}')", pN.Matricula, pN.Nombre, pN.Calificacion, pN.Fecha_Calificacion), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int ModificarCalificacion(NotaAsistencia pN)
        {
            int R = -1;
            using(SqlConnection conaxion = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("Update NotaAsistencia set Calificacion_Asistencia = {0}, Fecha_Calificada = '{1}' where ID = {0}", pN.Calificacion, pN.Fecha_Calificacion, pN.ID), conaxion);
                R = comand.ExecuteNonQuery();
                conaxion.Close();
            }
            return R;
        }
        public static int EliminarCalificacion(int pID)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete NotaAsistencia where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static List<NotaAsistencia> TodasLasCalificaciones()
        {
            List<NotaAsistencia> list = new List<NotaAsistencia>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotaAsistencia"), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    NotaAsistencia pN = new NotaAsistencia();
                    pN.ID = reader.GetInt32(0);
                    pN.Matricula = reader.GetInt32(1);
                    pN.Nombre = reader.GetString(2);
                    pN.Calificacion = reader.GetInt32(3);
                    pN.Fecha_Calificacion = reader.GetDateTime(4).ToString();
                    list.Add(pN);
                }
                conexion.Close();
            }
            return list;
        }
        public static List<NotaAsistencia> BuscarCalificaciones(int pMatricula)
        {
            List<NotaAsistencia> list = new List<NotaAsistencia>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotaAsistencia where Matricula = {0}", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    NotaAsistencia pN = new NotaAsistencia();
                    pN.ID = reader.GetInt32(0);
                    pN.Matricula = reader.GetInt32(1);
                    pN.Nombre = reader.GetString(2);
                    pN.Calificacion = reader.GetDecimal(3);
                    pN.Fecha_Calificacion = reader.GetDateTime(4).ToString();
                    list.Add(pN);
                }
                conexion.Close();
            }
            return list;
        }
    }
}

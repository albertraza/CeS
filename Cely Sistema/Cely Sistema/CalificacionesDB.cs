using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class CalificacionesDB
    {
        public static int AgregarCalificacion(Calificaciones pCalificacion)
        {
            int Calificacion = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Calificacones (Codigo_estudiante, Nombre_Estudiante, Primer_Parcial, Segundo_Parcial, Tercer_Parcial, Asistencia, Fecha_Parcial, Codigo_Grupo) values ({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', {7})",
                    pCalificacion.Codigo_Estudiante, pCalificacion.Nombre_Estudiante, pCalificacion.Primer_Parcial, pCalificacion.Sengundo_Parcial, pCalificacion.Tercer_Parcial, pCalificacion.Asistencia, pCalificacion.Fecha_Parcial, pCalificacion.Codigo_Grupo), conexion);

                Calificacion = comando.ExecuteNonQuery();

                conexion.Close();
            }

            return Calificacion;
        }
        public static int ModificarCalificacion(Calificaciones pC)
        {
            int C = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Calificacones set Primer_Parcial = {0}, Segundo_Parcial = {1}, Tercer_Parcial = {2}, Asistencia = {3} where ID = {4}", pC.Primer_Parcial,
                    pC.Sengundo_Parcial, pC.Tercer_Parcial, pC.Asistencia, pC.ID), conexion);

                C = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return C;
        }
        public static List<CalificacionesB> BuscarCalificacionesE(Int32 pID)
        {
            List<CalificacionesB> LC = new List<CalificacionesB>();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from calificacones where Codigo_Estudiante = {0}", pID), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Calificaciones pC = new Calificaciones();
                    CalificacionesB pCB = new CalificacionesB();

                    pC.ID = reader.GetInt32(0);
                    pC.Codigo_Estudiante = reader.GetInt32(1);
                    pC.Nombre_Estudiante = reader.GetString(2);
                    pC.Primer_Parcial = reader.GetInt32(3);
                    pC.Sengundo_Parcial = reader.GetInt32(4);
                    pC.Tercer_Parcial = reader.GetInt32(5);
                    pC.Asistencia = reader.GetInt32(6);
                    pC.Fecha_Parcial = reader.GetDateTime(7).ToString();
                    pC.Codigo_Grupo = reader.GetInt32(8);

                    pCB.ID = pC.ID;
                    pCB.Primer_Parcial = pC.Primer_Parcial;
                    pCB.Segundo_Parcial = pC.Sengundo_Parcial;
                    pCB.Tercer_parcial = pC.Tercer_Parcial;
                    pCB.Asistencia = pC.Asistencia;
                    pCB.Fecha_Parcial = pC.Fecha_Parcial;


                    LC.Add(pCB);
                }
                conexion.Close();
            }
            return LC;
        }
        public static Calificaciones ObtenerCalificaciones(Int32 ID)
        {
            Calificaciones pC = new Calificaciones();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from calificacones where ID = {0}", ID), conexion);

                SqlDataReader reader = comando.ExecuteReader();


                while(reader.Read())
                {
                    pC.ID = reader.GetInt32(0);
                    pC.Codigo_Estudiante = reader.GetInt32(1);
                    pC.Nombre_Estudiante = reader.GetString(2);
                    pC.Primer_Parcial = reader.GetInt32(3);
                    pC.Sengundo_Parcial = reader.GetInt32(4);
                    pC.Tercer_Parcial = reader.GetInt32(5);
                    pC.Asistencia = reader.GetInt32(6);
                    pC.Fecha_Parcial = reader.GetDateTime(7).ToString();
                    pC.Codigo_Grupo = reader.GetInt32(8);
                }
                conexion.Close();
            }
            return pC;
        }
        public static int EliminarCalificacion(Int32 pID)
        {
            int C = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete Calificacones where ID = {0}", pID), conexion);

                C = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return C;
        }
    }
}

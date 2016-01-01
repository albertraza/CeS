using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class HorariosDB
    {
        public static int RegistrarHorario(Horarios pHorario)
        {
            int Horario = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Horarios (Hora, Dias) values ('{0}', '{1}')", pHorario.Hora, pHorario.Dias), conexion);

                Horario = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Horario;
        }
        public static List<Horarios> TodosLosHorarios()
        {
            List<Horarios> List = new List<Horarios>();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Horarios"), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Horarios pH = new Horarios();

                    pH.ID = reader.GetInt32(0);
                    pH.Hora = reader.GetString(1);
                    pH.Dias = reader.GetString(2);

                    List.Add(pH);
                }
                conexion.Close();
            }
            return List;
        }
        public static Horarios ObtenerHorario(Int32 pID)
        {
            Horarios pHorario = new Horarios();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Horarios Where ID = {0}", pID), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    pHorario.ID = reader.GetInt32(0);
                    pHorario.Hora = reader.GetString(1);
                    pHorario.Dias = reader.GetString(2);
                }
                conexion.Close();
            }
            return pHorario;
        }
        public static int ModificaciondeHorario(Horarios pHorario)
        {
            int Horario = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Horarios set Hora = '{0}', Dias = '{1}' where ID = {2}", pHorario.Hora, pHorario.Dias, pHorario.ID), conexion);

                Horario = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return Horario;
        }
        public static int EliminarHorario(Horarios pHorario)
        {
            int Retorno = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete horarios where ID = {0}", pHorario.ID), conexion);

                Retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Retorno;
        }
        public static List<Horarios> BuscarHorarios(string dias, string hora)
        {
            List<Horarios> List = new List<Horarios>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Horarios where Hora like '{0}%' and Dias like '{1}%'", hora, dias), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Horarios pH = new Horarios();

                    pH.ID = reader.GetInt32(0);
                    pH.Hora = reader.GetString(1);
                    pH.Dias = reader.GetString(2);

                    List.Add(pH);
                }
                conexion.Close();
            }
            return List;
        }
    }
}

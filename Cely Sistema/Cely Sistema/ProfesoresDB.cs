using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class ProfesoresDB
    {
        public static int AgregarProfesor(Profesores pProfesor)
        {
            int R = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into Profesores (Nombre, Apellido) values ('{0}', '{1}')", pProfesor.Nombre, pProfesor.Apellido), conexion);

                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static Profesores ObtenerProfesor(Int32 ID)
        {
            Profesores pP = new Profesores();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Profesores where ID = {0}", ID), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    pP.ID = reader.GetInt32(0);
                    pP.Nombre = reader.GetString(1);
                    pP.Apellido = reader.GetString(2);
                }
                conexion.Close();
            }
            return pP;
        }
        public static List<Profesores> TodosLosProfesores()
        {
            List<Profesores> list = new List<Profesores>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from Profesores", conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Profesores pP = new Profesores();

                    pP.ID = reader.GetInt32(0);
                    pP.Nombre = reader.GetString(1);
                    pP.Apellido = reader.GetString(2);

                    list.Add(pP);
                }
                conexion.Close();
            }
            return list;
        }
        public static List<Profesores> BuscarProfesores(string nombre, string apellido)
        {
            List<Profesores> list = new List<Profesores>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from Profesores where Nombre like '{0}%' or Apellido like '{1}%'", nombre, apellido), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Profesores pP = new Profesores();

                    pP.ID = reader.GetInt32(0);
                    pP.Nombre = reader.GetString(1);
                    pP.Apellido = reader.GetString(2);

                    list.Add(pP);
                }
                conexion.Close();
            }
            return list;
        }
        public static int ModificarProfesor(Profesores pProfesores)
        {
            int Retorno = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Profesores set Nombre = '{0}', Apellido = '{1}' where ID = {2}", pProfesores.Nombre, pProfesores.Apellido, pProfesores.ID), conexion);
                Retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Retorno;
        }
        public static int EliminarProfesor(Int32 pID)
        {
            int R = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete Profesores where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
    }
}

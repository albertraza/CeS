using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class GruposDB
    {
        public static int AgregarGrupo(Grupos pGrupos)
        {
            int Grupo = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Grupos (Nivel, Profesor, Aula, Codigo_Horario, Fecha_Inicio, Total_Inscritos) values ('{0}', '{1}', '{2}', {3}, '{4}', {5})", pGrupos.Nivel, pGrupos.Profesor, pGrupos.Aula, pGrupos.Horario, pGrupos.Fecha_Inicio, pGrupos.Total_Inscritos), conexion);

                Grupo = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Grupo;
        }
        public static int ModificarGrupo(Grupos pGrupos)
        {
            int Grupos = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Grupos Set Nivel = '{0}', Profesor = '{1}', Aula = '{2}', Codigo_Horario = {3}, Fecha_Inicio = '{4}' where ID = {5}", pGrupos.Nivel, pGrupos.Profesor, pGrupos.Aula, pGrupos.Horario, pGrupos.Fecha_Inicio, pGrupos.ID), conexion);

                Grupos = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return Grupos;
        }
        public static Grupos ObtenerGrupos(Int32 pID)
        {
            Grupos pG = new Grupos();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Grupos.ID as CodigoGrupo, Nivel, Profesor, Aula, Fecha_Inicio, Total_Inscritos, Horarios.ID as Horario from Grupos inner join Horarios on Horarios.ID = Grupos.Codigo_Horario Where Grupos.ID = {0}", pID), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    pG.ID = int.Parse(reader["CodigoGrupo"].ToString());
                    pG.Nivel = reader["Nivel"].ToString();
                    pG.Profesor = reader["Profesor"].ToString();
                    pG.Aula = reader["Aula"].ToString();
                    pG.Horario = reader["Horario"].ToString();
                    pG.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]).ToString("dd-MM-yyyy");
                    pG.Total_Inscritos = int.Parse(reader["Total_Inscritos"].ToString());
                }
                conexion.Close();
            }
            return pG;
        }
        public static List<Grupos> TodosLosGrupos()
        {
            List<Grupos> List = new List<Grupos>();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select Grupos.ID as CodigoGrupo, Nivel, Profesor, Aula, Fecha_Inicio, Total_Inscritos, Horarios.Dias + ' ' + Horarios.Hora as Horario from Grupos inner join Horarios on Horarios.ID = Grupos.Codigo_Horario", conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Grupos pG = new Grupos();

                    pG.ID = int.Parse(reader["CodigoGrupo"].ToString());
                    pG.Nivel = reader["Nivel"].ToString();
                    pG.Profesor = reader["Profesor"].ToString();
                    pG.Aula = reader["Aula"].ToString();
                    pG.Horario = reader["Horario"].ToString();
                    pG.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]).ToString("dd-MM-yyyy");
                    pG.Total_Inscritos = int.Parse(reader["Total_Inscritos"].ToString());

                    List.Add(pG);
                }
                conexion.Close();
            }
            return List;
        }
        public static List<Grupos> BuscarGrupos(string nivel, string profesor, string fechaInicio, string aula)
        {
            List<Grupos> List = new List<Grupos>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Grupos.ID as CodigoGrupo, Nivel, Profesor, Aula, Fecha_Inicio, Total_Inscritos, Horarios.Dias + ' ' + Horarios.Hora as Horario from Grupos inner join Horarios on Horarios.ID = Grupos.Codigo_Horario where Nivel like '{0}%' and Profesor like '{1}%' and Fecha_Inicio like '{2}%' and Aula like '{3}%'", nivel, profesor, fechaInicio, aula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Grupos pG = new Grupos();
                    pG.ID = int.Parse(reader["CodigoGrupo"].ToString());
                    pG.Nivel = reader["Nivel"].ToString();
                    pG.Profesor = reader["Profesor"].ToString();
                    pG.Aula = reader["Aula"].ToString();
                    pG.Horario = reader["Horario"].ToString();
                    pG.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]).ToString("dd-MM-yyyy");
                    pG.Total_Inscritos = int.Parse(reader["Total_Inscritos"].ToString());
                    List.Add(pG);
                }
                conexion.Close();
            }
            return List;
        }
        public static int EliminarGrupo(Int32 pID)
        {
            int Grupo = 0;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete grupos where ID = {0}", pID), conexion);
                Grupo = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Grupo;
        }
        public static DateTime ObtenerFechaInicio(Int32 pID)
        {
            DateTime fechai = DateTime.Now;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Fecha_Inicio from Grupos where ID = {0}", pID), conexion);
                fechai = Convert.ToDateTime(comando.ExecuteScalar());
                conexion.Close();
            }
            return fechai;
        }
        public static List<Estudiante> EstudiantePorGrupo(Int32 CodigoG)
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Estudiantes where Codigo_Grupo = {0}", CodigoG), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Estudiante pEstuidante = new Estudiante();

                    pEstuidante.ID = reader.GetInt32(0);
                    pEstuidante.Nombre = reader.GetString(1);
                    pEstuidante.Apellido = reader.GetString(2);
                    pEstuidante.Fecha_N = reader.GetDateTime(3).ToString();
                    pEstuidante.Edad = reader.GetString(4);
                    pEstuidante.Telefono = reader.GetString(5);
                    pEstuidante.Fecha_Ins = reader.GetDateTime(6).ToString();
                    pEstuidante.E_Mail = reader.GetString(7);
                    pEstuidante.Direccion = reader.GetString(8);
                    pEstuidante.Sector = reader.GetString(9);
                    pEstuidante.Ocupacion = reader.GetString(10);
                    pEstuidante.N_Academico = reader.GetString(11);
                    pEstuidante.D_Idioma = reader.GetString(12);
                    pEstuidante.NivelA = reader.GetString(13);
                    pEstuidante.Codigo_Grupo = reader.GetInt32(15);
                    pEstuidante.Modo_Pago = reader.GetString(16);
                    pEstuidante.VIP = reader["VIP"].ToString();

                    lista.Add(pEstuidante);

                }
                conexion.Close();

                return lista;
            }
        }
        public static int ActualizarCantidadEstudiantes(Int32 pID, Int32 pCantidad)
        {
            int Retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Grupos Set Total_Inscritos = {0} where ID = {1}", pCantidad, pID), conexion);
                Retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Retorno;
        }
        public static int ObtenerTotalInscritos(Int32 pID)
        {
            int TI = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Total_Inscritos from Grupos where ID = {0}", pID), conexion);
                TI = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            return TI;
        }
        public static List<Grupos> BuscarGruposPorFechaInicio(string pFecha)
        {
            List<Grupos> List = new List<Grupos>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Grupos.ID as CodigoGrupo, Nivel, Profesor, Aula, Fecha_Inicio, Total_Inscritos, Horarios.Dias + ' ' + Horarios.Hora as Horario from Grupos inner join Horarios on Horarios.ID = Grupos.Codigo_Horario where Grupos.Fecha_Inicio = '{0}'", pFecha), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Grupos pG = new Grupos();
                    pG.ID = int.Parse(reader["CodigoGrupo"].ToString());
                    pG.Nivel = reader["Nivel"].ToString();
                    pG.Profesor = reader["Profesor"].ToString();
                    pG.Aula = reader["Aula"].ToString();
                    pG.Horario = reader["Horario"].ToString();
                    pG.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]).ToString("dd-MM-yyyy");
                    pG.Total_Inscritos = int.Parse(reader["Total_Inscritos"].ToString());
                    List.Add(pG);
                }
                conexion.Close();
            }
            return List;
        }
    }
}

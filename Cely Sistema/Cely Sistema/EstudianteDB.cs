using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class EstudianteDB
    {
        public static int RegistrarEstudiante(EstudianteBase E, string Celular, string Respuesta1, string Respuesta2)
        {
            int retorno = 0;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Estudiantes (Nombre, Apellido, FechaN, Edad, Telefono, FechaA, Email, Direccion, Sector, Ocupacion, NivelA, DominioIdiomaIngles, Nivel, Codigo_Grupo, Modo_Pago, Celular, Respuesta1, Respuesta2)"
                    + " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')",
                    E.Nombre, E.Apellido, E.Fecha_N, E.Edad, E.Telefono, E.Fecha_Ins, E.E_Mail, E.Direccion, E.Sector, E.Ocupacion, E.N_Academico, E.D_Idioma, E.NivelA, E.Codigo_Grupo, E.Modo_Pago, Celular, Respuesta1, Respuesta2), conexion);

                retorno = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return retorno;
        }

        public static List<Estudiante> BuscarEstudiante(string nombre, string apellido, string matricula)
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Estudiantes where Nombre like '{0}%' and Apellido like '{1}%' and ID like '{2}%'", nombre, apellido, matricula), conexion);

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
        public static EstudianteBase SeleccionarEstudiante(Int64 pID)
        {
            EstudianteBase pEstudiante = new EstudianteBase();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Estudiantes where ID = {0}", pID), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pEstudiante.ID = reader.GetInt32(0);
                    pEstudiante.Nombre = reader.GetString(1);
                    pEstudiante.Apellido = reader.GetString(2);
                    pEstudiante.Fecha_N = reader.GetDateTime(3).ToString();
                    pEstudiante.Edad = reader.GetString(4);
                    pEstudiante.Telefono = reader.GetString(5);
                    pEstudiante.Fecha_Ins = reader.GetDateTime(6).ToString();
                    pEstudiante.E_Mail = reader.GetString(7);
                    pEstudiante.Direccion = reader.GetString(8);
                    pEstudiante.Sector = reader.GetString(9);
                    pEstudiante.Ocupacion = reader.GetString(10);
                    pEstudiante.N_Academico = reader.GetString(11);
                    pEstudiante.D_Idioma = reader.GetString(12);
                    pEstudiante.NivelA = reader.GetString(13);
                    pEstudiante.Codigo_Grupo = Convert.ToInt32(reader["Codigo_Grupo"]);
                    pEstudiante.Modo_Pago = reader.GetString(16);
                    pEstudiante.VIP = reader["VIP"].ToString();
                    pEstudiante.Respuesta1 = reader["Respuesta1"].ToString();
                    pEstudiante.Respuesta2 = reader["Respuesta2"].ToString();
                    pEstudiante.Celular = reader["Celular"].ToString();

                }
                conexion.Close();
                return pEstudiante;

            }
        }
        public static int Modificar(EstudianteBase pEstudiante)
        {
            int retorno = -1;

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Estudiantes set Nombre = '{0}', Apellido = '{1}', FechaN = '{2}', Edad = '{3}', Telefono = '{4}', FechaA = '{5}', Email = '{6}', Direccion = '{7}', Sector = '{8}', Ocupacion = '{9}', NivelA = '{10}', DominioIdiomaIngles = '{11}', Nivel = '{12}', Codigo_Grupo = {13}, Modo_Pago = '{14}', Celular = '{15}', Respuesta1 = '{16}', Respuesta2 = '{17}' where ID = {18}",
                    pEstudiante.Nombre, pEstudiante.Apellido, pEstudiante.Fecha_N, pEstudiante.Edad, pEstudiante.Telefono, pEstudiante.Fecha_Ins, pEstudiante.E_Mail, pEstudiante.Direccion, pEstudiante.Sector, pEstudiante.Ocupacion, pEstudiante.N_Academico, pEstudiante.D_Idioma, pEstudiante.NivelA, pEstudiante.Codigo_Grupo, pEstudiante.Modo_Pago, pEstudiante.Celular, pEstudiante.Respuesta1, pEstudiante.Respuesta2 , pEstudiante.ID), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static int EliminarEstudiante(EstudianteBase pEstudiante)
        {
            int retorno = -1;

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete Estudiantes where ID = {0}", pEstudiante.ID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }

            return retorno;
        }

        public static string ObtenerMatricula(EstudianteBase pEstudiante)
        {
            string matricula = null;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select ID from Estudiantes Where Nombre = '{0}' and Apellido = '{1}' and FechaN = '{2}' and Edad = '{3}' and Telefono = '{4}' and FechaA = '{5}' and Email = '{6}' and Direccion = '{7}' and Sector = '{8}' and Ocupacion = '{9}' and NivelA = '{10}' and DominioIdiomaIngles = '{11}' and Nivel = '{12}'",
                    pEstudiante.Nombre, pEstudiante.Apellido, pEstudiante.Fecha_N, pEstudiante.Edad, pEstudiante.Telefono, pEstudiante.Fecha_Ins, pEstudiante.E_Mail, pEstudiante.Direccion, pEstudiante.Sector, pEstudiante.Ocupacion, pEstudiante.N_Academico, pEstudiante.D_Idioma, pEstudiante.NivelA), conexion);

                matricula = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return matricula;
        }
        public static string ObtenerNombre(Int32 ID)
        {
            string Nombre = null;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select Nombre from Estudiantes Where ID = {0}", ID), conexion);

                    Nombre = comando.ExecuteScalar().ToString();

                    conexion.Close();
                }
                catch (Exception)
                {
                    Nombre = null;
                }
            }
            return Nombre;
        }

        public static string ObtenerApellido(Int32 ID)
        {
            string Apelldo = null;

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                    SqlCommand comando = new SqlCommand(string.Format("select Apellido from Estudiantes Where ID = {0}", ID), conexion);

                    Apelldo = comando.ExecuteScalar().ToString();
                    conexion.Close();
            }
            return Apelldo;
        }
        public static string ObtenerUltimoPago(Int32 ID)
        {
            string ULtimoP = null;

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                    SqlCommand comando = new SqlCommand(string.Format("Select Ultimo_Pago from Estudiantes where ID = {0}", ID), conexion);

                    ULtimoP = comando.ExecuteScalar().ToString();

                    conexion.Close();
            }
            return ULtimoP;
        }
        public static int UltimoPago(string pFecha, Int32 pID)
        {
            int PAgo = 0;

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Estudiantes set Ultimo_Pago = '{0}' where ID = {1}", pFecha, pID), conexion);

                PAgo = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return PAgo;
        }
        public static List<Estudiante> TodosEstudiante()
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Estudiantes order by ID desc"), conexion);

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
        public static DateTime ObtenerFechaProximoPago(Int32 pID)
        {
            DateTime fecha = DateTime.Today;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select FechaProximoPago from Estudiantes where ID = {0}", pID), conexion);
                fecha = Convert.ToDateTime(comando.ExecuteScalar());
                conexion.Close();
            }
            return fecha;
        }
        public static string ObtenerModoPago(Int32 pID)
        {
            string MP = null;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                    SqlCommand comando = new SqlCommand(string.Format("Select Modo_Pago from Estudiantes where ID = {0}", pID), conexion);
                    MP = comando.ExecuteScalar().ToString();
                    conexion.Close();
            }
            return MP;
        }
        public static int ActualizarProximoPago(Int32 pID, string pFecha)
        {
            int R;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Estudiantes set FechaProximoPago = '{0}' where ID = {1}", pFecha, pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerCodigoNivel(Int64 pMatricula)
        {
            string R = null;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Codigo_Grupo from Estudiantes where ID = {0}", pMatricula), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static List<Estudiante> BuscarEstudiantePorMatrc(int Matricula)
        {
            List<Estudiante> list = new List<Estudiante>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format("select * from Estudiantes where ID={0}", Matricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estudiante E = new Estudiante();
                    E.ID = reader.GetInt32(0);
                    E.Nombre = reader.GetString(1);
                    E.Apellido = reader.GetString(2);
                    E.Fecha_N = reader.GetDateTime(3).ToString();
                    E.Edad = reader.GetString(4);
                    E.Telefono = reader.GetString(5);
                    E.Fecha_Ins = reader.GetDateTime(6).ToString();
                    E.E_Mail = reader.GetString(7);
                    E.Direccion = reader.GetString(8);
                    E.Sector = reader.GetString(9);
                    E.Ocupacion = reader.GetString(10);
                    E.N_Academico = reader.GetString(11);
                    E.D_Idioma = reader.GetString(12);
                    E.NivelA = reader.GetString(13);
                    E.Codigo_Grupo = reader.GetInt32(15);
                    E.Modo_Pago = reader.GetString(16);
                    E.VIP = reader["VIP"].ToString();
                    list.Add(E);

                }
                conexion.Close();
            }
            return list;
        }
        public static int UpdateVIPstatus(string vipS, string ID)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Estudiantes set VIP= '{0}' where ID = {1}", vipS, ID), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int getTotalStudentsRegistered()
        {
            int r;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("select COUNT(*) as CantRegistrados from Estudiantes", con);
                r = int.Parse(comand.ExecuteScalar().ToString());
                con.Close();
            }
            return r;
        }
    }
}

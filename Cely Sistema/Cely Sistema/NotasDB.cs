using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Cely_Sistema
{
    public class NotasDB
    {
        public static int RegistrarNotaExamenE(Notas pNotas, string nivelID)
        {
            int retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into NotasExamenEscrito (Matricula, Nombre, N1, N2, N3, NF, Fecha_Examen, NivelID) values ({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}')", pNotas.Matricula, pNotas.Nombre, pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, nivelID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int RegistrarNotaExamenL(Notas pNotas, string nivelID)
        {
            int retorno = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into NotasExamenLectura (Matricula, Nombre, N1, N2, N3, NF, Fecha_Examen, NivelID) values ({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}')", pNotas.Matricula, pNotas.Nombre, pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, nivelID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int RegistrarNotaExamenO(Notas pNotas, string nivelID)
        {
            int retorno = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into NotasExamenOral (Matricula, Nombre, N1, N2, N3, NF, Fecha_Examen, NivelID) values ({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}')", pNotas.Matricula, pNotas.Nombre, pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, nivelID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int RegistrarNotaExposicion(Notas pNotas, string nivelID)
        {
            int retorno = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into NotasExposicion (Matricula, Nombre, N1, N2, N3, NF, Fecha_Examen, NivelID) values ({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}')", pNotas.Matricula, pNotas.Nombre, pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, nivelID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static List<Notas> TodasLasNotasExpM(Int32 pMatricula, string fechaExamen)
        {
            List<Notas> Lista = new List<Notas>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotasExposicion where Matricula like '{0}%'", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Notas pNotas = new Notas();
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                    Lista.Add(pNotas);
                }
                conexion.Close();
            }
            return Lista;
        }
        public static List<Notas> TodasLasNotasExmenEscrM(Int32 pMatricula, string fechaExamen)
        {
            List<Notas> Lista = new List<Notas>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotasExamenEscrito where Matricula like '{0}%'", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Notas pNotas = new Notas();
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                    Lista.Add(pNotas);
                }
                conexion.Close();
            }
            return Lista;
        }
        public static List<Notas> TodasLasNotasExamenOralM(Int32 pMatricula, string fechaExamen)
        {
            List<Notas> Lista = new List<Notas>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotasExamenOral where Matricula like '{0}%'", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Notas pNotas = new Notas();
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                    Lista.Add(pNotas);
                }
                conexion.Close();
            }
            return Lista;
        }
        public static List<Notas> TodasLasNotasExamenLecM(Int32 pMatricula, string fechaExamen)
        {
            List<Notas> Lista = new List<Notas>();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from NotasExamenLectura where Matricula like '{0}%'", pMatricula), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Notas pNotas = new Notas();
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                    Lista.Add(pNotas);
                }
                conexion.Close();
            }
            return Lista;
        }
        public static Notas ObtenerNotasExp(int pID, string FechaExamen)
        {
            Notas pNotas = new Notas();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from NotasExposicion where ID like '{0}%'", pID), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                }
                conexion.Close();
            }
            return pNotas;
        }
        public static Notas ObtenerNotasExamenLect(int pID, string FechaExamen)
        {
            Notas pNotas = new Notas();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from NotasExamenLectura where ID like '{0}%'", pID), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                }
                conexion.Close();
            }
            return pNotas;
        }
        public static Notas ObtenerNotasExamenOral(int pID, string FechaExamen)
        {
            Notas pNotas = new Notas();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from NotasExamenOral where ID like '{0}%'", pID), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                }
                conexion.Close();
            }
            return pNotas;
        }
        public static Notas ObtenerNotasExamenEscrito(int pID, string FechaExamen)
        {
            Notas pNotas = new Notas();
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * from NotasExamenEscrito where ID like '{0}%'", pID), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNotas.ID = reader.GetInt32(0);
                    pNotas.Matricula = reader.GetInt32(1);
                    pNotas.Nombre = reader.GetString(2);
                    pNotas.N1 = reader.GetInt32(3);
                    pNotas.N2 = reader.GetInt32(4);
                    pNotas.N3 = reader.GetInt32(5);
                    pNotas.NF = reader.GetInt32(6);
                    pNotas.Fecha_Examen = reader.GetDateTime(7).ToString();
                }
                conexion.Close();
            }
            return pNotas;
        }
        public static int ModificarCalificacionesExamenOral(Notas pNotas)
        {
            int retorno;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("update NotasExamenOral set N1 = {0}, N2 = {1}, N3 = {2}, NF = {3}, Fecha_Examen = '{4}' where ID = {5}", pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF,pNotas.Fecha_Examen, pNotas.ID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarCalificacionesExamenEscrito(Notas pNotas)
        {
            int retorno;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("update NotasExamenEscrito set N1 = {0}, N2 = {1}, N3 = {2}, NF = {3}, Fecha_Examen = '{4}' where ID = {5}", pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, pNotas.ID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarCalificacionesExamenLectura(Notas pNotas)
        {
            int retorno;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("update NotasExamenLectura set N1 = {0}, N2 = {1}, N3 = {2}, NF = {3}, Fecha_Examen = '{4}' where ID = {5}", pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, pNotas.ID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarCalificacionesExposicion(Notas pNotas)
        {
            int retorno;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("update NotasExposicion set N1 = {0}, N2 = {1}, N3 = {2}, NF = {3}, Fecha_Examen = '{4}' where ID = {5}", pNotas.N1, pNotas.N2, pNotas.N3, pNotas.NF, pNotas.Fecha_Examen, pNotas.ID), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarNotaExamenEscrito(int pID)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete NotasExamenEscrito where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int EliminarNotaExamenLectura(int pID)
        {
            int R = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete NotasExamenLectura where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int EliminarNotaExamenOral(int pID)
        {
            int R = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete NotasExamenOral where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int EliminarNotaExposicion(int pID)
        {
            int R = -1;
            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete NotasExposicion where ID = {0}", pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
    }
}

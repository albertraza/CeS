using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class UsuariosDB
    {
        public static int RegistrarUsuarios(Usuarios pU)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into Usuarios (Nombre, Contraseña, Nivel) values ('{0}', PWDEncrypt('{1}'), '{2}')", pU.Nombre_Usuario, pU.Contraseña, pU.Nivel), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int Login(Usuarios pU)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Usuarios where PWDcompare('{0}', Contraseña) = 1 and Nombre  = '{1}'", pU.Contraseña, pU.Nombre_Usuario), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    R = 50;
                }
                conexion.Close();
            }
            return R;
        }
        public static int ModificarUsuarios(Usuarios pU)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Usuarios set Nombre = '{0}', Contraseña = PWDEncrypt('{1}'), Nivel = '{2}' where ID = {3}", pU.Nombre_Usuario, pU.Contraseña, pU.Nivel, pU.Codigo), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerCodigo(Usuarios pU)
        {
            string N = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select ID From Usuarios where Nombre = '{0}'", pU.Nombre_Usuario), conexion);
                N = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return N;
        }
        public static int Eliminar(int Codigo)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete usuarios where ID = {0}", Codigo), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ONivel(string NombreUsuario)
        {
            string Nivel = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Nivel from Usuarios where Nombre = '{0}'", NombreUsuario), conexion);
                Nivel = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return Nivel;
        }
        public static List<UsuariosS> Buscar(String codigo, String idusuario, String nivel)
        {
            List<UsuariosS> listu = new List<UsuariosS>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from usuarios where ID like '{0}%' and Nombre like '{1}%' and Nivel like '{2}%'", codigo, idusuario, nivel), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    UsuariosS u = new UsuariosS();
                    u.Codigo = re["ID"].ToString();
                    u.ID_Usuario = re["Nombre"].ToString();
                    u.Nivel = re["Nivel"].ToString();

                    listu.Add(u);
                }
                con.Close();
            }
            return listu;
        }
    }
}

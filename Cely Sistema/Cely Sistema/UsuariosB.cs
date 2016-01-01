using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class UsuariosB
    {
        public string codigo { get; set; }
        public string Nombre_Usuario { get; set; }

        public UsuariosB() { }
        public UsuariosB(string c, string id)
        {
            this.codigo = c;
            this.Nombre_Usuario = id;
        }

        public static List<UsuariosB> Buscar(string codigo, string NombreUsuario, string nivel)
        {
            List<UsuariosB> list = new List<UsuariosB>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Usuarios where ID like '{0}%' and Nombre like '{1}%' and Nivel like '{2}%'", codigo, NombreUsuario, nivel), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    UsuariosB u = new UsuariosB();
                    u.codigo = re["ID"].ToString();
                    u.Nombre_Usuario = re["Nombre"].ToString();
                    list.Add(u);
                }
                con.Close();
            }
            return list;
        }
        public static List<UsuariosB> TodosUsuarios()
        {
            List<UsuariosB> list = new List<UsuariosB>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Usuarios"), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    UsuariosB u = new UsuariosB();
                    u.codigo = re["ID"].ToString();
                    u.Nombre_Usuario = re["Nombre"].ToString();
                    list.Add(u);
                }
                con.Close();
            }
            return list;
        }
    }
}

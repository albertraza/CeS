using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class UsuariosS
    {
        public string Codigo { get; set; }
        public string ID_Usuario { get; set; }
        public string Nivel { get; set; }

        public UsuariosS() { }
        public UsuariosS(string c, string id, string n)
        {
            this.Codigo = c;
            this.ID_Usuario = id;
            this.Nivel = n;
        }
    }
}

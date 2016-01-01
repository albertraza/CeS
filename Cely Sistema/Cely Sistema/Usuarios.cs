using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Usuarios
    {
        public Int32 Codigo { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Contraseña { get; set; }
        public String Nivel { get; set; }

        public Usuarios()
        {

        }
        public Usuarios(Int32 pC, String pNU, String pC1, String pN)
        {
            this.Codigo = pC;
            this.Nombre_Usuario = pNU;
            this.Contraseña = pC1;
            this.Nivel = pN;
        }
    }
}

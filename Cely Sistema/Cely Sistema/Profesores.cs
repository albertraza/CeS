using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Profesores
    {
        public Int32 ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Profesores()
        { }

        public Profesores(Int32 pID, string N, string A)
        {
            this.ID = pID;
            this.Nombre = N;
            this.Apellido = A;
        }
    }
}

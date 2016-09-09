using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Asistencia
    {
        public Int32 Matricula { get; set; }
        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public DateTime Fecha { get; set; }

        public Asistencia() { }
        public Asistencia(Int32 pM, string pN, string pNi, DateTime pF)
        {
            this.Matricula = pM;
            this.Nombre = pN;
            this.Nivel = pNi;
            this.Fecha = pF;
        }
    }
}

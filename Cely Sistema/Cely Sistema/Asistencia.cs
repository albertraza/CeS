using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Asistencia
    {
        public Int32 ID { get; set; }
        public Int32 Matricula { get; set; }
        public string Nombre { get; set; }
        public string Fecha_Inicio { get; set; }
        public Int32 CAsistencia { get; set; }
        public string Ultima_Asistencia { get; set; }

        public Asistencia() { }
        public Asistencia(Int32 pID, Int32 pM, string pN, string pFI, Int32 pA, string pUA)
        {
            this.ID = pID;
            this.Matricula = pM;
            this.Nombre = pN;
            this.Fecha_Inicio = pFI;
            this.CAsistencia = pA;
            this.Ultima_Asistencia = pUA;
        }
    }
}

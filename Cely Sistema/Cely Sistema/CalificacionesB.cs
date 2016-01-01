using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class CalificacionesB
    {
        public Int32 ID { get; set; }
        public int Primer_Parcial { get; set; }
        public int Segundo_Parcial { get; set; }
        public int Tercer_parcial { get; set; }
        public int Asistencia { get; set; }
        public string Fecha_Parcial { get; set; }

        public CalificacionesB()
        {

        }

        public CalificacionesB(int pID , int PP, int SP, int TP, int A, string FP)
        {
            this.ID = pID;
            this.Primer_Parcial = PP;
            this.Segundo_Parcial = SP;
            this.Tercer_parcial = TP;
            this.Asistencia = A;
            this.Fecha_Parcial = FP;
        }
    }
}

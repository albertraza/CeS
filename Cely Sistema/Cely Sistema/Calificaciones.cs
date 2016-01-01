using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Calificaciones
    {
        public int ID { get; set; }
        public int Codigo_Estudiante { get; set; }
        public string Nombre_Estudiante { get; set; }
        public int Primer_Parcial { get; set; }
        public int Sengundo_Parcial { get; set; }
        public int Tercer_Parcial { get; set; }
        public int Asistencia { get; set; }
        public string Fecha_Parcial { get; set; }
        public int Codigo_Grupo { get; set; }

        public Calificaciones()
        { }

        public Calificaciones(int pID, int CE, string NE, int PP, int SP, int TP, int A, string FP, int CG)
        {
            this.ID = pID;
            this.Codigo_Estudiante = CE;
            this.Nombre_Estudiante = NE;
            this.Primer_Parcial = PP;
            this.Sengundo_Parcial = SP;
            this.Tercer_Parcial = TP;
            this.Asistencia = A;
            this.Fecha_Parcial = FP;
            this.Codigo_Grupo = CG;
        }

    }
}

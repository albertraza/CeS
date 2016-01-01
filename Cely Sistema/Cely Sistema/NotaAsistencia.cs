using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class NotaAsistencia
    {
        public Int32 ID { get; set; }
        public Int32 Matricula { get; set; }
        public String Nombre { get; set; }
        public Decimal Calificacion { get; set; }
        public string Fecha_Calificacion { get; set; }

        public NotaAsistencia()
        { }

        public NotaAsistencia(Int32 pID, Int32 pMatricula, String pNombre, Decimal pCalificacion, string pFecha)
        {
            this.ID = pID;
            this.Matricula = pMatricula;
            this.Nombre = pNombre;
            this.Calificacion = pCalificacion;
            this.Fecha_Calificacion = pFecha;
        }
    }
}

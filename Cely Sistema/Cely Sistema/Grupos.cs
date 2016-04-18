using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Grupos
    {
        public Int32 ID { get; set; }
        public string Nivel { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
        public string Horario { get; set; }
        public string Fecha_Inicio { get; set; }
        public int Total_Inscritos { get; set; }

        public Grupos()
        { }

        public Grupos(Int32 pID, string N, string P, string A, string H, string FI, int TI)
        {
            this.ID = pID;
            this.Nivel = N;
            this.Profesor = P;
            this.Aula = A;
            this.Horario = H;
            this.Fecha_Inicio = FI;
            this.Total_Inscritos = TI;
        }
    }
}

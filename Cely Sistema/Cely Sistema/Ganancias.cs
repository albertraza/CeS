using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Ganancias
    {
        public Int32 ID { get; set; }
        public string Fecha_Ganancia { get; set; }
        public double Ganancia { get; set; }

        public Ganancias() { }

        public Ganancias(Int32 pID, string FG, double G)
        {
            this.ID = pID;
            this.Fecha_Ganancia = FG;
            this.Ganancia = G;
        }
    }
}

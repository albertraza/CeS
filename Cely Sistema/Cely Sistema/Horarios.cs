using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Horarios
    {
        public Int32 ID { get; set; }
        public string Dias { get; set; }
        public string Hora { get; set; }

        public Horarios()
        {

        }

        public Horarios(Int32 pID, string D, string H)
        {
            this.ID = pID;
            this.Dias = D;
            this.Hora = H;
        }
    }
}

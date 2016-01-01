using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Mora
    {
        public Int64 pID { get; set; }
        public String Mora_Semanal { get; set; }
        public String Mora_Mensual { get; set; }
        public String Pago_Mensual { get; set; }
        public String Pago_Semanal { get; set; }

        public Mora() { }

        public Mora(Int64 pid, String pMS, String pMM, String pPM, String pPS)
        {
            this.pID = pid;
            this.Mora_Semanal = pMS;
            this.Mora_Mensual = pMM;
            this.Pago_Mensual = pPM;
            this.Pago_Semanal = pPS;
        }
    }
}

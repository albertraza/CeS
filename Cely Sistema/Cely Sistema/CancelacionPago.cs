using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class CancelacionPago
    {
        public Int32 Codigo_Factura { get; set; }
        public Int32 Matricula { get; set; }
        public string Nombre { get; set; }
        public Decimal Monto { get; set; }
        public string Fecha_Pago { get; set; }

        public CancelacionPago()
        {
        }

        public CancelacionPago(Int32 pCF, Int32 pM, string pN, Decimal pMo, string pF)
        {
            this.Codigo_Factura = pCF;
            this.Matricula = pM;
            this.Nombre = pN;
            this.Monto = pMo;
            this.Fecha_Pago = pF;
        }
    }
}

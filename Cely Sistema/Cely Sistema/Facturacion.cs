using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Facturacion
    {
        public Int32 Matricula_Estudiante { get; set; }
        public string Nombre_Estudiante { get; set; }
        public double Precio { get; set; }
        public string Fecha_Factura { get; set; }
        public string Razon_Pago { get; set; }
        public string Cancelacion_Pago { get; set; }
        public int Codigo_Factura { get; set; }
        public string FechaProximoPago { get; set; }

        public Facturacion()
        { }

        public Facturacion(Int32 ME, string NE, int P, string FF, string N, string CP, int CF, string fpp)
        {
            this.Matricula_Estudiante = ME;
            this.Nombre_Estudiante = NE;
            this.Precio = P;
            this.Fecha_Factura = FF;
            this.Razon_Pago = N;
            this.Cancelacion_Pago = CP;
            this.Codigo_Factura = CF;
            this.FechaProximoPago = fpp;
        }
    }
}

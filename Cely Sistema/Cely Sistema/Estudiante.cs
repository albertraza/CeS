using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_N { get; set; }
        public string Fecha_Ins { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public string E_Mail { get; set; }
        public string D_Idioma { get; set; }
        public string N_Academico { get; set; }
        public string NivelA { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }
        public Int64 ID { get; set; }
        public string Sector { get; set; }
        public Int32 Codigo_Grupo { get; set; }
        public string Modo_Pago { get; set; }


        public Estudiante() { }

        public Estudiante(string pNombre, string pApellido, string pFecha_N, string pFecha_Ins, string pDireccion, string pOcupacion,
            string pE_Mail, string pD_Idioma, string pN_Academico, string pNivelA, string pTelefono, string pEdad, Int64 pID, string pSector, Int32 CG, string MP)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Fecha_N = pFecha_N;
            this.Fecha_Ins = pFecha_Ins;
            this.Direccion = pDireccion;
            this.Ocupacion = pOcupacion;
            this.E_Mail = pE_Mail;
            this.D_Idioma = pD_Idioma;
            this.N_Academico = pN_Academico;
            this.NivelA = pNivelA;
            this.Telefono = pTelefono;
            this.Edad = pEdad;
            this.ID = pID;
            this.Sector = pSector;
            this.Codigo_Grupo = CG;
            this.Modo_Pago = MP;
        }
    }
}

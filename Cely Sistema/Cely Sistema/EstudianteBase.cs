﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class EstudianteBase
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
        public string VIP { get; set; }
        public string Celular { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public int pagoGrupal { get; set; }
        public int codigoGrupal { get; set; }

        public EstudianteBase() { }

        public EstudianteBase(string pNombre, string pApellido, string pFecha_N, string pFecha_Ins,
            string pDireccion, string pOcupacion,
            string pE_Mail, string pD_Idioma, string pN_Academico, string pNivelA, string pTelefono,
            string pEdad, Int64 pID, string pSector, Int32 CG, string MP, 
            string vip, string celular, string respu1, string respu2, int pg, int cg)
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
            this.VIP = vip;
            this.Respuesta1 = respu1;
            this.Respuesta2 = respu2;
            this.Celular = celular;
            this.pagoGrupal = pg;
            this.codigoGrupal = cg;
        }
    }
    public class Pagos
    {
        public int Matricula { get; set; }
        public double PagoMensualSemanal { get; set; }
        public double MoraMensualSemanal { get; set; }

        public Pagos() { }
        public Pagos(int ma, double pms, double mms)
        {
            Matricula = ma;
            PagoMensualSemanal = pms;
            MoraMensualSemanal = mms;
        }
    }
    public class EstudiantesPago
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nivel { get; set; }

        public EstudiantesPago() { }
        public EstudiantesPago(int m, string n, string a, string ni)
        {
            Matricula = m;
            Nombre = n;
            Apellido = a;
            Nivel = ni;
        }
    }
}

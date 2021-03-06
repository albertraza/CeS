﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;



namespace Cely_Sistema
{
    public class FacturacionDB
    {
        public static int CrearFactura(Facturacion pFactura)
        {
            int Factura = 0;

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Facturacion (IDCliente, NombreCliente, Precio, FechaFactura, Notas, CancelacionPago) values ({0}, '{1}', {2}, '{3}', '{4}', '{5}')",
                    pFactura.Matricula_Estudiante, pFactura.Nombre_Estudiante, pFactura.Precio, pFactura.Fecha_Factura, pFactura.Razon_Pago, pFactura.Cancelacion_Pago), conexion);

                Factura = comando.ExecuteNonQuery();

                conexion.Close();
            }
            return Factura;
        }
        public static string ObtenerCodigo(Facturacion pFactura)
        {
            string Codigo = null;

            using(SqlConnection conaxion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select CodigoFacturacion from Facturacion Where IDCLiente = {0} and NombreCliente = '{1}' and Precio = '{2}' and FechaFactura = '{3}' and Notas = '{4}' and CancelacionPago = '{5}'",
                    pFactura.Matricula_Estudiante, pFactura.Nombre_Estudiante, pFactura.Precio, pFactura.Fecha_Factura, pFactura.Razon_Pago, pFactura.Cancelacion_Pago), conaxion);

                Codigo = comando.ExecuteScalar().ToString();

                conaxion.Close();
            }
            return Codigo;
        }

        public static List<Facturacion> TodasLasFacturas(string pFecha)
        {
            List<Facturacion> Factura = new List<Facturacion>();

            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Facturacion where FechaFactura = '{0}'", pFecha), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Facturacion pFactura = new Facturacion();
                    pFactura.Matricula_Estudiante = reader.GetInt32(0);
                    pFactura.Nombre_Estudiante = reader.GetString(1);
                    pFactura.Precio = Convert.ToDouble(reader.GetValue(2));
                    pFactura.Fecha_Factura = reader.GetDateTime(3).ToString();
                    pFactura.Razon_Pago = reader.GetString(4);
                    pFactura.Cancelacion_Pago = reader.GetString(5);
                    pFactura.Codigo_Factura = reader.GetInt32(6);

                    Factura.Add(pFactura);
                }
                conexion.Close();
            }
            return Factura;
        }
        public static List<Facturacion> TodasLasFacturasND()
        {
            List<Facturacion> Factura = new List<Facturacion>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Facturacion"), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Facturacion pFactura = new Facturacion();

                    pFactura.Matricula_Estudiante = reader.GetInt32(0);
                    pFactura.Nombre_Estudiante = reader.GetString(1);
                    pFactura.Precio = Convert.ToDouble(reader.GetValue(2));
                    pFactura.Fecha_Factura = reader.GetDateTime(3).ToString();
                    pFactura.Razon_Pago = reader.GetString(4);
                    pFactura.Cancelacion_Pago = reader.GetString(5);
                    pFactura.Codigo_Factura = reader.GetInt32(6);

                    Factura.Add(pFactura);
                }
                conexion.Close();
            }
            return Factura;
        }
        public static List<Facturacion> BuscarFacturas(Int32 pMatricula)
        {
            List<Facturacion> Factura = new List<Facturacion>();

            using (SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from Facturacion where IDCliente = {0}", pMatricula), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Facturacion pFactura = new Facturacion();

                    pFactura.Matricula_Estudiante = reader.GetInt32(0);
                    pFactura.Nombre_Estudiante = reader.GetString(1);
                    pFactura.Precio = Convert.ToDouble(reader.GetValue(2));
                    pFactura.Fecha_Factura = reader.GetDateTime(3).ToString();
                    pFactura.Razon_Pago = reader.GetString(4);
                    pFactura.Cancelacion_Pago = reader.GetString(5);
                    pFactura.Codigo_Factura = reader.GetInt32(6);

                    Factura.Add(pFactura);
                }
                conexion.Close();
            }
            return Factura;
        }
        public static List<Facturacion> BuscarFacturas1(string Matricula, string NombreApellido, string Precio, string FechaFa, string CodigoFa, string notas)
        {
            List<Facturacion> Factura = new List<Facturacion>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Facturacion where IDCLiente like '{0}%' and NombreCLiente like '{1}%' and Precio like '{2}%' and FechaFactura like '{3}%' and Notas like '{4}%' and CodigoFacturacion like '{5}%'",
                    Matricula, NombreApellido, Precio, FechaFa, notas, CodigoFa), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Facturacion pFactura = new Facturacion();
                    pFactura.Matricula_Estudiante = reader.GetInt32(0);
                    pFactura.Nombre_Estudiante = reader.GetString(1);
                    pFactura.Precio = Convert.ToDouble(reader.GetValue(2));
                    pFactura.Fecha_Factura = reader.GetDateTime(3).ToString();
                    pFactura.Razon_Pago = reader.GetString(4);
                    pFactura.Cancelacion_Pago = reader.GetString(5);
                    pFactura.Codigo_Factura = reader.GetInt32(6);

                    Factura.Add(pFactura);
                }
                conexion.Close();
            }
            return Factura;
        }
        public static List<CancelacionPago> BuscarfacturasCP(int pID)
        {
            List<CancelacionPago> list = new List<CancelacionPago>();
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select CodigoFacturacion, IDCliente, NombreCliente, Precio, FechaFactura from Facturacion where CodigoFacturacion = {0}", pID), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    CancelacionPago pCP = new CancelacionPago();
                    pCP.Codigo_Factura = reader.GetInt32(0);
                    pCP.Matricula = reader.GetInt32(1);
                    pCP.Nombre = reader.GetString(2);
                    pCP.Monto = reader.GetDecimal(3);
                    pCP.Fecha_Pago = reader.GetDateTime(4).ToString();
                    list.Add(pCP);
                }
                conexion.Close();
            }
            return list;
        }
        public static int CancelarPago(int pID, string pCP)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Facturacion set CancelacionPago = '{0}' where CodigoFacturacion = {1}", pCP, pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int ActualizarFechaPAgoAnterior(int pID, string pFecha)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Facturacion set Fecha_Pago_Anterior = '{0}' where CodigoFacturacion = {1}", pFecha, pID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerFechaPagoAnterior(int pID)
        {
            string FPA = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Fecha_Pago_Anterior from Facturacion where CodigoFacturacion = {0}", pID),conexion);
                FPA = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return FPA;
        }
        public static string ObtenerCancelacionPago(int pID)
        {
            string r = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select CancelacionPago from Facturacion where CodigoFacturacion = {0}", pID), con);
                r = comand.ExecuteScalar().ToString();
                con.Close();
            }
            return r;
        }
    }
}

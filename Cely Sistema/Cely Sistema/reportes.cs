using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Cely_Sistema
{
    public class reportes
    {
        // report for VIP students where their payment is monthly
        public static DataTable contratoEstudianteVIPMensual(string Matricula)
        {
            DataTable r = new DataTable();
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Estudiantes.ID as Matricula, Nombre, Apellido as Apellidos, FechaN as FechaNacimiento, Edad, Telefono, Celular, Email, Sector, Direccion, Ocupacion, NivelA as NivelAcademico, DominioIdiomaIngles as DominioIdiomaIngles, Pago_VIP as PagoMensualSemanal, Mora_Mensual as Mora, VIP from Estudiantes Inner join CantidadPagoVIP on CantidadPagoVIP.ID = 1 where VIP = 'Si' and Modo_Pago = 'Mensual' and Estudiantes.ID = '{0}'", Matricula), con);
                da.Fill(r);
                con.Close();
            }
            return r;
        }
        // report for VIP students where their payment is weekly
        public static DataTable contratoEstudianteVIPSemanal(string Matricula)
        {
            DataTable r = new DataTable();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Estudiantes.ID as Matricula, Nombre, Apellido as Apellidos, FechaN as FechaNacimiento, Edad, Telefono, Celular, Email, Sector, Direccion, Ocupacion, NivelA as NivelAcademico, DominioIdiomaIngles as DominioIdiomaIngles, Pago_Semanal as PagoMensualSemanal, Mora_Semanal as Mora, VIP from Estudiantes Inner join CantidadPagoVIP on CantidadPagoVIP.ID = 1 where VIP = 'Si' and Modo_Pago = 'Semanal' and Estudiantes.ID = '{0}'", Matricula), con);
                da.Fill(r);
                con.Close();
            }
            return r;
        }
        // report for non VIP students where their payment is weekly
        public static DataTable contratoEstudianteSemanal(string Matricula)
        {
            DataTable r = new DataTable();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Estudiantes.ID as Matricula, Nombre, Apellido as Apellidos, FechaN as FechaNacimiento, Edad, Telefono, Celular, Email, Sector, Direccion, Ocupacion, NivelA as NivelAcademico, DominioIdiomaIngles as DominioIdiomaIngles, Pago_Semanal as PagoMensualSemanal, Mora_Semanal as Mora, VIP from Estudiantes Inner join CantidadPago on CantidadPago.ID = 1 inner join Mora on Mora.ID = 1 where VIP = 'NO' and Modo_Pago = 'Semanal' and Estudiantes.ID = '{0}'", Matricula), con);
                da.Fill(r);
                con.Close();
            }
            return r;
        }
        // report for non VIP students where their payment is monthly
        public static DataTable contratoEstudianteMensual(string Matricula)
        {
            DataTable r = new DataTable();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("Select Estudiantes.ID as Matricula, Nombre, Apellido as Apellidos, FechaN as FechaNacimiento, Edad, Telefono, Celular, Email, Sector, Direccion, Ocupacion, NivelA as NivelAcademico, DominioIdiomaIngles as DominioIdiomaIngles, Pago_Mensual as PagoMensualSemanal, Mora_Mensual as Mora, VIP from Estudiantes Inner join CantidadPago on CantidadPago.ID = 1 inner join Mora on Mora.ID = 1 where VIP = 'NO' and Modo_Pago = 'Mensual' and Estudiantes.ID = '{0}'", Matricula), con);
                da.Fill(r);
                con.Close();
            }
            return r;
        }

        // *************** reports for factura Semanal and Mensual *************** //

        public static DataTable Factura(string codigoFactura)
        {
            DataTable r = new DataTable();
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format("select Estudiantes.Nombre, Estudiantes.Apellido, Facturacion.PagoMensualSemanal, Facturacion.CantSemanasMesesPagos as CantSemanasMesesPagados, Facturacion.MesesSemnasRestantes as CantSemanasMesesPendientes, Facturacion.Precio as TotalPagado, Facturacion.FechaFactura as FechaPago, Estudiantes.FechaProximoPago, Facturacion.PagoCon, Facturacion.devuelta as Devuelta, Facturacion.CodigoFacturacion as CodigoFactura, Facturacion.Notas as MotivodePago, Facturacion.mora as Mora, Facturacion.TotalMensualSemanal, Facturacion.TotalMora, Facturacion.Descuento from Facturacion inner join Estudiantes on Estudiantes.ID = Facturacion.IDCLiente where Facturacion.CodigoFacturacion = '{0}'", codigoFactura), con);
                da.Fill(r);
                con.Close();
            }
            return r;
        }
    }
}

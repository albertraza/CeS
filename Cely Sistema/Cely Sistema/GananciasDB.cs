using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class GananciasDB
    {
        // Object Base for ganancias
        public int ID { get; set; }
        public string Fecha_Ganancias { get; set; }
        public decimal Total_Ingresos { get; set; }
        public decimal Libros { get; set; }
        public decimal Inscripcion { get; set; }
        public decimal Reinscripcion { get; set; }
        public decimal Derecho_Examen { get; set; }
        public decimal Cuota { get; set; }
        public decimal Gastos { get; set; }
        public string Detalles_Gastos { get; set; }
        public decimal Total_Ganancias { get; set; }
        // end object building //

        // constructs
        public GananciasDB() { }
        public GananciasDB(int id, string fecha, decimal totalin, decimal libros, decimal ins, decimal reins, decimal derec,
            decimal cuota, decimal gastos, string detalles, decimal totalga)
        {
            this.ID = id;
            this.Fecha_Ganancias = fecha;
            this.Total_Ingresos = totalin;
            this.Libros = libros;
            this.Inscripcion = ins;
            this.Reinscripcion = reins;
            this.Derecho_Examen = derec;
            this.Cuota = cuota;
            this.Gastos = gastos;
            this.Detalles_Gastos = detalles;
            Total_Ganancias = totalga;
        }
        // end cosuntrucst biulding //

        public static int RegistrarGanancias(Ganancias pGanancias)
        {
            int Retorno = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into Ganancias (Fecha_Ganancias, Ingresos) values ('{0}', {1})", pGanancias.Fecha_Ganancia, pGanancias.Ganancia), conexion);
                Retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return Retorno;
        }
        public static string ObtenerCantidad(string pfecha)
        {
            string g = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select Ingresos from Ganancias where Fecha_Ganancias = '{0}'", pfecha), conexion);
                    g = comando.ExecuteScalar().ToString();
                    conexion.Close();
                }
                catch (Exception)
                {
                    g = null;
                }
            }
            return g;
        }
        public static string ObtenerID(string pFecha)
        {
            string g = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select ID From Ganancias where Fecha_Ganancias = '{0}'", pFecha), conexion);
                    g = comando.ExecuteScalar().ToString();
                    conexion.Close();
                }
                catch (Exception)
                {
                    g = null;
                }
            }
            return g;
        }
        public static int ActualizarGanancias(Ganancias pGanancias)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Ingresos = {0} where ID = {1}", pGanancias.Ganancia, pGanancias.ID), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static int ActualizarGananciasF(string pFechaGanancia, Decimal pCantidad)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Ingresos = {0} where Fecha_Ganancias = '{1}'", pCantidad, pFechaGanancia), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerDescuentos(string pFechaGanancias)
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select Total_Descuentos from Ganancias where Fecha_Ganancias = '{0}'", pFechaGanancias), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static string ObtenerTotalIngresos(string pFechaGanancia)
        {
            string R = null;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select Total_Ganancias from Ganancias where Fecha_Ganancias = '{0}'", pFechaGanancia), conexion);
                R = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            return R;
        }
        public static int RegistrarIngresos(double TotalDescuentos, double TotalGanancias, string pFechaGanancias)
        {
            int R = -1;
            using(SqlConnection conexion = DBcomun.ObetenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update Ganancias set Total_Descuentos = {0}, Total_Ganancias = {1} where Fecha_Ganancias = '{2}'", TotalDescuentos, TotalGanancias, pFechaGanancias), conexion);
                R = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return R;
        }
        public static List<Ganancias> Buscar(string fecha)
        {
            List<Ganancias> list = new List<Ganancias>();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Ganancias where Fecha_Ganancias like '{0}%'", fecha), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Ganancias g = new Ganancias();
                    g.Fecha_Ganancia = Convert.ToDateTime(re["Fecha_Ganancias"]).ToString("dd-MM-yyyy");
                    g.Ganancia = Convert.ToDouble(re["Ingresos"]);
                    g.ID = Convert.ToInt32(re["ID"]);
                    list.Add(g);
                }
                con.Close();
            }
            return list;
        }
        public static int updateDescuentos()
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("update Ganancias set Total_Descuentos = 0 where Total_Descuentos is null", con);
                comand.ExecuteNonQuery(); r = 1;
                con.Close();
            }
            return r;
        }
        public static int updateTotalGanancias()
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("update Ganancias set Total_Ganancias = Ingresos where Total_Ganancias is null or Total_Descuentos = 0 or Total_Descuentos is null", con);
                comand.ExecuteNonQuery();
                r = 1;
                con.Close();
            }
            return r;
        }
        public static int fixMathIssue()
        {
            int retu = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("update Ganancias set Total_Ganancias = Ingresos - Total_Descuentos", con);
                retu = comand.ExecuteNonQuery();
                con.Close();
            }
            return retu;
        }

        public static string getTotalLibros(string fecha)
        {
            string retorno = null;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select Libros from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static string getTotalInscripcion(string fecha)
        {
            string retorno = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select Inscripcion from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static string getTotalReInscripcion(string fecha)
        {
            string retorno = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select Reinscripcion from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static string getTotalDetallesGastos(string fecha)
        {
            string retorno = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select DetallesGastos from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static string getTotalDerechoExamen(string fecha)
        {
            string retorno = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("select DerechoExamen from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static string getTotalCuotas(string fecha)
        {
            string retorno = null;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("Select Cuota from Ganancias where Fecha_Ganancias = '{0}'", fecha), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    retorno = comand.ExecuteScalar().ToString();
                }
                else
                {
                    retorno = null;
                }
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalLibros(string fecha, decimal Total)
        {
            int retorno = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Ganancias set Libros = '{0}' where Fecha_Ganancias = '{1}'", Total, fecha), con);
                retorno = comand.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalInscripcion(string fecha, decimal Total)
        {
            int retorno = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Ganancias set Inscripcion = '{0}' where Fecha_Ganancias = '{1}'", Total, fecha), con);
                retorno = comand.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalReInscripcion(string fecha, decimal Total)
        {
            int retorno = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Ganancias set Reinscripcion = '{0}' where Fecha_Ganancias = '{1}'", Total, fecha), con);
                retorno = comand.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalDetallesGastos(string fecha, string detalles)
        {
            int retorno = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Ganancias set DetallesGastos = '{0}' where Fecha_Ganancias = '{1}'", detalles, fecha), con);
                retorno = comand.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalDerechoExamen(string fecha, decimal Total)
        {
            int retorno = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("update Ganancias set DerechoExamen = '{0}' where Fecha_Ganancias = '{1}'", Total, fecha), con);
                retorno = comand.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static int updateTotalCuota(string fecha, decimal total)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand(string.Format("Update Ganancias set Cuota = '{0}' where Fecha_Ganancias = '{1}'", total, fecha), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
                return r;
        }
        public static int getAndUpdateGanancias(string tipoPago, string fecha, decimal total)
        {
            int retorno = -1;
            if (tipoPago == "Inscripcion")
            {
                string Ins = getTotalInscripcion(fecha);
                decimal ins;
                if (Ins == null || string.Empty == Ins)
                {
                    ins = total;
                }
                else
                {
                    ins = decimal.Parse(Ins);
                    ins += total;
                }
                retorno = updateTotalInscripcion(fecha, ins);
            }
            else if (tipoPago == "Reinscripcion")
            {
                string ReIns = getTotalReInscripcion(fecha);
                decimal reIns;
                if (ReIns == null || string.Empty == ReIns || decimal.Parse(ReIns) == 0)
                {
                    reIns = total;
                }
                else
                {
                    reIns = decimal.Parse(ReIns);
                    reIns += total;
                }
                retorno = updateTotalReInscripcion(fecha, reIns);
            }
            else if (tipoPago == "Libros")
            {
                string Libr = getTotalLibros(fecha);
                decimal libr;
                if (string.Empty == Libr || Libr == null)
                {
                    libr = total;
                }
                else
                {
                    libr = decimal.Parse(Libr);
                    libr += total;
                }
                retorno = updateTotalLibros(fecha, libr);
            }
            else if (tipoPago == "Derecho a Examen")
            {
                string Der = getTotalDerechoExamen(fecha);
                decimal der;
                if(Der == null || string.Empty == Der)
                {
                    der = total;
                }
                else
                {
                    der = decimal.Parse(Der);
                    der += total;
                }
                retorno = updateTotalDerechoExamen(fecha, der);
            }
            else if(tipoPago == "Cuota")
            {
                string cuo = getTotalCuotas(fecha);
                decimal Cuo;
                if(cuo == string.Empty || cuo == null)
                {
                    Cuo = total;
                }
                else
                {
                    Cuo = decimal.Parse(cuo);
                    Cuo += total;
                }
                retorno = updateTotalCuota(fecha, Cuo);
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }

        public static GananciasDB getGanancias(string fecha)
        {
            GananciasDB pG = new GananciasDB();
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("select * from Ganancias where Fecha_Ganancias = '" + fecha + "'", con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pG.ID = int.Parse(re["ID"].ToString());
                        pG.Fecha_Ganancias = Convert.ToDateTime(re["Fecha_Ganancias"]).ToString("dd-MM-yyyy");
                        pG.Libros = Convert.ToDecimal(re["Libros"]);
                        pG.Inscripcion = Convert.ToDecimal(re["Inscripcion"]);
                        pG.Reinscripcion = Convert.ToDecimal(re["Reinscripcion"]);
                        pG.Derecho_Examen = Convert.ToDecimal(re["DerechoExamen"]);
                        pG.Cuota = Convert.ToDecimal(re["Cuota"]);
                        pG.Gastos = Convert.ToDecimal(re["Total_Descuentos"]);
                        pG.Detalles_Gastos = re["DetallesGastos"].ToString();
                        pG.Total_Ganancias = Convert.ToDecimal(re["Total_Ganancias"]);
                        pG.Total_Ingresos = Convert.ToDecimal(re["Ingresos"]);
                    }
                }
                else
                {
                    pG = null;
                }
                con.Close();
            }
            return pG;
        }
        public static int fillNullValues()
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand1 = new SqlCommand("update Ganancias set Libros = 0 where Libros is null", con);
                SqlCommand comand2 = new SqlCommand("update Ganancias set Inscripcion = 0 where Inscripcion is null", con);
                SqlCommand comand3 = new SqlCommand("update Ganancias set Reinscripcion = 0 where Reinscripcion is null", con);
                SqlCommand comand4 = new SqlCommand("update Ganancias set DetallesGastos = 'none' where DetallesGastos is null", con);
                SqlCommand comand5 = new SqlCommand("update Ganancias set Cuota = 0 where Cuota is null", con);
                SqlCommand comand6 = new SqlCommand("update Ganancias set DerechoExamen = 0 where DerechoExamen is null", con);
                r = comand1.ExecuteNonQuery();
                r = comand2.ExecuteNonQuery();
                r = comand3.ExecuteNonQuery();
                r = comand4.ExecuteNonQuery();
                r = comand5.ExecuteNonQuery();
                r = comand6.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}
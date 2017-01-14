using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public class pagoGrupal
    {
        public int Id_grupo { get; set; }
        public string Nombre { get; set; }
        public string ModoPago { get; set; }
        public double pago { get; set; }
        public double mora { get; set; }
        public string FechaUltimoPago { get; set; }
        public string FechaProximoPago { get; set; }


        public pagoGrupal() { }
        public pagoGrupal(int ID, string n, double p, double m, string fup, string fpp, string mp)
        {
            Id_grupo = ID;
            Nombre = n;
            pago = p;
            mora = m;
            FechaUltimoPago = fup;
            FechaProximoPago = fpp;
            ModoPago = mp;
        }

        public static int registerGrupo(pagoGrupal pInfoGrupo)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "registerPagoGrupal";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pInfoGrupo.Nombre;

                comand.Parameters.Add(new SqlParameter("@pago", System.Data.SqlDbType.Money));
                comand.Parameters["@pago"].Value = pInfoGrupo.pago;

                comand.Parameters.Add(new SqlParameter("@mora", System.Data.SqlDbType.Money));
                comand.Parameters["@mora"].Value = pInfoGrupo.mora;

                comand.Parameters.Add(new SqlParameter("@modoPago", System.Data.SqlDbType.VarChar));
                comand.Parameters["@modoPago"].Value = pInfoGrupo.ModoPago;

                comand.Parameters.Add(new SqlParameter("@fechapp", System.Data.SqlDbType.Date));
                comand.Parameters["@fechapp"].Value = pInfoGrupo.FechaProximoPago;

                r = comand.ExecuteNonQuery();
            }
            return r;
        }

        public static int modifyGrupo(pagoGrupal pInfoGrupo)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "modifyPagoGrupal";

                comand.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int));
                comand.Parameters["@Id"].Value = pInfoGrupo.Id_grupo;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pInfoGrupo.Nombre;

                comand.Parameters.Add(new SqlParameter("@pago", System.Data.SqlDbType.Money));
                comand.Parameters["@pago"].Value = pInfoGrupo.pago;

                comand.Parameters.Add(new SqlParameter("@mora", System.Data.SqlDbType.Money));
                comand.Parameters["@mora"].Value = pInfoGrupo.mora;

                comand.Parameters.Add(new SqlParameter("@ModoPago", System.Data.SqlDbType.VarChar));
                comand.Parameters["@ModoPago"].Value = pInfoGrupo.ModoPago;

                r = comand.ExecuteNonQuery();
            }
            return r;
        }

        public static int deletePagoGrupal(int ID)
        {
            int r = -1;
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "deletePagoGrupal";

                comand.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int));
                comand.Parameters["@ID"].Value = ID;

                SqlCommand comand0 = new SqlCommand();
                comand0.Connection = con;
                comand0.CommandType = System.Data.CommandType.StoredProcedure;
                comand0.CommandText = "deletePagoGrupalStudents";

                comand0.Parameters.Add(new SqlParameter("@codigoGrupo", System.Data.SqlDbType.Int));
                comand0.Parameters["@codigoGrupo"].Value = ID;


                r = comand.ExecuteNonQuery();
                r = comand0.ExecuteNonQuery();
            }
            return r;
        }

        public static List<pagoGrupal> listAllGrupos()
        {
            List<pagoGrupal> list = new List<pagoGrupal>();
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;
                comand.CommandText = "listAllPagoGrupal";

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pagoGrupal pIngoGrupos = new pagoGrupal();

                    pIngoGrupos.Id_grupo = Convert.ToInt32(reader["cod"].ToString());
                    pIngoGrupos.Nombre = reader["nom"].ToString();
                    pIngoGrupos.pago = Convert.ToDouble(reader["p"].ToString());
                    pIngoGrupos.mora = Convert.ToDouble(reader["m"].ToString());
                    pIngoGrupos.ModoPago = reader["mp"].ToString();

                    if (reader["fpp"].ToString() == null || reader["fpp"].ToString() == string.Empty)
                    {
                        pIngoGrupos.FechaProximoPago = "none";
                    }
                    else
                    {
                        pIngoGrupos.FechaProximoPago = reader["fpp"].ToString();
                    }

                    if (reader["fup"].ToString() == null || reader["fup"].ToString() == string.Empty)
                    {
                        pIngoGrupos.FechaUltimoPago = "none";
                    }
                    else
                    {
                        pIngoGrupos.FechaUltimoPago = reader["fup"].ToString();
                    }

                    list.Add(pIngoGrupos);
                }
                con.Close();
            }
            return list;
        }

        public static List<pagoGrupal> searchGrupos(string matricula, string nombre)
        {
            List<pagoGrupal> list = new List<pagoGrupal>();
            using (SqlConnection con =DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;
                comand.CommandText = "searchPagoGrupal";

                comand.Parameters.Add(new SqlParameter("@codigoGrupo", System.Data.SqlDbType.VarChar));
                comand.Parameters["@codigoGrupo"].Value = matricula;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pagoGrupal pIngoGrupos = new pagoGrupal();

                    pIngoGrupos.Id_grupo = Convert.ToInt32(reader["cod"].ToString());
                    pIngoGrupos.Nombre = reader["nom"].ToString();
                    pIngoGrupos.pago = Convert.ToDouble(reader["p"].ToString());
                    pIngoGrupos.mora = Convert.ToDouble(reader["m"].ToString());
                    pIngoGrupos.ModoPago = reader["mp"].ToString();

                    if (reader["fpp"].ToString() == null || reader["fpp"].ToString() == string.Empty)
                    {
                        pIngoGrupos.FechaProximoPago = "none";
                    }
                    else
                    {
                        pIngoGrupos.FechaProximoPago = reader["fpp"].ToString();
                    }

                    if (reader["fup"].ToString() == null || reader["fup"].ToString() == string.Empty)
                    {
                        pIngoGrupos.FechaUltimoPago = "none";
                    }
                    else
                    {
                        pIngoGrupos.FechaUltimoPago = reader["fup"].ToString();
                    }


                    list.Add(pIngoGrupos);
                }
                con.Close();
            }
            return list;
        }

        public static pagoGrupal getPagoGrupal(int matricula)
        {
            pagoGrupal pIngoGrupos = new pagoGrupal();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;
                comand.CommandText = "getPagoGrupal";

                comand.Parameters.Add(new SqlParameter("@codigoGrupo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoGrupo"].Value = matricula;

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {

                    pIngoGrupos.Id_grupo = Convert.ToInt32(reader["cod"].ToString());
                    pIngoGrupos.Nombre = reader["nom"].ToString();
                    pIngoGrupos.pago = Convert.ToDouble(reader["p"].ToString());
                    pIngoGrupos.mora = Convert.ToDouble(reader["m"].ToString());
                    pIngoGrupos.ModoPago = reader["mp"].ToString();
                    pIngoGrupos.FechaProximoPago = reader["fpp"].ToString();
                    pIngoGrupos.FechaUltimoPago = reader["fup"].ToString();


                }
                con.Close();
            }
            return pIngoGrupos;
        }

        public static int anadirEstudiante(int matriculaEstu, int codigoGrupo, string fechaProximoPago)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "anadirEstudianteGrupo";

                comand.Parameters.Add(new SqlParameter("@codigoGrupo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoGrupo"].Value = codigoGrupo;

                comand.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.Int));
                comand.Parameters["@matricula"].Value = matriculaEstu;

                r = comand.ExecuteNonQuery();

                SqlCommand comand0 = new SqlCommand();
                comand0.Connection = con;
                comand0.CommandType = System.Data.CommandType.StoredProcedure;
                comand0.CommandText = "updatefppGrupo";

                comand0.Parameters.Add(new SqlParameter("@fecha", System.Data.SqlDbType.Date));
                comand0.Parameters["@fecha"].Value = fechaProximoPago;

                comand0.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand0.Parameters["@codigo"].Value = codigoGrupo;

                r = comand0.ExecuteNonQuery();

                con.Close();
            }
            return r;
        }

        public static int modifyfup(int codigoGrupo, DateTime fechaUltimoPago)
        {
            int r = -1;
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "updatefupPagoGrupal";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@fecha", System.Data.SqlDbType.DateTime));
                comand.Parameters["@fecha"].Value = fechaUltimoPago;

                comand.Parameters.Add(new SqlParameter("@codigoGrupo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoGrupo"].Value = codigoGrupo;

                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Cely_Sistema
{
    public partial class frmReporte : Form
    {
        public string Matricula { get; set; }
        public string ModoPago { get; set; }
        public string VIP { get; set; }
        public string codigoFactura { get; set; }
        public string TipoReporte { get; set; }

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            if (TipoReporte == "Contrato")
            {
                LoadReport();
            }
            else if(TipoReporte == "Factura")
            {

            }
            else
            {
                MessageBox.Show("No se Reconoce el Reporte a cargar, esta ventana se cerrara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            this.reportViewer1.RefreshReport();
        }
        private void LoadReport()
        {
            if(VIP == "NO" || VIP == "No")
            {
                // for non VIP Students.
                if(ModoPago == "Mensual")
                {
                    // when payment is monthly
                    DataTable dtPagoMensual = reportes.contratoEstudianteMensual(Matricula);
                    reportViewer1.Reset();
                    reportViewer1.LocalReport.ReportPath = "Contrato.rdlc";
                    ReportDataSource ds = new ReportDataSource("Contrato", dtPagoMensual);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.Refresh();
                }
                else
                {
                    // when payment is weekly
                    DataTable dtPagoSemanal = reportes.contratoEstudianteSemanal(Matricula);
                    reportViewer1.Reset();
                    reportViewer1.LocalReport.ReportPath = "Contrato.rdlc";
                    ReportDataSource ds = new ReportDataSource("Contrato", dtPagoSemanal);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.Refresh();
                }
            }
            else
            {
                // for VIP Students.
                if(ModoPago == "Mensual")
                {
                    // when payment is monthly
                    DataTable dtPagoVIPMensual = reportes.contratoEstudianteVIPMensual(Matricula);
                    reportViewer1.Reset();
                    reportViewer1.LocalReport.ReportPath = "Contrato.rdlc";
                    ReportDataSource ds = new ReportDataSource("Contrato", dtPagoVIPMensual);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.Refresh();
                }
                else
                {
                    // when payment is weekly
                    DataTable dtPagoVIPSemanal = reportes.contratoEstudianteVIPSemanal(Matricula);
                    reportViewer1.Reset();
                    reportViewer1.LocalReport.ReportPath = "Contrato.rdlc";
                    ReportDataSource ds = new ReportDataSource("Contrato", dtPagoVIPSemanal);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.Refresh();
                }
            }
        }
        private void LoadFactura()
        {

        }
    }
}

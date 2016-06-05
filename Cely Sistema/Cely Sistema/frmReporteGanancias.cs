using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cely_Sistema
{
    public partial class frmReporteGanancias : Form
    {
        public frmReporteGanancias()
        {
            InitializeComponent();
        }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        private void frmReporteGanancias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.ReporteGanancias' table. You can move, or remove it, as needed.
            this.ReporteGananciasTableAdapter.Fill(this.Reporting.ReporteGanancias, fechaDesde, fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class frmFacturaSemanal : Form
    {
        public frmFacturaSemanal()
        {
            InitializeComponent();
        }
        public int matricula { get; set; }
        private void frmFacturaSemanal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.Reporting.Factura, matricula);

            this.reportViewer1.RefreshReport();
        }
    }
}

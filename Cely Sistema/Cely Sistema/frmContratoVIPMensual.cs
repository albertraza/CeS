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
    public partial class frmContratoVIPMensual : Form
    {
        public frmContratoVIPMensual()
        {
            InitializeComponent();
        }
        public int matricula { get; set; }
        private void frmContratoVIPMensual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.ContratoVIPMensual' table. You can move, or remove it, as needed.
            this.ContratoVIPMensualTableAdapter.Fill(this.Reporting.ContratoVIPMensual, matricula);
            this.reportViewer1.RefreshReport();
        }
    }
}

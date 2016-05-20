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
    public partial class frmContratoMensual : Form
    {
        public frmContratoMensual()
        {
            InitializeComponent();
        }
        public int matricula { get; set; }
        private void frmContratoMensual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.ContratoMensual' table. You can move, or remove it, as needed.
            this.ContratoMensualTableAdapter.Fill(this.Reporting.ContratoMensual, matricula);
            this.reportViewer1.RefreshReport();
        }
    }
}

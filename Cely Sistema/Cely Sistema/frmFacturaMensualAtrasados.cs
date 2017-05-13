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
    public partial class frmFacturaMensualAtrasados : Form
    {
        public frmFacturaMensualAtrasados()
        {
            InitializeComponent();
        }

        public int pMatricula { get; set; }

        private void frmFacturaMensualAtrasados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.FacturaEstudiantil' table. You can move, or remove it, as needed.
            this.FacturaEstudiantilTableAdapter.Fill(this.Reporting.FacturaEstudiantil, pMatricula);

            this.reportViewer1.RefreshReport();
        }
    }
}

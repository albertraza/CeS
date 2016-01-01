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
    public partial class frmImpresionFactura : Form
    {
        public frmImpresionFactura()
        {
            InitializeComponent();
        }

        public int Matricula { get; set; }
        public DateTime Fecha { get; set; }
        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CelyDBDataSet.FacturaEstudiantil' Puede moverla o quitarla según sea necesario.
            this.FacturaEstudiantilTableAdapter.Fill(this.CelyDBDataSet.FacturaEstudiantil, Matricula, Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}

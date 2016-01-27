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
    public partial class frmReportedeNotas : Form
    {
        public frmReportedeNotas()
        {
            InitializeComponent();
        }

        public DateTime fechaD { get; set; }
        public DateTime fechaH { get; set; }
        public string matricula { get; set; }
        private void frmReportedeNotas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'CelyDBDataSet.ReporteCalificacionesTo1' Puede moverla o quitarla según sea necesario.
                // TODO: esta línea de código carga datos en la tabla 'CelyDBDataSet.ReporteCalificacionesTo' Puede moverla o quitarla según sea necesario.


                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
        public int matricula { get; set; }
        private void frmReportedeNotas_Load(object sender, EventArgs e)
        {
            matricula = 11036;
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'CelyDBDataSet.ReporteCalificacionesTo1' Puede moverla o quitarla según sea necesario.
                this.ReporteNotasDeHastaTableAdapter.Fill(this.CelyDBDataSet.ReporteNotasDeHasta, fechaD, fechaH, matricula);
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

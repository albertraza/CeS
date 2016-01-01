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
    public partial class frmReporteNotasEstudiantes : Form
    {
        public frmReporteNotasEstudiantes()
        {
            InitializeComponent();
        }

        public int matricula {get; set;}
        public DateTime Fecha { get; set; }
        private void frmReporteNotasEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'CelyDBDataSet.VerReporteNotas' Puede moverla o quitarla según sea necesario.
                this.VerReporteNotasTableAdapter.Fill(this.CelyDBDataSet.VerReporteNotas, matricula, Fecha);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

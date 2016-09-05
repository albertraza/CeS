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
    public partial class frmReporteEstudiantePorNivel : Form
    {
        // propiedad para guardar el codigo del nivel
        public int NoNivel { get; set; }

        public frmReporteEstudiantePorNivel()
        {
            InitializeComponent();
        }

        private void frmReporteEstudiantePorNivel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CelyDBDataSet.reporteEstudiantesPorNivel' table. You can move, or remove it, as needed.
            this.reporteEstudiantesPorNivelTableAdapter.Fill(this.CelyDBDataSet.reporteEstudiantesPorNivel, NoNivel);

            this.reportViewer1.RefreshReport();
        }
    }
}

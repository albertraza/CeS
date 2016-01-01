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
    public partial class frmReporteCalificacionesTo : Form
    {
        public frmReporteCalificacionesTo()
        {
            InitializeComponent();
        }

        private void btnGeneralReporte_Click(object sender, EventArgs e)
        {
            frmReportedeNotas pR = new frmReportedeNotas();
            pR.fechaD = dtpDesde.Value.Date;
            pR.fechaH = dtpHasta.Value.Date;
            pR.ShowDialog();
        }

        private void dtpDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpHasta.Focus();
            }
        }

        private void dtpHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                frmReportedeNotas pR = new frmReportedeNotas();
                pR.fechaD = dtpDesde.Value.Date;
                pR.fechaH = dtpHasta.Value.Date;
                pR.ShowDialog();
            }
        }

        private void frmReporteCalificacionesTo_Load(object sender, EventArgs e)
        {

        }
    }
}

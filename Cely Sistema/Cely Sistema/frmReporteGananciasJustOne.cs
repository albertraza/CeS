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
    public partial class frmReporteGananciasJustOne : Form
    {
        public frmReporteGananciasJustOne()
        {
            InitializeComponent();
        }
        public DateTime fechaReporte { get; set; }
        private void frmReporteGananciasJustOne_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.GananciasOneDay' table. You can move, or remove it, as needed.
            this.GananciasOneDayTableAdapter.Fill(this.Reporting.GananciasOneDay, fechaReporte);

            this.reportViewer1.RefreshReport();
        }
    }
}

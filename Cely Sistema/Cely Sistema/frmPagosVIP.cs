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
    public partial class frmPagosVIP : Form
    {
        public frmPagosVIP()
        {
            InitializeComponent();
        }

        private void frmPagosVIP_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPagosVIP.DataSource = MoraDB.VerMorayPagosVIP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class frmDescuentoFacturacion : Form
    {
        public frmDescuentoFacturacion()
        {
            InitializeComponent();
        }

        private void frmDescuentoFacturacion_Load(object sender, EventArgs e)
        {
            txtDescuento.Focus();
        }

        public string Descuento { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Descuento = txtDescuento.Text;
            this.Close();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Descuento = txtDescuento.Text;
                this.Close();
            }
        }
    }
}

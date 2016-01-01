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
    public partial class frmFacturasA : Form
    {
        public frmFacturasA()
        {
            InitializeComponent();
        }

        private void frmFacturasA_Load(object sender, EventArgs e)
        {
            try
            {
                double GA = Convert.ToDouble(GananciasDB.ObtenerCantidad(DateTime.Today.Date.ToString("yyyy-MM-dd")));
                lblTotalRecaudado.Text = lblTotalRecaudado.Text + " " + "$" + GA.ToString("f2");
                dgvTabla.DataSource = FacturacionDB.TodasLasFacturas(DateTime.Today.Date.ToString("yyyy-MM-dd"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTabla.DataSource = FacturacionDB.TodasLasFacturas(dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    dgvTabla.DataSource = FacturacionDB.TodasLasFacturas(dtpFecha.Value.ToString("yyyy-MM-dd"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

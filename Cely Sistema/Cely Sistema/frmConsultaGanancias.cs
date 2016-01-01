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
    public partial class frmConsultaGanancias : Form
    {
        public frmConsultaGanancias()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            dtpFechaGanancias.Value = DateTime.Today;
            dgvGanancias.DataSource = "";
        }
        private void frmConsultaGanancias_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha;
            if (dtpFechaGanancias.Value.Date == DateTime.Today.Date)
            {
                fecha = "";
            }
            else
            {
                fecha = dtpFechaGanancias.Value.Date.ToString("yyyy-MM-dd");
            }
            try
            {
                dgvGanancias.DataSource = GananciasDB.Buscar(fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtpFechaGanancias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string fecha;
                if (dtpFechaGanancias.Value.Date == DateTime.Today.Date)
                {
                    fecha = "";
                }
                else
                {
                    fecha = dtpFechaGanancias.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvGanancias.DataSource = GananciasDB.Buscar(fecha);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

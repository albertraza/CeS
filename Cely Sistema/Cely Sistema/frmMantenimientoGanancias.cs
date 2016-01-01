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
    public partial class frmMantenimientoGanancias : Form
    {
        public frmMantenimientoGanancias()
        {
            InitializeComponent();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string R = GananciasDB.ObtenerTotalIngresos(dtpFecha.Value.ToString("yyyy-MM-dd"));
                if (R != null & R != string.Empty)
                {
                    string R1 = GananciasDB.ObtenerCantidad(dtpFecha.Value.ToString("yyyy-MM-dd"));
                    double T1 = double.Parse(R1);
                    txtTotalIngresos.Text = T1.ToString("f2");
                    txtTotalIngresos.Enabled = false;
                    double T = double.Parse(R);
                    txtTotalGanancias.Text = T.ToString("f2");
                    txtTotalGanancias.Enabled = false;
                    string R0 = GananciasDB.ObtenerDescuentos(dtpFecha.Value.ToString("yyyy-MM-dd"));
                    double T0 = double.Parse(R0);
                    txtDescuentos.Text = T0.ToString("f2");
                }
                else
                {
                    DateTime fecha = dtpFecha.Value;
                    double G = Double.Parse(GananciasDB.ObtenerCantidad(fecha.Date.ToString("yyyy-MM-dd")));
                    txtTotalIngresos.Text = G.ToString("f2");
                    txtTotalIngresos.Enabled = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se Registraron Ingresos en Ese dia", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalIngresos.Text == string.Empty)
                {
                    MessageBox.Show("No se han Registrado ingresos", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTotalIngresos.Focus();
                }
                else if (txtDescuentos.Text == string.Empty)
                {
                    MessageBox.Show("No se han detectado descuentos, Digite una cantidad valida", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescuentos.Focus();
                }
                else
                {
                    double TI, D, TG;
                    TI = double.Parse(txtTotalIngresos.Text);
                    D = double.Parse(txtDescuentos.Text);
                    TG = TI - D;
                    txtTotalGanancias.Text = TG.ToString("f2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMantenimientoGanancias_Load(object sender, EventArgs e)
        {
            try
            {
                txtTotalIngresos.Enabled = false;
                txtTotalGanancias.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FechaA = dtpFecha.Value;
                string R0 = GananciasDB.ObtenerDescuentos(FechaA.Date.ToString("yyyy-MM-dd"));
                if (R0 != null & R0 != string.Empty)
                {
                    double pTotalDescuentos, pTotalGanancias, pTotalIngresos, Descuentos;
                    pTotalDescuentos = Double.Parse(R0);
                    Descuentos = double.Parse(txtDescuentos.Text);
                    pTotalDescuentos = Descuentos + pTotalDescuentos;
                    txtDescuentos.Text = pTotalDescuentos.ToString("f2");
                    pTotalIngresos = double.Parse(txtTotalIngresos.Text);
                    pTotalGanancias = pTotalIngresos - pTotalDescuentos;
                    txtTotalGanancias.Text = pTotalGanancias.ToString("f2");
                    int R = GananciasDB.RegistrarIngresos(pTotalDescuentos, pTotalGanancias, FechaA.Date.ToString("yyyy-MM-dd"));
                    if (R > 0)
                    {
                        MessageBox.Show("Registro Exitoso!", "Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar, Intentelo Nuevamente", "Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    double pTD, pTG, pTI;
                    pTI = double.Parse(txtTotalIngresos.Text);
                    pTD = double.Parse(txtDescuentos.Text);
                    pTG = pTI - pTD;
                    int R = GananciasDB.RegistrarIngresos(pTD, pTG, FechaA.Date.ToString("yyyy-MM-dd"));
                    if (R > 0)
                    {
                        MessageBox.Show("Registro Exitoso!", "Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Registrar, Intentalo Nuevamente", "Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescuentos.Clear();
            txtTotalGanancias.Clear();
            dtpFecha.Value = DateTime.Today;
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescuentos.Focus();
            }
        }

        private void txtDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtTotalIngresos.Text == string.Empty)
                    {
                        MessageBox.Show("No se han Registrado ingresos", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTotalIngresos.Focus();
                    }
                    else if (txtDescuentos.Text == string.Empty)
                    {
                        MessageBox.Show("No se han detectado descuentos, Digite una cantidad valida", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescuentos.Focus();
                    }
                    else
                    {
                        double TI, D, TG;
                        TI = double.Parse(txtTotalIngresos.Text);
                        D = double.Parse(txtDescuentos.Text);
                        TG = TI - D;
                        txtTotalGanancias.Text = TG.ToString("f2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

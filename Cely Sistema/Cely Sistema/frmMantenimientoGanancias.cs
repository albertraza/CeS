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
        private void LoadData()
        {
            GananciasDB Ganancias = GananciasDB.getGanancias(dtpFecha.Value.Date.ToString("yyyy-MM-dd"));
            if (Ganancias != null)
            {
                txtCuota.Text = Ganancias.Cuota.ToString("f2");
                txtDerechoExamen.Text = Ganancias.Derecho_Examen.ToString("f2");
                txtDetallesGastos.Text = Ganancias.Detalles_Gastos;
                txtGastos.Text = "0.00";
                txtInscripcion.Text = Ganancias.Inscripcion.ToString("f2");
                txtLibros.Text = Ganancias.Libros.ToString("f2");
                txtReinscripcion.Text = Ganancias.Reinscripcion.ToString("f2");
                txtTotalGanancias.Text = Ganancias.Total_Ganancias.ToString("f2");
                txtTotalIngresos.Text = Ganancias.Total_Ingresos.ToString("f2");
            }
            else
            {
                MessageBox.Show("No se ha registrado una ganacia en ese dia", "Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public frmMantenimientoGanancias()
        {
            InitializeComponent();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception)
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
                else if (txtGastos.Text == string.Empty)
                {
                    MessageBox.Show("No se han detectado descuentos, Digite una cantidad valida", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGastos.Focus();
                }
                else
                {
                    double TI, TG, TD;
                    TD = double.Parse(GananciasDB.ObtenerDescuentos(dtpFecha.Value.Date.ToString("yyyy-MM-dd")));
                    TI = double.Parse(txtTotalIngresos.Text);
                    TD += double.Parse(txtGastos.Text);
                    TG = TI - TD;
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
                GananciasDB.fillNullValues();
                GananciasDB.updateDescuentos();
                GananciasDB.updateTotalGanancias();
                txtCuota.Enabled = false;
                txtDerechoExamen.Enabled = false;
                txtInscripcion.Enabled = false;
                txtLibros.Enabled = false;
                txtReinscripcion.Enabled = false;
                txtTotalIngresos.Enabled = false;
                txtTotalGanancias.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FechaA = dtpFecha.Value;
                string R0 = GananciasDB.ObtenerDescuentos(dtpFecha.Value.Date.ToString("yyyy-MM-dd"));
                if (R0 != null & R0 != string.Empty)
                {
                    double pTotalDescuentos, pTotalGanancias, pTotalIngresos, Descuentos;
                    pTotalDescuentos = Double.Parse(R0);
                    Descuentos = double.Parse(txtGastos.Text);
                    pTotalDescuentos = Descuentos + pTotalDescuentos;
                    txtGastos.Text = pTotalDescuentos.ToString("f2");
                    pTotalIngresos = double.Parse(txtTotalIngresos.Text);
                    pTotalGanancias = pTotalIngresos - pTotalDescuentos;
                    txtTotalGanancias.Text = pTotalGanancias.ToString("f2");
                    int R = GananciasDB.RegistrarIngresos(pTotalDescuentos, pTotalGanancias, FechaA.Date.ToString("yyyy-MM-dd"));
                    if (R > 0 && GananciasDB.updateTotalDetallesGastos(dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtDetallesGastos.Text) > 0)
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
                    pTD = double.Parse(txtGastos.Text);
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
            txtGastos.Clear();
            txtTotalGanancias.Clear();
            dtpFecha.Value = DateTime.Today;
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtGastos.Focus();
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
                    else if (txtGastos.Text == string.Empty)
                    {
                        MessageBox.Show("No se han detectado descuentos, Digite una cantidad valida", "Informacion Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtGastos.Focus();
                    }
                    else
                    {
                        double TI, D, TG;
                        TI = double.Parse(txtTotalIngresos.Text);
                        D = double.Parse(txtGastos.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

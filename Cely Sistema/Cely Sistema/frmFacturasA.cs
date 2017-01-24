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

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvTabla.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvTabla.CurrentRow.Cells[0].Value);
                    int codigoFactura = Convert.ToInt32(dgvTabla.CurrentRow.Cells[6].Value);

                    if(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(id)).Modo_Pago != null)
                    {
                        EstudianteBase pEstudiante = EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(id));
                        if (pEstudiante.Modo_Pago == "Mensual")
                        {
                            frmFacturaMensual pFactura = new frmFacturaMensual();
                            pFactura.matricula = codigoFactura;
                            pFactura.ShowDialog();
                        }
                        else if (pEstudiante.Modo_Pago == "Semanal")
                        {
                            frmFacturaSemanal pFactura = new frmFacturaSemanal();
                            pFactura.matricula = codigoFactura;
                            pFactura.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo identificar el modo de pago estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (pagoGrupal.getPagoGrupal(id).ModoPago == null)
                        {
                            MessageBox.Show("No existe el grupo y el Estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            pagoGrupal pinfoGrupo = pagoGrupal.getPagoGrupal(id);

                            if (pinfoGrupo.ModoPago == "Mensual")
                            {
                                frmFacturaMensual pFactura = new frmFacturaMensual();
                                pFactura.matricula = codigoFactura;
                                pFactura.ShowDialog();
                            }
                            else if (pinfoGrupo.ModoPago == "Semanal")
                            {
                                frmFacturaSemanal pFactura = new frmFacturaSemanal();
                                pFactura.matricula = codigoFactura;
                                pFactura.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo identificar el modo de pago grupo" + pinfoGrupo.ModoPago, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una factura para imprimir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

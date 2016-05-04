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
    public partial class frmCancelacionPago : Form
    {
        public frmCancelacionPago()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoFactura.Text == string.Empty)
                {
                    MessageBox.Show("Complete el Codigo de la factura", "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int IDF = int.Parse(txtCodigoFactura.Text);
                    dgvFactura.DataSource = FacturacionDB.BuscarfacturasCP(IDF);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigoFactura.Clear();
                dgvFactura.ClearSelection();
                txtTotalRemborso.Enabled = false;
                txtTotalRemborso.Text = "0";
                nCant.Value = 0;
                btnCancelarPago.Enabled = false;
                dgvFactura.DataSource = FacturacionDB.TodasLasFacturasND();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int Retorno { get; set; }
        private int Matricula;
        private int IDFactura;
        private DateTime FechaFactura;
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Cancelar el Pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (dgvFactura.SelectedRows.Count == 1)
                    {
                        if (txtCodigoFactura.Text != string.Empty)
                        {
                            Matricula = Convert.ToInt32(dgvFactura.CurrentRow.Cells[1].Value);
                            IDFactura = Convert.ToInt32(dgvFactura.CurrentRow.Cells[0].Value);
                            FechaFactura = Convert.ToDateTime(dgvFactura.CurrentRow.Cells[4].Value);
                        }
                        else
                        {
                            Matricula = Convert.ToInt32(dgvFactura.CurrentRow.Cells[1].Value);
                            IDFactura = Convert.ToInt32(dgvFactura.CurrentRow.Cells[6].Value);
                            FechaFactura = Convert.ToDateTime(dgvFactura.CurrentRow.Cells[3].Value);
                        }
                        if (FacturacionDB.ObtenerCancelacionPago(IDFactura) == "0")
                        {
                            int r = 0;
                            string Modopago = EstudianteDB.ObtenerModoPago(Matricula);
                            DateTime FechaPago = EstudianteDB.ObtenerFechaProximoPago(Matricula);
                            double Pago = FacturacionDB.ObtenerCantidadPagada(IDFactura);
                            double ganancias = Convert.ToDouble(GananciasDB.ObtenerCantidad(FechaFactura.ToString("yyyy-MM-dd")));
                            ganancias -= double.Parse(txtTotalRemborso.Text);
                            int R01 = GananciasDB.ActualizarGananciasF(FechaFactura.ToString("yyyy-MM-dd"), Convert.ToDecimal(ganancias));
                            int R02 = 0;
                            if (Modopago == "Mensual")
                            {
                                int Days = 30 * Convert.ToInt32(nCant.Value);
                                TimeSpan TimeS = TimeSpan.FromDays(Days);
                                FechaPago = FechaPago.Subtract(TimeS);
                                r = EstudianteDB.ActualizarProximoPago(Matricula, FechaPago.ToString("yyyy-MM-dd"));
                                R02 = FacturacionDB.CancelarPago(IDFactura, "Remborso " + nCant.Value.ToString() + " Meses");
                            }
                            else if (Modopago == "Semanal")
                            {
                                int Days = 7 * Convert.ToInt32(nCant.Value);
                                TimeSpan TimeS = TimeSpan.FromDays(Days);
                                FechaPago = FechaPago.Subtract(TimeS);
                                r = EstudianteDB.ActualizarProximoPago(Matricula, FechaPago.ToString("yyyy-MM-dd"));
                                R02 = FacturacionDB.CancelarPago(IDFactura, "Remborso " + nCant.Value.ToString() + " Semanas");
                            }

                            if(r > 0 && R02 > 0 && R01 > 0)
                            {
                                MessageBox.Show("El Pago fue cancelado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cancelar el pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Pago ya fue cancelado", "Cancelacion de pagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una factura de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private string CodigoFactura;
        public string getCodigo
        {
            get { return CodigoFactura; }
            set { CodigoFactura = value; }
        }
        private void frmCancelacionPago_Load(object sender, EventArgs e)
        {
            if (CodigoFactura != null)
            {
                try
                {
                    txtCodigoFactura.Focus();
                    dgvFactura.DataSource = FacturacionDB.BuscarfacturasCP(int.Parse(CodigoFactura));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    dgvFactura.DataSource = FacturacionDB.TodasLasFacturasND();
                    txtTotalRemborso.Enabled = false;
                    txtTotalRemborso.Text = "0";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCodigoFactura.Text == string.Empty)
                    {
                        MessageBox.Show("Complete el Codigo de la factura", "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    int IDF = int.Parse(txtCodigoFactura.Text);
                    dgvFactura.DataSource = FacturacionDB.BuscarfacturasCP(IDF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lblModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTotalRemborso.Enabled = true;
        }

        // method for getting data ready when a bill is selected.
        private void LoadValues()
        {
            if (dgvFactura.SelectedRows.Count == 1)
            {
                try
                {
                    if (txtCodigoFactura.Text != null)
                    {
                        Int32 ID = int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString());
                        nCant.Value = FacturacionDB.ObtenerCantSemanasMesesPagos(ID);
                        double CantPagada = FacturacionDB.ObtenerCantidadPagada(ID);
                        double pagoMensualSemanal = CantPagada / (FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                        int CantRemborso = Convert.ToInt32(nCant.Value);
                        double totalRemborso = pagoMensualSemanal * CantRemborso;
                        txtTotalRemborso.Clear();
                        txtTotalRemborso.Text = totalRemborso.ToString("f2");
                    }
                    else
                    {
                        Int32 ID = int.Parse(dgvFactura.CurrentRow.Cells[6].Value.ToString());
                        nCant.Value = FacturacionDB.ObtenerCantSemanasMesesPagos(ID);
                        double CantPagada = FacturacionDB.ObtenerCantidadPagada(ID);
                        double pagoMensualSemanal = CantPagada / (FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                        int CantRemborso = Convert.ToInt32(nCant.Value);
                        double totalRemborso = pagoMensualSemanal * CantRemborso;
                        txtTotalRemborso.Clear();
                        txtTotalRemborso.Text = totalRemborso.ToString("f2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSeleccionarFactura_Click(object sender, EventArgs e)
        {
            LoadValues();
        }

        private void nCant_ValueChanged(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count == 1)
            {
                try
                {
                    if (txtCodigoFactura.Text != null)
                    {
                        Int32 ID = int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString());
                        double CantPagada = FacturacionDB.ObtenerCantidadPagada(ID);
                        if (FacturacionDB.ObtenerCantSemanasMesesPagos(ID) >= Convert.ToInt32(nCant.Value))
                        {
                            double pagoMensualSemanal = CantPagada / (FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                            int CantRemborso = Convert.ToInt32(nCant.Value);
                            double totalRemborso = pagoMensualSemanal * CantRemborso;
                            txtTotalRemborso.Clear();
                            txtTotalRemborso.Text = totalRemborso.ToString("f2");
                        }
                        else
                        {
                            MessageBox.Show("Ya se ha excedido del maximo pagado en ese dia", "Mensaje", MessageBoxButtons.OK);
                            nCant.Value = Convert.ToInt32(FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                        }
                    }
                    else
                    {
                        Int32 ID = int.Parse(dgvFactura.CurrentRow.Cells[6].Value.ToString());
                        double CantPagada = FacturacionDB.ObtenerCantidadPagada(ID);
                        if (FacturacionDB.ObtenerCantSemanasMesesPagos(ID) >= Convert.ToInt32(nCant.Value))
                        {
                            double pagoMensualSemanal = CantPagada / (FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                            int CantRemborso = Convert.ToInt32(nCant.Value);
                            double totalRemborso = pagoMensualSemanal * CantRemborso;
                            txtTotalRemborso.Clear();
                            txtTotalRemborso.Text = totalRemborso.ToString("f2");
                        }
                        else
                        {
                            MessageBox.Show("Ya se ha excedido del maximo pagado en ese dia", "Mensaje", MessageBoxButtons.OK);
                            nCant.Value = Convert.ToInt32(FacturacionDB.ObtenerCantSemanasMesesPagos(ID));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Cancelar el Pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (dgvFactura.SelectedRows.Count == 1)
                    {
                        int ID;
                        ID = Convert.ToInt32(dgvFactura.CurrentRow.Cells[0].Value);
                        if (FacturacionDB.ObtenerCancelacionPago(ID) == "0")
                        {
                            int R = FacturacionDB.CancelarPago(ID, "Cancelado");
                            DateTime FechaFactura = Convert.ToDateTime(dgvFactura.CurrentRow.Cells[4].Value);
                            int Matricula = Convert.ToInt32(dgvFactura.CurrentRow.Cells[1].Value);
                            Decimal Ganancia = Convert.ToDecimal(GananciasDB.ObtenerCantidad(FechaFactura.Date.ToString("yyyy-MM-dd")));
                            Decimal Pago = Convert.ToDecimal(dgvFactura.CurrentRow.Cells[3].Value);
                            decimal NuevaGanancia = Ganancia - Pago;
                            int R0 = GananciasDB.ActualizarGananciasF(FechaFactura.Date.ToString("yyyy-MM-dd"), NuevaGanancia);
                            DateTime FP = Convert.ToDateTime(EstudianteDB.ObtenerFechaProximoPago(Matricula));
                            string Modopago = EstudianteDB.ObtenerModoPago(Matricula);
                            if (Modopago == "Mensual")
                            {
                                DateTime Time = FP;
                                TimeSpan Tiempo = TimeSpan.FromDays(30);
                                Time = Time.Subtract(Tiempo);
                                int R2 = EstudianteDB.ActualizarProximoPago(Matricula, Time.ToString("yyyy-MM-dd"));
                                Retorno = R2;
                            }
                            else if (Modopago == "Semanal")
                            {
                                DateTime Time = FP;
                                TimeSpan Tiempo = TimeSpan.FromDays(7);
                                Time = Time.Subtract(Tiempo);
                                int R2 = EstudianteDB.ActualizarProximoPago(Matricula, Time.ToString("yyyy-MM-dd"));
                                Retorno = R2;
                            }
                            if (R > 0 & R0 > 0 & Retorno > 0)
                            {
                                MessageBox.Show("Pago Cancelado!", "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un Error", "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Pago ya fue Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecciona una factura de la lista", "Cancelacion Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

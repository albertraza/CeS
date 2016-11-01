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
    public partial class frmMontoPagosyMora : Form
    {
        private void disableCheckBoxes()
        {
            cbMoraPagoMensual.Checked = false;
            cbMoraPagoMensualVIP.Checked = false;
            cbMoraPagoSemanal.Checked = false;
            cbMoraPagoSemanalVIP.Checked = false;
            cbPagoMensual.Checked = false;
            cbPagoMensualVIP.Checked = false;
            cbPagoSemanal.Checked = false;
            cbPagoSemanalVIP.Checked = false;
        }
        private void disableInputs()
        {
            txtMoraPagoMensual.Enabled = false;
            txtMoraPagoMensualVIP.Enabled = false;
            txtMoraPagoSemanal.Enabled = false;
            txtMoraPagoSemanalVIP.Enabled = false;
            txtPagoMensual.Enabled = false;
            txtPagoMensualVIP.Enabled = false;
            txtPagoSemanal.Enabled = false;
            txtPagoSemanalVIP.Enabled = false;
        }

        private void loadPrices()
        {
            txtPagoMensual.Text = PagosDB.ObtenerPagoMensual().ToString("f2");
            txtPagoSemanal.Text = PagosDB.ObtenerPagoSemanal().ToString("f2");

            txtMoraPagoMensual.Text = Convert.ToDouble(MoraDB.ObtenerMoraMensual()).ToString("f2");
            txtMoraPagoSemanal.Text = Convert.ToDouble(MoraDB.ObtenerMoraSemanal()).ToString("f2");

            txtPagoMensualVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual).ToString("f2");
            txtPagoSemanalVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal).ToString("f2");

            txtMoraPagoMensualVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Mensual).ToString("f2");
            txtMoraPagoSemanalVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Semanal).ToString("f2");

        }

        public frmMontoPagosyMora()
        {
            InitializeComponent();
        }

        private void frmMontoPagosyMora_Load(object sender, EventArgs e)
        {
            try
            {
                disableInputs();
                loadPrices();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que Desea Modificar la Tarifa?", "Pagos y Mora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txtMoraPagoMensual.Text == string.Empty || txtMoraPagoSemanal.Text == string.Empty || txtPagoMensual.Text == string.Empty || txtPagoSemanal.Text == string.Empty)
                    {
                        MessageBox.Show("Complete todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(!cbMoraPagoMensual.Checked & !cbMoraPagoSemanal.Checked & !cbPagoMensual.Checked & !cbPagoSemanal.Checked)
                    {
                        MessageBox.Show("No hay ningun precio a modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Mora pM = new Mora();
                        pM.Mora_Mensual = txtMoraPagoMensual.Text;
                        pM.Mora_Semanal = txtMoraPagoSemanal.Text;
                        pM.Pago_Mensual = txtPagoMensual.Text;
                        pM.Pago_Semanal = txtPagoSemanal.Text;

                        int R = MoraDB.Modificar(pM);
                        if (R > 0)
                        {
                            MessageBox.Show("Pagos Modificados con Exito!", "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadPrices();
                            disableCheckBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Error, No se pudo Modificar", "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {

                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPagoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPagoSemanal.Focus();
            }
        }

        private void txtPagoSemanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoraPagoSemanal.Focus();
            }
        }

        private void txtMoraPagoSemanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoraPagoMensual.Focus();
            }
        }

        private void txtMoraPagoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    try
            //    {
            //        if (MessageBox.Show("Seguro que Desea Modificar la Tarifa?", "Pagos y Mora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //        {
            //            if (txtMoraPagoMensual.Text == string.Empty || txtMoraPagoSemanal.Text == string.Empty || txtPagoMensual.Text == string.Empty || txtPagoSemanal.Text == string.Empty)
            //            {
            //                MessageBox.Show("Complete todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            else
            //            {
            //                Mora pM = new Mora();
            //                pM.Mora_Mensual = txtMoraPagoMensual.Text;
            //                pM.Mora_Semanal = txtMoraPagoSemanal.Text;
            //                pM.Pago_Mensual = txtPagoMensual.Text;
            //                pM.Pago_Semanal = txtPagoSemanal.Text;

            //                int R = MoraDB.Modificar(pM);
            //                if (R > 0)
            //                {
            //                    MessageBox.Show("Pagos Modificados con Exito!", "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    //dgvTabla.DataSource = MoraDB.VerMorayPagos();
            //                    txtMoraPagoMensual.Clear();
            //                    txtMoraPagoSemanal.Clear();
            //                    txtPagoMensual.Clear();
            //                    txtPagoSemanal.Clear();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Error, No se pudo Modificar", "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                }
            //            }
            //        }
            //        else
            //        {

            //        };
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMoraPagoSemanal.Checked)
                {
                    txtMoraPagoSemanal.Enabled = true;
                    txtMoraPagoSemanal.Focus();
                }
                else
                {
                    txtMoraPagoSemanal.Enabled = false;
                    txtMoraPagoSemanal.Text = Convert.ToDouble(MoraDB.ObtenerMoraSemanal()).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPagoMensual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPagoMensual.Checked)
                {
                    txtPagoMensual.Enabled = true;
                    txtPagoMensual.Focus();
                }
                else
                {
                    txtPagoMensual.Enabled = false;
                    txtPagoMensual.Text = PagosDB.ObtenerPagoMensual().ToString("f2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPagoSemanal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPagoSemanal.Checked)
                {
                    txtPagoSemanal.Enabled = true;
                    txtPagoSemanal.Focus();
                }
                else
                {
                    txtPagoSemanal.Enabled = false;
                    txtPagoSemanal.Text = PagosDB.ObtenerPagoSemanal().ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMoraPagoMensual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMoraPagoMensual.Checked)
                {
                    txtMoraPagoMensual.Enabled = true;
                    txtMoraPagoMensual.Focus();
                }
                else
                {
                    txtMoraPagoMensual.Enabled = false;
                    txtMoraPagoMensual.Text = Convert.ToDouble(MoraDB.ObtenerMoraMensual()).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPagoMensualVIP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPagoMensualVIP.Checked)
                {
                    txtPagoMensualVIP.Enabled = true;
                    txtPagoMensualVIP.Focus();
                }
                else
                {
                    txtPagoMensualVIP.Enabled = false;
                    txtPagoMensualVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPagoSemanalVIP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPagoSemanalVIP.Checked)
                {
                    txtPagoSemanalVIP.Enabled = true;
                    txtPagoSemanalVIP.Focus();
                }
                else
                {
                    txtPagoSemanalVIP.Enabled = false;
                    txtPagoSemanalVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMoraPagoSemanalVIP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMoraPagoSemanalVIP.Checked)
                {
                    txtMoraPagoSemanalVIP.Enabled = true;
                    txtMoraPagoSemanalVIP.Focus();
                }
                else
                {
                    txtMoraPagoSemanalVIP.Enabled = false;
                    txtMoraPagoSemanalVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Semanal).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMoraPagoMensualVIP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMoraPagoMensualVIP.Checked)
                {
                    txtMoraPagoMensualVIP.Enabled = true;
                    txtMoraPagoMensualVIP.Focus();
                }
                else
                {
                    txtMoraPagoMensualVIP.Enabled = false;
                    txtMoraPagoMensualVIP.Text = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Mensual).ToString("f2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarVIP_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea modificar la tarifa para los estudiantes VIP?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMoraPagoMensualVIP.Text == string.Empty || txtPagoSemanalVIP.Text == string.Empty || txtMoraPagoSemanalVIP.Text == string.Empty || txtPagoMensualVIP.Text == string.Empty)
                    {
                        MessageBox.Show("Complete todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!cbMoraPagoMensualVIP.Checked & !cbMoraPagoSemanalVIP.Checked & !cbPagoMensualVIP.Checked & !cbPagoSemanalVIP.Checked)
                    {
                        MessageBox.Show("No hay ningun campo a modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Mora pTarifa = new Mora();

                        pTarifa.Mora_Mensual = txtMoraPagoMensualVIP.Text;
                        pTarifa.Mora_Semanal = txtMoraPagoSemanalVIP.Text;
                        pTarifa.Pago_Mensual = txtPagoMensualVIP.Text;
                        pTarifa.Pago_Semanal = txtPagoSemanalVIP.Text;

                        if (MoraDB.ModificarVIP(pTarifa) > 0)
                        {
                            MessageBox.Show("Tarifa modificada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            disableCheckBoxes();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtMoraMensual.Text == string.Empty)
            {
                MessageBox.Show("Mora Mensual esta vacia, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoraMensual.Focus();
            }
            else if (txtMoraSemanal.Text == string.Empty)
            {
                MessageBox.Show("Mora Semanal esta vacia, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoraSemanal.Focus();
            }
            else if (txtPagoMensual.Text == string.Empty)
            {
                MessageBox.Show("Pago Mensual esta vacio, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagoMensual.Focus();
            }
            else if (txtPagoSemanal.Text == string.Empty)
            {
                MessageBox.Show("Pago semanal esta vacio, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagoSemanal.Focus();
            }
            else
            {
                try
                {
                    Mora pMora = new Mora();
                    pMora.Mora_Mensual = txtMoraMensual.Text;
                    pMora.Mora_Semanal = txtMoraSemanal.Text;
                    pMora.Pago_Mensual = txtPagoMensual.Text;
                    pMora.Pago_Semanal = txtPagoSemanal.Text;

                    int r = MoraDB.ModificarVIP(pMora);
                    if (r > 0)
                    {
                        MessageBox.Show("Modificado con Exito", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPagosVIP.DataSource = MoraDB.VerMorayPagosVIP();
                        txtMoraMensual.Clear();
                        txtMoraSemanal.Clear();
                        txtPagoMensual.Clear();
                        txtPagoSemanal.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar, Intentelo Nuevamente", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPagoSemanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoraSemanal.Focus();
            }
        }

        private void txtMoraSemanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPagoMensual.Focus();
            }
        }

        private void txtPagoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoraMensual.Focus();
            }
        }

        private void txtMoraMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtMoraMensual.Text == string.Empty)
                {
                    MessageBox.Show("Mora Mensual esta vacia, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoraMensual.Focus();
                }
                else if (txtMoraSemanal.Text == string.Empty)
                {
                    MessageBox.Show("Mora Semanal esta vacia, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoraSemanal.Focus();
                }
                else if (txtPagoMensual.Text == string.Empty)
                {
                    MessageBox.Show("Pago Mensual esta vacio, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPagoMensual.Focus();
                }
                else if (txtPagoSemanal.Text == string.Empty)
                {
                    MessageBox.Show("Pago semanal esta vacio, digite una cantidad valida", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPagoSemanal.Focus();
                }
                else
                {
                    try
                    {
                        Mora pMora = new Mora();
                        pMora.Mora_Mensual = txtMoraMensual.Text;
                        pMora.Mora_Semanal = txtMoraSemanal.Text;
                        pMora.Pago_Mensual = txtPagoMensual.Text;
                        pMora.Pago_Semanal = txtPagoSemanal.Text;

                        int r = MoraDB.ModificarVIP(pMora);
                        if (r > 0)
                        {
                            MessageBox.Show("Modificado con Exito", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvPagosVIP.DataSource = MoraDB.VerMorayPagosVIP();
                            txtMoraMensual.Clear();
                            txtMoraSemanal.Clear();
                            txtPagoMensual.Clear();
                            txtPagoSemanal.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar, Intentelo Nuevamente", "Pagos VIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
}

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
        public frmMontoPagosyMora()
        {
            InitializeComponent();
        }

        private void frmMontoPagosyMora_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTabla.DataSource = MoraDB.VerMorayPagos();
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
                            dgvTabla.DataSource = MoraDB.VerMorayPagos();
                            txtMoraPagoMensual.Clear();
                            txtMoraPagoSemanal.Clear();
                            txtPagoMensual.Clear();
                            txtPagoSemanal.Clear();
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (MessageBox.Show("Seguro que Desea Modificar la Tarifa?", "Pagos y Mora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txtMoraPagoMensual.Text == string.Empty || txtMoraPagoSemanal.Text == string.Empty || txtPagoMensual.Text == string.Empty || txtPagoSemanal.Text == string.Empty)
                        {
                            MessageBox.Show("Complete todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                dgvTabla.DataSource = MoraDB.VerMorayPagos();
                                txtMoraPagoMensual.Clear();
                                txtMoraPagoSemanal.Clear();
                                txtPagoMensual.Clear();
                                txtPagoSemanal.Clear();
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pagos y Mora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

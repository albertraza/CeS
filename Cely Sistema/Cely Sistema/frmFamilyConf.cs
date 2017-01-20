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
    public partial class frmFamilyConf : Form
    {
        // metodo para limpiar los texboxes
        private void LimpiarTodo()
        {
            txtMora.Clear();
            txtNombre.Clear();
            txtPago.Clear();
            rbMensual.Checked = false;
            rbSemanal.Checked = false;
            dgvListado.DataSource = "";
            txtNombre.Focus();
            dtpFechaPrimerPago.Enabled = true;
            dtpFechaPrimerPago.Value = DateTime.Today.Date;
        }
        public frmFamilyConf()
        {
            InitializeComponent();
        }

        private pagoGrupal pInfoGrupoActual { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarGrupo pGrupo = new frmBuscarGrupo();
            pGrupo.menu = false;
            pGrupo.ShowDialog();

            try
            {

                if (pGrupo.pInfoGrupoSeleccionado != null)
                {
                    pInfoGrupoActual = pGrupo.pInfoGrupoSeleccionado;
                    txtMora.Text = pGrupo.pInfoGrupoSeleccionado.mora.ToString("f2");
                    txtPago.Text = pGrupo.pInfoGrupoSeleccionado.pago.ToString("f2");
                    txtNombre.Text = pGrupo.pInfoGrupoSeleccionado.Nombre;

                    if (pGrupo.pInfoGrupoSeleccionado.FechaProximoPago != string.Empty && pGrupo.pInfoGrupoSeleccionado.FechaProximoPago != null)
                    {
                        dtpFechaPrimerPago.Value = Convert.ToDateTime(pGrupo.pInfoGrupoSeleccionado.FechaProximoPago);
                        dtpFechaPrimerPago.Enabled = false;
                    }

                    if (pGrupo.pInfoGrupoSeleccionado.ModoPago == "Semanal")
                    {
                        rbSemanal.Checked = true;
                    }
                    else if (pGrupo.pInfoGrupoSeleccionado.ModoPago == "Mensual")
                    {
                        rbMensual.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo identificar el modo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dgvListado.DataSource = EstudianteDB.listEstudiantesPorPagoGrupal(pGrupo.pInfoGrupoSeleccionado.Id_grupo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
                else if (!rbMensual.Checked && !rbSemanal.Checked)
                {
                    MessageBox.Show("Seleccione un modo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPago.Text == string.Empty)
                {
                    MessageBox.Show("El pago esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPago.Focus();
                }
                else if (txtMora.Text == string.Empty)
                {
                    MessageBox.Show("La mora esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMora.Focus();
                }
                else if (DateTime.Compare(DateTime.Today.Date, dtpFechaPrimerPago.Value.Date) == 0)
                {
                    MessageBox.Show("La fecha de pago no puede ser la misma de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaPrimerPago.Focus();
                }
                else if (DateTime.Compare(DateTime.Today.Date, dtpFechaPrimerPago.Value.Date) > 0)
                {
                    MessageBox.Show("La fecha del primer pago no puede ser menor al dia de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaPrimerPago.Focus();
                }
                else
                {
                    pagoGrupal pInfoGrupo = new pagoGrupal();
                    pInfoGrupo.Nombre = txtNombre.Text;
                    pInfoGrupo.pago = Convert.ToDouble(txtPago.Text);
                    pInfoGrupo.mora = Convert.ToDouble(txtMora.Text);
                    pInfoGrupo.FechaProximoPago = dtpFechaPrimerPago.Value.Date.ToString("yyyy-MM-dd");

                    if (rbMensual.Checked)
                    {
                        pInfoGrupo.ModoPago = rbMensual.Text;
                    }
                    else
                    {
                        pInfoGrupo.ModoPago = rbSemanal.Text;
                    }

                    if (pagoGrupal.registerGrupo(pInfoGrupo) > 0)
                    {
                        MessageBox.Show("Registrado Exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTodo();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool menu { get; set; }
        public int codigoGrupo {get; set;}

        private void frmFamilyConf_Load(object sender, EventArgs e)
        {
            if (!menu)
            {
                if (codigoGrupo != 0)
                {
                    pagoGrupal pInfoGrupoOutSide = pagoGrupal.getPagoGrupal(codigoGrupo);

                    pInfoGrupoActual = pInfoGrupoOutSide;
                    txtMora.Text = pInfoGrupoOutSide.mora.ToString("f2");
                    txtPago.Text = pInfoGrupoOutSide.pago.ToString("f2");
                    txtNombre.Text = pInfoGrupoOutSide.Nombre;

                    if (pInfoGrupoOutSide.FechaProximoPago != string.Empty && pInfoGrupoOutSide.FechaProximoPago != null)
                    {
                        dtpFechaPrimerPago.Value = Convert.ToDateTime(pInfoGrupoOutSide.FechaProximoPago);
                        dtpFechaPrimerPago.Enabled = false;
                    }

                    if (pInfoGrupoOutSide.ModoPago == "Semanal")
                    {
                        rbSemanal.Checked = true;
                    }
                    else if (pInfoGrupoOutSide.ModoPago == "Mensual")
                    {
                        rbMensual.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo identificar el modo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dgvListado.DataSource = EstudianteDB.listEstudiantesPorPagoGrupal(pInfoGrupoOutSide.Id_grupo);
                }
                else
                {
                    rbMensual.Checked = false;
                    rbSemanal.Checked = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                pInfoGrupoActual.Nombre = txtNombre.Text;
                pInfoGrupoActual.pago = Convert.ToDouble(txtPago.Text);
                pInfoGrupoActual.mora = Convert.ToDouble(txtMora.Text);

                if (rbMensual.Checked)
                {
                    pInfoGrupoActual.ModoPago = rbMensual.Text;
                }
                else
                {
                    pInfoGrupoActual.ModoPago = rbSemanal.Text;
                }


                if(pagoGrupal.modifyGrupo(pInfoGrupoActual) > 0)
                {
                    MessageBox.Show("Modificado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(pagoGrupal.deletePagoGrupal(pInfoGrupoActual.Id_grupo) > 0)
                {
                    MessageBox.Show("Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void lblAnadirGrupo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pInfoGrupoActual != null)
            {
                frmBusquedaDeAlumnos pBusqueda = new frmBusquedaDeAlumnos();
                pBusqueda.getState = false;
                pBusqueda.ShowDialog();

                if (pBusqueda.EstudianteSeleccionado != null)
                {
                    try
                    {
                        if (pagoGrupal.anadirEstudiante(Convert.ToInt32(pBusqueda.EstudianteSeleccionado.ID),
                            pInfoGrupoActual.Id_grupo, 
                            EstudianteDB.ObtenerFechaProximoPago(Convert.ToInt32(pBusqueda.EstudianteSeleccionado.ID)).ToString("yyyy-MM-dd")) > 0)
                        {
                            MessageBox.Show("Añadido Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvListado.DataSource = EstudianteDB.listEstudiantesPorPagoGrupal(pInfoGrupoActual.Id_grupo);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un grupo para poder añadir a un estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

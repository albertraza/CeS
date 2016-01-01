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
    public partial class frmRegistrodeHorarios : Form
    {
        public frmRegistrodeHorarios()
        {
            InitializeComponent();
        }

        private void frmRegistrodeHorarios_Load(object sender, EventArgs e)
        {
            dgvHorarios.DataSource = HorariosDB.TodosLosHorarios();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        public void Limpiar()
        {
            txtDias.Clear();
            txtHora.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDias.Text == string.Empty)
                {
                    MessageBox.Show("Complete el Campo: 'Dias'", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDias.Focus();
                }
                else if (txtHora.Text == string.Empty)
                {
                    MessageBox.Show("Complete el Campo: 'Hora'", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHora.Focus();
                }
                else
                {

                    if (MessageBox.Show("Seguro que desea registrar el Horaio?", "Registro de Horarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Horarios pH = new Horarios();

                        pH.Hora = txtHora.Text;
                        pH.Dias = txtDias.Text;

                        int retorno = HorariosDB.RegistrarHorario(pH);

                        if (retorno > 0)
                        {
                            MessageBox.Show("Horario Registrado Con Exito", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvHorarios.DataSource = HorariosDB.TodosLosHorarios();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Registrar el Horario, Intentelo Nuevamente", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Horarios pHS { get; set; }
        private void btnCargarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHorarios.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvHorarios.CurrentRow.Cells[0].Value);
                    pHS = HorariosDB.ObtenerHorario(ID);


                    if (pHS != null)
                    {
                        txtDias.Text = pHS.Dias;
                        txtHora.Text = pHS.Hora;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un Error, Intentelo Nuevamente", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnCargarHorario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un Horario, Seleccione uno de la Tabla", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Horarios pH = new Horarios();

                if (MessageBox.Show("Seguro que desea modificar el Horario?", "Registro de Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (MessageBox.Show("Recuerde que Modificando el Horario los estudiantes registrados con ese horario resultaran afectados por el cambio; Desea continuar?", "Registro de Horarios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txtDias.Text == string.Empty)
                        {
                            MessageBox.Show("No se puede dejar el campo: 'Dias' vacio", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtDias.Focus();
                        }
                        else if (txtHora.Text == string.Empty)
                        {
                            MessageBox.Show("No se puede dejar el campo: 'Hora' vacio", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtHora.Focus();
                        }
                        else
                        {
                            pH.Hora = txtHora.Text;
                            pH.Dias = txtDias.Text;
                            pH.ID = pHS.ID;

                            int Retorno = HorariosDB.ModificaciondeHorario(pH);

                            if (Retorno > 0)
                            {
                                MessageBox.Show("Horario Modificado con Exito", "Registro de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvHorarios.DataSource = HorariosDB.TodosLosHorarios();
                                Limpiar();
                                btnGuardar.Enabled = true;
                                btnModificar.Enabled = false;
                                btnEliminar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Modificar el Horario, Intentelo mas Tarde", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea Eliminar el Horario?", "Registro de Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (MessageBox.Show("Aviso: Algunos Estudiantes pueden ser afectados con esta Accion; Desea Continuar?", "Registro de Horarios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int R = HorariosDB.EliminarHorario(pHS);

                        if (R > 0)
                        {
                            MessageBox.Show("Horaio Eliminaro con Exito", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnGuardar.Enabled = true;
                            btnModificar.Enabled = false;
                            btnEliminar.Enabled = false;
                            dgvHorarios.DataSource = HorariosDB.TodosLosHorarios();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Eliminar el Horario, Intentelo Nuevamente", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
                txtDias.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtHora.Focus();
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
        }
    }
}

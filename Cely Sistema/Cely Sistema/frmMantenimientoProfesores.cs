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
    public partial class frmMantenimientoProfesores : Form
    {
        public Profesores pPS { get; set; }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            pPS = null;
            txtNombre.Focus();
        }
        public frmMantenimientoProfesores()
        {
            InitializeComponent();
        }
        private string IDProfesor;
        public string getIDProfesor
        {
            get { return IDProfesor; }
            set { IDProfesor = value; }
        }
        private void frmMantenimientoProfesores_Load(object sender, EventArgs e)
        {
            if (IDProfesor != null)
            {
                btnRegsitrar.Enabled = false;
                try
                {
                    pPS = ProfesoresDB.ObtenerProfesor(int.Parse(IDProfesor));
                    txtApellido.Text = pPS.Apellido;
                    txtNombre.Text = pPS.Nombre;
                    dgvProfesores.DataSource = ProfesoresDB.TodosLosProfesores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                try
                {
                    dgvProfesores.DataSource = ProfesoresDB.TodosLosProfesores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegsitrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre esta vacio, Digite uno Valido", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNombre.Focus();
                }
                else if (txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("El Apellido esta Vacio, Digite uno valido", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtApellido.Focus();
                }
                else
                {
                    Profesores pP = new Profesores();
                    pP.Nombre = txtNombre.Text;
                    pP.Apellido = txtApellido.Text;

                    int R = ProfesoresDB.AgregarProfesor(pP);

                    if (R > 0)
                    {
                        MessageBox.Show("Profesor Registrado Con Exito", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProfesores.DataSource = ProfesoresDB.TodosLosProfesores();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Registrar el Docente, Intentelo Nuevamente", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCargarProfesor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvProfesores.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value);
                    pPS = ProfesoresDB.ObtenerProfesor(ID);

                    if (pPS != null)
                    {
                        txtNombre.Text = pPS.Nombre;
                        txtApellido.Text = pPS.Apellido;
                        btnRegsitrar.Enabled = false;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Cargar el Docente, Intentelo Nuevamente", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha Seleccionado Ningun Docente, Seleccione uno de la Tabla", "Registro de  Docentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre esta vacio, Digite uno Valido", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNombre.Focus();
                }
                else if (txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("El Apellido esta Vacio, Digite uno valido", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtApellido.Focus();
                }
                else
                {
                    Profesores pP = new Profesores();
                    if (MessageBox.Show("Seguro que deseea Modificar el Docente?", "Registro de Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pP.Nombre = txtNombre.Text;
                        pP.Apellido = txtApellido.Text;
                        pP.ID = pPS.ID;
                        int R = ProfesoresDB.ModificarProfesor(pP);
                        if (R > 0)
                        {
                            MessageBox.Show("Docente Modificado Con Exito", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            dgvProfesores.DataSource = ProfesoresDB.TodosLosProfesores();
                            btnRegsitrar.Enabled = true;
                            btnEliminar.Enabled = false;
                            btnModificar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Modificar el Docente, Intentelo Nuevamente", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (MessageBox.Show("Seguro que desea elimianr el Docente?", "Registro de Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int R = ProfesoresDB.EliminarProfesor(pPS.ID);

                    if (R > 0)
                    {
                        MessageBox.Show("Se Elimino el Docente", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        dgvProfesores.DataSource = ProfesoresDB.TodosLosProfesores();
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnRegsitrar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se  pudo Eliminar el Docente, Intentelo Nuevamnente", "Registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnRegsitrar.Focus();
            }
        }
    }
}

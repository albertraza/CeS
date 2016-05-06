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
    public partial class frmBusquedaDeAlumnos : Form
    {
        public EstudianteBase EstudianteSeleccionado { get; set; }
        public frmBusquedaDeAlumnos()
        {
            InitializeComponent();
        }

        private bool state = false;
        public bool getState
        {
            get { return state; }
            set { state = value; }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, matricula;
            try
            {
                Estudiante pE = new Estudiante();
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = txtApellido.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                matricula = txtMatricula.Text;
                dataGridView1.DataSource = EstudianteDB.BuscarEstudiante(nombre, apellido, matricula);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBusquedaDeAlumnos_Load(object sender, EventArgs e)
        {
            if (state == false)
            {
                try
                {
                    dataGridView1.DataSource = EstudianteDB.TodosEstudiante();
                    btnModificar.Visible = false;
                    btnEliminar.Visible = false;

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
                    dataGridView1.DataSource = EstudianteDB.TodosEstudiante();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnSeleccionarAlumno.Visible = false;
            }
        }

        private void btnSeleccionarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Int64 ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                    EstudianteSeleccionado = EstudianteDB.SeleccionarEstudiante(ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, No se ha seleccionado ningun Estudiante, Seleccione otra vez", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 ID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[13].Value);
                EstudianteSeleccionado = EstudianteDB.SeleccionarEstudiante(ID);
                this.Close();
                frmCargaEstudiante pEstudiante = new frmCargaEstudiante();
                pEstudiante.Show();
            }
            else
            {
                MessageBox.Show("Error, No se ha seleccionado ningun Estudiante, Seleccione otra vez", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmRegistro re = new frmRegistro();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                    re.GetIDestudiante = EstudianteDB.SeleccionarEstudiante(ID);
                    re.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un estudiante de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmRegistro re = new frmRegistro();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                    re.GetIDestudiante = EstudianteDB.SeleccionarEstudiante(ID);
                    re.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un estudiante de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nombre, apellido, matricula;
                try
                {
                    Estudiante pE = new Estudiante();
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    if (txtMatricula.Text == string.Empty)
                    {
                        matricula = "";
                    }
                    else
                    {
                        matricula = txtMatricula.Text;
                    }
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    matricula = txtMatricula.Text;
                    dataGridView1.DataSource = EstudianteDB.BuscarEstudiante(nombre, apellido, matricula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nombre, apellido, matricula;
                try
                {
                    Estudiante pE = new Estudiante();
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    if (txtMatricula.Text == string.Empty)
                    {
                        matricula = "";
                    }
                    else
                    {
                        matricula = txtMatricula.Text;
                    }
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    matricula = txtMatricula.Text;
                    dataGridView1.DataSource = EstudianteDB.BuscarEstudiante(nombre, apellido, matricula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nombre, apellido, matricula;
                try
                {
                    Estudiante pE = new Estudiante();
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    if (txtMatricula.Text == string.Empty)
                    {
                        matricula = "";
                    }
                    else
                    {
                        matricula = txtMatricula.Text;
                    }
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    matricula = txtMatricula.Text;
                    dataGridView1.DataSource = EstudianteDB.BuscarEstudiante(nombre, apellido, matricula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                frmFacturacion f = new frmFacturacion();
                f.getID = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun Estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Desea Imprimir el Contrato del Estudiante", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmReporte pContrato = new frmReporte();
                    string matricula = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    pContrato.Matricula = matricula;
                    pContrato.ModoPago = EstudianteDB.ObtenerModoPago(int.Parse(matricula));
                    pContrato.VIP = EstudianteDB.SeleccionarEstudiante(int.Parse(matricula)).VIP;
                    pContrato.ShowDialog();
                }
            }
        }
    }
}

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
    public partial class frmProfesoresA : Form
    {
        public frmProfesoresA()
        {
            InitializeComponent();
        }

        private void frmProfesoresA_Load(object sender, EventArgs e)
        {
            try
            {
                MaximizeBox = false;
                dgvTabla.DataSource = ProfesoresDB.TodosLosProfesores();
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
                string nombre, apellido;
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
                dgvTabla.DataSource = ProfesoresDB.BuscarProfesores(nombre, apellido);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Profesores pPS { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTabla.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvTabla.CurrentRow.Cells[0].Value);
                    pPS = ProfesoresDB.ObtenerProfesor(ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha Seleccionado un Profesor, Elija uno de la Tabla", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string nombre, apellido;
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
                    dgvTabla.DataSource = ProfesoresDB.BuscarProfesores(nombre, apellido);
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
                try
                {
                    string nombre, apellido;
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
                    dgvTabla.DataSource = ProfesoresDB.BuscarProfesores(nombre, apellido);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

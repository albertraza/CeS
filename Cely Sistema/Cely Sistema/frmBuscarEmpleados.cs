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
    public partial class frmBuscarEmpleados : Form
    {
        public frmBuscarEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbProfesores.Checked == true)
                {
                    string nombre, apellido;
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre ="";
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
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool state;
        public bool getState
        {
            get { return state; }
            set { state = value; }
        }
        private void frmBuscarEmpleados_Load(object sender, EventArgs e)
        {
            if (state == false)
            {
                btnModificar.Visible = false;
            }
            else
            {
                btnModificar.Visible = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbProfesores.Checked == true)
            {
                frmMantenimientoProfesores mp = new frmMantenimientoProfesores();
                if (dgvTabla.SelectedRows.Count == 1)
                {
                    mp.getIDProfesor = dgvTabla.CurrentRow.Cells[0].Value.ToString();
                    mp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un Estudiante de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Mantenimiento de secretarias
            }
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
                try
                {
                    if (rbProfesores.Checked == true)
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
                    else
                    {

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

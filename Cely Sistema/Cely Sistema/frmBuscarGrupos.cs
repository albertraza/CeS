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
    public partial class frmBuscarGrupos : Form
    {
        public frmBuscarGrupos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtAula.Clear();
            txtNivel.Clear();
            txtProfesor.Clear();
            txtNivel.Focus();
            dtpFechaInicio.Value = DateTime.Today;
            dgvNiveles.DataSource = "";
        }
        private bool state;
        public bool getState
        {
            get { return state; }
            set { state = value; }
        }
        private void frmBuscarGrupos_Load(object sender, EventArgs e)
        {
            if (state == false)
            {
                btnModificar.Visible = false;
                try
                {
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnModificar.Visible = true;
                try
                {
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nivel, profesor, fechaInicio, aula;
            if (txtAula.Text == string.Empty)
            {
                nivel = "";
            }
            else
            {
                nivel = txtNivel.Text;
            }
            if (txtAula.Text == string.Empty)
            {
                aula = "";
            }
            else
            {
                aula = txtAula.Text;
            }
            if (txtProfesor.Text == string.Empty)
            {
                profesor = "";
            }
            else
            {
                profesor = txtProfesor.Text;
            }
            if (dtpFechaInicio.Value.Date == DateTime.Today.Date)
            {
                fechaInicio = "";
            }
            else
            {
                fechaInicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
            }
            try
            {
                dgvNiveles.DataSource = GruposDB.BuscarGrupos(nivel, profesor, fechaInicio, aula);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvNiveles.SelectedRows.Count == 1)
            {
                frmRegistrodeGruposyNiveles rg = new frmRegistrodeGruposyNiveles();
                rg.getID = dgvNiveles.CurrentRow.Cells[0].Value.ToString();
                rg.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Grupo de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nivel, profesor, fechaInicio, aula;
                if (txtAula.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                if (txtAula.Text == string.Empty)
                {
                    aula = "";
                }
                else
                {
                    aula = txtAula.Text;
                }
                if (txtProfesor.Text == string.Empty)
                {
                    profesor = "";
                }
                else
                {
                    profesor = txtProfesor.Text;
                }
                if (dtpFechaInicio.Value.Date == DateTime.Today.Date)
                {
                    fechaInicio = "";
                }
                else
                {
                    fechaInicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos(nivel, profesor, fechaInicio, aula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nivel, profesor, fechaInicio, aula;
                if (txtAula.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                if (txtAula.Text == string.Empty)
                {
                    aula = "";
                }
                else
                {
                    aula = txtAula.Text;
                }
                if (txtProfesor.Text == string.Empty)
                {
                    profesor = "";
                }
                else
                {
                    profesor = txtProfesor.Text;
                }
                if (dtpFechaInicio.Value.Date == DateTime.Today.Date)
                {
                    fechaInicio = "";
                }
                else
                {
                    fechaInicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos(nivel, profesor, fechaInicio, aula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nivel, profesor, fechaInicio, aula;
                if (txtAula.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                if (txtAula.Text == string.Empty)
                {
                    aula = "";
                }
                else
                {
                    aula = txtAula.Text;
                }
                if (txtProfesor.Text == string.Empty)
                {
                    profesor = "";
                }
                else
                {
                    profesor = txtProfesor.Text;
                }
                if (dtpFechaInicio.Value.Date == DateTime.Today.Date)
                {
                    fechaInicio = "";
                }
                else
                {
                    fechaInicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos(nivel, profesor, fechaInicio, aula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nivel, profesor, fechaInicio, aula;
                if (txtAula.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                if (txtAula.Text == string.Empty)
                {
                    aula = "";
                }
                else
                {
                    aula = txtAula.Text;
                }
                if (txtProfesor.Text == string.Empty)
                {
                    profesor = "";
                }
                else
                {
                    profesor = txtProfesor.Text;
                }
                if (dtpFechaInicio.Value.Date == DateTime.Today.Date)
                {
                    fechaInicio = "";
                }
                else
                {
                    fechaInicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos(nivel, profesor, fechaInicio, aula);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

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
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo, nombre, nivel;
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
            }
            if (txtIDUsuario.Text == string.Empty)
            {
                nombre = "";
            }
            else
            {
                nombre = txtIDUsuario.Text;
            }
            if (txtNivel.Text == string.Empty)
            {
                nivel = "";
            }
            else
            {
                nivel = txtNivel.Text;
            }
            try
            {
                dgvUsuarios.DataSource = UsuariosB.Buscar(codigo, nombre, nivel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtIDUsuario.Clear();
            txtNivel.Clear();
            try
            {
                dgvUsuarios.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = UsuariosB.TodosUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo, nombre, nivel;
                if (txtCodigo.Text == string.Empty)
                {
                    codigo = "";
                }
                else
                {
                    codigo = txtCodigo.Text;
                }
                if (txtIDUsuario.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtIDUsuario.Text;
                }
                if (txtNivel.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                try
                {
                    dgvUsuarios.DataSource = UsuariosB.Buscar(codigo, nombre, nivel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIDUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo, nombre, nivel;
                if (txtCodigo.Text == string.Empty)
                {
                    codigo = "";
                }
                else
                {
                    codigo = txtCodigo.Text;
                }
                if (txtIDUsuario.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtIDUsuario.Text;
                }
                if (txtNivel.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                try
                {
                    dgvUsuarios.DataSource = UsuariosB.Buscar(codigo, nombre, nivel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo, nombre, nivel;
                if (txtCodigo.Text == string.Empty)
                {
                    codigo = "";
                }
                else
                {
                    codigo = txtCodigo.Text;
                }
                if (txtIDUsuario.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtIDUsuario.Text;
                }
                if (txtNivel.Text == string.Empty)
                {
                    nivel = "";
                }
                else
                {
                    nivel = txtNivel.Text;
                }
                try
                {
                    dgvUsuarios.DataSource = UsuariosB.Buscar(codigo, nombre, nivel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

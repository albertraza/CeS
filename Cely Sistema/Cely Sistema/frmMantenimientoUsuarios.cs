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
    public partial class frmMantenimientoUsuarios : Form
    {
        public frmMantenimientoUsuarios()
        {
            InitializeComponent();
        }
        private string pC02 { get; set; }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsuario.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre Usuario Vacio, Inserte uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreUsuario.Focus();
                }
                else if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La Contraseña esta vacia, Digite una valida", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContraseña.Focus();
                }
                else
                {
                    string pC1, pC2;
                    if (txtContraseña.Text != string.Empty)
                    {
                        pC1 = txtContraseña.Text;
                        frmConfContraseña pC = new frmConfContraseña();
                        pC.ShowDialog();
                        if (pC.Contrasena != null)
                        {
                            pC2 = pC.Contrasena;
                            if (pC1 == pC2)
                            {
                                Usuarios pUsuarios = new Usuarios();
                                pUsuarios.Nombre_Usuario = txtNombreUsuario.Text;
                                pUsuarios.Contraseña = pC1;
                                pUsuarios.Nivel = txtNivel.Text;
                                int R = UsuariosDB.RegistrarUsuarios(pUsuarios);
                                if (R > 0)
                                {
                                    MessageBox.Show("Usuario Registrado con Exito!", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    string ID = UsuariosDB.ObtenerCodigo(pUsuarios);
                                    if (ID != null)
                                    {
                                        MessageBox.Show("Su Codigo es: " + ID, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error al Registrar el Usuario", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las Contraseñas son Diferentes, Intentelo Nuevamente", "Usuarioas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
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
                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("El Codigo esta Vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus();
                }
                else if (txtNombreUsuario.Text == string.Empty)
                {
                    MessageBox.Show("El Nombe de Usuario esta Vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreUsuario.Focus();
                }
                else if (txtNivel.Text == string.Empty)
                {
                    MessageBox.Show("El Nivel esta Vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNivel.Focus();
                }
                else if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La Contraseña esta Vacia, Digite una Valida", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContraseña.Focus();
                }
                else
                {
                    frmConfContraseña pC = new frmConfContraseña();
                    pC.ShowDialog();
                    if (pC.Contrasena != null)
                    {
                        if (txtContraseña.Text == pC.Contrasena)
                        {
                            Usuarios pU = new Usuarios();
                            pU.Codigo = Convert.ToInt32(txtCodigo.Text);
                            pU.Nombre_Usuario = txtNombreUsuario.Text;
                            pU.Contraseña = txtContraseña.Text;
                            pU.Nivel = txtNivel.Text;
                            if (MessageBox.Show("Seguro que desea modificar el Usuario?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                int R = UsuariosDB.ModificarUsuarios(pU);
                                if (R > 0)
                                {
                                    MessageBox.Show("Modificado con Exito", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Modificar, Intentalo nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las Contraseña no Coinciden, Digitelas nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas no coinciden, Intentalo Nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                txtCodigo.Clear();
                txtContraseña.Clear();
                txtNombreUsuario.Clear();
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
                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Completa el Codigo del Usuario", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus();
                }
                else
                {
                    if (MessageBox.Show("Deseas eliminar el Usuario?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int R = UsuariosDB.Eliminar(int.Parse(txtCodigo.Text));
                        if (R > 0)
                        {
                            MessageBox.Show("Eliminado Exitosamente!", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodigo.Clear();
                            txtContraseña.Clear();
                            txtNombreUsuario.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el Usuario, Intentelo nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombreUsuario.Focus();
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNivel.Focus();
            }
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnRegistrar.Focus();
            }
        }
    }
}

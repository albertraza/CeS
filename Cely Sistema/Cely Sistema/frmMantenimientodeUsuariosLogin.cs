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
    public partial class frmMantenimientodeUsuariosLogin : Form
    {
        public frmMantenimientodeUsuariosLogin()
        {
            InitializeComponent();
        }

        private void frmMantenimientodeUsuariosLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsuario.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre de Usuario Esta vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreUsuario.Focus();
                }
                else if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La Contraseña esta vacia, Digitela nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContraseña.Focus();
                }
                else
                {
                    Usuarios pU = new Usuarios();
                    pU.Nombre_Usuario = txtNombreUsuario.Text;
                    pU.Contraseña = txtContraseña.Text;
                    int R0 = UsuariosDB.Login(pU);
                    if (R0 > 0)
                    {
                        string R1 = UsuariosDB.ONivel(txtNombreUsuario.Text);
                        if (R1 != null)
                        {
                            int R2 = int.Parse(R1);
                            if (R2 > 2)
                            {
                                frmMantenimientoUsuarios p = new frmMantenimientoUsuarios();
                                p.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No tienes Acceso, Contactate con el Administrador del Sistema", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre o Contraseña Incorrectos, Intentelo Nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                try
                {
                    if (txtNombreUsuario.Text == string.Empty)
                    {
                        MessageBox.Show("El Nombre de Usuario Esta vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombreUsuario.Focus();
                    }
                    else if (txtContraseña.Text == string.Empty)
                    {
                        MessageBox.Show("La Contraseña esta vacia, Digitela nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtContraseña.Focus();
                    }
                    else
                    {
                        Usuarios pU = new Usuarios();
                        pU.Nombre_Usuario = txtNombreUsuario.Text;
                        pU.Contraseña = txtContraseña.Text;
                        int R0 = UsuariosDB.Login(pU);
                        if (R0 > 0)
                        {
                            string R1 = UsuariosDB.ONivel(txtNombreUsuario.Text);
                            if (R1 != null)
                            {
                                int R2 = int.Parse(R1);
                                if (R2 > 2)
                                {
                                    frmMantenimientoUsuarios p = new frmMantenimientoUsuarios();
                                    p.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("No tienes Acceso, Contactate con el Administrador del Sistema", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre o Contraseña Incorrectos, Intentelo Nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

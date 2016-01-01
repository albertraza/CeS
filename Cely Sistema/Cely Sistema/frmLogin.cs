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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsuario.Text == string.Empty)
                {
                    MessageBox.Show("El Nombre de Usuario esta vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La Contraseña esta vacia, Digite una Valida", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Usuarios pU = new Usuarios();
                    pU.Nombre_Usuario = txtNombreUsuario.Text;
                    pU.Contraseña = txtContraseña.Text;
                    int R = UsuariosDB.Login(pU);
                    if (R > 0)
                    {
                        frmMenu pM = new frmMenu();
                        pM.ObNivel = int.Parse(UsuariosDB.ONivel(txtNombreUsuario.Text));
                        pM.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El Nombre o Contraseña no Validos, Digitelos Nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtContraseña.Clear();
                        txtNombreUsuario.Clear();
                        txtNombreUsuario.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                        MessageBox.Show("El Nombre de Usuario esta vacio, Digite uno Valido", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtContraseña.Text == string.Empty)
                    {
                        MessageBox.Show("La Contraseña esta vacia, Digite una Valida", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Usuarios pU = new Usuarios();
                        pU.Nombre_Usuario = txtNombreUsuario.Text;
                        pU.Contraseña = txtContraseña.Text;
                        int R = UsuariosDB.Login(pU);
                        if (R > 0)
                        {
                            frmMenu pM = new frmMenu();
                            pM.ObNivel = int.Parse(UsuariosDB.ONivel(txtNombreUsuario.Text));
                            pM.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El Nombre o Contraseña no Validos, Digitelos Nuevamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtContraseña.Clear();
                            txtNombreUsuario.Clear();
                            txtNombreUsuario.Focus();
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

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
    public partial class frmConfContraseña : Form
    {
        public frmConfContraseña()
        {
            InitializeComponent();
        }

        public string Contrasena { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Contrasena = null;
                if (txtConfirmacionContrasena.Text != string.Empty)
                {
                    Contrasena = txtConfirmacionContrasena.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Contraseña esta vacia, Digite una nueva contraseña", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtConfirmacionContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Contrasena = null;
                    if (txtConfirmacionContrasena.Text != string.Empty)
                    {
                        Contrasena = txtConfirmacionContrasena.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Contraseña esta vacia, Digite una nueva contraseña", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmConfContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}

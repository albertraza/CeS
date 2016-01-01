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
    public partial class frmBuscarFacturas : Form
    {
        public frmBuscarFacturas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtIDFactura.Clear();
            txtMatricula.Clear();
            txtNombre.Clear();
            txtNotas.Clear();
            txtPrecio.Clear();
            dtpFecha.Value = DateTime.Today;
            txtMatricula.Focus();
            dgvTabla.DataSource = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
            if (txtApellido.Text == string.Empty)
            {
                apellido = "";
            }
            else
            {
                apellido = " "+txtApellido.Text;
            }
            if (txtIDFactura.Text == string.Empty)
            {
                codigofa = "";
            }
            else
            {
                codigofa = txtIDFactura.Text;
            }
            if (txtMatricula.Text == string.Empty)
            {
                matricula = "";
            }
            else
            {
                matricula = txtMatricula.Text;
            }
            if (txtNombre.Text == string.Empty)
            {
                nombre = "";
            }
            else
            {
                nombre = txtNombre.Text;
            }
            if (txtNotas.Text == string.Empty)
            {
                notas = "";
            }
            else
            {
                notas = txtNotas.Text;
            }
            if (txtPrecio.Text == string.Empty)
            {
                precio = "";
            }
            else
            {
                precio = txtPrecio.Text;
            }
            if (dtpFecha.Value.Date == DateTime.Today.Date)
            {
                Fecha = "";
            }
            else
            {
                Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
            }
            try
            {
                dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre+apellido, precio, Fecha, codigofa, notas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool state;
        public bool getState
        {
            get { return state; }
            set { state = value; }
        }
        private void frmBuscarFacturas_Load(object sender, EventArgs e)
        {
            if (state == false)
            {
                try
                {
                    btnCancelarFactura.Visible = true;
                    dgvTabla.DataSource = FacturacionDB.TodasLasFacturasND();
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
                    dgvTabla.DataSource = FacturacionDB.TodasLasFacturasND();
                    btnCancelarFactura.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            try
            {
                dgvTabla.DataSource = FacturacionDB.TodasLasFacturasND();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count == 1)
            {
                string ID = dgvTabla.CurrentRow.Cells[6].Value.ToString();
                frmCancelacionPago cp = new frmCancelacionPago();
                cp.getCodigo = ID;
                cp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una factura de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtIDFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string matricula, precio, codigofa, nombre, apellido, notas, Fecha;
                if (txtApellido.Text == string.Empty)
                {
                    apellido = "";
                }
                else
                {
                    apellido = " " + txtApellido.Text;
                }
                if (txtIDFactura.Text == string.Empty)
                {
                    codigofa = "";
                }
                else
                {
                    codigofa = txtIDFactura.Text;
                }
                if (txtMatricula.Text == string.Empty)
                {
                    matricula = "";
                }
                else
                {
                    matricula = txtMatricula.Text;
                }
                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (txtNotas.Text == string.Empty)
                {
                    notas = "";
                }
                else
                {
                    notas = txtNotas.Text;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    precio = "";
                }
                else
                {
                    precio = txtPrecio.Text;
                }
                if (dtpFecha.Value.Date == DateTime.Today.Date)
                {
                    Fecha = "";
                }
                else
                {
                    Fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");
                }
                try
                {
                    dgvTabla.DataSource = FacturacionDB.BuscarFacturas1(matricula, nombre + apellido, precio, Fecha, codigofa, notas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busqueda de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

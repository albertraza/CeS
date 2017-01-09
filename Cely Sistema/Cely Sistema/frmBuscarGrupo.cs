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
    public partial class frmBuscarGrupo : Form
    {
        public frmBuscarGrupo()
        {
            InitializeComponent();
        }
        public bool menu { get; set; }

        private void frmBuscarGrupo_Load(object sender, EventArgs e)
        {
            dgvLista.ClearSelection();
            try
            {
                dgvLista.DataSource = pagoGrupal.listAllGrupos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (menu)
            {
                btnModificar.Visible = true;
                btnSeleccionar.Visible = false;
            }
            else
            {
                btnModificar.Visible = false;
                btnSeleccionar.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Clear();
                txtNombre.Clear();
                txtCodigo.Focus();
                dgvLista.DataSource = pagoGrupal.listAllGrupos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, codigo;

                if (txtCodigo.Text == string.Empty)
                {
                    codigo = "";
                }
                else
                {
                    codigo = txtCodigo.Text;
                }

                if (txtNombre.Text == string.Empty)
                {
                    nombre = "";
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                dgvLista.DataSource = pagoGrupal.searchGrupos(codigo, nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public pagoGrupal pInfoGrupoSeleccionado { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvLista.SelectedRows.Count == 1)
            {
                pInfoGrupoSeleccionado = pagoGrupal.getPagoGrupal(Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un Grupo de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!menu)
            {
                if (dgvLista.SelectedRows.Count == 1)
                {
                    pInfoGrupoSeleccionado = pagoGrupal.getPagoGrupal(Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona un Grupo de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (menu)
            {
                int codigoGrupo;
                codigoGrupo = Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value);
                frmFamilyConf pGrupo = new frmFamilyConf();
                pGrupo.codigoGrupo = codigoGrupo;
                pGrupo.menu = false;
                pGrupo.ShowDialog();
            }
        }

        private void gbBusqueda_Enter(object sender, EventArgs e)
        {

        }
    }
}

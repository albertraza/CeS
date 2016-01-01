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
    public partial class frmHorarioA : Form
    {
        public frmHorarioA()
        {
            InitializeComponent();
        }

        private void frmHorarioA_Load(object sender, EventArgs e)
        {
            dgvTabla.DataSource = HorariosDB.TodosLosHorarios();
            MaximizeBox = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string dias, hora;
                if (txtDias.Text == string.Empty)
                {
                    dias = "";
                }
                else
                {
                    dias = txtDias.Text;
                }
                if (txtHora.Text == string.Empty)
                {
                    hora = "";
                }
                else
                {
                    hora = txtHora.Text;
                }
                dgvTabla.DataSource = HorariosDB.BuscarHorarios(dias, hora);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Horarios pHS { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTabla.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvTabla.CurrentRow.Cells[0].Value);
                    pHS = HorariosDB.ObtenerHorario(ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Ha Seleccionado un Horario, Seleccione uno de la tabla", "Registro de Horario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string dias, hora;
                    if (txtDias.Text == string.Empty)
                    {
                        dias = "";
                    }
                    else
                    {
                        dias = txtDias.Text;
                    }
                    if (txtHora.Text == string.Empty)
                    {
                        hora = "";
                    }
                    else
                    {
                        hora = txtHora.Text;
                    }
                    dgvTabla.DataSource = HorariosDB.BuscarHorarios(dias, hora);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string dias, hora;
                    if (txtDias.Text == string.Empty)
                    {
                        dias = "";
                    }
                    else
                    {
                        dias = txtDias.Text;
                    }
                    if (txtHora.Text == string.Empty)
                    {
                        hora = "";
                    }
                    else
                    {
                        hora = txtHora.Text;
                    }
                    dgvTabla.DataSource = HorariosDB.BuscarHorarios(dias, hora);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

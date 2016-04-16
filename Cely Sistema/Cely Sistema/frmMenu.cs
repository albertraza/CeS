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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private Int32 Nivel = 9;
        public Int32 ObNivel
        {
            get { return Nivel; }
            set { Nivel = value; }
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'celyDBDataSet.VerGruposwHorario' Puede moverla o quitarla según sea necesario.
                this.verGruposwHorarioTableAdapter.Fill(this.celyDBDataSet.VerGruposwHorario);
                dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                Console.Write("Digite su nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite la contraseña: ");
                string contraseña = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para salir");
                ControlBox = false;
                MinimizeBox = false;
                MaximizeBox = false;
                btnBuscarEstudiante.Visible = false;
                tContador.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 1)
            {
                frmRegistro pRegistro = new frmRegistro();
                pRegistro.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buscarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 1)
            {
                frmCalificaciones pC = new frmCalificaciones();
                pC.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void hacerFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 1)
            {
                frmFacturacion pF = new frmFacturacion();
                pF.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso,contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void registroDeHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmRegistrodeHorarios pH = new frmRegistrodeHorarios();
                pH.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void registroDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmRegistrodeGruposyNiveles pGN = new frmRegistrodeGruposyNiveles();
                pGN.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void registroDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmMantenimientoProfesores pP = new frmMantenimientoProfesores();
                pP.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void lblAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarGrupos pGrupos = new frmBuscarGrupos();
            if (Nivel > 3)
            {
                pGrupos.getState = true;
                pGrupos.Show();
            }
            else
            {
                pGrupos.getState = false;
                pGrupos.Show();
            }
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusquedaDeAlumnos pEstudiante = new frmBusquedaDeAlumnos();
            if (Nivel > 3)
            {
                pEstudiante.getState = true;
                pEstudiante.Show();
            }
            else
            {
                pEstudiante.Show();
            }
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleados pEmpleados = new frmBuscarEmpleados();
            if (Nivel > 3)
            {
                pEmpleados.getState = true;
                pEmpleados.Show();
            }
            else
            {
                pEmpleados.getState = false;
                pEmpleados.Show();
            }
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarFacturas Factura = new frmBuscarFacturas();
            if (Nivel > 3)
            {
                Factura.getState = false;
                Factura.Show();
            }
            else
            {
                Factura.getState = true;
                Factura.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNiveles.SelectedRows.Count == -1)
                {
                    MessageBox.Show("No se ha seleccionado un estudiante", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvNiveles.CurrentRow.Cells[0].Value);
                    dgvEstudiantes.DataSource = GruposDB.EstudiantePorGrupo(ID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEstudiantes.DataSource = EstudianteDB.BuscarEstudiantePorMatrc(int.Parse(txtMatricula.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEstudiantes.DataSource = AsistenciaDB.BuscarAsistencia(Convert.ToInt32(txtMatricula.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                /// Matematica Asistencia (Añadir) ///
                if (dgvEstudiantes.SelectedRows.Count == 1)
                {
                    int matricula = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[12].Value);
                    int Ca;
                    Ca = Convert.ToInt32(AsistenciaDB.ObtenerTotalAsistencia(matricula));
                    Ca = Ca + 1;
                    /// Guardar la Asistencia ///
                    int R = AsistenciaDB.ActualizarCAsistencia(matricula, Ca);
                    if (R > 0)
                    {
                        MessageBox.Show("Asistencia Registrada!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la Asistencia", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int Ca;
                    Ca = Convert.ToInt32(AsistenciaDB.ObtenerTotalAsistencia(Convert.ToInt32(txtMatricula.Text)));
                    Ca = Ca + 1;
                    /// Guardar la Asistencia ////////
                    int R = AsistenciaDB.ActualizarCAsistencia(int.Parse(txtMatricula.Text), Ca);
                    if (R > 0)
                    {
                        MessageBox.Show("Asistencia Registrada!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la Asistencia", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbAsistencia_Enter(object sender, EventArgs e)
        {

        }

        private void cancelacionDeCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmCancelacionPago pC = new frmCancelacionPago();
                pC.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2 || Nivel == 9)
            {
                frmMantenimientodeUsuariosLogin p = new frmMantenimientodeUsuariosLogin();
                p.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmMantenimientoGanancias pG = new frmMantenimientoGanancias();
                pG.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void registroDeMoraYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmMontoPagosyMora pP = new frmMontoPagosyMora();
                pP.Show();
            }
            else
            {
                MessageBox.Show("No Tienenes Acceso, contacta el administrador del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void calificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Nivel > 2)
            {
                frmReporteCalificacionesTo p = new frmReporteCalificacionesTo();
                p.Show();
            }
            else
            {
                MessageBox.Show("No tienes Acceso, contacta el administrados del sistema", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCalificacion bc = new frmBuscarCalificacion();
            bc.Show();
        }

        private void manualDelUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios cu = new frmConsultaUsuarios();
            cu.Show();
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 3)
            {
                frmConsultaGanancias cg = new frmConsultaGanancias();
                cg.Show();
            }
            else
            {
                MessageBox.Show("No tienes Acceso, Contacta al Administrador del Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    dgvEstudiantes.DataSource = AsistenciaDB.BuscarAsistencia(Convert.ToInt32(txtMatricula.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ingresosVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nivel > 3)
            {
                frmPagosVIP pP = new frmPagosVIP();
                pP.Show();
            }
            else
            {
                MessageBox.Show("No tienes Acceso, Contacta al Administrador del Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void tContador_Tick(object sender, EventArgs e)
        {
            try
            {
                dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

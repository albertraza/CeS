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
    public partial class frmRegistrodeGruposyNiveles : Form
    {
        public frmRegistrodeGruposyNiveles()
        {
            InitializeComponent();
        }

        bool p1 = false, p2 = false;
        public Horarios pHs { get; set; }
        public void Limpiar()
        {
            txtNivel.Focus();
            txtHorario.Clear();
            txtNivel.Clear();
            txtProfesor.Clear();
            pHs = null;
            dtpFechaInicio.Value = DateTime.Now;
            cbAula.Text = "";
        }
        private void lblBuscarHorario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmHorarioA pH = new frmHorarioA();
                pH.ShowDialog();

                if (pH.pHS != null)
                {
                    pHs = pH.pHS;
                    txtHorario.Text = pH.pHS.Dias.ToString() + " " + pH.pHS.Hora.ToString();
                    p1 = true;
                    dtpFechaInicio.Focus();
                    if (p1 == true & p2 == true)
                    {
                        btnGuardar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se Pudo cargar el Horario, Intentelo Nuevamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string IDg;
        public string getID
        {
            get { return IDg; }
            set { IDg = value; }
        }
        private void frmRegistrodeGruposyNiveles_Load(object sender, EventArgs e)
        {
            if (IDg != null)
            {
                btnGuardar.Enabled = false;
                try
                {
                    pGS = GruposDB.ObtenerGrupos(int.Parse(IDg));
                    pHs = HorariosDB.ObtenerHorario(int.Parse(pGS.Horario));
                    txtHorario.Text = pHs.Dias + " " + pHs.Hora;
                    txtNivel.Text = pGS.Nivel;
                    txtProfesor.Text = pGS.Profesor;
                    dtpFechaInicio.Value = Convert.ToDateTime(pGS.Fecha_Inicio);
                    cbAula.Text = pGS.Aula;
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtProfesor.Enabled = false;
                txtHorario.Enabled = false;
                MaximizeBox = false;
                try
                {
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        public Profesores pPS { get; set; }
        private void lblBuscarProfesor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmProfesoresA pp = new frmProfesoresA();
                pp.ShowDialog();

                if (pp.pPS != null)
                {
                    pPS = pp.pPS;
                    txtProfesor.Text = pp.pPS.Nombre.ToString() + " " + pp.pPS.Apellido.ToString();
                    cbAula.Focus();
                    p2 = true;
                    if (p1 == true & p2 == true)
                    {
                        btnGuardar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Se Produjo un Error, Intentelo Nuevamente", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (p1 == true & p2 == true)
                {
                    Grupos pG = new Grupos();

                    pG.Nivel = txtNivel.Text;
                    pG.Profesor = txtProfesor.Text;
                    pG.Total_Inscritos = 0;
                    pG.Horario = pHs.ID.ToString();

                    if (cbAula.SelectedIndex == -1)
                    {
                        MessageBox.Show("No se Ha Seleccionado una Aula, Seleccione uno de la lista", "Registro de Niveles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        object obt = cbAula.SelectedItem;
                        pG.Aula = obt.ToString();
                    }
                    pG.Fecha_Inicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");

                    int G = GruposDB.AgregarGrupo(pG);

                    if (G > 0)
                    {
                        MessageBox.Show("Grupo Registrado con Exito", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        p1 = false;
                        p2 = false;
                        btnGuardar.Enabled = false;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Registrar el Grupo, Intentelo Nuevamnete", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Complete el Horario y el Profesor, Elija uno valido", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Grupos pGS { get; set; }
        private void btnSeleccionarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNiveles.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvNiveles.CurrentRow.Cells[0].Value);
                    pGS = GruposDB.ObtenerGrupos(ID);

                    if (pGS != null)
                    {
                        txtProfesor.Text = pGS.Profesor;
                        txtNivel.Text = pGS.Nivel;
                        pHs = HorariosDB.ObtenerHorario(int.Parse(pGS.Horario));
                        txtHorario.Text = pHs.Dias + " " + pHs.Hora;
                        cbAula.Text = pGS.Aula;
                        string fechaI = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");
                        fechaI = pGS.Fecha_Inicio;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Cargar el Estudiante, Intentelo Nuevamente", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado un Grupo, Seleccione uno de la Tabla", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                Grupos pG = new Grupos();

                if (pGS != null)
                {
                    pG.ID = pGS.ID;
                    pG.Nivel = txtNivel.Text;
                    pG.Profesor = txtProfesor.Text;
                    pG.Horario = pHs.ID.ToString();
                    pG.Fecha_Inicio = dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd");

                    if (cbAula.SelectedIndex == -1)
                    {
                        MessageBox.Show("No se Ha Seleccionado una Aula, Seleccione uno de la lista", "Registro de Niveles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        object obt = cbAula.SelectedItem;
                        pG.Aula = obt.ToString();
                    }

                    if (MessageBox.Show("Seguro que desea modificar el Grupo?", "Registro de Grupos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int G = GruposDB.ModificarGrupo(pG);

                        if (G > 0)
                        {
                            MessageBox.Show("Grupo Modificado con Exito", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Modificar el Grupo, Intentelo Nuevamente", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Horario de la Tabla", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                if (MessageBox.Show("Seguro que desea Eliminar el Grupo?", "Registro de Grupos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (MessageBox.Show("AVISO! Algunos estudiantes seran afectados con el cambio que se realizara, Desea Continuar?", "Registro de Grupos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int G = GruposDB.EliminarGrupo(pGS.ID);

                        if (G > 0)
                        {
                            MessageBox.Show("Grupo Eliminado con Exito", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Eliminar el Grupo, Intentelo Nuevamente", "Registro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            Limpiar();
        }

        public Int32 ID { get; set; }
        public List<Estudiante> EstudiantesPN { get; set; }
        private void btnVerEstudiantesR_Click(object sender, EventArgs e)
        {
            try
            {
                frmEstudiantePorNivel pE = new frmEstudiantePorNivel();
                if (dgvNiveles.SelectedRows.Count == 1)
                {
                    pE.getID = Convert.ToInt32(dgvNiveles.CurrentRow.Cells[0].Value);
                    pE.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un nivel, Seleccione uno de la lista", "Control de Nieveles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lblBuscarProfesor.Focus();
            }
        }

        private void cbAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lblBuscarHorario.Focus();
            }
        }

        private void txtHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpFechaInicio.Focus();
            }
        }

        private void dtpFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
        }
    }
}
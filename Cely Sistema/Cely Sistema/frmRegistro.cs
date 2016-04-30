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
    public partial class frmRegistro : Form
    {
        public EstudianteBase EstudianteSeleccionado { get; set; }
        public Grupos pGS { get; set; }
        public void Limpiar()
        {
            txtCelular.Clear();
            txtRespuesta1.Clear();
            txtRespuesta2.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            cbD_Idioma.Text = "";
            txtEdad.Clear();
            txtEmail.Clear();
            txtNivel.Clear();
            cbN_Academico.Text = "";
            txtOcupacion.Clear();
            txtSector.Clear();
            txtTelefono.Clear();
            cbVIP.Checked = false;
            rbMensual.Checked = false;
            rbSemanal.Checked = false;
        }
        public frmRegistro()
        {
            InitializeComponent();
        }
        private EstudianteBase IDEstudiante;
        public EstudianteBase GetIDestudiante
        {
            get { return IDEstudiante; }
            set { IDEstudiante = value; }
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            if (IDEstudiante != null)
            {
                try
                {
                    EstudianteSeleccionado = IDEstudiante;
                    txtNombre.Text = EstudianteSeleccionado.Nombre;
                    txtApellido.Text = EstudianteSeleccionado.Apellido;
                    txtDireccion.Text = EstudianteSeleccionado.Direccion;
                    cbD_Idioma.Text = EstudianteSeleccionado.D_Idioma;
                    txtEdad.Text = EstudianteSeleccionado.Edad;
                    txtEmail.Text = EstudianteSeleccionado.E_Mail;
                    txtNivel.Text = EstudianteSeleccionado.NivelA;
                    cbN_Academico.Text = EstudianteSeleccionado.N_Academico;
                    txtOcupacion.Text = EstudianteSeleccionado.Ocupacion;
                    txtSector.Text = EstudianteSeleccionado.Sector;
                    txtTelefono.Text = EstudianteSeleccionado.Telefono;
                    txtCelular.Text = EstudianteSeleccionado.Celular;
                    txtRespuesta1.Text = EstudianteSeleccionado.Respuesta1;
                    txtRespuesta2.Text = EstudianteSeleccionado.Respuesta2;
                    CodigoNivelAnterior = EstudianteSeleccionado.Codigo_Grupo;
                    pGrupoAnteriol = GruposDB.ObtenerGrupos(EstudianteSeleccionado.Codigo_Grupo);
                    dtpFechaActual.Value = Convert.ToDateTime(EstudianteSeleccionado.Fecha_Ins);
                    dtpFechaNacimiento.Value = Convert.ToDateTime(EstudianteSeleccionado.Fecha_N);
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                    btnRegistrar.Enabled = false;
                    txtNivel.Enabled = false;
                    if (EstudianteSeleccionado.Modo_Pago == "Mensual")
                    {
                        rbMensual.Checked = true;
                    }
                    else
                    {
                        rbSemanal.Checked = true;
                    }
                    if(EstudianteSeleccionado.VIP == "Si")
                    {
                        cbVIP.Checked = true;
                    }
                    else
                    {
                        cbVIP.Checked = false;
                    }

                    btnRegistrar.Visible = false;
                    lblBuscarAlumno.Visible = false;
                    lblTitulo.Text = "Estudiante";
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'celyDBDataSet.VerGruposwHorario' Puede moverla o quitarla según sea necesario.
                this.verGruposwHorarioTableAdapter.Fill(this.celyDBDataSet.VerGruposwHorario);
                try
                {
                    txtNivel.Enabled = false;
                    this.txtNombre.Focus();
                    ControlBox = false;
                    MinimizeBox = true;
                    MaximizeBox = false;
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    lblBuscarAlumno.Visible = true;
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                    btnRegistrar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Nombre Vacio, Complete El Campo Nombre", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                }
                else if(txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("Apellido Vacio, Complete El Campo Apellido", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellido.Focus();
                }
                else if(txtDireccion.Text == string.Empty)
                {
                    MessageBox.Show("Direccion Vacia, Complete El Campo Direccion", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                }
                else if(txtEdad.Text == string.Empty)
                {
                    MessageBox.Show("Edad Vacia, Complete El Campo Edad", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEdad.Focus();
                }
                else if(dtpFechaNacimiento.Value == DateTime.Today)
                {
                    MessageBox.Show("Fecha Vacia, Complete El Campo Fecha de Nacimiento Con la fecha de nacimiento", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaNacimiento.Focus();
                }
                else if(!txtTelefono.MaskCompleted)
                {
                    MessageBox.Show("Telefono Vacio, Complete El Campo Telefono", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                }
                else if(txtSector.Text == string.Empty)
                {
                    MessageBox.Show("Sector Vacio, Complete El Campo Sector", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSector.Focus();
                }
                else if(txtOcupacion.Text == string.Empty)
                {
                    MessageBox.Show("Ocupacion Vacia, Complete El Campo Ocupacion", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOcupacion.Focus();
                }
                else if(cbN_Academico.Text == string.Empty)
                {
                    MessageBox.Show("Nivel Academico Vacio, Complete El Campo Nivel Academico", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbN_Academico.Focus();
                }
                else if(cbD_Idioma.Text == string.Empty)
                {
                    MessageBox.Show("Dominio del Idioma Vacio, Complete El Campo Dominio del Idioma", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbD_Idioma.Focus();
                }
                else if (txtNivel.Text == string.Empty)
                {
                    MessageBox.Show("Nivel Vacio, Complete El Campo Nivel", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNivel.Focus();
                }
                else if (!txtCelular.MaskCompleted)
                {
                    MessageBox.Show("Complete el Celular del Estudiante", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
                else if(txtRespuesta1.Text == string.Empty)
                {
                    MessageBox.Show("La respuesta a la pregunta numero 1 esta vacia", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRespuesta1.Focus();
                }
                else if(txtRespuesta2.Text == string.Empty)
                {
                    MessageBox.Show("La respuesta a la pregunta numero 2 esta vacia", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRespuesta2.Focus();
                }
                else
                {
                    EstudianteBase pE = new EstudianteBase();
                    pE.Nombre = txtNombre.Text;
                    pE.Apellido = txtApellido.Text;
                    pE.D_Idioma = cbD_Idioma.Text;
                    pE.Direccion = txtDireccion.Text;
                    pE.E_Mail = txtEmail.Text;
                    pE.Edad = txtEdad.Text;
                    pE.Fecha_Ins = dtpFechaActual.Value.Date.ToString("yyyy-MM-dd");
                    pE.Fecha_N = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");
                    pE.N_Academico = cbN_Academico.Text;
                    pE.Ocupacion = txtOcupacion.Text;
                    pE.Sector = txtSector.Text;
                    pE.Telefono = txtTelefono.Text;
                    pE.NivelA = txtNivel.Text;
                    /* Struct Utilizado para rellenar la Asistencia */
                    Asistencia pA = new Asistencia();
                    if(rbMensual.Checked == true)
                    {
                        pE.Modo_Pago = rbMensual.Text;
                    }
                    else
                    {
                        pE.Modo_Pago = rbSemanal.Text;
                    }
                    pE.Codigo_Grupo = pGS.ID;

                    int r = EstudianteDB.RegistrarEstudiante(pE, txtCelular.Text, txtRespuesta1.Text, txtRespuesta2.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("Estudiante Registrado con exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string matricula = EstudianteDB.ObtenerMatricula(pE);
                        if (matricula != null)
                        {

                            MessageBox.Show("La Matricula del nuevo estudiante es: " + matricula, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (cbVIP.Checked == true)
                            {
                                string res = "Si";
                                EstudianteDB.UpdateVIPstatus(res, matricula.ToString());
                            }
                            else
                            {
                                string res = "No";
                                EstudianteDB.UpdateVIPstatus(res, matricula.ToString());
                            }

                            // Analizis de la fecha de pago para el Estudiante
                            string FechaProximoP = FechaPP.ToString("yyyy-MM-dd");
                            EstudianteDB.ActualizarProximoPago(int.Parse(matricula), FechaProximoP);
                            /* Datos para registrar Asistencia */
                            pA.Nombre = txtNombre.Text + " " + txtApellido.Text;
                            pA.Matricula = int.Parse(matricula);
                            pA.Fecha_Inicio = DateTime.Today.Date.ToString("yyyy-MM-dd");
                            pA.CAsistencia = 0;
                            pA.Ultima_Asistencia = DateTime.Today.Date.ToString("yyyy-MM-dd");
                            AsistenciaDB.RegistrarAsistencia(pA);
                            Limpiar();
                            int NTotalInscritos = GruposDB.ObtenerTotalInscritos(pID);
                            int NuevaCant = NTotalInscritos + 1;
                            GruposDB.ActualizarCantidadEstudiantes(pID, NuevaCant);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el estudiante", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblBuscarAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmBusquedaDeAlumnos pBusqueda = new frmBusquedaDeAlumnos();
                pBusqueda.ShowDialog();

                if (pBusqueda.EstudianteSeleccionado != null)
                {
                    EstudianteSeleccionado = pBusqueda.EstudianteSeleccionado;
                    txtNombre.Text = pBusqueda.EstudianteSeleccionado.Nombre;
                    txtApellido.Text = pBusqueda.EstudianteSeleccionado.Apellido;
                    txtDireccion.Text = pBusqueda.EstudianteSeleccionado.Direccion;
                    cbD_Idioma.Text = pBusqueda.EstudianteSeleccionado.D_Idioma;
                    txtEdad.Text = pBusqueda.EstudianteSeleccionado.Edad;
                    txtEmail.Text = pBusqueda.EstudianteSeleccionado.E_Mail;
                    txtNivel.Text = pBusqueda.EstudianteSeleccionado.NivelA;
                    cbN_Academico.Text = pBusqueda.EstudianteSeleccionado.N_Academico;
                    txtOcupacion.Text = pBusqueda.EstudianteSeleccionado.Ocupacion;
                    txtSector.Text = pBusqueda.EstudianteSeleccionado.Sector;
                    txtTelefono.Text = pBusqueda.EstudianteSeleccionado.Telefono;
                    txtCelular.Text = pBusqueda.EstudianteSeleccionado.Celular;
                    txtRespuesta1.Text = pBusqueda.EstudianteSeleccionado.Respuesta1;
                    txtRespuesta2.Text = pBusqueda.EstudianteSeleccionado.Respuesta2;
                    dtpFechaActual.Value = Convert.ToDateTime(pBusqueda.EstudianteSeleccionado.Fecha_Ins);
                    dtpFechaNacimiento.Value = Convert.ToDateTime(pBusqueda.EstudianteSeleccionado.Fecha_N);
                    CodigoNivelAnterior = pBusqueda.EstudianteSeleccionado.Codigo_Grupo;
                    pGrupoAnteriol = GruposDB.ObtenerGrupos(pBusqueda.EstudianteSeleccionado.Codigo_Grupo);

                    if(pBusqueda.EstudianteSeleccionado.Modo_Pago == "Mensual")
                    {
                        rbMensual.Checked = true;
                    }
                    else
                    {
                        rbSemanal.Checked = true;
                    }
                    // VIP estudiante
                    if (pBusqueda.EstudianteSeleccionado.VIP == "Si")
                    {
                        cbVIP.Checked = true;
                    }
                    else
                    {
                        cbVIP.Checked = false;
                    }
                    btnRegistrar.Visible = false;
                    lblBuscarAlumno.Visible = false;
                    lblTitulo.Text = "Estudiante";
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro Estudiantil", MessageBoxButtons.OK);
            }
        }
        private int CodigoNivelAnterior { get; set; }
        private int codigoNuevoGrupo { get; set; }
        private Grupos nuevoGrupo { get; set; }
        private Grupos pGrupoAnteriol { get; set; }
        private void getGrupoAnteriol()
        {
            pGrupoAnteriol = GruposDB.ObtenerGrupos(CodigoNivelAnterior);
        }
        private void getNuevoGrupo()
        {
            nuevoGrupo = GruposDB.ObtenerGrupos(codigoNuevoGrupo);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Nombre Vacio, Complete El Campo Nombre", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                }
                else if (txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("Apellido Vacio, Complete El Campo Apellido", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellido.Focus();
                }
                else if (txtDireccion.Text == string.Empty)
                {
                    MessageBox.Show("Direccion Vacia, Complete El Campo Direccion", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                }
                else if (txtEdad.Text == string.Empty)
                {
                    MessageBox.Show("Edad Vacia, Complete El Campo Edad", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEdad.Focus();
                }
                else if (dtpFechaNacimiento.Value == DateTime.Today)
                {
                    MessageBox.Show("Fecha Vacia, Complete El Campo Fecha de Nacimiento Con la fecha de nacimiento", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaNacimiento.Focus();
                }
                else if (txtTelefono.Text == string.Empty)
                {
                    MessageBox.Show("Telefono Vacio, Complete El Campo Telefono", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                }
                else if (txtSector.Text == string.Empty)
                {
                    MessageBox.Show("Sector Vacio, Complete El Campo Sector", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSector.Focus();
                }
                else if (txtOcupacion.Text == string.Empty)
                {
                    MessageBox.Show("Ocupacion Vacia, Complete El Campo Ocupacion", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOcupacion.Focus();
                }
                else if (cbN_Academico.Text == string.Empty)
                {
                    MessageBox.Show("Nivel Academico Vacio, Complete El Campo Nivel Academico", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbN_Academico.Focus();
                }
                else if (cbD_Idioma.Text == string.Empty)
                {
                    MessageBox.Show("Dominio del Idioma Vacio, Complete El Campo Dominio del Idioma", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbD_Idioma.Focus();
                }
                else if (txtNivel.Text == string.Empty)
                {
                    MessageBox.Show("Nivel Vacio, Complete El Campo Nivel", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNivel.Focus();
                }
                else if (!txtCelular.MaskCompleted)
                {
                    MessageBox.Show("El Celular esta vacio", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
                else if (txtRespuesta1.Text == string.Empty)
                {
                    MessageBox.Show("La respuesta a la primera pregunta esta vacia, digite una valida", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRespuesta1.Focus();
                }
                else if (txtRespuesta2.Text == string.Empty)
                {
                    MessageBox.Show("La respuesta a la segunda pregunta esta vacia", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRespuesta2.Focus();
                }
                else
                {
                    // *Actualizar canti Nivel* //
                    Int64 ID = EstudianteSeleccionado.ID;
                    // ************************ //

                    EstudianteBase pEstudiante = new EstudianteBase();

                    pEstudiante.Nombre = txtNombre.Text;
                    pEstudiante.Apellido = txtApellido.Text;
                    pEstudiante.Direccion = txtDireccion.Text;
                    pEstudiante.Edad = txtEdad.Text;
                    pEstudiante.Fecha_N = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");
                    pEstudiante.Telefono = txtTelefono.Text;
                    pEstudiante.Sector = txtSector.Text;
                    pEstudiante.E_Mail = txtEmail.Text;
                    pEstudiante.Ocupacion = txtOcupacion.Text;
                    pEstudiante.Fecha_Ins = dtpFechaActual.Value.Date.ToString("yyyy-MM-dd");
                    pEstudiante.N_Academico = cbN_Academico.Text;
                    pEstudiante.D_Idioma = cbD_Idioma.Text;
                    pEstudiante.NivelA = txtNivel.Text;
                    pEstudiante.ID = EstudianteSeleccionado.ID;
                    pEstudiante.Respuesta1 = txtRespuesta1.Text;
                    pEstudiante.Respuesta2 = txtRespuesta2.Text;
                    pEstudiante.Celular = txtCelular.Text;

                    if (rbMensual.Checked == true)
                    {
                        pEstudiante.Modo_Pago = rbMensual.Text;
                    }
                    else
                    {
                        pEstudiante.Modo_Pago = rbSemanal.Text;
                    }

                    int retorno;
                    // verificar si el codigo del grupo fue canbiado
                    if (pEstudiante.Codigo_Grupo != codigoNuevoGrupo)
                    {
                        pEstudiante.Codigo_Grupo = codigoNuevoGrupo;
                        retorno = EstudianteDB.Modificar(pEstudiante);
                    }
                    else if (pGrupoAnteriol.ID != 0)
                    {
                        pEstudiante.Codigo_Grupo = CodigoNivelAnterior;
                        retorno = EstudianteDB.Modificar(pEstudiante);
                    }
                    else
                    {
                        MessageBox.Show("El codigo del nivel del estudiante es igual a cero", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        retorno = 0;
                    }

                    if (retorno > 0)
                    {
                        if (CodigoNivelAnterior != codigoNuevoGrupo & codigoNuevoGrupo != 0 & CodigoNivelAnterior != 0)
                        {
                            int CantidadEstudiantesGrupoAnt = GruposDB.ObtenerTotalInscritos(CodigoNivelAnterior);
                            int NuevacantGrupoAnt = CantidadEstudiantesGrupoAnt - 1;
                            int R0 = GruposDB.ActualizarCantidadEstudiantes(CodigoNivelAnterior, NuevacantGrupoAnt);
                            int CantEstudiantesNuevoGrupo = GruposDB.ObtenerTotalInscritos(pGS.ID);
                            int NuevaCantNuevoGrupo = CantEstudiantesNuevoGrupo + 1;
                            int R1 = GruposDB.ActualizarCantidadEstudiantes(codigoNuevoGrupo, NuevaCantNuevoGrupo);
                            if (R1 > 0 & R0 > 0)
                            {
                                MessageBox.Show("Estudiante Modificado con Exito", "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // VIP student
                                if (cbVIP.Checked == true)
                                {
                                    EstudianteDB.UpdateVIPstatus("Si", pEstudiante.ID.ToString());
                                }
                                else
                                {
                                    EstudianteDB.UpdateVIPstatus("No", pEstudiante.ID.ToString());
                                }
                                Limpiar();
                                btnModificar.Visible = false;
                                btnEliminar.Visible = false;
                                btnRegistrar.Visible = true;
                                lblBuscarAlumno.Visible = true;
                            }
                        }
                        else if (CodigoNivelAnterior != 0)
                        {
                            MessageBox.Show("Estudiante Modificado con Exito", "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // VIP student
                            if (cbVIP.Checked == true)
                            {
                                EstudianteDB.UpdateVIPstatus("Si", pEstudiante.ID.ToString());
                            }
                            else
                            {
                                EstudianteDB.UpdateVIPstatus("No", pEstudiante.ID.ToString());
                            }
                            Limpiar();
                            btnModificar.Visible = false;
                            btnEliminar.Visible = false;
                            btnRegistrar.Visible = true;
                            lblBuscarAlumno.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Modificar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea Eliminar el Estudiante?", "Registro Estudiantil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int retorno = EstudianteDB.EliminarEstudiante(EstudianteSeleccionado);

                    if (retorno > 0)
                    {
                        int CantidadEstudiantesNi = GruposDB.ObtenerTotalInscritos(EstudianteSeleccionado.Codigo_Grupo);
                        int NuevaCantidad = CantidadEstudiantesNi - 1;
                        int R0 = GruposDB.ActualizarCantidadEstudiantes(EstudianteSeleccionado.Codigo_Grupo, NuevaCantidad);
                        btnRegistrar.Visible = true;
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        lblBuscarAlumno.Visible = true;
                        if (R0 > 0)
                        {
                            MessageBox.Show("Estudiante Eliminado Esxitosamente", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Eliminar el Estudiante, Intentelo Nuevamente", "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro Estudiantil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime FechaPP;
        private int CantidadInscritos {get; set;}
        private Int32 pID { get; set; }
        private DateTime FI { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNiveles.SelectedRows.Count == 1)
                {
                    Int32 ID;
                    ID = Convert.ToInt32(dgvNiveles.CurrentRow.Cells[0].Value);
                    pID = ID;
                    codigoNuevoGrupo = ID;
                    pGS = GruposDB.ObtenerGrupos(ID);
                    // obetner el nuevo grupo para modificar el estudiante
                    getNuevoGrupo();
                    // Obtener cantidad Inscritos
                    CantidadInscritos = GruposDB.ObtenerTotalInscritos(ID);


                    DateTime FechaI, FechaA;

                    FechaI = GruposDB.ObtenerFechaInicio(ID);
                    FI = FechaI;

                    FechaA = DateTime.Today;

                    double comp;
                    
                    if (rbMensual.Checked == true)
                    {
                        comp = (FechaA - FechaI).TotalDays / 30;
                        if (comp <= 0)
                        {
                            FechaPP = FechaI.AddMonths(1);
                        }
                        else
                        {
                            FechaPP = FechaA.AddMonths(1);
                        }
                    }
                    else if (rbSemanal.Checked)
                    {
                        comp = (FechaA - FechaI).TotalDays / 7;
                        if (comp <= 0)
                        {
                            FechaPP = FechaI.AddDays(7);
                        }
                        else
                        {
                            FechaPP = FechaA.AddDays(7);
                        }
                    }
                    if (pGS != null)
                    {
                        txtNivel.Text = pGS.Nivel;
                        txtNivel.Enabled = false;
                        btnRegistrar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Nivel de la Lista", "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNiveles.DataSource = GruposDB.BuscarGruposPorFechaInicio(dtpFechadeInicio.Value.Date.ToString("yyyy-MM-dd"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechadeInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGruposPorFechaInicio(dtpFechadeInicio.Value.Date.ToString("yyyy-MM-dd"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFechaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpFechaNacimiento.Focus();
            }
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSector.Focus();
            }
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtOcupacion.Focus();
            }
        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbN_Academico.Focus();
            }
        }

        private void cbN_Academico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRespuesta1.Focus();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbN_Academico.Focus();
            }
        }

        private void rbSemanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbVIP.Focus();
            }
        }

        private void rbMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rbSemanal.Focus();
            }
        }

        private void gbEstudiante_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCelular.Focus();
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbD_Idioma.Focus();
            }
        }

        private void cbD_Idioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEdad.Focus();
            }
        }

        private void txtRespuesta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rbMensual.Focus();
            }
        }

        private void txtRespuesta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRespuesta2.Focus();
            }
        }

        private void cbVIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnRegistrar.Focus();
            }
        }
    }
}

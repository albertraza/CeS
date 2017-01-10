using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cely_Sistema
{
    public partial class frmMenu : Form
    {
        // metodo para cargar los estudiantes inscritos en cada nivel
        private void loadEstudiantesEnNivel()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // metodo para cargar los horarios
        private void loadHorarios()
        {
            txtBusqueda.Items.Clear();
            using(SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("select ID, Dias + ' ' + Hora as Horario from Horarios", con);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    txtBusqueda.Items.Add(reader["Horario"]);
                }
            }
        }

        // metodo para cargar los profesores
        private void loadProfesores()
        {
            txtBusqueda.Items.Clear();
            using (SqlConnection con = DBcomun.ObetenerConexion())
            {
                SqlCommand comand = new SqlCommand("Select ID, Nombre + ' ' + Apellido as Profesor from Profesores", con);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    txtBusqueda.Items.Add(reader["Profesor"]);
                }

            }
        }

        // metodo para cargar las Aulas
        private void loadAulas()
        {
            txtBusqueda.Items.Clear();

            txtBusqueda.Items.Add("A");
            txtBusqueda.Items.Add("B");
            txtBusqueda.Items.Add("C");
        }

        // metodo para limpiar el fitro de niveles
        private void limpiarFiltroNiveles()
        {
            cbFiltro.SelectedIndex = -1;
            txtBusqueda.Items.Clear();
            txtBusqueda.Text = "";
            dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
            dgvNiveles.ClearSelection();

            dgvEstudiantes.DataSource = "";
        }

        // metodo para filtrar los niveles
        private void filtrarNiveles()
        {
            try
            {
                if (cbFiltro.Text == "Horario")
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos("", "", "", "", txtBusqueda.Text);
                }
                else if (cbFiltro.Text == "Profesor")
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos("", txtBusqueda.Text, "", "", "");
                }
                else if (cbFiltro.Text == "Aula")
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos("", "", "", txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Nivel")
                {
                    dgvNiveles.DataSource = GruposDB.BuscarGrupos(txtBusqueda.Text, "", "", "", "");
                }
                else if(cbFiltro.Text == "")
                {
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmMenu()
        {
            InitializeComponent();
        }
        private void DisabledConsultaItens()
        {
            txtApellido.Enabled = false;
            txtCelular.Enabled = false;
            txtDireccion.Enabled = false;
            txtDominiodelIdiomaIngles.Enabled = false;
            txtEdad.Enabled = false;
            txtEmail.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtFechaRegistro.Enabled = false;
            txtMora.Enabled = false;
            txtNivel.Enabled = false;
            txtNivelAcademico.Enabled = false;
            txtNombre.Enabled = false;
            txtOcupacion.Enabled = false;
            txtPagoMensual.Enabled = false;
            txtSector.Enabled = false;
            txtTelefono.Enabled = false;
        }
        private void LoadStudentData()
        {
            if (txtMatriculaCon.Text == string.Empty)
            {
                MessageBox.Show("La matricula esta vacia, digite la matricula del estudiante a buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatriculaCon.Focus();
            }
            else
            {
                EstudianteBase pEstudiante = EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatriculaCon.Text));

                if (EstudianteDB.ObtenerNombre(int.Parse(txtMatriculaCon.Text)) != null)
                {
                    btnEliminar.Visible = true;
                    btnHacerFactura.Visible = true;
                    btnModificar.Visible = true;
                    btnRetirarEstudiante.Visible = true;
                    txtApellido.Text = pEstudiante.Apellido;
                    txtCelular.Text = pEstudiante.Celular;
                    txtDireccion.Text = pEstudiante.Direccion;
                    txtDominiodelIdiomaIngles.Text = pEstudiante.D_Idioma;
                    txtEdad.Text = pEstudiante.Edad;
                    txtEmail.Text = pEstudiante.E_Mail;
                    txtFechaNacimiento.Text = Convert.ToDateTime(pEstudiante.Fecha_N).ToString("dd-MM-yyyy");
                    txtFechaRegistro.Text = Convert.ToDateTime(pEstudiante.Fecha_Ins).ToString("dd-MM-yyyy");
                    lblTipodePago.Text = "Tipo de Pago: " + pEstudiante.Modo_Pago;
                    txtNivel.Text = pEstudiante.NivelA;
                    txtNivelAcademico.Text = pEstudiante.N_Academico;
                    txtNombre.Text = pEstudiante.Nombre;
                    txtOcupacion.Text = pEstudiante.Ocupacion;
                    txtSector.Text = pEstudiante.Sector;
                    txtTelefono.Text = pEstudiante.Telefono;

                    // getting payments info
                    if (EstudianteDB.getRetirado(Convert.ToInt32(txtMatriculaCon.Text)) != 1)
                    {


                        if (pEstudiante.VIP == "NO" || pEstudiante.VIP == "No")
                        {
                            lblVIP.ForeColor = Color.Black;
                            lblVIP.Text = "VIP: " + pEstudiante.VIP;

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                txtPagoMensual.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).precio.ToString("f2");
                                txtMora.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).mora.ToString("f2");
                            }
                            else
                            {
                                txtPagoMensual.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).precio.ToString("f2");
                                txtMora.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).mora.ToString("f2");
                            }
                        }
                        else
                        {
                            lblVIP.ForeColor = Color.Red;
                            lblVIP.Text = "VIP: " + pEstudiante.VIP;

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                txtPagoMensual.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).precio.ToString("f2");
                                txtMora.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).mora.ToString("f2");
                            }
                            else
                            {
                                txtPagoMensual.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).precio.ToString("f2");
                                txtMora.Text = PagosDB.getPrecio(int.Parse(txtMatriculaCon.Text)).mora.ToString("f2");
                            }
                        }

                        DateTime fp = EstudianteDB.ObtenerFechaProximoPago(int.Parse(txtMatriculaCon.Text));
                        DateTime fa = DateTime.Today.Date;

                        int Comp = DateTime.Compare(fp, fa);

                        if (Comp < 0)
                        {
                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                lblProximoPago.ForeColor = Color.Red;
                                lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();
                                double P = (DateTime.Today.Date - fp).TotalDays / 30;
                                if (P < 0)
                                {
                                    P *= -1;
                                }
                                int raw = Convert.ToInt32(P);
                                lblPendientes.ForeColor = Color.Red;
                                lblPendientes.Text = "Meses Pendientes: " + raw.ToString();
                                double totalMora = double.Parse(txtMora.Text) * (raw);
                                double totalpagar = (double.Parse(txtPagoMensual.Text) * (raw + 1)) + totalMora;
                                lblTotalPagar.Text = "Total Pagar: " + totalpagar.ToString("f2");
                            }
                            else
                            {
                                lblProximoPago.ForeColor = Color.Red;
                                lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();
                                double P = (DateTime.Today.Date - fp).TotalDays / 7;
                                if (P < 0)
                                {
                                    P *= -1;
                                }
                                int raw = Convert.ToInt32(P);
                                lblPendientes.ForeColor = Color.Red;
                                lblPendientes.Text = "Semanas Pendientes: " + raw.ToString();
                                double totalMora = double.Parse(txtMora.Text) * (raw);
                                double totalpagar = (double.Parse(txtPagoMensual.Text) * (raw + 1)) + totalMora;
                                lblTotalPagar.Text = "Total Pagar: " + totalpagar.ToString("f2");
                            }
                        }
                        else
                        {
                            lblProximoPago.ForeColor = Color.Black;
                            lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                lblPendientes.ForeColor = Color.Black;
                                lblPendientes.Text = "Meses Pendientes: 0";
                                lblTotalPagar.Text = "Total Pagar: " + txtPagoMensual.Text;
                            }
                            else
                            {
                                lblPendientes.ForeColor = Color.Black;
                                lblPendientes.Text = "Semanas Pendientes: 0";
                                lblTotalPagar.Text = "Total Pagar: " + txtPagoMensual.Text;
                            }
                        }
                    }
                    else
                    {

                        // codigo cuando el estudiante esta retirado

                        MessageBox.Show("El Estudiante fue retirado", "Estudiante Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRetirarEstudiante.Enabled = false;

                        if (pEstudiante.VIP == "NO" || pEstudiante.VIP == "No")
                        {
                            lblVIP.ForeColor = Color.Black;
                            lblVIP.Text = "VIP: " + pEstudiante.VIP;

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                txtPagoMensual.Text = EstudianteDB.getRetiradoPayment(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                                txtMora.Text = EstudianteDB.getRetiradoMora(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                            }
                            else
                            {
                                txtPagoMensual.Text = EstudianteDB.getRetiradoPayment(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                                txtMora.Text = EstudianteDB.getRetiradoMora(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                            }
                        }
                        else
                        {
                            lblVIP.ForeColor = Color.Red;
                            lblVIP.Text = "VIP: " + pEstudiante.VIP;

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                txtPagoMensual.Text = EstudianteDB.getRetiradoPayment(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                                txtMora.Text = EstudianteDB.getRetiradoMora(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                            }
                            else
                            {
                                txtPagoMensual.Text = EstudianteDB.getRetiradoPayment(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                                txtMora.Text = EstudianteDB.getRetiradoMora(Convert.ToInt32(pEstudiante.ID)).ToString("f2");
                            }
                        }

                        DateTime fp = EstudianteDB.ObtenerFechaProximoPago(int.Parse(txtMatriculaCon.Text));
                        DateTime fr = EstudianteDB.getFechaRetiro(Convert.ToInt32(pEstudiante.ID));

                        int Comp = DateTime.Compare(fp, fr);

                        if (Comp < 0)
                        {
                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                lblProximoPago.ForeColor = Color.Red;
                                lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();
                                double P = (fr - fp).TotalDays / 30;
                                if (P < 0)
                                {
                                    P *= -1;
                                }
                                int raw = Convert.ToInt32(P);
                                lblPendientes.ForeColor = Color.Red;
                                lblPendientes.Text = "Meses Pendientes: " + raw.ToString();
                                double totalMora = double.Parse(txtMora.Text) * (raw);
                                double totalpagar = (double.Parse(txtPagoMensual.Text) * (raw)) + totalMora;
                                lblTotalPagar.Text = "Total Pagar: " + totalpagar.ToString("f2");
                            }
                            else
                            {
                                lblProximoPago.ForeColor = Color.Red;
                                lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();
                                double P = (fr - fp).TotalDays / 7;
                                if (P < 0)
                                {
                                    P *= -1;
                                }
                                int raw = Convert.ToInt32(P);
                                lblPendientes.ForeColor = Color.Red;
                                lblPendientes.Text = "Semanas Pendientes: " + raw.ToString();
                                double totalMora = double.Parse(txtMora.Text) * (raw);
                                double totalpagar = (double.Parse(txtPagoMensual.Text) * (raw)) + totalMora;
                                lblTotalPagar.Text = "Total Pagar: " + totalpagar.ToString("f2");
                            }
                        }
                        else
                        {
                            lblProximoPago.ForeColor = Color.Black;
                            lblProximoPago.Text = "Proximo Pago: " + fp.ToLongDateString();

                            if (pEstudiante.Modo_Pago == "Mensual")
                            {
                                lblPendientes.ForeColor = Color.Black;
                                lblPendientes.Text = "Meses Pendientes: 0";
                                lblTotalPagar.Text = "Total Pagar: " + txtPagoMensual.Text;
                            }
                            else
                            {
                                lblPendientes.ForeColor = Color.Black;
                                lblPendientes.Text = "Semanas Pendientes: 0";
                                lblTotalPagar.Text = "Total Pagar: " + txtPagoMensual.Text;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Estudiante no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                    txtMatricula.Focus();
                }
            }
        }
        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtDominiodelIdiomaIngles.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
            txtFechaNacimiento.Clear();
            txtFechaRegistro.Clear();
            txtMatriculaCon.Clear();
            txtMora.Clear();
            txtNivel.Clear();
            txtNivelAcademico.Clear();
            txtNombre.Clear();
            txtOcupacion.Clear();
            txtPagoMensual.Clear();
            txtSector.Clear();
            txtTelefono.Clear();
            lblVIP.ForeColor = Color.Black;
            lblVIP.Text = "VIP:";
            lblPendientes.Text = "Pendientes: ";
            lblPendientes.ForeColor = Color.Black;
            lblTotalPagar.Text = "Total a Pagar:";
            lblProximoPago.Text = "Proximo Pago:";
            lblProximoPago.ForeColor = Color.Black;
            btnRetirarEstudiante.Enabled = true;
            btnRetirarEstudiante.Visible = false;
            btnModificar.Visible = false;
            btnHacerFactura.Visible = false;
            btnEliminar.Visible = false;
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
                tContador.Start();
                tReloj.Start();
                dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                ControlBox = false;
                MinimizeBox = false;
                MaximizeBox = false;
                DisabledConsultaItens();
                dgvNiveles.ClearSelection();
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
            loadEstudiantesEnNivel();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            loadEstudiantesEnNivel();
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
                dgvEstudiantes.DataSource = AsistenciaDB.BuscarAsistencia(txtMatricula.Text, "", "", "");
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
                Asistencia pA = new Asistencia();
                int codigoGrupo = 0;
                if (txtMatricula.Text == string.Empty)
                {
                    if(dgvEstudiantes.SelectedRows.Count == 1)
                    {
                        EstudianteBase pE = new EstudianteBase();
                        pE = EstudianteDB.SeleccionarEstudiante(Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[12].Value));
                        codigoGrupo = pE.Codigo_Grupo;

                        pA.Fecha = DateTime.Parse(DateTime.Today.Date.ToString("MM/dd/yyyy"));
                        pA.Matricula = Convert.ToInt32(pE.ID);
                        AsistenciaDB.RegistrarAsistencia(pA, codigoGrupo);
                        MessageBox.Show("Asistencia Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if(dgvEstudiantes.SelectedRows.Count == 1)
                    {
                        EstudianteBase pE = new EstudianteBase();
                        pE = EstudianteDB.SeleccionarEstudiante(Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[1].Value));
                        codigoGrupo = pE.Codigo_Grupo;

                        pA.Fecha = DateTime.Parse(DateTime.Today.Date.ToString("MM/dd/yyyy"));
                        pA.Matricula = Convert.ToInt32(pE.ID);
                        AsistenciaDB.RegistrarAsistencia(pA, codigoGrupo);

                        MessageBox.Show("Asistencia Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EstudianteBase pE = new EstudianteBase();
                        if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt32(txtMatricula.Text)) != null)
                        {
                            pE = EstudianteDB.SeleccionarEstudiante(Convert.ToInt32(txtMatricula.Text));
                            codigoGrupo = pE.Codigo_Grupo;

                            pA.Fecha = DateTime.Parse(DateTime.Today.Date.ToString("MM/dd/yyyy"));
                            pA.Matricula = Convert.ToInt32(pE.ID);
                            AsistenciaDB.RegistrarAsistencia(pA, codigoGrupo);

                            MessageBox.Show("Asistencia Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No existe el estudiante, digite una matricula diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
                    dgvEstudiantes.DataSource = AsistenciaDB.BuscarAsistencia(txtMatricula.Text, "", "", "");
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
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = "Fecha: ";
                lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString() + " Hora: " + DateTime.Now.ToLongTimeString();
                lblCantidadEstudiantesRegistrados.Text = "Cantidad de Estudiantes Registrados: ";
                lblCantidadEstudiantesRegistrados.Text += EstudianteDB.getTotalStudentsRegistered().ToString();
                lblEstudiantesRetirados.Text = "Cantidad Estudiantes Retirados: ";
                lblEstudiantesRetirados.Text += EstudianteDB.getTotalRetired().ToString();
                lblEstudiantesActivos.Text = "Cantidad Estudiantes Activos: ";
                lblEstudiantesActivos.Text += EstudianteDB.getTotalStudentsActive().ToString();
                EstudianteDB.updateRetiradoStatusWhenStudentIsRegistered();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatriculaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    LoadStudentData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }

        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmRegistro pRegistro = new frmRegistro();
            if(txtMora.Text == string.Empty)
            {
                MessageBox.Show("El Estudiante no se ha cargado, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtMatriculaCon.Text == string.Empty)
                {
                    MessageBox.Show("la matricula esta vacia, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pRegistro.GetIDestudiante = EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatriculaCon.Text));
                    pRegistro.ShowDialog();
                    LoadStudentData();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmRegistro pRegistro = new frmRegistro();
            if (txtMora.Text == string.Empty)
            {
                MessageBox.Show("El Estudiante no se ha cargado, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMatriculaCon.Text == string.Empty)
                {
                    MessageBox.Show("la matricula esta vacia, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pRegistro.GetIDestudiante = EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatriculaCon.Text));
                    pRegistro.ShowDialog();
                    LoadStudentData();
                }
            }
        }

        private void btnHacerFactura_Click(object sender, EventArgs e)
        {
            frmFacturacion pFactura = new frmFacturacion();
            if (txtMora.Text == string.Empty)
            {
                MessageBox.Show("El Estudiante no se ha cargado, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMatriculaCon.Text == string.Empty)
                {
                    MessageBox.Show("la matricula esta vacia, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pFactura.getID = txtMatriculaCon.Text.ToString();
                    pFactura.ShowDialog();
                    LoadStudentData();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRetirarEstudiante_Click(object sender, EventArgs e)
        {
            if(txtMatriculaCon.Text == string.Empty)
            {
                MessageBox.Show("La Matricula esta vacia", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado un estudiante", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatriculaCon.Text)) == null)
            {
                MessageBox.Show("No existe el Alunmo", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Esta seguro que desea retirar el Estudiante?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (EstudianteDB.updateRetiradoStatus(int.Parse(txtMatriculaCon.Text)) > 0)
                    {
                        MessageBox.Show("El Estudiante fue retirado", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo retirar el Estudiante", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbFiltro.Text == "Nivel")
                {
                    txtBusqueda.DropDownStyle = ComboBoxStyle.Simple;
                    txtBusqueda.Select();
                }
                else if (cbFiltro.Text == "Horario")
                {
                    txtBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                    loadHorarios();
                    txtBusqueda.Select();
                }
                else if (cbFiltro.Text == "Profesor")
                {
                    txtBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                    loadProfesores();
                    txtBusqueda.Select();
                }
                else if (cbFiltro.Text == "Aula")
                {
                    txtBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                    loadAulas();
                    txtBusqueda.Select();
                }
                else if (cbFiltro.Text == "")
                {
                    txtBusqueda.DropDownStyle = ComboBoxStyle.Simple;
                    tContador.Start();
                }
                else
                {
                    MessageBox.Show("El Filtro no ha sido registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarNiveles();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == "Nivel")
                {
                    if (txtBusqueda.Text != string.Empty)
                    {
                        dgvNiveles.DataSource = GruposDB.BuscarGrupos(txtBusqueda.Text, "", "", "", "");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarNivelesBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarFiltroNiveles();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pbRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == string.Empty)
                {
                    dgvNiveles.DataSource = GruposDB.TodosLosGrupos();
                    dgvNiveles.ClearSelection();
                    dgvEstudiantes.DataSource = "";
                }
                else
                {
                    filtrarNiveles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gananciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Nivel > 2)
            {
                new frmMantenimientoGanancias().Show();
            }
            else
            {
                MessageBox.Show("Acceso restringido, contactese con el admimnistrador del sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registroDeGruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Nivel > 2)
            {
                frmFamilyConf pGrupo = new frmFamilyConf();
                pGrupo.menu = true;
                pGrupo.Show();
            }
            else
            {
                MessageBox.Show("No tienes Acceso, Contacta al Administrador del Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pagoGrupalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarGrupo pBuscarGrupo = new frmBuscarGrupo();
            pBuscarGrupo.menu = true;
            pBuscarGrupo.Show();
        }
    }
}

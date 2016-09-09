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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtPrimerPalcial.Clear();
            txtSegundoParcial.Clear();
            txtTercerParcial.Clear();
            dtpFechaParcial.Value = DateTime.Now;
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                dgvAsistencia.DataSource = AsistenciaDB.MostrarTodasLasAsistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargraEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    MessageBox.Show("Matricula Vacia, Complete la Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatricula.Focus();
                }
                else
                {
                    string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                    string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));

                    if (nombre != null & apellido != null)
                    {
                        txtNombre.Text = nombre;
                        txtApellido.Text = apellido;
                        dgvAsistencia.DataSource = AsistenciaDB.BuscarAsistencia(txtMatricula.Text, "", "", "");
                        dgvNotaAsistencia.DataSource = NotaAsistenciaDB.BuscarCalificaciones(int.Parse(txtMatricula.Text));
                        btnCargarCalificacion.Enabled = true;
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                        rbExamenEscrito.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("El estudiante No existe, Digite una Matricula Valida", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricula.Clear();
                        txtMatricula.Focus();
                    }
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
                if (rbExamenEscrito.Checked == true)
                {
                    if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                    {
                        MessageBox.Show("No se ha Cargado un Estudiante", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMatricula.Focus();
                    }
                    else
                    {
                        // evaluation to verify if textboxes are empty.
                        if (txtPrimerPalcial.Text == string.Empty || txtSegundoParcial.Text == string.Empty || txtTercerParcial.Text == string.Empty)
                        {
                            MessageBox.Show("Complete la nota de todos los parciales", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            // validate if textboxes value is less than 100.
                            if (int.Parse(txtPrimerPalcial.Text) > 100 || int.Parse(txtSegundoParcial.Text) > 100 || int.Parse(txtTercerParcial.Text) > 100)
                            {
                                MessageBox.Show("La notas de los parciales debe ser menos o igual que 100, digite las notas nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPrimerPalcial.Focus();
                            }
                            else
                            {
                                Notas pNotas = new Notas();

                                pNotas.Matricula = int.Parse(txtMatricula.Text);
                                pNotas.Nombre = txtNombre.Text + " " + txtApellido.Text;
                                pNotas.N1 = Int32.Parse(txtPrimerPalcial.Text);
                                pNotas.N2 = Int32.Parse(txtSegundoParcial.Text);
                                pNotas.N3 = Int32.Parse(txtTercerParcial.Text);
                                int NFF = pNotas.N1 + pNotas.N2 + pNotas.N3;
                                NFF = NFF / 3;
                                pNotas.NF = NFF;
                                pNotas.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                                if (MessageBox.Show("Seguro que desea registrar la calificacion?", "Calificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    int calificacion = NotasDB.RegistrarNotaExamenE(pNotas, EstudianteDB.ObtenerCodigoNivel(int.Parse(txtMatricula.Text)));

                                    if (calificacion > 0)
                                    {
                                        MessageBox.Show("Calificacion Registrada con Exito!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Convert.ToInt32(txtMatricula.Text), "");
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Pudo Registrar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (rbExamenLectura.Checked == true)
                {
                    // Examen de Lectura
                    if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                    {
                        MessageBox.Show("No se ha Cargado un Estudiante", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMatricula.Focus();
                    }
                    else
                    {
                        // evaluation to verify if textboxes are empty.
                        if (txtPrimerPalcial.Text == string.Empty || txtSegundoParcial.Text == string.Empty || txtTercerParcial.Text == string.Empty)
                        {
                            MessageBox.Show("Complete la nota de todos los parciales", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            if (int.Parse(txtPrimerPalcial.Text) > 100 || int.Parse(txtSegundoParcial.Text) > 100 || int.Parse(txtTercerParcial.Text) > 100)
                            {
                                MessageBox.Show("La notas de los parciales debe ser menos o igual que 100, digite las notas nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPrimerPalcial.Focus();
                            }
                            else
                            {
                                Notas pNotas = new Notas();

                                pNotas.Matricula = int.Parse(txtMatricula.Text);
                                pNotas.Nombre = txtNombre.Text + " " + txtApellido.Text;
                                pNotas.N1 = Int32.Parse(txtPrimerPalcial.Text);
                                pNotas.N2 = Int32.Parse(txtSegundoParcial.Text);
                                pNotas.N3 = Int32.Parse(txtTercerParcial.Text);
                                int NFF = pNotas.N1 + pNotas.N2 + pNotas.N3;
                                NFF = NFF / 3;
                                pNotas.NF = NFF;
                                pNotas.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                                if (MessageBox.Show("Seguro que desea registrar la calificacion?", "Calificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    int calificacion = NotasDB.RegistrarNotaExamenL(pNotas, EstudianteDB.ObtenerCodigoNivel(int.Parse(txtMatricula.Text)));

                                    if (calificacion > 0)
                                    {
                                        MessageBox.Show("Calificacion Registrada con Exito!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnCargarCalificacion.Enabled = false;
                                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Convert.ToInt32(txtMatricula.Text), "");
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Pudo Registrar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (rbExamenOral.Checked == true)
                {
                    // Examen Oral
                    if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                    {
                        MessageBox.Show("No se ha Cargado un Estudiante", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMatricula.Focus();
                    }
                    else
                    {
                        // evaluation to verify if textboxes are empty.
                        if (txtPrimerPalcial.Text == string.Empty || txtSegundoParcial.Text == string.Empty || txtTercerParcial.Text == string.Empty)
                        {
                            MessageBox.Show("Complete la nota de todos los parciales", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            if (int.Parse(txtPrimerPalcial.Text) > 100 || int.Parse(txtSegundoParcial.Text) > 100 || int.Parse(txtTercerParcial.Text) > 100)
                            {
                                MessageBox.Show("La notas de los parciales debe ser menos o igual a 100, digite las notas nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPrimerPalcial.Focus();
                            }
                            else
                            {
                                Notas pNotas = new Notas();

                                pNotas.Matricula = int.Parse(txtMatricula.Text);
                                pNotas.Nombre = txtNombre.Text + " " + txtApellido.Text;
                                pNotas.N1 = Int32.Parse(txtPrimerPalcial.Text);
                                pNotas.N2 = Int32.Parse(txtSegundoParcial.Text);
                                pNotas.N3 = Int32.Parse(txtTercerParcial.Text);
                                int NFF = pNotas.N1 + pNotas.N2 + pNotas.N3;
                                NFF = NFF / 3;
                                pNotas.NF = NFF;
                                pNotas.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                                if (MessageBox.Show("Seguro que desea registrar la calificacion?", "Calificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    int calificacion = NotasDB.RegistrarNotaExamenO(pNotas, EstudianteDB.ObtenerCodigoNivel(int.Parse(txtMatricula.Text)));

                                    if (calificacion > 0)
                                    {
                                        MessageBox.Show("Calificacion Registrada con Exito!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btnCargarCalificacion.Enabled = false;
                                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Convert.ToInt32(txtMatricula.Text), "");
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Pudo Registrar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                    {
                        MessageBox.Show("No se ha Cargado un Estudiante", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMatricula.Focus();
                    }
                    else
                    {
                        // evaluation to verify if textboxes are empty.
                        if (txtPrimerPalcial.Text == string.Empty || txtSegundoParcial.Text == string.Empty || txtTercerParcial.Text == string.Empty)
                        {
                            MessageBox.Show("Complete la nota de todos los parciales", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            if (int.Parse(txtPrimerPalcial.Text) > 100 || int.Parse(txtSegundoParcial.Text) > 100 || int.Parse(txtTercerParcial.Text) > 100)
                            {
                                MessageBox.Show("La notas de los parciales debe ser menos o igual a 100, digite las notas nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPrimerPalcial.Focus();
                            }
                            else
                            {
                                Notas pNotas = new Notas();

                                pNotas.Matricula = int.Parse(txtMatricula.Text);
                                pNotas.Nombre = txtNombre.Text + " " + txtApellido.Text;
                                pNotas.N1 = Int32.Parse(txtPrimerPalcial.Text);
                                pNotas.N2 = Int32.Parse(txtSegundoParcial.Text);
                                pNotas.N3 = Int32.Parse(txtTercerParcial.Text);
                                int NFF = pNotas.N1 + pNotas.N2 + pNotas.N3;
                                NFF = NFF / 3;
                                pNotas.NF = NFF;
                                pNotas.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                                if (MessageBox.Show("Seguro que desea registrar la calificacion?", "Calificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    int calificacion = NotasDB.RegistrarNotaExposicion(pNotas, EstudianteDB.ObtenerCodigoNivel(int.Parse(txtMatricula.Text)));

                                    if (calificacion > 0)
                                    {
                                        MessageBox.Show("Calificacion Registrada con Exito!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btnCargarCalificacion.Enabled = false;
                                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Convert.ToInt32(txtMatricula.Text), "");
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Pudo Registrar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Notas pCS { get; set; }
        private void btnCargarCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUltimasCalificaciones.SelectedRows.Count == 1)
                {
                    if (rbExamenEscrito.Checked == true)
                    {  
                        Int32 ID;
                        ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                        pCS = NotasDB.ObtenerNotasExamenEscrito(ID, "");
                    }
                    else if (rbExamenLectura.Checked == true)
                    {
                        Int32 ID;
                        ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                        pCS = NotasDB.ObtenerNotasExamenLect(ID, "");
                    }
                    else if (rbExamenOral.Checked == true)
                    {
                        Int32 pID;
                        pID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                        pCS = NotasDB.ObtenerNotasExamenOral(pID, "");
                    }
                    else if (rbExposicion.Checked == true)
                    {
                        Int32 ID;
                        ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                        pCS = NotasDB.ObtenerNotasExp(ID, "");
                    }
                    if (pCS != null)
                    {
                        txtPrimerPalcial.Text = pCS.N1.ToString();
                        txtSegundoParcial.Text = pCS.N2.ToString();
                        txtTercerParcial.Text = pCS.N3.ToString();
                        string fechaP = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                        fechaP = pCS.Fecha_Examen;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado la calificacion, seleccione una de la tabla", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                if (pCS == null)
                {
                    MessageBox.Show("Nesesita cargar la calificacion, Seleccione una valida", "Calificacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnCargarCalificacion.Focus();
                }
                else if(int.Parse(txtPrimerPalcial.Text) > 100 || int.Parse(txtSegundoParcial.Text) > 100 || int.Parse(txtTercerParcial.Text) > 100)
                {
                    MessageBox.Show("La notas de los parciales debe ser menos o igual que 100, digite las notas nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrimerPalcial.Focus();
                }
                else
                {
                    if (rbExamenEscrito.Checked == true)
                    {
                        Notas pC = new Notas();
                        pC.N1 = int.Parse(txtPrimerPalcial.Text);
                        pC.N2 = int.Parse(txtSegundoParcial.Text);
                        pC.N3 = int.Parse(txtTercerParcial.Text);
                        pC.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");

                        int NF = int.Parse(txtPrimerPalcial.Text) + int.Parse(txtSegundoParcial.Text) + int.Parse(txtTercerParcial.Text);
                        NF = NF / 3;

                        pC.NF = NF;

                        pC.ID = pCS.ID;
                        if (MessageBox.Show("Seguro que desa Modificcar la calificacion?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            int C;
                            C = NotasDB.ModificarCalificacionesExamenEscrito(pC);

                            if (C > 0)
                            {
                                MessageBox.Show("Modificacion Exitosa", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnModificar.Enabled = false;
                                btnEliminar.Enabled = false;
                                Limpiar();
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Modificar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (rbExamenLectura.Checked == true)
                    {
                        Notas pC = new Notas();
                        pC.N1 = int.Parse(txtPrimerPalcial.Text);
                        pC.N2 = int.Parse(txtSegundoParcial.Text);
                        pC.N3 = int.Parse(txtTercerParcial.Text);
                        pC.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                        pC.ID = pCS.ID;
                        int NF = int.Parse(txtPrimerPalcial.Text) + int.Parse(txtSegundoParcial.Text) + int.Parse(txtTercerParcial.Text);
                        NF = NF / 3;

                        pC.NF = NF;

                        if (MessageBox.Show("Seguro que desa Modificcar la calificacion?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            int C;
                            C = NotasDB.ModificarCalificacionesExamenLectura(pC);

                            if (C > 0)
                            {
                                MessageBox.Show("Modificacion Exitosa", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnModificar.Enabled = false;
                                btnEliminar.Enabled = false;
                                Limpiar();
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Modificar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (rbExamenOral.Checked == true)
                    {
                        Notas pC = new Notas();
                        pC.N1 = int.Parse(txtPrimerPalcial.Text);
                        pC.N2 = int.Parse(txtSegundoParcial.Text);
                        pC.N3 = int.Parse(txtTercerParcial.Text);
                        pC.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                        pC.ID = pCS.ID;
                        int NF = int.Parse(txtPrimerPalcial.Text) + int.Parse(txtSegundoParcial.Text) + int.Parse(txtTercerParcial.Text);
                        NF = NF / 3;

                        pC.NF = NF;
                        if (MessageBox.Show("Seguro que desa Modificcar la calificacion?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            int C;
                            C = NotasDB.ModificarCalificacionesExamenOral(pC);

                            if (C > 0)
                            {
                                MessageBox.Show("Modificacion Exitosa", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnModificar.Enabled = false;
                                btnEliminar.Enabled = false;
                                Limpiar();
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Modificar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (rbExposicion.Checked == true)
                    {
                        Notas pC = new Notas();
                        pC.N1 = int.Parse(txtPrimerPalcial.Text);
                        pC.N2 = int.Parse(txtSegundoParcial.Text);
                        pC.N3 = int.Parse(txtTercerParcial.Text);
                        pC.Fecha_Examen = dtpFechaParcial.Value.Date.ToString("yyyy-MM-dd");
                        pC.ID = pCS.ID;
                        int NF = int.Parse(txtPrimerPalcial.Text) + int.Parse(txtSegundoParcial.Text) + int.Parse(txtTercerParcial.Text);
                        NF = NF / 3;

                        pC.NF = NF;
                        if (MessageBox.Show("Seguro que desa Modificcar la calificacion?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            int C;
                            C = NotasDB.ModificarCalificacionesExposicion(pC);

                            if (C > 0)
                            {
                                MessageBox.Show("Modificacion Exitosa", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnModificar.Enabled = false;
                                btnEliminar.Enabled = false;
                                Limpiar();
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Modificar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
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
                if (pCS != null)
                {
                    if (MessageBox.Show("Seguro que desea Eliminar la Calificacion?", "Calificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (rbExamenEscrito.Checked == true)
                        {
                            dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Convert.ToInt32(txtMatricula.Text), "");
                            Int32 ID;
                            ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                            int R = NotasDB.EliminarNotaExamenEscrito(ID);
                            if(R > 0)
                            {
                                MessageBox.Show("Notas Eliminadas Exitosamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Convert.ToInt32(txtMatricula.Text),"");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Eliminar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Convert.ToInt32(txtMatricula.Text), "");
                            Int32 ID;
                            ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                            int R = NotasDB.EliminarNotaExamenLectura(ID);
                            if (R > 0)
                            {
                                MessageBox.Show("Notas Eliminadas Exitosamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Eliminar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Convert.ToInt32(txtMatricula.Text), "");
                            Int32 pID;
                            pID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                            int R = NotasDB.EliminarNotaExamenOral(pID);
                            if (R > 0)
                            {
                                MessageBox.Show("Notas Eliminadas Exitosamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Eliminar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else if (rbExposicion.Checked == true)
                        {
                            dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Convert.ToInt32(txtMatricula.Text), "");
                            Int32 ID;
                            ID = Convert.ToInt32(dgvUltimasCalificaciones.CurrentRow.Cells[0].Value);
                            int R = NotasDB.EliminarNotaExposicion(ID);
                            if (R > 0)
                            {
                                MessageBox.Show("Notas Eliminadas Exitosamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Convert.ToInt32(txtMatricula.Text), "");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Eliminar la Calificacion, Intentelo Nuevamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CalificacionesB> lista { get; set; }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Clear();
            txtApellido.Clear();
            txtMatricula.Clear();
            dgvUltimasCalificaciones.DataSource = lista;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCargarCalificacion.Enabled = false;
            btnCargraEstudiante.Enabled = true;
            btnCargarCalificacion.Enabled = false;
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarCalificacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBuscarCalificacion bc = new frmBuscarCalificacion();
            bc.ShowDialog();
        }

        private void rbExamenEscrito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbExamenEscrito.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Matricula, "");
                        gbNotas.Text = "Notas Examen Escrito";
                    }
                }
                else if (rbExamenLectura.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Matricula, "");
                        gbNotas.Text = "Notas Examen Lectura";
                    }
                }
                else if (rbExamenOral.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Matricula, "");
                        gbNotas.Text = "Notas Examen Oral";
                    }
                }
                else
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Matricula, "");
                        gbNotas.Text = "Notas Exposicion";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbExamenOral_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbExamenEscrito.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Matricula, "");
                        gbNotas.Text = "Notas Examen Escrito";
                    }
                }
                else if (rbExamenLectura.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Matricula, "");
                        gbNotas.Text = "Notas Examen Lectura";
                    }
                }
                else if (rbExamenOral.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Matricula, "");
                        gbNotas.Text = "Notas Examen Oral";
                    }
                }
                else
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Matricula, "");
                        gbNotas.Text = "Notas Exposicion";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbExamenLectura_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbExamenEscrito.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Matricula, "");
                        gbNotas.Text = "Notas Examen Escrito";
                    }
                }
                else if (rbExamenLectura.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Matricula, "");
                        gbNotas.Text = "Notas Examen Lectura";
                    }
                }
                else if (rbExamenOral.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Matricula, "");
                        gbNotas.Text = "Notas Examen Oral";
                    }
                }
                else
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Matricula, "");
                        gbNotas.Text = "Notas Exposicion";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbExposicion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbExamenEscrito.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExmenEscrM(Matricula, "");
                        gbNotas.Text = "Notas Examen Escrito";
                    }
                }
                else if (rbExamenLectura.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenLecM(Matricula, "");
                        gbNotas.Text = "Notas Examen Lectura";
                    }
                }
                else if (rbExamenOral.Checked == true)
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExamenOralM(Matricula, "");
                        gbNotas.Text = "Notas Examen Oral";
                    }
                }
                else
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Completa el Campo Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int Matricula = int.Parse(txtMatricula.Text);
                        dgvUltimasCalificaciones.DataSource = NotasDB.TodasLasNotasExpM(Matricula, "");
                        gbNotas.Text = "Notas Exposicion";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Asistencia pAS { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // boton para obtener el total de las asistencias
        }

        private void btnCalcularAsitencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalDias.Text == string.Empty)
                {
                    MessageBox.Show("No se ha completado el Campo de Dias a Asistir", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTotalDias.Focus();
                }
                else
                {
                    if (txtDiasAsistidos.Text == string.Empty)
                    {
                        MessageBox.Show("El Campo Dias Asistidos esta Vacio", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDiasAsistidos.Focus();
                    }
                    else
                    {
                        double DA, TD;
                        double CA;
                        DA = double.Parse(txtDiasAsistidos.Text);
                        TD = double.Parse(txtTotalDias.Text);
                        CA = (DA / TD) * 100;
                        if (CA != 0)
                        {
                            txtNotaAsistencia.Text = CA.ToString("f2");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarNotaAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    MessageBox.Show("Completa la Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatricula.Focus();
                }
                else
                {
                    NotaAsistencia pN = new NotaAsistencia();
                    pN.Nombre = pAS.Nombre;
                    pN.Matricula = int.Parse(txtMatricula.Text);
                    pN.Calificacion = Decimal.Parse(txtNotaAsistencia.Text);
                    pN.Fecha_Calificacion = DateTime.Today.Date.ToString("yyyy-MM-dd");
                    int R = NotaAsistenciaDB.RegistrarCalificacion(pN);
                    if (R > 0)
                    {
                        MessageBox.Show("Nota de Asistencia Registrada", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo Registrar la Nota, Intentelo Nuevamente", "Calificanones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnRegistrarNotaAsistencia.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUltimasCalificaciones.SelectedRows.Count == 1)
                {
                    frmReporteNotasEstudiantes pN = new frmReporteNotasEstudiantes();
                    DateTime fecha = Convert.ToDateTime(dgvUltimasCalificaciones.CurrentRow.Cells[7].Value);
                    string sf = fecha.ToString("yyyy-MM-dd");
                    pN.Fecha = Convert.ToDateTime(sf);
                    string matric = txtMatricula.Text;
                    pN.matricula = int.Parse(matric);
                    pN.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione una calificacion para imprimir", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtMatricula.Text == string.Empty)
                    {
                        MessageBox.Show("Matricula Vacia, Complete la Matricula", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatricula.Focus();
                    }
                    else
                    {
                        string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                        string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));

                        if (nombre != null & apellido != null)
                        {
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            dgvAsistencia.DataSource = AsistenciaDB.BuscarAsistencia(txtMatricula.Text, "", "", "");
                            dgvNotaAsistencia.DataSource = NotaAsistenciaDB.BuscarCalificaciones(int.Parse(txtMatricula.Text));
                            btnCargarCalificacion.Enabled = true;
                            btnGuardar.Enabled = true;
                            btnModificar.Enabled = false;
                            btnEliminar.Enabled = false;
                            rbExamenEscrito.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("El estudiante No existe, Digite una Matricula Valida", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatricula.Clear();
                            txtMatricula.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPrimerPalcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSegundoParcial.Focus();
            }
        }

        private void txtSegundoParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTercerParcial.Focus();
            }
        }

        private void txtTercerParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpFechaParcial.Focus();
            }
        }

        private void dtpFechaParcial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDiasAsistidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTotalDias.Focus();
            }
        }

        private void txtTotalDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularAsitencia.Focus();
            }
        }
    }
}

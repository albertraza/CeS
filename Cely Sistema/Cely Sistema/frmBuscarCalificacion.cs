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
    public partial class frmBuscarCalificacion : Form
    {
        public frmBuscarCalificacion()
        {
            InitializeComponent();
        }

        private void frmBuscarCalificacion_Load(object sender, EventArgs e)
        {
            rbExamenEscritos.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
                MessageBox.Show("La Matricula esta vacia, Digite una matricula valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                    {
                        MessageBox.Show("El Estudiante no Existe, Digite un Estudiante Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (rbExamenEscritos.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Escritos";
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes  de Lectura";
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Oral";
                        }
                        else
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Exposicion";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbExamenEscritos_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
            }
            else
            {
                if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                {
                }
                else
                {
                    try
                    {
                        if (rbExamenEscritos.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Escritos";
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes  de Lectura";
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Oral";
                        }
                        else
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Exposicion";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbExamenOral_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
            }
            else
            {
                if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                {
                }
                else
                {
                    try
                    {
                        if (rbExamenEscritos.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Escritos";
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes  de Lectura";
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Oral";
                        }
                        else
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Exposicion";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbExamenLectura_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
            }
            else
            {
                if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                {
                }
                else
                {
                    try
                    {
                        if (rbExamenEscritos.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Escritos";
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes  de Lectura";
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Oral";
                        }
                        else
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Exposicion";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbExposicion_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
            }
            else
            {
                if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                {
                }
                else
                {
                    try
                    {
                        if (rbExamenEscritos.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Escritos";
                        }
                        else if (rbExamenLectura.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes  de Lectura";
                        }
                        else if (rbExamenOral.Checked == true)
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Examenes Oral";
                        }
                        else
                        {
                            dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                            lblTitulo.Text = "Exposicion";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtpFechaExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMatricula.Focus();
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtMatricula.Text == string.Empty)
                {
                    MessageBox.Show("La Matricula esta vacia, Digite una matricula valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        if (EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) == null)
                        {
                            MessageBox.Show("El Estudiante no Existe, Digite un Estudiante Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (rbExamenEscritos.Checked == true)
                            {
                                dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExmenEscrM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                                lblTitulo.Text = "Examenes Escritos";
                            }
                            else if (rbExamenLectura.Checked == true)
                            {
                                dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenLecM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                                lblTitulo.Text = "Examenes  de Lectura";
                            }
                            else if (rbExamenOral.Checked == true)
                            {
                                dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExamenOralM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                                lblTitulo.Text = "Examenes Oral";
                            }
                            else
                            {
                                dgvListaExamenes.DataSource = NotasDB.TodasLasNotasExpM(int.Parse(txtMatricula.Text), dtpFechaExamen.Value.ToString("yyyy-MM-dd"));
                                lblTitulo.Text = "Exposicion";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

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
    public partial class frmCargaEstudiante : Form
    {
        public frmCargaEstudiante()
        {
            InitializeComponent();
        }

        private void frmCargaEstudiante_Load(object sender, EventArgs e)
        {
            Estudiante pEstudiante = new Estudiante();

            txtNombre.Text = pEstudiante.Nombre;
            txtApellido.Text = pEstudiante.Apellido;
            txtDireccion.Text = pEstudiante.Direccion;
            txtEmail.Text = pEstudiante.E_Mail;
            txtNivelAcademico.Text = pEstudiante.NivelA;
            txtOcupacion.Text = pEstudiante.Ocupacion;
            txtSector.Text = pEstudiante.Sector;
            txtTelefono.Text = pEstudiante.Telefono;
            txtEdad.Text = pEstudiante.Edad;
            txtDominiodelIdioma.Text = pEstudiante.D_Idioma;
            dtpFechaActual.MinDate = Convert.ToDateTime(pEstudiante.Fecha_Ins);
            dtpFechaNacimiento.MinDate = Convert.ToDateTime(pEstudiante.Fecha_N);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBusquedaDeAlumnos pBusqueda = new frmBusquedaDeAlumnos();
            pBusqueda.Show();
        }
    }
}

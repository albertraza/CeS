﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cely_Sistema
{
    public partial class frmEstudiantePorNivel : Form
    {
        public frmEstudiantePorNivel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Int32 ID;
        public Int32 getID
        {
            get { return ID; }
            set { ID = value; }
        }
        private void frmEstudiantePorNivel_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTabla.DataSource = GruposDB.EstudiantePorGrupo(ID);  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiardeNivel_Click(object sender, EventArgs e)
        {
            if(dgvTabla.SelectedRows.Count == 1)
            {
                frmRegistro pRegistro = new frmRegistro();
                pRegistro.GetIDestudiante = EstudianteDB.SeleccionarEstudiante(Convert.ToInt32(dgvTabla.CurrentRow.Cells[12].Value));
                pRegistro.ShowDialog();
                dgvTabla.DataSource = GruposDB.EstudiantePorGrupo(ID);
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante de la tabla", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImprimirListado_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteEstudiantePorNivel pLista = new frmReporteEstudiantePorNivel();
                if (ID != 0)
                {
                    pLista.NoNivel = ID;
                    pLista.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay nivel para hacer un listado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

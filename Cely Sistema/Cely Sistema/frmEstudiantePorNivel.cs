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
                btnAñadirEstudiante.Visible = false;
                btnCambiardeNivel.Visible = false;
                dgvTabla.DataSource = GruposDB.EstudiantePorGrupo(ID);  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiardeNivel_Click(object sender, EventArgs e)
        {

        }
    }
}

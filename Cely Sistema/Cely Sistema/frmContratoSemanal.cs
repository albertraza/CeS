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
    public partial class frmContratoSemanal : Form
    {
        public frmContratoSemanal()
        {
            InitializeComponent();
        }
        public int matricula { get; set; }

        private void frmContratoSemanal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporting.ContratoSemanal' table. You can move, or remove it, as needed.
            this.ContratoSemanalTableAdapter.Fill(this.Reporting.ContratoSemanal, matricula);
            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }
        private string ID;
        public string getID
        {
            get { return ID; }
            set { ID = value; }
        }
        private void populateStudent()
        {
            int cantPAgar = Convert.ToInt32(nCantPagar.Value);
            if (rbPago.Checked == true)
            {
                if (txtMatricula.Text == string.Empty)
                {
                    txtMatricula.Focus();
                }
                else
                {
                    if (EstudianteDB.ObtenerNombre(int.Parse(txtMatricula.Text)) == null)
                    {
                        MessageBox.Show("El Estudiante no Existe, Digite una matricula valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatricula.Clear();
                        txtApellido.Focus();
                    }
                    else
                    {
                        Limpiar();
                        string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                        string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                        string ultimop = EstudianteDB.ObtenerUltimoPago(Convert.ToInt32(txtMatricula.Text));
                        DateTime pPago = EstudianteDB.ObtenerFechaProximoPago(Convert.ToInt32(txtMatricula.Text));
                        pProximoPago = pPago;
                        string MP = EstudianteDB.ObtenerModoPago(Convert.ToInt32(txtMatricula.Text));
                        MP0 = MP;

                        DateTime fechaActual = DateTime.Today;
                        pPago0 = pPago;
                        pPagoA = pPago;

                        if (pPago.Date == fechaActual.Date)
                        {
                            txtFechaPago.Text = "No se ha calculado";
                            lblFechaPago.ForeColor = Color.Red;
                            lblFechaPago.Text = lblFechaPago.Text + " " + "No se ha Calculado";
                            fechaactualpp = DateTime.Now;
                        }
                        else
                        {
                            txtFechaPago.Text = Convert.ToString(pPago.Date);
                            lblFechaPago.Text = lblFechaPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                        }

                        if (ultimop == null || ultimop == string.Empty)
                        {
                            lblUltimoPAgo.ForeColor = Color.Red;
                            lblUltimoPAgo.Text = lblUltimoPAgo.Text + " " + "No se ha Realizado un Pago";
                            txtUltimoPago.Text = "No se ha realizado un pago";
                            fechaactualup = DateTime.Now;
                        }
                        else
                        {
                            DateTime fechaup;
                            fechaup = Convert.ToDateTime(ultimop);
                            txtUltimoPago.Text = Convert.ToString(fechaup.Date);
                            lblUltimoPAgo.Text = lblUltimoPAgo.Text + " " + fechaup.Date.ToString("dd-MM-yyyy");
                        }

                        if (nombre != null & apellido != null)
                        {
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            dgvtabla.DataSource = FacturacionDB.BuscarFacturas(Int32.Parse(txtMatricula.Text));
                            lblAnularPago.Visible = true;
                            btnAceptar.Focus();
                            int CompF = DateTime.Compare(pPago0, fechaActual);

                            // VIP method execution

                            if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "NO" ||
                                    EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "No" ||
                                    EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == null)
                            {
                                if (MP == "M" || MP == "Mensual")
                                {
                                    if (CompF < 0)
                                    {
                                        double cantMeses = (DateTime.Today.Date - pPago).TotalDays / 30;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Meses Pendientes: " + cantMeses.ToString("f0");
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = Convert.ToInt32(cantMeses);
                                        double pM = Convert.ToDouble(PagosDB.ObtenerPagoMensual());
                                        lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        pMora = true;
                                    }
                                    else
                                    {
                                        lblPendientes.Text = "Meses Pendientes: 0";
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = 1;
                                        double pM = PagosDB.ObtenerPagoMensual();
                                        lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        pMora = false;
                                    }
                                }
                                else
                                {
                                    if (CompF < 0)
                                    {
                                        double cantMeses = (DateTime.Today.Date - pPago).TotalDays / 7;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Semanas Pendientes: " + cantMeses.ToString("f0");
                                        lblMesesoSemanas.Text = "Semanas";
                                        nCantPagar.Value = Convert.ToInt32(cantMeses);
                                        double pS = Convert.ToDouble(PagosDB.ObtenerPagoSemanal());
                                        lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = true;
                                    }
                                    else
                                    {
                                        lblPendientes.Text = "Semanas Pensientes: 0";
                                        lblMesesoSemanas.Text = "Semanas";
                                        double pS = PagosDB.ObtenerPagoSemanal();
                                        lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                        txtTotalaPagar.Text = pS.ToString("f2");
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = false;
                                    }
                                }
                            }
                            else
                            {
                                // If false means that the student is a VIP
                                gbFactura.BackColor = Color.Yellow;
                                if (MP == "M" || MP == "Mensual")
                                {
                                    if (CompF < 0)
                                    {
                                        double cantMeses = (DateTime.Today.Date - pPago).TotalDays / 30;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Meses Pendientes: " + cantMeses.ToString("f0");
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = Convert.ToInt32(cantMeses);                                                                                                                                                                
                                        double pM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);                                      
                                        lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        pMora = true;
                                    }
                                    else
                                    {
                                        lblPendientes.Text = "Meses Pendientes: 0";
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = 1;
                                        double pM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);
                                        lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        pMora = false;
                                    }
                                }
                                else
                                {
                                    if (CompF < 0)
                                    {
                                        double cantMeses = (DateTime.Today.Date - pPago).TotalDays / 7;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Semanas Pendientes: " + cantMeses.ToString("f0");
                                        lblMesesoSemanas.Text = "Semanas";
                                        nCantPagar.Value = Convert.ToInt32(cantMeses);
                                        double pS = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                        lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = true;
                                    }
                                    else
                                    {
                                        lblPendientes.Text = "Semanas Pendientes: 0";
                                        lblMesesoSemanas.Text = "Semanas";
                                        nCantPagar.Value = 1;
                                        double pS = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                        lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                        txtTotalaPagar.Text = pS.ToString("f2");
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = false;
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("No Existe el Alumno, Digite una matricula Valida", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                Limpiar();
                lblFechaPago.Visible = false;
                lblMora.Visible = false;
                lblPagoMensual.Visible = false;
                lblPagoMensual.Text = "Cantidad a Pagar:";
                lblProximoPago.Visible = false;
                lblUltimoPAgo.Visible = false;
                txtTotalaPagar.Visible = true;
                lblPendientes.Visible = false;
                lblMesesoSemanas.Visible = false;
                lblCantMesesPagar.Visible = false;
                lblCantidadaPagar.Visible = false;
                nCantPagar.Visible = false;
                txtCantPagar.Visible = false;
                string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                if (nombre != null)
                {
                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                }
                else
                {
                    MessageBox.Show("No Existe el Estudiante, Ingrese una matricula Valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatricula.Clear();
                    txtMatricula.Focus();
                }
            }
        }
        private void LimpiarActu()
        {
            lblMora.Text = "Mora:";
            lblProximoPago.Text = "Proximo Pago:";
            lblTotalaPagar.Text = "Total a Pagar:";
        }
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            int cantPAgar = Convert.ToInt32(nCantPagar.Value);
            txtMatricula.Text = ID;
            if (lblMatricula.Text != null)
            {
                rbPago.Checked = true;
                lblAnularPago.Visible = false;
                txtFechaPago.Visible = false;
                txtProximoPAgo.Visible = false;
                txtTotalaPagar.Visible = false;
                lblMensaje.Visible = false;
                txtProximoPAgo.Visible = false;
                ControlBox = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtUltimoPago.Visible = false;
                txtMatricula.Focus();

                // Procedimientos para cargar la infomacion del Estudiante

                try
                {
                    if (rbPago.Checked == true)
                    {
                        if (txtMatricula.Text == string.Empty)
                        {
                            txtMatricula.Focus();
                        }
                        else
                        {
                            populateStudent();
                        }
                    }
                    else
                    {
                        Limpiar();
                        lblFechaPago.Visible = false;
                        lblMora.Visible = false;
                        lblPagoMensual.Visible = false;
                        lblPagoMensual.Text = "Cantidad a Pagar:";
                        lblProximoPago.Visible = false;
                        lblUltimoPAgo.Visible = false;
                        txtTotalaPagar.Visible = true;
                        lblPendientes.Visible = false;
                        lblMesesoSemanas.Visible = false;
                        lblCantMesesPagar.Visible = false;
                        lblCantidadaPagar.Visible = false;
                        nCantPagar.Visible = false;
                        txtCantPagar.Visible = false;
                        string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                        string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                        if (nombre != null)
                        {
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                        }
                        else
                        {
                            MessageBox.Show("No Existe el Estudiante, Ingrese una matricula Valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtMatricula.Clear();
                            txtMatricula.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Limpiar();
                rbPago.Checked = true;
                lblAnularPago.Visible = false;
                txtFechaPago.Visible = false;
                txtProximoPAgo.Visible = false;
                txtTotalaPagar.Visible = false;
                lblMensaje.Visible = false;
                txtProximoPAgo.Visible = false;
                ControlBox = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtUltimoPago.Visible = false;
                txtMatricula.Focus();
                try
                {
                    dgvtabla.DataSource = FacturacionDB.TodasLasFacturasND();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Limpiar()
        {
            nCantPagar.Value = 0;
            lblFechaPago.ForeColor = Color.Black;
            lblUltimoPAgo.ForeColor = Color.Black;
            lblFechaPago.Text = "Fecha Pago:";
            lblUltimoPAgo.Text = "Ultimo Pago:";
            lblPagoMensual.Text = "Pago Mensual:";
            lblMora.ForeColor = Color.Black;
            lblMora.Text = "Mora:";
            lblTotalaPagar.Text = "Total a Pagar:";
            lblProximoPago.Text = "Proximo Pago:";
            lblPendientes.Text = "Pendiente:";
            lblPendientes.ForeColor = Color.Black;
            lblUltimoPAgo.Visible = true;
            lblTotalaPagar.Visible = true;
            lblProximoPago.Visible = true;
            lblPagoMensual.Visible = true;
            lblMotivodePago.Visible = true;
            lblMora.Visible = true;
            lblFechaPago.Visible = true;
            txtMotivodePago.Clear();
            txtTotalaPagar.Clear();
            lblPendientes.Visible = true;
            lblCantidadaPagar.Visible = true;
            nCantPagar.Visible = true;
            lblCantMesesPagar.Visible = true;
            lblMesesoSemanas.Visible = true;
            txtCantPagar.Visible = true;
            txtTotalaPagar.Visible = false;
            lblAnularPago.Visible = false;
            gbFactura.BackColor = Color.White;
        }
        private void LimpiarM()
        {
            nCantPagar.Value = 0;
            lblFechaPago.ForeColor = Color.Black;
            lblUltimoPAgo.ForeColor = Color.Black;
            lblFechaPago.Text = "Fecha Pago:";
            lblUltimoPAgo.Text = "Ultimo Pago:";
            lblPagoMensual.Text = "Pago Mensual:";
            lblMora.ForeColor = Color.Black;
            lblMora.Text = "Mora:";
            lblTotalaPagar.Text = "Total a Pagar:";
            lblProximoPago.Text = "Proximo Pago:";
            lblPendientes.Text = "Pendiente:";
            lblPendientes.ForeColor = Color.Black;
            lblUltimoPAgo.Visible = true;
            lblTotalaPagar.Visible = true;
            lblProximoPago.Visible = true;
            lblPagoMensual.Visible = true;
            lblMotivodePago.Visible = true;
            lblMora.Visible = true;
            lblFechaPago.Visible = true;
            txtMotivodePago.Clear();
            txtTotalaPagar.Clear();
            txtTotalaPagar.Visible = false;
            lblAnularPago.Visible = false;
            txtNombre.Clear();
            txtApellido.Clear();
            txtMatricula.Focus();
            dgvtabla.DataSource = FacturacionDB.TodasLasFacturas(DateTime.Today.Date.ToString("yyyy-MM-dd"));
            txtApellido.Clear();
            txtNombre.Clear();
            gbFactura.BackColor = Color.White;
        }
        private string MP0;
        private DateTime fechaactualpp, fechaactualup, pPago0, pProximoPago;
        private DateTime pPagoA {get; set;}
        private bool pMora { get; set; }
        private void lblCargarEstudiante_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                populateStudent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Ganancias pGSeleccionada { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea registrar la factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (rbPago.Checked == true)
                    {
                        if (txtMatricula.Text == string.Empty)
                        {
                            MessageBox.Show("Digite una matricula antes de tomar el pago", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMatricula.Focus();
                        }
                        else if (txtTotalaPagar.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha Digitado una cantidad a Pagar, Digite una valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTotalaPagar.Focus();
                        }
                        else if (txtMotivodePago.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha Digitado un Motivo de Pago", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMotivodePago.Focus();
                        }
                        else if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha Cargado un Estudiante, Digite una Matricula valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatricula.Focus();
                        }
                        else if(EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) != null)
                        {

                            Facturacion pFactura = new Facturacion();

                            pFactura.Nombre_Estudiante = txtNombre.Text + " " + txtApellido.Text;
                            pFactura.Matricula_Estudiante = Convert.ToInt32(txtMatricula.Text);
                            pFactura.Razon_Pago = txtMotivodePago.Text;
                            pFactura.Precio = Double.Parse(txtTotalaPagar.Text);
                            pFactura.Fecha_Factura = DateTime.Today.Date.ToString("yyyy-MM-dd");
                            pFactura.Cancelacion_Pago = "0";

                            int Factura = FacturacionDB.CrearFactura(pFactura);


                            if (Factura > 0)
                            {
                                // Calculo de Ganancias //
                                DateTime fechaactual = DateTime.Today;
                                string retorno = GananciasDB.ObtenerCantidad(fechaactual.Date.ToString("yyyy-MM-dd"));
                                if (retorno != null)
                                {
                                    string ID0 = GananciasDB.ObtenerID(fechaactual.Date.ToString("yyyy-MM-dd"));
                                    Ganancias pG0 = new Ganancias();
                                    pG0.ID = Convert.ToInt32(ID0);


                                    double G0 = Convert.ToDouble(txtTotalaPagar.Text);
                                    double G1 = Convert.ToDouble(retorno);
                                    double Ganancia = G0 + G1;

                                    pG0.Ganancia = Ganancia;

                                    int Retorno;
                                    Retorno = GananciasDB.ActualizarGanancias(pG0);

                                    if (Retorno > 0)
                                    {
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrio un error registrando las ganancias, intentelo nuevamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                                else
                                {
                                    Ganancias pG1 = new Ganancias();
                                    pG1.Fecha_Ganancia = DateTime.Now.Date.ToString("yyyy-MM-dd");
                                    pG1.Ganancia = Convert.ToDouble(txtTotalaPagar.Text);

                                    int R = GananciasDB.RegistrarGanancias(pG1);

                                    if (R > 0)
                                    {
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrio un error registrando las ganancias, intentalo nuevamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                //******////////////////////////********//////////////////////////*****
                                MessageBox.Show("Factura Creada con Exito", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string codigo = FacturacionDB.ObtenerCodigo(pFactura);
                                int ultimop = EstudianteDB.UltimoPago(pFactura.Fecha_Factura, pFactura.Matricula_Estudiante);
                                int PP = EstudianteDB.ActualizarProximoPago(Convert.ToInt32(txtMatricula.Text), pPago0.ToString("yyyy-MM-dd"));
                                int retorno1 = FacturacionDB.ActualizarFechaPAgoAnterior(int.Parse(codigo), pPagoA.Date.ToString("yyyy-MM-dd"));

                                if (codigo != null & ultimop > 0 & PP > 0 & retorno1 > 0)
                                {
                                    MessageBox.Show("Codigo Factura: " + codigo, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lblAnularPago.Visible = false;
                                    if (MessageBox.Show("Desea Imprimir la Factura?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        frmImpresionFactura pI = new frmImpresionFactura();
                                        pI.Fecha = DateTime.Today.Date;
                                        pI.Matricula = int.Parse(txtMatricula.Text);
                                        pI.ShowDialog();
                                        LimpiarM();
                                    }
                                    else
                                    {
                                        LimpiarM();
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Error, No se pudo mostrar el Codigo", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        //codigo = FacturacionDB.ObtenerCodigo(pFactura);
                                        if (codigo != null)
                                        {
                                            MessageBox.Show("Codigo Factura: " + codigo, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            lblAnularPago.Visible = false;
                                            if (MessageBox.Show("Desea Imprimir la Factura?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                            {
                                                frmImpresionFactura pI = new frmImpresionFactura();
                                                pI.Fecha = DateTime.Today.Date;
                                                pI.Matricula = int.Parse(txtMatricula.Text);
                                                pI.ShowDialog();
                                                LimpiarM();
                                            }
                                            else
                                            {
                                                LimpiarM();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Generar la Factura, Intentelo Nuevamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Estudiante no Existe, Digite una matricula valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        Facturacion pF = new Facturacion();
                        pF.Matricula_Estudiante = int.Parse(txtMatricula.Text);
                        pF.Nombre_Estudiante = txtNombre.Text + " " + txtApellido.Text;
                        pF.Precio = double.Parse(txtTotalaPagar.Text);
                        pF.Razon_Pago = txtMotivodePago.Text;
                        pF.Fecha_Factura = DateTime.Now.Date.ToString("yyyy-MM-dd");
                        pF.Cancelacion_Pago = "0";
                        int R = FacturacionDB.CrearFactura(pF);
                        if (R > 0)
                        {
                            string G = GananciasDB.ObtenerCantidad(DateTime.Today.Date.Date.ToString("yyyy-MM-dd"));
                            if (G != null)
                            {
                                Decimal GH, TP, GT;
                                GH = Decimal.Parse(G);
                                TP = Decimal.Parse(txtTotalaPagar.Text);
                                GT = GH + TP;
                                DateTime FechaA = DateTime.Today;
                                int R1 = GananciasDB.ActualizarGananciasF(FechaA.Date.ToString("yyyy-MM-dd"), GT);
                                if (R1 > 0)
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Error al Registrar los Ingresos", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                double GH, TP, GT;
                                GH = 0;
                                TP = pF.Precio;
                                GT = GH + TP;
                                Ganancias pG = new Ganancias();
                                pG.Fecha_Ganancia = DateTime.Today.Date.ToString("yyyy-MM-dd");
                                pG.Ganancia = GT;
                                int R1 = GananciasDB.RegistrarGanancias(pG);
                                if (R1 > 0)
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Error al Registrar los Ingresos1", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            string R0 = FacturacionDB.ObtenerCodigo(pF);
                            if (R0 != null)
                            {
                                MessageBox.Show("Codigo factura: " + R0, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (MessageBox.Show("Desea Imprimir la factura?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    frmImpresionFactura pI = new frmImpresionFactura();
                                    pI.Fecha = DateTime.Today.Date;
                                    pI.Matricula = int.Parse(txtMatricula.Text);
                                    pI.ShowDialog();
                                    LimpiarM();
                                }
                                else
                                {
                                    LimpiarM();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al mostrar el Codigo de la factura", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al crear la factura, Intentelo Nuevamnete", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturasA pf = new frmFacturasA();
                pf.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int cantPAgar = Convert.ToInt32(nCantPagar.Value);
            if (MessageBox.Show("Desea hacer un Descuento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                frmDescuentoFacturacion d = new frmDescuentoFacturacion();
                d.ShowDialog();
                string descuento = d.Descuento;
                if (descuento != null)
                { 
                    try
                    {
                        double des = double.Parse(descuento);
                        if (rbPago.Checked == true)
                        {
                            if (txtMatricula.Text == string.Empty)
                            {
                                MessageBox.Show("Matricula Vacia, Digite una Valida", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtMatricula.Focus();
                            }
                            else
                            {
                                if (EstudianteDB.ObtenerNombre(int.Parse(txtMatricula.Text)) == null)
                                {
                                    MessageBox.Show("El Estudiante no Existe, Digite una matricula valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtMatricula.Clear();
                                    txtApellido.Focus();
                                }
                                else
                                {
                                    Limpiar();
                                    string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                                    string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                                    string ultimop = EstudianteDB.ObtenerUltimoPago(Convert.ToInt32(txtMatricula.Text));
                                    DateTime pPago = EstudianteDB.ObtenerFechaProximoPago(Convert.ToInt32(txtMatricula.Text));
                                    pProximoPago = pPago;
                                    string MP = EstudianteDB.ObtenerModoPago(Convert.ToInt32(txtMatricula.Text));
                                    MP0 = MP;

                                    DateTime fechaActual = DateTime.Today;
                                    pPago0 = pPago;
                                    pPagoA = pPago;

                                    if (pPago.Date == fechaActual.Date)
                                    {
                                        txtFechaPago.Text = "No se ha calculado";
                                        lblFechaPago.ForeColor = Color.Red;
                                        lblFechaPago.Text = lblFechaPago.Text + " " + "No se ha Calculado";
                                        fechaactualpp = DateTime.Now;
                                    }
                                    else
                                    {
                                        txtFechaPago.Text = Convert.ToString(pPago.Date);
                                        lblFechaPago.Text = lblFechaPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                    }

                                    if (ultimop == null || ultimop == string.Empty)
                                    {
                                        lblUltimoPAgo.ForeColor = Color.Red;
                                        lblUltimoPAgo.Text = lblUltimoPAgo.Text + " " + "No se ha Realizado un Pago";
                                        txtUltimoPago.Text = "No se ha realizado un pago";
                                        fechaactualup = DateTime.Now;
                                    }
                                    else
                                    {
                                        DateTime fechaup;
                                        fechaup = Convert.ToDateTime(ultimop);
                                        txtUltimoPago.Text = Convert.ToString(fechaup.Date);
                                        lblUltimoPAgo.Text = lblUltimoPAgo.Text + " " + fechaup.Date.ToString("dd-MM-yyyy");
                                    }

                                    if (nombre != null & apellido != null)
                                    {
                                        txtNombre.Text = nombre;
                                        txtApellido.Text = apellido;
                                        dgvtabla.DataSource = FacturacionDB.BuscarFacturas(Int32.Parse(txtMatricula.Text));
                                        lblAnularPago.Visible = true;
                                        btnAceptar.Focus();
                                        int CompF = DateTime.Compare(pPago0, fechaActual);

                                        // Getting VIP method working together with the old way of payment

                                        if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "NO" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "No" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == null)
                                        {
                                            if (MP == "M" || MP == "Mensual")
                                            {
                                                if (CompF < 0)
                                                {
                                                    
                                                    string Mora = MoraDB.ObtenerMoraMensual();
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddMonths(1));
                                                    pPago0 = pPago0.AddMonths(Convert.ToInt32(cantPAgar));
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pM = Convert.ToDouble(PagosDB.ObtenerPagoMensual());
                                                    pM = pM - des;
                                                    double TotalPagar = pM * cantPAgar;
                                                    lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                                    double DMora = double.Parse(Mora);
                                                    TotalPagar = TotalPagar + DMora;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + TotalPagar.ToString("f2");
                                                    txtTotalaPagar.Text = TotalPagar.ToString("f2");
                                                    lblMora.ForeColor = Color.Red;
                                                    lblMora.Text = lblMora.Text + " " + Mora;
                                                    rbPago.Text = "Pago Mensual";
                                                    txtMotivodePago.Text = "Pago Mes";
                                                    pMora = true;
                                                }
                                                else
                                                {
                                                    lblPendientes.Text = "Meses Pendientes: 0";
                                                    lblMesesoSemanas.Text = "Meses";
                                                    nCantPagar.Value = 1;
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddMonths(1));
                                                    pPago0 = pPago0.AddMonths(1);
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pM = PagosDB.ObtenerPagoMensual();
                                                    pM = pM - des;
                                                    double totalPagar = pM * cantPAgar;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalPagar.ToString("f2");
                                                    lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                                    txtTotalaPagar.Text = totalPagar.ToString("f2");
                                                    lblMora.Text = lblMora.Text + " " + "0";
                                                    rbPago.Text = "Pago Mensual";
                                                    txtMotivodePago.Text = "Pago Mes";
                                                    pMora = false;
                                                }
                                            }
                                            else
                                            {
                                                if (CompF < 0)
                                                {
                                                    string Mora = MoraDB.ObtenerMoraSemanal();
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddDays((Convert.ToInt32(cantPAgar) * 7)));
                                                    pPago0 = pPago0.AddDays((Convert.ToInt32(cantPAgar) * 7));
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pS = Convert.ToDouble(PagosDB.ObtenerPagoSemanal());
                                                    pS = pS - des;
                                                    double totalPAgar = pS * cantPAgar;
                                                    double DMora = double.Parse(Mora);
                                                    lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                                    totalPAgar = totalPAgar + DMora;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalPAgar.ToString("f2");
                                                    txtTotalaPagar.Text = totalPAgar.ToString("f2");
                                                    lblMora.ForeColor = Color.Red;
                                                    lblMora.Text = lblMora.Text + " " + Mora;
                                                    rbPago.Text = "Pago Semanal";
                                                    txtMotivodePago.Text = "Pago Semanal";
                                                    pMora = true;
                                                }
                                                else
                                                {
                                                    lblPendientes.Text = "Semanas Pensientes: 0";
                                                    lblMesesoSemanas.Text = "Semanas";
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddDays(7));
                                                    pPago0 = pPago0.AddDays(7);
                                                    double pS = PagosDB.ObtenerPagoSemanal();
                                                    pS = pS - des;
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + pS.ToString("f2");
                                                    txtTotalaPagar.Text = pS.ToString("f2");
                                                    lblMora.Text = lblMora.Text + " " + "0";
                                                    rbPago.Text = "Pago Semanal";
                                                    txtMotivodePago.Text = "Pago Semanal";
                                                    pMora = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // If false means that the student is a VIP
                                            gbFactura.BackColor = Color.Yellow;
                                            if (MP == "M" || MP == "Mensual")
                                            {
                                                if (CompF < 0)
                                                {
                                                    string Mora = MoraDB.GetVIPpayments().Mora_Mensual;
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddMonths(Convert.ToInt32(cantPAgar)));
                                                    pPago0 = pPago0.AddMonths(Convert.ToInt32(cantPAgar));
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);
                                                    pM = pM - des;
                                                    double totalPAgar = pM * cantPAgar;
                                                    lblPagoMensual.Text = lblPagoMensual.Text + " " + totalPAgar.ToString("f2");
                                                    double DMora = double.Parse(Mora);
                                                    totalPAgar = totalPAgar + DMora;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalPAgar.ToString("f2");
                                                    txtTotalaPagar.Text = totalPAgar.ToString("f2");
                                                    lblMora.ForeColor = Color.Red;
                                                    lblMora.Text = lblMora.Text + " " + Mora;
                                                    rbPago.Text = "Pago Mensual";
                                                    txtMotivodePago.Text = "Pago Mes";
                                                    pMora = true;
                                                }
                                                else
                                                {
                                                    lblPendientes.Text = "Meses Pendientes: 0";
                                                    lblMesesoSemanas.Text = "Meses";
                                                    nCantPagar.Value = 1;
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddMonths(1));
                                                    pPago0 = pPago0.AddMonths(1);
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);
                                                    pM = pM - des;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + pM.ToString("f2");
                                                    lblPagoMensual.Text = lblPagoMensual.Text + " " + pM.ToString("f2");
                                                    txtTotalaPagar.Text = pM.ToString("f2");
                                                    lblMora.Text = lblMora.Text + " " + "0";
                                                    rbPago.Text = "Pago Mensual";
                                                    txtMotivodePago.Text = "Pago Mes";
                                                    pMora = false;
                                                }
                                            }
                                            else
                                            {
                                                if (CompF < 0)
                                                {
                                                    string Mora = MoraDB.GetVIPpayments().Mora_Semanal;
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddDays((Convert.ToInt32(cantPAgar) * 7)));
                                                    pPago0 = pPago0.AddDays((Convert.ToInt32(cantPAgar) * 7));
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    double pS = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                                    pS = pS - des;
                                                    double totalPagar = pS * cantPAgar;
                                                    double DMora = double.Parse(Mora);
                                                    lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                                    totalPagar = totalPagar + DMora;
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalPagar.ToString("f2");
                                                    txtTotalaPagar.Text = totalPagar.ToString("f2");
                                                    lblMora.ForeColor = Color.Red;
                                                    lblMora.Text = lblMora.Text + " " + Mora;
                                                    rbPago.Text = "Pago Semanal";
                                                    txtMotivodePago.Text = "Pago Semanal";
                                                    pMora = true;
                                                }
                                                else
                                                {
                                                    lblPendientes.Text = "Semanas Pendientes: 0";
                                                    lblMesesoSemanas.Text = "Semanas";
                                                    nCantPagar.Value = 1;
                                                    txtProximoPAgo.Text = Convert.ToString(pPago0.AddDays(7));
                                                    pPago0 = pPago0.AddDays(7);
                                                    double pS = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                                    pS = pS - des;
                                                    lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.ToString("dd-MM-yyyy");
                                                    lblPagoMensual.Text = "Pago Semanal:" + " " + pS.ToString("f2");
                                                    lblTotalaPagar.Text = lblTotalaPagar.Text + " " + pS.ToString("f2");
                                                    txtTotalaPagar.Text = pS.ToString("f2");
                                                    lblMora.Text = lblMora.Text + " " + "0";
                                                    rbPago.Text = "Pago Semanal";
                                                    txtMotivodePago.Text = "Pago Semanal";
                                                    pMora = false;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Existe el Alumno, Digite una matricula Valida", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            Limpiar();
                            lblFechaPago.Visible = false;
                            lblMora.Visible = false;
                            lblPagoMensual.Visible = false;
                            lblPagoMensual.Text = "Cantidad a Pagar:";
                            lblProximoPago.Visible = false;
                            lblUltimoPAgo.Visible = false;
                            txtTotalaPagar.Visible = true;
                            lblPendientes.Visible = false;
                            lblMesesoSemanas.Visible = false;
                            lblCantMesesPagar.Visible = false;
                            lblCantidadaPagar.Visible = false;
                            nCantPagar.Visible = false;
                            txtCantPagar.Visible = false;
                            string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                            string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                            if (nombre != null)
                            {
                                txtNombre.Text = nombre;
                                txtApellido.Text = apellido;
                            }
                            else
                            {
                                MessageBox.Show("No Existe el Estudiante, Ingrese una matricula Valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtMatricula.Clear();
                                txtMatricula.Focus();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No se Hizo el descuento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvtabla.SelectedRows.Count == 1)
                {
                    frmImpresionFactura pI = new frmImpresionFactura();
                    pI.Fecha = Convert.ToDateTime(dgvtabla.CurrentRow.Cells[3].Value);
                    string Matricula = dgvtabla.CurrentRow.Cells[0].Value.ToString();
                    pI.Matricula = int.Parse(Matricula);
                    pI.ShowDialog();
                    Limpiar();
                }else
                {
                    MessageBox.Show("Selecciona una Factura a Imprimir", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblMora_Click(object sender, EventArgs e)
        {
            try
            {
                if (pMora == true)
                {
                    if (MessageBox.Show("Desea Eliminar la MORA?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string Modopago = EstudianteDB.ObtenerModoPago(int.Parse(txtMatricula.Text));
                        if (Modopago != null)
                        {
                            // Getting Mora chargue waived for VIP students

                            if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "NO" ||
                                EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "No" ||
                                EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)) == null)
                            {
                                if (Modopago == "M" || Modopago == "Mensual")
                                {
                                    string Mora = MoraDB.ObtenerMoraMensual();
                                    double DMora = double.Parse(Mora);
                                    double TP = double.Parse(txtTotalaPagar.Text);
                                    TP = TP - DMora;
                                    txtTotalaPagar.Text = TP.ToString("f2");
                                    lblMora.ForeColor = Color.Black;
                                    lblMora.Text = "Mora:" + " " + "0";
                                    pMora = false;
                                    lblTotalaPagar.Text = "Total a Pagar:" + " " + TP.ToString("f2");
                                }
                                else
                                {
                                    string Mora = MoraDB.ObtenerMoraSemanal();
                                    double DMora = double.Parse(Mora);
                                    double TP = double.Parse(txtTotalaPagar.Text);
                                    TP = TP - DMora;
                                    txtTotalaPagar.Text = TP.ToString("f2");
                                    lblMora.ForeColor = Color.Black;
                                    lblMora.Text = "Mora:" + " " + "0";
                                    pMora = false;
                                    lblTotalaPagar.Text = "Total a Pagar:" + " " + TP.ToString("f2");
                                }
                            }
                            else
                            {
                                if (Modopago == "M" || Modopago == "Mensual")
                                {
                                    string Mora = MoraDB.GetVIPpayments().Mora_Mensual;
                                    double DMora = double.Parse(Mora);
                                    double TP = double.Parse(txtTotalaPagar.Text);
                                    TP = TP - DMora;
                                    txtTotalaPagar.Text = TP.ToString("f2");
                                    lblMora.ForeColor = Color.Black;
                                    lblMora.Text = "Mora:" + " " + "0";
                                    pMora = false;
                                    lblTotalaPagar.Text = "Total a Pagar:" + " " + TP.ToString("f2");
                                }
                                else
                                {
                                    string Mora = MoraDB.GetVIPpayments().Mora_Semanal;
                                    double DMora = double.Parse(Mora);
                                    double TP = double.Parse(txtTotalaPagar.Text);
                                    TP = TP - DMora;
                                    txtTotalaPagar.Text = TP.ToString("f2");
                                    lblMora.ForeColor = Color.Black;
                                    lblMora.Text = "Mora:" + " " + "0";
                                    pMora = false;
                                    lblTotalaPagar.Text = "Total a Pagar:" + " " + TP.ToString("f2");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error No se pudo cargar el Modo de pago", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblAnularPago_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    MessageBox.Show("Matricula vacia, Digite una valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatricula.Focus();
                }
                else if (txtNombre.Text == string.Empty & txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("No se ha buscado un estudiante, digite una matricula valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatricula.Focus();
                }
                else
                {
                    string Modopago = EstudianteDB.ObtenerModoPago(int.Parse(txtMatricula.Text));
                    if (Modopago == "Mensual" || Modopago == "M")
                    {
                        Facturacion pF = new Facturacion();
                        int R0 = EstudianteDB.ActualizarProximoPago(int.Parse(txtMatricula.Text), pPago0.ToString("yyyy-MM-dd"));
                        pF.Nombre_Estudiante = txtNombre.Text + " " + txtApellido.Text;
                        pF.Cancelacion_Pago = "PAGO ANULADO";
                        pF.Fecha_Factura = DateTime.Today.Date.ToString("yyyy-MM-dd");
                        pF.Matricula_Estudiante = int.Parse(txtMatricula.Text);
                        pF.Precio = 0.00;
                        pF.Razon_Pago = "PAGO ANULADO";

                        int R1 = FacturacionDB.CrearFactura(pF);
                        if (R1 > 0 & R0 > 0)
                        {
                            MessageBox.Show("Pago Anulado!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error, No se Pudo anular el Pago", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        Facturacion pF = new Facturacion();
                        int R0 = EstudianteDB.ActualizarProximoPago(int.Parse(txtMatricula.Text), pPago0.ToString("yyyy-MM-dd"));
                        pF.Nombre_Estudiante = txtNombre.Text + " " + txtApellido.Text;
                        pF.Cancelacion_Pago = "PAGO ANULADO";
                        pF.Fecha_Factura = DateTime.Today.Date.ToString("yyyy-MM-dd");
                        pF.Matricula_Estudiante = int.Parse(txtMatricula.Text);
                        pF.Precio = 0.00;
                        pF.Razon_Pago = "PAGO ANULADO";

                        int R1 = FacturacionDB.CrearFactura(pF);
                        if (R1 > 0 & R0 > 0)
                        {
                            MessageBox.Show("Pago Anulado!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error, No se Pudo anular el Pago", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbPago_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            try {
                populateStudent();
            }
            catch (Exception)
            {
                txtMatricula.Focus();
            }
        }

        private void nCantPagar_ValueChanged(object sender, EventArgs e)
        {
            LimpiarActu();
            if (txtNombre.Text == null || txtMatricula.Text == null || txtMatricula.Text == string.Empty || txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado un Estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int cantPAgar = Convert.ToInt32(nCantPagar.Value);
                try
                {
                    if (rbPago.Checked == true)
                    {
                        if (txtMatricula.Text == string.Empty)
                        {
                            MessageBox.Show("Matricula Vacia, Digite una Valida", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMatricula.Focus();
                        }
                        else
                        {
                            if (EstudianteDB.ObtenerNombre(int.Parse(txtMatricula.Text)) == null)
                            {
                                MessageBox.Show("El Estudiante no Existe, Digite una matricula valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtMatricula.Clear();
                                txtApellido.Focus();
                            }
                            else
                            {
                                string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                                string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                                string ultimop = EstudianteDB.ObtenerUltimoPago(Convert.ToInt32(txtMatricula.Text));
                                DateTime pPago = EstudianteDB.ObtenerFechaProximoPago(Convert.ToInt32(txtMatricula.Text));
                                pProximoPago = pPago;
                                string MP = EstudianteDB.ObtenerModoPago(Convert.ToInt32(txtMatricula.Text));
                                MP0 = MP;

                                DateTime fechaActual = DateTime.Today;
                                pPago0 = pPago;
                                pPagoA = pPago;

                                if (nombre != null & apellido != null)
                                {
                                    btnAceptar.Focus();
                                    int CompF = DateTime.Compare(pPago0, fechaActual);

                                    // Getting VIP method working together with the old way of payment

                                    if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "NO" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == "No" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP == null)
                                    {
                                        if (MP == "M" || MP == "Mensual")
                                        {
                                            if (CompF < 0)
                                            {
                                                // pago mensual no VIP MORA
                                                lblMora.ForeColor = Color.Red;
                                                double mora = Convert.ToDouble(MoraDB.ObtenerMoraMensual());
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(PagosDB.ObtenerPagoMensual());
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value));
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)));
                                            }
                                            else
                                            {
                                                // pago mensual no VIP no MORA
                                                double mora = 0;
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(PagosDB.ObtenerPagoMensual());
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                pPago0.Date.AddMonths((Convert.ToInt32(nCantPagar.Value)));
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)));
                                            }
                                        }
                                        else
                                        {
                                            if (CompF < 0)
                                            {
                                                // pago semanal no VIP mora
                                                lblMora.ForeColor = Color.Red;
                                                double mora = Convert.ToDouble(MoraDB.ObtenerMoraSemanal());
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoS = Convert.ToDouble(PagosDB.ObtenerPagoSemanal());
                                                pagoS = pagoS * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoS;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                int days = (Convert.ToInt32(nCantPagar.Value)) * 7;
                                                pPago0.Date.AddDays(days);
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            }
                                            else
                                            {
                                                // pago semanal no VIP no MORA
                                                double mora = 0;
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoS = Convert.ToDouble(PagosDB.ObtenerPagoSemanal());
                                                pagoS = pagoS * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoS;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                int days = (Convert.ToInt32(nCantPagar.Value)) * 7;
                                                pPago0.Date.AddDays(days);
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // If false means that the student is a VIP
                                        gbFactura.BackColor = Color.Yellow;
                                        if (MP == "M" || MP == "Mensual")
                                        {
                                            if (CompF < 0)
                                            {
                                                // pago mensual VIP MORa
                                                lblMora.ForeColor = Color.Red;
                                                double mora = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Mensual);
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                pPago0.Date.AddMonths((Convert.ToInt32(nCantPagar.Value)));
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)));
                                            }
                                            else
                                            {
                                                // pago mensual VIP No mora
                                                double mora = 0;
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Mensual);
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                pPago0.Date.AddMonths((Convert.ToInt32(nCantPagar.Value)));
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(nCantPagar.Value)));
                                            }
                                        }
                                        else
                                        {
                                            if (CompF < 0)
                                            {
                                                // mora pago semanal VIP student
                                                lblMora.ForeColor = Color.Red;
                                                double mora = Convert.ToDouble(MoraDB.GetVIPpayments().Mora_Semanal);
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                int days = (Convert.ToInt32(nCantPagar.Value)) * 7;
                                                pPago0.Date.AddDays(days);
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            }
                                            else
                                            {
                                                // sin mora pago semanal VIP student
                                                double mora = 0;
                                                mora = mora * (Convert.ToInt32(nCantPagar.Value));
                                                lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                                double pagoM = Convert.ToDouble(MoraDB.GetVIPpayments().Pago_Semanal);
                                                pagoM = pagoM * (Convert.ToInt32(nCantPagar.Value));
                                                double totalpagar = mora + pagoM;
                                                lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                                txtTotalaPagar.Text = totalpagar.ToString("f2");
                                                int days = (Convert.ToInt32(nCantPagar.Value)) * 7;
                                                pPago0.Date.AddDays(days);
                                                lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                                txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Existe el Alumno, Digite una matricula Valida", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        Limpiar();
                        lblFechaPago.Visible = false;
                        lblMora.Visible = false;
                        lblPagoMensual.Visible = false;
                        lblPagoMensual.Text = "Cantidad a Pagar:";
                        lblProximoPago.Visible = false;
                        lblUltimoPAgo.Visible = false;
                        txtTotalaPagar.Visible = true;
                        lblPendientes.Visible = false;
                        lblMesesoSemanas.Visible = false;
                        lblCantMesesPagar.Visible = false;
                        lblCantidadaPagar.Visible = false;
                        nCantPagar.Visible = false;
                        txtCantPagar.Visible = false;
                        string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                        string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                        if (nombre != null)
                        {
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                        }
                        else
                        {
                            MessageBox.Show("No Existe el Estudiante, Ingrese una matricula Valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtMatricula.Clear();
                            txtMatricula.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbOtros_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            try
            {
                populateStudent();
            }
            catch (Exception)
            {
                txtMatricula.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarM();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    populateStudent();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

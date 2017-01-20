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
    public partial class frmFacturacion : Form
    {
        private double semanasP, MesesP, cantPagar, pagoS, pagoM, desc, MoraEs, PagoMensualSemanal, TotalPagoMensualSemanal, TotalMora, TotalDescuento, cantMora;
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
            rbPago.Checked = true;
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
                            rbPago.Checked = true;
                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            dgvtabla.DataSource = FacturacionDB.BuscarFacturas(Int32.Parse(txtMatricula.Text));
                            btnAceptar.Focus();
                            int CompF = DateTime.Compare(pPago0, fechaActual);


                            // validation to verify if student is already retired.
                            if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) != 1)
                            {
                                // verify if el estudiante is registeres for a grupal payment
                                if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                {
                                    // VIP method execution
                                    if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "NO" ||
                                            EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "No" ||
                                            EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != null)
                                    {
                                        // If false means that the student is a VIP
                                        gbFactura.BackColor = Color.Yellow;
                                    }


                                    if (MP == "M" || MP == "Mensual")
                                    {
                                        if (CompF < 0)
                                        {
                                            MesesP = (DateTime.Today.Date - pPago).TotalDays / 30;
                                            lblPendientes.ForeColor = Color.Red;
                                            lblPendientes.Text = "Meses Pendientes: " + (MesesP + 1).ToString("f0");
                                            lblMesesoSemanas.Text = "Meses";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(MesesP + 1);
                                            rbPago.Text = "Pago Mensual";
                                            txtMotivodePago.Text = "Pago Mes";
                                            PagoMensualSemanal = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                            MoraEs = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                            pMora = true;
                                        }
                                        else
                                        {
                                            MesesP = 0;
                                            lblPendientes.ForeColor = Color.Black;
                                            lblPendientes.Text = "Meses Pendientes: 0";
                                            lblMesesoSemanas.Text = "Meses";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = 1;
                                            rbPago.Text = "Pago Mensual";
                                            txtMotivodePago.Text = "Pago Mes";
                                            PagoMensualSemanal = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                            MoraEs = 0;
                                            pMora = false;
                                        }
                                    }
                                    else
                                    {
                                        if (CompF < 0)
                                        {
                                            semanasP = (DateTime.Today.Date - pPago).TotalDays / 7;
                                            lblPendientes.ForeColor = Color.Red;
                                            lblPendientes.Text = "Semanas Pendientes: " + (semanasP).ToString("f0");
                                            lblMesesoSemanas.Text = "Semanas";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(semanasP + 1);
                                            rbPago.Text = "Pago Semanal";
                                            txtMotivodePago.Text = "Pago Semanal";
                                            PagoMensualSemanal = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                            MoraEs = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                            pMora = true;
                                        }
                                        else
                                        {
                                            lblPendientes.ForeColor = Color.Black;
                                            semanasP = 0;
                                            lblPendientes.Text = "Semanas Pendientes: 0";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(semanasP + 1);
                                            lblMesesoSemanas.Text = "Semanas";
                                            rbPago.Text = "Pago Semanal";
                                            PagoMensualSemanal = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                            MoraEs = 0;
                                            txtMotivodePago.Text = "Pago Semanal";
                                            pMora = false;
                                        }
                                    }
                                }
                                // means that the student is registered for a grupal payment
                                else
                                {
                                    EstudianteBase pEstudianteInfo = EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text));
                                    pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(pEstudianteInfo.codigoGrupal);
                                    lblNombreGrupo.Text = pInfoGrupo.Nombre;


                                    gbListaGrupal.Visible = true;
                                    dgvListaGrupo.DataSource = EstudianteDB.listEstudiantesPorPagoGrupal(pInfoGrupo.Id_grupo);

                                    if(pInfoGrupo.ModoPago == "Mensual")
                                    {
                                        // comparar las fechas con la fecha actual para ver si esta atrasado en el pago
                                        if(DateTime.Compare(Convert.ToDateTime(pInfoGrupo.FechaProximoPago), DateTime.Today.Date) < 0)
                                        {
                                            // means that esta atrasado
                                            MesesP = (DateTime.Today.Date - Convert.ToDateTime(pInfoGrupo.FechaProximoPago)).TotalDays / 30;
                                            lblPendientes.ForeColor = Color.Red;
                                            lblPendientes.Text = "Meses Pendientes: " + (MesesP + 1).ToString("f0");
                                            lblMesesoSemanas.Text = "Meses";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(MesesP + 1);
                                            rbPago.Text = "Pago Mensual";
                                            txtMotivodePago.Text = "Pago Mes";
                                            PagoMensualSemanal = pInfoGrupo.pago;
                                            MoraEs = pInfoGrupo.mora;
                                            pMora = true;
                                        }
                                        else
                                        {
                                            // means esta al dia
                                            MesesP = 0;
                                            lblPendientes.ForeColor = Color.Black;
                                            lblPendientes.Text = "Meses Pendientes: 0";
                                            lblMesesoSemanas.Text = "Meses";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = 1;
                                            rbPago.Text = "Pago Mensual";
                                            txtMotivodePago.Text = "Pago Mes";
                                            PagoMensualSemanal = pInfoGrupo.pago;
                                            MoraEs = 0;
                                            pMora = false;
                                        }
                                    }
                                    else if(pInfoGrupo.ModoPago == "Semanal")
                                    {
                                        // comparar las fechas con la fecha actual para ver si esta atrasado en el pago
                                        if (DateTime.Compare(Convert.ToDateTime(pInfoGrupo.FechaProximoPago), DateTime.Today.Date) < 0)
                                        {
                                            // means that esta atrasado
                                            semanasP = (DateTime.Today.Date - Convert.ToDateTime(pInfoGrupo.FechaProximoPago)).TotalDays / 7;
                                            lblPendientes.ForeColor = Color.Red;
                                            lblPendientes.Text = "Semanas Pendientes: " + (semanasP).ToString("f0");
                                            lblMesesoSemanas.Text = "Semanas";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(semanasP + 1);
                                            rbPago.Text = "Pago Semanal";
                                            txtMotivodePago.Text = "Pago Semanal";
                                            PagoMensualSemanal = pInfoGrupo.pago;
                                            MoraEs = pInfoGrupo.mora;
                                            pMora = true;
                                        }
                                        else
                                        {
                                            // means esta al dia
                                            lblPendientes.ForeColor = Color.Black;
                                            semanasP = 0;
                                            lblPendientes.Text = "Semanas Pendientes: 0";
                                            nCantPagar.Value = 0;
                                            nCantPagar.Value = Convert.ToInt32(semanasP + 1);
                                            lblMesesoSemanas.Text = "Semanas";
                                            rbPago.Text = "Pago Semanal";
                                            PagoMensualSemanal = pInfoGrupo.pago;
                                            MoraEs = 0;
                                            txtMotivodePago.Text = "Pago Semanal";
                                            pMora = false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo identificar el modo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                            }
                            else
                            {
                                // when the student is already retired

                                rbOtros.Enabled = false;
                                if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "NO" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "No")
                                {
                                    gbFactura.BackColor = Color.Yellow;
                                }
                                DateTime Fr = EstudianteDB.getFechaRetiro(int.Parse(txtMatricula.Text));
                                DateTime fp = EstudianteDB.ObtenerFechaProximoPago(int.Parse(txtMatricula.Text));
                                int Conf = DateTime.Compare(fp, Fr);
                                pagoM = double.Parse(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)).ToString());
                                MoraEs = double.Parse(EstudianteDB.getRetiradoMora(int.Parse(txtMatricula.Text)).ToString());
                                pagoS = double.Parse(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)).ToString());
                                PagoMensualSemanal = double.Parse(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)).ToString());
                                if (EstudianteDB.ObtenerModoPago(int.Parse(txtMatricula.Text)) == "Mensual")
                                {
                                    if (Conf < 0)
                                    {
                                        MesesP = (Fr - fp).TotalDays / 30;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Meses Pendientes: " + (MesesP).ToString("f0");
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = 0;
                                        nCantPagar.Value = Convert.ToInt32(MesesP);
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        PagoMensualSemanal = pagoM;
                                        pMora = true;
                                    }
                                    else
                                    {
                                        MesesP = 0;
                                        lblPendientes.ForeColor = Color.Black;
                                        lblPendientes.Text = "Meses Pendientes: 0";
                                        lblMesesoSemanas.Text = "Meses";
                                        nCantPagar.Value = 1;
                                        nCantPagar.Value = 0;
                                        nCantPagar.Enabled = false;
                                        btnAceptar.Enabled = false;
                                        rbPago.Text = "Pago Mensual";
                                        txtMotivodePago.Text = "Pago Mes";
                                        PagoMensualSemanal = pagoS;
                                        MoraEs = 0;
                                        pMora = false;
                                    }
                                }
                                else
                                {
                                    if (Conf < 0)
                                    {
                                        semanasP = (Fr - fp).TotalDays / 7;
                                        lblPendientes.ForeColor = Color.Red;
                                        lblPendientes.Text = "Semanas Pendientes: " + (semanasP).ToString("f0");
                                        lblMesesoSemanas.Text = "Semanas";
                                        nCantPagar.Value = 0;
                                        nCantPagar.Value = Convert.ToInt32(semanasP);
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = true;
                                    }
                                    else
                                    {
                                        lblPendientes.ForeColor = Color.Black;
                                        semanasP = 0;
                                        lblPendientes.Text = "Semanas Pendientes: 0";
                                        lblMesesoSemanas.Text = "Semanas";
                                        nCantPagar.Value = 1;
                                        nCantPagar.Value = 0;
                                        nCantPagar.Enabled = false;
                                        btnAceptar.Enabled = false;
                                        rbPago.Text = "Pago Semanal";
                                        txtMotivodePago.Text = "Pago Semanal";
                                        pMora = false;
                                    }
                                }
                                MessageBox.Show("El Estudiante ya fue retirado", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                OtrosPayment();
            }
        }
        private void LimpiarActu()
        {
            lblMora.Text = "Mora:";
            lblProximoPago.Text = "Proximo Pago:";
            lblTotalaPagar.Text = "Total a Pagar:";
            lblPagoMensual.Text = "Pago Mensual:";
            txtProximoPAgo.Clear();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            nCantPagar.Value = 0;
            int cantPAgar = Convert.ToInt32(nCantPagar.Value);
            txtMatricula.Text = ID;
            if (txtMatricula.Text != null || txtMatricula.Text != string.Empty)
            {
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
                            dgvtabla.DataSource = FacturacionDB.TodasLasFacturas(DateTime.Today.Date.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            populateStudent();
                        }
                    }
                    else if(rbOtros.Checked == true)
                    {
                        OtrosPayment();
                    }
                    else
                    {
                        txtMatricula.Focus();
                        dgvtabla.DataSource = FacturacionDB.TodasLasFacturas(DateTime.Today.Date.ToString("yyyy-MM-dd"));
                        populateStudent();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    rbOtros.Checked = true;
                    OtrosPayment();
                    gbListaGrupal.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbTipodePago.Visible = false;
            lblCantMesesPagar.Visible = true;
            lblCantMesesPagar.Text = "Cant. pagar:";
            gbFactura.BackColor = Color.White;
            gbListaGrupal.Visible = false;
        }
        private void OtrosPayment()
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
            lblCantidadaPagar.Visible = false;
            nCantPagar.Visible = false;
            txtCantPagar.Visible = false;
            lblCantMesesPagar.Visible = true;
            lblCantMesesPagar.Text = "Tipo de Pago:";
            cbTipodePago.Visible = true;

            // validate the matricula input
            if (txtMatricula.Text != string.Empty)
            {
                string nombre = EstudianteDB.ObtenerNombre(Convert.ToInt32(txtMatricula.Text));
                string apellido = EstudianteDB.ObtenerApellido(Convert.ToInt32(txtMatricula.Text));
                if (nombre != null)
                {
                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    dgvtabla.DataSource = FacturacionDB.BuscarFacturas(Int32.Parse(txtMatricula.Text));
                }
                else
                {
                    MessageBox.Show("No Existe el Estudiante, Ingrese una matricula Valida", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatricula.Clear();
                    txtMatricula.Focus();
                }
            }
        }
        private void LimpiarM()
        {
            rbPago.Checked = true;
            btnAceptar.Enabled = true;
            nCantPagar.Enabled = true;
            rbOtros.Enabled = true;
            txtCantPagar.Clear();
            cantMora = 0;
            TotalPagoMensualSemanal = 0;
            TotalMora = 0;
            PagoMensualSemanal = 0;
            MoraEs = 0;
            TotalDescuento = 0;
            MesesSemanasRestan = 0;
            cantMesesSemanasPagos = 0;
            devuelta = 0;
            pagoCon = 0;
            descM = 0;
            txtMatricula.Clear();
            desc = 0;
            semanasP = 0;
            MesesP = 0;
            cantPagar = 0;
            pagoS = 0;
            pagoM = 0;
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtMatricula.Focus();
            dgvtabla.DataSource = FacturacionDB.TodasLasFacturas(DateTime.Today.Date.ToString("yyyy-MM-dd"));
            txtApellido.Clear();
            txtNombre.Clear();
            gbFactura.BackColor = Color.White;
            cbTipodePago.SelectedIndex = -1;
            gbListaGrupal.Visible = false;
        }
        private string MP0;
        private DateTime fechaactualpp, fechaactualup, pPago0, pProximoPago;
        private DateTime pPagoA {get; set;}
        private bool pMora { get; set; }

        private void lblCargarEstudiante_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                populateStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Ganancias pGSeleccionada { get; set; }
        private double pagoCon, devuelta, cantMesesSemanasPagos, MesesSemanasRestan;
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
                        else if(txtCantPagar.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha digitado la moneda con la que se pagara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCantPagar.Focus();
                        }
                        else if(EstudianteDB.ObtenerApellido(int.Parse(txtMatricula.Text)) != null)
                        {

                            Facturacion pFactura = new Facturacion();

                            if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                            {
                                pFactura.Nombre_Estudiante = txtNombre.Text + " " + txtApellido.Text;
                                pFactura.Matricula_Estudiante = Convert.ToInt32(txtMatricula.Text);
                                pFactura.Razon_Pago = txtMotivodePago.Text;
                                pFactura.Precio = Double.Parse(txtTotalaPagar.Text);
                                pFactura.Fecha_Factura = DateTime.Today.Date.ToString("yyyy-MM-dd");
                                pFactura.Cancelacion_Pago = "0";
                                pFactura.FechaProximoPago = Convert.ToDateTime(txtProximoPAgo.Text).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal);

                                pFactura.Nombre_Estudiante = pInfoGrupo.Nombre;
                                pFactura.Matricula_Estudiante = pInfoGrupo.Id_grupo;
                                pFactura.Razon_Pago = txtMotivodePago.Text;
                                pFactura.Precio = Double.Parse(txtTotalaPagar.Text);
                                pFactura.Fecha_Factura = DateTime.Today.Date.ToString("yyyy-MM-dd");
                                pFactura.Cancelacion_Pago = "0";
                                pFactura.FechaProximoPago = Convert.ToDateTime(txtProximoPAgo.Text).ToString("yyyy-MM-dd");
                            }

                            // calculo de la devuelta
                            pagoCon = Convert.ToDouble(txtCantPagar.Text);

                            devuelta = pagoCon - (Convert.ToDouble(txtTotalaPagar.Text));
                            int Factura = -1;


                            // calculo semanas restantes
                            string MP = EstudianteDB.ObtenerModoPago(int.Parse(txtMatricula.Text));
                            cantMesesSemanasPagos = Convert.ToInt32(nCantPagar.Value);
                            if (MP == "M" || MP == "Mensual")
                            {
                                MesesSemanasRestan = MesesP - cantMesesSemanasPagos;
                                if(MesesSemanasRestan <= 0)
                                {
                                    MesesSemanasRestan = 0;
                                }
                            }
                            else
                            {
                                MesesSemanasRestan = semanasP - cantMesesSemanasPagos;
                                if (MesesSemanasRestan <= 0)
                                {
                                    MesesSemanasRestan = 0;
                                }
                            }

                            // evaluation for facturas
                            if (devuelta >= 0)
                            {
                                Factura = FacturacionDB.CrearFactura(pFactura, Convert.ToInt32(MesesSemanasRestan.ToString("f0")), int.Parse(txtCantPagar.Text), Convert.ToDouble(devuelta.ToString("f2")), Convert.ToInt32(nCantPagar.Value), PagoMensualSemanal, TotalPagoMensualSemanal, MoraEs, TotalMora, TotalDescuento, Convert.ToInt32(cantMora));
                            }
                            else
                            {
                                MessageBox.Show("La cantidad con la que se pagara es menol que el total a pagar, digite una cantidad valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTotalaPagar.Clear();
                                txtTotalaPagar.Focus();
                            }

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
                                        if(GananciasDB.getAndUpdateGanancias("Cuota", DateTime.Today.Date.ToString("yyyy-MM-dd"), double.Parse(txtTotalaPagar.Text)) < 0)
                                            MessageBox.Show("No se pudo Registrar Los detalles de los ingresos", "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                        if (GananciasDB.getAndUpdateGanancias("Cuota", DateTime.Today.Date.ToString("yyyy-MM-dd"), double.Parse(txtTotalaPagar.Text)) < 0)
                                            MessageBox.Show("No se pudo Registrar Los detalles de los ingresos", "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrio un error registrando las ganancias, intentalo nuevamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                //******////////////////////////********//////////////////////////*****
                                MessageBox.Show("Factura Creada con Exito", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string codigo = FacturacionDB.ObtenerCodigo(pFactura);

                                int ultimop;
                                if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                {
                                    ultimop = EstudianteDB.UltimoPago(pFactura.Fecha_Factura, pFactura.Matricula_Estudiante);
                                }
                                else
                                {
                                    ultimop = pagoGrupal.modifyfup(pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal).Id_grupo, DateTime.Now);
                                }

                                // method for evaliating if the student is retired \
                                int PP;
                                if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                {
                                    if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) > 0)
                                    {
                                        PP = EstudianteDB.ActualizarProximoPago(int.Parse(txtMatricula.Text), Convert.ToDateTime(txtProximoPAgo.Text).ToString("yyyy-MM-dd"));
                                    }
                                    else
                                    {
                                        PP = EstudianteDB.ActualizarProximoPago(Convert.ToInt32(txtMatricula.Text), Convert.ToDateTime(txtProximoPAgo.Text).ToString("yyyy-MM-dd"));
                                    }
                                }
                                else
                                {
                                   PP = pagoGrupal.anadirEstudiante(int.Parse(txtMatricula.Text), pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal).Id_grupo, txtProximoPAgo.Text);
                                }
                                int retorno1 = FacturacionDB.ActualizarFechaPAgoAnterior(int.Parse(codigo), pPagoA.Date.ToString("yyyy-MM-dd"));

                                if (codigo != null & ultimop > 0 & PP > 0 & retorno1 > 0)
                                {
                                    MessageBox.Show("Codigo Factura: " + codigo + "\n" + "Devuelta: " + devuelta.ToString("f2") + "\n" + "Cant Pendiente: " + MesesSemanasRestan.ToString("f0"), "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (MessageBox.Show("Desea Imprimir la Factura?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        string codigoFactura = FacturacionDB.getFacturaID(txtMatricula.Text, txtMotivodePago.Text, DateTime.Today.Date.ToString("yyyy-MM-dd"), MesesSemanasRestan.ToString("f0"), pagoCon.ToString(), TotalDescuento.ToString());

                                        if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                        {
                                            if (MP == "Mensual")
                                            {
                                                frmFacturaMensual pFacturaEst = new frmFacturaMensual();
                                                pFacturaEst.matricula = int.Parse(codigoFactura);
                                                pFacturaEst.ShowDialog();
                                            }
                                            else if (MP == "Semanal")
                                            {
                                                frmFacturaSemanal pFacturaSem = new frmFacturaSemanal();
                                                pFacturaSem.matricula = int.Parse(codigoFactura);
                                                pFacturaSem.ShowDialog();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El modo de pago no ha sido registrado para este estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                if (MessageBox.Show("Desearia registrar un modo de pago para este estudiante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                {
                                                    frmRegistro pRegistro = new frmRegistro();
                                                    EstudianteBase pEstudiante = EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text));
                                                    pRegistro.GetIDestudiante = pEstudiante;
                                                    pRegistro.ShowDialog();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            EstudianteBase pInfoEstudiante = EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text));
                                            if(pagoGrupal.getPagoGrupal(pInfoEstudiante.codigoGrupal).ModoPago == "Mensual")
                                            {
                                                frmFacturaMensual pFacturaEst = new frmFacturaMensual();
                                                pFacturaEst.matricula = int.Parse(codigoFactura);
                                                pFacturaEst.ShowDialog();
                                            }
                                            else if(pagoGrupal.getPagoGrupal(pInfoEstudiante.codigoGrupal).ModoPago == "Semanal")
                                            {
                                                frmFacturaSemanal pFacturaSem = new frmFacturaSemanal();
                                                pFacturaSem.matricula = int.Parse(codigoFactura);
                                                pFacturaSem.ShowDialog();
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se pudo Identificar el modo de pago del Grupo donde esta registrado el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
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
                                            if (MessageBox.Show("Desea Imprimir la Factura?", "Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                            {
                                                frmReporte pFacturaImpr = new frmReporte();
                                                string codigoFactura = FacturacionDB.getFacturaID(txtMatricula.Text, txtMotivodePago.Text, DateTime.Today.Date.ToString("yyyy-MM-dd"), MesesSemanasRestan.ToString(), pagoCon.ToString(), TotalDescuento.ToString());
                                                pFacturaImpr.TipoReporte = "Factura";
                                                pFacturaImpr.Text = "Factura";
                                                pFacturaImpr.ModoPago = MP;
                                                pFacturaImpr.codigoFactura = codigoFactura;
                                                pFacturaImpr.ShowDialog();
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
                        int R = FacturacionDB.CrearFactura(pF, 0, 0, 0, 0, double.Parse(txtTotalaPagar.Text), double.Parse(txtTotalaPagar.Text), 0, 0, 0, 0);
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
                                    if(GananciasDB.getAndUpdateGanancias(cbTipodePago.Text, DateTime.Now.Date.ToString("yyyy-MM-dd"), double.Parse(txtTotalaPagar.Text)) < 0)
                                        MessageBox.Show("No se pudo Registrar los detalles de los ingresos", "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    if (GananciasDB.getAndUpdateGanancias(cbTipodePago.Text, DateTime.Now.Date.ToString("yyyy-MM-dd"), double.Parse(txtTotalaPagar.Text)) < 0)
                                        MessageBox.Show("No se pudo Registrar los detalles de los ingresos", "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                LimpiarM();
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

        // evento para validar la entrada que haga el usuario
        private void txtCantPagar_TextChanged(object sender, EventArgs e)
        {
            double comparacion;
            if(!double.TryParse(txtCantPagar.Text, out comparacion))
            {
                txtCantPagar.Clear();
            }
        }

        private void lblNombreGrupo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                if (txtMatricula.Text != string.Empty)
                {
                    if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)) != null)
                    {
                        frmFamilyConf pInfoGrupo = new frmFamilyConf();
                        pInfoGrupo.menu = false;
                        if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal != 0)
                        {
                            pInfoGrupo.codigoGrupo = EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal;
                            pInfoGrupo.ShowDialog();
                            populateStudent();
                        }
                        else
                        {
                            MessageBox.Show("El Estudiante no esta registrado en un pago grupal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe el estudiante, digite una matricula valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatricula.Clear();
                        txtMatricula.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Matricula vacia, digite una matricula valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string MP = EstudianteDB.ObtenerModoPago(Convert.ToInt32(txtMatricula.Text));
                        double des = double.Parse(descuento);
                        desc = des;
                        if (MP == "M" || MP == "Mensual")
                        {
                            nCantPagar.Value = 0;
                            nCantPagar.Value = Convert.ToInt32(MesesP + 1);
                        }
                        else
                        {
                            nCantPagar.Value = 0;
                            nCantPagar.Value = Convert.ToInt32(semanasP + 1);
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

        private void txtCantPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }

        private void gbInformacionEstudiante_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string Matricula = dgvtabla.CurrentRow.Cells[0].Value.ToString();
                string CodigoFactura = dgvtabla.CurrentRow.Cells[6].Value.ToString();
                if (dgvtabla.SelectedRows.Count == 1)
                {
                    if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(Matricula)) != null)
                    {
                        string MP = EstudianteDB.ObtenerModoPago(int.Parse(Matricula));
                        if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(Matricula)).pagoGrupal == 0)
                        {
                            if (MP == "Mensual")
                            {
                                frmFacturaMensual pFactura = new frmFacturaMensual();
                                pFactura.matricula = int.Parse(CodigoFactura);
                                pFactura.ShowDialog();
                            }
                            else if (MP == "Semanal")
                            {
                                frmFacturaSemanal pFactura = new frmFacturaSemanal();
                                pFactura.matricula = int.Parse(CodigoFactura);
                                pFactura.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No se ha registrado un modo pago para el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (MessageBox.Show("Desearia registrar un modo de pago para este estudiante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    frmRegistro pRegistro = new frmRegistro();
                                    EstudianteBase pEstudiante = EstudianteDB.SeleccionarEstudiante(int.Parse(Matricula));
                                    pRegistro.GetIDestudiante = pEstudiante;
                                    pRegistro.ShowDialog();
                                }

                            }
                        }
                        else
                        {
                            EstudianteBase pInfoEstudiante = EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(Matricula));
                            if (pagoGrupal.getPagoGrupal(pInfoEstudiante.codigoGrupal).ModoPago == "Mensual")
                            {
                                frmFacturaMensual pFactura = new frmFacturaMensual();
                                pFactura.matricula = int.Parse(CodigoFactura);
                                pFactura.ShowDialog();
                            }
                            else if (pagoGrupal.getPagoGrupal(pInfoEstudiante.codigoGrupal).ModoPago == "Semanal")
                            {
                                frmFacturaSemanal pFactura = new frmFacturaSemanal();
                                pFactura.matricula = int.Parse(CodigoFactura);
                                pFactura.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo identificar el modo de pago del Grupo donde esta registrado el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        if (pagoGrupal.getPagoGrupal(int.Parse(Matricula)).ModoPago == "Mensual")
                        {
                            frmFacturaMensual pFactura = new frmFacturaMensual();
                            pFactura.matricula = int.Parse(CodigoFactura);
                            pFactura.ShowDialog();
                        }
                        else if (pagoGrupal.getPagoGrupal(int.Parse(Matricula)).ModoPago == "Semanal")
                        {
                            frmFacturaSemanal pFactura = new frmFacturaSemanal();
                            pFactura.matricula = int.Parse(CodigoFactura);
                            pFactura.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo identificar el modo de pago del Grupo donde esta registrado el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una Factura a Imprimir", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                string Matricula = dgvtabla.CurrentRow.Cells[0].Value.ToString();
                string CodigoFactura = dgvtabla.CurrentRow.Cells[6].Value.ToString();

                if (pagoGrupal.getPagoGrupal(int.Parse(Matricula)).ModoPago == "Mensual")
                {
                    frmFacturaMensual pFactura = new frmFacturaMensual();
                    pFactura.matricula = int.Parse(CodigoFactura);
                    pFactura.ShowDialog();
                }
                else if (pagoGrupal.getPagoGrupal(int.Parse(Matricula)).ModoPago == "Semanal")
                {
                    frmFacturaSemanal pFactura = new frmFacturaSemanal();
                    pFactura.matricula = int.Parse(CodigoFactura);
                    pFactura.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se pudo identificar el modo de pago del Grupo donde esta registrado el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private double descM;
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
                                    descM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                    nCantPagar.Value = 0;
                                    nCantPagar.Value = Convert.ToInt32(MesesP + 1);
                                }
                                else
                                {
                                    descM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                    nCantPagar.Value = 0;
                                    nCantPagar.Value = Convert.ToInt32(semanasP + 1);
                                }
                            }
                            else
                            {
                                if (Modopago == "M" || Modopago == "Mensual")
                                {
                                    descM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                    nCantPagar.Value = 0;
                                    nCantPagar.Value = Convert.ToInt32(MesesP + 1);
                                }
                                else
                                {
                                    descM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                    nCantPagar.Value = 0;
                                    nCantPagar.Value = Convert.ToInt32(semanasP + 1);
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
            /// this iten was deleted
        }

        private void rbPago_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            try {
                if (rbOtros.Checked)
                {
                    OtrosPayment();
                }
                else
                {
                    populateStudent();
                }
            }
            catch (Exception)
            {
                txtMatricula.Focus();
            }
        }

        private void nCantPagar_ValueChanged(object sender, EventArgs e)
        {
            LimpiarActu();
            cantPagar = Convert.ToInt32(nCantPagar.Value);
            if (txtNombre.Text == null || txtMatricula.Text == null || txtMatricula.Text == string.Empty || txtNombre.Text == string.Empty)
            {
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

                                    if (EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "NO" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != "No" ||
                                        EstudianteDB.SeleccionarEstudiante(int.Parse(txtMatricula.Text)).VIP != null)
                                    {
                                        gbFactura.BackColor = Color.Yellow;
                                    }

                                    if (MP == "M" || MP == "Mensual")
                                    {
                                        if (CompF < 0)
                                        {
                                            double mora;
                                            if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                            {
                                                if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) != 1)
                                                {
                                                    pagoM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                                    mora = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                                }
                                                else
                                                {
                                                    pagoM = Convert.ToDouble(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)));
                                                    mora = EstudianteDB.getRetiradoMora(int.Parse(txtMatricula.Text));
                                                }
                                            }
                                            else
                                            {
                                                pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal);
                                                pagoM = pInfoGrupo.pago;
                                                mora = pInfoGrupo.mora;
                                            }

                                            TotalPagoMensualSemanal = pagoM * (Convert.ToInt32(cantPagar));
                                            pagoM -= desc;
                                            lblPagoMensual.Text = lblPagoMensual.Text + " " + pagoM.ToString("f2");
                                            lblMora.ForeColor = Color.Red;
                                            if (Convert.ToInt32(cantPagar) > Convert.ToInt32(MesesP))
                                            {
                                                mora = (mora - (descM)) * (Convert.ToInt32(MesesP));
                                                cantMora = Convert.ToInt32(MesesP);
                                            }
                                            else
                                            {
                                                mora = (mora - (descM)) * (Convert.ToInt32(cantPagar));
                                                cantMora = Convert.ToInt32(cantPagar);
                                            }
                                            lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                            pagoM = pagoM * (Convert.ToInt32(cantPagar));
                                            TotalMora = mora;
                                            double totalpagar = mora + pagoM;
                                            lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                            txtTotalaPagar.Text = totalpagar.ToString("f2");
                                            pPago0.Date.AddMonths((Convert.ToInt32(cantPagar)));
                                            lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(cantPagar)).ToString("dd-MM-yyyy");
                                            txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(cantPagar)));
                                            TotalDescuento = desc * Convert.ToInt32(nCantPagar.Value);
                                        }
                                        else
                                        {
                                            lblPendientes.ForeColor = Color.Black;
                                            lblMora.ForeColor = Color.Black;
                                            if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                            {
                                                if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) != 1)
                                                {
                                                    pagoM = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                                }
                                                else
                                                {
                                                    pagoM = Convert.ToDouble(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)));
                                                }
                                            }
                                            else
                                            {
                                                pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal);
                                                pagoM = pInfoGrupo.pago;
                                            }

                                            TotalPagoMensualSemanal = pagoM * (Convert.ToInt32(cantPagar));
                                            pagoM -= desc;
                                            lblPagoMensual.Text = lblPagoMensual.Text + " " + pagoM.ToString("f2");
                                            double mora = 0;
                                            mora = mora * (Convert.ToInt32(MesesP));
                                            lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                            pagoM = pagoM * (Convert.ToInt32(cantPagar));
                                            TotalMora = mora;
                                            double totalpagar = mora + pagoM;
                                            lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                            txtTotalaPagar.Text = totalpagar.ToString("f2");
                                            pPago0.Date.AddMonths((Convert.ToInt32(cantPagar)));
                                            lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddMonths(Convert.ToInt32(cantPagar)).ToString("dd-MM-yyyy");
                                            txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddMonths(Convert.ToInt32(cantPagar)));
                                            TotalDescuento = desc * Convert.ToInt32(nCantPagar.Value);
                                        }
                                    }
                                    else
                                    {
                                        if (CompF < 0)
                                        {
                                            double mora;
                                            if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                            {
                                                if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) != 1)
                                                {
                                                    pagoS = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                                    mora = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).mora;
                                                }
                                                else
                                                {
                                                    pagoS = Convert.ToDouble(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)));
                                                    mora = EstudianteDB.getRetiradoMora(int.Parse(txtMatricula.Text));
                                                }
                                            }
                                            else
                                            {
                                                pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal);
                                                pagoS = pInfoGrupo.pago;
                                                mora = pInfoGrupo.mora;
                                            }

                                            TotalPagoMensualSemanal = pagoS * (Convert.ToInt32(cantPagar));
                                            pagoS -= desc;
                                            lblPagoMensual.Text = "Pago Semanal:" + " " + pagoS.ToString("f2");
                                            lblMora.ForeColor = Color.Red;
                                            if (Convert.ToInt32(cantPagar) > Convert.ToInt32(semanasP))
                                            {
                                                mora = (mora - (descM)) * (Convert.ToInt32(semanasP));
                                                cantMora = Convert.ToInt32(semanasP);
                                            }
                                            else
                                            {
                                                mora = (mora - (descM)) * (Convert.ToInt32(cantPagar));
                                                cantMora = Convert.ToInt32(cantPagar);
                                            }
                                            lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                            pagoS = pagoS * (Convert.ToInt32(cantPagar));
                                            TotalMora = mora;
                                            double totalpagar = mora + pagoS;
                                            lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                            txtTotalaPagar.Text = totalpagar.ToString("f2");

                                            int days = (Convert.ToInt32(cantPagar)) * 7;
                                            pPago0.Date.AddDays(days);
                                            lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                            txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            TotalDescuento = desc * Convert.ToInt32(nCantPagar.Value);
                                        }
                                        else
                                        {
                                            lblPendientes.ForeColor = Color.Black;
                                            lblMora.ForeColor = Color.Black;
                                            if (EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).pagoGrupal == 0)
                                            {
                                                if (EstudianteDB.getRetirado(int.Parse(txtMatricula.Text)) != 1)
                                                {
                                                    pagoS = PagosDB.getPrecio(int.Parse(txtMatricula.Text)).precio;
                                                }
                                                else
                                                {
                                                    pagoS = Convert.ToDouble(EstudianteDB.getRetiradoPayment(int.Parse(txtMatricula.Text)));
                                                }
                                            }
                                            else
                                            {
                                                pagoGrupal pInfoGrupo = pagoGrupal.getPagoGrupal(EstudianteDB.SeleccionarEstudiante(Convert.ToInt64(txtMatricula.Text)).codigoGrupal);
                                                pagoS = pInfoGrupo.pago;
                                            }

                                            TotalPagoMensualSemanal = pagoS * (Convert.ToInt32(cantPagar));
                                            pagoS -= desc;
                                            lblPagoMensual.Text = "Pago Semanal:" + " " + pagoS.ToString("f2");
                                            double mora = 0;
                                            mora = mora * (Convert.ToInt32(cantPagar));
                                            lblMora.Text = lblMora.Text + " " + mora.ToString("f2");
                                            pagoS = pagoS * (Convert.ToInt32(cantPagar));
                                            TotalMora = mora;
                                            double totalpagar = mora + pagoS;
                                            lblTotalaPagar.Text = lblTotalaPagar.Text + " " + totalpagar.ToString("f2");
                                            txtTotalaPagar.Text = totalpagar.ToString("f2");
                                            int days = (Convert.ToInt32(cantPagar)) * 7;
                                            pPago0.Date.AddDays(days);
                                            lblProximoPago.Text = lblProximoPago.Text + " " + pPago0.Date.AddDays(days).ToString("dd-MM-yyyy");
                                            txtProximoPAgo.Text = Convert.ToString(pPago0.Date.AddDays(days));
                                            TotalDescuento = desc * Convert.ToInt32(nCantPagar.Value);
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
                        OtrosPayment();
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
                if (rbOtros.Checked)
                {
                    OtrosPayment();
                }
                else
                {
                    populateStudent();
                }
            }
            catch (Exception)
            {
                txtMatricula.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            rbPago.Checked = true;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

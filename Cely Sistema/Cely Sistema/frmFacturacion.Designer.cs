namespace Cely_Sistema
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMotivodePago = new System.Windows.Forms.Label();
            this.txtMotivodePago = new System.Windows.Forms.TextBox();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCargarEstudiante = new System.Windows.Forms.LinkLabel();
            this.txtUltimoPago = new System.Windows.Forms.TextBox();
            this.lblUltimoPAgo = new System.Windows.Forms.Label();
            this.dgvtabla = new System.Windows.Forms.DataGridView();
            this.gbUltimosPagos = new System.Windows.Forms.GroupBox();
            this.lblProximoPago = new System.Windows.Forms.Label();
            this.txtProximoPAgo = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.lblMora = new System.Windows.Forms.Label();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.lblTotalaPagar = new System.Windows.Forms.Label();
            this.lblPagoMensual = new System.Windows.Forms.Label();
            this.gbInformacionEstudiante = new System.Windows.Forms.GroupBox();
            this.gbListaGrupal = new System.Windows.Forms.GroupBox();
            this.dgvListaGrupo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.cbTipodePago = new System.Windows.Forms.ComboBox();
            this.lblMesesoSemanas = new System.Windows.Forms.Label();
            this.nCantPagar = new System.Windows.Forms.NumericUpDown();
            this.lblCantMesesPagar = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCantidadaPagar = new System.Windows.Forms.Label();
            this.txtCantPagar = new System.Windows.Forms.TextBox();
            this.gbMotivoPago = new System.Windows.Forms.GroupBox();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNombreGrupo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabla)).BeginInit();
            this.gbUltimosPagos.SuspendLayout();
            this.gbInformacionEstudiante.SuspendLayout();
            this.gbListaGrupal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantPagar)).BeginInit();
            this.gbMotivoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(73, 30);
            this.txtMatricula.MaxLength = 7;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(81, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(9, 593);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(14, 33);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(73, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(114, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblMotivodePago
            // 
            this.lblMotivodePago.AutoSize = true;
            this.lblMotivodePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivodePago.Location = new System.Drawing.Point(8, 164);
            this.lblMotivodePago.Name = "lblMotivodePago";
            this.lblMotivodePago.Size = new System.Drawing.Size(121, 16);
            this.lblMotivodePago.TabIndex = 9;
            this.lblMotivodePago.Text = "Motivo de Pago:";
            // 
            // txtMotivodePago
            // 
            this.txtMotivodePago.Location = new System.Drawing.Point(135, 161);
            this.txtMotivodePago.Name = "txtMotivodePago";
            this.txtMotivodePago.Size = new System.Drawing.Size(100, 22);
            this.txtMotivodePago.TabIndex = 1;
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Location = new System.Drawing.Point(197, 593);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(75, 23);
            this.btnVerFacturas.TabIndex = 3;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(288, 593);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCargarEstudiante
            // 
            this.lblCargarEstudiante.AutoSize = true;
            this.lblCargarEstudiante.Location = new System.Drawing.Point(160, 33);
            this.lblCargarEstudiante.Name = "lblCargarEstudiante";
            this.lblCargarEstudiante.Size = new System.Drawing.Size(40, 13);
            this.lblCargarEstudiante.TabIndex = 1;
            this.lblCargarEstudiante.TabStop = true;
            this.lblCargarEstudiante.Text = "Buscar";
            this.lblCargarEstudiante.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCargarEstudiante_LinkClicked);
            // 
            // txtUltimoPago
            // 
            this.txtUltimoPago.Location = new System.Drawing.Point(241, 60);
            this.txtUltimoPago.Name = "txtUltimoPago";
            this.txtUltimoPago.Size = new System.Drawing.Size(10, 22);
            this.txtUltimoPago.TabIndex = 4;
            // 
            // lblUltimoPAgo
            // 
            this.lblUltimoPAgo.AutoSize = true;
            this.lblUltimoPAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoPAgo.Location = new System.Drawing.Point(32, 82);
            this.lblUltimoPAgo.Name = "lblUltimoPAgo";
            this.lblUltimoPAgo.Size = new System.Drawing.Size(97, 16);
            this.lblUltimoPAgo.TabIndex = 15;
            this.lblUltimoPAgo.Text = "Ultimo Pago:";
            this.lblUltimoPAgo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvtabla
            // 
            this.dgvtabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtabla.Location = new System.Drawing.Point(6, 19);
            this.dgvtabla.Name = "dgvtabla";
            this.dgvtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtabla.Size = new System.Drawing.Size(666, 586);
            this.dgvtabla.TabIndex = 16;
            // 
            // gbUltimosPagos
            // 
            this.gbUltimosPagos.Controls.Add(this.dgvtabla);
            this.gbUltimosPagos.Location = new System.Drawing.Point(372, 7);
            this.gbUltimosPagos.Name = "gbUltimosPagos";
            this.gbUltimosPagos.Size = new System.Drawing.Size(683, 613);
            this.gbUltimosPagos.TabIndex = 17;
            this.gbUltimosPagos.TabStop = false;
            this.gbUltimosPagos.Text = "Ultimos Pagos";
            // 
            // lblProximoPago
            // 
            this.lblProximoPago.AutoSize = true;
            this.lblProximoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoPago.Location = new System.Drawing.Point(20, 148);
            this.lblProximoPago.Name = "lblProximoPago";
            this.lblProximoPago.Size = new System.Drawing.Size(109, 16);
            this.lblProximoPago.TabIndex = 19;
            this.lblProximoPago.Text = "Proximo Pago:";
            // 
            // txtProximoPAgo
            // 
            this.txtProximoPAgo.Location = new System.Drawing.Point(241, 113);
            this.txtProximoPAgo.Name = "txtProximoPAgo";
            this.txtProximoPAgo.Size = new System.Drawing.Size(10, 22);
            this.txtProximoPAgo.TabIndex = 18;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(45, 321);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 21;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(33, 66);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(96, 16);
            this.lblFechaPago.TabIndex = 23;
            this.lblFechaPago.Text = "Fecha Pago:";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(240, 86);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(10, 22);
            this.txtFechaPago.TabIndex = 22;
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.Location = new System.Drawing.Point(82, 113);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(47, 16);
            this.lblMora.TabIndex = 25;
            this.lblMora.Text = "Mora:";
            this.lblMora.Click += new System.EventHandler(this.lblMora_Click);
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.Location = new System.Drawing.Point(134, 129);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(101, 22);
            this.txtTotalaPagar.TabIndex = 0;
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalaPagar.Location = new System.Drawing.Point(22, 129);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(107, 16);
            this.lblTotalaPagar.TabIndex = 8;
            this.lblTotalaPagar.Text = "Total a Pagar:";
            // 
            // lblPagoMensual
            // 
            this.lblPagoMensual.AutoSize = true;
            this.lblPagoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoMensual.Location = new System.Drawing.Point(18, 98);
            this.lblPagoMensual.Name = "lblPagoMensual";
            this.lblPagoMensual.Size = new System.Drawing.Size(111, 16);
            this.lblPagoMensual.TabIndex = 26;
            this.lblPagoMensual.Text = "Pago Mensual:";
            this.lblPagoMensual.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gbInformacionEstudiante
            // 
            this.gbInformacionEstudiante.Controls.Add(this.gbListaGrupal);
            this.gbInformacionEstudiante.Controls.Add(this.pictureBox1);
            this.gbInformacionEstudiante.Controls.Add(this.lblMatricula);
            this.gbInformacionEstudiante.Controls.Add(this.txtMatricula);
            this.gbInformacionEstudiante.Controls.Add(this.txtApellido);
            this.gbInformacionEstudiante.Controls.Add(this.txtNombre);
            this.gbInformacionEstudiante.Controls.Add(this.lblNombre);
            this.gbInformacionEstudiante.Controls.Add(this.lblApellido);
            this.gbInformacionEstudiante.Controls.Add(this.lblCargarEstudiante);
            this.gbInformacionEstudiante.Location = new System.Drawing.Point(12, 7);
            this.gbInformacionEstudiante.Name = "gbInformacionEstudiante";
            this.gbInformacionEstudiante.Size = new System.Drawing.Size(360, 277);
            this.gbInformacionEstudiante.TabIndex = 27;
            this.gbInformacionEstudiante.TabStop = false;
            this.gbInformacionEstudiante.Text = "Informacion Estudiante";
            this.gbInformacionEstudiante.Enter += new System.EventHandler(this.gbInformacionEstudiante_Enter);
            // 
            // gbListaGrupal
            // 
            this.gbListaGrupal.Controls.Add(this.lblNombreGrupo);
            this.gbListaGrupal.Controls.Add(this.dgvListaGrupo);
            this.gbListaGrupal.Location = new System.Drawing.Point(6, 114);
            this.gbListaGrupal.Name = "gbListaGrupal";
            this.gbListaGrupal.Size = new System.Drawing.Size(338, 157);
            this.gbListaGrupal.TabIndex = 18;
            this.gbListaGrupal.TabStop = false;
            this.gbListaGrupal.Text = "Pago Grupal";
            // 
            // dgvListaGrupo
            // 
            this.dgvListaGrupo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaGrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGrupo.Location = new System.Drawing.Point(6, 56);
            this.dgvListaGrupo.Name = "dgvListaGrupo";
            this.dgvListaGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaGrupo.Size = new System.Drawing.Size(329, 95);
            this.dgvListaGrupo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.Color.White;
            this.gbFactura.Controls.Add(this.cbTipodePago);
            this.gbFactura.Controls.Add(this.lblMesesoSemanas);
            this.gbFactura.Controls.Add(this.nCantPagar);
            this.gbFactura.Controls.Add(this.lblCantMesesPagar);
            this.gbFactura.Controls.Add(this.lblPendientes);
            this.gbFactura.Controls.Add(this.lblCantidadaPagar);
            this.gbFactura.Controls.Add(this.txtCantPagar);
            this.gbFactura.Controls.Add(this.lblFechaPago);
            this.gbFactura.Controls.Add(this.txtTotalaPagar);
            this.gbFactura.Controls.Add(this.lblPagoMensual);
            this.gbFactura.Controls.Add(this.lblTotalaPagar);
            this.gbFactura.Controls.Add(this.lblMora);
            this.gbFactura.Controls.Add(this.lblMotivodePago);
            this.gbFactura.Controls.Add(this.txtMotivodePago);
            this.gbFactura.Controls.Add(this.txtFechaPago);
            this.gbFactura.Controls.Add(this.txtUltimoPago);
            this.gbFactura.Controls.Add(this.lblUltimoPAgo);
            this.gbFactura.Controls.Add(this.lblProximoPago);
            this.gbFactura.Controls.Add(this.txtProximoPAgo);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(9, 335);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(363, 252);
            this.gbFactura.TabIndex = 28;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            // 
            // cbTipodePago
            // 
            this.cbTipodePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipodePago.FormattingEnabled = true;
            this.cbTipodePago.Items.AddRange(new object[] {
            "Inscripcion",
            "Reinscripcion",
            "Libros",
            "Derecho a Examen"});
            this.cbTipodePago.Location = new System.Drawing.Point(147, 31);
            this.cbTipodePago.Name = "cbTipodePago";
            this.cbTipodePago.Size = new System.Drawing.Size(159, 24);
            this.cbTipodePago.TabIndex = 33;
            // 
            // lblMesesoSemanas
            // 
            this.lblMesesoSemanas.AutoSize = true;
            this.lblMesesoSemanas.Location = new System.Drawing.Point(172, 34);
            this.lblMesesoSemanas.Name = "lblMesesoSemanas";
            this.lblMesesoSemanas.Size = new System.Drawing.Size(0, 16);
            this.lblMesesoSemanas.TabIndex = 32;
            // 
            // nCantPagar
            // 
            this.nCantPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCantPagar.Location = new System.Drawing.Point(126, 32);
            this.nCantPagar.Name = "nCantPagar";
            this.nCantPagar.Size = new System.Drawing.Size(40, 22);
            this.nCantPagar.TabIndex = 31;
            this.nCantPagar.ValueChanged += new System.EventHandler(this.nCantPagar_ValueChanged);
            // 
            // lblCantMesesPagar
            // 
            this.lblCantMesesPagar.AutoSize = true;
            this.lblCantMesesPagar.Location = new System.Drawing.Point(33, 34);
            this.lblCantMesesPagar.Name = "lblCantMesesPagar";
            this.lblCantMesesPagar.Size = new System.Drawing.Size(88, 16);
            this.lblCantMesesPagar.TabIndex = 30;
            this.lblCantMesesPagar.Text = "Cant pagar:";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(18, 18);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(90, 16);
            this.lblPendientes.TabIndex = 18;
            this.lblPendientes.Text = "Pendientes:";
            // 
            // lblCantidadaPagar
            // 
            this.lblCantidadaPagar.AutoSize = true;
            this.lblCantidadaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadaPagar.Location = new System.Drawing.Point(8, 192);
            this.lblCantidadaPagar.Name = "lblCantidadaPagar";
            this.lblCantidadaPagar.Size = new System.Drawing.Size(133, 16);
            this.lblCantidadaPagar.TabIndex = 29;
            this.lblCantidadaPagar.Text = "Cantidad a Pagar:";
            // 
            // txtCantPagar
            // 
            this.txtCantPagar.Location = new System.Drawing.Point(147, 189);
            this.txtCantPagar.Name = "txtCantPagar";
            this.txtCantPagar.Size = new System.Drawing.Size(100, 22);
            this.txtCantPagar.TabIndex = 28;
            this.txtCantPagar.TextChanged += new System.EventHandler(this.txtCantPagar_TextChanged);
            this.txtCantPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPagar_KeyPress);
            // 
            // gbMotivoPago
            // 
            this.gbMotivoPago.Controls.Add(this.rbOtros);
            this.gbMotivoPago.Controls.Add(this.rbPago);
            this.gbMotivoPago.Location = new System.Drawing.Point(9, 290);
            this.gbMotivoPago.Name = "gbMotivoPago";
            this.gbMotivoPago.Size = new System.Drawing.Size(240, 46);
            this.gbMotivoPago.TabIndex = 27;
            this.gbMotivoPago.TabStop = false;
            this.gbMotivoPago.Text = "Motivo de Pago";
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(174, 19);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(50, 17);
            this.rbOtros.TabIndex = 1;
            this.rbOtros.TabStop = true;
            this.rbOtros.Text = "Otros";
            this.rbOtros.UseVisualStyleBackColor = true;
            this.rbOtros.CheckedChanged += new System.EventHandler(this.rbOtros_CheckedChanged);
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Location = new System.Drawing.Point(25, 19);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(50, 17);
            this.rbPago.TabIndex = 0;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            this.rbPago.CheckedChanged += new System.EventHandler(this.rbPago_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(104, 593);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(281, 313);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNombreGrupo.LinkColor = System.Drawing.Color.Black;
            this.lblNombreGrupo.Location = new System.Drawing.Point(14, 27);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(105, 16);
            this.lblNombreGrupo.TabIndex = 1;
            this.lblNombreGrupo.TabStop = true;
            this.lblNombreGrupo.Text = "NombreGrupo";
            this.lblNombreGrupo.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblNombreGrupo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNombreGrupo_LinkClicked);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1068, 624);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbMotivoPago);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbInformacionEstudiante);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbUltimosPagos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerFacturas);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion Estudiantil";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabla)).EndInit();
            this.gbUltimosPagos.ResumeLayout(false);
            this.gbInformacionEstudiante.ResumeLayout(false);
            this.gbInformacionEstudiante.PerformLayout();
            this.gbListaGrupal.ResumeLayout(false);
            this.gbListaGrupal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantPagar)).EndInit();
            this.gbMotivoPago.ResumeLayout(false);
            this.gbMotivoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMotivodePago;
        private System.Windows.Forms.TextBox txtMotivodePago;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.LinkLabel lblCargarEstudiante;
        private System.Windows.Forms.TextBox txtUltimoPago;
        private System.Windows.Forms.Label lblUltimoPAgo;
        private System.Windows.Forms.DataGridView dgvtabla;
        private System.Windows.Forms.GroupBox gbUltimosPagos;
        private System.Windows.Forms.Label lblProximoPago;
        private System.Windows.Forms.TextBox txtProximoPAgo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.Label lblTotalaPagar;
        private System.Windows.Forms.Label lblPagoMensual;
        private System.Windows.Forms.GroupBox gbInformacionEstudiante;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbMotivoPago;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantidadaPagar;
        private System.Windows.Forms.TextBox txtCantPagar;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.NumericUpDown nCantPagar;
        private System.Windows.Forms.Label lblCantMesesPagar;
        private System.Windows.Forms.Label lblMesesoSemanas;
        private System.Windows.Forms.ComboBox cbTipodePago;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbListaGrupal;
        private System.Windows.Forms.DataGridView dgvListaGrupo;
        private System.Windows.Forms.LinkLabel lblNombreGrupo;
    }
}
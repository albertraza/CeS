namespace Cely_Sistema
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionDeCobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMoraYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosVIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.gbNiveles = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbEstudiante = new System.Windows.Forms.GroupBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.gbAsistencia = new System.Windows.Forms.GroupBox();
            this.lblEstudiantesRetirados = new System.Windows.Forms.Label();
            this.lblEstudiantesActivos = new System.Windows.Forms.Label();
            this.lblCantidadEstudiantesRegistrados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.verGruposwHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verGruposwHorarioTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerGruposwHorarioTableAdapter();
            this.tContador = new System.Windows.Forms.Timer(this.components);
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            this.tcMenuP = new System.Windows.Forms.TabControl();
            this.tpAsistencia = new System.Windows.Forms.TabPage();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.btnRetirarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbInformacionPagos = new System.Windows.Forms.GroupBox();
            this.btnHacerFactura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProximoPago = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.lblMora = new System.Windows.Forms.Label();
            this.txtPagoMensual = new System.Windows.Forms.TextBox();
            this.lblPagoMensual = new System.Windows.Forms.Label();
            this.lblVIP = new System.Windows.Forms.Label();
            this.lblTipodePago = new System.Windows.Forms.Label();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtMatriculaCon = new System.Windows.Forms.TextBox();
            this.lblMatriculaCon = new System.Windows.Forms.Label();
            this.txtDominiodelIdiomaIngles = new System.Windows.Forms.TextBox();
            this.lblDominioIdiomaIngles = new System.Windows.Forms.Label();
            this.txtNivelAcademico = new System.Windows.Forms.TextBox();
            this.lblNivelAca = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            this.gbNiveles.SuspendLayout();
            this.gbEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.gbAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verGruposwHorarioBindingSource)).BeginInit();
            this.tcMenuP.SuspendLayout();
            this.tpAsistencia.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.gbInformacionPagos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerFacturaToolStripMenuItem,
            this.cancelacionDeCobrosToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.registroDeMoraYCToolStripMenuItem,
            this.ingresosVIPToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.facturasToolStripMenuItem.Text = "Cobros";
            // 
            // hacerFacturaToolStripMenuItem
            // 
            this.hacerFacturaToolStripMenuItem.Name = "hacerFacturaToolStripMenuItem";
            this.hacerFacturaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.hacerFacturaToolStripMenuItem.Text = "Registro de Cobros";
            this.hacerFacturaToolStripMenuItem.Click += new System.EventHandler(this.hacerFacturaToolStripMenuItem_Click);
            // 
            // cancelacionDeCobrosToolStripMenuItem
            // 
            this.cancelacionDeCobrosToolStripMenuItem.Name = "cancelacionDeCobrosToolStripMenuItem";
            this.cancelacionDeCobrosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cancelacionDeCobrosToolStripMenuItem.Text = "Cancelacion de Cobros";
            this.cancelacionDeCobrosToolStripMenuItem.Click += new System.EventHandler(this.cancelacionDeCobrosToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // registroDeMoraYCToolStripMenuItem
            // 
            this.registroDeMoraYCToolStripMenuItem.Name = "registroDeMoraYCToolStripMenuItem";
            this.registroDeMoraYCToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroDeMoraYCToolStripMenuItem.Text = "Registro de Pagos";
            this.registroDeMoraYCToolStripMenuItem.Click += new System.EventHandler(this.registroDeMoraYCToolStripMenuItem_Click);
            // 
            // ingresosVIPToolStripMenuItem
            // 
            this.ingresosVIPToolStripMenuItem.Name = "ingresosVIPToolStripMenuItem";
            this.ingresosVIPToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ingresosVIPToolStripMenuItem.Text = "Ingresos VIP";
            this.ingresosVIPToolStripMenuItem.Click += new System.EventHandler(this.ingresosVIPToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudianteToolStripMenuItem,
            this.buscarEstudianteToolStripMenuItem,
            this.registroDeGruposToolStripMenuItem,
            this.registroDeHorariosToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.registrarEstudianteToolStripMenuItem.Text = "Control de Estudiantes";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstudianteToolStripMenuItem_Click);
            // 
            // buscarEstudianteToolStripMenuItem
            // 
            this.buscarEstudianteToolStripMenuItem.Name = "buscarEstudianteToolStripMenuItem";
            this.buscarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.buscarEstudianteToolStripMenuItem.Text = "Registro de Calificaciones";
            this.buscarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.buscarEstudianteToolStripMenuItem_Click);
            // 
            // registroDeGruposToolStripMenuItem
            // 
            this.registroDeGruposToolStripMenuItem.Name = "registroDeGruposToolStripMenuItem";
            this.registroDeGruposToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.registroDeGruposToolStripMenuItem.Text = "Registro de Grupos y Niveles";
            this.registroDeGruposToolStripMenuItem.Click += new System.EventHandler(this.registroDeGruposToolStripMenuItem_Click);
            // 
            // registroDeHorariosToolStripMenuItem
            // 
            this.registroDeHorariosToolStripMenuItem.Name = "registroDeHorariosToolStripMenuItem";
            this.registroDeHorariosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.registroDeHorariosToolStripMenuItem.Text = "Registro de Horarios";
            this.registroDeHorariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeHorariosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProfesoresToolStripMenuItem,
            this.mantenimientoDeUsuariosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registroDeProfesoresToolStripMenuItem
            // 
            this.registroDeProfesoresToolStripMenuItem.Name = "registroDeProfesoresToolStripMenuItem";
            this.registroDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registroDeProfesoresToolStripMenuItem.Text = "Registro de Profesores";
            this.registroDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProfesoresToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de Usuarios";
            this.mantenimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDelUsuarioToolStripMenuItem,
            this.estudiantesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.calificacionesToolStripMenuItem,
            this.gananciasToolStripMenuItem,
            this.facturasToolStripMenuItem1,
            this.nivelesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ayudaToolStripMenuItem.Text = "Consulta";
            // 
            // manualDelUsuarioToolStripMenuItem
            // 
            this.manualDelUsuarioToolStripMenuItem.Name = "manualDelUsuarioToolStripMenuItem";
            this.manualDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.manualDelUsuarioToolStripMenuItem.Text = "Usuarios";
            this.manualDelUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDelUsuarioToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem1
            // 
            this.estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            this.estudiantesToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.estudiantesToolStripMenuItem1.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem1.Click += new System.EventHandler(this.estudiantesToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.gananciasToolStripMenuItem.Text = "Ganancias";
            this.gananciasToolStripMenuItem.Click += new System.EventHandler(this.gananciasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem1
            // 
            this.facturasToolStripMenuItem1.Name = "facturasToolStripMenuItem1";
            this.facturasToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.facturasToolStripMenuItem1.Text = "Facturas";
            this.facturasToolStripMenuItem1.Click += new System.EventHandler(this.facturasToolStripMenuItem1_Click);
            // 
            // nivelesToolStripMenuItem
            // 
            this.nivelesToolStripMenuItem.Name = "nivelesToolStripMenuItem";
            this.nivelesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nivelesToolStripMenuItem.Text = "Niveles";
            this.nivelesToolStripMenuItem.Click += new System.EventHandler(this.nivelesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gananciasToolStripMenuItem1,
            this.calificacionesToolStripMenuItem1,
            this.facturasToolStripMenuItem2});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.acercaDeToolStripMenuItem.Text = "Reportes";
            // 
            // gananciasToolStripMenuItem1
            // 
            this.gananciasToolStripMenuItem1.Name = "gananciasToolStripMenuItem1";
            this.gananciasToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.gananciasToolStripMenuItem1.Text = "Ganancias";
            // 
            // calificacionesToolStripMenuItem1
            // 
            this.calificacionesToolStripMenuItem1.Enabled = false;
            this.calificacionesToolStripMenuItem1.Name = "calificacionesToolStripMenuItem1";
            this.calificacionesToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.calificacionesToolStripMenuItem1.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem1.Click += new System.EventHandler(this.calificacionesToolStripMenuItem1_Click);
            // 
            // facturasToolStripMenuItem2
            // 
            this.facturasToolStripMenuItem2.Enabled = false;
            this.facturasToolStripMenuItem2.Name = "facturasToolStripMenuItem2";
            this.facturasToolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.facturasToolStripMenuItem2.Text = "Facturas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Location = new System.Drawing.Point(6, 19);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveles.Size = new System.Drawing.Size(439, 193);
            this.dgvNiveles.TabIndex = 2;
            this.dgvNiveles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbNiveles
            // 
            this.gbNiveles.Controls.Add(this.dgvNiveles);
            this.gbNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNiveles.Location = new System.Drawing.Point(6, 25);
            this.gbNiveles.Name = "gbNiveles";
            this.gbNiveles.Size = new System.Drawing.Size(451, 224);
            this.gbNiveles.TabIndex = 3;
            this.gbNiveles.TabStop = false;
            this.gbNiveles.Text = "Niveles";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(18, 256);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(104, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar Nivel";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gbEstudiante
            // 
            this.gbEstudiante.Controls.Add(this.dgvEstudiantes);
            this.gbEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstudiante.Location = new System.Drawing.Point(12, 285);
            this.gbEstudiante.Name = "gbEstudiante";
            this.gbEstudiante.Size = new System.Drawing.Size(445, 161);
            this.gbEstudiante.TabIndex = 5;
            this.gbEstudiante.TabStop = false;
            this.gbEstudiante.Text = "Estudiantes";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(6, 22);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(433, 127);
            this.dgvEstudiantes.TabIndex = 2;
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(570, 239);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarAsistencia.TabIndex = 2;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // gbAsistencia
            // 
            this.gbAsistencia.Controls.Add(this.lblEstudiantesRetirados);
            this.gbAsistencia.Controls.Add(this.lblEstudiantesActivos);
            this.gbAsistencia.Controls.Add(this.lblCantidadEstudiantesRegistrados);
            this.gbAsistencia.Controls.Add(this.pictureBox1);
            this.gbAsistencia.Controls.Add(this.label1);
            this.gbAsistencia.Controls.Add(this.btnBuscarEstudiante);
            this.gbAsistencia.Controls.Add(this.txtMatricula);
            this.gbAsistencia.Controls.Add(this.btnSeleccionar);
            this.gbAsistencia.Controls.Add(this.btnBuscar);
            this.gbAsistencia.Controls.Add(this.gbEstudiante);
            this.gbAsistencia.Controls.Add(this.btnRegistrarAsistencia);
            this.gbAsistencia.Controls.Add(this.gbNiveles);
            this.gbAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsistencia.Location = new System.Drawing.Point(6, 20);
            this.gbAsistencia.Name = "gbAsistencia";
            this.gbAsistencia.Size = new System.Drawing.Size(775, 452);
            this.gbAsistencia.TabIndex = 1;
            this.gbAsistencia.TabStop = false;
            this.gbAsistencia.Text = "Asistencia";
            this.gbAsistencia.Enter += new System.EventHandler(this.gbAsistencia_Enter);
            // 
            // lblEstudiantesRetirados
            // 
            this.lblEstudiantesRetirados.AutoSize = true;
            this.lblEstudiantesRetirados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantesRetirados.Location = new System.Drawing.Point(463, 359);
            this.lblEstudiantesRetirados.Name = "lblEstudiantesRetirados";
            this.lblEstudiantesRetirados.Size = new System.Drawing.Size(231, 16);
            this.lblEstudiantesRetirados.TabIndex = 15;
            this.lblEstudiantesRetirados.Text = "Cantidad Estudiantes Retirados:";
            // 
            // lblEstudiantesActivos
            // 
            this.lblEstudiantesActivos.AutoSize = true;
            this.lblEstudiantesActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantesActivos.Location = new System.Drawing.Point(463, 334);
            this.lblEstudiantesActivos.Name = "lblEstudiantesActivos";
            this.lblEstudiantesActivos.Size = new System.Drawing.Size(214, 16);
            this.lblEstudiantesActivos.TabIndex = 14;
            this.lblEstudiantesActivos.Text = "Cantidad Estudiantes Activos:";
            // 
            // lblCantidadEstudiantesRegistrados
            // 
            this.lblCantidadEstudiantesRegistrados.AutoSize = true;
            this.lblCantidadEstudiantesRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEstudiantesRegistrados.Location = new System.Drawing.Point(463, 307);
            this.lblCantidadEstudiantesRegistrados.Name = "lblCantidadEstudiantesRegistrados";
            this.lblCantidadEstudiantesRegistrados.Size = new System.Drawing.Size(248, 16);
            this.lblCantidadEstudiantesRegistrados.TabIndex = 5;
            this.lblCantidadEstudiantesRegistrados.Text = "Cantidad Estudiantes Registrados:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matricula:";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(145, 256);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarEstudiante.TabIndex = 3;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(570, 190);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(94, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(670, 188);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(7, 544);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // celyDBDataSet
            // 
            this.celyDBDataSet.DataSetName = "CelyDBDataSet";
            this.celyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verGruposwHorarioBindingSource
            // 
            this.verGruposwHorarioBindingSource.DataMember = "VerGruposwHorario";
            this.verGruposwHorarioBindingSource.DataSource = this.celyDBDataSet;
            // 
            // verGruposwHorarioTableAdapter
            // 
            this.verGruposwHorarioTableAdapter.ClearBeforeFill = true;
            // 
            // tContador
            // 
            this.tContador.Interval = 60000;
            this.tContador.Tick += new System.EventHandler(this.tContador_Tick);
            // 
            // tReloj
            // 
            this.tReloj.Interval = 1000;
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // tcMenuP
            // 
            this.tcMenuP.Controls.Add(this.tpAsistencia);
            this.tcMenuP.Controls.Add(this.tbConsulta);
            this.tcMenuP.Location = new System.Drawing.Point(0, 27);
            this.tcMenuP.Name = "tcMenuP";
            this.tcMenuP.SelectedIndex = 0;
            this.tcMenuP.Size = new System.Drawing.Size(816, 518);
            this.tcMenuP.TabIndex = 2;
            // 
            // tpAsistencia
            // 
            this.tpAsistencia.Controls.Add(this.gbAsistencia);
            this.tpAsistencia.Location = new System.Drawing.Point(4, 22);
            this.tpAsistencia.Name = "tpAsistencia";
            this.tpAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsistencia.Size = new System.Drawing.Size(808, 492);
            this.tpAsistencia.TabIndex = 0;
            this.tpAsistencia.Text = "Asistencia";
            this.tpAsistencia.UseVisualStyleBackColor = true;
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.btnRetirarEstudiante);
            this.tbConsulta.Controls.Add(this.btnEliminar);
            this.tbConsulta.Controls.Add(this.btnModificar);
            this.tbConsulta.Controls.Add(this.gbInformacionPagos);
            this.tbConsulta.Controls.Add(this.gbDatosPersonales);
            this.tbConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(808, 492);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRetirarEstudiante
            // 
            this.btnRetirarEstudiante.Location = new System.Drawing.Point(318, 423);
            this.btnRetirarEstudiante.Name = "btnRetirarEstudiante";
            this.btnRetirarEstudiante.Size = new System.Drawing.Size(124, 23);
            this.btnRetirarEstudiante.TabIndex = 10;
            this.btnRetirarEstudiante.Text = "Retirar Estudiante";
            this.btnRetirarEstudiante.UseVisualStyleBackColor = true;
            this.btnRetirarEstudiante.Click += new System.EventHandler(this.btnRetirarEstudiante_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(183, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(46, 423);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbInformacionPagos
            // 
            this.gbInformacionPagos.Controls.Add(this.btnHacerFactura);
            this.gbInformacionPagos.Controls.Add(this.groupBox1);
            this.gbInformacionPagos.Controls.Add(this.txtMora);
            this.gbInformacionPagos.Controls.Add(this.lblMora);
            this.gbInformacionPagos.Controls.Add(this.txtPagoMensual);
            this.gbInformacionPagos.Controls.Add(this.lblPagoMensual);
            this.gbInformacionPagos.Controls.Add(this.lblVIP);
            this.gbInformacionPagos.Controls.Add(this.lblTipodePago);
            this.gbInformacionPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionPagos.Location = new System.Drawing.Point(497, 17);
            this.gbInformacionPagos.Name = "gbInformacionPagos";
            this.gbInformacionPagos.Size = new System.Drawing.Size(300, 383);
            this.gbInformacionPagos.TabIndex = 1;
            this.gbInformacionPagos.TabStop = false;
            this.gbInformacionPagos.Text = "Informacion pagos";
            // 
            // btnHacerFactura
            // 
            this.btnHacerFactura.Location = new System.Drawing.Point(95, 304);
            this.btnHacerFactura.Name = "btnHacerFactura";
            this.btnHacerFactura.Size = new System.Drawing.Size(114, 58);
            this.btnHacerFactura.TabIndex = 7;
            this.btnHacerFactura.Text = "Hacer Factura";
            this.btnHacerFactura.UseVisualStyleBackColor = true;
            this.btnHacerFactura.Click += new System.EventHandler(this.btnHacerFactura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProximoPago);
            this.groupBox1.Controls.Add(this.lblTotalPagar);
            this.groupBox1.Controls.Add(this.lblPendientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus del Estudiante";
            // 
            // lblProximoPago
            // 
            this.lblProximoPago.AutoSize = true;
            this.lblProximoPago.Location = new System.Drawing.Point(7, 46);
            this.lblProximoPago.Name = "lblProximoPago";
            this.lblProximoPago.Size = new System.Drawing.Size(88, 13);
            this.lblProximoPago.TabIndex = 3;
            this.lblProximoPago.Text = "Proximo Pago:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(7, 116);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(73, 13);
            this.lblTotalPagar.TabIndex = 2;
            this.lblTotalPagar.Text = "Total Pagar";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(7, 84);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(70, 13);
            this.lblPendientes.TabIndex = 1;
            this.lblPendientes.Text = "Pendientes";
            // 
            // txtMora
            // 
            this.txtMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMora.Location = new System.Drawing.Point(215, 80);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(60, 20);
            this.txtMora.TabIndex = 5;
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.Location = new System.Drawing.Point(175, 83);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(34, 13);
            this.lblMora.TabIndex = 4;
            this.lblMora.Text = "Mora:";
            // 
            // txtPagoMensual
            // 
            this.txtPagoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoMensual.Location = new System.Drawing.Point(100, 80);
            this.txtPagoMensual.Name = "txtPagoMensual";
            this.txtPagoMensual.Size = new System.Drawing.Size(60, 20);
            this.txtPagoMensual.TabIndex = 3;
            // 
            // lblPagoMensual
            // 
            this.lblPagoMensual.AutoSize = true;
            this.lblPagoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoMensual.Location = new System.Drawing.Point(16, 83);
            this.lblPagoMensual.Name = "lblPagoMensual";
            this.lblPagoMensual.Size = new System.Drawing.Size(78, 13);
            this.lblPagoMensual.TabIndex = 2;
            this.lblPagoMensual.Text = "Pago Mensual:";
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIP.Location = new System.Drawing.Point(164, 38);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(31, 13);
            this.lblVIP.TabIndex = 1;
            this.lblVIP.Text = "VIP:";
            // 
            // lblTipodePago
            // 
            this.lblTipodePago.AutoSize = true;
            this.lblTipodePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodePago.Location = new System.Drawing.Point(20, 38);
            this.lblTipodePago.Name = "lblTipodePago";
            this.lblTipodePago.Size = new System.Drawing.Size(74, 13);
            this.lblTipodePago.TabIndex = 0;
            this.lblTipodePago.Text = "Tipo de Pago:";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.btnLimpiar);
            this.gbDatosPersonales.Controls.Add(this.lblBuscar);
            this.gbDatosPersonales.Controls.Add(this.txtNivel);
            this.gbDatosPersonales.Controls.Add(this.lblnivel);
            this.gbDatosPersonales.Controls.Add(this.txtFechaRegistro);
            this.gbDatosPersonales.Controls.Add(this.lblFechaRegistro);
            this.gbDatosPersonales.Controls.Add(this.txtMatriculaCon);
            this.gbDatosPersonales.Controls.Add(this.lblMatriculaCon);
            this.gbDatosPersonales.Controls.Add(this.txtDominiodelIdiomaIngles);
            this.gbDatosPersonales.Controls.Add(this.lblDominioIdiomaIngles);
            this.gbDatosPersonales.Controls.Add(this.txtNivelAcademico);
            this.gbDatosPersonales.Controls.Add(this.lblNivelAca);
            this.gbDatosPersonales.Controls.Add(this.txtOcupacion);
            this.gbDatosPersonales.Controls.Add(this.lblOcupacion);
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.lblDireccion);
            this.gbDatosPersonales.Controls.Add(this.txtSector);
            this.gbDatosPersonales.Controls.Add(this.lblSector);
            this.gbDatosPersonales.Controls.Add(this.txtEmail);
            this.gbDatosPersonales.Controls.Add(this.lblEmail);
            this.gbDatosPersonales.Controls.Add(this.txtCelular);
            this.gbDatosPersonales.Controls.Add(this.lblCelular);
            this.gbDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.txtEdad);
            this.gbDatosPersonales.Controls.Add(this.lblEdad);
            this.gbDatosPersonales.Controls.Add(this.txtFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.txtApellido);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(18, 17);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(453, 383);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(280, 35);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(177, 41);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 13);
            this.lblBuscar.TabIndex = 30;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // txtNivel
            // 
            this.txtNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(74, 80);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(97, 20);
            this.txtNivel.TabIndex = 29;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnivel.Location = new System.Drawing.Point(21, 83);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(34, 13);
            this.lblnivel.TabIndex = 28;
            this.lblnivel.Text = "Nivel:";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.Location = new System.Drawing.Point(280, 77);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(142, 20);
            this.txtFechaRegistro.TabIndex = 27;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(192, 80);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(82, 13);
            this.lblFechaRegistro.TabIndex = 26;
            this.lblFechaRegistro.Text = "Fecha Registro:";
            // 
            // txtMatriculaCon
            // 
            this.txtMatriculaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculaCon.Location = new System.Drawing.Point(74, 38);
            this.txtMatriculaCon.Name = "txtMatriculaCon";
            this.txtMatriculaCon.Size = new System.Drawing.Size(97, 20);
            this.txtMatriculaCon.TabIndex = 25;
            this.txtMatriculaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriculaCon_KeyPress);
            // 
            // lblMatriculaCon
            // 
            this.lblMatriculaCon.AutoSize = true;
            this.lblMatriculaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculaCon.Location = new System.Drawing.Point(15, 41);
            this.lblMatriculaCon.Name = "lblMatriculaCon";
            this.lblMatriculaCon.Size = new System.Drawing.Size(53, 13);
            this.lblMatriculaCon.TabIndex = 24;
            this.lblMatriculaCon.Text = "Matricula:";
            // 
            // txtDominiodelIdiomaIngles
            // 
            this.txtDominiodelIdiomaIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDominiodelIdiomaIngles.Location = new System.Drawing.Point(361, 342);
            this.txtDominiodelIdiomaIngles.Name = "txtDominiodelIdiomaIngles";
            this.txtDominiodelIdiomaIngles.Size = new System.Drawing.Size(66, 20);
            this.txtDominiodelIdiomaIngles.TabIndex = 23;
            // 
            // lblDominioIdiomaIngles
            // 
            this.lblDominioIdiomaIngles.AutoSize = true;
            this.lblDominioIdiomaIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominioIdiomaIngles.Location = new System.Drawing.Point(225, 345);
            this.lblDominioIdiomaIngles.Name = "lblDominioIdiomaIngles";
            this.lblDominioIdiomaIngles.Size = new System.Drawing.Size(130, 13);
            this.lblDominioIdiomaIngles.TabIndex = 22;
            this.lblDominioIdiomaIngles.Text = "Dominio del Idioma Ingles:";
            // 
            // txtNivelAcademico
            // 
            this.txtNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelAcademico.Location = new System.Drawing.Point(122, 342);
            this.txtNivelAcademico.Name = "txtNivelAcademico";
            this.txtNivelAcademico.Size = new System.Drawing.Size(88, 20);
            this.txtNivelAcademico.TabIndex = 21;
            // 
            // lblNivelAca
            // 
            this.lblNivelAca.AutoSize = true;
            this.lblNivelAca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAca.Location = new System.Drawing.Point(26, 345);
            this.lblNivelAca.Name = "lblNivelAca";
            this.lblNivelAca.Size = new System.Drawing.Size(90, 13);
            this.lblNivelAca.TabIndex = 20;
            this.lblNivelAca.Text = "Nivel Academico:";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.Location = new System.Drawing.Point(297, 299);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(125, 20);
            this.txtOcupacion.TabIndex = 19;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.Location = new System.Drawing.Point(227, 302);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(62, 13);
            this.lblOcupacion.TabIndex = 18;
            this.lblOcupacion.Text = "Ocupacion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(79, 299);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(131, 20);
            this.txtDireccion.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(21, 302);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(280, 251);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(142, 20);
            this.txtSector.TabIndex = 15;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(227, 254);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 14;
            this.lblSector.Text = "Sector:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(74, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 254);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(280, 208);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(142, 20);
            this.txtCelular.TabIndex = 11;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(227, 211);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(79, 208);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(21, 211);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(280, 163);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(142, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(227, 166);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(138, 163);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(72, 20);
            this.txtFechaNacimiento.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(21, 166);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(280, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(142, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(227, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(74, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 557);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tcMenuP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CELI SISTEMA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            this.gbNiveles.ResumeLayout(false);
            this.gbEstudiante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.gbAsistencia.ResumeLayout(false);
            this.gbAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verGruposwHorarioBindingSource)).EndInit();
            this.tcMenuP.ResumeLayout(false);
            this.tpAsistencia.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.gbInformacionPagos.ResumeLayout(false);
            this.gbInformacionPagos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelacionDeCobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.GroupBox gbNiveles;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox gbEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.GroupBox gbAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMoraYCToolStripMenuItem;
        private CelyDBDataSet celyDBDataSet;
        private System.Windows.Forms.BindingSource verGruposwHorarioBindingSource;
        private CelyDBDataSetTableAdapters.VerGruposwHorarioTableAdapter verGruposwHorarioTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem ingresosVIPToolStripMenuItem;
        private System.Windows.Forms.Timer tContador;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tReloj;
        private System.Windows.Forms.TabControl tcMenuP;
        private System.Windows.Forms.TabPage tpAsistencia;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbInformacionPagos;
        private System.Windows.Forms.Button btnHacerFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.TextBox txtPagoMensual;
        private System.Windows.Forms.Label lblPagoMensual;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.Label lblTipodePago;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtMatriculaCon;
        private System.Windows.Forms.Label lblMatriculaCon;
        private System.Windows.Forms.TextBox txtDominiodelIdiomaIngles;
        private System.Windows.Forms.Label lblDominioIdiomaIngles;
        private System.Windows.Forms.TextBox txtNivelAcademico;
        private System.Windows.Forms.Label lblNivelAca;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProximoPago;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantidadEstudiantesRegistrados;
        private System.Windows.Forms.Button btnRetirarEstudiante;
        private System.Windows.Forms.Label lblEstudiantesRetirados;
        private System.Windows.Forms.Label lblEstudiantesActivos;
    }
}
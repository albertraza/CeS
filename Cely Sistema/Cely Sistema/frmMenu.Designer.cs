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
            this.estudiantesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAcercaDe = new System.Windows.Forms.LinkLabel();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.gbNiveles = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbEstudiante = new System.Windows.Forms.GroupBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.gbAsistencia = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.verGruposwHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verGruposwHorarioTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerGruposwHorarioTableAdapter();
            this.tContador = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            this.gbNiveles.SuspendLayout();
            this.gbEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.gbAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verGruposwHorarioBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
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
            this.estudiantesToolStripMenuItem2,
            this.calificacionesToolStripMenuItem1,
            this.empleadosToolStripMenuItem2,
            this.facturasToolStripMenuItem2});
            this.acercaDeToolStripMenuItem.Enabled = false;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.acercaDeToolStripMenuItem.Text = "Reportes";
            // 
            // gananciasToolStripMenuItem1
            // 
            this.gananciasToolStripMenuItem1.Name = "gananciasToolStripMenuItem1";
            this.gananciasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.gananciasToolStripMenuItem1.Text = "Ganancias";
            // 
            // estudiantesToolStripMenuItem2
            // 
            this.estudiantesToolStripMenuItem2.Name = "estudiantesToolStripMenuItem2";
            this.estudiantesToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.estudiantesToolStripMenuItem2.Text = "Estudiantes";
            // 
            // calificacionesToolStripMenuItem1
            // 
            this.calificacionesToolStripMenuItem1.Name = "calificacionesToolStripMenuItem1";
            this.calificacionesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.calificacionesToolStripMenuItem1.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem1.Click += new System.EventHandler(this.calificacionesToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem2
            // 
            this.empleadosToolStripMenuItem2.Name = "empleadosToolStripMenuItem2";
            this.empleadosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem2.Text = "Empleados";
            // 
            // facturasToolStripMenuItem2
            // 
            this.facturasToolStripMenuItem2.Name = "facturasToolStripMenuItem2";
            this.facturasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
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
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Location = new System.Drawing.Point(954, 425);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(56, 13);
            this.lblAcercaDe.TabIndex = 1;
            this.lblAcercaDe.TabStop = true;
            this.lblAcercaDe.Text = "Acerca de";
            this.lblAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAcercaDe_LinkClicked);
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Location = new System.Drawing.Point(6, 19);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.Size = new System.Drawing.Size(439, 255);
            this.dgvNiveles.TabIndex = 2;
            this.dgvNiveles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbNiveles
            // 
            this.gbNiveles.Controls.Add(this.dgvNiveles);
            this.gbNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNiveles.Location = new System.Drawing.Point(6, 25);
            this.gbNiveles.Name = "gbNiveles";
            this.gbNiveles.Size = new System.Drawing.Size(451, 283);
            this.gbNiveles.TabIndex = 3;
            this.gbNiveles.TabStop = false;
            this.gbNiveles.Text = "Niveles";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(24, 375);
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
            this.gbEstudiante.Location = new System.Drawing.Point(473, 119);
            this.gbEstudiante.Name = "gbEstudiante";
            this.gbEstudiante.Size = new System.Drawing.Size(577, 189);
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
            this.dgvEstudiantes.Size = new System.Drawing.Size(565, 161);
            this.dgvEstudiantes.TabIndex = 2;
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(569, 90);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarAsistencia.TabIndex = 2;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // gbAsistencia
            // 
            this.gbAsistencia.Controls.Add(this.pictureBox1);
            this.gbAsistencia.Controls.Add(this.label1);
            this.gbAsistencia.Controls.Add(this.txtMatricula);
            this.gbAsistencia.Controls.Add(this.btnBuscar);
            this.gbAsistencia.Controls.Add(this.gbEstudiante);
            this.gbAsistencia.Controls.Add(this.btnRegistrarAsistencia);
            this.gbAsistencia.Controls.Add(this.gbNiveles);
            this.gbAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsistencia.Location = new System.Drawing.Point(12, 55);
            this.gbAsistencia.Name = "gbAsistencia";
            this.gbAsistencia.Size = new System.Drawing.Size(1056, 314);
            this.gbAsistencia.TabIndex = 1;
            this.gbAsistencia.TabStop = false;
            this.gbAsistencia.Text = "Asistencia";
            this.gbAsistencia.Enter += new System.EventHandler(this.gbAsistencia_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 25);
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
            this.label1.Location = new System.Drawing.Point(510, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(569, 41);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(94, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(669, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(160, 375);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarEstudiante.TabIndex = 3;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
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
            this.tContador.Interval = 5000;
            this.tContador.Tick += new System.EventHandler(this.tContador_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(831, 396);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // tReloj
            // 
            this.tReloj.Interval = 1000;
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 418);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gbAsistencia);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblAcercaDe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CELY SISTEMA";
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
        private System.Windows.Forms.LinkLabel lblAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem buscarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem2;
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
    }
}
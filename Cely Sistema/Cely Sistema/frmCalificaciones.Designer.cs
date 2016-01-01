namespace Cely_Sistema
{
    partial class frmCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalificaciones));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblBuscarCalificacion = new System.Windows.Forms.LinkLabel();
            this.gbInformacionEstudiante = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargraEstudiante = new System.Windows.Forms.Button();
            this.dgvUltimasCalificaciones = new System.Windows.Forms.DataGridView();
            this.lblPrimerParcial = new System.Windows.Forms.Label();
            this.txtPrimerPalcial = new System.Windows.Forms.TextBox();
            this.gbRegistroCalificaciones = new System.Windows.Forms.GroupBox();
            this.lblFechaParcial = new System.Windows.Forms.Label();
            this.dtpFechaParcial = new System.Windows.Forms.DateTimePicker();
            this.txtTercerParcial = new System.Windows.Forms.TextBox();
            this.lblTercerParcial = new System.Windows.Forms.Label();
            this.txtSegundoParcial = new System.Windows.Forms.TextBox();
            this.lblSegundoParcial = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargarCalificacion = new System.Windows.Forms.Button();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.gbNotasaRegistrar = new System.Windows.Forms.GroupBox();
            this.rbExposicion = new System.Windows.Forms.RadioButton();
            this.rbExamenLectura = new System.Windows.Forms.RadioButton();
            this.rbExamenOral = new System.Windows.Forms.RadioButton();
            this.rbExamenEscrito = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcularAsitencia = new System.Windows.Forms.Button();
            this.gbInfomacionAsistencia = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnRegistrarNotaAsistencia = new System.Windows.Forms.Button();
            this.txtNotaAsistencia = new System.Windows.Forms.TextBox();
            this.lblNotaAsistencia = new System.Windows.Forms.Label();
            this.txtTotalDias = new System.Windows.Forms.TextBox();
            this.lblDiasTotal = new System.Windows.Forms.Label();
            this.txtDiasAsistidos = new System.Windows.Forms.TextBox();
            this.dgvNotaAsistencia = new System.Windows.Forms.DataGridView();
            this.lblDiasAsistidos = new System.Windows.Forms.Label();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.notaAsistenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasExamenEscritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasExamenEscritoTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.NotasExamenEscritoTableAdapter();
            this.asistenciaTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.AsistenciaTableAdapter();
            this.notaAsistenciaTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.NotaAsistenciaTableAdapter();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbInformacionEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCalificaciones)).BeginInit();
            this.gbRegistroCalificaciones.SuspendLayout();
            this.gbNotas.SuspendLayout();
            this.gbNotasaRegistrar.SuspendLayout();
            this.gbInfomacionAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaAsistenciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaAsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasExamenEscritoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(22, 31);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(81, 28);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // lblBuscarCalificacion
            // 
            this.lblBuscarCalificacion.AutoSize = true;
            this.lblBuscarCalificacion.Location = new System.Drawing.Point(377, 504);
            this.lblBuscarCalificacion.Name = "lblBuscarCalificacion";
            this.lblBuscarCalificacion.Size = new System.Drawing.Size(97, 13);
            this.lblBuscarCalificacion.TabIndex = 7;
            this.lblBuscarCalificacion.TabStop = true;
            this.lblBuscarCalificacion.Text = "Buscar Calificacion";
            this.lblBuscarCalificacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarCalificacion_LinkClicked);
            // 
            // gbInformacionEstudiante
            // 
            this.gbInformacionEstudiante.Controls.Add(this.lblApellido);
            this.gbInformacionEstudiante.Controls.Add(this.txtApellido);
            this.gbInformacionEstudiante.Controls.Add(this.lblNombre);
            this.gbInformacionEstudiante.Controls.Add(this.txtNombre);
            this.gbInformacionEstudiante.Controls.Add(this.lblMatricula);
            this.gbInformacionEstudiante.Controls.Add(this.txtMatricula);
            this.gbInformacionEstudiante.Controls.Add(this.btnCargraEstudiante);
            this.gbInformacionEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionEstudiante.Location = new System.Drawing.Point(19, 51);
            this.gbInformacionEstudiante.Name = "gbInformacionEstudiante";
            this.gbInformacionEstudiante.Size = new System.Drawing.Size(247, 153);
            this.gbInformacionEstudiante.TabIndex = 0;
            this.gbInformacionEstudiante.TabStop = false;
            this.gbInformacionEstudiante.Text = "Informacion del Estudiante";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(28, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(81, 91);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(81, 60);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnCargraEstudiante
            // 
            this.btnCargraEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargraEstudiante.Location = new System.Drawing.Point(98, 124);
            this.btnCargraEstudiante.Name = "btnCargraEstudiante";
            this.btnCargraEstudiante.Size = new System.Drawing.Size(69, 23);
            this.btnCargraEstudiante.TabIndex = 1;
            this.btnCargraEstudiante.Text = "Buscar";
            this.btnCargraEstudiante.UseVisualStyleBackColor = true;
            this.btnCargraEstudiante.Click += new System.EventHandler(this.btnCargraEstudiante_Click);
            // 
            // dgvUltimasCalificaciones
            // 
            this.dgvUltimasCalificaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUltimasCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimasCalificaciones.Location = new System.Drawing.Point(6, 16);
            this.dgvUltimasCalificaciones.Name = "dgvUltimasCalificaciones";
            this.dgvUltimasCalificaciones.Size = new System.Drawing.Size(843, 209);
            this.dgvUltimasCalificaciones.TabIndex = 7;
            // 
            // lblPrimerParcial
            // 
            this.lblPrimerParcial.AutoSize = true;
            this.lblPrimerParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerParcial.Location = new System.Drawing.Point(38, 53);
            this.lblPrimerParcial.Name = "lblPrimerParcial";
            this.lblPrimerParcial.Size = new System.Drawing.Size(74, 13);
            this.lblPrimerParcial.TabIndex = 5;
            this.lblPrimerParcial.Text = "Primer Parcial:";
            // 
            // txtPrimerPalcial
            // 
            this.txtPrimerPalcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerPalcial.Location = new System.Drawing.Point(118, 50);
            this.txtPrimerPalcial.MaxLength = 3;
            this.txtPrimerPalcial.Name = "txtPrimerPalcial";
            this.txtPrimerPalcial.Size = new System.Drawing.Size(37, 20);
            this.txtPrimerPalcial.TabIndex = 0;
            this.txtPrimerPalcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerPalcial_KeyPress);
            // 
            // gbRegistroCalificaciones
            // 
            this.gbRegistroCalificaciones.Controls.Add(this.lblFechaParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.dtpFechaParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.txtTercerParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.lblTercerParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.txtSegundoParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.lblSegundoParcial);
            this.gbRegistroCalificaciones.Controls.Add(this.txtPrimerPalcial);
            this.gbRegistroCalificaciones.Controls.Add(this.lblPrimerParcial);
            this.gbRegistroCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroCalificaciones.Location = new System.Drawing.Point(12, 270);
            this.gbRegistroCalificaciones.Name = "gbRegistroCalificaciones";
            this.gbRegistroCalificaciones.Size = new System.Drawing.Size(435, 166);
            this.gbRegistroCalificaciones.TabIndex = 0;
            this.gbRegistroCalificaciones.TabStop = false;
            this.gbRegistroCalificaciones.Text = "Registro de Calificaciones";
            // 
            // lblFechaParcial
            // 
            this.lblFechaParcial.AutoSize = true;
            this.lblFechaParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaParcial.Location = new System.Drawing.Point(260, 57);
            this.lblFechaParcial.Name = "lblFechaParcial";
            this.lblFechaParcial.Size = new System.Drawing.Size(72, 13);
            this.lblFechaParcial.TabIndex = 14;
            this.lblFechaParcial.Text = "Fecha Parcial";
            // 
            // dtpFechaParcial
            // 
            this.dtpFechaParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaParcial.Location = new System.Drawing.Point(211, 84);
            this.dtpFechaParcial.Name = "dtpFechaParcial";
            this.dtpFechaParcial.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaParcial.TabIndex = 3;
            this.dtpFechaParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaParcial_KeyPress);
            // 
            // txtTercerParcial
            // 
            this.txtTercerParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTercerParcial.Location = new System.Drawing.Point(118, 119);
            this.txtTercerParcial.MaxLength = 3;
            this.txtTercerParcial.Name = "txtTercerParcial";
            this.txtTercerParcial.Size = new System.Drawing.Size(37, 20);
            this.txtTercerParcial.TabIndex = 2;
            this.txtTercerParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTercerParcial_KeyPress);
            // 
            // lblTercerParcial
            // 
            this.lblTercerParcial.AutoSize = true;
            this.lblTercerParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTercerParcial.Location = new System.Drawing.Point(38, 122);
            this.lblTercerParcial.Name = "lblTercerParcial";
            this.lblTercerParcial.Size = new System.Drawing.Size(76, 13);
            this.lblTercerParcial.TabIndex = 9;
            this.lblTercerParcial.Text = "Tercer Parcial:";
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoParcial.Location = new System.Drawing.Point(118, 83);
            this.txtSegundoParcial.MaxLength = 3;
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(37, 20);
            this.txtSegundoParcial.TabIndex = 1;
            this.txtSegundoParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoParcial_KeyPress);
            // 
            // lblSegundoParcial
            // 
            this.lblSegundoParcial.AutoSize = true;
            this.lblSegundoParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoParcial.Location = new System.Drawing.Point(27, 86);
            this.lblSegundoParcial.Name = "lblSegundoParcial";
            this.lblSegundoParcial.Size = new System.Drawing.Size(88, 13);
            this.lblSegundoParcial.TabIndex = 7;
            this.lblSegundoParcial.Text = "Segundo Parcial:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(101, 494);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 494);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(286, 494);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargarCalificacion
            // 
            this.btnCargarCalificacion.Location = new System.Drawing.Point(497, 260);
            this.btnCargarCalificacion.Name = "btnCargarCalificacion";
            this.btnCargarCalificacion.Size = new System.Drawing.Size(146, 23);
            this.btnCargarCalificacion.TabIndex = 5;
            this.btnCargarCalificacion.Text = "Seleccionar Calificacion";
            this.btnCargarCalificacion.UseVisualStyleBackColor = true;
            this.btnCargarCalificacion.Click += new System.EventHandler(this.btnCargarCalificacion_Click);
            // 
            // gbNotas
            // 
            this.gbNotas.Controls.Add(this.dgvUltimasCalificaciones);
            this.gbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotas.Location = new System.Drawing.Point(482, 12);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(856, 243);
            this.gbNotas.TabIndex = 6;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Notas";
            // 
            // gbNotasaRegistrar
            // 
            this.gbNotasaRegistrar.Controls.Add(this.rbExposicion);
            this.gbNotasaRegistrar.Controls.Add(this.rbExamenLectura);
            this.gbNotasaRegistrar.Controls.Add(this.rbExamenOral);
            this.gbNotasaRegistrar.Controls.Add(this.rbExamenEscrito);
            this.gbNotasaRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotasaRegistrar.Location = new System.Drawing.Point(12, 210);
            this.gbNotasaRegistrar.Name = "gbNotasaRegistrar";
            this.gbNotasaRegistrar.Size = new System.Drawing.Size(435, 54);
            this.gbNotasaRegistrar.TabIndex = 10;
            this.gbNotasaRegistrar.TabStop = false;
            this.gbNotasaRegistrar.Text = "Notas";
            // 
            // rbExposicion
            // 
            this.rbExposicion.AutoSize = true;
            this.rbExposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExposicion.Location = new System.Drawing.Point(325, 19);
            this.rbExposicion.Name = "rbExposicion";
            this.rbExposicion.Size = new System.Drawing.Size(76, 17);
            this.rbExposicion.TabIndex = 3;
            this.rbExposicion.TabStop = true;
            this.rbExposicion.Text = "Exposicion";
            this.rbExposicion.UseVisualStyleBackColor = true;
            this.rbExposicion.CheckedChanged += new System.EventHandler(this.rbExposicion_CheckedChanged);
            // 
            // rbExamenLectura
            // 
            this.rbExamenLectura.AutoSize = true;
            this.rbExamenLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamenLectura.Location = new System.Drawing.Point(220, 19);
            this.rbExamenLectura.Name = "rbExamenLectura";
            this.rbExamenLectura.Size = new System.Drawing.Size(102, 17);
            this.rbExamenLectura.TabIndex = 2;
            this.rbExamenLectura.TabStop = true;
            this.rbExamenLectura.Text = "Examen Lectura";
            this.rbExamenLectura.UseVisualStyleBackColor = true;
            this.rbExamenLectura.CheckedChanged += new System.EventHandler(this.rbExamenLectura_CheckedChanged);
            // 
            // rbExamenOral
            // 
            this.rbExamenOral.AutoSize = true;
            this.rbExamenOral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamenOral.Location = new System.Drawing.Point(129, 19);
            this.rbExamenOral.Name = "rbExamenOral";
            this.rbExamenOral.Size = new System.Drawing.Size(85, 17);
            this.rbExamenOral.TabIndex = 1;
            this.rbExamenOral.TabStop = true;
            this.rbExamenOral.Text = "Examen Oral";
            this.rbExamenOral.UseVisualStyleBackColor = true;
            this.rbExamenOral.CheckedChanged += new System.EventHandler(this.rbExamenOral_CheckedChanged);
            // 
            // rbExamenEscrito
            // 
            this.rbExamenEscrito.AutoSize = true;
            this.rbExamenEscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamenEscrito.Location = new System.Drawing.Point(22, 19);
            this.rbExamenEscrito.Name = "rbExamenEscrito";
            this.rbExamenEscrito.Size = new System.Drawing.Size(98, 17);
            this.rbExamenEscrito.TabIndex = 0;
            this.rbExamenEscrito.TabStop = true;
            this.rbExamenEscrito.Text = "Examen Escrito";
            this.rbExamenEscrito.UseVisualStyleBackColor = true;
            this.rbExamenEscrito.CheckedChanged += new System.EventHandler(this.rbExamenEscrito_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(126, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Registro de Calificaciones";
            // 
            // btnCalcularAsitencia
            // 
            this.btnCalcularAsitencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularAsitencia.Location = new System.Drawing.Point(543, 173);
            this.btnCalcularAsitencia.Name = "btnCalcularAsitencia";
            this.btnCalcularAsitencia.Size = new System.Drawing.Size(126, 23);
            this.btnCalcularAsitencia.TabIndex = 4;
            this.btnCalcularAsitencia.Text = "Calcular Asistencia";
            this.btnCalcularAsitencia.UseVisualStyleBackColor = true;
            this.btnCalcularAsitencia.Click += new System.EventHandler(this.btnCalcularAsitencia_Click);
            // 
            // gbInfomacionAsistencia
            // 
            this.gbInfomacionAsistencia.Controls.Add(this.btnSeleccionar);
            this.gbInfomacionAsistencia.Controls.Add(this.btnRegistrarNotaAsistencia);
            this.gbInfomacionAsistencia.Controls.Add(this.txtNotaAsistencia);
            this.gbInfomacionAsistencia.Controls.Add(this.lblNotaAsistencia);
            this.gbInfomacionAsistencia.Controls.Add(this.txtTotalDias);
            this.gbInfomacionAsistencia.Controls.Add(this.lblDiasTotal);
            this.gbInfomacionAsistencia.Controls.Add(this.txtDiasAsistidos);
            this.gbInfomacionAsistencia.Controls.Add(this.dgvNotaAsistencia);
            this.gbInfomacionAsistencia.Controls.Add(this.lblDiasAsistidos);
            this.gbInfomacionAsistencia.Controls.Add(this.dgvAsistencia);
            this.gbInfomacionAsistencia.Controls.Add(this.btnCalcularAsitencia);
            this.gbInfomacionAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfomacionAsistencia.Location = new System.Drawing.Point(482, 289);
            this.gbInfomacionAsistencia.Name = "gbInfomacionAsistencia";
            this.gbInfomacionAsistencia.Size = new System.Drawing.Size(682, 243);
            this.gbInfomacionAsistencia.TabIndex = 13;
            this.gbInfomacionAsistencia.TabStop = false;
            this.gbInfomacionAsistencia.Text = "Informacion Asistencia";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(543, 131);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(126, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnRegistrarNotaAsistencia
            // 
            this.btnRegistrarNotaAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNotaAsistencia.Location = new System.Drawing.Point(527, 214);
            this.btnRegistrarNotaAsistencia.Name = "btnRegistrarNotaAsistencia";
            this.btnRegistrarNotaAsistencia.Size = new System.Drawing.Size(142, 23);
            this.btnRegistrarNotaAsistencia.TabIndex = 5;
            this.btnRegistrarNotaAsistencia.Text = "Registrar Nota Asistencia";
            this.btnRegistrarNotaAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarNotaAsistencia.Click += new System.EventHandler(this.btnRegistrarNotaAsistencia_Click);
            // 
            // txtNotaAsistencia
            // 
            this.txtNotaAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaAsistencia.Location = new System.Drawing.Point(475, 192);
            this.txtNotaAsistencia.Name = "txtNotaAsistencia";
            this.txtNotaAsistencia.Size = new System.Drawing.Size(53, 20);
            this.txtNotaAsistencia.TabIndex = 2;
            // 
            // lblNotaAsistencia
            // 
            this.lblNotaAsistencia.AutoSize = true;
            this.lblNotaAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaAsistencia.Location = new System.Drawing.Point(394, 195);
            this.lblNotaAsistencia.Name = "lblNotaAsistencia";
            this.lblNotaAsistencia.Size = new System.Drawing.Size(84, 13);
            this.lblNotaAsistencia.TabIndex = 19;
            this.lblNotaAsistencia.Text = "Nota Asistencia:";
            // 
            // txtTotalDias
            // 
            this.txtTotalDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDias.Location = new System.Drawing.Point(475, 159);
            this.txtTotalDias.Name = "txtTotalDias";
            this.txtTotalDias.Size = new System.Drawing.Size(53, 20);
            this.txtTotalDias.TabIndex = 1;
            this.txtTotalDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDias_KeyPress);
            // 
            // lblDiasTotal
            // 
            this.lblDiasTotal.AutoSize = true;
            this.lblDiasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasTotal.Location = new System.Drawing.Point(394, 164);
            this.lblDiasTotal.Name = "lblDiasTotal";
            this.lblDiasTotal.Size = new System.Drawing.Size(73, 13);
            this.lblDiasTotal.TabIndex = 17;
            this.lblDiasTotal.Text = "Total de Dias:";
            // 
            // txtDiasAsistidos
            // 
            this.txtDiasAsistidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasAsistidos.Location = new System.Drawing.Point(475, 129);
            this.txtDiasAsistidos.Name = "txtDiasAsistidos";
            this.txtDiasAsistidos.Size = new System.Drawing.Size(53, 20);
            this.txtDiasAsistidos.TabIndex = 0;
            this.txtDiasAsistidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasAsistidos_KeyPress);
            // 
            // dgvNotaAsistencia
            // 
            this.dgvNotaAsistencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotaAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaAsistencia.Location = new System.Drawing.Point(24, 131);
            this.dgvNotaAsistencia.Name = "dgvNotaAsistencia";
            this.dgvNotaAsistencia.Size = new System.Drawing.Size(344, 106);
            this.dgvNotaAsistencia.TabIndex = 15;
            // 
            // lblDiasAsistidos
            // 
            this.lblDiasAsistidos.AutoSize = true;
            this.lblDiasAsistidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasAsistidos.Location = new System.Drawing.Point(394, 134);
            this.lblDiasAsistidos.Name = "lblDiasAsistidos";
            this.lblDiasAsistidos.Size = new System.Drawing.Size(75, 13);
            this.lblDiasAsistidos.TabIndex = 14;
            this.lblDiasAsistidos.Text = "Dias Asistidos:";
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(24, 17);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(645, 106);
            this.dgvAsistencia.TabIndex = 14;
            // 
            // notaAsistenciaBindingSource1
            // 
            this.notaAsistenciaBindingSource1.DataMember = "NotaAsistencia";
            this.notaAsistenciaBindingSource1.DataSource = this.celyDBDataSet;
            // 
            // celyDBDataSet
            // 
            this.celyDBDataSet.DataSetName = "CelyDBDataSet";
            this.celyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataMember = "Asistencia";
            this.asistenciaBindingSource.DataSource = this.celyDBDataSet;
            // 
            // notaAsistenciaBindingSource
            // 
            this.notaAsistenciaBindingSource.DataMember = "NotaAsistencia";
            this.notaAsistenciaBindingSource.DataSource = this.celyDBDataSet;
            // 
            // notasExamenEscritoBindingSource
            // 
            this.notasExamenEscritoBindingSource.DataMember = "NotasExamenEscrito";
            this.notasExamenEscritoBindingSource.DataSource = this.celyDBDataSet;
            // 
            // notasExamenEscritoTableAdapter
            // 
            this.notasExamenEscritoTableAdapter.ClearBeforeFill = true;
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // notaAsistenciaTableAdapter
            // 
            this.notaAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(688, 260);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(162, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir Calificacion";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 535);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbInfomacionAsistencia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbNotasaRegistrar);
            this.Controls.Add(this.gbNotas);
            this.Controls.Add(this.btnCargarCalificacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbRegistroCalificaciones);
            this.Controls.Add(this.gbInformacionEstudiante);
            this.Controls.Add(this.lblBuscarCalificacion);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            this.gbInformacionEstudiante.ResumeLayout(false);
            this.gbInformacionEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCalificaciones)).EndInit();
            this.gbRegistroCalificaciones.ResumeLayout(false);
            this.gbRegistroCalificaciones.PerformLayout();
            this.gbNotas.ResumeLayout(false);
            this.gbNotasaRegistrar.ResumeLayout(false);
            this.gbNotasaRegistrar.PerformLayout();
            this.gbInfomacionAsistencia.ResumeLayout(false);
            this.gbInfomacionAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaAsistenciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaAsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasExamenEscritoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.LinkLabel lblBuscarCalificacion;
        private System.Windows.Forms.GroupBox gbInformacionEstudiante;
        private System.Windows.Forms.DataGridView dgvUltimasCalificaciones;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrimerParcial;
        private System.Windows.Forms.TextBox txtPrimerPalcial;
        private System.Windows.Forms.GroupBox gbRegistroCalificaciones;
        private System.Windows.Forms.Label lblFechaParcial;
        private System.Windows.Forms.DateTimePicker dtpFechaParcial;
        private System.Windows.Forms.TextBox txtTercerParcial;
        private System.Windows.Forms.Label lblTercerParcial;
        private System.Windows.Forms.TextBox txtSegundoParcial;
        private System.Windows.Forms.Label lblSegundoParcial;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargraEstudiante;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargarCalificacion;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.GroupBox gbNotasaRegistrar;
        private System.Windows.Forms.RadioButton rbExamenLectura;
        private System.Windows.Forms.RadioButton rbExamenOral;
        private System.Windows.Forms.RadioButton rbExamenEscrito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbExposicion;
        private System.Windows.Forms.Button btnCalcularAsitencia;
        private CelyDBDataSet celyDBDataSet;
        private System.Windows.Forms.BindingSource notasExamenEscritoBindingSource;
        private CelyDBDataSetTableAdapters.NotasExamenEscritoTableAdapter notasExamenEscritoTableAdapter;
        private System.Windows.Forms.GroupBox gbInfomacionAsistencia;
        private System.Windows.Forms.DataGridView dgvNotaAsistencia;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private CelyDBDataSetTableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
        private System.Windows.Forms.BindingSource notaAsistenciaBindingSource;
        private CelyDBDataSetTableAdapters.NotaAsistenciaTableAdapter notaAsistenciaTableAdapter;
        private System.Windows.Forms.BindingSource notaAsistenciaBindingSource1;
        private System.Windows.Forms.Label lblDiasAsistidos;
        private System.Windows.Forms.TextBox txtDiasAsistidos;
        private System.Windows.Forms.Button btnRegistrarNotaAsistencia;
        private System.Windows.Forms.TextBox txtNotaAsistencia;
        private System.Windows.Forms.Label lblNotaAsistencia;
        private System.Windows.Forms.TextBox txtTotalDias;
        private System.Windows.Forms.Label lblDiasTotal;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnImprimir;
    }
}
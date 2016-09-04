namespace Cely_Sistema
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDominioDelIdioma = new System.Windows.Forms.Label();
            this.lblNivelAcademico = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarAlumno = new System.Windows.Forms.LinkLabel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbEstudiante = new System.Windows.Forms.GroupBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.gbVIP = new System.Windows.Forms.GroupBox();
            this.cbVIP = new System.Windows.Forms.CheckBox();
            this.cbN_Academico = new System.Windows.Forms.ComboBox();
            this.cbD_Idioma = new System.Windows.Forms.ComboBox();
            this.pModoPago = new System.Windows.Forms.Panel();
            this.lblMododePago = new System.Windows.Forms.Label();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.rbSemanal = new System.Windows.Forms.RadioButton();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.gbNiveles = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtpFechadeInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeInicio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.verGruposwHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verGruposwHorarioTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerGruposwHorarioTableAdapter();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblFiltroPor = new System.Windows.Forms.Label();
            this.lblDigiteSuBusqueda = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltroNiveles = new System.Windows.Forms.Button();
            this.gbEstudiante.SuspendLayout();
            this.gbVIP.SuspendLayout();
            this.pModoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            this.gbNiveles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verGruposwHorarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(376, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro Estudiantil";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(176, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(28, 168);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(36, 13);
            this.lblEMail.TabIndex = 4;
            this.lblEMail.Text = "E-Mail";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(231, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 105);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(255, 239);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(293, 236);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(43, 20);
            this.txtEdad.TabIndex = 11;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 207);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(17, 25);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 12;
            this.lblNivel.Text = "Nivel";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(54, 22);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(129, 20);
            this.txtNivel.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(182, 136);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(240, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(138, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(177, 168);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(59, 13);
            this.lblOcupacion.TabIndex = 16;
            this.lblOcupacion.Text = "Ocupacion";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(239, 165);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(100, 20);
            this.txtOcupacion.TabIndex = 7;
            this.txtOcupacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOcupacion_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(26, 136);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(38, 13);
            this.lblSector.TabIndex = 19;
            this.lblSector.Text = "Sector";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(70, 133);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(100, 20);
            this.txtSector.TabIndex = 4;
            this.txtSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSector_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 467);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(560, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDominioDelIdioma
            // 
            this.lblDominioDelIdioma.AutoSize = true;
            this.lblDominioDelIdioma.Location = new System.Drawing.Point(23, 243);
            this.lblDominioDelIdioma.Name = "lblDominioDelIdioma";
            this.lblDominioDelIdioma.Size = new System.Drawing.Size(99, 13);
            this.lblDominioDelIdioma.TabIndex = 35;
            this.lblDominioDelIdioma.Text = "Dominio del Idioma:";
            // 
            // lblNivelAcademico
            // 
            this.lblNivelAcademico.AutoSize = true;
            this.lblNivelAcademico.Location = new System.Drawing.Point(23, 283);
            this.lblNivelAcademico.Name = "lblNivelAcademico";
            this.lblNivelAcademico.Size = new System.Drawing.Size(90, 13);
            this.lblNivelAcademico.TabIndex = 38;
            this.lblNivelAcademico.Text = "Nivel Academico:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(20, 29);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(97, 13);
            this.lblFechaActual.TabIndex = 39;
            this.lblFechaActual.Text = "Fecha de Registro:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Location = new System.Drawing.Point(123, 23);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaActual.TabIndex = 0;
            this.dtpFechaActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaActual_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(131, 99);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNacimiento_KeyPress);
            // 
            // lblBuscarAlumno
            // 
            this.lblBuscarAlumno.AutoSize = true;
            this.lblBuscarAlumno.Location = new System.Drawing.Point(660, 472);
            this.lblBuscarAlumno.Name = "lblBuscarAlumno";
            this.lblBuscarAlumno.Size = new System.Drawing.Size(78, 13);
            this.lblBuscarAlumno.TabIndex = 4;
            this.lblBuscarAlumno.TabStop = true;
            this.lblBuscarAlumno.Text = "Buscar Alumno";
            this.lblBuscarAlumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarAlumno_LinkClicked);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(108, 467);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 467);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbEstudiante
            // 
            this.gbEstudiante.Controls.Add(this.txtRespuesta2);
            this.gbEstudiante.Controls.Add(this.lblPregunta2);
            this.gbEstudiante.Controls.Add(this.txtRespuesta1);
            this.gbEstudiante.Controls.Add(this.lblPregunta1);
            this.gbEstudiante.Controls.Add(this.txtCelular);
            this.gbEstudiante.Controls.Add(this.txtTelefono);
            this.gbEstudiante.Controls.Add(this.lblCelular);
            this.gbEstudiante.Controls.Add(this.gbVIP);
            this.gbEstudiante.Controls.Add(this.cbN_Academico);
            this.gbEstudiante.Controls.Add(this.cbD_Idioma);
            this.gbEstudiante.Controls.Add(this.pModoPago);
            this.gbEstudiante.Controls.Add(this.lblFechaActual);
            this.gbEstudiante.Controls.Add(this.txtNombre);
            this.gbEstudiante.Controls.Add(this.lblNombre);
            this.gbEstudiante.Controls.Add(this.lblApellido);
            this.gbEstudiante.Controls.Add(this.lblEMail);
            this.gbEstudiante.Controls.Add(this.dtpFechaNacimiento);
            this.gbEstudiante.Controls.Add(this.txtApellido);
            this.gbEstudiante.Controls.Add(this.dtpFechaActual);
            this.gbEstudiante.Controls.Add(this.lblFechaNacimiento);
            this.gbEstudiante.Controls.Add(this.lblEdad);
            this.gbEstudiante.Controls.Add(this.lblNivelAcademico);
            this.gbEstudiante.Controls.Add(this.txtEdad);
            this.gbEstudiante.Controls.Add(this.lblTelefono);
            this.gbEstudiante.Controls.Add(this.lblDireccion);
            this.gbEstudiante.Controls.Add(this.lblDominioDelIdioma);
            this.gbEstudiante.Controls.Add(this.txtDireccion);
            this.gbEstudiante.Controls.Add(this.lblOcupacion);
            this.gbEstudiante.Controls.Add(this.txtOcupacion);
            this.gbEstudiante.Controls.Add(this.txtEmail);
            this.gbEstudiante.Controls.Add(this.txtSector);
            this.gbEstudiante.Controls.Add(this.lblSector);
            this.gbEstudiante.Location = new System.Drawing.Point(13, 28);
            this.gbEstudiante.Name = "gbEstudiante";
            this.gbEstudiante.Size = new System.Drawing.Size(384, 433);
            this.gbEstudiante.TabIndex = 0;
            this.gbEstudiante.TabStop = false;
            this.gbEstudiante.Text = "Estudiante";
            this.gbEstudiante.Enter += new System.EventHandler(this.gbEstudiante_Enter);
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(32, 377);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(337, 20);
            this.txtRespuesta2.TabIndex = 14;
            this.txtRespuesta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta2_KeyPress);
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Location = new System.Drawing.Point(114, 361);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(115, 13);
            this.lblPregunta2.TabIndex = 53;
            this.lblPregunta2.Text = "¿Donde ha estudiado?";
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(32, 333);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(337, 20);
            this.txtRespuesta1.TabIndex = 13;
            this.txtRespuesta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta1_KeyPress);
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(111, 317);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(141, 13);
            this.lblPregunta1.TabIndex = 51;
            this.lblPregunta1.Text = "¿Ha estudiado ingles antes?";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(231, 204);
            this.txtCelular.Mask = "(999) 000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(78, 204);
            this.txtTelefono.Mask = "(999) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress_1);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(187, 207);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 48;
            this.lblCelular.Text = "Celular:";
            // 
            // gbVIP
            // 
            this.gbVIP.Controls.Add(this.cbVIP);
            this.gbVIP.Location = new System.Drawing.Point(283, 397);
            this.gbVIP.Name = "gbVIP";
            this.gbVIP.Size = new System.Drawing.Size(56, 33);
            this.gbVIP.TabIndex = 46;
            this.gbVIP.TabStop = false;
            this.gbVIP.Text = "VIP";
            // 
            // cbVIP
            // 
            this.cbVIP.AutoSize = true;
            this.cbVIP.Location = new System.Drawing.Point(18, 13);
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Size = new System.Drawing.Size(15, 14);
            this.cbVIP.TabIndex = 0;
            this.cbVIP.UseVisualStyleBackColor = true;
            this.cbVIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbVIP_KeyPress);
            // 
            // cbN_Academico
            // 
            this.cbN_Academico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbN_Academico.FormattingEnabled = true;
            this.cbN_Academico.Items.AddRange(new object[] {
            "Estudiante",
            "Universitario",
            "Profesional",
            "Otros"});
            this.cbN_Academico.Location = new System.Drawing.Point(114, 279);
            this.cbN_Academico.Name = "cbN_Academico";
            this.cbN_Academico.Size = new System.Drawing.Size(103, 21);
            this.cbN_Academico.TabIndex = 12;
            this.cbN_Academico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbN_Academico_KeyPress);
            // 
            // cbD_Idioma
            // 
            this.cbD_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD_Idioma.FormattingEnabled = true;
            this.cbD_Idioma.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avazado",
            "Ninguno"});
            this.cbD_Idioma.Location = new System.Drawing.Point(122, 239);
            this.cbD_Idioma.Name = "cbD_Idioma";
            this.cbD_Idioma.Size = new System.Drawing.Size(103, 21);
            this.cbD_Idioma.TabIndex = 10;
            this.cbD_Idioma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbD_Idioma_KeyPress);
            // 
            // pModoPago
            // 
            this.pModoPago.Controls.Add(this.lblMododePago);
            this.pModoPago.Controls.Add(this.rbMensual);
            this.pModoPago.Controls.Add(this.rbSemanal);
            this.pModoPago.Location = new System.Drawing.Point(26, 401);
            this.pModoPago.Name = "pModoPago";
            this.pModoPago.Size = new System.Drawing.Size(245, 26);
            this.pModoPago.TabIndex = 45;
            // 
            // lblMododePago
            // 
            this.lblMododePago.AutoSize = true;
            this.lblMododePago.Location = new System.Drawing.Point(3, 6);
            this.lblMododePago.Name = "lblMododePago";
            this.lblMododePago.Size = new System.Drawing.Size(80, 13);
            this.lblMododePago.TabIndex = 42;
            this.lblMododePago.Text = "Modo de Pago:";
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(99, 5);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            this.rbMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbMensual_KeyPress);
            // 
            // rbSemanal
            // 
            this.rbSemanal.AutoSize = true;
            this.rbSemanal.Location = new System.Drawing.Point(170, 4);
            this.rbSemanal.Name = "rbSemanal";
            this.rbSemanal.Size = new System.Drawing.Size(66, 17);
            this.rbSemanal.TabIndex = 1;
            this.rbSemanal.TabStop = true;
            this.rbSemanal.Text = "Semanal";
            this.rbSemanal.UseVisualStyleBackColor = true;
            this.rbSemanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSemanal_KeyPress);
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Location = new System.Drawing.Point(6, 105);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveles.Size = new System.Drawing.Size(544, 322);
            this.dgvNiveles.TabIndex = 4;
            this.dgvNiveles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNiveles_CellContentClick);
            // 
            // gbNiveles
            // 
            this.gbNiveles.Controls.Add(this.btnLimpiarFiltroNiveles);
            this.gbNiveles.Controls.Add(this.txtBusqueda);
            this.gbNiveles.Controls.Add(this.cbFiltro);
            this.gbNiveles.Controls.Add(this.lblDigiteSuBusqueda);
            this.gbNiveles.Controls.Add(this.lblFiltroPor);
            this.gbNiveles.Controls.Add(this.btnSeleccionar);
            this.gbNiveles.Controls.Add(this.dtpFechadeInicio);
            this.gbNiveles.Controls.Add(this.lblFechadeInicio);
            this.gbNiveles.Controls.Add(this.btnBuscar);
            this.gbNiveles.Controls.Add(this.dgvNiveles);
            this.gbNiveles.Controls.Add(this.txtNivel);
            this.gbNiveles.Controls.Add(this.lblNivel);
            this.gbNiveles.Location = new System.Drawing.Point(412, 28);
            this.gbNiveles.Name = "gbNiveles";
            this.gbNiveles.Size = new System.Drawing.Size(566, 433);
            this.gbNiveles.TabIndex = 1;
            this.gbNiveles.TabStop = false;
            this.gbNiveles.Text = "Niveles";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(475, 76);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtpFechadeInicio
            // 
            this.dtpFechadeInicio.Location = new System.Drawing.Point(290, 19);
            this.dtpFechadeInicio.Name = "dtpFechadeInicio";
            this.dtpFechadeInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadeInicio.TabIndex = 1;
            this.dtpFechadeInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechadeInicio_KeyPress);
            // 
            // lblFechadeInicio
            // 
            this.lblFechadeInicio.AutoSize = true;
            this.lblFechadeInicio.Location = new System.Drawing.Point(201, 25);
            this.lblFechadeInicio.Name = "lblFechadeInicio";
            this.lblFechadeInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechadeInicio.TabIndex = 45;
            this.lblFechadeInicio.Text = "Fecha de Inicio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(314, 467);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(120, 23);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar Estudiante";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(457, 467);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFiltroPor
            // 
            this.lblFiltroPor.AutoSize = true;
            this.lblFiltroPor.Location = new System.Drawing.Point(20, 60);
            this.lblFiltroPor.Name = "lblFiltroPor";
            this.lblFiltroPor.Size = new System.Drawing.Size(54, 13);
            this.lblFiltroPor.TabIndex = 46;
            this.lblFiltroPor.Text = "Filtrar Por:";
            // 
            // lblDigiteSuBusqueda
            // 
            this.lblDigiteSuBusqueda.AutoSize = true;
            this.lblDigiteSuBusqueda.Location = new System.Drawing.Point(155, 60);
            this.lblDigiteSuBusqueda.Name = "lblDigiteSuBusqueda";
            this.lblDigiteSuBusqueda.Size = new System.Drawing.Size(102, 13);
            this.lblDigiteSuBusqueda.TabIndex = 47;
            this.lblDigiteSuBusqueda.Text = "Digite su Busqueda:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nivel",
            "Aula",
            "Horario",
            "Profesor"});
            this.cbFiltro.Location = new System.Drawing.Point(23, 78);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 48;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtBusqueda.FormattingEnabled = true;
            this.txtBusqueda.Location = new System.Drawing.Point(158, 78);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(238, 20);
            this.txtBusqueda.TabIndex = 49;
            this.txtBusqueda.SelectedIndexChanged += new System.EventHandler(this.txtBusqueda_SelectedIndexChanged);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnLimpiarFiltroNiveles
            // 
            this.btnLimpiarFiltroNiveles.Location = new System.Drawing.Point(407, 76);
            this.btnLimpiarFiltroNiveles.Name = "btnLimpiarFiltroNiveles";
            this.btnLimpiarFiltroNiveles.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiarFiltroNiveles.TabIndex = 50;
            this.btnLimpiarFiltroNiveles.Text = "Limpiar";
            this.btnLimpiarFiltroNiveles.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroNiveles.Click += new System.EventHandler(this.btnLimpiarFiltroNiveles_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 502);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.gbNiveles);
            this.Controls.Add(this.gbEstudiante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBuscarAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Estudiantir";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gbEstudiante.ResumeLayout(false);
            this.gbEstudiante.PerformLayout();
            this.gbVIP.ResumeLayout(false);
            this.gbVIP.PerformLayout();
            this.pModoPago.ResumeLayout(false);
            this.pModoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            this.gbNiveles.ResumeLayout(false);
            this.gbNiveles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verGruposwHorarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDominioDelIdioma;
        private System.Windows.Forms.Label lblNivelAcademico;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.LinkLabel lblBuscarAlumno;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbEstudiante;
        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.GroupBox gbNiveles;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DateTimePicker dtpFechadeInicio;
        private System.Windows.Forms.Label lblFechadeInicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMododePago;
        private System.Windows.Forms.Panel pModoPago;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbSemanal;
        private CelyDBDataSet celyDBDataSet;
        private System.Windows.Forms.BindingSource verGruposwHorarioBindingSource;
        private CelyDBDataSetTableAdapters.VerGruposwHorarioTableAdapter verGruposwHorarioTableAdapter;
        private System.Windows.Forms.ComboBox cbN_Academico;
        private System.Windows.Forms.ComboBox cbD_Idioma;
        private System.Windows.Forms.GroupBox gbVIP;
        private System.Windows.Forms.CheckBox cbVIP;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLimpiarFiltroNiveles;
        private System.Windows.Forms.ComboBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lblDigiteSuBusqueda;
        private System.Windows.Forms.Label lblFiltroPor;
    }
}
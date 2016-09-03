namespace Cely_Sistema
{
    partial class frmRegistrodeGruposyNiveles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrodeGruposyNiveles));
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBuscarHorario = new System.Windows.Forms.LinkLabel();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.gbRegistrodeNiveles = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerEstudiantesR = new System.Windows.Forms.Button();
            this.btnSeleccionarGrupos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarProfesor = new System.Windows.Forms.LinkLabel();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            this.gbRegistrodeNiveles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNivel
            // 
            this.txtNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(72, 19);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivel.TabIndex = 0;
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(31, 22);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 13);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(37, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBuscarHorario
            // 
            this.lblBuscarHorario.AutoSize = true;
            this.lblBuscarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarHorario.Location = new System.Drawing.Point(117, 143);
            this.lblBuscarHorario.Name = "lblBuscarHorario";
            this.lblBuscarHorario.Size = new System.Drawing.Size(77, 13);
            this.lblBuscarHorario.TabIndex = 5;
            this.lblBuscarHorario.TabStop = true;
            this.lblBuscarHorario.Text = "Buscar Horario";
            this.lblBuscarHorario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarHorario_LinkClicked);
            // 
            // cbAula
            // 
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbAula.Location = new System.Drawing.Point(71, 90);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(83, 21);
            this.cbAula.TabIndex = 3;
            this.cbAula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAula_KeyPress);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(31, 93);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(31, 13);
            this.lblAula.TabIndex = 5;
            this.lblAula.Text = "Aula:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(21, 123);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horario:";
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(71, 120);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(170, 20);
            this.txtHorario.TabIndex = 4;
            this.txtHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorario_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(132, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(323, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Location = new System.Drawing.Point(280, 19);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveles.Size = new System.Drawing.Size(590, 277);
            this.dgvNiveles.TabIndex = 11;
            // 
            // gbRegistrodeNiveles
            // 
            this.gbRegistrodeNiveles.Controls.Add(this.pictureBox1);
            this.gbRegistrodeNiveles.Controls.Add(this.btnVerEstudiantesR);
            this.gbRegistrodeNiveles.Controls.Add(this.btnSeleccionarGrupos);
            this.gbRegistrodeNiveles.Controls.Add(this.label1);
            this.gbRegistrodeNiveles.Controls.Add(this.dtpFechaInicio);
            this.gbRegistrodeNiveles.Controls.Add(this.lblBuscarProfesor);
            this.gbRegistrodeNiveles.Controls.Add(this.txtProfesor);
            this.gbRegistrodeNiveles.Controls.Add(this.lblProfesor);
            this.gbRegistrodeNiveles.Controls.Add(this.txtNivel);
            this.gbRegistrodeNiveles.Controls.Add(this.dgvNiveles);
            this.gbRegistrodeNiveles.Controls.Add(this.lblNivel);
            this.gbRegistrodeNiveles.Controls.Add(this.lblBuscarHorario);
            this.gbRegistrodeNiveles.Controls.Add(this.cbAula);
            this.gbRegistrodeNiveles.Controls.Add(this.lblAula);
            this.gbRegistrodeNiveles.Controls.Add(this.lblHorario);
            this.gbRegistrodeNiveles.Controls.Add(this.txtHorario);
            this.gbRegistrodeNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrodeNiveles.Location = new System.Drawing.Point(26, 18);
            this.gbRegistrodeNiveles.Name = "gbRegistrodeNiveles";
            this.gbRegistrodeNiveles.Size = new System.Drawing.Size(887, 331);
            this.gbRegistrodeNiveles.TabIndex = 0;
            this.gbRegistrodeNiveles.TabStop = false;
            this.gbRegistrodeNiveles.Text = "Registro de Niveles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerEstudiantesR
            // 
            this.btnVerEstudiantesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstudiantesR.Location = new System.Drawing.Point(525, 302);
            this.btnVerEstudiantesR.Name = "btnVerEstudiantesR";
            this.btnVerEstudiantesR.Size = new System.Drawing.Size(211, 23);
            this.btnVerEstudiantesR.TabIndex = 8;
            this.btnVerEstudiantesR.Text = "Ver Estudiantes Registrados en Ese Nivel";
            this.btnVerEstudiantesR.UseVisualStyleBackColor = true;
            this.btnVerEstudiantesR.Click += new System.EventHandler(this.btnVerEstudiantesR_Click);
            // 
            // btnSeleccionarGrupos
            // 
            this.btnSeleccionarGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarGrupos.Location = new System.Drawing.Point(377, 302);
            this.btnSeleccionarGrupos.Name = "btnSeleccionarGrupos";
            this.btnSeleccionarGrupos.Size = new System.Drawing.Size(119, 23);
            this.btnSeleccionarGrupos.TabIndex = 7;
            this.btnSeleccionarGrupos.Text = "Seleccionar Grupo";
            this.btnSeleccionarGrupos.UseVisualStyleBackColor = true;
            this.btnSeleccionarGrupos.Click += new System.EventHandler(this.btnSeleccionarGrupos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(80, 159);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(190, 20);
            this.dtpFechaInicio.TabIndex = 6;
            this.dtpFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaInicio_KeyPress);
            // 
            // lblBuscarProfesor
            // 
            this.lblBuscarProfesor.AutoSize = true;
            this.lblBuscarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProfesor.Location = new System.Drawing.Point(77, 74);
            this.lblBuscarProfesor.Name = "lblBuscarProfesor";
            this.lblBuscarProfesor.Size = new System.Drawing.Size(82, 13);
            this.lblBuscarProfesor.TabIndex = 2;
            this.lblBuscarProfesor.TabStop = true;
            this.lblBuscarProfesor.Text = "Buscar Profesor";
            this.lblBuscarProfesor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarProfesor_LinkClicked);
            // 
            // txtProfesor
            // 
            this.txtProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesor.Location = new System.Drawing.Point(72, 53);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 1;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(21, 56);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor.TabIndex = 13;
            this.lblProfesor.Text = "Profesor:";
            // 
            // frmRegistrodeGruposyNiveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 397);
            this.Controls.Add(this.gbRegistrodeNiveles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrodeGruposyNiveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Grupos y Niveles";
            this.Load += new System.EventHandler(this.frmRegistrodeGruposyNiveles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            this.gbRegistrodeNiveles.ResumeLayout(false);
            this.gbRegistrodeNiveles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.LinkLabel lblBuscarHorario;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.GroupBox gbRegistrodeNiveles;
        private System.Windows.Forms.LinkLabel lblBuscarProfesor;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnSeleccionarGrupos;
        private System.Windows.Forms.Button btnVerEstudiantesR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
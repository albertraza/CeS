namespace Cely_Sistema
{
    partial class frmFamilyConf
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbGrupo = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblAnadirGrupo = new System.Windows.Forms.LinkLabel();
            this.gbPagos = new System.Windows.Forms.GroupBox();
            this.lblMora = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblModoPago = new System.Windows.Forms.Label();
            this.rbSemanal = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaPrimerPago = new System.Windows.Forms.DateTimePicker();
            this.gbGrupo.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // gbGrupo
            // 
            this.gbGrupo.Controls.Add(this.btnLimpiar);
            this.gbGrupo.Controls.Add(this.btnEliminar);
            this.gbGrupo.Controls.Add(this.btnModificar);
            this.gbGrupo.Controls.Add(this.btnBuscar);
            this.gbGrupo.Controls.Add(this.btnGuardar);
            this.gbGrupo.Controls.Add(this.gbListado);
            this.gbGrupo.Controls.Add(this.lblAnadirGrupo);
            this.gbGrupo.Controls.Add(this.gbPagos);
            this.gbGrupo.Controls.Add(this.lblNombre);
            this.gbGrupo.Controls.Add(this.txtNombre);
            this.gbGrupo.Location = new System.Drawing.Point(12, 22);
            this.gbGrupo.Name = "gbGrupo";
            this.gbGrupo.Size = new System.Drawing.Size(805, 275);
            this.gbGrupo.TabIndex = 1;
            this.gbGrupo.TabStop = false;
            this.gbGrupo.Text = "Grupo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(365, 239);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(278, 239);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(196, 239);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(92, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar Grupo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(11, 239);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Location = new System.Drawing.Point(359, 7);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(421, 217);
            this.gbListado.TabIndex = 5;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Estudiantes";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(6, 22);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(409, 189);
            this.dgvListado.TabIndex = 4;
            // 
            // lblAnadirGrupo
            // 
            this.lblAnadirGrupo.AutoSize = true;
            this.lblAnadirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnadirGrupo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAnadirGrupo.Location = new System.Drawing.Point(468, 227);
            this.lblAnadirGrupo.Name = "lblAnadirGrupo";
            this.lblAnadirGrupo.Size = new System.Drawing.Size(205, 16);
            this.lblAnadirGrupo.TabIndex = 3;
            this.lblAnadirGrupo.TabStop = true;
            this.lblAnadirGrupo.Text = "+ Añadir Estudiante al Grupo";
            this.lblAnadirGrupo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAnadirGrupo_LinkClicked);
            // 
            // gbPagos
            // 
            this.gbPagos.Controls.Add(this.dtpFechaPrimerPago);
            this.gbPagos.Controls.Add(this.label1);
            this.gbPagos.Controls.Add(this.lblMora);
            this.gbPagos.Controls.Add(this.txtMora);
            this.gbPagos.Controls.Add(this.lblPago);
            this.gbPagos.Controls.Add(this.txtPago);
            this.gbPagos.Controls.Add(this.lblModoPago);
            this.gbPagos.Controls.Add(this.rbSemanal);
            this.gbPagos.Controls.Add(this.rbMensual);
            this.gbPagos.Location = new System.Drawing.Point(29, 73);
            this.gbPagos.Name = "gbPagos";
            this.gbPagos.Size = new System.Drawing.Size(299, 151);
            this.gbPagos.TabIndex = 2;
            this.gbPagos.TabStop = false;
            this.gbPagos.Text = "Pagos";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Location = new System.Drawing.Point(142, 67);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(34, 13);
            this.lblMora.TabIndex = 6;
            this.lblMora.Text = "Mora:";
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(182, 64);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(71, 20);
            this.txtMora.TabIndex = 5;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(12, 67);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(35, 13);
            this.lblPago.TabIndex = 4;
            this.lblPago.Text = "Pago:";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(52, 64);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(71, 20);
            this.txtPago.TabIndex = 3;
            // 
            // lblModoPago
            // 
            this.lblModoPago.AutoSize = true;
            this.lblModoPago.Location = new System.Drawing.Point(29, 30);
            this.lblModoPago.Name = "lblModoPago";
            this.lblModoPago.Size = new System.Drawing.Size(64, 13);
            this.lblModoPago.TabIndex = 2;
            this.lblModoPago.Text = "Modo pago:";
            // 
            // rbSemanal
            // 
            this.rbSemanal.AutoSize = true;
            this.rbSemanal.Location = new System.Drawing.Point(182, 28);
            this.rbSemanal.Name = "rbSemanal";
            this.rbSemanal.Size = new System.Drawing.Size(66, 17);
            this.rbSemanal.TabIndex = 1;
            this.rbSemanal.TabStop = true;
            this.rbSemanal.Text = "Semanal";
            this.rbSemanal.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(99, 28);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Primer Pago";
            // 
            // dtpFechaPrimerPago
            // 
            this.dtpFechaPrimerPago.Location = new System.Drawing.Point(42, 117);
            this.dtpFechaPrimerPago.Name = "dtpFechaPrimerPago";
            this.dtpFechaPrimerPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPrimerPago.TabIndex = 8;
            // 
            // frmFamilyConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 319);
            this.Controls.Add(this.gbGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFamilyConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Grupos";
            this.Load += new System.EventHandler(this.frmFamilyConf_Load);
            this.gbGrupo.ResumeLayout(false);
            this.gbGrupo.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbPagos.ResumeLayout(false);
            this.gbPagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbGrupo;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.LinkLabel lblAnadirGrupo;
        private System.Windows.Forms.GroupBox gbPagos;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblModoPago;
        private System.Windows.Forms.RadioButton rbSemanal;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaPrimerPago;
        private System.Windows.Forms.Label label1;
    }
}
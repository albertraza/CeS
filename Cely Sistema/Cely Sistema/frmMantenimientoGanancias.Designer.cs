namespace Cely_Sistema
{
    partial class frmMantenimientoGanancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoGanancias));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngresos = new System.Windows.Forms.Label();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.lblTotalGanancias = new System.Windows.Forms.Label();
            this.txtTotalGanancias = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbIngresos = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtDerechoExamen = new System.Windows.Forms.TextBox();
            this.lblDerechoExamen = new System.Windows.Forms.Label();
            this.txtReinscripcion = new System.Windows.Forms.TextBox();
            this.lblReinscripcion = new System.Windows.Forms.Label();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.txtLibros = new System.Windows.Forms.TextBox();
            this.lblLibros = new System.Windows.Forms.Label();
            this.lblDetallesGastos = new System.Windows.Forms.Label();
            this.txtDetallesGastos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbReporteGanancias = new System.Windows.Forms.GroupBox();
            this.btnImprimirReporte = new System.Windows.Forms.Button();
            this.btnGeneralReporte = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.gbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbReporteGanancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(127, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // lblFechaIngresos
            // 
            this.lblFechaIngresos.AutoSize = true;
            this.lblFechaIngresos.Location = new System.Drawing.Point(33, 32);
            this.lblFechaIngresos.Name = "lblFechaIngresos";
            this.lblFechaIngresos.Size = new System.Drawing.Size(83, 13);
            this.lblFechaIngresos.TabIndex = 1;
            this.lblFechaIngresos.Text = "Fecha Ingresos:";
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(102, 227);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIngresos.TabIndex = 6;
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Location = new System.Drawing.Point(15, 230);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(77, 13);
            this.lblTotalIngresos.TabIndex = 3;
            this.lblTotalIngresos.Text = "Total Ingresos:";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(53, 264);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(43, 13);
            this.lblDescuentos.TabIndex = 5;
            this.lblDescuentos.Text = "Gastos:";
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(102, 261);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(100, 20);
            this.txtGastos.TabIndex = 7;
            this.txtGastos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentos_KeyPress);
            // 
            // lblTotalGanancias
            // 
            this.lblTotalGanancias.AutoSize = true;
            this.lblTotalGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGanancias.Location = new System.Drawing.Point(372, 194);
            this.lblTotalGanancias.Name = "lblTotalGanancias";
            this.lblTotalGanancias.Size = new System.Drawing.Size(122, 16);
            this.lblTotalGanancias.TabIndex = 7;
            this.lblTotalGanancias.Text = "Total Ganancias";
            // 
            // txtTotalGanancias
            // 
            this.txtTotalGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGanancias.Location = new System.Drawing.Point(384, 213);
            this.txtTotalGanancias.Name = "txtTotalGanancias";
            this.txtTotalGanancias.Size = new System.Drawing.Size(100, 22);
            this.txtTotalGanancias.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 407);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(262, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbIngresos
            // 
            this.gbIngresos.Controls.Add(this.btnImprimir);
            this.gbIngresos.Controls.Add(this.txtCuota);
            this.gbIngresos.Controls.Add(this.lblCuota);
            this.gbIngresos.Controls.Add(this.txtDerechoExamen);
            this.gbIngresos.Controls.Add(this.lblDerechoExamen);
            this.gbIngresos.Controls.Add(this.txtReinscripcion);
            this.gbIngresos.Controls.Add(this.lblReinscripcion);
            this.gbIngresos.Controls.Add(this.txtInscripcion);
            this.gbIngresos.Controls.Add(this.lblInscripcion);
            this.gbIngresos.Controls.Add(this.txtLibros);
            this.gbIngresos.Controls.Add(this.lblLibros);
            this.gbIngresos.Controls.Add(this.lblDetallesGastos);
            this.gbIngresos.Controls.Add(this.txtDetallesGastos);
            this.gbIngresos.Controls.Add(this.pictureBox1);
            this.gbIngresos.Controls.Add(this.lblFechaIngresos);
            this.gbIngresos.Controls.Add(this.btnCalcular);
            this.gbIngresos.Controls.Add(this.dtpFecha);
            this.gbIngresos.Controls.Add(this.txtTotalIngresos);
            this.gbIngresos.Controls.Add(this.lblTotalIngresos);
            this.gbIngresos.Controls.Add(this.lblTotalGanancias);
            this.gbIngresos.Controls.Add(this.txtGastos);
            this.gbIngresos.Controls.Add(this.txtTotalGanancias);
            this.gbIngresos.Controls.Add(this.lblDescuentos);
            this.gbIngresos.Location = new System.Drawing.Point(12, 12);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.Size = new System.Drawing.Size(521, 389);
            this.gbIngresos.TabIndex = 0;
            this.gbIngresos.TabStop = false;
            this.gbIngresos.Text = "Mantenimiento Ingresos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(375, 259);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Ganancias";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(102, 60);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 20);
            this.txtCuota.TabIndex = 1;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(58, 63);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(38, 13);
            this.lblCuota.TabIndex = 23;
            this.lblCuota.Text = "Cuota:";
            // 
            // txtDerechoExamen
            // 
            this.txtDerechoExamen.Location = new System.Drawing.Point(102, 194);
            this.txtDerechoExamen.Name = "txtDerechoExamen";
            this.txtDerechoExamen.Size = new System.Drawing.Size(100, 20);
            this.txtDerechoExamen.TabIndex = 5;
            // 
            // lblDerechoExamen
            // 
            this.lblDerechoExamen.AutoSize = true;
            this.lblDerechoExamen.Location = new System.Drawing.Point(19, 197);
            this.lblDerechoExamen.Name = "lblDerechoExamen";
            this.lblDerechoExamen.Size = new System.Drawing.Size(80, 13);
            this.lblDerechoExamen.TabIndex = 21;
            this.lblDerechoExamen.Text = "Der. a Examen:";
            // 
            // txtReinscripcion
            // 
            this.txtReinscripcion.Location = new System.Drawing.Point(102, 158);
            this.txtReinscripcion.Name = "txtReinscripcion";
            this.txtReinscripcion.Size = new System.Drawing.Size(100, 20);
            this.txtReinscripcion.TabIndex = 4;
            // 
            // lblReinscripcion
            // 
            this.lblReinscripcion.AutoSize = true;
            this.lblReinscripcion.Location = new System.Drawing.Point(25, 161);
            this.lblReinscripcion.Name = "lblReinscripcion";
            this.lblReinscripcion.Size = new System.Drawing.Size(74, 13);
            this.lblReinscripcion.TabIndex = 19;
            this.lblReinscripcion.Text = "Reinscripcion:";
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(102, 123);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(100, 20);
            this.txtInscripcion.TabIndex = 3;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Location = new System.Drawing.Point(38, 126);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(61, 13);
            this.lblInscripcion.TabIndex = 17;
            this.lblInscripcion.Text = "Inscripcion:";
            // 
            // txtLibros
            // 
            this.txtLibros.Location = new System.Drawing.Point(102, 95);
            this.txtLibros.Name = "txtLibros";
            this.txtLibros.Size = new System.Drawing.Size(100, 20);
            this.txtLibros.TabIndex = 2;
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.Location = new System.Drawing.Point(61, 98);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(38, 13);
            this.lblLibros.TabIndex = 15;
            this.lblLibros.Text = "Libros:";
            // 
            // lblDetallesGastos
            // 
            this.lblDetallesGastos.AutoSize = true;
            this.lblDetallesGastos.Location = new System.Drawing.Point(15, 300);
            this.lblDetallesGastos.Name = "lblDetallesGastos";
            this.lblDetallesGastos.Size = new System.Drawing.Size(84, 13);
            this.lblDetallesGastos.TabIndex = 13;
            this.lblDetallesGastos.Text = "Detalles Gastos:";
            // 
            // txtDetallesGastos
            // 
            this.txtDetallesGastos.Location = new System.Drawing.Point(102, 297);
            this.txtDetallesGastos.MaxLength = 200;
            this.txtDetallesGastos.Multiline = true;
            this.txtDetallesGastos.Name = "txtDetallesGastos";
            this.txtDetallesGastos.Size = new System.Drawing.Size(409, 74);
            this.txtDetallesGastos.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(126, 407);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbReporteGanancias
            // 
            this.gbReporteGanancias.Controls.Add(this.btnImprimirReporte);
            this.gbReporteGanancias.Controls.Add(this.btnGeneralReporte);
            this.gbReporteGanancias.Controls.Add(this.lblFechaHasta);
            this.gbReporteGanancias.Controls.Add(this.lblFechaDesde);
            this.gbReporteGanancias.Controls.Add(this.dtpFechaHasta);
            this.gbReporteGanancias.Controls.Add(this.dtpFechaDesde);
            this.gbReporteGanancias.Controls.Add(this.dgvTabla);
            this.gbReporteGanancias.Location = new System.Drawing.Point(539, 12);
            this.gbReporteGanancias.Name = "gbReporteGanancias";
            this.gbReporteGanancias.Size = new System.Drawing.Size(601, 389);
            this.gbReporteGanancias.TabIndex = 4;
            this.gbReporteGanancias.TabStop = false;
            this.gbReporteGanancias.Text = "Reporte Ganancias";
            // 
            // btnImprimirReporte
            // 
            this.btnImprimirReporte.Location = new System.Drawing.Point(387, 76);
            this.btnImprimirReporte.Name = "btnImprimirReporte";
            this.btnImprimirReporte.Size = new System.Drawing.Size(174, 23);
            this.btnImprimirReporte.TabIndex = 6;
            this.btnImprimirReporte.Text = "Imprimir Reporte";
            this.btnImprimirReporte.UseVisualStyleBackColor = true;
            this.btnImprimirReporte.Click += new System.EventHandler(this.btnImprimirReporte_Click);
            // 
            // btnGeneralReporte
            // 
            this.btnGeneralReporte.Location = new System.Drawing.Point(387, 33);
            this.btnGeneralReporte.Name = "btnGeneralReporte";
            this.btnGeneralReporte.Size = new System.Drawing.Size(174, 23);
            this.btnGeneralReporte.TabIndex = 5;
            this.btnGeneralReporte.Text = "Ver Reporte de Ganancias";
            this.btnGeneralReporte.UseVisualStyleBackColor = true;
            this.btnGeneralReporte.Click += new System.EventHandler(this.btnGeneralReporte_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(39, 82);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(65, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Final:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(39, 38);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(68, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha Inicio:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(113, 76);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(113, 32);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(6, 141);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(589, 242);
            this.dgvTabla.TabIndex = 0;
            // 
            // frmMantenimientoGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 447);
            this.Controls.Add(this.gbReporteGanancias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbIngresos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantenimientoGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Ganancias";
            this.Load += new System.EventHandler(this.frmMantenimientoGanancias_Load);
            this.gbIngresos.ResumeLayout(false);
            this.gbIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbReporteGanancias.ResumeLayout(false);
            this.gbReporteGanancias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaIngresos;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label lblTotalGanancias;
        private System.Windows.Forms.TextBox txtTotalGanancias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbIngresos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox txtDerechoExamen;
        private System.Windows.Forms.Label lblDerechoExamen;
        private System.Windows.Forms.TextBox txtReinscripcion;
        private System.Windows.Forms.Label lblReinscripcion;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.TextBox txtLibros;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Label lblDetallesGastos;
        private System.Windows.Forms.TextBox txtDetallesGastos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbReporteGanancias;
        private System.Windows.Forms.Button btnImprimirReporte;
        private System.Windows.Forms.Button btnGeneralReporte;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DataGridView dgvTabla;
    }
}
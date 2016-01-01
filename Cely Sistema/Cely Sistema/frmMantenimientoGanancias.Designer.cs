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
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.lblTotalGanancias = new System.Windows.Forms.Label();
            this.txtTotalGanancias = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbIngresos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtTotalIngresos.Location = new System.Drawing.Point(127, 60);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIngresos.TabIndex = 1;
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Location = new System.Drawing.Point(44, 63);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(77, 13);
            this.lblTotalIngresos.TabIndex = 3;
            this.lblTotalIngresos.Text = "Total Ingresos:";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(54, 98);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(67, 13);
            this.lblDescuentos.TabIndex = 5;
            this.lblDescuentos.Text = "Descuentos:";
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(127, 95);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentos.TabIndex = 2;
            this.txtDescuentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentos_KeyPress);
            // 
            // lblTotalGanancias
            // 
            this.lblTotalGanancias.AutoSize = true;
            this.lblTotalGanancias.Location = new System.Drawing.Point(33, 133);
            this.lblTotalGanancias.Name = "lblTotalGanancias";
            this.lblTotalGanancias.Size = new System.Drawing.Size(88, 13);
            this.lblTotalGanancias.TabIndex = 7;
            this.lblTotalGanancias.Text = "Total Ganancias:";
            // 
            // txtTotalGanancias
            // 
            this.txtTotalGanancias.Location = new System.Drawing.Point(127, 130);
            this.txtTotalGanancias.Name = "txtTotalGanancias";
            this.txtTotalGanancias.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGanancias.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 202);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(265, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbIngresos
            // 
            this.gbIngresos.Controls.Add(this.pictureBox1);
            this.gbIngresos.Controls.Add(this.lblFechaIngresos);
            this.gbIngresos.Controls.Add(this.btnCalcular);
            this.gbIngresos.Controls.Add(this.dtpFecha);
            this.gbIngresos.Controls.Add(this.txtTotalIngresos);
            this.gbIngresos.Controls.Add(this.lblTotalIngresos);
            this.gbIngresos.Controls.Add(this.lblTotalGanancias);
            this.gbIngresos.Controls.Add(this.txtDescuentos);
            this.gbIngresos.Controls.Add(this.txtTotalGanancias);
            this.gbIngresos.Controls.Add(this.lblDescuentos);
            this.gbIngresos.Location = new System.Drawing.Point(12, 12);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.Size = new System.Drawing.Size(521, 174);
            this.gbIngresos.TabIndex = 0;
            this.gbIngresos.TabStop = false;
            this.gbIngresos.Text = "Mantenimiento Ingresos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(117, 202);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmMantenimientoGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 241);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaIngresos;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.Label lblTotalGanancias;
        private System.Windows.Forms.TextBox txtTotalGanancias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbIngresos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
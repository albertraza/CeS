namespace Cely_Sistema
{
    partial class frmBuscarCalificacion
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
            this.dgvListaExamenes = new System.Windows.Forms.DataGridView();
            this.gbExamenCo = new System.Windows.Forms.GroupBox();
            this.rbExposicion = new System.Windows.Forms.RadioButton();
            this.rbExamenOral = new System.Windows.Forms.RadioButton();
            this.rbExamenLectura = new System.Windows.Forms.RadioButton();
            this.rbExamenEscritos = new System.Windows.Forms.RadioButton();
            this.dtpFechaExamen = new System.Windows.Forms.DateTimePicker();
            this.lblFechaExamen = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExamenes)).BeginInit();
            this.gbExamenCo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaExamenes
            // 
            this.dgvListaExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaExamenes.Location = new System.Drawing.Point(12, 178);
            this.dgvListaExamenes.Name = "dgvListaExamenes";
            this.dgvListaExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaExamenes.Size = new System.Drawing.Size(666, 355);
            this.dgvListaExamenes.TabIndex = 0;
            // 
            // gbExamenCo
            // 
            this.gbExamenCo.Controls.Add(this.rbExposicion);
            this.gbExamenCo.Controls.Add(this.rbExamenOral);
            this.gbExamenCo.Controls.Add(this.rbExamenLectura);
            this.gbExamenCo.Controls.Add(this.rbExamenEscritos);
            this.gbExamenCo.Location = new System.Drawing.Point(12, 12);
            this.gbExamenCo.Name = "gbExamenCo";
            this.gbExamenCo.Size = new System.Drawing.Size(302, 100);
            this.gbExamenCo.TabIndex = 1;
            this.gbExamenCo.TabStop = false;
            this.gbExamenCo.Text = "Examen a Consultar";
            // 
            // rbExposicion
            // 
            this.rbExposicion.AutoSize = true;
            this.rbExposicion.Location = new System.Drawing.Point(166, 67);
            this.rbExposicion.Name = "rbExposicion";
            this.rbExposicion.Size = new System.Drawing.Size(76, 17);
            this.rbExposicion.TabIndex = 3;
            this.rbExposicion.TabStop = true;
            this.rbExposicion.Text = "Exposicion";
            this.rbExposicion.UseVisualStyleBackColor = true;
            this.rbExposicion.CheckedChanged += new System.EventHandler(this.rbExposicion_CheckedChanged);
            // 
            // rbExamenOral
            // 
            this.rbExamenOral.AutoSize = true;
            this.rbExamenOral.Location = new System.Drawing.Point(166, 29);
            this.rbExamenOral.Name = "rbExamenOral";
            this.rbExamenOral.Size = new System.Drawing.Size(85, 17);
            this.rbExamenOral.TabIndex = 2;
            this.rbExamenOral.TabStop = true;
            this.rbExamenOral.Text = "Examen Oral";
            this.rbExamenOral.UseVisualStyleBackColor = true;
            this.rbExamenOral.CheckedChanged += new System.EventHandler(this.rbExamenOral_CheckedChanged);
            // 
            // rbExamenLectura
            // 
            this.rbExamenLectura.AutoSize = true;
            this.rbExamenLectura.Location = new System.Drawing.Point(22, 67);
            this.rbExamenLectura.Name = "rbExamenLectura";
            this.rbExamenLectura.Size = new System.Drawing.Size(117, 17);
            this.rbExamenLectura.TabIndex = 1;
            this.rbExamenLectura.TabStop = true;
            this.rbExamenLectura.Text = "Examen de Lectura";
            this.rbExamenLectura.UseVisualStyleBackColor = true;
            this.rbExamenLectura.CheckedChanged += new System.EventHandler(this.rbExamenLectura_CheckedChanged);
            // 
            // rbExamenEscritos
            // 
            this.rbExamenEscritos.AutoSize = true;
            this.rbExamenEscritos.Location = new System.Drawing.Point(22, 29);
            this.rbExamenEscritos.Name = "rbExamenEscritos";
            this.rbExamenEscritos.Size = new System.Drawing.Size(103, 17);
            this.rbExamenEscritos.TabIndex = 0;
            this.rbExamenEscritos.TabStop = true;
            this.rbExamenEscritos.Text = "Examen Escritos";
            this.rbExamenEscritos.UseVisualStyleBackColor = true;
            this.rbExamenEscritos.CheckedChanged += new System.EventHandler(this.rbExamenEscritos_CheckedChanged);
            // 
            // dtpFechaExamen
            // 
            this.dtpFechaExamen.Location = new System.Drawing.Point(425, 26);
            this.dtpFechaExamen.Name = "dtpFechaExamen";
            this.dtpFechaExamen.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaExamen.TabIndex = 4;
            this.dtpFechaExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaExamen_KeyPress);
            // 
            // lblFechaExamen
            // 
            this.lblFechaExamen.AutoSize = true;
            this.lblFechaExamen.Location = new System.Drawing.Point(338, 32);
            this.lblFechaExamen.Name = "lblFechaExamen";
            this.lblFechaExamen.Size = new System.Drawing.Size(81, 13);
            this.lblFechaExamen.TabIndex = 5;
            this.lblFechaExamen.Text = "Fecha Examen:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(366, 81);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 6;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(425, 76);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(568, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(257, 155);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(189, 20);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Calificaciones Examen";
            // 
            // frmBuscarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 545);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblFechaExamen);
            this.Controls.Add(this.dtpFechaExamen);
            this.Controls.Add(this.gbExamenCo);
            this.Controls.Add(this.dgvListaExamenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarCalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Calificaciones";
            this.Load += new System.EventHandler(this.frmBuscarCalificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExamenes)).EndInit();
            this.gbExamenCo.ResumeLayout(false);
            this.gbExamenCo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaExamenes;
        private System.Windows.Forms.GroupBox gbExamenCo;
        private System.Windows.Forms.RadioButton rbExposicion;
        private System.Windows.Forms.RadioButton rbExamenOral;
        private System.Windows.Forms.RadioButton rbExamenLectura;
        private System.Windows.Forms.RadioButton rbExamenEscritos;
        private System.Windows.Forms.DateTimePicker dtpFechaExamen;
        private System.Windows.Forms.Label lblFechaExamen;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
    }
}
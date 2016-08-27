namespace Cely_Sistema
{
    partial class frmBuscarGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarGrupos));
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.lblFechadeInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Location = new System.Drawing.Point(19, 108);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveles.Size = new System.Drawing.Size(688, 249);
            this.dgvNiveles.TabIndex = 0;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(71, 23);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivel.TabIndex = 0;
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(30, 26);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 13);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(16, 72);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor.TabIndex = 5;
            this.lblProfesor.Text = "Profesor:";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(71, 69);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 1;
            this.txtProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_KeyPress);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(242, 26);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(31, 13);
            this.lblAula.TabIndex = 7;
            this.lblAula.Text = "Aula:";
            this.lblAula.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(279, 23);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 2;
            this.txtAula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAula_KeyPress);
            // 
            // lblFechadeInicio
            // 
            this.lblFechadeInicio.AutoSize = true;
            this.lblFechadeInicio.Location = new System.Drawing.Point(242, 72);
            this.lblFechadeInicio.Name = "lblFechadeInicio";
            this.lblFechadeInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechadeInicio.TabIndex = 8;
            this.lblFechadeInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(331, 69);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaInicio.TabIndex = 3;
            this.dtpFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaInicio_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(632, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(632, 50);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmBuscarGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 375);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechadeInicio);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.dgvNiveles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Niveles";
            this.Load += new System.EventHandler(this.frmBuscarGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label lblFechadeInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
    }
}
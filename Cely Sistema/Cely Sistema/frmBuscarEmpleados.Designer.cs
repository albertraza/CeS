namespace Cely_Sistema
{
    partial class frmBuscarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEmpleados));
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.rbProfesores = new System.Windows.Forms.RadioButton();
            this.rbSecretarias = new System.Windows.Forms.RadioButton();
            this.gbBusquedaDe = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbBusquedaDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(75, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(289, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(21, 109);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(340, 150);
            this.dgvTabla.TabIndex = 7;
            // 
            // rbProfesores
            // 
            this.rbProfesores.AutoSize = true;
            this.rbProfesores.Location = new System.Drawing.Point(12, 26);
            this.rbProfesores.Name = "rbProfesores";
            this.rbProfesores.Size = new System.Drawing.Size(75, 17);
            this.rbProfesores.TabIndex = 0;
            this.rbProfesores.TabStop = true;
            this.rbProfesores.Text = "Profesores";
            this.rbProfesores.UseVisualStyleBackColor = true;
            // 
            // rbSecretarias
            // 
            this.rbSecretarias.AutoSize = true;
            this.rbSecretarias.Location = new System.Drawing.Point(12, 49);
            this.rbSecretarias.Name = "rbSecretarias";
            this.rbSecretarias.Size = new System.Drawing.Size(78, 17);
            this.rbSecretarias.TabIndex = 1;
            this.rbSecretarias.TabStop = true;
            this.rbSecretarias.Text = "Secretarias";
            this.rbSecretarias.UseVisualStyleBackColor = true;
            // 
            // gbBusquedaDe
            // 
            this.gbBusquedaDe.Controls.Add(this.rbProfesores);
            this.gbBusquedaDe.Controls.Add(this.rbSecretarias);
            this.gbBusquedaDe.Location = new System.Drawing.Point(181, 12);
            this.gbBusquedaDe.Name = "gbBusquedaDe";
            this.gbBusquedaDe.Size = new System.Drawing.Size(102, 90);
            this.gbBusquedaDe.TabIndex = 15;
            this.gbBusquedaDe.TabStop = false;
            this.gbBusquedaDe.Text = "Desea Buscar?";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(289, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmBuscarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 280);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbBusquedaDe);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleados";
            this.Load += new System.EventHandler(this.frmBuscarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbBusquedaDe.ResumeLayout(false);
            this.gbBusquedaDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.RadioButton rbProfesores;
        private System.Windows.Forms.RadioButton rbSecretarias;
        private System.Windows.Forms.GroupBox gbBusquedaDe;
        private System.Windows.Forms.Button btnModificar;
    }
}
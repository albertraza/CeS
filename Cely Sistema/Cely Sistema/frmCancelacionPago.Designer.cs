namespace Cely_Sistema
{
    partial class frmCancelacionPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelacionPago));
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.lblIDFactura = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCanRemborso = new System.Windows.Forms.Label();
            this.nCant = new System.Windows.Forms.NumericUpDown();
            this.lblTotalRemborso = new System.Windows.Forms.Label();
            this.txtTotalRemborso = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.LinkLabel();
            this.btnSeleccionarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 143);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactura.Size = new System.Drawing.Size(590, 150);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.Location = new System.Drawing.Point(112, 36);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFactura.TabIndex = 1;
            this.txtCodigoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFactura_KeyPress);
            // 
            // lblIDFactura
            // 
            this.lblIDFactura.AutoSize = true;
            this.lblIDFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFactura.Location = new System.Drawing.Point(24, 39);
            this.lblIDFactura.Name = "lblIDFactura";
            this.lblIDFactura.Size = new System.Drawing.Size(82, 13);
            this.lblIDFactura.TabIndex = 2;
            this.lblIDFactura.Text = "Codigo Factura:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(245, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.lblIDFactura);
            this.gbFactura.Controls.Add(this.btnBuscar);
            this.gbFactura.Controls.Add(this.txtCodigoFactura);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(12, 12);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(341, 83);
            this.gbFactura.TabIndex = 4;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            this.gbFactura.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPago.Location = new System.Drawing.Point(12, 313);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(89, 23);
            this.btnCancelarPago.TabIndex = 5;
            this.btnCancelarPago.Text = "Cancelar Pago";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(510, 313);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCanRemborso
            // 
            this.lblCanRemborso.AutoSize = true;
            this.lblCanRemborso.Location = new System.Drawing.Point(375, 23);
            this.lblCanRemborso.Name = "lblCanRemborso";
            this.lblCanRemborso.Size = new System.Drawing.Size(130, 13);
            this.lblCanRemborso.TabIndex = 7;
            this.lblCanRemborso.Text = "Cant Semanas Remborso:";
            // 
            // nCant
            // 
            this.nCant.Location = new System.Drawing.Point(511, 21);
            this.nCant.Name = "nCant";
            this.nCant.Size = new System.Drawing.Size(53, 20);
            this.nCant.TabIndex = 8;
            this.nCant.ValueChanged += new System.EventHandler(this.nCant_ValueChanged);
            // 
            // lblTotalRemborso
            // 
            this.lblTotalRemborso.AutoSize = true;
            this.lblTotalRemborso.Location = new System.Drawing.Point(375, 50);
            this.lblTotalRemborso.Name = "lblTotalRemborso";
            this.lblTotalRemborso.Size = new System.Drawing.Size(97, 13);
            this.lblTotalRemborso.TabIndex = 9;
            this.lblTotalRemborso.Text = "Total a Remborsar:";
            // 
            // txtTotalRemborso
            // 
            this.txtTotalRemborso.Location = new System.Drawing.Point(478, 48);
            this.txtTotalRemborso.Name = "txtTotalRemborso";
            this.txtTotalRemborso.Size = new System.Drawing.Size(86, 20);
            this.txtTotalRemborso.TabIndex = 10;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(493, 71);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(50, 13);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.TabStop = true;
            this.lblModificar.Text = "Modificar";
            this.lblModificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblModificar_LinkClicked);
            // 
            // btnSeleccionarFactura
            // 
            this.btnSeleccionarFactura.Location = new System.Drawing.Point(26, 114);
            this.btnSeleccionarFactura.Name = "btnSeleccionarFactura";
            this.btnSeleccionarFactura.Size = new System.Drawing.Size(134, 23);
            this.btnSeleccionarFactura.TabIndex = 12;
            this.btnSeleccionarFactura.Text = "Seleccionar Factura";
            this.btnSeleccionarFactura.UseVisualStyleBackColor = true;
            this.btnSeleccionarFactura.Click += new System.EventHandler(this.btnSeleccionarFactura_Click);
            // 
            // frmCancelacionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 348);
            this.Controls.Add(this.btnSeleccionarFactura);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.txtTotalRemborso);
            this.Controls.Add(this.lblTotalRemborso);
            this.Controls.Add(this.nCant);
            this.Controls.Add(this.lblCanRemborso);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelarPago);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.dgvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelacionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cacelacion de Pagos";
            this.Load += new System.EventHandler(this.frmCancelacionPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Label lblIDFactura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCanRemborso;
        private System.Windows.Forms.NumericUpDown nCant;
        private System.Windows.Forms.Label lblTotalRemborso;
        private System.Windows.Forms.TextBox txtTotalRemborso;
        private System.Windows.Forms.LinkLabel lblModificar;
        private System.Windows.Forms.Button btnSeleccionarFactura;
    }
}
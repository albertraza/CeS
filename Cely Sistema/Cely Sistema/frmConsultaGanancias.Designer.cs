namespace Cely_Sistema
{
    partial class frmConsultaGanancias
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
            this.dgvGanancias = new System.Windows.Forms.DataGridView();
            this.dtpFechaGanancias = new System.Windows.Forms.DateTimePicker();
            this.lblFechaGanancias = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGanancias
            // 
            this.dgvGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanancias.Location = new System.Drawing.Point(12, 110);
            this.dgvGanancias.Name = "dgvGanancias";
            this.dgvGanancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGanancias.Size = new System.Drawing.Size(584, 311);
            this.dgvGanancias.TabIndex = 0;
            // 
            // dtpFechaGanancias
            // 
            this.dtpFechaGanancias.Location = new System.Drawing.Point(123, 43);
            this.dtpFechaGanancias.Name = "dtpFechaGanancias";
            this.dtpFechaGanancias.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaGanancias.TabIndex = 1;
            this.dtpFechaGanancias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaGanancias_KeyPress);
            // 
            // lblFechaGanancias
            // 
            this.lblFechaGanancias.AutoSize = true;
            this.lblFechaGanancias.Location = new System.Drawing.Point(23, 49);
            this.lblFechaGanancias.Name = "lblFechaGanancias";
            this.lblFechaGanancias.Size = new System.Drawing.Size(94, 13);
            this.lblFechaGanancias.TabIndex = 2;
            this.lblFechaGanancias.Text = "Fecha Ganancias:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(495, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(351, 44);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmConsultaGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 433);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaGanancias);
            this.Controls.Add(this.dtpFechaGanancias);
            this.Controls.Add(this.dgvGanancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ganancias";
            this.Load += new System.EventHandler(this.frmConsultaGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGanancias;
        private System.Windows.Forms.DateTimePicker dtpFechaGanancias;
        private System.Windows.Forms.Label lblFechaGanancias;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
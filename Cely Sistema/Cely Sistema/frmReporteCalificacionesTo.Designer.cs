namespace Cely_Sistema
{
    partial class frmReporteCalificacionesTo
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.gbGenerarReporte = new System.Windows.Forms.GroupBox();
            this.btnGeneralReporte = new System.Windows.Forms.Button();
            this.gbGenerarReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(105, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDesde_KeyPress);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(105, 75);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpHasta_KeyPress);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(58, 41);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(58, 81);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // gbGenerarReporte
            // 
            this.gbGenerarReporte.Controls.Add(this.btnGeneralReporte);
            this.gbGenerarReporte.Controls.Add(this.lblDesde);
            this.gbGenerarReporte.Controls.Add(this.lblHasta);
            this.gbGenerarReporte.Controls.Add(this.dtpDesde);
            this.gbGenerarReporte.Controls.Add(this.dtpHasta);
            this.gbGenerarReporte.Location = new System.Drawing.Point(12, 41);
            this.gbGenerarReporte.Name = "gbGenerarReporte";
            this.gbGenerarReporte.Size = new System.Drawing.Size(430, 150);
            this.gbGenerarReporte.TabIndex = 0;
            this.gbGenerarReporte.TabStop = false;
            this.gbGenerarReporte.Text = "Generar Reporte";
            // 
            // btnGeneralReporte
            // 
            this.btnGeneralReporte.Location = new System.Drawing.Point(330, 121);
            this.btnGeneralReporte.Name = "btnGeneralReporte";
            this.btnGeneralReporte.Size = new System.Drawing.Size(75, 23);
            this.btnGeneralReporte.TabIndex = 2;
            this.btnGeneralReporte.Text = "Reporte";
            this.btnGeneralReporte.UseVisualStyleBackColor = true;
            this.btnGeneralReporte.Click += new System.EventHandler(this.btnGeneralReporte_Click);
            // 
            // frmReporteCalificacionesTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 228);
            this.Controls.Add(this.gbGenerarReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteCalificacionesTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Calificaciones";
            this.Load += new System.EventHandler(this.frmReporteCalificacionesTo_Load);
            this.gbGenerarReporte.ResumeLayout(false);
            this.gbGenerarReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.GroupBox gbGenerarReporte;
        private System.Windows.Forms.Button btnGeneralReporte;
    }
}
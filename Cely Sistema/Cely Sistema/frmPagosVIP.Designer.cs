namespace Cely_Sistema
{
    partial class frmPagosVIP
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
            this.dgvPagosVIP = new System.Windows.Forms.DataGridView();
            this.txtPagoSemanal = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPagoSemanal = new System.Windows.Forms.Label();
            this.lblMoraSemanal = new System.Windows.Forms.Label();
            this.txtMoraSemanal = new System.Windows.Forms.TextBox();
            this.lblPagoMensual = new System.Windows.Forms.Label();
            this.txtPagoMensual = new System.Windows.Forms.TextBox();
            this.lblMoraMensual = new System.Windows.Forms.Label();
            this.txtMoraMensual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagosVIP
            // 
            this.dgvPagosVIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosVIP.Location = new System.Drawing.Point(237, 32);
            this.dgvPagosVIP.Name = "dgvPagosVIP";
            this.dgvPagosVIP.Size = new System.Drawing.Size(330, 217);
            this.dgvPagosVIP.TabIndex = 0;
            // 
            // txtPagoSemanal
            // 
            this.txtPagoSemanal.Location = new System.Drawing.Point(118, 40);
            this.txtPagoSemanal.Name = "txtPagoSemanal";
            this.txtPagoSemanal.Size = new System.Drawing.Size(100, 20);
            this.txtPagoSemanal.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(35, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblPagoSemanal
            // 
            this.lblPagoSemanal.AutoSize = true;
            this.lblPagoSemanal.Location = new System.Drawing.Point(33, 43);
            this.lblPagoSemanal.Name = "lblPagoSemanal";
            this.lblPagoSemanal.Size = new System.Drawing.Size(79, 13);
            this.lblPagoSemanal.TabIndex = 3;
            this.lblPagoSemanal.Text = "Pago Semanal:";
            // 
            // lblMoraSemanal
            // 
            this.lblMoraSemanal.AutoSize = true;
            this.lblMoraSemanal.Location = new System.Drawing.Point(33, 86);
            this.lblMoraSemanal.Name = "lblMoraSemanal";
            this.lblMoraSemanal.Size = new System.Drawing.Size(78, 13);
            this.lblMoraSemanal.TabIndex = 5;
            this.lblMoraSemanal.Text = "Mora Semanal:";
            // 
            // txtMoraSemanal
            // 
            this.txtMoraSemanal.Location = new System.Drawing.Point(118, 83);
            this.txtMoraSemanal.Name = "txtMoraSemanal";
            this.txtMoraSemanal.Size = new System.Drawing.Size(100, 20);
            this.txtMoraSemanal.TabIndex = 4;
            // 
            // lblPagoMensual
            // 
            this.lblPagoMensual.AutoSize = true;
            this.lblPagoMensual.Location = new System.Drawing.Point(32, 130);
            this.lblPagoMensual.Name = "lblPagoMensual";
            this.lblPagoMensual.Size = new System.Drawing.Size(78, 13);
            this.lblPagoMensual.TabIndex = 7;
            this.lblPagoMensual.Text = "Pago Mensual:";
            // 
            // txtPagoMensual
            // 
            this.txtPagoMensual.Location = new System.Drawing.Point(118, 127);
            this.txtPagoMensual.Name = "txtPagoMensual";
            this.txtPagoMensual.Size = new System.Drawing.Size(100, 20);
            this.txtPagoMensual.TabIndex = 6;
            // 
            // lblMoraMensual
            // 
            this.lblMoraMensual.AutoSize = true;
            this.lblMoraMensual.Location = new System.Drawing.Point(33, 169);
            this.lblMoraMensual.Name = "lblMoraMensual";
            this.lblMoraMensual.Size = new System.Drawing.Size(77, 13);
            this.lblMoraMensual.TabIndex = 9;
            this.lblMoraMensual.Text = "Mora Mensual:";
            // 
            // txtMoraMensual
            // 
            this.txtMoraMensual.Location = new System.Drawing.Point(118, 166);
            this.txtMoraMensual.Name = "txtMoraMensual";
            this.txtMoraMensual.Size = new System.Drawing.Size(100, 20);
            this.txtMoraMensual.TabIndex = 8;
            // 
            // frmPagosVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 261);
            this.Controls.Add(this.lblMoraMensual);
            this.Controls.Add(this.txtMoraMensual);
            this.Controls.Add(this.lblPagoMensual);
            this.Controls.Add(this.txtPagoMensual);
            this.Controls.Add(this.lblMoraSemanal);
            this.Controls.Add(this.txtMoraSemanal);
            this.Controls.Add(this.lblPagoSemanal);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPagoSemanal);
            this.Controls.Add(this.dgvPagosVIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPagosVIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos VIP";
            this.Load += new System.EventHandler(this.frmPagosVIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagosVIP;
        private System.Windows.Forms.TextBox txtPagoSemanal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPagoSemanal;
        private System.Windows.Forms.Label lblMoraSemanal;
        private System.Windows.Forms.TextBox txtMoraSemanal;
        private System.Windows.Forms.Label lblPagoMensual;
        private System.Windows.Forms.TextBox txtPagoMensual;
        private System.Windows.Forms.Label lblMoraMensual;
        private System.Windows.Forms.TextBox txtMoraMensual;
    }
}
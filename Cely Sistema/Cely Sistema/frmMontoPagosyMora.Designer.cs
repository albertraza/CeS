namespace Cely_Sistema
{
    partial class frmMontoPagosyMora
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
            this.components = new System.ComponentModel.Container();
            this.txtPagoMensual = new System.Windows.Forms.TextBox();
            this.lblPagoMensual = new System.Windows.Forms.Label();
            this.lblPagoSemanal = new System.Windows.Forms.Label();
            this.txtPagoSemanal = new System.Windows.Forms.TextBox();
            this.lblMoraPagoMensual = new System.Windows.Forms.Label();
            this.txtMoraPagoMensual = new System.Windows.Forms.TextBox();
            this.lblMorPagoSemanal = new System.Windows.Forms.Label();
            this.txtMoraPagoSemanal = new System.Windows.Forms.TextBox();
            this.gbTarifario = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbMoraPagoMensual = new System.Windows.Forms.CheckBox();
            this.cbMoraPagoSemanal = new System.Windows.Forms.CheckBox();
            this.cbPagoSemanal = new System.Windows.Forms.CheckBox();
            this.cbPagoMensual = new System.Windows.Forms.CheckBox();
            this.verMoraPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.verMoraPagosTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerMoraPagosTableAdapter();
            this.gbTarifarioVIP = new System.Windows.Forms.GroupBox();
            this.btnModificarVIP = new System.Windows.Forms.Button();
            this.cbMoraPagoMensualVIP = new System.Windows.Forms.CheckBox();
            this.cbMoraPagoSemanalVIP = new System.Windows.Forms.CheckBox();
            this.cbPagoSemanalVIP = new System.Windows.Forms.CheckBox();
            this.cbPagoMensualVIP = new System.Windows.Forms.CheckBox();
            this.lblPagoMensualVIP = new System.Windows.Forms.Label();
            this.lblMoraPagoMensualVIP = new System.Windows.Forms.Label();
            this.txtMoraPagoMensualVIP = new System.Windows.Forms.TextBox();
            this.txtPagoMensualVIP = new System.Windows.Forms.TextBox();
            this.lblMoraPagoSemanalVIP = new System.Windows.Forms.Label();
            this.txtPagoSemanalVIP = new System.Windows.Forms.TextBox();
            this.txtMoraPagoSemanalVIP = new System.Windows.Forms.TextBox();
            this.lblPagoSemanalVIP = new System.Windows.Forms.Label();
            this.gbTarifario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verMoraPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            this.gbTarifarioVIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPagoMensual
            // 
            this.txtPagoMensual.Location = new System.Drawing.Point(100, 22);
            this.txtPagoMensual.Name = "txtPagoMensual";
            this.txtPagoMensual.Size = new System.Drawing.Size(100, 20);
            this.txtPagoMensual.TabIndex = 0;
            this.txtPagoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoMensual_KeyPress);
            // 
            // lblPagoMensual
            // 
            this.lblPagoMensual.AutoSize = true;
            this.lblPagoMensual.Location = new System.Drawing.Point(16, 25);
            this.lblPagoMensual.Name = "lblPagoMensual";
            this.lblPagoMensual.Size = new System.Drawing.Size(78, 13);
            this.lblPagoMensual.TabIndex = 2;
            this.lblPagoMensual.Text = "Pago Mensual:";
            // 
            // lblPagoSemanal
            // 
            this.lblPagoSemanal.AutoSize = true;
            this.lblPagoSemanal.Location = new System.Drawing.Point(16, 53);
            this.lblPagoSemanal.Name = "lblPagoSemanal";
            this.lblPagoSemanal.Size = new System.Drawing.Size(79, 13);
            this.lblPagoSemanal.TabIndex = 4;
            this.lblPagoSemanal.Text = "Pago Semanal:";
            // 
            // txtPagoSemanal
            // 
            this.txtPagoSemanal.Location = new System.Drawing.Point(100, 50);
            this.txtPagoSemanal.Name = "txtPagoSemanal";
            this.txtPagoSemanal.Size = new System.Drawing.Size(100, 20);
            this.txtPagoSemanal.TabIndex = 1;
            this.txtPagoSemanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoSemanal_KeyPress);
            // 
            // lblMoraPagoMensual
            // 
            this.lblMoraPagoMensual.AutoSize = true;
            this.lblMoraPagoMensual.Location = new System.Drawing.Point(17, 116);
            this.lblMoraPagoMensual.Name = "lblMoraPagoMensual";
            this.lblMoraPagoMensual.Size = new System.Drawing.Size(105, 13);
            this.lblMoraPagoMensual.TabIndex = 8;
            this.lblMoraPagoMensual.Text = "Mora Pago Mensual:";
            // 
            // txtMoraPagoMensual
            // 
            this.txtMoraPagoMensual.Location = new System.Drawing.Point(128, 113);
            this.txtMoraPagoMensual.Name = "txtMoraPagoMensual";
            this.txtMoraPagoMensual.Size = new System.Drawing.Size(72, 20);
            this.txtMoraPagoMensual.TabIndex = 3;
            this.txtMoraPagoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoraPagoMensual_KeyPress);
            // 
            // lblMorPagoSemanal
            // 
            this.lblMorPagoSemanal.AutoSize = true;
            this.lblMorPagoSemanal.Location = new System.Drawing.Point(17, 88);
            this.lblMorPagoSemanal.Name = "lblMorPagoSemanal";
            this.lblMorPagoSemanal.Size = new System.Drawing.Size(106, 13);
            this.lblMorPagoSemanal.TabIndex = 6;
            this.lblMorPagoSemanal.Text = "Mora Pago Semanal:";
            // 
            // txtMoraPagoSemanal
            // 
            this.txtMoraPagoSemanal.Location = new System.Drawing.Point(128, 85);
            this.txtMoraPagoSemanal.Name = "txtMoraPagoSemanal";
            this.txtMoraPagoSemanal.Size = new System.Drawing.Size(71, 20);
            this.txtMoraPagoSemanal.TabIndex = 2;
            this.txtMoraPagoSemanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoraPagoSemanal_KeyPress);
            // 
            // gbTarifario
            // 
            this.gbTarifario.Controls.Add(this.btnModificar);
            this.gbTarifario.Controls.Add(this.cbMoraPagoMensual);
            this.gbTarifario.Controls.Add(this.cbMoraPagoSemanal);
            this.gbTarifario.Controls.Add(this.cbPagoSemanal);
            this.gbTarifario.Controls.Add(this.cbPagoMensual);
            this.gbTarifario.Controls.Add(this.lblPagoMensual);
            this.gbTarifario.Controls.Add(this.lblMoraPagoMensual);
            this.gbTarifario.Controls.Add(this.txtMoraPagoMensual);
            this.gbTarifario.Controls.Add(this.txtPagoMensual);
            this.gbTarifario.Controls.Add(this.lblMorPagoSemanal);
            this.gbTarifario.Controls.Add(this.txtPagoSemanal);
            this.gbTarifario.Controls.Add(this.txtMoraPagoSemanal);
            this.gbTarifario.Controls.Add(this.lblPagoSemanal);
            this.gbTarifario.Location = new System.Drawing.Point(12, 12);
            this.gbTarifario.Name = "gbTarifario";
            this.gbTarifario.Size = new System.Drawing.Size(382, 158);
            this.gbTarifario.TabIndex = 0;
            this.gbTarifario.TabStop = false;
            this.gbTarifario.Text = "Tarifario Estudiante";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(265, 56);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbMoraPagoMensual
            // 
            this.cbMoraPagoMensual.AutoSize = true;
            this.cbMoraPagoMensual.Location = new System.Drawing.Point(215, 117);
            this.cbMoraPagoMensual.Name = "cbMoraPagoMensual";
            this.cbMoraPagoMensual.Size = new System.Drawing.Size(15, 14);
            this.cbMoraPagoMensual.TabIndex = 12;
            this.cbMoraPagoMensual.UseVisualStyleBackColor = true;
            this.cbMoraPagoMensual.CheckedChanged += new System.EventHandler(this.cbMoraPagoMensual_CheckedChanged);
            // 
            // cbMoraPagoSemanal
            // 
            this.cbMoraPagoSemanal.AutoSize = true;
            this.cbMoraPagoSemanal.Location = new System.Drawing.Point(215, 87);
            this.cbMoraPagoSemanal.Name = "cbMoraPagoSemanal";
            this.cbMoraPagoSemanal.Size = new System.Drawing.Size(15, 14);
            this.cbMoraPagoSemanal.TabIndex = 11;
            this.cbMoraPagoSemanal.UseVisualStyleBackColor = true;
            this.cbMoraPagoSemanal.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbPagoSemanal
            // 
            this.cbPagoSemanal.AutoSize = true;
            this.cbPagoSemanal.Location = new System.Drawing.Point(215, 53);
            this.cbPagoSemanal.Name = "cbPagoSemanal";
            this.cbPagoSemanal.Size = new System.Drawing.Size(15, 14);
            this.cbPagoSemanal.TabIndex = 10;
            this.cbPagoSemanal.UseVisualStyleBackColor = true;
            this.cbPagoSemanal.CheckedChanged += new System.EventHandler(this.cbPagoSemanal_CheckedChanged);
            // 
            // cbPagoMensual
            // 
            this.cbPagoMensual.AutoSize = true;
            this.cbPagoMensual.Location = new System.Drawing.Point(215, 24);
            this.cbPagoMensual.Name = "cbPagoMensual";
            this.cbPagoMensual.Size = new System.Drawing.Size(15, 14);
            this.cbPagoMensual.TabIndex = 9;
            this.cbPagoMensual.UseVisualStyleBackColor = true;
            this.cbPagoMensual.CheckedChanged += new System.EventHandler(this.cbPagoMensual_CheckedChanged);
            // 
            // verMoraPagosBindingSource
            // 
            this.verMoraPagosBindingSource.DataMember = "VerMoraPagos";
            this.verMoraPagosBindingSource.DataSource = this.celyDBDataSet;
            // 
            // celyDBDataSet
            // 
            this.celyDBDataSet.DataSetName = "CelyDBDataSet";
            this.celyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verMoraPagosTableAdapter
            // 
            this.verMoraPagosTableAdapter.ClearBeforeFill = true;
            // 
            // gbTarifarioVIP
            // 
            this.gbTarifarioVIP.BackColor = System.Drawing.Color.Wheat;
            this.gbTarifarioVIP.Controls.Add(this.btnModificarVIP);
            this.gbTarifarioVIP.Controls.Add(this.cbMoraPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.cbMoraPagoSemanalVIP);
            this.gbTarifarioVIP.Controls.Add(this.cbPagoSemanalVIP);
            this.gbTarifarioVIP.Controls.Add(this.cbPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.lblPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.lblMoraPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.txtMoraPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.txtPagoMensualVIP);
            this.gbTarifarioVIP.Controls.Add(this.lblMoraPagoSemanalVIP);
            this.gbTarifarioVIP.Controls.Add(this.txtPagoSemanalVIP);
            this.gbTarifarioVIP.Controls.Add(this.txtMoraPagoSemanalVIP);
            this.gbTarifarioVIP.Controls.Add(this.lblPagoSemanalVIP);
            this.gbTarifarioVIP.Location = new System.Drawing.Point(12, 176);
            this.gbTarifarioVIP.Name = "gbTarifarioVIP";
            this.gbTarifarioVIP.Size = new System.Drawing.Size(382, 158);
            this.gbTarifarioVIP.TabIndex = 1;
            this.gbTarifarioVIP.TabStop = false;
            this.gbTarifarioVIP.Text = "Tarifario Estudiantes VIP";
            // 
            // btnModificarVIP
            // 
            this.btnModificarVIP.Location = new System.Drawing.Point(265, 56);
            this.btnModificarVIP.Name = "btnModificarVIP";
            this.btnModificarVIP.Size = new System.Drawing.Size(84, 45);
            this.btnModificarVIP.TabIndex = 1;
            this.btnModificarVIP.Text = "Modificar";
            this.btnModificarVIP.UseVisualStyleBackColor = true;
            this.btnModificarVIP.Click += new System.EventHandler(this.btnModificarVIP_Click);
            // 
            // cbMoraPagoMensualVIP
            // 
            this.cbMoraPagoMensualVIP.AutoSize = true;
            this.cbMoraPagoMensualVIP.Location = new System.Drawing.Point(215, 117);
            this.cbMoraPagoMensualVIP.Name = "cbMoraPagoMensualVIP";
            this.cbMoraPagoMensualVIP.Size = new System.Drawing.Size(15, 14);
            this.cbMoraPagoMensualVIP.TabIndex = 12;
            this.cbMoraPagoMensualVIP.UseVisualStyleBackColor = true;
            this.cbMoraPagoMensualVIP.CheckedChanged += new System.EventHandler(this.cbMoraPagoMensualVIP_CheckedChanged);
            // 
            // cbMoraPagoSemanalVIP
            // 
            this.cbMoraPagoSemanalVIP.AutoSize = true;
            this.cbMoraPagoSemanalVIP.Location = new System.Drawing.Point(215, 87);
            this.cbMoraPagoSemanalVIP.Name = "cbMoraPagoSemanalVIP";
            this.cbMoraPagoSemanalVIP.Size = new System.Drawing.Size(15, 14);
            this.cbMoraPagoSemanalVIP.TabIndex = 11;
            this.cbMoraPagoSemanalVIP.UseVisualStyleBackColor = true;
            this.cbMoraPagoSemanalVIP.CheckedChanged += new System.EventHandler(this.cbMoraPagoSemanalVIP_CheckedChanged);
            // 
            // cbPagoSemanalVIP
            // 
            this.cbPagoSemanalVIP.AutoSize = true;
            this.cbPagoSemanalVIP.Location = new System.Drawing.Point(215, 53);
            this.cbPagoSemanalVIP.Name = "cbPagoSemanalVIP";
            this.cbPagoSemanalVIP.Size = new System.Drawing.Size(15, 14);
            this.cbPagoSemanalVIP.TabIndex = 10;
            this.cbPagoSemanalVIP.UseVisualStyleBackColor = true;
            this.cbPagoSemanalVIP.CheckedChanged += new System.EventHandler(this.cbPagoSemanalVIP_CheckedChanged);
            // 
            // cbPagoMensualVIP
            // 
            this.cbPagoMensualVIP.AutoSize = true;
            this.cbPagoMensualVIP.Location = new System.Drawing.Point(215, 24);
            this.cbPagoMensualVIP.Name = "cbPagoMensualVIP";
            this.cbPagoMensualVIP.Size = new System.Drawing.Size(15, 14);
            this.cbPagoMensualVIP.TabIndex = 9;
            this.cbPagoMensualVIP.UseVisualStyleBackColor = true;
            this.cbPagoMensualVIP.CheckedChanged += new System.EventHandler(this.cbPagoMensualVIP_CheckedChanged);
            // 
            // lblPagoMensualVIP
            // 
            this.lblPagoMensualVIP.AutoSize = true;
            this.lblPagoMensualVIP.Location = new System.Drawing.Point(16, 25);
            this.lblPagoMensualVIP.Name = "lblPagoMensualVIP";
            this.lblPagoMensualVIP.Size = new System.Drawing.Size(78, 13);
            this.lblPagoMensualVIP.TabIndex = 2;
            this.lblPagoMensualVIP.Text = "Pago Mensual:";
            // 
            // lblMoraPagoMensualVIP
            // 
            this.lblMoraPagoMensualVIP.AutoSize = true;
            this.lblMoraPagoMensualVIP.Location = new System.Drawing.Point(17, 116);
            this.lblMoraPagoMensualVIP.Name = "lblMoraPagoMensualVIP";
            this.lblMoraPagoMensualVIP.Size = new System.Drawing.Size(105, 13);
            this.lblMoraPagoMensualVIP.TabIndex = 8;
            this.lblMoraPagoMensualVIP.Text = "Mora Pago Mensual:";
            // 
            // txtMoraPagoMensualVIP
            // 
            this.txtMoraPagoMensualVIP.Location = new System.Drawing.Point(128, 113);
            this.txtMoraPagoMensualVIP.Name = "txtMoraPagoMensualVIP";
            this.txtMoraPagoMensualVIP.Size = new System.Drawing.Size(72, 20);
            this.txtMoraPagoMensualVIP.TabIndex = 3;
            // 
            // txtPagoMensualVIP
            // 
            this.txtPagoMensualVIP.Location = new System.Drawing.Point(100, 22);
            this.txtPagoMensualVIP.Name = "txtPagoMensualVIP";
            this.txtPagoMensualVIP.Size = new System.Drawing.Size(100, 20);
            this.txtPagoMensualVIP.TabIndex = 0;
            // 
            // lblMoraPagoSemanalVIP
            // 
            this.lblMoraPagoSemanalVIP.AutoSize = true;
            this.lblMoraPagoSemanalVIP.Location = new System.Drawing.Point(17, 88);
            this.lblMoraPagoSemanalVIP.Name = "lblMoraPagoSemanalVIP";
            this.lblMoraPagoSemanalVIP.Size = new System.Drawing.Size(106, 13);
            this.lblMoraPagoSemanalVIP.TabIndex = 6;
            this.lblMoraPagoSemanalVIP.Text = "Mora Pago Semanal:";
            // 
            // txtPagoSemanalVIP
            // 
            this.txtPagoSemanalVIP.Location = new System.Drawing.Point(100, 50);
            this.txtPagoSemanalVIP.Name = "txtPagoSemanalVIP";
            this.txtPagoSemanalVIP.Size = new System.Drawing.Size(100, 20);
            this.txtPagoSemanalVIP.TabIndex = 1;
            // 
            // txtMoraPagoSemanalVIP
            // 
            this.txtMoraPagoSemanalVIP.Location = new System.Drawing.Point(128, 85);
            this.txtMoraPagoSemanalVIP.Name = "txtMoraPagoSemanalVIP";
            this.txtMoraPagoSemanalVIP.Size = new System.Drawing.Size(71, 20);
            this.txtMoraPagoSemanalVIP.TabIndex = 2;
            // 
            // lblPagoSemanalVIP
            // 
            this.lblPagoSemanalVIP.AutoSize = true;
            this.lblPagoSemanalVIP.Location = new System.Drawing.Point(16, 53);
            this.lblPagoSemanalVIP.Name = "lblPagoSemanalVIP";
            this.lblPagoSemanalVIP.Size = new System.Drawing.Size(79, 13);
            this.lblPagoSemanalVIP.TabIndex = 4;
            this.lblPagoSemanalVIP.Text = "Pago Semanal:";
            // 
            // frmMontoPagosyMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 348);
            this.Controls.Add(this.gbTarifarioVIP);
            this.Controls.Add(this.gbTarifario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMontoPagosyMora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos Y Mora";
            this.Load += new System.EventHandler(this.frmMontoPagosyMora_Load);
            this.gbTarifario.ResumeLayout(false);
            this.gbTarifario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verMoraPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).EndInit();
            this.gbTarifarioVIP.ResumeLayout(false);
            this.gbTarifarioVIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPagoMensual;
        private System.Windows.Forms.Label lblPagoMensual;
        private System.Windows.Forms.Label lblPagoSemanal;
        private System.Windows.Forms.TextBox txtPagoSemanal;
        private System.Windows.Forms.Label lblMoraPagoMensual;
        private System.Windows.Forms.TextBox txtMoraPagoMensual;
        private System.Windows.Forms.Label lblMorPagoSemanal;
        private System.Windows.Forms.TextBox txtMoraPagoSemanal;
        private System.Windows.Forms.GroupBox gbTarifario;
        private System.Windows.Forms.BindingSource verMoraPagosBindingSource;
        private CelyDBDataSet celyDBDataSet;
        private CelyDBDataSetTableAdapters.VerMoraPagosTableAdapter verMoraPagosTableAdapter;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox cbPagoMensual;
        private System.Windows.Forms.CheckBox cbMoraPagoSemanal;
        private System.Windows.Forms.CheckBox cbPagoSemanal;
        private System.Windows.Forms.CheckBox cbMoraPagoMensual;
        private System.Windows.Forms.GroupBox gbTarifarioVIP;
        private System.Windows.Forms.Button btnModificarVIP;
        private System.Windows.Forms.CheckBox cbMoraPagoMensualVIP;
        private System.Windows.Forms.CheckBox cbMoraPagoSemanalVIP;
        private System.Windows.Forms.CheckBox cbPagoSemanalVIP;
        private System.Windows.Forms.CheckBox cbPagoMensualVIP;
        private System.Windows.Forms.Label lblPagoMensualVIP;
        private System.Windows.Forms.Label lblMoraPagoMensualVIP;
        private System.Windows.Forms.TextBox txtMoraPagoMensualVIP;
        private System.Windows.Forms.TextBox txtPagoMensualVIP;
        private System.Windows.Forms.Label lblMoraPagoSemanalVIP;
        private System.Windows.Forms.TextBox txtPagoSemanalVIP;
        private System.Windows.Forms.TextBox txtMoraPagoSemanalVIP;
        private System.Windows.Forms.Label lblPagoSemanalVIP;
    }
}
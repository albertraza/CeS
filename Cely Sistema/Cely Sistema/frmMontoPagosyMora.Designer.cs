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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtPagoMensual = new System.Windows.Forms.TextBox();
            this.lblPagoMensual = new System.Windows.Forms.Label();
            this.lblPagoSemanal = new System.Windows.Forms.Label();
            this.txtPagoSemanal = new System.Windows.Forms.TextBox();
            this.lblMoraPagoMensual = new System.Windows.Forms.Label();
            this.txtMoraPagoMensual = new System.Windows.Forms.TextBox();
            this.lblMorPagoSemanal = new System.Windows.Forms.Label();
            this.txtMoraPagoSemanal = new System.Windows.Forms.TextBox();
            this.gbTarifario = new System.Windows.Forms.GroupBox();
            this.verMoraPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.verMoraPagosTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerMoraPagosTableAdapter();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbTarifario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verMoraPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(234, 25);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(443, 111);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
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
            this.gbTarifario.Controls.Add(this.lblPagoMensual);
            this.gbTarifario.Controls.Add(this.lblMoraPagoMensual);
            this.gbTarifario.Controls.Add(this.dgvTabla);
            this.gbTarifario.Controls.Add(this.txtMoraPagoMensual);
            this.gbTarifario.Controls.Add(this.txtPagoMensual);
            this.gbTarifario.Controls.Add(this.lblMorPagoSemanal);
            this.gbTarifario.Controls.Add(this.txtPagoSemanal);
            this.gbTarifario.Controls.Add(this.txtMoraPagoSemanal);
            this.gbTarifario.Controls.Add(this.lblPagoSemanal);
            this.gbTarifario.Location = new System.Drawing.Point(12, 12);
            this.gbTarifario.Name = "gbTarifario";
            this.gbTarifario.Size = new System.Drawing.Size(696, 158);
            this.gbTarifario.TabIndex = 0;
            this.gbTarifario.TabStop = false;
            this.gbTarifario.Text = "Tarifa";
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(32, 178);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmMontoPagosyMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 213);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbTarifario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMontoPagosyMora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos Y Mora";
            this.Load += new System.EventHandler(this.frmMontoPagosyMora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbTarifario.ResumeLayout(false);
            this.gbTarifario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verMoraPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celyDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
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
    }
}
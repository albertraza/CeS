namespace Cely_Sistema
{
    partial class frmContratoMensual
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporting1 = new Cely_Sistema.Reporting();
            this.contratoMensualTableAdapter1 = new Cely_Sistema.ReportingTableAdapters.ContratoMensualTableAdapter();
            this.Reporting = new Cely_Sistema.Reporting();
            this.ContratoMensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContratoMensualTableAdapter = new Cely_Sistema.ReportingTableAdapters.ContratoMensualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoMensualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Contrato";
            reportDataSource1.Value = this.ContratoMensualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpContratoMensual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporting1
            // 
            this.reporting1.DataSetName = "Reporting";
            this.reporting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratoMensualTableAdapter1
            // 
            this.contratoMensualTableAdapter1.ClearBeforeFill = true;
            // 
            // Reporting
            // 
            this.Reporting.DataSetName = "Reporting";
            this.Reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContratoMensualBindingSource
            // 
            this.ContratoMensualBindingSource.DataMember = "ContratoMensual";
            this.ContratoMensualBindingSource.DataSource = this.Reporting;
            // 
            // ContratoMensualTableAdapter
            // 
            this.ContratoMensualTableAdapter.ClearBeforeFill = true;
            // 
            // frmContratoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 532);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContratoMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.frmContratoMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoMensualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reporting reporting1;
        private ReportingTableAdapters.ContratoMensualTableAdapter contratoMensualTableAdapter1;
        private System.Windows.Forms.BindingSource ContratoMensualBindingSource;
        private Reporting Reporting;
        private ReportingTableAdapters.ContratoMensualTableAdapter ContratoMensualTableAdapter;
    }
}
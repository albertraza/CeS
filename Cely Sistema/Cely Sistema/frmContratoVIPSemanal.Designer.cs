namespace Cely_Sistema
{
    partial class frmContratoVIPSemanal
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
            this.contratoVIPSemanalTableAdapter1 = new Cely_Sistema.ReportingTableAdapters.ContratoVIPSemanalTableAdapter();
            this.reporting1 = new Cely_Sistema.Reporting();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporting = new Cely_Sistema.Reporting();
            this.ContratoVIPSemanalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContratoVIPSemanalTableAdapter = new Cely_Sistema.ReportingTableAdapters.ContratoVIPSemanalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoVIPSemanalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contratoVIPSemanalTableAdapter1
            // 
            this.contratoVIPSemanalTableAdapter1.ClearBeforeFill = true;
            // 
            // reporting1
            // 
            this.reporting1.DataSetName = "Reporting";
            this.reporting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Contrato";
            reportDataSource1.Value = this.ContratoVIPSemanalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpContratoVIPSemanal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporting
            // 
            this.Reporting.DataSetName = "Reporting";
            this.Reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContratoVIPSemanalBindingSource
            // 
            this.ContratoVIPSemanalBindingSource.DataMember = "ContratoVIPSemanal";
            this.ContratoVIPSemanalBindingSource.DataSource = this.Reporting;
            // 
            // ContratoVIPSemanalTableAdapter
            // 
            this.ContratoVIPSemanalTableAdapter.ClearBeforeFill = true;
            // 
            // frmContratoVIPSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 532);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContratoVIPSemanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.frmContratoVIPSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoVIPSemanalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportingTableAdapters.ContratoVIPSemanalTableAdapter contratoVIPSemanalTableAdapter1;
        private Reporting reporting1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContratoVIPSemanalBindingSource;
        private Reporting Reporting;
        private ReportingTableAdapters.ContratoVIPSemanalTableAdapter ContratoVIPSemanalTableAdapter;
    }
}
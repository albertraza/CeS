namespace Cely_Sistema
{
    partial class frmContratoSemanal
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
            this.contratoSemanalTableAdapter1 = new Cely_Sistema.ReportingTableAdapters.ContratoSemanalTableAdapter();
            this.reporting1 = new Cely_Sistema.Reporting();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Reporting = new Cely_Sistema.Reporting();
            this.ContratoSemanalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContratoSemanalTableAdapter = new Cely_Sistema.ReportingTableAdapters.ContratoSemanalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoSemanalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Contrato";
            reportDataSource1.Value = this.ContratoSemanalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpContratoSemanal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // contratoSemanalTableAdapter1
            // 
            this.contratoSemanalTableAdapter1.ClearBeforeFill = true;
            // 
            // reporting1
            // 
            this.reporting1.DataSetName = "Reporting";
            this.reporting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.reporting1;
            this.bindingSource1.Position = 0;
            // 
            // Reporting
            // 
            this.Reporting.DataSetName = "Reporting";
            this.Reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContratoSemanalBindingSource
            // 
            this.ContratoSemanalBindingSource.DataMember = "ContratoSemanal";
            this.ContratoSemanalBindingSource.DataSource = this.Reporting;
            // 
            // ContratoSemanalTableAdapter
            // 
            this.ContratoSemanalTableAdapter.ClearBeforeFill = true;
            // 
            // frmContratoSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 532);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContratoSemanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.frmContratoSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoSemanalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportingTableAdapters.ContratoSemanalTableAdapter contratoSemanalTableAdapter1;
        private Reporting reporting1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource ContratoSemanalBindingSource;
        private Reporting Reporting;
        private ReportingTableAdapters.ContratoSemanalTableAdapter ContratoSemanalTableAdapter;
    }
}
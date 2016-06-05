namespace Cely_Sistema
{
    partial class frmReporteGanancias
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
            this.Reporting = new Cely_Sistema.Reporting();
            this.ReporteGananciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteGananciasTableAdapter = new Cely_Sistema.ReportingTableAdapters.ReporteGananciasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGananciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Ganancias";
            reportDataSource1.Value = this.ReporteGananciasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.ReporteGanancias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(926, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporting
            // 
            this.Reporting.DataSetName = "Reporting";
            this.Reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteGananciasBindingSource
            // 
            this.ReporteGananciasBindingSource.DataMember = "ReporteGanancias";
            this.ReporteGananciasBindingSource.DataSource = this.Reporting;
            // 
            // ReporteGananciasTableAdapter
            // 
            this.ReporteGananciasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 538);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReporteGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ganancias";
            this.Load += new System.EventHandler(this.frmReporteGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGananciasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteGananciasBindingSource;
        private Reporting Reporting;
        private ReportingTableAdapters.ReporteGananciasTableAdapter ReporteGananciasTableAdapter;
    }
}
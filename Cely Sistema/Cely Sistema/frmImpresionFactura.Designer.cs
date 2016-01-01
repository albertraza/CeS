namespace Cely_Sistema
{
    partial class frmImpresionFactura
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
            this.FacturaEstudiantilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CelyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaEstudiantilTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.FacturaEstudiantilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEstudiantilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaEstudiantilBindingSource
            // 
            this.FacturaEstudiantilBindingSource.DataMember = "FacturaEstudiantil";
            this.FacturaEstudiantilBindingSource.DataSource = this.CelyDBDataSet;
            // 
            // CelyDBDataSet
            // 
            this.CelyDBDataSet.DataSetName = "CelyDBDataSet";
            this.CelyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FacturaEstudiante";
            reportDataSource1.Value = this.FacturaEstudiantilBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(934, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaEstudiantilTableAdapter
            // 
            this.FacturaEstudiantilTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 558);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmImpresionFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmImpresionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEstudiantilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaEstudiantilBindingSource;
        private CelyDBDataSet CelyDBDataSet;
        private CelyDBDataSetTableAdapters.FacturaEstudiantilTableAdapter FacturaEstudiantilTableAdapter;
    }
}
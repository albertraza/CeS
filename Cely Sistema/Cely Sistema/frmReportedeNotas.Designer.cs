namespace Cely_Sistema
{
    partial class frmReportedeNotas
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
            this.ReporteCalificacionesTo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CelyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.ReporteCalificacionesToBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteCalificacionesToTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.ReporteCalificacionesToTableAdapter();
            this.ReporteCalificacionesTo1TableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.ReporteCalificacionesTo1TableAdapter();
            this.ReporteNotasDeHastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteNotasDeHastaTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.ReporteNotasDeHastaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCalificacionesTo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCalificacionesToBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteNotasDeHastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteCalificacionesTo1BindingSource
            // 
            this.ReporteCalificacionesTo1BindingSource.DataMember = "ReporteCalificacionesTo1";
            this.ReporteCalificacionesTo1BindingSource.DataSource = this.CelyDBDataSet;
            // 
            // CelyDBDataSet
            // 
            this.CelyDBDataSet.DataSetName = "CelyDBDataSet";
            this.CelyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteCalificacionesToBindingSource
            // 
            this.ReporteCalificacionesToBindingSource.DataMember = "ReporteCalificacionesTo";
            this.ReporteCalificacionesToBindingSource.DataSource = this.CelyDBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSourceCely";
            reportDataSource1.Value = this.ReporteNotasDeHastaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpCalificaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1041, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteCalificacionesToTableAdapter
            // 
            this.ReporteCalificacionesToTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCalificacionesTo1TableAdapter
            // 
            this.ReporteCalificacionesTo1TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteNotasDeHastaBindingSource
            // 
            this.ReporteNotasDeHastaBindingSource.DataMember = "ReporteNotasDeHasta";
            this.ReporteNotasDeHastaBindingSource.DataSource = this.CelyDBDataSet;
            // 
            // ReporteNotasDeHastaTableAdapter
            // 
            this.ReporteNotasDeHastaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportedeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 521);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReportedeNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Notas";
            this.Load += new System.EventHandler(this.frmReportedeNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCalificacionesTo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCalificacionesToBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteNotasDeHastaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteCalificacionesToBindingSource;
        private CelyDBDataSet CelyDBDataSet;
        private CelyDBDataSetTableAdapters.ReporteCalificacionesToTableAdapter ReporteCalificacionesToTableAdapter;
        private System.Windows.Forms.BindingSource ReporteCalificacionesTo1BindingSource;
        private CelyDBDataSetTableAdapters.ReporteCalificacionesTo1TableAdapter ReporteCalificacionesTo1TableAdapter;
        private System.Windows.Forms.BindingSource ReporteNotasDeHastaBindingSource;
        private CelyDBDataSetTableAdapters.ReporteNotasDeHastaTableAdapter ReporteNotasDeHastaTableAdapter;
    }
}
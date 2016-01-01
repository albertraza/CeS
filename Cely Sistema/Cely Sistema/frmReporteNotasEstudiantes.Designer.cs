namespace Cely_Sistema
{
    partial class frmReporteNotasEstudiantes
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
            this.VerReporteNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CelyDBDataSet = new Cely_Sistema.CelyDBDataSet();
            this.VerReporteNotasTableAdapter = new Cely_Sistema.CelyDBDataSetTableAdapters.VerReporteNotasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VerReporteNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VerReporteNotasBindingSource
            // 
            this.VerReporteNotasBindingSource.DataMember = "VerReporteNotas";
            this.VerReporteNotasBindingSource.DataSource = this.CelyDBDataSet;
            // 
            // CelyDBDataSet
            // 
            this.CelyDBDataSet.DataSetName = "CelyDBDataSet";
            this.CelyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VerReporteNotasTableAdapter
            // 
            this.VerReporteNotasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VerReporteNotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cely_Sistema.rpCalificacionesEstudiantiles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1064, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteNotasEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 583);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteNotasEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Notas";
            this.Load += new System.EventHandler(this.frmReporteNotasEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VerReporteNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelyDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource VerReporteNotasBindingSource;
        private CelyDBDataSet CelyDBDataSet;
        private CelyDBDataSetTableAdapters.VerReporteNotasTableAdapter VerReporteNotasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}
namespace FlavorsOfTheHouse.Reportes
{
    partial class ReporteFacturacion
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
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFactura = new FlavorsOfTheHouse.Reportes.DataSetFactura();
            this.dataSetFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetFacturaTableAdapters.DataTableTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.dataSetFactura;
            // 
            // dataSetFactura
            // 
            this.dataSetFactura.DataSetName = "DataSetFactura";
            this.dataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetFacturaBindingSource
            // 
            this.dataSetFacturaBindingSource.DataSource = this.dataSetFactura;
            this.dataSetFacturaBindingSource.Position = 0;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(944, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFacturacion";
            this.Text = "Reporte de facturacion";
            this.Load += new System.EventHandler(this.ReporteFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSetFactura dataSetFactura;
        private System.Windows.Forms.BindingSource dataSetFacturaBindingSource;
        private DataSetFacturaTableAdapters.DataTableTableAdapter DataTableTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
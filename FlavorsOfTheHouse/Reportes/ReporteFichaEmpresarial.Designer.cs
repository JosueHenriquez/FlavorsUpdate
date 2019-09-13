namespace FlavorsOfTheHouse.Reportes
{
    partial class ReporteFichaEmpresarial
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
            this.DataSetFichaEmpresa = new FlavorsOfTheHouse.Reportes.DataSetFichaEmpresa();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetFichaEmpresaTableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFichaEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(940, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetFichaEmpresa
            // 
            this.DataSetFichaEmpresa.DataSetName = "DataSetFichaEmpresa";
            this.DataSetFichaEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSetFichaEmpresa;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFichaEmpresarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFichaEmpresarial";
            this.Text = "ReporteFichaEmpresarial";
            this.Load += new System.EventHandler(this.ReporteFichaEmpresarial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFichaEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSetFichaEmpresa DataSetFichaEmpresa;
        private DataSetFichaEmpresaTableAdapters.DataTableTableAdapter DataTableTableAdapter;
    }
}
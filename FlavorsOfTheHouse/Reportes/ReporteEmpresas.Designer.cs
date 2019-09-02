namespace FlavorsOfTheHouse.Reportes
{
    partial class ReporteEmpresas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEmpresa = new FlavorsOfTheHouse.Reportes.DataSetEmpresa();
            this.tbempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbempresaTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetEmpresaTableAdapters.tbempresaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbempresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 506);
            this.panel1.TabIndex = 1;
            // 
            // reportEmpresa
            // 
            this.reportEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetEmpresa";
            reportDataSource2.Value = this.tbempresaBindingSource;
            this.reportEmpresa.LocalReport.DataSources.Add(reportDataSource2);
            this.reportEmpresa.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report2.rdlc";
            this.reportEmpresa.Location = new System.Drawing.Point(0, 0);
            this.reportEmpresa.Name = "reportEmpresa";
            this.reportEmpresa.Size = new System.Drawing.Size(812, 506);
            this.reportEmpresa.TabIndex = 0;
            // 
            // DataSetEmpresa
            // 
            this.DataSetEmpresa.DataSetName = "DataSetEmpresa";
            this.DataSetEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbempresaBindingSource
            // 
            this.tbempresaBindingSource.DataMember = "tbempresa";
            this.tbempresaBindingSource.DataSource = this.DataSetEmpresa;
            // 
            // tbempresaTableAdapter
            // 
            this.tbempresaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReporteEmpresas";
            this.Text = "Reporte de empresas";
            this.Load += new System.EventHandler(this.ReporteEmpresas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbempresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportEmpresa;
        private System.Windows.Forms.BindingSource tbempresaBindingSource;
        private DataSetEmpresa DataSetEmpresa;
        private DataSetEmpresaTableAdapters.tbempresaTableAdapter tbempresaTableAdapter;
    }
}
namespace FlavorsOfTheHouse.Reportes
{
    partial class ReporteProductos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnGeneral = new System.Windows.Forms.Button();
            this.tbproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetProducto = new FlavorsOfTheHouse.Reportes.DataSetProducto();
            this.tbproductoTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetProductoTableAdapters.tbproductoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 483);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProductos";
            reportDataSource1.Value = this.tbproductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(927, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija la empresa que desea visualizar:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(253, 1);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(276, 21);
            this.cmbEmpresa.TabIndex = 3;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(535, 1);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(124, 23);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar Productos";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.Location = new System.Drawing.Point(665, 1);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Size = new System.Drawing.Size(141, 23);
            this.BtnGeneral.TabIndex = 4;
            this.BtnGeneral.Text = "Ver todos los productos";
            this.BtnGeneral.UseVisualStyleBackColor = true;
            this.BtnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            // 
            // tbproductoBindingSource
            // 
            this.tbproductoBindingSource.DataMember = "tbproducto";
            this.tbproductoBindingSource.DataSource = this.DataSetProducto;
            // 
            // DataSetProducto
            // 
            this.DataSetProducto.DataSetName = "DataSetProducto";
            this.DataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbproductoTableAdapter
            // 
            this.tbproductoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.BtnGeneral);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbproductoBindingSource;
        private DataSetProducto DataSetProducto;
        private DataSetProductoTableAdapters.tbproductoTableAdapter tbproductoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnGeneral;
    }
}
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnGeneral = new System.Windows.Forms.Button();
            this.tbempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEmpresa = new FlavorsOfTheHouse.Reportes.DataSetEmpresa();
            this.tbempresaTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetEmpresaTableAdapters.tbempresaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbempresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).BeginInit();
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
            reportDataSource4.Name = "DataSetEmpresa";
            reportDataSource4.Value = this.tbempresaBindingSource;
            this.reportEmpresa.LocalReport.DataSources.Add(reportDataSource4);
            this.reportEmpresa.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report2.rdlc";
            this.reportEmpresa.Location = new System.Drawing.Point(0, 0);
            this.reportEmpresa.Name = "reportEmpresa";
            this.reportEmpresa.Size = new System.Drawing.Size(812, 506);
            this.reportEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija una opción para generar el reporte: ";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(206, 1);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(274, 21);
            this.cmbEmpresa.TabIndex = 3;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.ForeColor = System.Drawing.Color.White;
            this.BtnFiltrar.Location = new System.Drawing.Point(486, 0);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(135, 23);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar reporte";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BtnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneral.ForeColor = System.Drawing.Color.White;
            this.BtnGeneral.Location = new System.Drawing.Point(627, 0);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Size = new System.Drawing.Size(135, 23);
            this.BtnGeneral.TabIndex = 4;
            this.BtnGeneral.Text = "Reporte General";
            this.BtnGeneral.UseVisualStyleBackColor = false;
            this.BtnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            // 
            // tbempresaBindingSource
            // 
            this.tbempresaBindingSource.DataMember = "tbempresa";
            this.tbempresaBindingSource.DataSource = this.DataSetEmpresa;
            // 
            // DataSetEmpresa
            // 
            this.DataSetEmpresa.DataSetName = "DataSetEmpresa";
            this.DataSetEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Controls.Add(this.BtnGeneral);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReporteEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de empresas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteEmpresas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbempresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnGeneral;
    }
}
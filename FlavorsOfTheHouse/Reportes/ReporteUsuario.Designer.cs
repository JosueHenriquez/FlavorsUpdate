namespace FlavorsOfTheHouse.Reportes
{
    partial class ReporteUsuario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetUsuarios = new FlavorsOfTheHouse.Reportes.DataSetUsuarios();
            this.DataTableUsuariosTableAdapter = new FlavorsOfTheHouse.Reportes.DataSetUsuariosTableAdapters.DataTableUsuariosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoUsuarios = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnGeneral = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 396);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetUsuarios";
            reportDataSource5.Value = this.DataTableUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FlavorsOfTheHouse.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(877, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableUsuariosBindingSource
            // 
            this.DataTableUsuariosBindingSource.DataMember = "DataTableUsuarios";
            this.DataTableUsuariosBindingSource.DataSource = this.DataSetUsuarios;
            // 
            // DataSetUsuarios
            // 
            this.DataSetUsuarios.DataSetName = "DataSetUsuarios";
            this.DataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableUsuariosTableAdapter
            // 
            this.DataTableUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija que tipo de usuarios desea visualizar:";
            // 
            // cmbTipoUsuarios
            // 
            this.cmbTipoUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuarios.FormattingEnabled = true;
            this.cmbTipoUsuarios.Location = new System.Drawing.Point(217, 1);
            this.cmbTipoUsuarios.Name = "cmbTipoUsuarios";
            this.cmbTipoUsuarios.Size = new System.Drawing.Size(233, 21);
            this.cmbTipoUsuarios.TabIndex = 3;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.White;
            this.BtnFiltrar.Location = new System.Drawing.Point(456, 0);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(145, 23);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar usuarios";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneral.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeneral.ForeColor = System.Drawing.Color.White;
            this.BtnGeneral.Location = new System.Drawing.Point(607, 0);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Size = new System.Drawing.Size(145, 23);
            this.BtnGeneral.TabIndex = 4;
            this.BtnGeneral.Text = "Ver todos los usuarios";
            this.BtnGeneral.UseVisualStyleBackColor = false;
            this.BtnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            // 
            // ReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 420);
            this.Controls.Add(this.BtnGeneral);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.cmbTipoUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReporteUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableUsuariosBindingSource;
        private DataSetUsuarios DataSetUsuarios;
        private DataSetUsuariosTableAdapters.DataTableUsuariosTableAdapter DataTableUsuariosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoUsuarios;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnGeneral;
    }
}
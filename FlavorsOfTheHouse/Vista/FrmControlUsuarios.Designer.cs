namespace FlavorsOfTheHouse.Vista
{
    partial class FrmControlUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrarFormulario = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.ToolStripTextBox();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnReporte = new System.Windows.Forms.ToolStripButton();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.maskDui = new System.Windows.Forms.MaskedTextBox();
            this.radCarne = new System.Windows.Forms.RadioButton();
            this.radDui = new System.Windows.Forms.RadioButton();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpMantenimientos = new System.Windows.Forms.GroupBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnReestablecer = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.OpenCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.chkVerUsuarios = new System.Windows.Forms.CheckBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpMantenimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnCerrarFormulario,
            this.txtId,
            this.txtBuscar,
            this.BtnBuscar,
            this.BtnReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1055, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(110, 22);
            this.toolStripLabel1.Text = "Control de usuarios";
            // 
            // BtnCerrarFormulario
            // 
            this.BtnCerrarFormulario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrarFormulario.Image = global::FlavorsOfTheHouse.Properties.Resources.back_arrow;
            this.BtnCerrarFormulario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrarFormulario.Name = "BtnCerrarFormulario";
            this.BtnCerrarFormulario.Size = new System.Drawing.Size(118, 22);
            this.BtnCerrarFormulario.Text = "Cerrar formulario";
            this.BtnCerrarFormulario.Click += new System.EventHandler(this.BtnCerrarFormulario_Click);
            // 
            // txtId
            // 
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 25);
            this.txtId.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 25);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::FlavorsOfTheHouse.Properties.Resources.searching_magnifying_glass;
            this.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 22);
            this.BtnBuscar.Text = "Buscar Usuario";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Image = global::FlavorsOfTheHouse.Properties.Resources.clipboard_paste_button;
            this.BtnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(174, 22);
            this.BtnReporte.Text = "Reporte General de usuarios";
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExaminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar.Location = new System.Drawing.Point(886, 247);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(128, 29);
            this.BtnExaminar.TabIndex = 13;
            this.BtnExaminar.Text = "Cargar Imagen";
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(584, 107);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(259, 23);
            this.cmbTipoUsuario.TabIndex = 9;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(34, 155);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(255, 23);
            this.cmbEstado.TabIndex = 10;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(309, 107);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(257, 23);
            this.cmbEmpresa.TabIndex = 8;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(36, 108);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(259, 24);
            this.dtNacimiento.TabIndex = 7;
            // 
            // maskDui
            // 
            this.maskDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskDui.Location = new System.Drawing.Point(585, 57);
            this.maskDui.Mask = "00000000-0";
            this.maskDui.Name = "maskDui";
            this.maskDui.Size = new System.Drawing.Size(258, 24);
            this.maskDui.TabIndex = 5;
            // 
            // radCarne
            // 
            this.radCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCarne.AutoSize = true;
            this.radCarne.Location = new System.Drawing.Point(737, 33);
            this.radCarne.Name = "radCarne";
            this.radCarne.Size = new System.Drawing.Size(65, 21);
            this.radCarne.TabIndex = 4;
            this.radCarne.TabStop = true;
            this.radCarne.Text = "CARNÉ";
            this.radCarne.UseVisualStyleBackColor = true;
            this.radCarne.CheckedChanged += new System.EventHandler(this.radCarne_CheckedChanged);
            // 
            // radDui
            // 
            this.radDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDui.AutoSize = true;
            this.radDui.Location = new System.Drawing.Point(669, 31);
            this.radDui.Name = "radDui";
            this.radDui.Size = new System.Drawing.Size(48, 21);
            this.radDui.TabIndex = 3;
            this.radDui.TabStop = true;
            this.radDui.Text = "DUI";
            this.radDui.UseVisualStyleBackColor = true;
            this.radDui.CheckedChanged += new System.EventHandler(this.radDui_CheckedChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.Location = new System.Drawing.Point(309, 57);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 24);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(585, 154);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(259, 24);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtCarne
            // 
            this.txtCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarne.Location = new System.Drawing.Point(585, 57);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(258, 24);
            this.txtCarne.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(36, 57);
            this.txtNombres.MaxLength = 45;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(258, 24);
            this.txtNombres.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(894, 230);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Imagen de 4Mb máximo";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tipo Usuario:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Usuario: *";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nacimiento: *";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Documento: *";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(895, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Foto de perfil:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Apellidos: *";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombres: *";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.Location = new System.Drawing.Point(34, 304);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.Size = new System.Drawing.Size(980, 206);
            this.dgvUsuarios.TabIndex = 20;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grpMantenimientos
            // 
            this.grpMantenimientos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpMantenimientos.Controls.Add(this.BtnNuevo);
            this.grpMantenimientos.Controls.Add(this.BtnEliminar);
            this.grpMantenimientos.Controls.Add(this.BtnActualizar);
            this.grpMantenimientos.Controls.Add(this.BtnReestablecer);
            this.grpMantenimientos.Controls.Add(this.BtnMostrar);
            this.grpMantenimientos.Controls.Add(this.BtnAgregar);
            this.grpMantenimientos.Location = new System.Drawing.Point(34, 193);
            this.grpMantenimientos.Name = "grpMantenimientos";
            this.grpMantenimientos.Size = new System.Drawing.Size(809, 70);
            this.grpMantenimientos.TabIndex = 46;
            this.grpMantenimientos.TabStop = false;
            this.grpMantenimientos.Text = "Mantenimientos";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(518, 23);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(112, 34);
            this.BtnNuevo.TabIndex = 18;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(400, 23);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 34);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(282, 23);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(112, 34);
            this.BtnActualizar.TabIndex = 16;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnReestablecer
            // 
            this.BtnReestablecer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReestablecer.BackColor = System.Drawing.Color.Red;
            this.BtnReestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReestablecer.ForeColor = System.Drawing.Color.White;
            this.BtnReestablecer.Location = new System.Drawing.Point(636, 24);
            this.BtnReestablecer.Name = "BtnReestablecer";
            this.BtnReestablecer.Size = new System.Drawing.Size(125, 33);
            this.BtnReestablecer.TabIndex = 19;
            this.BtnReestablecer.Text = "Reestablecer Clave";
            this.BtnReestablecer.UseVisualStyleBackColor = false;
            this.BtnReestablecer.Click += new System.EventHandler(this.BtnReestablecer_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.Location = new System.Drawing.Point(164, 23);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(112, 34);
            this.BtnMostrar.TabIndex = 15;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(46, 23);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(112, 34);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto.Location = new System.Drawing.Point(886, 61);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(127, 165);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 41;
            this.pbFoto.TabStop = false;
            // 
            // OpenCargarImagen
            // 
            this.OpenCargarImagen.Title = "Cargar Logo";
            // 
            // chkVerUsuarios
            // 
            this.chkVerUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkVerUsuarios.AutoSize = true;
            this.chkVerUsuarios.Location = new System.Drawing.Point(36, 277);
            this.chkVerUsuarios.Name = "chkVerUsuarios";
            this.chkVerUsuarios.Size = new System.Drawing.Size(147, 21);
            this.chkVerUsuarios.TabIndex = 12;
            this.chkVerUsuarios.Text = "Ver todos los usuarios";
            this.chkVerUsuarios.UseVisualStyleBackColor = true;
            this.chkVerUsuarios.CheckedChanged += new System.EventHandler(this.chkVerUsuarios_CheckedChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(306, 135);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(116, 17);
            this.lblCorreo.TabIndex = 28;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.Location = new System.Drawing.Point(309, 154);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 24);
            this.txtCorreo.TabIndex = 11;
            // 
            // FrmControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 522);
            this.Controls.Add(this.chkVerUsuarios);
            this.Controls.Add(this.grpMantenimientos);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.maskDui);
            this.Controls.Add(this.radCarne);
            this.Controls.Add(this.radDui);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControlUsuarios";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControlUsuarios";
            this.Load += new System.EventHandler(this.FrmControlUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpMantenimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrarFormulario;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.MaskedTextBox maskDui;
        private System.Windows.Forms.RadioButton radCarne;
        private System.Windows.Forms.RadioButton radDui;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripTextBox txtId;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grpMantenimientos;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnReestablecer;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.OpenFileDialog OpenCargarImagen;
        private System.Windows.Forms.CheckBox chkVerUsuarios;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ToolStripButton BtnReporte;
    }
}
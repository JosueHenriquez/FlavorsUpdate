namespace FlavorsOfTheHouse.Vista
{
    partial class FrmPrimerUsuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.ToolStripTextBox();
            this.lblIdusuario = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radDui = new System.Windows.Forms.RadioButton();
            this.radCarne = new System.Windows.Forms.RadioButton();
            this.maskDui = new System.Windows.Forms.MaskedTextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPregunta1 = new System.Windows.Forms.ComboBox();
            this.cmbPregunta2 = new System.Windows.Forms.ComboBox();
            this.cmbPregunta3 = new System.Windows.Forms.ComboBox();
            this.cmbPregunta4 = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtConfClave = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnSalir,
            this.txtId,
            this.lblIdusuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(196, 22);
            this.toolStripLabel1.Text = "Usuario | Administrador General";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Image = global::FlavorsOfTheHouse.Properties.Resources.cancel_button;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(132, 22);
            this.BtnSalir.Text = "Cerrar Formulario";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtId
            // 
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 25);
            // 
            // lblIdusuario
            // 
            this.lblIdusuario.Name = "lblIdusuario";
            this.lblIdusuario.Size = new System.Drawing.Size(69, 22);
            this.lblIdusuario.Text = "ID Usuario";
            this.lblIdusuario.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(69, 59);
            this.txtNombres.MaxLength = 45;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(277, 24);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.Location = new System.Drawing.Point(373, 59);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(278, 24);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto.Location = new System.Drawing.Point(715, 73);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(105, 143);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(373, 254);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(278, 24);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 286);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Documento:";
            // 
            // radDui
            // 
            this.radDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDui.AutoSize = true;
            this.radDui.Location = new System.Drawing.Point(143, 86);
            this.radDui.Name = "radDui";
            this.radDui.Size = new System.Drawing.Size(48, 21);
            this.radDui.TabIndex = 13;
            this.radDui.TabStop = true;
            this.radDui.Text = "DUI";
            this.radDui.UseVisualStyleBackColor = true;
            this.radDui.CheckedChanged += new System.EventHandler(this.radDui_CheckedChanged);
            // 
            // radCarne
            // 
            this.radCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCarne.AutoSize = true;
            this.radCarne.Location = new System.Drawing.Point(194, 87);
            this.radCarne.Name = "radCarne";
            this.radCarne.Size = new System.Drawing.Size(65, 21);
            this.radCarne.TabIndex = 13;
            this.radCarne.TabStop = true;
            this.radCarne.Text = "CARNÉ";
            this.radCarne.UseVisualStyleBackColor = true;
            this.radCarne.CheckedChanged += new System.EventHandler(this.radCarne_CheckedChanged);
            // 
            // maskDui
            // 
            this.maskDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskDui.Location = new System.Drawing.Point(69, 107);
            this.maskDui.Mask = "00000000-0";
            this.maskDui.Name = "maskDui";
            this.maskDui.Size = new System.Drawing.Size(277, 24);
            this.maskDui.TabIndex = 3;
            // 
            // txtCarne
            // 
            this.txtCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarne.Location = new System.Drawing.Point(69, 107);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(277, 24);
            this.txtCarne.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nacimiento:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(373, 107);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(278, 24);
            this.dtNacimiento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(70, 157);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(581, 23);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(71, 254);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(275, 23);
            this.cmbEstado.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tipo Usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(373, 205);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(278, 23);
            this.cmbTipoUsuario.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Confirmar clave:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(34, 497);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(455, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Se le recomienda guardar este usuario en un lugar seguro y mantener una copia";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(725, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Foto de perfil:";
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExaminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar.Location = new System.Drawing.Point(696, 237);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(141, 33);
            this.BtnExaminar.TabIndex = 12;
            this.BtnExaminar.Text = "Cargar Imagen";
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(34, 516);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(432, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "de las credenciales proporcionadas asi como de las respuestas de seguridad.";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(661, 498);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(141, 33);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Continuar...";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta1.Location = new System.Drawing.Point(536, 386);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(301, 24);
            this.txtRespuesta1.TabIndex = 14;
            this.txtRespuesta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta1_KeyPress);
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta2.Location = new System.Drawing.Point(536, 411);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(301, 24);
            this.txtRespuesta2.TabIndex = 16;
            this.txtRespuesta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta2_KeyPress);
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta3.Location = new System.Drawing.Point(536, 435);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(301, 24);
            this.txtRespuesta3.TabIndex = 18;
            this.txtRespuesta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta3_KeyPress);
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta4.Location = new System.Drawing.Point(536, 459);
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(301, 24);
            this.txtRespuesta4.TabIndex = 20;
            this.txtRespuesta4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta4_KeyPress);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(53, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(254, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Conteste las preguntas con una sola palabra";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(716, 222);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Imagen de 4Mb máximo";
            // 
            // cmbPregunta1
            // 
            this.cmbPregunta1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta1.FormattingEnabled = true;
            this.cmbPregunta1.Location = new System.Drawing.Point(59, 384);
            this.cmbPregunta1.Name = "cmbPregunta1";
            this.cmbPregunta1.Size = new System.Drawing.Size(459, 23);
            this.cmbPregunta1.TabIndex = 13;
            // 
            // cmbPregunta2
            // 
            this.cmbPregunta2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta2.FormattingEnabled = true;
            this.cmbPregunta2.Location = new System.Drawing.Point(59, 409);
            this.cmbPregunta2.Name = "cmbPregunta2";
            this.cmbPregunta2.Size = new System.Drawing.Size(459, 23);
            this.cmbPregunta2.TabIndex = 15;
            // 
            // cmbPregunta3
            // 
            this.cmbPregunta3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta3.FormattingEnabled = true;
            this.cmbPregunta3.Location = new System.Drawing.Point(59, 433);
            this.cmbPregunta3.Name = "cmbPregunta3";
            this.cmbPregunta3.Size = new System.Drawing.Size(459, 23);
            this.cmbPregunta3.TabIndex = 17;
            // 
            // cmbPregunta4
            // 
            this.cmbPregunta4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta4.FormattingEnabled = true;
            this.cmbPregunta4.Location = new System.Drawing.Point(59, 458);
            this.cmbPregunta4.Name = "cmbPregunta4";
            this.cmbPregunta4.Size = new System.Drawing.Size(459, 23);
            this.cmbPregunta4.TabIndex = 19;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave.Location = new System.Drawing.Point(69, 304);
            this.txtClave.MaxLength = 45;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(277, 24);
            this.txtClave.TabIndex = 10;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // txtConfClave
            // 
            this.txtConfClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfClave.Location = new System.Drawing.Point(373, 304);
            this.txtConfClave.Name = "txtConfClave";
            this.txtConfClave.Size = new System.Drawing.Size(278, 24);
            this.txtConfClave.TabIndex = 11;
            this.txtConfClave.TextChanged += new System.EventHandler(this.txtConfClave_TextChanged);
            this.txtConfClave.Enter += new System.EventHandler(this.txtConfClave_Enter);
            this.txtConfClave.Leave += new System.EventHandler(this.txtConfClave_Leave);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(474, 286);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(136, 17);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Las claves no coinciden";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 186);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Correo electrónico:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(71, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 24);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // FrmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 578);
            this.Controls.Add(this.cmbPregunta4);
            this.Controls.Add(this.cmbPregunta3);
            this.Controls.Add(this.cmbPregunta2);
            this.Controls.Add(this.cmbPregunta1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.maskDui);
            this.Controls.Add(this.radCarne);
            this.Controls.Add(this.radDui);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtConfClave);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtRespuesta4);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrimerUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUsuario";
            this.Load += new System.EventHandler(this.FrmPrimerUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radDui;
        private System.Windows.Forms.RadioButton radCarne;
        private System.Windows.Forms.MaskedTextBox maskDui;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPregunta1;
        private System.Windows.Forms.ComboBox cmbPregunta2;
        private System.Windows.Forms.ComboBox cmbPregunta3;
        private System.Windows.Forms.ComboBox cmbPregunta4;
        private System.Windows.Forms.ToolStripTextBox txtId;
        private System.Windows.Forms.ToolStripLabel lblIdusuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfClave;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
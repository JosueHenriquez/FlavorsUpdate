﻿namespace FlavorsOfTheHouse.Vista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
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
            this.txtConfClave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnSalir});
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
            this.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalir.Image = global::FlavorsOfTheHouse.Properties.Resources.cancel_button;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(23, 22);
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(82, 65);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(267, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(379, 65);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(268, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto.Location = new System.Drawing.Point(726, 75);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(120, 153);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(84, 274);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(268, 22);
            this.txtUsuario.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(379, 221);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(268, 22);
            this.txtClave.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Documento:";
            // 
            // radDui
            // 
            this.radDui.AutoSize = true;
            this.radDui.Location = new System.Drawing.Point(167, 94);
            this.radDui.Name = "radDui";
            this.radDui.Size = new System.Drawing.Size(49, 20);
            this.radDui.TabIndex = 13;
            this.radDui.TabStop = true;
            this.radDui.Text = "DUI";
            this.radDui.UseVisualStyleBackColor = true;
            this.radDui.CheckedChanged += new System.EventHandler(this.radDui_CheckedChanged);
            // 
            // radCarne
            // 
            this.radCarne.AutoSize = true;
            this.radCarne.Location = new System.Drawing.Point(225, 95);
            this.radCarne.Name = "radCarne";
            this.radCarne.Size = new System.Drawing.Size(73, 20);
            this.radCarne.TabIndex = 13;
            this.radCarne.TabStop = true;
            this.radCarne.Text = "CARNÉ";
            this.radCarne.UseVisualStyleBackColor = true;
            this.radCarne.CheckedChanged += new System.EventHandler(this.radCarne_CheckedChanged);
            // 
            // maskDui
            // 
            this.maskDui.Location = new System.Drawing.Point(82, 116);
            this.maskDui.Mask = "00000000-0";
            this.maskDui.Name = "maskDui";
            this.maskDui.Size = new System.Drawing.Size(267, 22);
            this.maskDui.TabIndex = 3;
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(82, 116);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(267, 22);
            this.txtCarne.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nacimiento:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(379, 116);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(268, 22);
            this.dtNacimiento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(83, 169);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(266, 24);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(84, 221);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(265, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tipo Usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(379, 169);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(268, 24);
            this.cmbTipoUsuario.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Confirmar clave:";
            // 
            // txtConfClave
            // 
            this.txtConfClave.Location = new System.Drawing.Point(379, 274);
            this.txtConfClave.Name = "txtConfClave";
            this.txtConfClave.Size = new System.Drawing.Size(268, 22);
            this.txtConfClave.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(56, 466);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Se le recomienda guardar este usuario en un lugar seguro y mantener una copia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(743, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Foto de perfil:";
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar.Location = new System.Drawing.Point(704, 242);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(161, 35);
            this.BtnExaminar.TabIndex = 15;
            this.BtnExaminar.Text = "Cargar Imagen";
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(56, 486);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(479, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "de las credenciales proporcionadas asi como de las respuestas de seguridad.";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(708, 467);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(161, 35);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Continuar...";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(79, 348);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "1. ¿Cual de mis nombres prefiero cambiar?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 374);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "2. ¿Cual es su comida favorita?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 400);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "3. ¿A que edad tuvo su primer novia?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 426);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "4. ¿Cual son los ultimos dos numeros de su movil?";
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(389, 348);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(456, 22);
            this.txtRespuesta1.TabIndex = 11;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(389, 374);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(456, 22);
            this.txtRespuesta2.TabIndex = 12;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(389, 400);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(456, 22);
            this.txtRespuesta3.TabIndex = 13;
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Location = new System.Drawing.Point(389, 426);
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(456, 22);
            this.txtRespuesta4.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(78, 314);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(274, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "Conteste las preguntas con una sola palabra";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 522);
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
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtRespuesta4);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.txtConfClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtClave;
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
        private System.Windows.Forms.TextBox txtConfClave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
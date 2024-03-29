﻿namespace FlavorsOfTheHouse.Vista
{
    partial class FrmRecuperacionPorCorreo
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
            this.LinkMetodos = new System.Windows.Forms.LinkLabel();
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.grpNuevaClave = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpValidacionAdmin = new System.Windows.Forms.GroupBox();
            this.BtnValidarCredenciales = new System.Windows.Forms.Button();
            this.BtnVerificarCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuarioRecuperar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrarFormulario = new System.Windows.Forms.ToolStripButton();
            this.grpNuevaClave.SuspendLayout();
            this.grpValidacionAdmin.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkMetodos
            // 
            this.LinkMetodos.AutoSize = true;
            this.LinkMetodos.Location = new System.Drawing.Point(32, 662);
            this.LinkMetodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkMetodos.Name = "LinkMetodos";
            this.LinkMetodos.Size = new System.Drawing.Size(321, 17);
            this.LinkMetodos.TabIndex = 6;
            this.LinkMetodos.TabStop = true;
            this.LinkMetodos.Text = "Regresar a los metodos de recuperación de contraseñas";
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Location = new System.Drawing.Point(32, 640);
            this.LinkLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(105, 17);
            this.LinkLogin.TabIndex = 7;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Regresar al Login";
            // 
            // grpNuevaClave
            // 
            this.grpNuevaClave.Controls.Add(this.btnCambiar);
            this.grpNuevaClave.Controls.Add(this.txtClave);
            this.grpNuevaClave.Controls.Add(this.label4);
            this.grpNuevaClave.Controls.Add(this.txtConfirmar);
            this.grpNuevaClave.Controls.Add(this.label6);
            this.grpNuevaClave.Controls.Add(this.label5);
            this.grpNuevaClave.Location = new System.Drawing.Point(13, 412);
            this.grpNuevaClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNuevaClave.Name = "grpNuevaClave";
            this.grpNuevaClave.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNuevaClave.Size = new System.Drawing.Size(436, 213);
            this.grpNuevaClave.TabIndex = 1;
            this.grpNuevaClave.TabStop = false;
            this.grpNuevaClave.Text = "Nuevas Credenciales de Acceso";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.Green;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.Location = new System.Drawing.Point(51, 147);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(335, 40);
            this.btnCambiar.TabIndex = 7;
            this.btnCambiar.Text = "Actualizar contraseña";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(51, 62);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(335, 24);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nueva Clave:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(51, 114);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(335, 24);
            this.txtConfirmar.TabIndex = 6;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(258, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Las claves no coinciden";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirmar Clave:";
            // 
            // grpValidacionAdmin
            // 
            this.grpValidacionAdmin.Controls.Add(this.BtnValidarCredenciales);
            this.grpValidacionAdmin.Controls.Add(this.BtnVerificarCodigo);
            this.grpValidacionAdmin.Controls.Add(this.txtCodigo);
            this.grpValidacionAdmin.Controls.Add(this.txtEmail);
            this.grpValidacionAdmin.Controls.Add(this.txtUsuarioRecuperar);
            this.grpValidacionAdmin.Controls.Add(this.label3);
            this.grpValidacionAdmin.Controls.Add(this.label2);
            this.grpValidacionAdmin.Controls.Add(this.label8);
            this.grpValidacionAdmin.Controls.Add(this.label7);
            this.grpValidacionAdmin.Controls.Add(this.label1);
            this.grpValidacionAdmin.Location = new System.Drawing.Point(13, 34);
            this.grpValidacionAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpValidacionAdmin.Name = "grpValidacionAdmin";
            this.grpValidacionAdmin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpValidacionAdmin.Size = new System.Drawing.Size(436, 372);
            this.grpValidacionAdmin.TabIndex = 0;
            this.grpValidacionAdmin.TabStop = false;
            this.grpValidacionAdmin.Text = "Datos para recuperación de clave";
            // 
            // BtnValidarCredenciales
            // 
            this.BtnValidarCredenciales.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnValidarCredenciales.FlatAppearance.BorderSize = 0;
            this.BtnValidarCredenciales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnValidarCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValidarCredenciales.ForeColor = System.Drawing.Color.White;
            this.BtnValidarCredenciales.Location = new System.Drawing.Point(51, 193);
            this.BtnValidarCredenciales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnValidarCredenciales.Name = "BtnValidarCredenciales";
            this.BtnValidarCredenciales.Size = new System.Drawing.Size(335, 40);
            this.BtnValidarCredenciales.TabIndex = 2;
            this.BtnValidarCredenciales.Text = "Verificar congruencia de datos";
            this.BtnValidarCredenciales.UseVisualStyleBackColor = false;
            this.BtnValidarCredenciales.Click += new System.EventHandler(this.BtnValidarCredenciales_Click);
            // 
            // BtnVerificarCodigo
            // 
            this.BtnVerificarCodigo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVerificarCodigo.FlatAppearance.BorderSize = 0;
            this.BtnVerificarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnVerificarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerificarCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnVerificarCodigo.Location = new System.Drawing.Point(50, 297);
            this.BtnVerificarCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnVerificarCodigo.Name = "BtnVerificarCodigo";
            this.BtnVerificarCodigo.Size = new System.Drawing.Size(335, 40);
            this.BtnVerificarCodigo.TabIndex = 4;
            this.BtnVerificarCodigo.Text = "Iniciar recuperación";
            this.BtnVerificarCodigo.UseVisualStyleBackColor = false;
            this.BtnVerificarCodigo.Click += new System.EventHandler(this.BtnVerificarCodigo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(50, 264);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(334, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(51, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtUsuarioRecuperar
            // 
            this.txtUsuarioRecuperar.Location = new System.Drawing.Point(51, 106);
            this.txtUsuarioRecuperar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuarioRecuperar.Name = "txtUsuarioRecuperar";
            this.txtUsuarioRecuperar.Size = new System.Drawing.Size(334, 24);
            this.txtUsuarioRecuperar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingresar código de verificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo electrónico perteneciente al usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(36, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "sean las correctas.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(36, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Por motivos de seguridad vamos a verificar que las credenciales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué usuario desea recuperar?";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnCerrarFormulario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(465, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(346, 22);
            this.toolStripLabel1.Text = "Recuperación de contraseñas por intervención de Administrador";
            // 
            // BtnCerrarFormulario
            // 
            this.BtnCerrarFormulario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrarFormulario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrarFormulario.Image = global::FlavorsOfTheHouse.Properties.Resources.cancel_button;
            this.BtnCerrarFormulario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrarFormulario.Name = "BtnCerrarFormulario";
            this.BtnCerrarFormulario.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrarFormulario.Text = "Salir";
            this.BtnCerrarFormulario.Click += new System.EventHandler(this.BtnCerrarFormulario_Click);
            // 
            // FrmRecuperacionPorCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 710);
            this.Controls.Add(this.LinkMetodos);
            this.Controls.Add(this.LinkLogin);
            this.Controls.Add(this.grpNuevaClave);
            this.Controls.Add(this.grpValidacionAdmin);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRecuperacionPorCorreo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperacionPorCorreo";
            this.Load += new System.EventHandler(this.FrmRecuperacionPorCorreo_Load);
            this.grpNuevaClave.ResumeLayout(false);
            this.grpNuevaClave.PerformLayout();
            this.grpValidacionAdmin.ResumeLayout(false);
            this.grpValidacionAdmin.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkMetodos;
        private System.Windows.Forms.LinkLabel LinkLogin;
        private System.Windows.Forms.GroupBox grpNuevaClave;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpValidacionAdmin;
        private System.Windows.Forms.Button BtnValidarCredenciales;
        private System.Windows.Forms.Button BtnVerificarCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuarioRecuperar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrarFormulario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
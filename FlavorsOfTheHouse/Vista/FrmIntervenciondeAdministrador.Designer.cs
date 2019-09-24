namespace FlavorsOfTheHouse.Vista
{
    partial class FrmIntervenciondeAdministrador
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lbldiferente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.LinkMetodos = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(346, 22);
            this.toolStripLabel1.Text = "Recuperación de contraseñas por intervención de Administrador";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FlavorsOfTheHouse.Properties.Resources.cancel_button;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnVerificar);
            this.grp1.Controls.Add(this.txtUsuario);
            this.grp1.Controls.Add(this.txtClaveAdmin);
            this.grp1.Controls.Add(this.txtUsuarioAdmin);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Location = new System.Drawing.Point(30, 41);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(390, 259);
            this.grp1.TabIndex = 1;
            this.grp1.TabStop = false;
            this.grp1.Text = "Uso del Administrador";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(46, 196);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(287, 35);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Validar Recuperación";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(46, 148);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(287, 24);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.Location = new System.Drawing.Point(46, 101);
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.Size = new System.Drawing.Size(287, 24);
            this.txtClaveAdmin.TabIndex = 1;
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(46, 56);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(287, 24);
            this.txtUsuarioAdmin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario a recuperar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Administrador:";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.button2);
            this.grp2.Controls.Add(this.txtNewClave);
            this.grp2.Controls.Add(this.label4);
            this.grp2.Controls.Add(this.txtConfirmarClave);
            this.grp2.Controls.Add(this.lbldiferente);
            this.grp2.Controls.Add(this.label5);
            this.grp2.Location = new System.Drawing.Point(453, 41);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(390, 259);
            this.grp2.TabIndex = 1;
            this.grp2.TabStop = false;
            this.grp2.Text = "Nuevas Credenciales de Acceso";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(52, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Validar Recuperación";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNewClave
            // 
            this.txtNewClave.Location = new System.Drawing.Point(52, 56);
            this.txtNewClave.Name = "txtNewClave";
            this.txtNewClave.Size = new System.Drawing.Size(287, 24);
            this.txtNewClave.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nueva Clave:";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(52, 101);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(287, 24);
            this.txtConfirmarClave.TabIndex = 1;
            // 
            // lbldiferente
            // 
            this.lbldiferente.AutoSize = true;
            this.lbldiferente.ForeColor = System.Drawing.Color.Red;
            this.lbldiferente.Location = new System.Drawing.Point(203, 83);
            this.lbldiferente.Name = "lbldiferente";
            this.lbldiferente.Size = new System.Drawing.Size(136, 17);
            this.lbldiferente.TabIndex = 0;
            this.lbldiferente.Text = "Las claves no coinciden";
            this.lbldiferente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirmar Clave:";
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Location = new System.Drawing.Point(27, 319);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(105, 17);
            this.LinkLogin.TabIndex = 2;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Regresar al Login";
            this.LinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogin_LinkClicked);
            // 
            // LinkMetodos
            // 
            this.LinkMetodos.AutoSize = true;
            this.LinkMetodos.Location = new System.Drawing.Point(27, 346);
            this.LinkMetodos.Name = "LinkMetodos";
            this.LinkMetodos.Size = new System.Drawing.Size(321, 17);
            this.LinkMetodos.TabIndex = 2;
            this.LinkMetodos.TabStop = true;
            this.LinkMetodos.Text = "Regresar a los metodos de recuperación de contraseñas";
            this.LinkMetodos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMetodos_LinkClicked);
            // 
            // FrmIntervenciondeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 391);
            this.Controls.Add(this.LinkMetodos);
            this.Controls.Add(this.LinkLogin);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIntervenciondeAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIntervenciondeAdministrador";
            this.Load += new System.EventHandler(this.FrmIntervenciondeAdministrador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.TextBox txtNewClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lbldiferente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.LinkLabel LinkLogin;
        private System.Windows.Forms.LinkLabel LinkMetodos;
    }
}
namespace FlavorsOfTheHouse.Vista
{
    partial class FrmLogin
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.animacionUsuario = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelusuario = new System.Windows.Forms.Panel();
            this.panelclave = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lnkRecuperacion = new System.Windows.Forms.LinkLabel();
            this.lbllogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panellogin = new System.Windows.Forms.Panel();
            this.animacionContra = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.BtnPrimerUso = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnIniciar = new System.Windows.Forms.ToolStripButton();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panellogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // animacionUsuario
            // 
            this.animacionUsuario.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacionUsuario.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animacionUsuario.DefaultAnimation = animation1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.animacionContra.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnIniciar,
            this.BtnCerrar,
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // panelusuario
            // 
            this.panelusuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.animacionContra.SetDecoration(this.panelusuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.panelusuario, BunifuAnimatorNS.DecorationType.None);
            this.panelusuario.Location = new System.Drawing.Point(358, 145);
            this.panelusuario.Name = "panelusuario";
            this.panelusuario.Size = new System.Drawing.Size(347, 2);
            this.panelusuario.TabIndex = 38;
            // 
            // panelclave
            // 
            this.panelclave.BackColor = System.Drawing.Color.DodgerBlue;
            this.animacionContra.SetDecoration(this.panelclave, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.panelclave, BunifuAnimatorNS.DecorationType.None);
            this.panelclave.Location = new System.Drawing.Point(358, 188);
            this.panelclave.Name = "panelclave";
            this.panelclave.Size = new System.Drawing.Size(347, 2);
            this.panelclave.TabIndex = 39;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animacionUsuario.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.txtContrasena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(358, 169);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '○';
            this.txtContrasena.Size = new System.Drawing.Size(347, 19);
            this.txtContrasena.TabIndex = 27;
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animacionUsuario.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(358, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(347, 19);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lblContra, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lblContra, BunifuAnimatorNS.DecorationType.None);
            this.lblContra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(267, 170);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(83, 19);
            this.lblContra.TabIndex = 36;
            this.lblContra.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(291, 126);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 37;
            this.lblUsuario.Text = "Usuario";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.lbl2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(218, 65);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(363, 18);
            this.lbl2.TabIndex = 35;
            this.lbl2.Text = "Haz clic en \"PRIMER USO\" para iniciar con la configuración.";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.lbl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(149, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(489, 18);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Bienvenido, hemos detectado que es primera vez que utilizas nuestro sistema";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.animacionUsuario.SetDecoration(this.BtnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.BtnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(423, 227);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(129, 31);
            this.BtnCancelar.TabIndex = 31;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.ForestGreen;
            this.animacionUsuario.SetDecoration(this.btnAcceder, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.btnAcceder, BunifuAnimatorNS.DecorationType.None);
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(576, 227);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(129, 31);
            this.btnAcceder.TabIndex = 32;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click_2);
            // 
            // lnkRecuperacion
            // 
            this.lnkRecuperacion.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lnkRecuperacion, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lnkRecuperacion, BunifuAnimatorNS.DecorationType.None);
            this.lnkRecuperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lnkRecuperacion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnkRecuperacion.Location = new System.Drawing.Point(473, 282);
            this.lnkRecuperacion.Name = "lnkRecuperacion";
            this.lnkRecuperacion.Size = new System.Drawing.Size(179, 18);
            this.lnkRecuperacion.TabIndex = 30;
            this.lnkRecuperacion.TabStop = true;
            this.lnkRecuperacion.Text = "¿Olvidaste tu contraseña?";
            this.lnkRecuperacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperacion_LinkClicked);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.lbllogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(304, 63);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(383, 19);
            this.lbllogin.TabIndex = 29;
            this.lbllogin.Text = "Bienvenido, introduce tus credenciales para Iniciar Sesión";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.animacionUsuario.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(532, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 24);
            this.textBox1.TabIndex = 28;
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.panellogin.Controls.Add(this.picImagen);
            this.animacionContra.SetDecoration(this.panellogin, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.panellogin, BunifuAnimatorNS.DecorationType.None);
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogin.Location = new System.Drawing.Point(0, 25);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(245, 306);
            this.panellogin.TabIndex = 40;
            // 
            // animacionContra
            // 
            this.animacionContra.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacionContra.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animacionContra.DefaultAnimation = animation2;
            // 
            // picImagen
            // 
            this.animacionUsuario.SetDecoration(this.picImagen, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.picImagen, BunifuAnimatorNS.DecorationType.None);
            this.picImagen.Image = global::FlavorsOfTheHouse.Properties.Resources.sabores_de_la_casa;
            this.picImagen.Location = new System.Drawing.Point(54, 65);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(133, 168);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 34;
            this.picImagen.TabStop = false;
            // 
            // BtnPrimerUso
            // 
            this.BtnPrimerUso.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPrimerUso.color = System.Drawing.Color.DodgerBlue;
            this.BtnPrimerUso.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.BtnPrimerUso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionContra.SetDecoration(this.BtnPrimerUso, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.BtnPrimerUso, BunifuAnimatorNS.DecorationType.None);
            this.BtnPrimerUso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimerUso.ForeColor = System.Drawing.Color.White;
            this.BtnPrimerUso.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrimerUso.Image")));
            this.BtnPrimerUso.ImagePosition = 18;
            this.BtnPrimerUso.ImageZoom = 50;
            this.BtnPrimerUso.LabelPosition = 36;
            this.BtnPrimerUso.LabelText = "PRIMER USO";
            this.BtnPrimerUso.Location = new System.Drawing.Point(278, 133);
            this.BtnPrimerUso.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPrimerUso.Name = "BtnPrimerUso";
            this.BtnPrimerUso.Size = new System.Drawing.Size(255, 155);
            this.BtnPrimerUso.TabIndex = 34;
            this.BtnPrimerUso.Click += new System.EventHandler(this.BtnPrimerUso_Click_1);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnIniciar.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciar.Image = global::FlavorsOfTheHouse.Properties.Resources.birthday_cake;
            this.BtnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(93, 22);
            this.BtnIniciar.Text = "Inicio de Sesión";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::FlavorsOfTheHouse.Properties.Resources.close_button;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "toolStripButton2";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = global::FlavorsOfTheHouse.Properties.Resources.downwards_arrow_key;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "toolStripButton3";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 331);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.panelusuario);
            this.Controls.Add(this.panelclave);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.BtnPrimerUso);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lnkRecuperacion);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.animacionUsuario.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmLogin";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panellogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition animacionContra;
        private BunifuAnimatorNS.BunifuTransition animacionUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnIniciar;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel panelusuario;
        private System.Windows.Forms.Panel panelclave;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private Bunifu.Framework.UI.BunifuTileButton BtnPrimerUso;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel lnkRecuperacion;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.PictureBox picImagen;
    }
}
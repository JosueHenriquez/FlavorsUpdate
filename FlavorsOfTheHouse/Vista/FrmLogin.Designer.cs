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
            BunifuAnimatorNS.Animation animation17 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            BunifuAnimatorNS.Animation animation18 = new BunifuAnimatorNS.Animation();
            this.animacionUsuario = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnIniciar = new System.Windows.Forms.ToolStripButton();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.BtnPrimerUso = new Bunifu.Framework.UI.BunifuTileButton();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lnkRecuperacion = new System.Windows.Forms.LinkLabel();
            this.lbllogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.animacionContra = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolStrip1.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // animacionUsuario
            // 
            this.animacionUsuario.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacionUsuario.Cursor = null;
            animation17.AnimateOnlyDifferences = true;
            animation17.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.BlindCoeff")));
            animation17.LeafCoeff = 0F;
            animation17.MaxTime = 1F;
            animation17.MinTime = 0F;
            animation17.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicCoeff")));
            animation17.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicShift")));
            animation17.MosaicSize = 0;
            animation17.Padding = new System.Windows.Forms.Padding(0);
            animation17.RotateCoeff = 0F;
            animation17.RotateLimit = 0F;
            animation17.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.ScaleCoeff")));
            animation17.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.SlideCoeff")));
            animation17.TimeCoeff = 0F;
            animation17.TransparencyCoeff = 0F;
            this.animacionUsuario.DefaultAnimation = animation17;
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
            this.toolStrip1.Size = new System.Drawing.Size(626, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
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
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.txtContrasena);
            this.PanelLogin.Controls.Add(this.txtUsuario);
            this.PanelLogin.Controls.Add(this.lblContra);
            this.PanelLogin.Controls.Add(this.lblUsuario);
            this.PanelLogin.Controls.Add(this.lbl2);
            this.PanelLogin.Controls.Add(this.lbl1);
            this.PanelLogin.Controls.Add(this.BtnPrimerUso);
            this.PanelLogin.Controls.Add(this.picImagen);
            this.PanelLogin.Controls.Add(this.BtnCancelar);
            this.PanelLogin.Controls.Add(this.btnAcceder);
            this.PanelLogin.Controls.Add(this.lnkRecuperacion);
            this.PanelLogin.Controls.Add(this.lbllogin);
            this.PanelLogin.Controls.Add(this.textBox1);
            this.animacionContra.SetDecoration(this.PanelLogin, BunifuAnimatorNS.DecorationType.None);
            this.animacionUsuario.SetDecoration(this.PanelLogin, BunifuAnimatorNS.DecorationType.None);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLogin.Location = new System.Drawing.Point(0, 25);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(626, 252);
            this.PanelLogin.TabIndex = 10;
            // 
            // txtContrasena
            // 
            this.animacionUsuario.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.txtContrasena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(276, 129);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '○';
            this.txtContrasena.Size = new System.Drawing.Size(277, 26);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.animacionUsuario.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(276, 86);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(277, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lblContra, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lblContra, BunifuAnimatorNS.DecorationType.None);
            this.lblContra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(187, 132);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(83, 19);
            this.lblContra.TabIndex = 23;
            this.lblContra.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(211, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.lbl2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(142, 37);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(363, 18);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "Haz clic en \"PRIMER USO\" para iniciar con la configuración.";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.lbl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(73, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(489, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bienvenido, hemos detectado que es primera vez que utilizas nuestro sistema";
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
            this.BtnPrimerUso.Location = new System.Drawing.Point(191, 80);
            this.BtnPrimerUso.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPrimerUso.Name = "BtnPrimerUso";
            this.BtnPrimerUso.Size = new System.Drawing.Size(255, 155);
            this.BtnPrimerUso.TabIndex = 20;
            this.BtnPrimerUso.Click += new System.EventHandler(this.BtnPrimerUso_Click);
            // 
            // picImagen
            // 
            this.animacionUsuario.SetDecoration(this.picImagen, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.picImagen, BunifuAnimatorNS.DecorationType.None);
            this.picImagen.Image = global::FlavorsOfTheHouse.Properties.Resources.sabores_de_la_casa;
            this.picImagen.Location = new System.Drawing.Point(33, 51);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(124, 154);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 19;
            this.picImagen.TabStop = false;
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
            this.BtnCancelar.Location = new System.Drawing.Point(285, 177);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(129, 31);
            this.BtnCancelar.TabIndex = 17;
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
            this.btnAcceder.Location = new System.Drawing.Point(424, 176);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(129, 31);
            this.btnAcceder.TabIndex = 18;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click_1);
            // 
            // lnkRecuperacion
            // 
            this.lnkRecuperacion.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lnkRecuperacion, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lnkRecuperacion, BunifuAnimatorNS.DecorationType.None);
            this.lnkRecuperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lnkRecuperacion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnkRecuperacion.Location = new System.Drawing.Point(326, 221);
            this.lnkRecuperacion.Name = "lnkRecuperacion";
            this.lnkRecuperacion.Size = new System.Drawing.Size(179, 18);
            this.lnkRecuperacion.TabIndex = 16;
            this.lnkRecuperacion.TabStop = true;
            this.lnkRecuperacion.Text = "¿Olvidaste tu contraseña?";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.animacionUsuario.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.lbllogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(187, 22);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(383, 19);
            this.lbllogin.TabIndex = 15;
            this.lbllogin.Text = "Bienvenido, introduce tus credenciales para Iniciar Sesión";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.animacionUsuario.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(456, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 24);
            this.textBox1.TabIndex = 10;
            // 
            // animacionContra
            // 
            this.animacionContra.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacionContra.Cursor = null;
            animation18.AnimateOnlyDifferences = true;
            animation18.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.BlindCoeff")));
            animation18.LeafCoeff = 0F;
            animation18.MaxTime = 1F;
            animation18.MinTime = 0F;
            animation18.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicCoeff")));
            animation18.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicShift")));
            animation18.MosaicSize = 0;
            animation18.Padding = new System.Windows.Forms.Padding(0);
            animation18.RotateCoeff = 0F;
            animation18.RotateLimit = 0F;
            animation18.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.ScaleCoeff")));
            animation18.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.SlideCoeff")));
            animation18.TimeCoeff = 0F;
            animation18.TransparencyCoeff = 0F;
            this.animacionContra.DefaultAnimation = animation18;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(626, 277);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.toolStrip1);
            this.animacionUsuario.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacionContra.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
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
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel lnkRecuperacion;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuTileButton BtnPrimerUso;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}
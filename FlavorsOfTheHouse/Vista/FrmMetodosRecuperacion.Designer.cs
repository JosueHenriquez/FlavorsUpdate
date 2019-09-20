namespace FlavorsOfTheHouse.Vista
{
    partial class FrmMetodosRecuperacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picRecuperacionPreguntas = new System.Windows.Forms.PictureBox();
            this.picRegresarLogin = new System.Windows.Forms.PictureBox();
            this.picCorreo = new System.Windows.Forms.PictureBox();
            this.picRecuperacionAdmin = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecuperacionPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecuperacionAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(158, 22);
            this.toolStripLabel1.Text = "Recuperación de Contraseña";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el metodo de recuperación de contraseña que desea ejectuar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intervención de Administrador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electrónico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preguntas de Seguridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Regresar al Login";
            // 
            // picRecuperacionPreguntas
            // 
            this.picRecuperacionPreguntas.Image = global::FlavorsOfTheHouse.Properties.Resources.pregunta;
            this.picRecuperacionPreguntas.Location = new System.Drawing.Point(559, 85);
            this.picRecuperacionPreguntas.Name = "picRecuperacionPreguntas";
            this.picRecuperacionPreguntas.Size = new System.Drawing.Size(153, 156);
            this.picRecuperacionPreguntas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecuperacionPreguntas.TabIndex = 1;
            this.picRecuperacionPreguntas.TabStop = false;
            this.picRecuperacionPreguntas.Click += new System.EventHandler(this.picRecuperacionPreguntas_Click);
            // 
            // picRegresarLogin
            // 
            this.picRegresarLogin.Image = global::FlavorsOfTheHouse.Properties.Resources.back_arrow1;
            this.picRegresarLogin.Location = new System.Drawing.Point(34, 122);
            this.picRegresarLogin.Name = "picRegresarLogin";
            this.picRegresarLogin.Size = new System.Drawing.Size(60, 51);
            this.picRegresarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegresarLogin.TabIndex = 1;
            this.picRegresarLogin.TabStop = false;
            this.picRegresarLogin.Click += new System.EventHandler(this.picRegresarLogin_Click);
            // 
            // picCorreo
            // 
            this.picCorreo.Image = global::FlavorsOfTheHouse.Properties.Resources.correo2;
            this.picCorreo.Location = new System.Drawing.Point(146, 85);
            this.picCorreo.Name = "picCorreo";
            this.picCorreo.Size = new System.Drawing.Size(153, 156);
            this.picCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCorreo.TabIndex = 1;
            this.picCorreo.TabStop = false;
            this.picCorreo.Click += new System.EventHandler(this.picCorreo_Click);
            // 
            // picRecuperacionAdmin
            // 
            this.picRecuperacionAdmin.Image = global::FlavorsOfTheHouse.Properties.Resources.guapo;
            this.picRecuperacionAdmin.Location = new System.Drawing.Point(351, 85);
            this.picRecuperacionAdmin.Name = "picRecuperacionAdmin";
            this.picRecuperacionAdmin.Size = new System.Drawing.Size(153, 156);
            this.picRecuperacionAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecuperacionAdmin.TabIndex = 1;
            this.picRecuperacionAdmin.TabStop = false;
            this.picRecuperacionAdmin.Click += new System.EventHandler(this.picRecuperacionAdmin_Click);
            // 
            // FrmMetodosRecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRecuperacionPreguntas);
            this.Controls.Add(this.picRegresarLogin);
            this.Controls.Add(this.picCorreo);
            this.Controls.Add(this.picRecuperacionAdmin);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMetodosRecuperacion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetodosRecuperacion";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecuperacionPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecuperacionAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox picRecuperacionAdmin;
        private System.Windows.Forms.PictureBox picCorreo;
        private System.Windows.Forms.PictureBox picRecuperacionPreguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picRegresarLogin;
        private System.Windows.Forms.Label label5;
    }
}
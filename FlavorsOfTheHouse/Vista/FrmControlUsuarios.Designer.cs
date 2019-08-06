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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrarFormulario = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnCerrarFormulario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 25);
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
            // FrmControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 522);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControlUsuarios";
            this.Text = "FrmControlUsuarios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrarFormulario;
    }
}
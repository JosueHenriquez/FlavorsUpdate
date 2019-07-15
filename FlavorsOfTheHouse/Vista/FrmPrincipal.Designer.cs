namespace FlavorsOfTheHouse.Vista
{
    partial class FrmPrincipal
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.PanelReporte = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelAdministracion = new System.Windows.Forms.Panel();
            this.BtnAlumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEmpresas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelVentas = new System.Windows.Forms.Panel();
            this.PanelInventario2 = new System.Windows.Forms.Panel();
            this.BtnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAdministracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BarraTitulo = new System.Windows.Forms.ToolStrip();
            this.BtnMenu = new System.Windows.Forms.ToolStripButton();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMaximizar = new System.Windows.Forms.ToolStripButton();
            this.BtnNormal = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.PanelLinea = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.lblConectado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LblFrmActual = new System.Windows.Forms.ToolStripLabel();
            this.LblFActual = new System.Windows.Forms.ToolStripLabel();
            this.BtnAcercaDe = new System.Windows.Forms.ToolStripButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.AnimacionAdministracion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionInventario = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelSidebar.SuspendLayout();
            this.PanelReporte.SuspendLayout();
            this.PanelAdministracion.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(132)))));
            this.PanelSidebar.Controls.Add(this.PanelReporte);
            this.PanelSidebar.Controls.Add(this.PanelAdministracion);
            this.PanelSidebar.Controls.Add(this.PanelVentas);
            this.PanelSidebar.Controls.Add(this.PanelInventario2);
            this.PanelSidebar.Controls.Add(this.BtnVentas);
            this.PanelSidebar.Controls.Add(this.BtnInventario);
            this.PanelSidebar.Controls.Add(this.BtnAdministracion);
            this.AnimacionInventario.SetDecoration(this.PanelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 25);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(718, 636);
            this.PanelSidebar.TabIndex = 1;
            // 
            // PanelReporte
            // 
            this.PanelReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelReporte.Controls.Add(this.bunifuFlatButton1);
            this.PanelReporte.Controls.Add(this.BtnReportes);
            this.PanelReporte.Controls.Add(this.BtnGraficos);
            this.AnimacionInventario.SetDecoration(this.PanelReporte, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelReporte, BunifuAnimatorNS.DecorationType.None);
            this.PanelReporte.Location = new System.Drawing.Point(233, 179);
            this.PanelReporte.Name = "PanelReporte";
            this.PanelReporte.Size = new System.Drawing.Size(236, 135);
            this.PanelReporte.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton3";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 89);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(236, 46);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "bunifuFlatButton3";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnReportes
            // 
            this.BtnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReportes.BorderRadius = 0;
            this.BtnReportes.ButtonText = "      Reporte de Ventas";
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnReportes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnReportes, BunifuAnimatorNS.DecorationType.None);
            this.BtnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReportes.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.list;
            this.BtnReportes.Iconimage_right = null;
            this.BtnReportes.Iconimage_right_Selected = null;
            this.BtnReportes.Iconimage_Selected = null;
            this.BtnReportes.IconMarginLeft = 0;
            this.BtnReportes.IconMarginRight = 0;
            this.BtnReportes.IconRightVisible = true;
            this.BtnReportes.IconRightZoom = 0D;
            this.BtnReportes.IconVisible = true;
            this.BtnReportes.IconZoom = 35D;
            this.BtnReportes.IsTab = false;
            this.BtnReportes.Location = new System.Drawing.Point(0, 45);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnReportes.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReportes.selected = false;
            this.BtnReportes.Size = new System.Drawing.Size(236, 46);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "      Reporte de Ventas";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Textcolor = System.Drawing.Color.White;
            this.BtnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnGraficos
            // 
            this.BtnGraficos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGraficos.BorderRadius = 0;
            this.BtnGraficos.ButtonText = "      Gráficos";
            this.BtnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.BtnGraficos.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGraficos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGraficos.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.circles_extend_button;
            this.BtnGraficos.Iconimage_right = null;
            this.BtnGraficos.Iconimage_right_Selected = null;
            this.BtnGraficos.Iconimage_Selected = null;
            this.BtnGraficos.IconMarginLeft = 0;
            this.BtnGraficos.IconMarginRight = 0;
            this.BtnGraficos.IconRightVisible = true;
            this.BtnGraficos.IconRightZoom = 0D;
            this.BtnGraficos.IconVisible = true;
            this.BtnGraficos.IconZoom = 35D;
            this.BtnGraficos.IsTab = false;
            this.BtnGraficos.Location = new System.Drawing.Point(0, 0);
            this.BtnGraficos.Name = "BtnGraficos";
            this.BtnGraficos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnGraficos.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGraficos.selected = false;
            this.BtnGraficos.Size = new System.Drawing.Size(236, 46);
            this.BtnGraficos.TabIndex = 7;
            this.BtnGraficos.Text = "      Gráficos";
            this.BtnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGraficos.Textcolor = System.Drawing.Color.White;
            this.BtnGraficos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanelAdministracion
            // 
            this.PanelAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelAdministracion.Controls.Add(this.BtnAlumnos);
            this.PanelAdministracion.Controls.Add(this.BtnEmpresas);
            this.PanelAdministracion.Controls.Add(this.BtnUsuarios);
            this.AnimacionInventario.SetDecoration(this.PanelAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.PanelAdministracion.Location = new System.Drawing.Point(233, 38);
            this.PanelAdministracion.Name = "PanelAdministracion";
            this.PanelAdministracion.Size = new System.Drawing.Size(236, 135);
            this.PanelAdministracion.TabIndex = 0;
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlumnos.BorderRadius = 0;
            this.BtnAlumnos.ButtonText = "      Alumnos Inscritos";
            this.BtnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnAlumnos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnAlumnos, BunifuAnimatorNS.DecorationType.None);
            this.BtnAlumnos.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAlumnos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlumnos.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.list_of_three_elements_on_black_background;
            this.BtnAlumnos.Iconimage_right = null;
            this.BtnAlumnos.Iconimage_right_Selected = null;
            this.BtnAlumnos.Iconimage_Selected = null;
            this.BtnAlumnos.IconMarginLeft = 0;
            this.BtnAlumnos.IconMarginRight = 0;
            this.BtnAlumnos.IconRightVisible = true;
            this.BtnAlumnos.IconRightZoom = 0D;
            this.BtnAlumnos.IconVisible = true;
            this.BtnAlumnos.IconZoom = 35D;
            this.BtnAlumnos.IsTab = false;
            this.BtnAlumnos.Location = new System.Drawing.Point(0, 90);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnAlumnos.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnAlumnos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAlumnos.selected = false;
            this.BtnAlumnos.Size = new System.Drawing.Size(237, 46);
            this.BtnAlumnos.TabIndex = 8;
            this.BtnAlumnos.Text = "      Alumnos Inscritos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumnos.Textcolor = System.Drawing.Color.White;
            this.BtnAlumnos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnEmpresas
            // 
            this.BtnEmpresas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnEmpresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpresas.BorderRadius = 0;
            this.BtnEmpresas.ButtonText = "      Puestos de Trabajo";
            this.BtnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnEmpresas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnEmpresas, BunifuAnimatorNS.DecorationType.None);
            this.BtnEmpresas.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEmpresas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEmpresas.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.shopping_cart;
            this.BtnEmpresas.Iconimage_right = null;
            this.BtnEmpresas.Iconimage_right_Selected = null;
            this.BtnEmpresas.Iconimage_Selected = null;
            this.BtnEmpresas.IconMarginLeft = 0;
            this.BtnEmpresas.IconMarginRight = 0;
            this.BtnEmpresas.IconRightVisible = true;
            this.BtnEmpresas.IconRightZoom = 0D;
            this.BtnEmpresas.IconVisible = true;
            this.BtnEmpresas.IconZoom = 35D;
            this.BtnEmpresas.IsTab = false;
            this.BtnEmpresas.Location = new System.Drawing.Point(0, 45);
            this.BtnEmpresas.Name = "BtnEmpresas";
            this.BtnEmpresas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnEmpresas.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnEmpresas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEmpresas.selected = false;
            this.BtnEmpresas.Size = new System.Drawing.Size(237, 46);
            this.BtnEmpresas.TabIndex = 8;
            this.BtnEmpresas.Text = "      Puestos de Trabajo";
            this.BtnEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpresas.Textcolor = System.Drawing.Color.White;
            this.BtnEmpresas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUsuarios.BorderRadius = 0;
            this.BtnUsuarios.ButtonText = "      Usuarios";
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.BtnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUsuarios.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.user_shape;
            this.BtnUsuarios.Iconimage_right = null;
            this.BtnUsuarios.Iconimage_right_Selected = null;
            this.BtnUsuarios.Iconimage_Selected = null;
            this.BtnUsuarios.IconMarginLeft = 0;
            this.BtnUsuarios.IconMarginRight = 0;
            this.BtnUsuarios.IconRightVisible = true;
            this.BtnUsuarios.IconRightZoom = 0D;
            this.BtnUsuarios.IconVisible = true;
            this.BtnUsuarios.IconZoom = 35D;
            this.BtnUsuarios.IsTab = false;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(147)))), ((int)(((byte)(188)))));
            this.BtnUsuarios.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUsuarios.selected = false;
            this.BtnUsuarios.Size = new System.Drawing.Size(237, 46);
            this.BtnUsuarios.TabIndex = 7;
            this.BtnUsuarios.Text = "      Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Textcolor = System.Drawing.Color.White;
            this.BtnUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanelVentas
            // 
            this.PanelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AnimacionInventario.SetDecoration(this.PanelVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelVentas, BunifuAnimatorNS.DecorationType.None);
            this.PanelVentas.Location = new System.Drawing.Point(468, 38);
            this.PanelVentas.Name = "PanelVentas";
            this.PanelVentas.Size = new System.Drawing.Size(219, 139);
            this.PanelVentas.TabIndex = 0;
            // 
            // PanelInventario2
            // 
            this.PanelInventario2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AnimacionInventario.SetDecoration(this.PanelInventario2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelInventario2, BunifuAnimatorNS.DecorationType.None);
            this.PanelInventario2.Location = new System.Drawing.Point(468, 183);
            this.PanelInventario2.Name = "PanelInventario2";
            this.PanelInventario2.Size = new System.Drawing.Size(219, 139);
            this.PanelInventario2.TabIndex = 0;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(233)))));
            this.BtnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentas.BorderRadius = 0;
            this.BtnVentas.ButtonText = "      Reporte de Ventas";
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnVentas, BunifuAnimatorNS.DecorationType.None);
            this.BtnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Iconimage")));
            this.BtnVentas.Iconimage_right = null;
            this.BtnVentas.Iconimage_right_Selected = null;
            this.BtnVentas.Iconimage_Selected = null;
            this.BtnVentas.IconMarginLeft = 0;
            this.BtnVentas.IconMarginRight = 0;
            this.BtnVentas.IconRightVisible = true;
            this.BtnVentas.IconRightZoom = 0D;
            this.BtnVentas.IconVisible = true;
            this.BtnVentas.IconZoom = 45D;
            this.BtnVentas.IsTab = false;
            this.BtnVentas.Location = new System.Drawing.Point(0, 136);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(234)))));
            this.BtnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVentas.selected = false;
            this.BtnVentas.Size = new System.Drawing.Size(236, 48);
            this.BtnVentas.TabIndex = 6;
            this.BtnVentas.Text = "      Reporte de Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Textcolor = System.Drawing.Color.White;
            this.BtnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnInventario
            // 
            this.BtnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(233)))));
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.BorderRadius = 0;
            this.BtnInventario.ButtonText = "      Inventario";
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnInventario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnInventario, BunifuAnimatorNS.DecorationType.None);
            this.BtnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInventario.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.books;
            this.BtnInventario.Iconimage_right = null;
            this.BtnInventario.Iconimage_right_Selected = null;
            this.BtnInventario.Iconimage_Selected = null;
            this.BtnInventario.IconMarginLeft = 0;
            this.BtnInventario.IconMarginRight = 0;
            this.BtnInventario.IconRightVisible = true;
            this.BtnInventario.IconRightZoom = 0D;
            this.BtnInventario.IconVisible = true;
            this.BtnInventario.IconZoom = 45D;
            this.BtnInventario.IsTab = false;
            this.BtnInventario.Location = new System.Drawing.Point(0, 87);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnInventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(234)))));
            this.BtnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInventario.selected = false;
            this.BtnInventario.Size = new System.Drawing.Size(236, 48);
            this.BtnInventario.TabIndex = 1;
            this.BtnInventario.Text = "      Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Textcolor = System.Drawing.Color.White;
            this.BtnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnAdministracion
            // 
            this.BtnAdministracion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(233)))));
            this.BtnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdministracion.BorderRadius = 0;
            this.BtnAdministracion.ButtonText = "      Administración";
            this.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.BtnAdministracion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAdministracion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAdministracion.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.settings_cogwheel_button;
            this.BtnAdministracion.Iconimage_right = null;
            this.BtnAdministracion.Iconimage_right_Selected = null;
            this.BtnAdministracion.Iconimage_Selected = null;
            this.BtnAdministracion.IconMarginLeft = 0;
            this.BtnAdministracion.IconMarginRight = 0;
            this.BtnAdministracion.IconRightVisible = true;
            this.BtnAdministracion.IconRightZoom = 0D;
            this.BtnAdministracion.IconVisible = true;
            this.BtnAdministracion.IconZoom = 45D;
            this.BtnAdministracion.IsTab = false;
            this.BtnAdministracion.Location = new System.Drawing.Point(0, 38);
            this.BtnAdministracion.Name = "BtnAdministracion";
            this.BtnAdministracion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.BtnAdministracion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(234)))));
            this.BtnAdministracion.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAdministracion.selected = false;
            this.BtnAdministracion.Size = new System.Drawing.Size(236, 48);
            this.BtnAdministracion.TabIndex = 0;
            this.BtnAdministracion.Text = "      Administración";
            this.BtnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdministracion.Textcolor = System.Drawing.Color.White;
            this.BtnAdministracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministracion.Click += new System.EventHandler(this.BtnAdministracion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Ricaldone";
            // 
            // BarraTitulo
            // 
            this.AnimacionInventario.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.BarraTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMenu,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.BtnCerrar,
            this.BtnMaximizar,
            this.BtnNormal,
            this.BtnMinimizar,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1284, 25);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Text = "toolStrip1";
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = global::FlavorsOfTheHouse.Properties.Resources.list_button_with_3_elements;
            this.BtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(107, 22);
            this.BtnMenu.Text = "Contraer Menú";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::FlavorsOfTheHouse.Properties.Resources.cancel_button;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "Cerrar Programa";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMaximizar.Image = global::FlavorsOfTheHouse.Properties.Resources.crop_button;
            this.BtnMaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMaximizar.Text = "Maximizar";
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNormal.Image = global::FlavorsOfTheHouse.Properties.Resources.full_screen_exit;
            this.BtnNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(23, 22);
            this.BtnNormal.Text = "Restaurar a tamaño normal";
            this.BtnNormal.Visible = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel2.Text = "Sabores de la casa";
            // 
            // PanelLinea
            // 
            this.PanelLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(132)))));
            this.AnimacionInventario.SetDecoration(this.PanelLinea, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelLinea, BunifuAnimatorNS.DecorationType.None);
            this.PanelLinea.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLinea.Location = new System.Drawing.Point(718, 25);
            this.PanelLinea.Name = "PanelLinea";
            this.PanelLinea.Size = new System.Drawing.Size(566, 3);
            this.PanelLinea.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.AnimacionInventario.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUsuarioConectado,
            this.lblConectado,
            this.toolStripButton1,
            this.LblFrmActual,
            this.LblFActual,
            this.BtnAcercaDe});
            this.toolStrip1.Location = new System.Drawing.Point(718, 636);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblUsuarioConectado
            // 
            this.LblUsuarioConectado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LblUsuarioConectado.Name = "LblUsuarioConectado";
            this.LblUsuarioConectado.Size = new System.Drawing.Size(114, 22);
            this.LblUsuarioConectado.Text = "Usuario Conectado:";
            // 
            // lblConectado
            // 
            this.lblConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(10, 22);
            this.lblConectado.Text = ".";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FlavorsOfTheHouse.Properties.Resources.keyboard_right_arrow_button;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // LblFrmActual
            // 
            this.LblFrmActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LblFrmActual.Name = "LblFrmActual";
            this.LblFrmActual.Size = new System.Drawing.Size(108, 22);
            this.LblFrmActual.Text = "Formulario Actual:";
            // 
            // LblFActual
            // 
            this.LblFActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.LblFActual.Name = "LblFActual";
            this.LblFActual.Size = new System.Drawing.Size(10, 22);
            this.LblFActual.Text = ".";
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnAcercaDe.Image = global::FlavorsOfTheHouse.Properties.Resources.developer_mode_for_smartphones_and_tablets;
            this.BtnAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(82, 22);
            this.BtnAcercaDe.Text = "Acerca de:";
            // 
            // PanelContenedor
            // 
            this.AnimacionInventario.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(718, 28);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(566, 608);
            this.PanelContenedor.TabIndex = 4;
            // 
            // AnimacionAdministracion
            // 
            this.AnimacionAdministracion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionAdministracion.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionAdministracion.DefaultAnimation = animation2;
            // 
            // AnimacionInventario
            // 
            this.AnimacionInventario.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionInventario.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionInventario.DefaultAnimation = animation1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PanelLinea);
            this.Controls.Add(this.PanelSidebar);
            this.Controls.Add(this.BarraTitulo);
            this.AnimacionAdministracion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionInventario.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelSidebar.ResumeLayout(false);
            this.PanelReporte.ResumeLayout(false);
            this.PanelAdministracion.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelSidebar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnNormal;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStrip BarraTitulo;
        private System.Windows.Forms.Panel PanelLinea;
        private System.Windows.Forms.ToolStripButton BtnMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LblUsuarioConectado;
        private System.Windows.Forms.ToolStripLabel lblConectado;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel LblFrmActual;
        private System.Windows.Forms.ToolStripLabel LblFActual;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAdministracion;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInventario;
        private System.Windows.Forms.Panel PanelAdministracion;
        private BunifuAnimatorNS.BunifuTransition AnimacionInventario;
        private BunifuAnimatorNS.BunifuTransition AnimacionAdministracion;
        private System.Windows.Forms.ToolStripButton BtnMaximizar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEmpresas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlumnos;
        private System.Windows.Forms.Panel PanelVentas;
        private System.Windows.Forms.Panel PanelReporte;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGraficos;
        private System.Windows.Forms.ToolStripButton BtnAcercaDe;
        private System.Windows.Forms.Panel PanelInventario2;
    }
}
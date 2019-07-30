﻿namespace FlavorsOfTheHouse.Vista
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnLibros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelInventario = new System.Windows.Forms.Panel();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelVentas = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelAdministracion = new System.Windows.Forms.Panel();
            this.BtnAlumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEmpresas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelLibros = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInventario.SuspendLayout();
            this.PanelVentas.SuspendLayout();
            this.PanelAdministracion.SuspendLayout();
            this.PanelLibros.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(179)))), ((int)(((byte)(30)))));
            this.PanelSidebar.Controls.Add(this.LineaSidebar);
            this.PanelSidebar.Controls.Add(this.lblNivel);
            this.PanelSidebar.Controls.Add(this.lblusuario);
            this.PanelSidebar.Controls.Add(this.pictureBox1);
            this.PanelSidebar.Controls.Add(this.bunifuFlatButton7);
            this.PanelSidebar.Controls.Add(this.BtnLibros);
            this.PanelSidebar.Controls.Add(this.PanelInventario);
            this.PanelSidebar.Controls.Add(this.PanelVentas);
            this.PanelSidebar.Controls.Add(this.PanelAdministracion);
            this.PanelSidebar.Controls.Add(this.PanelLibros);
            this.PanelSidebar.Controls.Add(this.BtnVentas);
            this.PanelSidebar.Controls.Add(this.BtnInventario);
            this.PanelSidebar.Controls.Add(this.BtnAdministracion);
            this.AnimacionInventario.SetDecoration(this.PanelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelSidebar, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 25);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(237, 636);
            this.PanelSidebar.TabIndex = 1;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionInventario.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(6, 107);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(223, 10);
            this.LineaSidebar.TabIndex = 12;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.AnimacionAdministracion.SetDecoration(this.lblNivel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionInventario.SetDecoration(this.lblNivel, BunifuAnimatorNS.DecorationType.None);
            this.lblNivel.Location = new System.Drawing.Point(60, 59);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(35, 15);
            this.lblNivel.TabIndex = 11;
            this.lblNivel.Text = "Nivel";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.AnimacionAdministracion.SetDecoration(this.lblusuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionInventario.SetDecoration(this.lblusuario, BunifuAnimatorNS.DecorationType.None);
            this.lblusuario.Location = new System.Drawing.Point(60, 41);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(49, 15);
            this.lblusuario.TabIndex = 11;
            this.lblusuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.AnimacionAdministracion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionInventario.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::FlavorsOfTheHouse.Properties.Resources.sabores_de_la_casa;
            this.pictureBox1.Location = new System.Drawing.Point(6, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.bunifuFlatButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "      Configuración de Sistema";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.ajustes;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 45D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 563);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(236, 48);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "      Configuración de Sistema";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnLibros
            // 
            this.BtnLibros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLibros.BorderRadius = 0;
            this.BtnLibros.ButtonText = "      Libros de compra y venta";
            this.BtnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnLibros, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnLibros, BunifuAnimatorNS.DecorationType.None);
            this.BtnLibros.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLibros.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLibros.Iconimage = global::FlavorsOfTheHouse.Properties.Resources._293022;
            this.BtnLibros.Iconimage_right = null;
            this.BtnLibros.Iconimage_right_Selected = null;
            this.BtnLibros.Iconimage_Selected = null;
            this.BtnLibros.IconMarginLeft = 0;
            this.BtnLibros.IconMarginRight = 0;
            this.BtnLibros.IconRightVisible = true;
            this.BtnLibros.IconRightZoom = 0D;
            this.BtnLibros.IconVisible = true;
            this.BtnLibros.IconZoom = 45D;
            this.BtnLibros.IsTab = false;
            this.BtnLibros.Location = new System.Drawing.Point(0, 275);
            this.BtnLibros.Name = "BtnLibros";
            this.BtnLibros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnLibros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnLibros.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLibros.selected = false;
            this.BtnLibros.Size = new System.Drawing.Size(236, 48);
            this.BtnLibros.TabIndex = 8;
            this.BtnLibros.Text = "      Libros de compra y venta";
            this.BtnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLibros.Textcolor = System.Drawing.Color.White;
            this.BtnLibros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibros.Click += new System.EventHandler(this.BtnLibros_Click);
            // 
            // PanelInventario
            // 
            this.PanelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelInventario.Controls.Add(this.bunifuFlatButton6);
            this.PanelInventario.Controls.Add(this.bunifuFlatButton3);
            this.PanelInventario.Controls.Add(this.bunifuFlatButton2);
            this.AnimacionInventario.SetDecoration(this.PanelInventario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelInventario, BunifuAnimatorNS.DecorationType.None);
            this.PanelInventario.Location = new System.Drawing.Point(494, 47);
            this.PanelInventario.Name = "PanelInventario";
            this.PanelInventario.Size = new System.Drawing.Size(236, 135);
            this.PanelInventario.TabIndex = 7;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "bunifuFlatButton6";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 89);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(241, 45);
            this.bunifuFlatButton6.TabIndex = 9;
            this.bunifuFlatButton6.Text = "bunifuFlatButton6";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "      Inventario General";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.inventario;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 44);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(237, 46);
            this.bunifuFlatButton3.TabIndex = 9;
            this.bunifuFlatButton3.Text = "      Inventario General";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Registro de productos";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.underline_button;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 35D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, -1);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(237, 46);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "      Registro de productos";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanelVentas
            // 
            this.PanelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelVentas.Controls.Add(this.bunifuFlatButton5);
            this.PanelVentas.Controls.Add(this.BtnReportes);
            this.PanelVentas.Controls.Add(this.BtnGraficos);
            this.AnimacionInventario.SetDecoration(this.PanelVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelVentas, BunifuAnimatorNS.DecorationType.None);
            this.PanelVentas.Location = new System.Drawing.Point(242, 195);
            this.PanelVentas.Name = "PanelVentas";
            this.PanelVentas.Size = new System.Drawing.Size(236, 135);
            this.PanelVentas.TabIndex = 0;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      Ings, Egrs, Ganancias";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.dinero;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 35D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 89);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(236, 46);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Text = "      Ings, Egrs, Ganancias";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnReportes
            // 
            this.BtnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.BtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
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
            this.BtnReportes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
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
            this.BtnGraficos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.BtnGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGraficos.BorderRadius = 0;
            this.BtnGraficos.ButtonText = "      Gráficos de ventas";
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
            this.BtnGraficos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnGraficos.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGraficos.selected = false;
            this.BtnGraficos.Size = new System.Drawing.Size(236, 46);
            this.BtnGraficos.TabIndex = 7;
            this.BtnGraficos.Text = "      Gráficos de ventas";
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
            this.PanelAdministracion.Location = new System.Drawing.Point(242, 46);
            this.PanelAdministracion.Name = "PanelAdministracion";
            this.PanelAdministracion.Size = new System.Drawing.Size(236, 135);
            this.PanelAdministracion.TabIndex = 0;
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.BtnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlumnos.BorderRadius = 0;
            this.BtnAlumnos.ButtonText = "      Registro de Empresas";
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
            this.BtnAlumnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnAlumnos.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnAlumnos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAlumnos.selected = false;
            this.BtnAlumnos.Size = new System.Drawing.Size(237, 46);
            this.BtnAlumnos.TabIndex = 8;
            this.BtnAlumnos.Text = "      Registro de Empresas";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumnos.Textcolor = System.Drawing.Color.White;
            this.BtnAlumnos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnEmpresas
            // 
            this.BtnEmpresas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.BtnEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnEmpresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpresas.BorderRadius = 0;
            this.BtnEmpresas.ButtonText = "      Tipos de usuario";
            this.BtnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnEmpresas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnEmpresas, BunifuAnimatorNS.DecorationType.None);
            this.BtnEmpresas.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEmpresas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEmpresas.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.editarperfil;
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
            this.BtnEmpresas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.BtnEmpresas.OnHovercolor = System.Drawing.Color.Silver;
            this.BtnEmpresas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEmpresas.selected = false;
            this.BtnEmpresas.Size = new System.Drawing.Size(237, 46);
            this.BtnEmpresas.TabIndex = 8;
            this.BtnEmpresas.Text = "      Tipos de usuario";
            this.BtnEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpresas.Textcolor = System.Drawing.Color.White;
            this.BtnEmpresas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
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
            this.BtnUsuarios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
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
            // PanelLibros
            // 
            this.PanelLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelLibros.Controls.Add(this.bunifuFlatButton4);
            this.PanelLibros.Controls.Add(this.bunifuFlatButton1);
            this.AnimacionInventario.SetDecoration(this.PanelLibros, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelLibros, BunifuAnimatorNS.DecorationType.None);
            this.PanelLibros.Location = new System.Drawing.Point(495, 195);
            this.PanelLibros.Name = "PanelLibros";
            this.PanelLibros.Size = new System.Drawing.Size(236, 135);
            this.PanelLibros.TabIndex = 0;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "      Libro de Ventas";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.ingresos;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 35D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1, 45);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(236, 46);
            this.bunifuFlatButton4.TabIndex = 8;
            this.bunifuFlatButton4.Text = "      Libro de Ventas";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Libro de Compras";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.compras;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 35D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(236, 46);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "      Libro de Compras";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnVentas
            // 
            this.BtnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentas.BorderRadius = 0;
            this.BtnVentas.ButtonText = "       Reportes";
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnVentas, BunifuAnimatorNS.DecorationType.None);
            this.BtnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentas.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.libros;
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
            this.BtnVentas.Location = new System.Drawing.Point(0, 226);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVentas.selected = false;
            this.BtnVentas.Size = new System.Drawing.Size(236, 48);
            this.BtnVentas.TabIndex = 6;
            this.BtnVentas.Text = "       Reportes";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Textcolor = System.Drawing.Color.White;
            this.BtnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.BorderRadius = 0;
            this.BtnInventario.ButtonText = "      Inventario";
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnInventario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnInventario, BunifuAnimatorNS.DecorationType.None);
            this.BtnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInventario.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.inventarios;
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
            this.BtnInventario.Location = new System.Drawing.Point(0, 177);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnInventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
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
            this.BtnAdministracion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
            this.BtnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdministracion.BorderRadius = 0;
            this.BtnAdministracion.ButtonText = "      Administración";
            this.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionInventario.SetDecoration(this.BtnAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.BtnAdministracion, BunifuAnimatorNS.DecorationType.None);
            this.BtnAdministracion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAdministracion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAdministracion.Iconimage = global::FlavorsOfTheHouse.Properties.Resources.settings;
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
            this.BtnAdministracion.Location = new System.Drawing.Point(0, 128);
            this.BtnAdministracion.Name = "BtnAdministracion";
            this.BtnAdministracion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BtnAdministracion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(104)))));
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
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.PanelLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(179)))), ((int)(((byte)(30)))));
            this.AnimacionInventario.SetDecoration(this.PanelLinea, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAdministracion.SetDecoration(this.PanelLinea, BunifuAnimatorNS.DecorationType.None);
            this.PanelLinea.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLinea.Location = new System.Drawing.Point(237, 25);
            this.PanelLinea.Name = "PanelLinea";
            this.PanelLinea.Size = new System.Drawing.Size(1047, 3);
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
            this.toolStrip1.Location = new System.Drawing.Point(237, 636);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 25);
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
            this.PanelContenedor.Location = new System.Drawing.Point(237, 28);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1047, 608);
            this.PanelContenedor.TabIndex = 4;
            // 
            // AnimacionAdministracion
            // 
            this.AnimacionAdministracion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionAdministracion.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionAdministracion.DefaultAnimation = animation4;
            // 
            // AnimacionInventario
            // 
            this.AnimacionInventario.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionInventario.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionInventario.DefaultAnimation = animation3;
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
            this.PanelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInventario.ResumeLayout(false);
            this.PanelVentas.ResumeLayout(false);
            this.PanelAdministracion.ResumeLayout(false);
            this.PanelLibros.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGraficos;
        private System.Windows.Forms.ToolStripButton BtnAcercaDe;
        private System.Windows.Forms.Panel PanelLibros;
        private System.Windows.Forms.Panel PanelInventario;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLibros;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblusuario;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
    }
}
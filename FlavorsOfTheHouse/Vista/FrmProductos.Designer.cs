namespace FlavorsOfTheHouse.Vista
{
    partial class FrmProductos
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
            this.BtnCerrar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.ToolStripTextBox();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BtnProductos = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtEmpacado = new System.Windows.Forms.DateTimePicker();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgvDetallesProducto = new System.Windows.Forms.DataGridView();
            this.txtIdHistorial = new System.Windows.Forms.TextBox();
            this.grpDetalleProducto = new System.Windows.Forms.GroupBox();
            this.BtnAgregarDetalle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.BtnCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesProducto)).BeginInit();
            this.grpDetalleProducto.SuspendLayout();
            this.grpProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.txtId,
            this.txtBuscar,
            this.toolStripButton2,
            this.BtnProductos});
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(925, 25);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(164, 22);
            this.toolStripLabel1.Text = "Registro de nuevos productos";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::FlavorsOfTheHouse.Properties.Resources.back_arrow;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(120, 22);
            this.toolStripButton1.Text = "Cerrar Formulario";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtId
            // 
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 25);
            this.txtId.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::FlavorsOfTheHouse.Properties.Resources.searching_magnifying_glass;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "Buscar";
            // 
            // BtnProductos
            // 
            this.BtnProductos.Image = global::FlavorsOfTheHouse.Properties.Resources.clipboard_paste_button;
            this.BtnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(182, 22);
            this.BtnProductos.Text = "Generar reporte de productos";
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProducto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(329, 48);
            this.txtProducto.MaxLength = 45;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(233, 24);
            this.txtProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa a la que pertenece el producto:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio unitario:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(20, 331);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(436, 163);
            this.dgvProductos.TabIndex = 40;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(29, 46);
            this.txtPrecio.MaxLength = 4;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(73, 24);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(148, 97);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(414, 23);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuario que agrega el producto:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(19, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 24);
            this.txtUsuario.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de empacado:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // dtEmpacado
            // 
            this.dtEmpacado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtEmpacado.CustomFormat = "yyyy-MM-dd";
            this.dtEmpacado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEmpacado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmpacado.Location = new System.Drawing.Point(14, 93);
            this.dtEmpacado.Name = "dtEmpacado";
            this.dtEmpacado.Size = new System.Drawing.Size(121, 23);
            this.dtEmpacado.TabIndex = 8;
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtVencimiento.CustomFormat = "yyyy-MM-dd";
            this.dtVencimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVencimiento.Location = new System.Drawing.Point(149, 93);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(131, 23);
            this.dtVencimiento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numCantidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(108, 47);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(172, 23);
            this.numCantidad.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tipo de producto:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(21, 145);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(10, 24);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(112, 36);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.AutoEllipsis = true;
            this.BtnMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.Location = new System.Drawing.Point(122, 24);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(112, 36);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "Mostrar Datos";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(234, 24);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(112, 36);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(346, 24);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 36);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(458, 24);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(112, 36);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(271, 22);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(42, 24);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.BtnMostrar);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimientos";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Codigo del producto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(21, 96);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 24);
            this.txtCodigo.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(14, 144);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(266, 23);
            this.cmbEstado.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(421, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Ver todos los productos, esto incluira el registro de productos vencidos.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductos.Location = new System.Drawing.Point(38, 497);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(173, 15);
            this.lblProductos.TabIndex = 14;
            this.lblProductos.Text = "No hay productos por mostrar";
            this.lblProductos.Visible = false;
            // 
            // dgvDetallesProducto
            // 
            this.dgvDetallesProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDetallesProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesProducto.Location = new System.Drawing.Point(462, 331);
            this.dgvDetallesProducto.Name = "dgvDetallesProducto";
            this.dgvDetallesProducto.ReadOnly = true;
            this.dgvDetallesProducto.Size = new System.Drawing.Size(436, 163);
            this.dgvDetallesProducto.TabIndex = 41;
            // 
            // txtIdHistorial
            // 
            this.txtIdHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdHistorial.Enabled = false;
            this.txtIdHistorial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHistorial.Location = new System.Drawing.Point(238, 17);
            this.txtIdHistorial.Name = "txtIdHistorial";
            this.txtIdHistorial.Size = new System.Drawing.Size(42, 24);
            this.txtIdHistorial.TabIndex = 0;
            this.txtIdHistorial.Visible = false;
            // 
            // grpDetalleProducto
            // 
            this.grpDetalleProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpDetalleProducto.Controls.Add(this.button4);
            this.grpDetalleProducto.Controls.Add(this.button3);
            this.grpDetalleProducto.Controls.Add(this.BtnAgregarDetalle);
            this.grpDetalleProducto.Controls.Add(this.button2);
            this.grpDetalleProducto.Controls.Add(this.cmbEstado);
            this.grpDetalleProducto.Controls.Add(this.numCantidad);
            this.grpDetalleProducto.Controls.Add(this.dtVencimiento);
            this.grpDetalleProducto.Controls.Add(this.dtEmpacado);
            this.grpDetalleProducto.Controls.Add(this.label8);
            this.grpDetalleProducto.Controls.Add(this.txtPrecio);
            this.grpDetalleProducto.Controls.Add(this.txtIdHistorial);
            this.grpDetalleProducto.Controls.Add(this.label3);
            this.grpDetalleProducto.Controls.Add(this.label4);
            this.grpDetalleProducto.Controls.Add(this.label6);
            this.grpDetalleProducto.Controls.Add(this.label7);
            this.grpDetalleProducto.Controls.Add(this.label13);
            this.grpDetalleProducto.Enabled = false;
            this.grpDetalleProducto.Location = new System.Drawing.Point(608, 28);
            this.grpDetalleProducto.Name = "grpDetalleProducto";
            this.grpDetalleProducto.Size = new System.Drawing.Size(290, 270);
            this.grpDetalleProducto.TabIndex = 42;
            this.grpDetalleProducto.TabStop = false;
            this.grpDetalleProducto.Text = "Detalles del producto";
            // 
            // BtnAgregarDetalle
            // 
            this.BtnAgregarDetalle.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDetalle.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarDetalle.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarDetalle.Location = new System.Drawing.Point(22, 177);
            this.BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            this.BtnAgregarDetalle.Size = new System.Drawing.Size(120, 36);
            this.BtnAgregarDetalle.TabIndex = 10;
            this.BtnAgregarDetalle.Text = "Agregar detalle";
            this.BtnAgregarDetalle.UseVisualStyleBackColor = false;
            this.BtnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(149, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Refrescar tabla de detalles";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(22, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Actualizar detalle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(149, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Eliminar Detalle";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // grpProducto
            // 
            this.grpProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpProducto.Controls.Add(this.cmbCategoria);
            this.grpProducto.Controls.Add(this.cmbEmpresa);
            this.grpProducto.Controls.Add(this.label9);
            this.grpProducto.Controls.Add(this.txtCodigo);
            this.grpProducto.Controls.Add(this.label2);
            this.grpProducto.Controls.Add(this.txtIdUsuario);
            this.grpProducto.Controls.Add(this.txtUsuario);
            this.grpProducto.Controls.Add(this.label5);
            this.grpProducto.Controls.Add(this.txtProducto);
            this.grpProducto.Controls.Add(this.label10);
            this.grpProducto.Controls.Add(this.label1);
            this.grpProducto.Location = new System.Drawing.Point(20, 28);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(583, 190);
            this.grpProducto.TabIndex = 43;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Información del producto";
            // 
            // lbldetalle
            // 
            this.lbldetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldetalle.Location = new System.Drawing.Point(462, 498);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(173, 15);
            this.lbldetalle.TabIndex = 14;
            this.lbldetalle.Text = "No hay productos por mostrar";
            this.lbldetalle.Visible = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 522);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.grpDetalleProducto);
            this.Controls.Add(this.dgvDetallesProducto);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.BtnCerrar.ResumeLayout(false);
            this.BtnCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesProducto)).EndInit();
            this.grpDetalleProducto.ResumeLayout(false);
            this.grpDetalleProducto.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BtnCerrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox txtId;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEmpacado;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ToolStripButton BtnProductos;
        private System.Windows.Forms.DataGridView dgvDetallesProducto;
        private System.Windows.Forms.TextBox txtIdHistorial;
        private System.Windows.Forms.GroupBox grpDetalleProducto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnAgregarDetalle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lbldetalle;
    }
}
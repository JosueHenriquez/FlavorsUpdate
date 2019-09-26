namespace FlavorsOfTheHouse.Vista
{
    partial class FrmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualizarDetalle = new System.Windows.Forms.Button();
            this.dtfechafactura = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnAnularFactura = new System.Windows.Forms.Button();
            this.BtnCrearFactura = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdusuario = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDetallesFactura = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDetalleFactura = new System.Windows.Forms.TextBox();
            this.dgvdetalleproductos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(142, 22);
            this.toolStripLabel1.Text = "Facturación de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de factura:";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFactura.Location = new System.Drawing.Point(30, 61);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(156, 25);
            this.txtIdFactura.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del cajero:";
            // 
            // txtCajero
            // 
            this.txtCajero.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajero.Location = new System.Drawing.Point(29, 111);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.ReadOnly = true;
            this.txtCajero.Size = new System.Drawing.Size(436, 25);
            this.txtCajero.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualizarDetalle);
            this.groupBox1.Controls.Add(this.dtfechafactura);
            this.groupBox1.Controls.Add(this.BtnEliminarProducto);
            this.groupBox1.Controls.Add(this.BtnInventario);
            this.groupBox1.Controls.Add(this.BtnFinalizar);
            this.groupBox1.Controls.Add(this.BtnAnularFactura);
            this.groupBox1.Controls.Add(this.BtnCrearFactura);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDisponible);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCajero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdusuario);
            this.groupBox1.Controls.Add(this.txtIdFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 408);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación de factura";
            // 
            // BtnActualizarDetalle
            // 
            this.BtnActualizarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnActualizarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnActualizarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarDetalle.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarDetalle.Location = new System.Drawing.Point(32, 349);
            this.BtnActualizarDetalle.Name = "BtnActualizarDetalle";
            this.BtnActualizarDetalle.Size = new System.Drawing.Size(134, 34);
            this.BtnActualizarDetalle.TabIndex = 16;
            this.BtnActualizarDetalle.Text = "Actualizar Detalle";
            this.BtnActualizarDetalle.UseVisualStyleBackColor = false;
            this.BtnActualizarDetalle.Click += new System.EventHandler(this.BtnActualizarDetalle_Click);
            // 
            // dtfechafactura
            // 
            this.dtfechafactura.CustomFormat = "yyyy-MM-dd";
            this.dtfechafactura.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtfechafactura.Enabled = false;
            this.dtfechafactura.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechafactura.Location = new System.Drawing.Point(28, 161);
            this.dtfechafactura.Name = "dtfechafactura";
            this.dtfechafactura.Size = new System.Drawing.Size(436, 25);
            this.dtfechafactura.TabIndex = 4;
            this.dtfechafactura.Value = new System.DateTime(2019, 9, 7, 0, 0, 0, 0);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(312, 311);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(134, 34);
            this.BtnEliminarProducto.TabIndex = 13;
            this.BtnEliminarProducto.Text = "Eliminar del detalle";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Location = new System.Drawing.Point(172, 351);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(134, 34);
            this.BtnInventario.TabIndex = 12;
            this.BtnInventario.Text = "Consultar inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizar.Location = new System.Drawing.Point(172, 311);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(134, 34);
            this.BtnFinalizar.TabIndex = 14;
            this.BtnFinalizar.Text = "Finalizar factura";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnAnularFactura
            // 
            this.BtnAnularFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAnularFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnularFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnularFactura.ForeColor = System.Drawing.Color.White;
            this.BtnAnularFactura.Location = new System.Drawing.Point(312, 351);
            this.BtnAnularFactura.Name = "BtnAnularFactura";
            this.BtnAnularFactura.Size = new System.Drawing.Size(134, 34);
            this.BtnAnularFactura.TabIndex = 15;
            this.BtnAnularFactura.Text = "Anular factura";
            this.BtnAnularFactura.UseVisualStyleBackColor = false;
            this.BtnAnularFactura.Click += new System.EventHandler(this.BtnAnularFactura_Click);
            // 
            // BtnCrearFactura
            // 
            this.BtnCrearFactura.BackColor = System.Drawing.Color.Green;
            this.BtnCrearFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearFactura.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearFactura.ForeColor = System.Drawing.Color.White;
            this.BtnCrearFactura.Location = new System.Drawing.Point(192, 54);
            this.BtnCrearFactura.Name = "BtnCrearFactura";
            this.BtnCrearFactura.Size = new System.Drawing.Size(152, 38);
            this.BtnCrearFactura.TabIndex = 0;
            this.BtnCrearFactura.Text = "Crear factura";
            this.BtnCrearFactura.UseVisualStyleBackColor = false;
            this.BtnCrearFactura.Click += new System.EventHandler(this.BtnCrearFactura_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(32, 311);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(134, 34);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar a factura";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha de facturación:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(227, 211);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(237, 25);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(367, 261);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(97, 25);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtPrecio.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // txtDisponible
            // 
            this.txtDisponible.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponible.Location = new System.Drawing.Point(227, 261);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Size = new System.Drawing.Size(129, 25);
            this.txtDisponible.TabIndex = 5;
            this.txtDisponible.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtDisponible.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(30, 261);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(188, 25);
            this.txtNombreProducto.TabIndex = 5;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtNombreProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(28, 211);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(190, 25);
            this.txtCodigoProducto.TabIndex = 5;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad a vender:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(364, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Precio unitario:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cantidad disponible";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del producto:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código o nombre de producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID Usuario";
            // 
            // txtIdusuario
            // 
            this.txtIdusuario.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdusuario.Location = new System.Drawing.Point(421, 65);
            this.txtIdusuario.Name = "txtIdusuario";
            this.txtIdusuario.ReadOnly = true;
            this.txtIdusuario.Size = new System.Drawing.Size(43, 25);
            this.txtIdusuario.TabIndex = 2;
            this.txtIdusuario.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(861, 37);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(42, 25);
            this.txtIdProducto.TabIndex = 7;
            this.txtIdProducto.Visible = false;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // txtPago
            // 
            this.txtPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPago.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPago.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.Lime;
            this.txtPago.Location = new System.Drawing.Point(386, 446);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(144, 64);
            this.txtPago.TabIndex = 17;
            this.txtPago.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(257, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total a pagar $";
            // 
            // dgvDetallesFactura
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.dgvDetallesFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallesFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFactura.Location = new System.Drawing.Point(550, 231);
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.dgvDetallesFactura.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(353, 279);
            this.dgvDetallesFactura.TabIndex = 16;
            this.dgvDetallesFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesFactura_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Detalle de factura:";
            // 
            // txtIdDetalleFactura
            // 
            this.txtIdDetalleFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdDetalleFactura.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalleFactura.Location = new System.Drawing.Point(861, 203);
            this.txtIdDetalleFactura.Name = "txtIdDetalleFactura";
            this.txtIdDetalleFactura.ReadOnly = true;
            this.txtIdDetalleFactura.Size = new System.Drawing.Size(42, 25);
            this.txtIdDetalleFactura.TabIndex = 7;
            this.txtIdDetalleFactura.Visible = false;
            this.txtIdDetalleFactura.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // dgvdetalleproductos
            // 
            this.dgvdetalleproductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalleproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetalleproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleproductos.Location = new System.Drawing.Point(550, 65);
            this.dgvdetalleproductos.Name = "dgvdetalleproductos";
            this.dgvdetalleproductos.Size = new System.Drawing.Size(353, 132);
            this.dgvdetalleproductos.TabIndex = 18;
            this.dgvdetalleproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalleproductos_CellClick);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(547, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Producto en buen estado:";
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.Location = new System.Drawing.Point(813, 37);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.ReadOnly = true;
            this.txtIdDetalle.Size = new System.Drawing.Size(42, 25);
            this.txtIdDetalle.TabIndex = 7;
            this.txtIdDetalle.Visible = false;
            this.txtIdDetalle.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 522);
            this.Controls.Add(this.dgvdetalleproductos);
            this.Controls.Add(this.dgvDetallesFactura);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdDetalleFactura);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.txtIdProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDetallesFactura;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdusuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAnularFactura;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnCrearFactura;
        private System.Windows.Forms.DateTimePicker dtfechafactura;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdDetalleFactura;
        private System.Windows.Forms.Button BtnActualizarDetalle;
        private System.Windows.Forms.DataGridView dgvdetalleproductos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdDetalle;
    }
}
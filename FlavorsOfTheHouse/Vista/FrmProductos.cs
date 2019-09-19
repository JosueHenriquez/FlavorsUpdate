using System;
using FlavorsOfTheHouse.Reportes;
using FlavorsOfTheHouse.Controlador;
using FlavorsOfTheHouse.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        void LimpiarCampos()
        {
            txtId.Clear();
            txtUsuario.Text = Constructor_Login.nombre;
            txtIdUsuario.Text = Constructor_Login.id_usuario.ToString();
            txtProducto.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            numCantidad.Value = 0;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
            
            txtCodigo.Enabled = true;
        }
        void Ingresar_Producto()
        {
            DateTime hoy = DateTime.Today;
            if (txtProducto.Text.Trim() == "" ||
                txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("El campo producto o codigo de producto están vacíos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtEmpacado.Value.Date > hoy)
            {
                MessageBox.Show("La fecha de empacado del producto no puede ser mayor a la fecha actual.", "Error en fecha de empacado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtVencimiento.Value.Date < dtEmpacado.Value.Date)
            {
                MessageBox.Show("La fecha de vencimiento del producto no puede ser menor a la fecha empacado.", "Error en fecha de vencimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ControlProductos.Verificar_Codigo(int.Parse(txtCodigo.Text)) == true)
            {
                MessageBox.Show("El código de producto que desea ingresar ya existe en la base de datos.", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt16(numCantidad.Text) == 0)
            {
                MessageBox.Show("La cantidad de productos que desea agregar no puede ser igual a cero.","Error lógico",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_Producto pro = new Constructor_Producto();
                pro.id_usuario = Convert.ToInt16(txtIdUsuario.Text);
                pro.producto = txtProducto.Text;
                pro.codigo_producto = int.Parse(txtCodigo.Text);
                pro.id_empresa = Convert.ToInt16(Constructor_Login.empresa);
                pro.id_tipo = Convert.ToInt16(cmbCategoria.SelectedValue);
                int datos = ControlProductos.Ingresar_Producto(pro);
                if (datos > 0)
                {
                    pro.precio = txtPrecio.Text;
                    pro.empacado = dtEmpacado.Text;
                    pro.vencimiento = dtVencimiento.Text;
                    pro.cantidad = Convert.ToInt16(numCantidad.Text);
                    pro.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                }      
            }
        }
        void Cargar_Productos()
        {
            if (ControlProductos.Cargar_Productos() != null)
            {
                this.dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProductos.DataSource = ControlProductos.Cargar_Productos();
                lblProductos.Visible = false;
                this.dgvProductos.Columns[0].Visible = false;
                this.dgvProductos.Columns[1].HeaderText = "Nombre del producto";
                this.dgvProductos.Columns[1].Width = 100;
                this.dgvProductos.Columns[2].HeaderText = "Codigo de producto";
                this.dgvProductos.Columns[2].Width = 50;
                this.dgvProductos.Columns[3].Visible = false;
                this.dgvProductos.Columns[4].Visible = false;
                this.dgvProductos.Columns[5].Visible = false;
                this.dgvProductos.Columns[6].HeaderText = "Tipo de producto";
                this.dgvProductos.Columns[6].Width = 50;
                this.dgvProductos.Columns[7].HeaderText = "Empresa";
                this.dgvProductos.Columns[7].Width = 50;
                this.dgvProductos.Columns[8].HeaderText = "Usuario que agrego el producto";
                this.dgvProductos.Columns[8].Width = 150;
            }
            else
            {
                lblProductos.Visible = true;
            }
        }
        void Actualizar_Productos()
        {
            Constructor_Producto prod = new Constructor_Producto();
            prod.id_producto = Convert.ToInt16(txtId.Text);
            prod.id_usuario = Convert.ToInt16(txtIdUsuario.Text);
            prod.producto = txtProducto.Text;
            prod.id_tipo = Convert.ToInt16(cmbCategoria.SelectedValue);
            prod.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
            int data = ControlProductos.Actualizar_Producto(prod);
            if (data > 0)
            {
                if (MessageBox.Show("¿Desea cambiar algun dato especifico en alguna puesta en marcha registrada?","Actualizar datos",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    prod.precio = txtPrecio.Text;
                    prod.empacado = dtEmpacado.Text;
                    prod.vencimiento = dtVencimiento.Text;
                    prod.cantidad = Convert.ToInt16(numCantidad.Text);
                    prod.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                    int datos = ControlProductos.Actualizar_Producto_Historial(prod);
                    if (datos > 0)
                    {

                    }
                }
            }
        }
        void Eliminar_Producto(int idproducto)
        {
            ControlProductos.Eliminar_Producto(idproducto);
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Productos();

                txtIdUsuario.Text = Constructor_Login.id_usuario.ToString();
                txtUsuario.Text = Constructor_Login_Datos.nombre;
                if (Constructor_Login.nivel < 3)
                {
                    cmbEmpresa.Enabled = true;
                    cmbEmpresa.DataSource = ControlProductos.ObtenerEmpresas();
                    cmbEmpresa.DisplayMember = "empresa";
                    cmbEmpresa.ValueMember = "id_empresa";
                }
                else
                {
                    cmbEmpresa.Enabled = false;
                    cmbEmpresa.DataSource = ControlProductos.ObtenerEmpresa(Convert.ToInt16(txtIdUsuario.Text));
                    cmbEmpresa.DisplayMember = "empresa";
                    cmbEmpresa.ValueMember = "Empresa";
                }
                cmbCategoria.DataSource = ControlProductos.Cargar_Tipo_Productos();
                cmbCategoria.DisplayMember = "categoria";
                cmbCategoria.ValueMember = "id_categoria_producto";

                cmbEstado.DataSource = ControlProductos.Cargar_Estado_Productos();
                cmbEstado.DisplayMember = "estado_producto";
                cmbEstado.ValueMember = "id_estado_producto";

                BtnAgregar.Enabled = true;
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar la empresas. " +ex ,"Error de proceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que en campo de precio solo se acepte un punto decimal
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_Producto();
            Cargar_Productos();
            LimpiarCampos();
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Cargar_Productos();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer actualizar los datos del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Actualizar_Productos();
                Cargar_Productos();                
            }
            LimpiarCampos();
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = 0;
            pos = this.dgvProductos.CurrentRow.Index;
            txtId.Text = this.dgvProductos[0, pos].Value.ToString();
            txtProducto.Text = this.dgvProductos[1, pos].Value.ToString();
            txtCodigo.Text = this.dgvProductos[2, pos].Value.ToString();
            txtIdUsuario.Text = this.dgvProductos[3, pos].Value.ToString();           
            cmbCategoria.Text = this.dgvProductos[6, pos].Value.ToString();
            cmbEmpresa.Text = this.dgvProductos[7, pos].Value.ToString();
            txtUsuario.Text = this.dgvProductos[8, pos].Value.ToString();
            BtnAgregar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            txtCodigo.Enabled = false;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer limpiar los campos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer eliminar los datos del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Eliminar_Producto(Convert.ToInt16(txtId.Text));
                Cargar_Productos();
            }            
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ReporteProductos repro = new ReporteProductos();
            repro.Show();
        }
    }
}

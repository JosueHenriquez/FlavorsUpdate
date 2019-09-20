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
            bool resultado = ControlProductos.Verificar_Codigo(txtCodigo.Text);
            DateTime hoy = DateTime.Today;
            if (txtProducto.Text.Trim() == "" ||
                txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("El campo producto o codigo de producto están vacíos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == true)
            {
                MessageBox.Show("El código de producto que desea ingresar ya existe en la base de datos.", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_Producto pro = new Constructor_Producto();
                pro.producto = txtProducto.Text;
                pro.codigo_producto = txtCodigo.Text;
                pro.id_empresa = Convert.ToInt16(Constructor_Login.empresa);
                pro.id_tipo = Convert.ToInt16(cmbCategoria.SelectedValue);
                int datos = ControlProductos.Ingresar_Producto(pro);
                if (datos > 0)
                {
                    txtId.Text = Constructor_Producto.id_producto.ToString();
                    grpDetalleProducto.Enabled = true;
                    dgvProductos.Enabled = false;
                    grpProducto.Enabled = false;
                }      
            }
        }
        void cproductos()
        {
            lblProductos.Visible = false;
            this.dgvProductos.Columns[0].Visible = false;
            this.dgvProductos.Columns[1].HeaderText = "Nombre del producto";
            this.dgvProductos.Columns[1].Width = 40;
            this.dgvProductos.Columns[2].HeaderText = "Codigo de producto";
            this.dgvProductos.Columns[2].Width = 20;
            this.dgvProductos.Columns[3].Visible = false;
            this.dgvProductos.Columns[4].Visible = false;
            this.dgvProductos.Columns[5].HeaderText = "Tipo de producto";
            this.dgvProductos.Columns[5].Width = 30;
            this.dgvProductos.Columns[6].HeaderText = "Empresa";
            this.dgvProductos.Columns[6].Width = 110;
        }
        void Cargar_Productos()
        {
            if (Constructor_Login.empresa == 1)
            {
                if (ControlProductos.Cargar_ProductosGeneral() != null)
                {
                    this.dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvProductos.DataSource = ControlProductos.Cargar_ProductosGeneral();
                    cproductos();
                }                
            }
            else if (ControlProductos.Cargar_Productos() != null)
            {
                this.dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProductos.DataSource = ControlProductos.Cargar_Productos();
                cproductos();
            }
            else
            {
                lblProductos.Visible = true;
            }
        }
        void Actualizar_Productos()
        {
            Constructor_Producto prod = new Constructor_Producto();
            Constructor_Producto.id_producto = Convert.ToInt16(txtId.Text);
            prod.producto = txtProducto.Text;
            prod.id_tipo = Convert.ToInt16(cmbCategoria.SelectedValue);
            prod.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
            int data = ControlProductos.Actualizar_Producto(prod);
            if (data > 0)
            {
                if (MessageBox.Show("¿Desea cambiar algun dato especifico en alguna puesta en marcha registrada?","Actualizar datos",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    grpDetalleProducto.Enabled = true;
                    //prod.id_usuario = Convert.ToInt16(txtIdUsuario.Text);
                    //prod.precio = txtPrecio.Text;
                    //prod.empacado = dtEmpacado.Text;
                    //prod.vencimiento = dtVencimiento.Text;
                    //prod.cantidad = Convert.ToInt16(numCantidad.Text);
                    //prod.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                    //int datos = ControlProductos.Actualizar_Producto_Historial(prod);
                    //if (datos > 0)
                    //{

                    //}
                }
                else
                {
                    grpDetalleProducto.Enabled = false;
                    LimpiarCampos();
                    grpProducto.Enabled = false;
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
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = 0;
            pos = this.dgvProductos.CurrentRow.Index;
            txtId.Text = this.dgvProductos[0, pos].Value.ToString();
            txtProducto.Text = this.dgvProductos[1, pos].Value.ToString();
            txtCodigo.Text = this.dgvProductos[2, pos].Value.ToString();
            //txtIdUsuario.Text = this.dgvProductos[3, pos].Value.ToString();           
            cmbCategoria.Text = this.dgvProductos[5, pos].Value.ToString();
            cmbEmpresa.Text = this.dgvProductos[6, pos].Value.ToString();
            //txtUsuario.Text = this.dgvProductos[8, pos].Value.ToString();
            BtnAgregar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            txtCodigo.Enabled = false;
            DataTable resultado = ControlProductos.CargarDetalle_Productos(Convert.ToInt16(txtId.Text));
            if (resultado != null)
            {
                dgvDetallesProducto.DataSource = resultado;
                lbldetalle.Visible = false;
                dgvDetallesProducto.Columns[0].Visible = false;
                dgvDetallesProducto.Columns[1].Visible = true;
                dgvDetallesProducto.Columns[2].Visible = false;
                dgvDetallesProducto.Columns[3].Visible = true;
                dgvDetallesProducto.Columns[4].Visible = false;
                dgvDetallesProducto.Columns[5].Visible = true;
                dgvDetallesProducto.Columns[6].Visible = true;
                dgvDetallesProducto.Columns[7].Visible = false;
                dgvDetallesProducto.Columns[8].Visible = false;
                dgvDetallesProducto.Columns[9].Visible = true;
            }
            else
            {
                lbldetalle.Visible = true;
            }
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

        void AgregarDetalle()
        {
            Constructor_Producto detpro = new Constructor_Producto();
            //ID PRODUCTO ENVIADO DIRECTAMENTE A BASE POR ESO NO SE ENVIA AQUI
            DateTime now = DateTime.Today;
            detpro.fecha_ingreso = now.ToString("yyyy-MM-dd");
            detpro.precio = txtPrecio.Text;
            detpro.empacado = dtEmpacado.Text;
            detpro.vencimiento = dtVencimiento.Text;
            detpro.cantidad = Convert.ToInt16(numCantidad.Text);
            detpro.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
            detpro.id_usuario = Convert.ToInt16(txtIdUsuario.Text);
            int datos = ControlProductos.Ingresar_Detalle_Producto(detpro);
            if (datos > 0)
            {
                grpDetalleProducto.Enabled = false;
                grpProducto.Enabled = true;
                dgvProductos.Enabled = true;
                LimpiarCampos();
            }
        }
        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
            LimpiarCampos();
        }
    }
}

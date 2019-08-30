using System;
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
                pro.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                pro.precio = txtPrecio.Text;
                pro.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                pro.cantidad = Convert.ToInt16(numCantidad.Text);
                pro.id_tipo = Convert.ToInt16(cmbCategoria.SelectedValue);
                pro.empacado = dtEmpacado.Text;
                pro.vencimiento = dtVencimiento.Text;
                ControlProductos.Ingresar_Producto(pro);
            }
        }
        void Cargar_Productos()
        {
            if (ControlProductos.Cargar_Productos() != null)
            {
                dgvProductos.DataSource = ControlProductos.Cargar_Productos();
                lblProductos.Visible = false;
            }
            else
            {
                lblProductos.Visible = true;
            }
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Productos();

                txtIdUsuario.Text = Constructor_Login.id_usuario.ToString();
                txtUsuario.Text = Constructor_Login_Datos.nombre;
                if (Constructor_Login.id_usuario <=2)
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
                cmbCategoria.DisplayMember = "tipo_producto";
                cmbCategoria.ValueMember = "id_tipo_producto";

                cmbEstado.DataSource = ControlProductos.Cargar_Estado_Productos();
                cmbEstado.DisplayMember = "estado_producto";
                cmbEstado.ValueMember = "id_estado_producto";
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
        private void BtnMostrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.F5))
            //{
            //    Cargar_Productos();
            //    MessageBox.Show("Se actualizo la tabla de productos.");
            //}
        }
    }
}

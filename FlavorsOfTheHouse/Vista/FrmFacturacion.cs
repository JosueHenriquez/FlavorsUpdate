using System;
using FlavorsOfTheHouse.Reportes;
using FlavorsOfTheHouse.Config;
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
using System.Globalization;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmFacturacion : Form
    {
        private int pedidoantiguo;
        private int nuevopedido;
        public FrmFacturacion()
        {
            InitializeComponent();
        }
        void LimpiarGrid()
        {
            DataTable dt = (DataTable)dgvdetalleproductos.DataSource;
            dt.Clear();
        }
        void AgregarDetalle()
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("La cantidad de productos no puede estar vacía.","Error de cantidad",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(Convert.ToInt16(txtCantidad.Text) == 0)
            {
                MessageBox.Show("La cantidad de productos no puede ser igual a cero.", "Error de cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt16(txtCantidad.Text) > Convert.ToInt16(txtDisponible.Text))
            {
                MessageBox.Show("No hay suficientes productos para la cantidad que desea vender.", "Error de cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_Detalle_Factura detalle = new Constructor_Detalle_Factura();
                detalle.id_producto = Convert.ToInt16(txtIdDetalle.Text);
                detalle.cantidad = Convert.ToInt16(txtCantidad.Text);
                detalle.id_factura = Convert.ToInt16(txtIdFactura.Text);
                double pago_parcial = Convert.ToInt16(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                detalle.total_parcial = pago_parcial;
                int resultado = ControlFacturacion.IngresarDetalle(detalle);
                if (resultado >= 1)
                {
                    //Actualizar cantidad disponible
                    int cantidad_antigua = Convert.ToInt16(txtDisponible.Text);
                    int cantidad_saliente = Convert.ToInt16(txtCantidad.Text);
                    int cantidad_nueva = cantidad_antigua - cantidad_saliente;
                    int idproducto = Convert.ToInt16(txtIdProducto.Text);
                    int iddetalle = Convert.ToInt16(txtIdDetalle.Text);
                    ControlFacturacion.Actualizar_Cantidad_Productos(idproducto,cantidad_nueva,iddetalle);
                    LimpiarCampos();
                    Calcular_Pago();
                }
            }    
        }
        void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtDisponible.Clear();
            txtCodigoProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }
        void CargarDetalle()
        {
            DataTable datos = ControlFacturacion.ObtenerDetalles(Convert.ToInt16(txtIdFactura.Text));
            if (datos != null)
            {
                dgvDetallesFactura.DataSource = ControlFacturacion.ObtenerDetalles(Convert.ToInt16(txtIdFactura.Text));                
                dgvDetallesFactura.Columns[0].Visible = false;
                dgvDetallesFactura.Columns[1].HeaderText = "Nombre del producto";
                dgvDetallesFactura.Columns[2].HeaderText = "Cantidad";
                dgvDetallesFactura.Columns[2].Width = 70;
                dgvDetallesFactura.Columns[3].HeaderText = "Precio unitario";
                dgvDetallesFactura.Columns[4].HeaderText = "Sub-Total";
                dgvDetallesFactura.Columns[4].Width = 70;
            }
        }
        void Calcular_Pago()
        {
            ControlFacturacion.Calcular_Pago(Convert.ToInt16(txtIdFactura.Text));
            Constructor_Facturacion pago = new Constructor_Facturacion();
            //Se coloca la N para permitir unicamente dos decimales.
            txtPago.Text = Constructor_Facturacion.total_pago.ToString("N");
        }
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            txtIdusuario.Text = Constructor_Login.id_usuario.ToString();
            txtCajero.Text = Constructor_Login.nombre;
            DeshabilitarBotones();
            DeshabilitarCampos();
        }
        void DeshabilitarCampos()
        {
            txtIdProducto.Enabled = false;
            txtIdusuario.Enabled = false;
            txtIdFactura.Enabled = false;
            txtCajero.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtDisponible.Enabled = false;
            txtCodigoProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
        }
        void DeshabilitarBotones()
        {
            BtnAgregar.Enabled = false;
            BtnEliminarProducto.Enabled = false;
            BtnFinalizar.Enabled = false;
            BtnAnularFactura.Enabled = false;
            BtnActualizarDetalle.Enabled = false;
        }
        void HabilitarBotones()
        {
            BtnAgregar.Enabled = true;
            BtnEliminarProducto.Enabled = true;
            BtnFinalizar.Enabled = true;
            BtnAnularFactura.Enabled = true;
            BtnActualizarDetalle.Enabled = true;
        }
        private void BtnCrearFactura_Click(object sender, EventArgs e)
        {
            try
            {
                Constructor_Facturacion fact = new Constructor_Facturacion();
                fact.id_usuario = Convert.ToInt16(txtIdusuario.Text);
                DateTime now = DateTime.Today;
                fact.fecha_factura = now.ToString("yyyy-MM-dd");
                fact.id_estado = 1;
                int resultado = ControlFacturacion.Crear_Factura(fact);
                if (resultado >= 1)
                {
                    txtIdFactura.Text = fact.id_factura.ToString();
                    BtnCrearFactura.Enabled = false;
                    txtCodigoProducto.Enabled = true;
                    BtnAnularFactura.Enabled = true;
                }
                else
                {
                    DeshabilitarBotones();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = false;
            }
        }
        private void txtCodigoProducto_Leave_1(object sender, EventArgs e)
        {
            try
            {
                DataTable data = ControlFacturacion.Buscar_Detalle_Productos(txtCodigoProducto.Text);
                if (data == null)
                {
                    DeshabilitarBotones();
                    //txtCantidad.Enabled = false;
                }
                else
                {
                    txtCantidad.Enabled = true;
                    HabilitarBotones();
                    this.dgvdetalleproductos.DataSource = ControlFacturacion.Buscar_Detalle_Productos(txtCodigoProducto.Text);
                    dgvdetalleproductos.Columns[0].Visible = false;
                    dgvdetalleproductos.Columns[1].HeaderText = "Nombre del producto";
                    dgvdetalleproductos.Columns[1].Width = 170;
                    dgvdetalleproductos.Columns[2].HeaderText = "Producto disponibles";
                    dgvdetalleproductos.Columns[3].HeaderText = "Precio Unitario";
                    dgvdetalleproductos.Columns[3].DefaultCellStyle.Format = "N2";
                    dgvdetalleproductos.Columns[4].Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
            CargarDetalle();
            LimpiarGrid();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            Validaciones.SinEspacios(e);
        }
        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            int devolver = Convert.ToInt16(txtCantidad.Text)+ Convert.ToInt16(txtDisponible.Text);
            int idproducto = Convert.ToInt16(txtIdProducto.Text);
            int iddetalle = Convert.ToInt16(txtIdDetalle.Text);
            int dev = ControlFacturacion.Actualizar_Cantidad_Productos(idproducto,devolver,iddetalle);
            if (dev >= 1)
            {
                //Eliminar detalle
                dev = ControlFacturacion.Eliminar_Detalle(Convert.ToInt16(txtIdDetalleFactura.Text));
                if (dev >= 1)
                {
                    MessageBox.Show("Los productos han sido devueltos al inventario.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Calcular_Pago();
                }                
            }
            CargarDetalle();
            LimpiarCampos();
            txtCodigoProducto.Enabled = true;
            HabilitarBotones();
            BtnCrearFactura.Enabled = false;
        }
        private void dgvDetallesFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregar.Enabled = false;
            txtCodigoProducto.Enabled = false;
            int pos = 0;
            pos = dgvDetallesFactura.CurrentRow.Index;
            if (dgvDetallesFactura.DataSource != null)
            {
                int posColum = dgvDetallesFactura.CurrentCell.ColumnIndex;
                if (dgvDetallesFactura[posColum, pos].Value.ToString() != "")
                {
                    txtNombreProducto.Text = dgvDetallesFactura[0, pos].Value.ToString();
                    txtCodigoProducto.Text = dgvDetallesFactura[0, pos].Value.ToString();
                    txtIdDetalleFactura.Text = dgvDetallesFactura[1, pos].Value.ToString();
                    txtIdProducto.Text = dgvDetallesFactura[2, pos].Value.ToString();
                    txtCantidad.Text = dgvDetallesFactura[3, pos].Value.ToString();
                    pedidoantiguo = Convert.ToInt16(dgvDetallesFactura[3, pos].Value);
                    txtIdFactura.Text = dgvDetallesFactura[4, pos].Value.ToString();
                    ControlFacturacion.Buscar_Detalle_Productos(txtNombreProducto.Text);
                    txtDisponible.Text = DatosProductos.cantidad.ToString();
                    txtPrecio.Text = DatosProductos.precio.ToString();
                    txtCantidad.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La celda seleccionada no contiene información, verifique que está seleccionando una celda con datos.", "Selección vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay datos por cargar en los controles, ingrese un producto al detalle.","Selección vacía",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        private void BtnActualizarDetalle_Click(object sender, EventArgs e)
        {
            nuevopedido = Convert.ToInt16(txtCantidad.Text);
            if (nuevopedido == pedidoantiguo)
            {
                CargarDetalle();
                LimpiarCampos();
                //MessageBox.Show("NO PASO NADA");
            }
            else if(nuevopedido > pedidoantiguo)
            {
                //MessageBox.Show("AUMENTAR PEDIDO");
                int temp = nuevopedido - pedidoantiguo;
                if (temp <= Convert.ToInt16(txtDisponible.Text))
                {
                    Constructor_Detalle_Factura cdet = new Constructor_Detalle_Factura();
                    cdet.cantidad = nuevopedido;
                    cdet.id_detalle_factura = Convert.ToInt16(txtIdDetalleFactura.Text);
                    cdet.total_parcial = nuevopedido * Convert.ToDouble(txtPrecio.Text);
                    int datos = ControlFacturacion.Actualizar_Detalle_Factura(cdet);
                    if (datos >= 1)
                    {
                        Constructor_Producto prod = new Constructor_Producto();
                        int nuevacantidad = Convert.ToInt16(txtDisponible.Text) - temp;
                        int idproducto = Convert.ToInt16(txtIdProducto.Text);
                        int iddetalle = Convert.ToInt16(txtIdDetalle.Text);
                        datos = ControlFacturacion.Actualizar_Cantidad_Productos(idproducto, nuevacantidad,iddetalle);
                        if (datos >= 1)
                        {
                            LimpiarCampos();
                            CargarDetalle();
                            Calcular_Pago();
                        }
                    }
                }
            }
            else if (nuevopedido < pedidoantiguo)
            {
                //MessageBox.Show("DEVOLVER PRODUCTOS");
                int sumar = pedidoantiguo - nuevopedido;
                Constructor_Detalle_Factura cdet = new Constructor_Detalle_Factura();
                cdet.cantidad = nuevopedido;
                cdet.id_detalle_factura = Convert.ToInt16(txtIdDetalleFactura.Text);
                cdet.total_parcial = nuevopedido * Convert.ToDouble(txtPrecio.Text);
                int datos = ControlFacturacion.Actualizar_Detalle_Factura(cdet);
                if (datos >= 1)
                {
                    Constructor_Producto prod = new Constructor_Producto();
                    int nuevacantidad = Convert.ToInt16(txtDisponible.Text) + sumar;
                    int idproducto = Convert.ToInt16(txtIdProducto.Text);
                    int iddetalle = Convert.ToInt16(txtIdDetalle.Text);
                    datos = ControlFacturacion.Actualizar_Cantidad_Productos(idproducto, nuevacantidad,iddetalle);
                    if (datos >= 1)
                    {
                        LimpiarCampos();
                        CargarDetalle();
                        Calcular_Pago();
                    }
                }                
            }
        }
        private void BtnAnularFactura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer anular la factura?","Confirmación de anulación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                int anulacion = ControlFacturacion.Anular_Factura(Convert.ToInt16(txtIdFactura.Text));
                if (anulacion > 0)
                {
                    BtnCrearFactura.Enabled = true;
                    LimpiarCampos();
                    txtIdFactura.Clear();
                    txtIdDetalleFactura.Clear();
                    if (dgvDetallesFactura.DataSource != null)
                    {
                        DataTable dt = (DataTable)dgvDetallesFactura.DataSource;
                        dt.Clear();
                    }
                    txtPago.Text = "0.00";
                    DeshabilitarBotones();

                }
            }            
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("-> Considere que si finaliza la factura ya no podrá editarla. \n ¿Desea finalizar el proceso de facturación?", "Finalizar factura",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnCrearFactura.Enabled = true;
                int pago = ControlFacturacion.Actualizar_Factura_PagoTotal(Convert.ToInt16(txtIdFactura.Text), Convert.ToDouble(txtPago.Text));
                if (pago > 0)
                {
                    txtPago.Text = "0.00";
                    ReporteFacturacion factu = new ReporteFacturacion(Convert.ToInt16(txtIdFactura.Text));
                    factu.ShowDialog();
                    LimpiarCampos();
                    txtIdFactura.Clear();
                    txtIdDetalleFactura.Clear();
                    DataTable dt = (DataTable)dgvDetallesFactura.DataSource;
                    dt.Clear();
                    DeshabilitarBotones();
                }
            }         
        }

        private void dgvdetalleproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = 0;
            pos = dgvdetalleproductos.CurrentRow.Index;
            txtIdProducto.Text = dgvdetalleproductos[0, pos].Value.ToString();
            txtNombreProducto.Text = dgvdetalleproductos[1, pos].Value.ToString();
            txtDisponible.Text = dgvdetalleproductos[2, pos].Value.ToString();
            txtPrecio.Text = dgvdetalleproductos[3, pos].Value.ToString();
            txtIdDetalle.Text = dgvdetalleproductos[4, pos].Value.ToString();
        }
    }
}
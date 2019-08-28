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
            if (txtProducto.Text.Trim() == "" ||
                txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("El producto o código muy cierto están vacíos.","Campos vacíos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdUsuario.Text = Constructor_Login.id_usuario.ToString();
                txtUsuario.Text = Constructor_Login_Datos.nombre;
                if (Constructor_Login.id_usuario <=2)
                {
                    cmbEmpresa.Enabled = true;
                    cmbEmpresa.DataSource = ControlProductos.ObtenerEmpresas();
                    cmbEmpresa.DisplayMember = "empresa";
                    cmbEmpresa.ValueMember = "Empresa";
                }
                else
                {
                    cmbEmpresa.Enabled = false;
                    cmbEmpresa.DataSource = ControlProductos.ObtenerEmpresa(Convert.ToInt16(txtIdUsuario.Text));
                    cmbEmpresa.DisplayMember = "empresa";
                    cmbEmpresa.ValueMember = "Empresa";
                }
               
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
            if (txtPrecio.Text.Contains('.'))
            {
                
            }
        }
    }
}

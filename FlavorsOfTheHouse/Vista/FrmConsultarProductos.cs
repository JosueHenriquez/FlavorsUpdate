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
using System.Runtime.InteropServices;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmConsultarProductos : Form
    {
        private int idempresa;
        public FrmConsultarProductos(int idempresa)
        {
            InitializeComponent();
            this.idempresa = idempresa;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ListadoProductos()
        {
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[0].Visible = false;

            dgvProductos.Columns[1].HeaderText = "Nombre del producto";
            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns[1].Width = 80;

            dgvProductos.Columns[2].HeaderText = "Código del prodcuto";
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[2].Width = 60;

            dgvProductos.Columns[3].Visible = false;

            dgvProductos.Columns[4].Visible = false;

            dgvProductos.Columns[5].HeaderText = "Tipo de producto";
            dgvProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns[5].Width = 60;

        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            DataTable data;
            if (Constructor_Login.nivel <= 2 || Constructor_Login.nivel == 6)
            {
                data = ControlProductos.Cargar_Productos_General_Facturacion();
                if (data != null)
                {
                    dgvProductos.DataSource = data;
                    ListadoProductos();
                }
                else
                {
                    MessageBox.Show("No hay productos registrados para esta empresa, o verifique que la fecha de vencimiento de los productos sean correctos, ya que solo se observarán productos en buen estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                data = ControlProductos.Cargar_Productos_PorEmpresa_Facturacion(idempresa);
                if (data != null)
                {
                    dgvProductos.DataSource = data;
                    ListadoProductos();
                }
                else
                {
                    MessageBox.Show("No hay productos registrados para esta empresa, o verifique que la fecha de vencimiento de los productos sean correctos, ya que solo se observarán productos en buen estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }           
        }

        private void FrmConsultarProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

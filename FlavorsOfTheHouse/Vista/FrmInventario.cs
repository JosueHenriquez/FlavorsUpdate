using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FlavorsOfTheHouse.Modelo;
using FlavorsOfTheHouse.Reportes;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmInventario : Form
    {
        private int id;
        public FrmInventario()
        {
            InitializeComponent();
        }
        #region
        void obtenerEmpresas()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tbempresa WHERE id_empresa > 1";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                int valor = Convert.ToInt16(cmdselect.ExecuteScalar());
                if (valor > 0)
                {
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = 2;
                        int numeroempresas = reader.GetInt16(0);
                        for (int i = 0; i < numeroempresas; i++)
                        {                            
                            string query2 = "SELECT id_empresa, empresa, logoempresa FROM tbempresa WHERE id_empresa >= 1";
                            MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion_Config.ObtenerConexion());
                            int resultado = Convert.ToInt16(cmdselect2.ExecuteScalar());
                            if (resultado > 0)
                            {
                                MySqlDataReader reader2 = cmdselect2.ExecuteReader();
                                while (reader2.Read())
                                {
                                    int idempresa = reader2.GetInt16(0);
                                    string empresa = reader2.GetString(1);
                                    byte[] image = Convert.FromBase64String(reader2.GetString(2));
                                    MemoryStream ms = new MemoryStream(image);
                                    switch (idempresa)
                                    {
                                        case 1:
                                            lblempresa7.Text = empresa;
                                            pic7.Image = Image.FromStream(ms);
                                            
                                            id++;
                                            break;
                                        case 2:
                                            lblempresa1.Text = "Inventario \n" + empresa;
                                            pic1.Image = Image.FromStream(ms);
                                            lblid1.Text = idempresa.ToString();
                                            id++;
                                            break;
                                        case 3:
                                            lblempresa2.Text = "Inventario \n" + empresa;
                                            pic2.Image = Image.FromStream(ms);
                                            lblid2.Text = idempresa.ToString();
                                            id++;
                                            break;
                                        case 4:
                                            lblempresa3.Text = "Inventario \n" + empresa;
                                            pic3.Image = Image.FromStream(ms);
                                            lblid3.Text = idempresa.ToString();
                                            break;
                                        case 5:
                                            lblempresa4.Text = "Inventario \n" + empresa;
                                            pic4.Image = Image.FromStream(ms);
                                            lblid4.Text = idempresa.ToString();
                                            break;
                                        case 6:
                                            lblempresa5.Text = "Inventario \n" + empresa;
                                            pic5.Image = Image.FromStream(ms);
                                            lblid5.Text = idempresa.ToString();
                                            break;
                                        case 7:
                                            lblempresa6.Text = "Inventario \n" + empresa;
                                            pic6.Image = Image.FromStream(ms);
                                            lblid6.Text = idempresa.ToString();
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            id++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        void ListadoProductos()
        {
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[0].Visible = false;

            dgvProductos.Columns[1].HeaderText = "Nombre del producto";
            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns[1].Width = 30;

            dgvProductos.Columns[2].HeaderText = "Código del prodcuto";
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[2].Width = 20;

            dgvProductos.Columns[3].HeaderText = "Precio unitario";
            dgvProductos.Columns[3].DefaultCellStyle.Format = "0.00";
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[3].Width = 20;

            //Ocultamos id usuario para mostrar el nombre de usuario que agrego el producto
            dgvProductos.Columns[4].Visible = false;

            dgvProductos.Columns[6].HeaderText = "Fecha de empacado";
            dgvProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[6].Width = 30;

            dgvProductos.Columns[5].HeaderText = "Fecha de vencimiento.";
            dgvProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[5].Width = 30;

            dgvProductos.Columns[7].HeaderText = "Existencia";
            dgvProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[7].Width = 20;

            dgvProductos.Columns[8].Visible = false;
            dgvProductos.Columns[8].HeaderText = "Tipo de producto";
            dgvProductos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[8].Width = 30;

            dgvProductos.Columns[9].Visible = false;
            dgvProductos.Columns[10].Visible = false;

            dgvProductos.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[11].HeaderText = "Usuario que agregó producto";
            dgvProductos.Columns[11].Width = 200;
        }
        void cargarProductos(int idempresa)
        {
            dgvProductos.DataSource = ControlProductos.Cargar_Productos_PorEmpresa(idempresa);
            ListadoProductos();
        }
        void cargarInventarioGeneral()
        {
            dgvProductos.DataSource = ControlProductos.Inventario_General();
            ListadoProductos();
        }
        void despintarCards()
        {
            this.bunifuCards1.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards2.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards3.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards4.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards5.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards6.BackColor = Color.FromArgb(255, 255, 255);
            this.bunifuCards7.BackColor = Color.FromArgb(255, 255, 255);
        }
        #endregion

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            obtenerEmpresas();
        }
        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid1.Text));
            despintarCards();
            this.bunifuCards1.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid1.Text);
        }
        private void bunifuCards2_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid2.Text));
            despintarCards();
            this.bunifuCards2.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid2.Text);
        }
        private void bunifuCards3_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid3.Text));
            despintarCards();
            this.bunifuCards3.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid3.Text);
        }
        private void bunifuCards4_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid4.Text));
            despintarCards();
            this.bunifuCards4.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid4.Text);
        }
        private void bunifuCards5_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid5.Text));
            despintarCards();
            this.bunifuCards5.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid5.Text);
        }
        private void bunifuCards6_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid6.Text));
            despintarCards();
            this.bunifuCards6.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid6.Text);
        }
        private void bunifuCards7_Click(object sender, EventArgs e)
        {
            cargarInventarioGeneral();
            despintarCards();
            this.bunifuCards7.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid1.Text));
            despintarCards();
            this.bunifuCards1.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid1.Text);
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid2.Text));
            despintarCards();
            this.bunifuCards2.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid2.Text);
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid3.Text));
            despintarCards();
            this.bunifuCards3.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid3.Text);
        }
        private void pic4_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid4.Text));
            despintarCards();
            this.bunifuCards4.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid4.Text);
        }
        private void pic5_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid5.Text));
            despintarCards();
            this.bunifuCards5.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid5.Text);
        }
        private void pic6_Click(object sender, EventArgs e)
        {
            cargarProductos(Convert.ToInt16(lblid6.Text));
            despintarCards();
            this.bunifuCards6.BackColor = Color.FromArgb(230, 230, 230);
            id = Convert.ToInt16(lblid6.Text);
        }
        private void pic7_Click(object sender, EventArgs e)
        {
            cargarInventarioGeneral();
            despintarCards();
            this.bunifuCards7.BackColor = Color.FromArgb(230, 230, 230);
        }
        
        private void GenerarReporteInd_Click(object sender, EventArgs e)
        {
            //ReporteInventarioIndividual repind = new ReporteInventarioIndividual(id);
            //repind.ShowDialog();
        }
    }
}

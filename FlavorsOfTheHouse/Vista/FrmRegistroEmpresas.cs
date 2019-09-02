using System;
using FlavorsOfTheHouse.Controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using FlavorsOfTheHouse.Modelo;
using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Reportes;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmRegistroEmpresas : Form
    {
        public FrmRegistroEmpresas()
        {
            InitializeComponent();
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen (.jpg)|*.jpg|Archivo de imagen (.png)|*.png|Archivo de imagen (.jpeg)|*.jpeg|Archivo de imagen (.tiff)|*.tiff";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName );
            }
        }
        void LimpiarCamos()
        {
            txtId.Clear();
            TxtEmpresa.Clear();
            TxtNit.Clear();
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            txtRepresentante.Clear();
            pbLogo.Image = null;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        void Agregar_Empresa()
        {
            if (TxtEmpresa.Text.Trim() == "" ||
                TxtNit.Text.Trim() == "" ||
                TxtDireccion.Text.Trim() == "" ||
                txtRepresentante.Text.Trim() == "" ||
                TxtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Algunos campos requeridos estan vacios.", "Datos faltantes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(pbLogo.Image == null)
            {
                MessageBox.Show("Debe cargar el logo que corresponde a la empresa.", "Logo faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConstructorEmpresa_Controlador empresa = new ConstructorEmpresa_Controlador();
                empresa.nombre_empresa = TxtEmpresa.Text;
                empresa.nit = TxtNit.Text;
                empresa.direccion = TxtDireccion.Text;
                empresa.estado = Convert.ToInt16(cmbEstado.SelectedValue);
                empresa.tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                empresa.representante = txtRepresentante.Text;
                empresa.correo = TxtCorreo.Text;
                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string encoded = Convert.ToBase64String(aByte);
                empresa.imagen = encoded;
                int datos = ControlEmpresas_Modelo.IngresarEmpresa(empresa);
            }
        }
        void Mostrar_Empresa_Activas()
        {
            if (ControlEmpresas_Modelo.MostrarEmpresas_Grid_Activas() != null)
            {
                dgvEmpresas.DataSource = ControlEmpresas_Modelo.MostrarEmpresas_Grid_Activas();
                this.dgvEmpresas.Columns[0].Visible = false;
                this.dgvEmpresas.Columns[1].HeaderText = "Nombre de empresa";
                this.dgvEmpresas.Columns[1].Width = 75;
                this.dgvEmpresas.Columns[2].HeaderText = "Correo Institucional";
                this.dgvEmpresas.Columns[2].Width = 100;
                this.dgvEmpresas.Columns[3].HeaderText = "Número de Identificación Tributario";
                this.dgvEmpresas.Columns[3].Width = 100;
                this.dgvEmpresas.Columns[4].Visible = false;
                this.dgvEmpresas.Columns[5].Visible = false;
                this.dgvEmpresas.Columns[5].HeaderText = "Tipo de empresa";
                this.dgvEmpresas.Columns[5].Width = 100;
                this.dgvEmpresas.Columns[6].HeaderText = "Estado de la empresa";
                this.dgvEmpresas.Columns[6].Width = 50;
                this.dgvEmpresas.Columns[7].HeaderText = "Dirección";
                this.dgvEmpresas.Columns[7].Width = 150;
                this.dgvEmpresas.Columns[8].Visible = false;

                
            }
        }
        void Mostrar_Empresa_General()
        {
            if (ControlEmpresas_Modelo.MostrarEmpresas_Grid_General() != null)
            {
                dgvEmpresas.DataSource = ControlEmpresas_Modelo.MostrarEmpresas_Grid_General();
                this.dgvEmpresas.Columns[0].Visible = false;
                this.dgvEmpresas.Columns[1].HeaderText = "Nombre de empresa";
                this.dgvEmpresas.Columns[1].Width = 75;
                this.dgvEmpresas.Columns[2].HeaderText = "Correo Institucional";
                this.dgvEmpresas.Columns[2].Width = 100;
                this.dgvEmpresas.Columns[3].HeaderText = "Número de Identificación Tributario";
                this.dgvEmpresas.Columns[3].Width = 100;
                this.dgvEmpresas.Columns[4].Visible = false;
                this.dgvEmpresas.Columns[5].Visible = false;
                this.dgvEmpresas.Columns[5].HeaderText = "Tipo de empresa";
                this.dgvEmpresas.Columns[5].Width = 100;
                this.dgvEmpresas.Columns[6].HeaderText = "Estado de la empresa";
                this.dgvEmpresas.Columns[6].Width = 50;
                this.dgvEmpresas.Columns[7].HeaderText = "Dirección";
                this.dgvEmpresas.Columns[7].Width = 150;
                this.dgvEmpresas.Columns[8].Visible = false;


            }
        }
        void Mostrar_Empresa_Inactivas()
        {
            if (ControlEmpresas_Modelo.MostrarEmpresas_Grid_Inactivas() != null)
            {
                dgvEmpresas.DataSource = ControlEmpresas_Modelo.MostrarEmpresas_Grid_Inactivas();
                this.dgvEmpresas.Columns[0].Visible = false;
                this.dgvEmpresas.Columns[1].HeaderText = "Nombre de empresa";
                this.dgvEmpresas.Columns[1].Width = 75;
                this.dgvEmpresas.Columns[2].HeaderText = "Correo Institucional";
                this.dgvEmpresas.Columns[2].Width = 100;
                this.dgvEmpresas.Columns[3].HeaderText = "Número de Identificación Tributario";
                this.dgvEmpresas.Columns[3].Width = 100;
                this.dgvEmpresas.Columns[4].Visible = false;
                this.dgvEmpresas.Columns[5].Visible = false;
                this.dgvEmpresas.Columns[5].HeaderText = "Tipo de empresa";
                this.dgvEmpresas.Columns[5].Width = 100;
                this.dgvEmpresas.Columns[6].HeaderText = "Estado de la empresa";
                this.dgvEmpresas.Columns[6].Width = 50;
                this.dgvEmpresas.Columns[7].HeaderText = "Dirección";
                this.dgvEmpresas.Columns[7].Width = 150;
                this.dgvEmpresas.Columns[8].Visible = false;


            }
        }
        void Actualizar_Empresa()
        {
            ConstructorEmpresa_Controlador actemp = new ConstructorEmpresa_Controlador();
            actemp.id_empresa = int.Parse(txtId.Text);
            actemp.nombre_empresa = TxtEmpresa.Text;
            actemp.correo = TxtCorreo.Text;
            actemp.nit = TxtNit.Text;
            actemp.representante = txtRepresentante.Text;
            actemp.tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            actemp.estado = Convert.ToInt16(cmbEstado.SelectedValue);
            actemp.direccion = TxtDireccion.Text;
            MemoryStream ms = new MemoryStream();
            pbLogo.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string encoded = Convert.ToBase64String(aByte);
            actemp.imagen = encoded;
            int resultado = ControlEmpresas_Modelo.Actualizar_Empresa(actemp);
        }
        void Cambiar_Estado()
        {
            if (MessageBox.Show("¿Está seguro de cambiar el estado de la empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ConstructorEmpresa_Controlador cambiarestado = new ConstructorEmpresa_Controlador();
                if (cmbEstado.Text == "Activo")
                {
                    int estado = 2;
                    ControlEmpresas_Modelo.Cambiar_Estado(Convert.ToInt16(txtId.Text), estado);
                    LimpiarCamos();
                    Mostrar_Empresa_Activas();
                }
                else if (cmbEstado.Text == "Inactivo")
                {
                    int estado = 1;
                    ControlEmpresas_Modelo.Cambiar_Estado(Convert.ToInt16(txtId.Text), estado);
                    LimpiarCamos();
                    Mostrar_Empresa_Activas();
                }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Empresa();
            Mostrar_Empresa_Activas();
            LimpiarCamos();
        }
        private void FrmRegistroEmpresas_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEstado.DataSource = ObtenerDatos_Modelo.Obtener_Estados();
                cmbEstado.DisplayMember = "estado";
                cmbEstado.ValueMember = "id_estado";

                cmbTipoEmpresa.DataSource = ObtenerDatos_Modelo.ObtenerTipoEmpresa();
                cmbTipoEmpresa.DisplayMember = "tipo_empresa";
                cmbTipoEmpresa.ValueMember = "id_tipo_empresa";

                Mostrar_Empresa_Activas();
                LimpiarCamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error. "+ ex.Message,"Error critico",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Empresa_Activas();
        }
        private void dgvEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos;
            pos = this.dgvEmpresas.CurrentRow.Index;
            txtId.Text = this.dgvEmpresas[0, pos].Value.ToString();
            TxtEmpresa.Text = this.dgvEmpresas[1, pos].Value.ToString();
            TxtCorreo.Text = this.dgvEmpresas[2, pos].Value.ToString();
            TxtNit.Text = this.dgvEmpresas[3, pos].Value.ToString();
            txtRepresentante.Text = this.dgvEmpresas[4, pos].Value.ToString();
            cmbTipoEmpresa.Text = this.dgvEmpresas[5, pos].Value.ToString();
            cmbEstado.Text = this.dgvEmpresas[6, pos].Value.ToString();
            TxtDireccion.Text = this.dgvEmpresas[7, pos].Value.ToString();
            // RECUPERAR IMAGEN
            string instruccion;
            instruccion = "SELECT logoempresa FROM tbempresa WHERE id_empresa = ?param1";
            MySqlCommand cmd = new MySqlCommand(instruccion, Conexion_Config.ObtenerConexion());
            cmd.Parameters.Add(new MySqlParameter("param1", txtId.Text));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] image = Convert.FromBase64String(reader.GetString(0));
                MemoryStream ms = new MemoryStream(image);
                pbLogo.Image = Image.FromStream(ms);
            }
            BtnAgregar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar_Empresa();
            Mostrar_Empresa_Activas();
            LimpiarCamos();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer limpiar los campos?, tenga en cuenta que perderá los datos de los controles.","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                LimpiarCamos();
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Cambiar_Estado();
            Mostrar_Empresa_Activas();   
        }
        private void chkempresas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkempresas.Checked == true)
            {
                Mostrar_Empresa_General();
            }
            else
            {
                Mostrar_Empresa_Activas();
            }
        }

        private void chkEmpInactivas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpInactivas.Checked == true)
            {
                Mostrar_Empresa_Inactivas();
            }
            else
            {
                Mostrar_Empresa_Activas();
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ReporteEmpresas remp = new ReporteEmpresas();
            remp.Show();
        }
    }
}

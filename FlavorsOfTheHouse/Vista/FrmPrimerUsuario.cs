using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlavorsOfTheHouse.Controlador;
using FlavorsOfTheHouse.Modelo;
using FlavorsOfTheHouse.Config;
using System.IO;
using System.Drawing.Imaging;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmPrimerUsuario : Form
    {
        public FrmPrimerUsuario()
        {
            InitializeComponent();
        }

        private void radDui_CheckedChanged(object sender, EventArgs e)
        {
            if (radDui.Checked == true)
            {
                maskDui.Visible = true;
                radCarne.Checked = false;
                txtCarne.Visible = false;
                txtCarne.Clear();
            }
        }

        private void radCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarne.Checked == true)
            {
                txtCarne.Visible = true;
                radDui.Checked = false;
                maskDui.Visible = false;
                maskDui.Clear();
            }
        }

        private void FrmPrimerUsuario_Load(object sender, EventArgs e)
        {
            txtCarne.Visible = false;
            maskDui.Visible = false;
            try
            {
                cmbEmpresa.DataSource = ControlEmpresas_Modelo.ObtenerEmpresa();
                cmbEmpresa.DisplayMember = "empresa";
                cmbEmpresa.ValueMember = "id_empresa";

                cmbTipoUsuario.DataSource = ObtenerDatos_Modelo.ObtenerTipo_Usuario();
                cmbTipoUsuario.DisplayMember = "tipo_usuario";
                cmbTipoUsuario.ValueMember = "id_tipo_usuario";

                cmbEstado.DataSource = ObtenerDatos_Modelo.Obtener_Estados();
                cmbEstado.DisplayMember = "estado";
                cmbEstado.ValueMember = "id_estado";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivos de Imagen (.png)|*.png| Archivos de Imagen (.jpeg)|*.jpeg| Todos los archivos|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Oops, Ha ocurrido un error, considere las posibles soluciones \n 1. El nombre de la imagen no es válido. \n 2. La extención de la imagen no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;

            if (txtNombres.Text.Trim() == "" || 
                txtApellidos.Text.Trim() == "" || 
                maskDui.Text.Trim() == "" && txtCarne.Text.Trim() == "" || 
                dtNacimiento.Value.Date >= hoy || 
                txtUsuario.Text.Trim() == "" ||
                txtClave.Text.Trim() == "" || 
                txtConfClave.Text.Trim() == "")
            {
                MessageBox.Show("Algunos campos de tipo obligatorio están vacíos o la fecha de nacimiento proporcionada no es correcta, por favor rellene todos los campos.","Error de Inserción",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (txtClave.Text != txtConfClave.Text)
                {
                    MessageBox.Show("Las claves no coinciden, vuelva a ingresarlas","Claves no coinciden",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    txtClave.Clear();
                    txtConfClave.Clear();
                }
                else
                {
                    Constructor_PrimerUsuario user = new Constructor_PrimerUsuario();
                    user.usuario = txtUsuario.Text;
                    user.clave = txtConfClave.Text;
                    user.nombres = txtNombres.Text;
                    user.apellidos = txtApellidos.Text;
                    if (radCarne.Checked == true)
                    {
                        user.documento = txtCarne.Text;
                    }
                    else
                    {
                        user.documento = maskDui.Text;
                    }
                    user.nacimiento = dtNacimiento.Text;
                    user.intentos = 0;
                    user.primer_uso = 1;
                    user.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                    user.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                    user.id_tipo_usuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
                    MemoryStream ms = new MemoryStream();
                    pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string encoded = Convert.ToBase64String(aByte);
                    user.imagen = encoded;
                    user.respuesta1 = txtRespuesta1.Text;
                    user.respuesta2 = txtRespuesta2.Text;
                    user.respuesta3 = txtRespuesta3.Text;
                    user.respuesta4 = txtRespuesta4.Text;
                    int datos = ControlUsuarios_Modelo.Ingresar_Usuario(user);
                    if (datos >= 1)
                    {
                        MessageBox.Show("Hemos finalizado con la configuración inicial, en este momento te mostrare el Inicio de Sesión para que escribas las credenciales del usuario que acabas de crear.","Proceso finalizado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FrmLogin log = new FrmLogin();
                        log.Show();
                        this.Close();
                    }
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
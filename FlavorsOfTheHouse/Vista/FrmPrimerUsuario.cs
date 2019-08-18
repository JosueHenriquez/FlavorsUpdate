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
            lblMensaje.Visible = false;
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

                cmbPregunta1.DataSource = ObtenerDatos_Modelo.ObtenerPreguntas();
                cmbPregunta1.DisplayMember = "pregunta";
                cmbPregunta1.ValueMember = "id_pregunta";

                cmbPregunta2.DataSource = ObtenerDatos_Modelo.ObtenerPreguntas();
                cmbPregunta2.DisplayMember = "pregunta";
                cmbPregunta2.ValueMember = "id_pregunta";

                cmbPregunta3.DataSource = ObtenerDatos_Modelo.ObtenerPreguntas();
                cmbPregunta3.DisplayMember = "pregunta";
                cmbPregunta3.ValueMember = "id_pregunta";

                cmbPregunta4.DataSource = ObtenerDatos_Modelo.ObtenerPreguntas();
                cmbPregunta4.DisplayMember = "pregunta";
                cmbPregunta4.ValueMember = "id_pregunta";
            }
            catch (Exception)
            {
                MessageBox.Show("Algunas listas no pudieron cargarse, consulte con el administrador.","Erro de carga",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivo de Imagen(.jpg)|*.jpg|Archivos de Imagen(.png)|*.png|Archivos de Imagen(.jpeg)|*.jpeg|Todos los archivos|*.*";
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

        void Registrar_Usuario()
        {
            DateTime hoy = DateTime.Today;
            if (txtNombres.Text.Trim() == "" ||
                txtApellidos.Text.Trim() == "" ||
                maskDui.Text.Trim() == "" && txtCarne.Text.Trim() == "" ||
                txtUsuario.Text.Trim() == "" ||
                txtClave.Text.Trim() == "" ||
                txtConfClave.Text.Trim() == "")
            {
                MessageBox.Show("Algunos campos están vacíos.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pbFoto.Image == null)
            {
                MessageBox.Show("Ha faltado cargar una foto al perfil del nuevo usuario", "Foto faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtClave.Text != txtConfClave.Text)
            {
                MessageBox.Show("Las claves no coinciden, vuelva a ingresarlas", "Claves no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtClave.Clear();
                txtConfClave.Clear();
            }
            else if (Convert.ToInt16(cmbPregunta1.SelectedValue) == Convert.ToInt16(cmbPregunta2.SelectedValue) ||
                Convert.ToInt16(cmbPregunta1.SelectedValue) == Convert.ToInt16(cmbPregunta3.SelectedValue)||
                Convert.ToInt16(cmbPregunta1.SelectedValue) == Convert.ToInt16(cmbPregunta4.SelectedValue)||
                Convert.ToInt16(cmbPregunta2.SelectedValue) == Convert.ToInt16(cmbPregunta3.SelectedValue)||
                Convert.ToInt16(cmbPregunta2.SelectedValue) == Convert.ToInt16(cmbPregunta4.SelectedValue)||
                Convert.ToInt16(cmbPregunta3.SelectedValue) == Convert.ToInt16(cmbPregunta4.SelectedValue))
            {
                MessageBox.Show("Verique que ha seleccionado y respondido a preguntas diferentes, no esta permitido responder dos veces a la misma pregunta.", "Verificación de pregunta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtNacimiento.Value.Date >= hoy)
            {
                MessageBox.Show("Verifique la fecha seleccionada, ya que es igual o pertenece a una fecha futura","Error en fecha de nacimiento",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                Constructor_Usuario user = new Constructor_Usuario();
                user.usuario = txtUsuario.Text;
                user.clave = Validaciones.md5(txtConfClave.Text);
                user.nombres = txtNombres.Text;
                user.apellidos = txtApellidos.Text;
                if (radCarne.Checked == true)
                {
                    user.documento = txtCarne.Text;
                }
                else if(radDui.Checked == true)
                {
                    user.documento = maskDui.Text;
                }
                user.nacimiento = dtNacimiento.Text;
                user.intentos = 0;
                user.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                user.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                user.id_tipo_usuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string encoded = Convert.ToBase64String(aByte);
                user.imagen = encoded;
                int datos = ControlUsuarios_Modelo.Ingresar_Usuario(user);
                if (datos >= 1)
                {
                    ControlUsuarios_Modelo.Buscar_usuario(txtUsuario.Text);
                    txtId.Text = Constructor_Usuario.id_usuario.ToString();
                    Constructor_Respuestas res = new Constructor_Respuestas();
                    for (int i = 0; i < 4; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                res.respuesta = Validaciones.md5(txtRespuesta1.Text);
                                res.id_pregunta = Convert.ToInt16(cmbPregunta1.SelectedValue);
                                int res1 = ControlUsuarios_Modelo.Ingresar_Respuesta(res, Convert.ToInt16(txtId.Text));
                                break;
                            case 1:
                                res.respuesta = Validaciones.md5(txtRespuesta2.Text);
                                res.id_pregunta = Convert.ToInt16(cmbPregunta2.SelectedValue);
                                int res2 = ControlUsuarios_Modelo.Ingresar_Respuesta(res, Convert.ToInt16(txtId.Text));
                                break;
                            case 2:
                                res.respuesta = Validaciones.md5(txtRespuesta3.Text);
                                res.id_pregunta = Convert.ToInt16(cmbPregunta3.SelectedValue);
                                int res3 = ControlUsuarios_Modelo.Ingresar_Respuesta(res, Convert.ToInt16(txtId.Text));
                                break;
                            case 3:
                                res.respuesta = Validaciones.md5(txtRespuesta4.Text);
                                res.id_pregunta = Convert.ToInt16(cmbPregunta4.SelectedValue);
                                int res4 = ControlUsuarios_Modelo.Ingresar_Respuesta(res, Convert.ToInt16(txtId.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    MessageBox.Show("Hemos finalizado con la configuración inicial, en este momento te mostrare el Inicio de Sesión para que escribas las credenciales del usuario que acabas de crear.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin log = new FrmLogin();
                    log.Show(); 
                    this.Close();
                }
            }
        }

        public void BtnGuardar_Click(object sender, EventArgs e)
        {
            Registrar_Usuario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "")
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtConfClave_Enter(object sender, EventArgs e)
        {
            if (txtConfClave.Text.Trim() == "")
            {
                txtConfClave.UseSystemPasswordChar = true;
            }
        }

        private void txtConfClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtConfClave.Text != "" 
                && txtClave.Text != txtConfClave.Text)
            {
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = false;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtConfClave.Text != ""
                && txtClave.Text != txtConfClave.Text)
            {
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = false;
            }
        }

        private void txtConfClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text != txtConfClave.Text)
            {
                lblMensaje.Visible = true;
            }
            else
            {
                lblMensaje.Visible = false;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }
    }
}
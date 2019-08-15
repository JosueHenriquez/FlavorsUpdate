using System;
using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Modelo;
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

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmControlUsuarios : Form
    {
        public FrmControlUsuarios()
        {
            InitializeComponent();
        }

        private void BtnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReestablecer_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            string reestablecer = txtUsuario.Text + "PRIMERUSO";
        }

        private void FrmControlUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEmpresa.DataSource = ControlEmpresas_Modelo.ObtenerEmpresa();
                cmbEmpresa.DisplayMember = "empresa";
                cmbEmpresa.ValueMember = "id_empresa";

                cmbTipoUsuario.DataSource = ObtenerDatos_Modelo.ObtenerTipo_Usuario_SinRoot();
                cmbTipoUsuario.DisplayMember = "tipo_usuario";
                cmbTipoUsuario.ValueMember = "id_tipo_usuario";

                cmbEstado.DataSource = ObtenerDatos_Modelo.Obtener_Estados();
                cmbEstado.DisplayMember = "estado";
                cmbEstado.ValueMember = "id_estado";

                Mostrar_Usuarios();
                maskDui.Visible = false;
                txtCarne.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos en las listas correspondientes, consulte con el administrador. " + ex,"Error de carga",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenCargarImagen.Filter = "Archivos de imagen (.jpg)|*.jpg|Archivos de imagen (.png)|*.png|Archivos de imagen (.jpeg)|*.jpeg|Archivos de imagen (.tiff)|*.tiff";
            DialogResult resultado = OpenCargarImagen.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(OpenCargarImagen.FileName);
            }
        }

        void Agregar_Usuario()
        {
            DateTime hoy = DateTime.Today;
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text)||
                string.IsNullOrWhiteSpace(txtCarne.Text) && 
                string.IsNullOrWhiteSpace(maskDui.Text)||
                string.IsNullOrWhiteSpace(dtNacimiento.Text))
            {
                MessageBox.Show("No se puede almacenar la información debido que algunos campos estan vacíos.","Campos vacíos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (dtNacimiento.Value.Date >= hoy)
            {
                MessageBox.Show("La fecha de nacimiento proporcionada no puede ser igual o mayor a la fecha actual.","Error en fecha de nacimiento",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(dtNacimiento.Value.AddYears(18) > hoy && maskDui.Text != "")
            {
                //***************** ERROR DE VALIDACIÓN
                MessageBox.Show("Error al procesar la información, considere los siguiente casos: \n\n1.Según la fecha de nacimiento el usuario que desea ingresar es menor de edad y ha brindado un numero de Dui.\n2.No ha proporcionado un número de carné");
            }
            else if (pbFoto.Image == null)
            {
                MessageBox.Show("Debes cargar una fotografia en el perfil del usuario.","Datos faltantes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_Usuario reg = new Constructor_Usuario();
                reg.usuario = txtUsuario.Text;
                string clave = Validaciones.md5(txtUsuario+"PRIMERUSO");
                reg.clave = clave;
                reg.nombres = txtNombres.Text;
                reg.apellidos = txtApellidos.Text;
                if (radCarne.Checked == true)
                {
                    radDui.Checked = false;
                    maskDui.Clear();
                    reg.documento = txtCarne.Text;
                }
                else if(radDui.Checked == true)
                {
                    radCarne.Checked = false;
                    txtCarne.Clear();
                    reg.documento = maskDui.Text;
                }
                reg.nacimiento = dtNacimiento.Text;
                reg.intentos = 0;
                reg.primer_uso = 0;
                reg.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                reg.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                reg.id_tipo_usuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
                MemoryStream ms = new MemoryStream();
                byte[] aByte = ms.ToArray();
                string decoded = Convert.ToBase64String(aByte);
                reg.imagen = decoded;
                //int datos = ControlUsuarios_Modelo.Ingresar_Usuario(reg);
            }
        }

        void Mostrar_Usuarios()
        {
            dgvUsuarios.DataSource = ControlUsuarios_Modelo.ObtenerUsuarios();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Usuario();
            Mostrar_Usuarios();
        }

        private void radDui_CheckedChanged(object sender, EventArgs e)
        {
            if (radDui.Checked == true)
            {
                txtCarne.Visible = false;
                radCarne.Checked = false;
                maskDui.Visible = true;
            }
        }

        private void radCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarne.Checked == true)
            {
                maskDui.Visible = false;
                radDui.Checked = false;
                txtCarne.Visible = true;
            }
        }
    }
}

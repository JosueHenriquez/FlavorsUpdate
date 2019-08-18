using System;
using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Modelo;
using FlavorsOfTheHouse.Controlador;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

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
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
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
                string.IsNullOrWhiteSpace(dtNacimiento.Text))
            {
                MessageBox.Show("No se puede almacenar la información debido que algunos campos estan vacíos.","Campos vacíos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (dtNacimiento.Value.Date >= hoy)
            {
                MessageBox.Show("La fecha de nacimiento proporcionada no puede ser igual o mayor a la fecha actual.","Error en fecha de nacimiento",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(maskDui.Text.Trim() == "-" && txtCarne.Text.Trim() == "")
            {
                MessageBox.Show("Brinde un documento de identificación, recuerde que puede proporcionar su numero de DUI o número de carné en caso de ser un estudiante.","Documento faltante",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (dtNacimiento.Value.AddYears(18) > hoy && maskDui.Text.Trim() != "-")
            {
                MessageBox.Show("Usted ha proporcionado un numero de dui siendo menor de edad, verifique que los datos sean correctos", "Fecha de nacimiento incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pbFoto.Image == null)
            {
                MessageBox.Show("Debes cargar una fotografia en el perfil del usuario.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_Usuario reg = new Constructor_Usuario();
                reg.usuario = txtUsuario.Text;
                string clave = Validaciones.md5(txtUsuario.Text+"primeruso");
                //MessageBox.Show(clave);
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
                reg.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                reg.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                reg.id_tipo_usuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms,ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string decoded = Convert.ToBase64String(aByte);
                reg.imagen = decoded;
                int datos = ControlUsuarios_Modelo.Ingresar_Usuario(reg);
                if (datos >= 1)
                {
                    LimpiarCampos();
                }
            }
        }
        void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCarne.Clear();
            maskDui.Clear();
            txtUsuario.Clear();
            radCarne.Checked = false;
            radDui.Checked = false;
            pbFoto.Image = null;
        }
        void Mostrar_Usuarios()
        {
            dgvUsuarios.DataSource = ControlUsuarios_Modelo.ObtenerUsuarios();
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 192, 192);
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvUsuarios.Columns[1].HeaderText = "Usuario";
            this.dgvUsuarios.Columns[1].Width = 65;
            this.dgvUsuarios.Columns[2].HeaderText = "Nombres";
            this.dgvUsuarios.Columns[2].Width = 90;
            this.dgvUsuarios.Columns[3].HeaderText = "Apellidos";
            this.dgvUsuarios.Columns[3].Width = 90;
            this.dgvUsuarios.Columns[4].HeaderText = "Documento";
            this.dgvUsuarios.Columns[4].Width = 65;
            this.dgvUsuarios.Columns[5].HeaderText = "Fecha de Nacimiento";
            this.dgvUsuarios.Columns[5].Width = 65;
            this.dgvUsuarios.Columns[6].HeaderText = "Empresa";
            this.dgvUsuarios.Columns[6].Width = 150;
            this.dgvUsuarios.Columns[7].HeaderText = "Estado";
            this.dgvUsuarios.Columns[7].Width = 50;
            this.dgvUsuarios.Columns[8].HeaderText = "Tipo de Usuario";
            this.dgvUsuarios.Columns[8].Width = 90;
            this.dgvUsuarios.Columns[9].Visible = false;

        }

        void activarBotones()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
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
                txtCarne.Clear();
                radCarne.Checked = false;
                maskDui.Visible = true;
            }
        }
        private void radCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (radCarne.Checked == true)
            {
                maskDui.Visible = false;
                maskDui.Clear();
                radDui.Checked = false;
                txtCarne.Visible = true;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de querer limpiar los campos, tenga en cuenta que perdera los datos ingresados en el formulario.","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                LimpiarCampos();
                txtUsuario.Enabled = true;
                BtnAgregar.Enabled = true;
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Usuarios();
            txtUsuario.Enabled = true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos;
            pos = this.dgvUsuarios.CurrentRow.Index;
            txtId.Text = this.dgvUsuarios[0, pos].Value.ToString();
            txtUsuario.Enabled = false;
            txtUsuario.Text = this.dgvUsuarios[1, pos].Value.ToString();
            txtNombres.Text = this.dgvUsuarios[2, pos].Value.ToString();
            txtApellidos.Text = this.dgvUsuarios[3, pos].Value.ToString();
            if (dgvUsuarios[4,pos].Value.ToString().Contains('-'))
            {
                maskDui.Text = this.dgvUsuarios[4, pos].Value.ToString();
                radDui.Checked = true;
                maskDui.Visible = true;
                txtCarne.Visible = false;
                txtCarne.Clear();
            }
            else
            {
                txtCarne.Text = dgvUsuarios[4, pos].Value.ToString();
                radCarne.Checked = true;
                txtCarne.Visible = true;
                maskDui.Visible = false;
                maskDui.Clear();
            }
            dtNacimiento.Text = this.dgvUsuarios[5,pos].Value.ToString();
            cmbEmpresa.Text = this.dgvUsuarios[6, pos].Value.ToString();
            cmbEstado.Text = this.dgvUsuarios[7, pos].Value.ToString();
            cmbTipoUsuario.Text = this.dgvUsuarios[8, pos].Value.ToString();
            //RECUPERAR IMAGEN
            string instruccion;
            instruccion = "SELECT foto FROM tbusuario WHERE id_usuario = ?param1";
            MySqlCommand cmd = new MySqlCommand(instruccion, Conexion_Config.ObtenerConexion());
            cmd.Parameters.Add(new MySqlParameter("param1",txtId.Text));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] image = Convert.FromBase64String(reader.GetString(0));
                MemoryStream ms = new MemoryStream(image);
                pbFoto.Image = Image.FromStream(ms);
            }
            BtnAgregar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar los datos del usuario?","Confirmación de actualización",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Constructor_Usuario actualizacion = new Constructor_Usuario();
                Constructor_Usuario.id_usuario = int.Parse(txtId.Text);
                actualizacion.nombres = txtNombres.Text;
                actualizacion.apellidos = txtApellidos.Text;
                if (radCarne.Checked == true)
                {
                    radDui.Checked = false;
                    maskDui.Clear();
                    actualizacion.documento = txtCarne.Text;
                }
                else if (radDui.Checked == true)
                {
                    radCarne.Checked = false;
                    txtCarne.Clear();
                    actualizacion.documento = maskDui.Text;
                }
                actualizacion.nacimiento = dtNacimiento.Text;
                actualizacion.id_empresa = Convert.ToInt16(cmbEmpresa.SelectedValue);
                actualizacion.id_estado = Convert.ToInt16(cmbEstado.SelectedValue);
                actualizacion.id_tipo_usuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string decoded = Convert.ToBase64String(aByte);
                actualizacion.imagen = decoded;
                int verificar_proceso = ControlUsuarios_Modelo.Actualizar_Usuario(actualizacion);
                if (verificar_proceso >= 1)
                {
                    Mostrar_Usuarios();
                    LimpiarCampos();
                    activarBotones();
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados, intentelo nuevamente","Proceso fallido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?\n\nConsidere que si el registro posee datos dependientes no podra eliminar el usuario, lo cual se le recomienda cambiarlo de estado.","Confirmación de Eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int proceso = ControlUsuarios_Modelo.Eliminar_Usuario(Convert.ToInt16(txtId.Text));
                if (proceso >= 1)
                {
                    Mostrar_Usuarios();
                    LimpiarCampos();
                    activarBotones();
                }
                else
                {
                    MessageBox.Show("El proceso no pudo ser completado, vuelva a intentarlo.", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void chkVerUsuarios_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

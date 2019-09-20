using System;
using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlavorsOfTheHouse.Modelo;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (PrimerUso_Modelo.Existencia_Empresa() == true)
            {
                bool dat = ObtenerDatos_Modelo.ObtenerUsuario();
                if (dat == true)
                {
                    //ocultar campos primer uso
                    BtnPrimerUso.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                }
                else
                {
                    //ocultar campos de login
                    lbllogin.Visible = false;
                    txtContrasena.Visible = false;
                    txtUsuario.Visible = false;
                    btnAcceder.Visible = false;
                    BtnCancelar.Visible = false;
                    picImagen.Visible = false;
                    lnkRecuperacion.Visible = false;
                    lblUsuario.Visible = false;
                    lblContra.Visible = false;
                    panelusuario.Visible = false;
                    panelclave.Visible = false;
                    panellogin.Visible = false;
                    BtnPrimerUso.LabelText = "Crear primer usuario";
                }
            }
            else
            {                
                //ocultar campos de login
                lbllogin.Visible = false;
                txtContrasena.Visible = false;
                txtUsuario.Visible = false;
                btnAcceder.Visible = false;
                BtnCancelar.Visible = false;
                picImagen.Visible = false;
                lnkRecuperacion.Visible = false;
                lblUsuario.Visible = false;
                lblContra.Visible = false;
                panelusuario.Visible = false;
                panelclave.Visible = false;
                panellogin.Visible = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Constructor_Login log = new Constructor_Login();
        void Log_In(string usuario, string clave)
        {
            Constructor_Login.usuario = usuario;
            log.clave = Validaciones.md5(txtContrasena.Text);
            //MessageBox.Show(clave);
            bool resultado = Validar_Login_Modelo.Validar_Acceso(log);
            if (resultado == true && txtContrasena.Text == txtUsuario.Text + "primeruso")
            {
                FrmPrimerUsoClave pu = new FrmPrimerUsoClave(txtUsuario.Text);
                pu.Show();
                this.Hide();
            }
            else if (resultado == true && txtContrasena.Text != txtUsuario.Text + "primeruso")
            {
                FrmPrincipal main = new FrmPrincipal();
                main.Show();
                this.Hide();
            }
        }

        protected void ValidarLog()
        {
            if (txtUsuario.Text.Trim() != "" || txtContrasena.Text.Trim() != "")
            {    
                Log_In(txtUsuario.Text, txtContrasena.Text);
            }
            else
            {
                MessageBox.Show("Los campos están vacíos.","Datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click_2(object sender, EventArgs e)
        {
            ValidarLog();
        }

        private void txtContrasena_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarLog();
            }
        }

        private void BtnPrimerUso_Click_1(object sender, EventArgs e)
        {
            if (BtnPrimerUso.LabelText == "Crear primer usuario")
            {
                FrmPrimerUsuario primerusuario = new FrmPrimerUsuario();
                primerusuario.Show();
                this.Hide();
            }
            else
            {
                FrmPrimerUso pu = new FrmPrimerUso();
                pu.Show();
                this.Hide();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarLog();
            }
        }

        private void lnkRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMetodosRecuperacion met = new FrmMetodosRecuperacion();
            met.Show();
            this.Hide();
        }
    }
}

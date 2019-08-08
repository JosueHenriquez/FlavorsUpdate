using System;
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

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();            
        }

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
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPrimerUso_Click(object sender, EventArgs e)
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

        public static string md5(string Value)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(Value);
            data = x.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < data.Length; i++)
                ret += data[i].ToString("x2").ToLower();
            return ret;
        }

        protected void ValidarLog(string usuario, string clave)
        {
            if (usuario.Trim() != "" || clave.Trim() != "")
            {
                Constructor_Login log = new Constructor_Login();
                Constructor_Login.usuario = usuario;
                log.clave = md5(clave);
                //MessageBox.Show(log.clave);
                bool resultado = Validar_Login_Modelo.Validar_Acceso(log);
                if (resultado == true && Constructor_Login.primer_uso == 0)
                {
                    FrmPrimerUsoClave pu = new FrmPrimerUsoClave();
                    pu.Show();
                    this.Hide();
                }
                else if(resultado == true)
                {
                    FrmPrincipal main = new FrmPrincipal();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Los campos están vacíos.","Datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            ValidarLog(txtUsuario.Text, txtContrasena.Text);
        }
    }
}

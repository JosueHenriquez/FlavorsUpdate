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
using FlavorsOfTheHouse.Modelo;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmRecuperacionPorCorreo : Form
    {
        public FrmRecuperacionPorCorreo()
        {
            InitializeComponent();
        }

        private void FrmRecuperacionPorCorreo_Load(object sender, EventArgs e)
        {
            grpNuevaClave.Enabled = false;
            BtnVerificarCodigo.Enabled = false;
            txtCodigo.Enabled = false;
        }

        void Verificar_Credenciales()
        {
            Constructor_Recuperacion_xCorreo em = new Constructor_Recuperacion_xCorreo();
            em.usuario_recuperar = txtUsuarioRecuperar.Text;
            em.correo = txtEmail.Text;
            //****************************
        }
        private void BtnValidarCredenciales_Click(object sender, EventArgs e)
        {
            if (ControlRecuCorreo.VerficarCredenciales(txtUsuarioRecuperar.Text, txtEmail.Text) == true)
            {
                Random rmd = new Random();
                int a = rmd.Next(0, 10);
                int b = rmd.Next(0, 10);
                int c = rmd.Next(0, 10);
                int d = rmd.Next(0, 10);
                int r = rmd.Next(0, 10);
                int f = rmd.Next(0, 10);

                string codigo = a.ToString() + b.ToString() + c.ToString() + d.ToString() + r.ToString() + f.ToString();

                ConstructorEmpresa_Controlador correo = new ConstructorEmpresa_Controlador();
                string sending = correo.correo;
                Constructor_Usuario recu = new Constructor_Usuario();
                string email = txtEmail.Text;
                System.Net.Mail.MailMessage mssg = new System.Net.Mail.MailMessage();
                mssg.To.Add(email);
                mssg.Subject = "Nuevo código de recuperación de contraseña";
                mssg.SubjectEncoding = System.Text.Encoding.UTF8;

                mssg.Body = "Su código de recuperación de contraseña es " + codigo + " por favor, inicie sesión con su usuario y el código asignado.";
                mssg.BodyEncoding = Encoding.UTF8;
                mssg.IsBodyHtml = true;
                mssg.From = new System.Net.Mail.MailAddress(sending);

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential(sending, "SaboresITR2019");
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                try
                {
                    cliente.Send(mssg);
                    MessageBox.Show("enviado");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void BtnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

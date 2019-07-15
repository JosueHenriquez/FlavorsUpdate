using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            Thread t = new Thread(new ThreadStart(StarForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }

        public void StarForm()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "Usuario")
            {
                lblUsuario.Visible = false;
                lblUsuario.Text = txtUsuario.Text;
                txtUsuario.Text = "";
                lblUsuario.ForeColor = Color.FromArgb(0, 122, 204);
                lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Bold);
                animacionUsuario.Show(lblUsuario);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Bold);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                txtUsuario.Text = lblUsuario.Text;
                lblUsuario.Visible = false;
                lblUsuario.ForeColor = Color.FromArgb(0, 0, 0);
                lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Bold);
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                lblContra.Visible = false;
                lblContra.Text = txtContrasena.Text;
                txtContrasena.Text = "";
                lblContra.ForeColor = Color.FromArgb(0, 122, 204);
                lblContra.Font = new Font(lblContra.Font, FontStyle.Bold);
                txtContrasena.UseSystemPasswordChar = true;
                animacionContra.Show(lblContra);
            }            
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Trim() == "")
            {
                txtContrasena.Text = lblContra.Text;
                lblContra.Visible = false;
                lblContra.ForeColor = Color.FromArgb(0, 0, 0);
                lblContra.Font = new Font(lblContra.Font, FontStyle.Bold);
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

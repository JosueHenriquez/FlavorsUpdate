using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Controlador;
using FlavorsOfTheHouse.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmIntervenciondeAdministrador : Form
    {
        public FrmIntervenciondeAdministrador()
        {
            InitializeComponent();
        }

        private void FrmIntervenciondeAdministrador_Load(object sender, EventArgs e)
        {
            grp2.Enabled = false;
            lbldiferente.Visible = false;
        }

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
        }

        private void LinkMetodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMetodosRecuperacion met = new FrmMetodosRecuperacion();
            met.Show();
            this.Hide();
        }
        Constructor_Usuario save = new Constructor_Usuario();
        public void VerificaciondeCredenciales()
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "" ||txtUsuario.Text.Trim()=="")
            {
                MessageBox.Show("Existen campos vacios", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tipo = 2;
                save.usuario = txtUsuarioAdmin.Text;
                save.clave = Validaciones.md5(txtClaveAdmin.Text);
                save.id_tipo_usuario = tipo;
                if (ControlRecuAdmin.VerificarAdmin(save) == true)
                {
                        save.usuario = txtUsuario.Text;
                        if (ControlRecuAdmin.VerificarUsuario(save) == true)
                        {
                            grp2.Enabled = true;
                            grp1.Enabled = false;
                        }
                    }
                }
            }
       
       
        public void CambiarContraseña()
        {

            if (txtNewClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las Contraseñas no coinciden, Vuelva a intentarlo", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewClave.Clear();
                lbldiferente.Visible = true;
                txtConfirmarClave.Clear();
            }
            else if (txtNewClave.Text.Trim()==""||txtConfirmarClave.Text.Trim()=="")
            {
                MessageBox.Show("Atencion: Complete todos los campos","Datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                save.usuario = txtUsuario.Text;
                save.clave = Validaciones.md5(txtNewClave.Text);
                bool datos = ControlRecuAdmin.ActualizarConstraseña(save);
                if (datos == true)
                {
                    FrmLogin log = new FrmLogin();
                    log.Show();
                    this.Hide();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerificaciondeCredenciales();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMetodosRecuperacion mt = new FrmMetodosRecuperacion();
            mt.Show();
            this.Hide();
        }
    }
}

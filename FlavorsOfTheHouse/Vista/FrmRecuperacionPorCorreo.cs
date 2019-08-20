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

        }
    }
}

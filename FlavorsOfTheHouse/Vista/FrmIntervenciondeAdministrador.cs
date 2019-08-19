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
            grpNuevaClave.Enabled = false;
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
    }
}

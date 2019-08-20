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
    public partial class FrmMetodosRecuperacion : Form
    {
        public FrmMetodosRecuperacion()
        {
            InitializeComponent();
        }

        private void picRegresarLogin_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
        }

        private void picCorreo_Click(object sender, EventArgs e)
        {
            FrmRecuperacionPorCorreo frmcorreo = new FrmRecuperacionPorCorreo();
            frmcorreo.Show();
            this.Hide();
        }
    }
}

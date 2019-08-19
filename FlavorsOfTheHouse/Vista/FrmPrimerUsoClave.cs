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
    public partial class FrmPrimerUsoClave : Form
    {
        public FrmPrimerUsoClave()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClave_Enter(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            if (txtClave.Text.Trim() == "")
            {
                lblnuevaclave.ForeColor = Color.DodgerBlue;
                lblnuevaclave.Font = new Font(this.Font, FontStyle.Bold);
                panelnuevaclave.BackColor = Color.DodgerBlue;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "")
            {
                lblnuevaclave.ForeColor = Color.Black;
                lblnuevaclave.Font = new Font(this.Font, FontStyle.Regular);
                panelnuevaclave.BackColor = Color.Black;
            }
        }

        private void txtConfClave_Enter(object sender, EventArgs e)
        {
            txtConfClave.UseSystemPasswordChar = true;
            if (txtConfClave.Text.Trim() == "")
            {
                lblconfclave.ForeColor = Color.DodgerBlue;
                lblconfclave.Font = new Font(this.Font, FontStyle.Bold);
                panelconfclave.BackColor = Color.DodgerBlue;
                
            }
        }

        private void txtConfClave_Leave(object sender, EventArgs e)
        {
            if (txtConfClave.Text.Trim() == "")
            {
                lblconfclave.ForeColor = Color.Black;
                lblconfclave.Font = new Font(this.Font, FontStyle.Regular);
                panelconfclave.BackColor = Color.Black;
            }
        }

        private void FrmPrimerUsoClave_Load(object sender, EventArgs e)
        {
            picOcultarClave.Visible = false;
        }

        private void picVerClave_Click(object sender, EventArgs e)
        {
            picVerClave.Visible = false;
            if (picVerClave.Visible == false)
            {
                txtClave.UseSystemPasswordChar = false;
                txtConfClave.UseSystemPasswordChar = false;
                picOcultarClave.Visible = true;
            }
        }

        private void picOcultarClave_Click(object sender, EventArgs e)
        {
            picOcultarClave.Visible = false;
            if (picOcultarClave.Visible == false)
            {
                txtClave.UseSystemPasswordChar = true;
                txtConfClave.UseSystemPasswordChar = true;
                picVerClave.Visible = true;
            }
        }

        private void txtConfClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() != txtConfClave.Text.Trim())
            {
                lblClaves.Visible = true;
            }
            else
            {
                lblClaves.Visible = false;
            }
        }

        private void FrmPrimerUsoClave_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

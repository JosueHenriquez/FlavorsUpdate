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
    public partial class FrmRegistroEmpresas : Form
    {
        public FrmRegistroEmpresas()
        {
            InitializeComponent();
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen (.jpg)|*.jpg|Archivo de imagen (.png)|*.png|Archivo de imagen (.jpeg)|*.jpeg|Archivo de imagen (.tiff)|*.tiff";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName );
            }
        }
        
        void Agregar_Empresa()
        {
            if (TxtEmpresa.Text.Trim() == "" ||
                TxtNit.Text.Trim() == "" ||
                TxtDireccion.Text.Trim() == "" ||
                )
            {

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

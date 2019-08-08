using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlavorsOfTheHouse.Controlador;
using System.IO;
using System.Drawing.Imaging;
using FlavorsOfTheHouse.Modelo;

namespace FlavorsOfTheHouse.Vista
{
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        void Insertar_Empresa()
        {
            if (TxtEmpresa.Text.Trim() == "" || TxtDireccion.Text.Trim() == "" || TxtLegal.Text.Trim() == "" || TxtNit.Text.Trim() == "" || pbLogo.Image == null)
            {
                MessageBox.Show("Verique que todos los campos completos o haber asignado el logo de su empresa.", "Informacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConstructorEmpresa_Controlador reg = new ConstructorEmpresa_Controlador();
                int tipo_empresa = 1;
                int estado = 1;
                reg.nombre_empresa = TxtEmpresa.Text;
                reg.nit = TxtNit.Text;
                reg.representante = TxtLegal.Text;
                reg.direccion = TxtDireccion.Text;
                reg.tipo_empresa = tipo_empresa;
                reg.estado = estado;

                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string encoded = Convert.ToBase64String(aByte);
                reg.imagen = encoded;

                
                if (PrimerUso_Modelo.IngresarEmpresa(reg) >= 1)
                {
                    FrmPrimerUsuario fuser= new FrmPrimerUsuario();
                    fuser.Show();
                    this.Hide();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Insertar_Empresa();            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivos de Imagen (.png)|*.png| Archivos de Imagen (.jpeg)|*.jpeg| Todos los archivos|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Oops, Ha ocurrido un error, considere las posibles soluciones \n 1. El nombre de la imagen no es válido. \n 2. La extención de la imagen no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrimerUso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

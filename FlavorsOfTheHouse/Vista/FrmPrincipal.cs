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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Form currentForm;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    PanelContenedor.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in PanelContenedor.Controls)
            {

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer cerrar el programa?\nConsidere que si tiene información en edición no podrá recuperarla.", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = false;
            BtnNormal.Visible = true;
            Screen screen = Screen.PrimaryScreen;
            int Height = screen.Bounds.Height;
            int Width = screen.Bounds.Width;
            this.MaximumSize = new Size(Width, Height - 37);
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            BtnNormal.Visible = false;
            BtnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UbicacionBotones()
        {
            BtnAdministracion.Location = new Point(0, 128);
            BtnInventario.Location = new Point(0, 177);
            BtnVentas.Location = new Point(0, 226);
            BtnFacturacion.Location = new Point(0,275);
            //BtnConfiguracion.Location = new Point(0,563);    
        }

        private void EstadoPaneles()
        {
            //paneles
            PanelAdministracion.Visible = false;
            PanelVentas.Visible = false;
            PanelInventario.Visible = false;
            
            PanelAjustes.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Constructor_Login.usuario;
            switch (Constructor_Login.nivel)
            {
                case 1:
                    lblNivel.Text = "Administrador General (Root)";
                    break;
                case 2:
                    lblNivel.Text = "Coordinador";
                    break;
                case 3:
                    lblNivel.Text = "Encargado de empresa";
                    break;
                case 4:
                    lblNivel.Text = "Asistente Empresarial";
                    break;
                case 5:
                    lblNivel.Text = "Vendedor";
                    break;
                case 6:
                    lblNivel.Text = "Encargado de Facturación";
                    break;
                default:
                    break;
            }
            PanelSidebar.Width = 236;
            //Estados de paneles
            EstadoPaneles();
            //Ubicacion Inicial de botones
            UbicacionBotones();
            AbrirFormulario<FrmInicio>();
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            if (PanelAdministracion.Visible == true)
            {
                EstadoPaneles();
                UbicacionBotones();
            }
            else
            {
                //Ocultamiento de todos los paneles
                EstadoPaneles();
                //Mostramos el panel requerido
                PanelAdministracion.Visible = true;
                PanelAdministracion.Location = new Point(0,176);
                BtnAdministracion.Location = new Point(0, 128);
                //Nueva ubicación de botones            
                BtnInventario.Location = new Point(0,313);
                BtnVentas.Location = new Point(0,362);
                BtnFacturacion.Location = new Point(0,411);
            }

            if (PanelAdministracion.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            if (PanelInventario.Visible == true)
            {
                EstadoPaneles();
                UbicacionBotones();
            }
            else
	        {
                //Ocultamiento de todos los paneles
                EstadoPaneles();
                //Mostrando panel requerido
                PanelInventario.Visible = true;
                PanelInventario.Location = new Point(0, 226);
                BtnInventario.Location = new Point(0, 177);
                //Ubicación de botones
                BtnAdministracion.Location = new Point(0, 128);
                BtnVentas.Location = new Point(0,362);
                BtnFacturacion.Location = new Point(0, 411);
            }
            if (PanelInventario.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (PanelVentas.Visible == true)
            {
                EstadoPaneles();
                UbicacionBotones();
            }
            else
            {
                //Ocultar todos los paneles
                EstadoPaneles();
                //Mostrar el panel requerido
                PanelVentas.Visible = true;
                PanelVentas.Location = new Point(0,275);
                BtnVentas.Location = new Point(0,226);
                //Ubicación de botones
                BtnAdministracion.Location = new Point(0, 128);
                BtnInventario.Location = new Point(0, 177);
                BtnFacturacion.Location = new Point(0, 500);
            }
            if (PanelVentas.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PanelSidebar.Width == 236)
            {
                PanelSidebar.Width = 59;
                LineaSidebar.Width = 52;
                //BtnMenu.Text = "Expandir Menú";
            }
            else
            {
                PanelSidebar.Width = 236;
                LineaSidebar.Width = 222;
                //BtnMenu.Text = "Contraer Menú";
            }
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            if (PanelAjustes.Visible == true)
            {
                EstadoPaneles();
                UbicacionBotones();
            }
            else
            {
                //Ocultar todos los paneles
                EstadoPaneles();
                //Mostrar Panel requerido
                PanelAjustes.Visible = true;
                if (BtnMaximizar.Visible == false)
                {
                    PanelAjustes.Location = new Point(0, Height-189);
                }
                else
                {
                    PanelAjustes.Location = new Point(0, 508);
                }

                //Moviendo Botones a posiciones originales
                UbicacionBotones();
            }
            if (PanelAjustes.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmControlUsuarios>();
        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroEmpresas>();
        }

        private void BtnConfUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPrimerUsuario>();
        }

        private void BtnEmpresaPpal_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPrimerUso>();
        }
    }
}

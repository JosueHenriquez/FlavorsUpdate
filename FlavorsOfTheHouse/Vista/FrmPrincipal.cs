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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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
            this.MaximumSize = new System.Drawing.Size(Width, Height - 40);
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
            BtnLibros.Location = new Point(0,275);     
        }

        private void EstadoPaneles()
        {
            //paneles
            PanelAdministracion.Visible = false;
            PanelVentas.Visible = false;
            PanelInventario.Visible = false;
            PanelLibros.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Width = 236;
            //Barra de titulo
            BtnMaximizar.Visible = true;
            //Estados de paneles
            EstadoPaneles();
            //Ubicacion Inicial de botones
            UbicacionBotones();
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
                BtnLibros.Location = new Point(0,411);
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
                BtnLibros.Location = new Point(0, 411);
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
                BtnLibros.Location = new Point(0, 411);
            }
            if (PanelVentas.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            if (PanelLibros.Visible == true)
            {
                EstadoPaneles();
                UbicacionBotones();
            }
            else
            {
                //Ocultar todos los paneles
                EstadoPaneles();
                //Mostrar panel requerido
                PanelLibros.Visible = true;
                PanelLibros.Location = new Point(0,324);
                BtnLibros.Location = new Point(0,275);
                //Mover botones
                BtnAdministracion.Location = new Point(0, 128);
                BtnInventario.Location = new Point(0, 177);
                BtnVentas.Location = new Point(0, 226);
            }
            if (PanelLibros.Visible == false)
            {
                UbicacionBotones();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PanelSidebar.Width == 236)
            {
                PanelSidebar.Width = 56;
                BtnMenu.Text = "Expandir Menú";
            }
            else
            {
                PanelSidebar.Width = 236;
                BtnMenu.Text = "Contraer Menú";
            }
        }
    }
}

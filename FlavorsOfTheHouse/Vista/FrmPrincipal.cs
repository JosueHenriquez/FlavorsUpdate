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

        private void UbicacionBotones()
        {
            BtnAdministracion.Location = new Point(0, 38);
            BtnInventario.Location = new Point(0, 87);
            BtnVentas.Location = new Point(0, 136);         
        }

        private void EstadoPaneles()
        {
            //paneles
            PanelAdministracion.Visible = false;
            PanelReporte.Visible = false;
            PanelVentas.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Width = 236;
            //Barra de titulo
            BtnMaximizar.Visible = true;
            //Estados de paneles
            PanelAdministracion.Visible = false;
            PanelReporte.Visible = false;
            //Ubicacion Inicial de botones
            UbicacionBotones();
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            if (PanelAdministracion.Visible == true)
            {
                EstadoPaneles();
            }
            else
            {
                //Ocultamos panel para que el efecto sea visible
                AnimacionAdministracion.Show(PanelAdministracion);
                PanelAdministracion.Visible = true;
                PanelAdministracion.Location = new Point(0,86);             
                BtnInventario.Location = new Point(0,226);
                PanelReporte.Visible = false;
            }

            if (PanelAdministracion.Visible == false)
            {
                BtnAdministracion.Location = new Point(0,38);
                BtnInventario.Location = new Point(0,87);
            }
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            if (PanelReporte.Visible == true)
            {
                EstadoPaneles();
            }
            else
	        {
                PanelAdministracion.Visible = false;
                AnimacionInventario.Show(PanelReporte);
                PanelReporte.Visible = true;
                BtnInventario.Location = new Point(0, 87);
                PanelReporte.Location = new Point(0, 136);
                BtnVentas.Location = new Point(0,142);
            }           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer cerrar el programa?\nConsidere que si tiene información en edición no podrá recuperarla.","Confirmación de cierre",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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
    }
}

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

namespace FlavorsOfTheHouse.Reportes
{
    public partial class ReporteFacturacion : Form
    {
        private int idfactura, idusuario;
        public ReporteFacturacion(int idfactura, int idusuario)
        {
            InitializeComponent();
            this.idfactura = idfactura;
            this.idusuario = idusuario;
        }

        private void ReporteFacturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFactura.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.ObtenerDetalles(this.dataSetFactura.DataTable, idfactura, Convert.ToInt16(Constructor_Login.empresa));

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
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
    public partial class ReporteInventario : Form
    {
        private int idempresa;
        public ReporteInventario(int idempresa)
        {
            InitializeComponent();
            this.idempresa = idempresa;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetInventario.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.ObtenerInventario(this.DataSetInventario.DataTable,idempresa);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}

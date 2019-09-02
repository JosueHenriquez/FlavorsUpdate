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
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetUsuarios.tbusuarios' Puede moverla o quitarla según sea necesario.
            this.tbusuariosTableAdapter.VerTodosLosUsuarios(this.DataSetUsuarios.tbusuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}

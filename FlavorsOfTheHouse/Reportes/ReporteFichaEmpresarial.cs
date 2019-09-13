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
    public partial class ReporteFichaEmpresarial : Form
    {
        private int id_empresa;
        public ReporteFichaEmpresarial(int idempresa)
        {
            InitializeComponent();
            this.id_empresa = idempresa;
        }

        private void ReporteFichaEmpresarial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFichaEmpresa.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.VerFicha(this.DataSetFichaEmpresa.DataTable,id_empresa);

            this.reportViewer1.RefreshReport();
        }
    }
}

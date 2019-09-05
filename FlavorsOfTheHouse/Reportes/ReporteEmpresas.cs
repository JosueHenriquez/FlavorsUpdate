using System;
using FlavorsOfTheHouse.Modelo;
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
    public partial class ReporteEmpresas : Form
    {
        public ReporteEmpresas()
        {
            InitializeComponent();
        }

        private void ReporteEmpresas_Load(object sender, EventArgs e)
        {
            ReporteGeneral();
            cmbEmpresa.DataSource = ObtenerDatos_Modelo.ObtenerTipoEmpresa();
            cmbEmpresa.DisplayMember = "tipo_empresa";
            cmbEmpresa.ValueMember = "id_tipo_empresa";
        }

        void ReporteGeneral()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEmpresa.tbempresa' Puede moverla o quitarla según sea necesario.
            this.tbempresaTableAdapter.VerTodasLasEmpresas(this.DataSetEmpresa.tbempresa);
            this.reportEmpresa.RefreshReport();
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            ReporteGeneral();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEmpresa.tbempresa' Puede moverla o quitarla según sea necesario.
            this.tbempresaTableAdapter.ConsultaParametrizadaEmpresa(this.DataSetEmpresa.tbempresa,Convert.ToInt16(cmbEmpresa.SelectedValue));
            this.reportEmpresa.RefreshReport();
        }
    }
}

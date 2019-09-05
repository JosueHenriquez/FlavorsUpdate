using FlavorsOfTheHouse.Modelo;
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
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        void CargarReporte()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProducto.tbproducto' Puede moverla o quitarla según sea necesario.
            this.tbproductoTableAdapter.VerTodosLosProductos(this.DataSetProducto.tbproducto);
            this.reportViewer1.RefreshReport();
        }
        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEmpresa.DataSource = ControlEmpresas_Modelo.ObtenerEmpresa();
                cmbEmpresa.DisplayMember = "empresa";
                cmbEmpresa.ValueMember = "id_empresa";
                CargarReporte();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProducto.tbproducto' Puede moverla o quitarla según sea necesario.
            this.tbproductoTableAdapter.ConsultaParametrizada(this.DataSetProducto.tbproducto,Convert.ToInt16(cmbEmpresa.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}

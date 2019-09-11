using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlavorsOfTheHouse.Modelo;

namespace FlavorsOfTheHouse.Reportes
{
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario()
        {
            InitializeComponent();
        }
        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetUsuarios.DataTableUsuarios' Puede moverla o quitarla según sea necesario.
            this.DataTableUsuariosTableAdapter.VerTodasLosUsuarios(this.DataSetUsuarios.DataTableUsuarios);
            this.reportViewer1.RefreshReport();
            try
            {
                cmbTipoUsuarios.DataSource = ObtenerDatos_Modelo.ObtenerTipo_Usuario();
                cmbTipoUsuarios.DisplayMember = "tipo_usuario";
                cmbTipoUsuarios.ValueMember = "id_tipo_usuario";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetUsuarios.DataTableUsuarios' Puede moverla o quitarla según sea necesario.
            this.DataTableUsuariosTableAdapter.ConsultaParametrizada(this.DataSetUsuarios.DataTableUsuarios,Convert.ToInt16(cmbTipoUsuarios.SelectedValue));
            this.reportViewer1.RefreshReport();
        }
        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetUsuarios.DataTableUsuarios' Puede moverla o quitarla según sea necesario.
            this.DataTableUsuariosTableAdapter.VerTodasLosUsuarios(this.DataSetUsuarios.DataTableUsuarios);
            this.reportViewer1.RefreshReport();
        }
    }
}

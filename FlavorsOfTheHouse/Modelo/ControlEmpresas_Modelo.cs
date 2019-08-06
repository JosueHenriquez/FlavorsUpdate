using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlavorsOfTheHouse.Config;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlEmpresas_Modelo
    {
        public static DataTable ObtenerEmpresa()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbempresa";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los datos de las empresas solicitados, consulte con el administrador.","Error de carga",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }   
        }
    }
}

using FlavorsOfTheHouse.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlProductos
    {
        public static DataTable ObtenerEmpresa(int idusuario)
        {
            DataTable data = new DataTable();
            string query = "SELECT te.id_empresa, te.empresa FROM tbempresa te, tbusuario tu WHERE tu.id_empresa = te.id_empresa AND tu.id_usuario = ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",idusuario));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                adp.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error critico, no se ha podido recuperar la empresa para los productos debido a un fallo en la conexión. " + ex,"Error de conexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data;
            }
        }
        public static DataTable ObtenerEmpresas()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbempresa te";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                adp.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error critico, no se ha podido recuperar la empresa para los productos debido a un fallo en la conexión. " + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static bool Verificar_Codigo(int codigo)
        {
            bool retorno = false;
            string query = "SELECT * FROM codigo_producto = ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",codigo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en la verificación del codigo de producto, verifique su conexión a internet o consulte con el administrador","Error de consulta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Cargar_Productos()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbproducto";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                adp.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error critico, no se ha npodido recuperar los productos debido a un fallo en la conexión. " + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static DataTable Cargar_Tipo_Productos()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbcategoria_producto";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                adp.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error critico, no se ha npodido recuperar los productos debido a un fallo en la conexión. " + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static DataTable Cargar_Estado_Productos()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbestado_producto";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                adp.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error critico, no se ha npodido recuperar los productos debido a un fallo en la conexión. " + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
    }
}

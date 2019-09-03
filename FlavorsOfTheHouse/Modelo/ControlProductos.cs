using FlavorsOfTheHouse.Config;
using MySql.Data.MySqlClient;
using System;
using FlavorsOfTheHouse.Controlador;
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
            string query = "SELECT * FROM tbempresa";
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
            string query = "SELECT * FROM tbproducto WHERE codigo_producto = ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",codigo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la verificación del codigo de producto, verifique su conexión a internet o consulte con el administrador " + ex,"Error de consulta",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        public static int Ingresar_Producto(Constructor_Producto pro)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbproducto (nombre_producto, codigo_producto, precio , id_usuario, fecha_caducidad, fecha_empacado, existencia, id_categoria, id_empresa, id_estado) VALUES ('"+pro.producto+"','"+pro.codigo_producto+ "','"+pro.precio+ "','"+pro.id_usuario+ "','"+pro.empacado+ "','"+pro.vencimiento+ "','"+pro.cantidad+ "','"+pro.id_tipo+ "','"+pro.id_empresa+ "','"+pro.id_estado+"')"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Producto registrado exitosamente.","Proceso completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser registrado.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, ocurrio un error durante la inserción de datos, verifique su conexión a internet. " + ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}

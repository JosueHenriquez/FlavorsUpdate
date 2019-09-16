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
            string query = "SELECT DISTINCT tp.*, tc.categoria, te.empresa, ts.estado_producto, CONCAT(tu.nombres,' ',tu.apellidos) FROM tbproducto tp, tbusuario tu, tbcategoria_producto tc, tbempresa te, tbestado_producto ts WHERE tu.id_usuario =  tp.id_usuario AND tp.id_categoria = tc.id_categoria_producto AND tp.id_empresa = te.id_empresa AND tp.id_estado = ts.id_estado_producto";
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
        public static bool ObtenerUsuarioPro(int idusuario)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT CONCAT(nombres,' ',apellidos) As Nombres FROM tbusuario WHERE id_usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno ==  true)
                {
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        Constructor_Producto.usuario = reader.GetString(0);
                    }
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Los nombres de usuario no pudieron ser recuperados intentelo nuevamente, debido a un problema de conexión","Error de conexión",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static int Actualizar_Producto(Constructor_Producto cpro)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbproducto SET nombre_producto = '"+cpro.producto+ "', precio = '" + cpro.precio + "', fecha_empacado = '"+cpro.empacado+ "', fecha_caducidad = '" + cpro.vencimiento+ "', existencia = '"+cpro.cantidad+"', id_categoria = '"+cpro.id_tipo+"', id_empresa = '"+cpro.id_empresa+"', id_estado = '"+cpro.id_estado+"' WHERE id_producto = '"+cpro.id_producto+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("El producto ha sido actualizado con exito.","Proceso completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ocurrio un error en la actualización de datos del producto, debido a un fallo de conexión, consulte con su administrador.","Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Eliminar_Producto(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbproducto WHERE id_producto = '"+id+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("El producto fue eliminado correctamente.","Proceso completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de conexión al momento de eliminar el producto, consulte al administrador. " + ex,"Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Cargar_Productos_PorEmpresa(int idempresa)
        {
            DataTable data = new DataTable();
            string query = "SELECT tp.*, CONCAT(tu.nombres,' ',tu.apellidos) As Nombres FROM tbproducto tp, tbusuario tu WHERE tp.id_empresa = ?param1 AND tp.id_usuario = tu.id_usuario ORDER BY tp.nombre_producto";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",idempresa));
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
        public static DataTable Inventario_General()
        {
            DataTable data = new DataTable();
            string query = "SELECT DISTINCT tp.*, CONCAT(tu.nombres,' ',tu.apellidos) As Nombres FROM tbproducto tp, tbusuario tu WHERE tp.id_usuario = tu.id_usuario ORDER BY nombre_producto ASC";
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

using System;
using FlavorsOfTheHouse.Controlador;
using FlavorsOfTheHouse.Config;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlFacturacion
    {
        public static int Crear_Factura(Constructor_Facturacion fa)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbfactura (id_usuario,fecha_factura,id_estado) VALUES ('"+fa.id_usuario+"','"+fa.fecha_factura+"','"+fa.id_estado+"')"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                if (retorno < 1)
                {
                    MessageBox.Show("La factura no pudo ser creada.", "Error de facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "SELECT MAX(id_factura)  FROM tbfactura WHERE id_usuario = ?param1 AND fecha_factura = ?param2";
                    MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                    cmdselect.Parameters.Add(new MySqlParameter("param1",fa.id_usuario));
                    cmdselect.Parameters.Add(new MySqlParameter("param2",fa.fecha_factura));
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        fa.id_factura = reader.GetInt16(0);
                    }
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ocurrio un error al generar la factura, consulte con el administrador. ","Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Buscar_Producto(string producto)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT id_producto, nombre_producto, existencia, precio FROM tbproducto WHERE codigo_producto = ?param1 OR nombre_producto = ?param2";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", producto));
                cmdselect.Parameters.Add(new MySqlParameter("param2", producto));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        DatosProductos.idpro = reader.GetInt16(0);
                        DatosProductos.nombreproducto = reader.GetString(1);
                        DatosProductos.cantidad = reader.GetInt16(2);
                        DatosProductos.precio = reader.GetDouble(3);
                    }
                }
                else
                {
                    MessageBox.Show("El producto solicitado no se encuentra registrado, consulte el inventario para ver el codigo de producto o el nombre respectivo.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al momento de buscar el producto.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int IngresarDetalle(Constructor_Detalle_Factura det)
        {
            int retorno = 0;
            try
            {
                string query1 = "SELECT * FROM tbdetalle_factura WHERE id_factura = ?detalle AND id_producto = ?producto";
                MySqlCommand cmdselect1 = new MySqlCommand(query1, Conexion_Config.ObtenerConexion());
                cmdselect1.Parameters.Add(new MySqlParameter("detalle", det.id_factura));
                cmdselect1.Parameters.Add(new MySqlParameter("producto", det.id_producto));
                bool existencia = Convert.ToBoolean(cmdselect1.ExecuteScalar());
                if (existencia == false)
                {
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbdetalle_factura (id_producto, cantidad, id_factura, total_parcial) VALUES ('" + det.id_producto + "','" + det.cantidad + "','" + det.id_factura + "','" + det.total_parcial + "')"), Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                    if (retorno < 1)
                    {
                        MessageBox.Show("El detalle no pudo ser agregado a la factura.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Actualizar detalle
                    MySqlDataReader reader = cmdselect1.ExecuteReader();
                    while (reader.Read())
                    {
                        int iddetalle = reader.GetInt16(0);
                        int cantidad = reader.GetInt16(2);
                        double pago = reader.GetDouble(4) + det.total_parcial;
                        int nuevacantidad = cantidad + det.cantidad;
                        MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbdetalle_factura SET cantidad = '"+nuevacantidad+"', total_parcial = '"+pago+"' WHERE id_detalle_factura = '"+iddetalle+"'"),Conexion_Config.ObtenerConexion());
                        retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                        if (retorno <= 0)
                        {
                            MessageBox.Show("El detalle no pudo actualizarse.","Proceso no completado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }                
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un fallo de conexión durante el ingreso del detalle de compra.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable ObtenerDetalles(int idfactura)
        {
            DataTable data = new DataTable();
            string query = "SELECT tp.nombre_producto, tf.* FROM tbdetalle_factura tf, tbproducto tp WHERE tf.id_factura = ?param1 AND tp.id_producto = tf.id_producto";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",idfactura));
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
        public static int Actualizar_Cantidad_Productos(int idproducto, int nuevacantidad)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbproducto SET existencia = '"+nuevacantidad+"' WHERE id_producto = '"+idproducto+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                if (retorno < 1)
                {
                    MessageBox.Show("No se pudo actualizar la existencia de productos, consulte con el soporte técnico.","Error de actualización",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar la existencia de productos debido a un problema de conexión, consulte con el soporte técnico.", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }
        public static int Actualizar_Detalle_Factura(Constructor_Detalle_Factura det)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbdetalle_factura SET cantidad = '" + det.cantidad + "', total_parcial = '"+det.total_parcial+"' WHERE id_detalle_factura = '" + det.id_detalle_factura + "'"), Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                if (retorno < 1)
                {
                    MessageBox.Show("El detalle no pudo ser actualizado.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("El detalle no pudo ser actualizado debido a un fallo de conexión, verifique que está conectado a internet.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Eliminar_Detalle(int iddetalle)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddelete = new MySqlCommand(string.Format("DELETE FROM tbdetalle_factura WHERE id_detalle_factura = '"+iddetalle+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmddelete.ExecuteNonQuery());
                if (retorno>=1)
                {
                    MessageBox.Show("El detalle ha sido eliminado exitosamente.","Proceso completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La factura no pudo ser eliminada, reintentelo nuevamente.","Reintentar",MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error de conexión durante la eliminación del detalle, verifique su conexión a internet o consulte con el administrador.","Error de conexión",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Calcular_Pago(int idfactura)
        {
            int retorno = 0;
            try
            {
                string query1 = "SELECT * FROM tbdetalle_factura WHERE id_factura = ?detalle";
                MySqlCommand cmdselect1 = new MySqlCommand(query1, Conexion_Config.ObtenerConexion());
                cmdselect1.Parameters.Add(new MySqlParameter("detalle", idfactura));
                bool existencia = Convert.ToBoolean(cmdselect1.ExecuteScalar());
                if (existencia == true)
                {
                    string query = "SELECT SUM(total_parcial) FROM tbdetalle_factura WHERE id_factura = ?param1";
                    MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                    cmdselect.Parameters.Add(new MySqlParameter("param1", idfactura));
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        Constructor_Facturacion.total_pago = reader.GetDouble(0);
                    }
                }
                else
                {
                    Constructor_Facturacion.total_pago = 0;
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Debido a un fallo de conexión, no pudo calcularse el monto a pagar, consulte con el administrador.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Actualizar_Factura_PagoTotal(int idfactura, double monto)
        {
            int retorno = 0;
            try
            {
                int activa_finalizada= 1;
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbfactura SET total_pago = '"+monto+"', id_estado = '"+ activa_finalizada + "' WHERE id_factura = '"+idfactura+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("La factura "+idfactura+" ha sido finalizada con exito","Cierre de factura",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La factura " + idfactura + " no pudo ser finalizada, vuelva a intentarlo nuevamente.", "Cierre de factura fallido", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ocurrio un error en el cierre de la factura debido a un problema de conexión, consulte con el administrador.", "Cierre de factura fallido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Anular_Factura(int idfactura)
        {
            int retorno = 0;
            int mensaje = 0;
            try
            {
                string query = "SELECT COUNT(id_detalle_factura) FROM tbdetalle_factura WHERE id_factura = ?fac";
                MySqlCommand cmdcount = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdcount.Parameters.Add(new MySqlParameter("fac",idfactura));
                bool verificacion = Convert.ToBoolean(cmdcount.ExecuteScalar());
                if (verificacion == true)
                {
                    MySqlDataReader reader = cmdcount.ExecuteReader();
                    while (reader.Read())
                    { 
                        int repeticion = reader.GetInt16(0);
                        for (int i = 0; i < repeticion; i++)
                        {
                            string query2 = "SELECT DISTINCT MIN(id_detalle_factura), id_producto, cantidad FROM tbdetalle_factura WHERE id_factura = ?param1";
                            MySqlCommand cmdselect = new MySqlCommand(query2,Conexion_Config.ObtenerConexion());
                            cmdselect.Parameters.Add(new MySqlParameter("param1",idfactura));
                            MySqlDataReader reader2 = cmdselect.ExecuteReader();
                            while (reader2.Read())
                            {
                                int detalle = reader2.GetInt16(0);
                                int idproducto = reader2.GetInt16(1);
                                int cantidad = reader2.GetInt16(2);
                                //capturar el numero de productos
                                string query3 = "SELECT existencia FROM tbproducto WHERE id_producto  = ?param4";
                                MySqlCommand cmdselect3 = new MySqlCommand(query3,Conexion_Config.ObtenerConexion());
                                cmdselect3.Parameters.Add(new MySqlParameter("param4",idproducto));
                                MySqlDataReader reader3 = cmdselect3.ExecuteReader();
                                while (reader3.Read())
                                {
                                    int existencia = reader3.GetInt16(0);
                                    int nuevacantidad = existencia + cantidad;
                                    MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbproducto SET existencia = '"+nuevacantidad+"' WHERE id_producto = '"+idproducto+"'"),Conexion_Config.ObtenerConexion());
                                    retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                                    if (retorno > 0)
                                    {
                                        //**
                                        MySqlCommand cmddelete = new MySqlCommand(string.Format("DELETE FROM tbdetalle_factura WHERE id_detalle_factura = '"+detalle+"'"),Conexion_Config.ObtenerConexion());
                                        retorno = Convert.ToInt16(cmddelete.ExecuteNonQuery());
                                        if (retorno>0)
                                        {
                                            mensaje++;
                                            if (mensaje == repeticion)
                                            {
                                                int anulado = 3;
                                                MySqlCommand cmdupdatenull = new MySqlCommand(string.Format("UPDATE tbfactura SET id_estado = '" + anulado + "' WHERE id_factura = '" + idfactura + "'"), Conexion_Config.ObtenerConexion());
                                                retorno = Convert.ToInt16(cmdupdatenull.ExecuteNonQuery());
                                                if (retorno > 0)
                                                {
                                                    MessageBox.Show("Los detalles han sido eliminados correctamente y los productos han sido devueltos al inventario.", "Factura anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }//End for
                    } 
                }
                else
                {
                    int anulado = 3;
                    double pago_anulado = 0.00;
                    MySqlCommand cmdupdatenull = new MySqlCommand(string.Format("UPDATE tbfactura SET id_estado = '"+anulado+"', total_pago = '"+pago_anulado+"' WHERE id_factura = '"+idfactura+"'"),Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdupdatenull.ExecuteNonQuery());
                    if (retorno > 0)
                    {
                        MessageBox.Show("La factura ha sido anulada, y no se procedió al reintegro de los productos debido que no existian productos registrados en la factura.", "Factura anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return retorno;   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar los detalles de la factura debido a un problema de conexión. " + ex,"Error de procesamiento",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
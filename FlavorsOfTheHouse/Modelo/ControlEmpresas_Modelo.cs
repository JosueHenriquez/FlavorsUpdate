using MySql.Data.MySqlClient;
using System;
using FlavorsOfTheHouse.Controlador;
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
        public static int IngresarEmpresa(ConstructorEmpresa_Controlador constemp)
        {
            int retorno = 0;
            try
            {
                string query = "SELECT * FROM tbempresa WHERE empresa = ?empresa OR nit = ?nit";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("empresa", constemp.nombre_empresa));
                cmdselect.Parameters.Add(new MySqlParameter("nit", constemp.nit));
                retorno = Convert.ToInt16(cmdselect.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El nombre de la empresa o el numero de identificación tributario (NIT) ya están registrados en la base de datos, verifique que los datos sean los correctos", "Duplicidad de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempresa (empresa,correo, nit, representante_legal, id_tipo_empresa, id_estado, direccion, logoempresa) VALUES ('" + constemp.nombre_empresa + "','" + constemp.correo + "','" + constemp.nit + "','" + constemp.representante + "','" + constemp.tipo_empresa + "','" + constemp.estado + "','" + constemp.direccion + "','" + constemp.imagen + "')"), Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Proceso completado, la empresa ha sido registrada con exito", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Proceso no completado, no se pudo registrar la nueva empresa en la base de datos.", "Proceso no Completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la transmisión de datos, verifique su conexión a Internet y si el problema persite consulte con el administrador " + ex.Message, "Error de registro en empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable MostrarEmpresas_Grid_Activas()
        {
            DataTable data = new DataTable();
            int casaMatriz = 1;
            int activo = 1;
            string query = "SELECT id_empresa, empresa, correo, nit, representante_legal, tipo_empresa, estado, direccion, logoempresa FROM tbempresa tem, tbtipo_empresa ttip, tbestado tes WHERE tem.id_tipo_empresa = ttip.id_tipo_empresa AND tem.id_estado = tes.id_estado AND tem.id_empresa > ?param1 AND tem.id_estado = ?param2 ORDER BY tem.id_empresa ASC";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", casaMatriz));
                cmdselect.Parameters.Add(new MySqlParameter("param2", activo));
                MySqlDataAdapter _adapter = new MySqlDataAdapter(cmdselect);
                _adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de usuarios, consulta con el administrador. " + ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable MostrarEmpresas_Grid_General()
        {
            DataTable data = new DataTable();
            int casaMatriz = 1;
            string query = "SELECT id_empresa, empresa, correo, nit, representante_legal, tipo_empresa, estado, direccion, logoempresa FROM tbempresa tem, tbtipo_empresa ttip, tbestado tes WHERE tem.id_tipo_empresa = ttip.id_tipo_empresa AND tem.id_estado = tes.id_estado AND tem.id_empresa > ?param1 ORDER BY tem.id_empresa ASC";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", casaMatriz));
                MySqlDataAdapter _adapter = new MySqlDataAdapter(cmdselect);
                _adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de usuarios, consulta con el administrador. " + ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable MostrarEmpresas_Grid_Inactivas()
        {
            DataTable data = new DataTable();
            int casaMatriz = 1;
            int inactivo = 2;
            string query = "SELECT id_empresa, empresa, correo, nit, representante_legal, tipo_empresa, estado, direccion, logoempresa FROM tbempresa tem, tbtipo_empresa ttip, tbestado tes WHERE tem.id_tipo_empresa = ttip.id_tipo_empresa AND tem.id_estado = tes.id_estado AND tem.id_empresa > ?param1 AND tem.id_estado = ?param2 ORDER BY tem.id_empresa ASC";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", casaMatriz));
                cmdselect.Parameters.Add(new MySqlParameter("param2", inactivo));
                MySqlDataAdapter _adapter = new MySqlDataAdapter(cmdselect);
                _adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de usuarios, consulta con el administrador. " + ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerEncargadosEmpresa()
        {
            DataTable data = new DataTable();
            int encargado = 3;
            string query = "SELECT id_usuario, CONCAT(nombres,' ',apellidos) As nombre FROM tbusuario WHERE id_tipousuario = ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",encargado));
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los usuarios con posibilidad de ser encargados de empresa, consulte con el administrador.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static int Actualizar_Empresa(ConstructorEmpresa_Controlador emp)
        {
            int retorno = 0;
            try
            {
                //string query = "SELECT * FROM tbempresa WHERE empresa = ?param1 OR nit = ?param2 OR correo = ?param3";
                //MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                //cmdselect.Parameters.Add(new MySqlParameter("param1",emp.nombre_empresa));
                //cmdselect.Parameters.Add(new MySqlParameter("param2",emp.nit));
                //cmdselect.Parameters.Add(new MySqlParameter("param3",emp.correo));
                //if (Convert.ToBoolean(cmdselect.ExecuteScalar()) == true)
                //{
                //    MessageBox.Show("No se pueden actualizar los datos de la empresa, considere los siguientes errores. \n1. El nombre nuevo nombre de la empresa ya está registrado en el base de datos.\n2.El número de identificación tributario ya está registrado en la base de datos.\n3El correo electronico que desea ingresar para la empresa ya esta asignado a otra empresa.","Duplicidad de Información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //}
                //else
                //{
                    MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbempresa SET empresa = '"+emp.nombre_empresa+"', correo = '"+emp.correo+"', nit = '"+emp.nit+"', representante_legal = '"+emp.representante+"', id_tipo_empresa = '"+emp.tipo_empresa+"', id_estado = '"+emp.estado+"', direccion = '"+emp.direccion+"', logoempresa = '"+emp.imagen+"' WHERE id_empresa = '"+emp.id_empresa+"'"),Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Empresa actualizada con exito","Datos actualizados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La empresa no pudo ser actualizada, intentelo de nuevo","Actualización fallida",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                //}
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico, la empresa no pudo ser actualizada debido a un problema de conexión, verifique que este conectado a internet y si el problema persiste consulte con el tecnico de sistemas. " + e, "Error critico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static int Cambiar_Estado(int idempresa, int estado)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbempresa SET id_estado = '"+estado+"' WHERE id_empresa = '"+idempresa+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                if (retorno == 1 && estado == 1)
                {
                    MessageBox.Show("Se cambio el estado de la empresa a: ACTIVO","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if(retorno == 1 && estado == 2)
                {
                    MessageBox.Show("Se cambio el estado de la empresa a: INACTIVO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, no pudimos cambiar el estado de la empresa debido a un fallo en la conexión, verifica tu conexión a internet, y si el problema persiste consulta con el tecnico de sistemas.", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
    }
}

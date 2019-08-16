using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlavorsOfTheHouse.Controlador;
using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using System.Windows.Forms;
using System.Data;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlUsuarios_Modelo
    {
        public static int Ingresar_Usuario(Constructor_Usuario cpri)
        {
            int retorno = 0;
            try
            {
                string query = "SELECT * FROM tbusuario WHERE usuario = ?usuario OR documento = ?documento";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("usuario", cpri.usuario));
                cmdselect.Parameters.Add(new MySqlParameter("documento",cpri.documento));
                retorno = Convert.ToInt16(cmdselect.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El usuario o el documento que desea registrar ya se encuentra en la base de datos, verifique sus datos.","Error de datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    retorno = 0;
                }
                else
                {
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuario (usuario, clave, nombres, apellidos, documento, nacimiento, intentos, id_empresa, id_estado, id_tipousuario, foto) VALUES ('"+cpri.usuario+"','"+cpri.clave+"','"+cpri.nombres+ "','" + cpri.apellidos + "','" + cpri.documento + "','" + cpri.nacimiento + "','" + cpri.intentos + "','" + cpri.id_empresa + "','" + cpri.id_estado + "','" + cpri.id_tipo_usuario + "','" + cpri.imagen + "')"),Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario agregado exitosamente.","Proceso completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario que desea ingresar no pudo ser registrado.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        retorno = 0;
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de un nuevo usuario, verifique su conexión a internet, si el problema persiste consulte al administrador." + ex.Message, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static List<Constructor_Usuario> Buscar_usuario(string user)
        {
            List<Constructor_Usuario> lista = new List<Constructor_Usuario>();
            string query = "SELECT MAX(id_usuario) FROM tbusuario WHERE usuario = ?usuario";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("usuario", user));
                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    int usuario = reader.GetInt16(0);
                    Constructor_Usuario.id_usuario = usuario;
                }
                return lista;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el ID del usuario, consulte con el administrador","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return lista;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static int Ingresar_Respuesta(Constructor_Respuestas cres, int iduser)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbrespuesta (respuesta, id_pregunta, id_usuario)VALUES('"+cres.respuesta+"','"+cres.id_pregunta+"','"+iduser+"')"),Conexion_Config.ObtenerConexion());
                retorno = cmdinsert.ExecuteNonQuery();
                if (retorno<=0)
                {
                    MessageBox.Show("Las respuesta de seguridad no pudieron ser registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Las respuesta de seguridad no pudieron ser registradas debido a un fallo de conexión.","Error critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerUsuarios()
        {
            DataTable data = new DataTable();
            int tipousuarios = 2;
            string query = "SELECT * FROM tbusuario WHERE id_tipousuario >= ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",tipousuarios));
                MySqlDataAdapter _adapter = new MySqlDataAdapter(cmdselect);
                _adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de usuarios, consulta con el administrador. "+ ex.Message,"Error de selección",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
    }
}

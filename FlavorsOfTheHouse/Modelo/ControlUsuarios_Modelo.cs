using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlavorsOfTheHouse.Controlador;
using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlUsuarios_Modelo
    {
        public static int Ingresar_Usuario(Constructor_PrimerUsuario cpri)
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
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuario (usuario, clave, nombres, apellidos, documento, nacimiento, intentos, primer_uso, id_empresa, id_estado, id_tipousuario, foto, respuesta1, respuesta2, respuesta3, respuesta4) VALUES ('"+cpri.usuario+"','"+cpri.clave+"','"+cpri.nombres+ "','" + cpri.apellidos + "','" + cpri.documento + "','" + cpri.nacimiento + "','" + cpri.intentos + "','" + cpri.primer_uso + "','" + cpri.id_empresa + "','" + cpri.id_estado + "','" + cpri.id_tipo_usuario + "','" + cpri.imagen + "','" + cpri.respuesta1 + "','" + cpri.respuesta2 + "','" + cpri.respuesta3 + "','" + cpri.respuesta4 + "')"),Conexion_Config.ObtenerConexion());
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
    }
}

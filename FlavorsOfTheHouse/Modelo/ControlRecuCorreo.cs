using FlavorsOfTheHouse.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    public class ControlRecuCorreo
    {
        public static bool VerficarCredenciales(string user, string correo)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuario WHERE usuario = ?user AND email = ?correo";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("user", user));
                cmdselect.Parameters.Add(new MySqlParameter("correo",correo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MySqlCommand cmdcorreo = new MySqlCommand(string.Format("SELECT DISTINCT MIN(id_empresa), empresa, correo FROM tbempresa"),Conexion_Config.ObtenerConexion());
                    bool verificar = Convert.ToBoolean(cmdcorreo.ExecuteScalar());
                    MySqlDataReader readercorreo = cmdcorreo.ExecuteReader();
                    if (verificar == true)
                    {
                        while (readercorreo.Read())
                        {
                            Constructor_RecuCorreo.correo = readercorreo.GetString(2);
                        }
                        MySqlDataReader reader = cmdselect.ExecuteReader();
                        while (reader.Read())
                        {
                            Constructor_Usuario.id_usuario = reader.GetInt16(0);
                            MessageBox.Show("Los datos comparados son correctos ahora proceda a ingresar el código de verificación que se encuentra en su correo electrónico", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son érroneos porfavor verifique sus credenciales", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos, por favor verifique su conexión a internet " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static bool ActualizarContra(int id_usuario, string codigo)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET clave = '{0}' WHERE id_usuario = '{1}'", codigo, id_usuario), Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                if (retorno == false)
                {
                    MessageBox.Show("La contraseña no ha sido actualizada", "Proceso anulado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
       }

        public static bool VerificarCodigo(int id_usuario, string codigo)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdveri = new MySqlCommand(string.Format("SELECT * FROM tbusuario WHERE id_usuario = ?id AND clave = ?clave"),Conexion_Config.ObtenerConexion());
                cmdveri.Parameters.Add(new MySqlParameter("id", id_usuario));
                cmdveri.Parameters.Add(new MySqlParameter("clave", codigo));
                retorno = Convert.ToBoolean(cmdveri.ExecuteScalar());
                if (retorno == true)
                {
                   
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son érroneos porfavor verifique sus credenciales", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ActualizarNueva(int id_usuario, string clave)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET clave = '{0}' WHERE id_usuario = '{1}'", clave, id_usuario), Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La contraseña ha sido actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

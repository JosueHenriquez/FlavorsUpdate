using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class ControlRecuAdmin
    {
        public static bool VerificarAdmin(Constructor_Usuario cc)
        {
            bool retorno = false;
            try
            {
                int tipoUsuario = 2;
                string query1 = "SELECT * FROM tbusuario WHERE BINARY usuario = ?usercomp AND  BINARY clave = ?encripClave AND id_tipousuario = ?tipoUser";
                MySqlCommand cmdselect = new MySqlCommand(query1, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("usercomp", cc.usuario));
                cmdselect.Parameters.Add(new MySqlParameter("encripClave", cc.clave));
                cmdselect.Parameters.Add(new MySqlParameter("tipoUser", tipoUsuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("Su usuario Administrador ha sido verificado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Su usuario no ha sido encontrado, Verifique los datos ingresados", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos ha ocurrido un error con la conexion" + ex, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static bool VerificarUsuario(Constructor_Usuario cd)
        {
            bool retorno = false;
            try
            {
                string query1 = "SELECT * FROM tbusuario WHERE BINARY usuario = ?usercomp";
                MySqlCommand cmdselect = new MySqlCommand(query1, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("usercomp", cd.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("El usuario que desea recuperar ha sido verificado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario que desea recuperar no ha sido encontrado, Verifique los datos ingresados", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opss! Ha ocurrido un fallo en la conexion" + ex, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool ActualizarConstraseña(Constructor_Usuario act)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdact = new MySqlCommand(string.Format("UPDATE tbusuario SET clave = '{0}' WHERE usuario = '{1}'", act.clave, act.usuario), Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdact.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Contraseña actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo cambiar la Contraseña, Vuelva a intentarlo", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Ha ocurrido un error, revise su conexion a internet" + ex, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}

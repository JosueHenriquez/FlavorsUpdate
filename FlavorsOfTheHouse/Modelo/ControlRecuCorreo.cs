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
                MySqlDataReader reader = cmdselect.ExecuteReader();
                if (retorno == true)
                {
                    MySqlCommand cmdcorreo = new MySqlCommand(string.Format("SELECT MIN(id_empresa), empresa, correo FROM tbempresa"));
                    bool verificar = Convert.ToBoolean(cmdcorreo.ExecuteScalar());
                    MySqlDataReader readercorreo = cmdselect.ExecuteReader();
                    if (verificar == true)
                    {
                        while (readercorreo.Read())
                        {
                            ConstructorEmpresa_Controlador recu = new ConstructorEmpresa_Controlador();
                            recu.correo = readercorreo.GetString(2);
                            while (reader.Read())
                            {
                                Constructor_Usuario.id_usuario = reader.GetInt16(0);
                                MessageBox.Show("Los comparados son correctos ahora proceda a ingresar el código de verificación que se encuentra en su correo electrónico", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
    }
}

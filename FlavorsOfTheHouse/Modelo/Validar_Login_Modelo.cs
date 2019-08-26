using MySql.Data.MySqlClient;
using FlavorsOfTheHouse.Config;
using System;
using FlavorsOfTheHouse.Controlador;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class Validar_Login_Modelo
    {
        public static bool Validar_Acceso(Constructor_Login log)
        {
            bool retorno = false;
            try
            {
                //verificando existencia del usuario
                string query = "SELECT * FROM tbusuario WHERE usuario = ?param0";
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param0",Constructor_Login.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    #region
                    int activo = 1;
                    //Verificando estado del usuario
                    string query2 = "SELECT * FROM tbusuario tu WHERE tu.usuario = binary ?usuario AND tu.clave = binary ?clave AND tu.id_estado = ?estado";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2,Conexion_Config.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("usuario",Constructor_Login.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("clave", log.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("estado", activo));
                    //redefiniendo el valor de retorno
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    if (retorno == true)
                    {
                        //Reiniciamos intentos fallidos a cero
                        int intentos = 0;
                        MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET intentos = '"+intentos+"' WHERE usuario = '"+Constructor_Login.usuario+"'"),Conexion_Config.ObtenerConexion());
                        int verificacion = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                        if (verificacion >= 1)
                        {
                            string query3 = "SELECT * FROM tbusuario WHERE usuario = ?param1";
                            MySqlCommand cmdselect3 = new MySqlCommand(query3, Conexion_Config.ObtenerConexion());
                            cmdselect3.Parameters.Add(new MySqlParameter("param1", Constructor_Login.usuario));
                            MySqlDataReader reader = cmdselect3.ExecuteReader();
                            while (reader.Read())
                            {
                                Constructor_Login_Datos.empresa = reader.GetInt16(9);
                                Constructor_Login_Datos.nivel = reader.GetInt16(10);
                                Constructor_Login_Datos.nombre = reader.GetString(3) + " " + reader.GetString(4);
                                Constructor_Login.id_usuario = reader.GetInt16(0);
                            }
                            MessageBox.Show("Bienvenido usuario: " + Constructor_Login.usuario, "Acceso concedido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            retorno = false;
                            MessageBox.Show("Ocurrio un error en la obtención de datos del usuario.", "Error de proceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }                       
                    }
                    else
                    {
                        MySqlDataReader reader = cmdselect.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = reader.GetInt16(8) + 1;
                            if (intentos > 5)
                            {
                                //Bloquear usuario
                                int bloqueo = 3;
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET id_estado = '" + bloqueo + "' WHERE usuario = '" + Constructor_Login.usuario + "'"), Conexion_Config.ObtenerConexion());
                                int verificacion = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("Usuario bloqueado.\n\nContacte con un administrador con mayores permisos para recuperar su usuario.", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                //Sumar uno a la cuenta de accesos fallidos                        
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET intentos = '" + intentos + "' WHERE usuario = '" + Constructor_Login.usuario + "'"), Conexion_Config.ObtenerConexion());
                                int verificacion = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("La contraseña proporcionada es incorrecta.", "Clave incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    retorno = false;
                                }
                            }
                        }
                                                
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe en la base de datos, verifica tus credenciales","Dato erroneo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, ha ocurrido un error al momento de validar el usuario, verifique su conexión internet, si el problema persiste contacte con un administrador " + ex,"Error crítico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
    }
}
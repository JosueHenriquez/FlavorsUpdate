using MySql.Data.MySqlClient;
using System;
using FlavorsOfTheHouse.Config;
using FlavorsOfTheHouse.Controlador;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Modelo
{
    class PrimerUso_Modelo
    {
        public static bool Existencia_Empresa()
        {
            bool retorno = false;
            string query = "SELECT * FROM tbempresa";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido verificar la existencia de una empresa registrada debido a un error inesperado, consulte con el administrador" + ex.Message,"Error de inicio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
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
                MySqlCommand cmdselect = new MySqlCommand(query,Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("empresa",constemp.nombre_empresa));
                cmdselect.Parameters.Add(new MySqlParameter("nit",constemp.nit));
                retorno = Convert.ToInt16(cmdselect.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("La empresa o el numero de identificación tributario que ha proporcionado ya están registrados en la base de datos, verifique que los datos sean los correctos","Duplicidad de información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempresa (empresa,correo, nit, representante_legal, id_tipo_empresa, id_estado, direccion, logoempresa) VALUES ('" + constemp.nombre_empresa + "','" + constemp.correo + "','" + constemp.nit + "','" + constemp.representante + "','" + constemp.tipo_empresa + "','" + constemp.estado + "','" + constemp.direccion + "','" + constemp.imagen + "')"), Conexion_Config.ObtenerConexion());
                    retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Proceso completado, continuemos con la creación del usuario de mayor nivel","Proceso Completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                return retorno;                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la transmisión de datos, verifique su conexión a Internet y si el problema persite consulte con el administrador " + ex.Message, "Error de registro en empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int CambiarClaveUsuarioPrimerUso(string clave, string usuario)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuario SET clave = '"+clave+"' WHERE usuario = '"+usuario+"'"),Conexion_Config.ObtenerConexion());
                retorno = Convert.ToInt16(cmdupdate.ExecuteNonQuery());
                if (retorno < 0)
                {
                    MessageBox.Show("La clave no pudo ser reestablecida.","Error al actualizar clave",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión, consulte con el administrador.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}

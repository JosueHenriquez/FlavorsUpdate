using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FlavorsOfTheHouse.Config
{
    class Conexion_Config
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection connect;
            string server = "10.20.1.67";
            string database = "dbflavors";
            string uid = "eMaster";
            string pwd = "123456";
            string port = "3306";
            try
            {
                connect = new MySqlConnection("server =" + server+
                                              "; Port = " + port +
                                              "; database = " + database+
                                              "; uid = " + uid+
                                              "; pwd = " + pwd);
                connect.Open();
                //MessageBox.Show("Conectado");
                return connect;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al momento de establecer la conexión al servidor, verifique su conexión a internet y si el problema persiste consulte con el administrador");
                return connect = new MySqlConnection();
            }
        }
    }
}

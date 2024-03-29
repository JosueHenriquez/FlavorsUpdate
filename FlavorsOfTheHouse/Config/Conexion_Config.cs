﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FlavorsOfTheHouse.Config
{
    class Conexion_Config
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection connect;
            string server = "127.0.0.1";
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

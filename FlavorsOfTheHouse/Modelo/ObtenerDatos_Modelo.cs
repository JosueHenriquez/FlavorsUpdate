﻿using FlavorsOfTheHouse.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlavorsOfTheHouse.Modelo
{
    class ObtenerDatos_Modelo
    {
        public static DataTable ObtenerTipo_Usuario()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbtipo_usuario";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los tipos de usuarios, consulte con el administrador.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerTipo_Usuario_SinRoot()
        {
            DataTable data = new DataTable();
            int tipoUsuario = 2;
            string query = "SELECT * FROM tbtipo_usuario WHERE id_tipo_usuario >= ?param1";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1",tipoUsuario));
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los tipos de usuarios, consulte con el administrador.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable Obtener_Estados()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbestado";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los tipos de estados, consulte con el administrador.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static bool ObtenerUsuario()
        {
            bool retorno = false;
            string query = "SELECT * FROM tbusuario";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la verificación de usuarios, consulte con el administrador.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerPreguntas()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbpregunta";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico al cargar las preguntas de seguridad, verifique su conexión a internet o consulte con el administrador.", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerTipoEmpresa()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM tbtipo_empresa";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion_Config.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico al cargar los tipos de empresa, verifique su conexión a internet o consulte con el administrador.", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                Conexion_Config.ObtenerConexion().Close();
            }
        }
    }
}

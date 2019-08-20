using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_Recuperacion_Clave
    {
        public string clave { get; set; }
        public string usuario_recuperar { get; set; }
        public int id_usuario { get; set; }
        public Constructor_Recuperacion_Clave() { }
    }

    class Constructor_Recuperacion_xCorreo :  Constructor_Recuperacion_Clave
    {
        public string correo { get; set; }
        public int codigo_verificacion { get; set; }
        public Constructor_Recuperacion_xCorreo() { }
    }

    class Constructor_Recuperacion_xPreguntas : Constructor_Recuperacion_Clave
    {
        public string respuesta { get; set; }
        public int pregunta { get; set; }
        Constructor_Recuperacion_xPreguntas() { }
    }

    class Constructor_Recuperacion_xAdminisitrador : Constructor_Recuperacion_Clave
    {
        public string usuario_admin { get; set; }
        public string clave_admin { get; set; }
        public Constructor_Recuperacion_xAdminisitrador() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    public class Constructor_Login : Constructor_Login_Datos
    {
        public static string usuario { get; set; }
        public string clave { get; set; }
        public Constructor_Login() { }
    }

    public class Constructor_Login_Datos
    {
        public static string nombre { get; set; }
        public static int nivel { get; set; }
        public static int empresa { get; set; }
        public Constructor_Login_Datos() { }
    }
}

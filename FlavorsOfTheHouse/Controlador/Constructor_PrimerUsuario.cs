using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_PrimerUsuario
    {
        public string id_usuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }
        public string nacimiento { get; set; }
        public int intentos { get; set; }
        public int primer_uso { get; set; }
        public int id_empresa { get; set; }
        public int id_estado { get; set; }
        public int id_tipo_usuario { get; set; }
        public string imagen { get; set; }
        public string respuesta1 { get; set; }
        public string respuesta2 { get; set; }
        public string respuesta3 { get; set; }
        public string respuesta4 { get; set; }
        public Constructor_PrimerUsuario() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class ConstructorEmpresa_Controlador
    {
        public string id_empresa { get; set; }
        public string nombre_empresa { get; set; }
        public string nit { get; set; }
        public string representante { get; set; }
        public string direccion { get; set; }
        public string imagen { get; set; }
        public int tipo_empresa { get; set; }
        public int estado { get; set; }
        public ConstructorEmpresa_Controlador() { }
    }
}

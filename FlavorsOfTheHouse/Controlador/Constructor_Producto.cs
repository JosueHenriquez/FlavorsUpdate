using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_Producto
    {
        public int id_producto { get; set; }
        public string producto { get; set; }
        public int codigo_producto { get; set; }
        public double precio { get; set; }
        public int id_usuario { get; set; }
        public string caducidad { get; set; }
        public string vencimiento { get; set; }
        public int id_categoria { get; set; }
        public int id_empresa { get; set; }
        public int id_estado { get; set; }
        public Constructor_Producto() { }
    }
}

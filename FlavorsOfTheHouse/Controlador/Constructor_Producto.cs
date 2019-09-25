using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_Producto
    {
        public static int id_producto { get; set; }
        public string producto { get; set; }
        public string codigo_producto { get; set; }
        public static string usuario { get; set; }
        public int id_tipo { get; set; }
        public int id_empresa { get; set; }
        public Constructor_Producto() { }
    }

    class Constructor_Detalle_Producto : Constructor_Producto
    {
        public int id_detalle_producto { get; set; }
        public string fecha_ingreso { get; set; }
        public double precio { get; set; }
        public string empacado { get; set; }
        public string vencimiento { get; set; }
        public int cantidad { get; set; }
        public int id_estado { get; set; }
        public int id_usuario { get; set; }
    }
}

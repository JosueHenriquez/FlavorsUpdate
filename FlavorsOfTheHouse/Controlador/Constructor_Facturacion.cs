using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_Facturacion
    {
        public int id_factura { get; set; }
        public int id_usuario { get; set; }
        public int id_estado { get; set; }
        public string fecha_factura { get; set; }
        public static double total_pago { get; set; }
        public Constructor_Facturacion() { }
    }

    class Constructor_Detalle_Factura : Constructor_Facturacion
    {
        public int id_detalle_factura { get; set; }
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int cantidad { get; set; }
        public double total_parcial { get; set; }
        public Constructor_Detalle_Factura() { }
    }

    class DatosProductos
    {
        public static int idpro { get; set; }
        public static string nombreproducto { get; set; }
        public static int cantidad { get; set; }
        public static double precio { get; set; }
        public DatosProductos() { }
    }
}

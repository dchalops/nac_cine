using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdMetodoPago { get; set; }
        public string AutorizacionSri { get; set; }
        public string EstadoFactura { get; set; }
        public bool EstadoLogico { get; set; }
    }
}

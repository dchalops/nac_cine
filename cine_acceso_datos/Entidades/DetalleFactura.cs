using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdEntrada { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool EstadoLogico { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdPelicula { get; set; }
        public int CantidadSolicitada { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEstimadaRecepcion { get; set; }
        public string EstadoPedido { get; set; }
        public string EstadoLogico { get; set; }
    }
}

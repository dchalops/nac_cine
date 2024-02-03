using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class stock_peliculas
    {
        public int id_stock_peliculas { get; set; }
<<<<<<< Updated upstream
        public int id_peliculas {  set; get; }
        public int cantidad { get; set; }
=======
        public string id_peliculas {  set; get; }
        public string cantidad { get; set; }

>>>>>>> Stashed changes
        public DateTime fecha_ultimo_pedido { get; set; }
        public string estado_logico { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class inventario_asientos
    {

        public int id_inventario { get; set; }
        public int id_sala { get; set; }
        public int id_programacion { get; set; }
        public int id_asiento { get; set; }
        public string estado_asiento { get; set; }
        public DateTime fecha { get; set; }
        public int estado_logico { get; set; }

    }
}

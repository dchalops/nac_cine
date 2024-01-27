using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class entradas
    {
        public int id_entrada { get; set; }
        public int id_cliente { get; set; }
        public int id_programacion { get; set; }
        public string asiento { get; set; }
        public string codigo_compra { get; set; }
        public string estado_logico { get; set; }
    }
}

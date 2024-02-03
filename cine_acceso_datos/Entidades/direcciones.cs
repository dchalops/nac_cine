using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{

    public class direcciones
    {
        public string id_direccion { get; set; }
        public int id_cliente { get; set; }
        public string calle { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string codigo_postal { get; set; }
        public string pais { get; set; }
        public int estado_logico { get; set; }


    }
}

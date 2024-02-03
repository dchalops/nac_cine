using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class metodo_de_pago
    {
        public int id_metodo_pago { get; set; }
        public string tipo { get; set; }
        public string detalles { get; set; }

        public DateTime fecha_expiracion { get; set; }
        public string estado_logico { get; set; }

    }
}

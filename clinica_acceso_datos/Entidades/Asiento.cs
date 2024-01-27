using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidados
{
    internal class Asiento
    {
        public int idAsiento { get; set; }
        public int idSala { get; set; }
        public string numeroAsiento { get; set; }
        public bool estadoLogico { get; set; }

    }
}

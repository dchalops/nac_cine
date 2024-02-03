using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Sala
    {
        public int idSala { get; set; }
        public string nombreSala { get; set; }
        public int capacidad { get; set; }
        public bool estadoLogico { get; set; }
    }
}

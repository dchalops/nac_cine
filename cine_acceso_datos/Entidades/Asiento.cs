using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Asiento
    {
        public int IdAsiento { get; set; }
        public int IdSala { get; set; }
        public int NumeroAsiento { get; set; }
        public bool EstadoLogico { get; set; }
    }
}

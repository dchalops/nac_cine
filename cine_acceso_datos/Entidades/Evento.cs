using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Evento
    {
        public int idEvento { get; set; }
        public string titulo { get; set; }
        public DateTime fechaEvento { get; set; }
        public string descripcion { get; set; }
        public string trailerUrl { get; set; }
        public int idPelicula { get; set; }
        public string estadoLogico { get; set; }
    }
}

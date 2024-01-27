using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class peliculas
    {
        public int id_pelicula {  get; set; }
        public string titulo {  get; set; }
        public int duracion { get; set; }
        public string sinopsis { get; set; }
        public string trailer_url { get; set; }
        public string estado_logico { get; set; }    
        
    }
}

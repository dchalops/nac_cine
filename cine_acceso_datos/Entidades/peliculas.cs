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
<<<<<<< Updated upstream
        public int duracion { get; set; }
=======
        public string duracion { get; set; }

>>>>>>> Stashed changes
        public string sinopsis { get; set; }
        public string trailer_url { get; set; }
        public bool estado_logico { get; set; }    
        
    }
}

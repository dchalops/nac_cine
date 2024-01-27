using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class programacion
    {
        public int id_programacion { get; set; }
        public int id_sala { get; set; }
        public int id_pelicula { get; set; }
        public DateTime fecha_hora_proyeccion { get; set; }
        public string estado_logico { get; set; }
    }
}

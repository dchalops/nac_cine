using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_logica_negocio
{
    public class peliculasLogica
    {
        private peliculasDAO peliculasDAO = new peliculasDAO();

        public bool Insertarpeliculas(peliculas nuevapelicula)
        {
            peliculasDAO.insertarpeliculas(nuevapelicula);
            return true;
        }

        public DataTable listarpelicula()
        {
            return peliculasDAO.ListarPeliculas();
        }
    }
}

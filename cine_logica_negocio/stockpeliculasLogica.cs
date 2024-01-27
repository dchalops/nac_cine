using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocio
{
    public class stockpeliculasLogica
    {
        private stock_peliculasDAO stockpeliculasDAO = new stock_peliculasDAO();
        private stock_peliculas stock_Peliculas = new stock_peliculas();
        private bool insertarstockpeliculas(stock_peliculas nuevostockpliculas)
        {
            stockpeliculasDAO.insertarstockpeliculas(nuevostockpliculas); 
            return true;
        }

        public DataTable Listarstockpeliculas()
        {
            return stockpeliculasDAO.Listarstockpeliculas();
        }
    }
}

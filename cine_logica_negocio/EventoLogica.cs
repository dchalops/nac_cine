using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using CineAccesoDatos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineLogicaNegocio
{
    public class EventoLogica
    {
        private EventoDAO EventoDAO = new EventoDAO();

        public Boolean InsertarEvento(Evento nuevoEvento)
        {
            EventoDAO.InsertarEvento(nuevoEvento);
            return true;
        }

        public DataTable ListarEventos()
        {
            return EventoDAO.ListarEventos();
        }
    }
}

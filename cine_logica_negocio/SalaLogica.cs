using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineLogicaNegocio
{
    public class SalaLogica
    {
        private SalaDAO SalaDao = new SalaDAO();

        public Boolean InsertarSala(Sala nuevoSala)
        {
            SalaDao.InsertarSala(nuevoSala);
            return true;
        }

        public DataTable ListarSalas()
        {
            return SalaDao.ListarSalas();
        }

    }
}

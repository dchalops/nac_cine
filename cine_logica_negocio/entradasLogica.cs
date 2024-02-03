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
    public class entradasLogica
    {
        private entradasDAO EntradasDao = new entradasDAO();
        public Boolean InsertarEntradas(entradas nuevaentradas)
        {
            EntradasDao.InsertarEntradas(nuevaentradas);
            DataTable resultado = EntradasDao.BuscarEntradasC(nuevaentradas.codigo_compra);
            return Boolean.Parse(resultado.Rows[0]["id_entradas"].ToString());
        }
        public DataTable ListarEntradas()
        {
            return EntradasDao.ListarEntradas();
        }
    }
}

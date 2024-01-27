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
        public int InsertarEntradas(entradas entradas)
        {
            EntradasDao.InsertarEntradas(entradas);
            DataTable resultado = EntradasDao.BuscarEntradasC(entradas.codigo_compra);
            return int.Parse(resultado.Rows[0]["id_entradas"].ToString());
        }
        public DataTable ListarEntradas()
        {
            return EntradasDao.ListarEntradas();
        }
    }
}

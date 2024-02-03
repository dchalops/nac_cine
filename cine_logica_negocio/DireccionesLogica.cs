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
    public class DireccionesLogica
    {
        private DireccionesDAO direccionesDAO = new DireccionesDAO();
        

        public int InsertarDirecciones (direcciones direcciones)
        {
            direccionesDAO.InsertarDirecciones(direcciones);
            DataTable resultado = direccionesDAO.BuscarDireccion(direcciones.calle);
            return int.Parse(resultado.Rows[0]["id_direccion"].ToString());
        }
        public DataTable ListarDireccion()
        {
            return direccionesDAO.ListarDireccion();
        }
    }
}

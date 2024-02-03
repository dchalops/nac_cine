using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Data;

namespace cine_logica_negocio
{
    public class AsientoLogica
    {
        public AsientoDAO asientoDAO = new AsientoDAO();

        public bool InsertarAsiento(Asiento nuevoAsiento)
        {
            try
            {

                asientoDAO.InsertarAsiento(nuevoAsiento);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public DataTable ListarAsientos()
        {
            return asientoDAO.ListarAsientos();
        }
    }
}

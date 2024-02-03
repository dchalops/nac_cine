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
    public class ClientesLogica
    {
        private ClientesDAO clientesDao = new ClientesDAO();
        public Boolean InsertarClientes(Clientes nuevocliente)
        {
            clientesDao.InsertarClientes(nuevocliente);
            return true;
        }
        public DataTable ListarCliente()
        {
            return clientesDao.ListarCliente();
        }
    }
}

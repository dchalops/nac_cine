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
        public int InsertarClientes(Clientes cliente)
        {
            clientesDao.InsertarClientes(cliente);
            DataTable resultado = clientesDao.BuscarClienteCI(cliente.doc_identidad);
            return int.Parse(resultado.Rows[0]["id_cliente"].ToString());
        }
        public DataTable ListarCliente()
        {
            return clientesDao.ListarCliente();
        }
    }
}

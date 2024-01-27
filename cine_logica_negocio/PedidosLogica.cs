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
    public class PedidosLogica
    {
        private PedidoDAO pedidoDAO = new PedidoDAO();

        public DataTable ConsultarPedidos()
        {
            return pedidoDAO.ConsultarPedidos();
        }
        public void InsertarPedido(Pedido pedido)
        {
            pedidoDAO.InsertarPedido(pedido);
        }

        public void ActualizarPedido(Pedido pedido)
        {
            pedidoDAO.ActualizarPedido(pedido);
        }

        public void EliminarPedido(int idPedido)
        {
            pedidoDAO.EliminarPedido(idPedido);
        }

    }
}

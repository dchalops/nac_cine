using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class PedidoDAO
    {
        private ConexionDB conexionDB = new ConexionDB();

        public void InsertarPedido(Pedido pedido)
        {
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spInsertarPedido", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPelicula", pedido.IdPelicula);
                    cmd.Parameters.AddWithValue("@CantidadSolicitada", pedido.CantidadSolicitada);
                    cmd.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);
                    cmd.Parameters.AddWithValue("@FechaEstimadaRecepcion", pedido.FechaEstimadaRecepcion);
                    cmd.Parameters.AddWithValue("@EstadoPedido", pedido.EstadoPedido);
                    cmd.Parameters.AddWithValue("@EstadoLogico", pedido.EstadoLogico);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPedido(Pedido pedido)
        {
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spActualizarPedido", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPedido(int idPedido)
        {
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spEliminarPedido", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarPedidos()
        {
            DataTable pedidos = new DataTable();
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spConsultarPedidos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(pedidos);
                    }
                }
            }
            return pedidos;
        }

    }
}

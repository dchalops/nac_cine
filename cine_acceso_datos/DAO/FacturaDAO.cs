using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class FacturaDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSQL;
        DataTable tabla = new DataTable();

        public DataTable MostrarFactura()
        {
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "spListarFacturas";
                ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                ejecutarSQL = ejecutarConsulta.ExecuteReader();
                tabla.Load(ejecutarSQL);
                conexionDB.CerrarConexion();
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar factura " + ex.ToString());
            }
            finally
            {
                conexionDB.CerrarConexion();
                if (ejecutarSQL != null)
                {
                    ejecutarSQL.Close();
                }
            }
            
        }

        public void InsertarFacturaConDetalles(Entidades.Factura factura, List<Entidades.DetalleFactura> detalles)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        string comandoFactura = "INSERT INTO facturas (id_cliente, fecha, total, id_metodo_pago, autorizacion_sri, estado_factura, estado_logico) VALUES (@idCliente, @fecha, @total, @idMetodoPago, @autorizacionSri, @estadoFactura, @estadoLogico); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand ejecutarConsulta = new SqlCommand(comandoFactura, conexion, transaccion))
                        {
                            ejecutarConsulta.Parameters.AddWithValue("@idCliente", factura.IdCliente);
                            ejecutarConsulta.Parameters.AddWithValue("@fecha", factura.Fecha);
                            ejecutarConsulta.Parameters.AddWithValue("@total", factura.Total);
                            ejecutarConsulta.Parameters.AddWithValue("@idMetodoPago", factura.IdMetodoPago);
                            ejecutarConsulta.Parameters.AddWithValue("@autorizacionSri", factura.AutorizacionSri);
                            ejecutarConsulta.Parameters.AddWithValue("@estadoFactura", factura.EstadoFactura);
                            ejecutarConsulta.Parameters.AddWithValue("@estadoLogico", factura.EstadoLogico);

                            int idFacturaNuevo = Convert.ToInt32(ejecutarConsulta.ExecuteScalar());

                            foreach (var detalle in detalles)
                            {
                                string comandoDetalle = "INSERT INTO detalle_factura (id_factura, id_entrada, precio, cantidad, estado_logico) VALUES (@IdFacturaNuevo, @idEntrada, @precio, @cantidad, @estadoLogicoDetalle);";
                                using (SqlCommand ejecutarDetalle = new SqlCommand(comandoDetalle, conexion, transaccion))
                                {
                                    ejecutarDetalle.Parameters.AddWithValue("@IdFacturaNuevo", idFacturaNuevo);
                                    ejecutarDetalle.Parameters.AddWithValue("@idEntrada", detalle.IdEntrada);
                                    ejecutarDetalle.Parameters.AddWithValue("@precio", detalle.Precio);
                                    ejecutarDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                    ejecutarDetalle.Parameters.AddWithValue("@estadoLogicoDetalle", detalle.EstadoLogico);

                                    ejecutarDetalle.ExecuteNonQuery();
                                }
                            }

                            transaccion.Commit();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar factura y detalles: " + ex.Message);
            }
        }



        public void EditarFacturaConDetalles(int idFactura, List<Entidades.DetalleFactura> detallesEditados)
        {
            try
            {
                using (SqlConnection conexion = conexionDB.AbrirConexion())
                {
                    using (SqlCommand ejecutarConsulta = new SqlCommand())
                    {
                        ejecutarConsulta.Connection = conexion;

                        using (SqlTransaction transaccion = conexion.BeginTransaction())
                        {
                            ejecutarConsulta.Transaction = transaccion;

                            foreach (var detalle in detallesEditados)
                            {
                                ejecutarConsulta.CommandText = "spEditarDetalleFactura";
                                ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                                ejecutarConsulta.Parameters.Clear();
                                ejecutarConsulta.Parameters.AddWithValue("@IdDetalle", detalle.IdDetalle);
                                ejecutarConsulta.Parameters.AddWithValue("@IdFactura", idFactura);
                                
                                ejecutarConsulta.Parameters.AddWithValue("@Precio", detalle.Precio);
                                ejecutarConsulta.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                                
                                ejecutarConsulta.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar detalles de la factura: " + ex.Message);
            }
        }

        public void EliminarFacturaConDetalle(Entidades.Factura factura)
        {
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();

                using (SqlTransaction transaccion = ejecutarConsulta.Connection.BeginTransaction())
                {
                    ejecutarConsulta.Transaction = transaccion;
                    
                    ejecutarConsulta.CommandText = "spActualizarEstadoFactura";
                    ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                    ejecutarConsulta.Parameters.AddWithValue("@IdFactura", factura.IdFactura);
                    ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", 1);
                    ejecutarConsulta.ExecuteNonQuery();
                    ejecutarConsulta.Parameters.Clear();

                    ejecutarConsulta.CommandText = "spActualizarEstadoDetalleFactura";
                    ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                    ejecutarConsulta.Parameters.AddWithValue("@IdFactura", factura.IdFactura);
                    ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", 1);
                    ejecutarConsulta.ExecuteNonQuery();
                    ejecutarConsulta.Parameters.Clear();

                    transaccion.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar factura y sus detalles: " + ex.Message);
            }
            finally
            {
                if (ejecutarConsulta.Connection != null && ejecutarConsulta.Connection.State == ConnectionState.Open)
                {
                    conexionDB.CerrarConexion();
                }
            }
        }
    }
}

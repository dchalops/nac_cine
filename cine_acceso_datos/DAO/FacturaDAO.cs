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
                    using (SqlCommand ejecutarConsulta = new SqlCommand())
                    {
                        ejecutarConsulta.Connection = conexion;

                        using (SqlTransaction transaccion = conexion.BeginTransaction())
                        {
                            ejecutarConsulta.Transaction = transaccion;

                            ejecutarConsulta.CommandText = "spInsertarFactura";
                            ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                            ejecutarConsulta.Parameters.AddWithValue("@IdCliente", factura.IdCliente);
                            ejecutarConsulta.Parameters.AddWithValue("@Fecha", factura.Fecha);
                            ejecutarConsulta.Parameters.AddWithValue("@Total", factura.Total);
                            ejecutarConsulta.Parameters.AddWithValue("@IdMetodoPago", factura.IdMetodoPago);
                            ejecutarConsulta.Parameters.AddWithValue("@AutorizacionSri", factura.AutorizacionSri);
                            ejecutarConsulta.Parameters.AddWithValue("@EstadoFactura", factura.EstadoFactura);
                            ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", factura.EstadoLogico);
                            
                            ejecutarConsulta.ExecuteNonQuery();

                            int idFactura = Convert.ToInt32(ejecutarConsulta.Parameters["@IdFactura"].Value);
                            ejecutarConsulta.Parameters.Clear();

                            foreach (var detalle in detalles)
                            {
                                ejecutarConsulta.CommandText = "spInsertarDetalleFactura";
                                ejecutarConsulta.CommandType = CommandType.StoredProcedure;
                                ejecutarConsulta.Parameters.Clear();
                                ejecutarConsulta.Parameters.AddWithValue("@IdFactura", idFactura);
                                ejecutarConsulta.Parameters.AddWithValue("@IdEntrada", detalle.IdEntrada);
                                ejecutarConsulta.Parameters.AddWithValue("@Precio", detalle.Precio);
                                ejecutarConsulta.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                                ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", detalle.EstadoLogico);
                                
                                ejecutarConsulta.ExecuteNonQuery();
                            }

                            transaccion.Commit();
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

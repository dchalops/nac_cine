using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cine_acceso_datos;

namespace cine_acceso_datos.DAO
{
    public class Inventario_AsientosDAO
    {

        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        public void InsertarInventarioAsientos(inventario_asientos nuevoInventarioAsientos)
        {
            ejecutarSql.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERTinsert into inventario_asientos (id_sala, id_programacion, id_asiento, estado_asiento, fecha, estado_logico) VALUES (@id_sala, @id_programacion, @id_asiento, @estado_asiento, @fecha, @estado_logico)";
                ejecutarSql.Parameters.AddWithValue("@id_sala", nuevoInventarioAsientos.id_sala);
                ejecutarSql.Parameters.AddWithValue("@id_programacion", nuevoInventarioAsientos.id_programacion);
                ejecutarSql.Parameters.AddWithValue("@id_asiento", nuevoInventarioAsientos.id_asiento);
                ejecutarSql.Parameters.AddWithValue("@estado_asiento", nuevoInventarioAsientos.estado_asiento);
                ejecutarSql.Parameters.AddWithValue("@fecha", nuevoInventarioAsientos.fecha);
                ejecutarSql.Parameters.AddWithValue("@estado_logico", nuevoInventarioAsientos.estado_logico);
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar inventario asientos" + ex.Message);
            }
        }
        public DataTable ListarInventarioAsientos()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from inventario_asientos";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar inventario asientos" + ex.Message);
            }
        }
        public DataTable BuscarInventarioAsientos(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from where inventario_asientos = '" + nombre + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar inventario asientos" + ex.Message);
            }
        }
    }
}

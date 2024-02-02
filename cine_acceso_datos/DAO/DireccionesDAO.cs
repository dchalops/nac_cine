using cine_acceso_datos;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class DireccionesDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        public void InsertarDirecciones(direcciones nuevoDireccion)
        {
            ejecutarSql.Connection = conexionDB.AbrirConexion();
            try
            {
                
                ejecutarSql.CommandText = "INSERT INTO direcciones (id_cliente, calle,ciudad,estado,codigo_postal,pais,estado_logico) VALUES (@id_cliente,@calle,@ciudad,@estado,@codigo_postal,@pais,@estado_logico)";
                ejecutarSql.Parameters.AddWithValue("@id_cliente", nuevoDireccion.id_cliente);
                ejecutarSql.Parameters.AddWithValue("@calle", nuevoDireccion.calle);
                ejecutarSql.Parameters.AddWithValue("@ciudad", nuevoDireccion.ciudad);
                ejecutarSql.Parameters.AddWithValue("@estado", nuevoDireccion.estado);
                ejecutarSql.Parameters.AddWithValue("@codigo_postal", nuevoDireccion.codigo_postal);
                ejecutarSql.Parameters.AddWithValue("@pais", nuevoDireccion.pais);
                ejecutarSql.Parameters.AddWithValue("@estado_logico", nuevoDireccion.estado_logico);
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se pudo insertar direcciones" + ex.ToString());
            }
        }
        public DataTable ListarDireccion()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from direcciones";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception ("Error al listar direcciones" + ex.Message);
            }
        }
        public DataTable BuscarDireccion(string calle)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from direcciones where calle = '" + calle + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar direcciones" + ex.Message);
            }
        }
    }
}

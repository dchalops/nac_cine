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
                ejecutarSql.CommandText = "insert into direcciones (id_cliente, calle, ciudad,estado, codigo_postal, pais, estado_logico)" + "values('" + nuevoDireccion.id_cliente + "','" + nuevoDireccion.calle + "','" + nuevoDireccion.ciudad + "','" + nuevoDireccion.estado + "','" + nuevoDireccion.codigo_postal + "','" + nuevoDireccion.pais + "','" + nuevoDireccion.estado_logico + ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch(Exception ex)
            {
                throw new Exception("Error al insertar direcciones" + ex.Message);
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
        public DataTable BuscarDireccion(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from direcciones where nombre = '" + nombre + "'";
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

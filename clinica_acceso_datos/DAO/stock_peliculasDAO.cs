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
    public class stock_peliculasDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        private object dt;

        //crud

        public void insertarstockpeliculas(stock_peliculas nuevostockpliculas)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarConsulta.CommandText = "insert into stock_peliculas (id_stock_pelicula,id_peliculas,cantidad,fecha_ultimo_pedido,estado_logico)" +
                    "values(" + nuevostockpliculas.id_peliculas + "," + nuevostockpliculas.cantidad + ",'" + nuevostockpliculas.fecha_ultimo_pedido + "','" + nuevostockpliculas.estado_logico + "')";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede insertar stock de peliculas" + ex.ToString());
            }
        }


        public DataTable Listarstockpeliculas()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from stock_peliculas";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede mostrar información" + ex.ToString());
            }
        }


        public DataTable Buscarstockpeliculas(int id_peliculas)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from where id_peliculas= '"+id_peliculas+ "'";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                dt.Load(ejecutarSql );
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede buscar información" + ex.ToString());
            }
        }

    }
}

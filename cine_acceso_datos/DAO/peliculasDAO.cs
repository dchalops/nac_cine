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
    public class peliculasDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta= new SqlCommand();
        SqlDataReader ejecutarSql;
        //crud

        public void insertarpeliculas(peliculas nuevapelicula)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarConsulta.CommandText = "insert into peliculas (id_pelicula,titulo,duracion,sinopsis,trailer_url,estado_logico)" +
                    "values('" + nuevapelicula.titulo+"','" + nuevapelicula.duracion+"','" + nuevapelicula.sinopsis+"','" + nuevapelicula.trailer_url+ "','" + nuevapelicula.estado_logico+"')";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede insertar pelicula" + ex.ToString());
            }
        }

        public DataTable ListarPeliculas()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from peliculas";
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

        public DataTable Buscarpeliculas(string titulo)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from where titulo= '" + titulo + "'";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede buscar información" + ex.ToString());
            }
        }

        public List<peliculas> findAll()
        {
            List<peliculas> lista = new List<peliculas>();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from peliculas";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                while (ejecutarSql.Read())
                {
                    lista.Add(new peliculas
                    {
                        id_pelicula = ejecutarSql.GetInt32(0),
                        titulo = ejecutarSql.GetString(1),
                        duracion = ejecutarSql.GetInt32(2),
                        sinopsis = ejecutarSql.GetString(3),
                        trailer_url = ejecutarSql.GetString(4),
                        estado_logico = ejecutarSql.GetBoolean(5)
                    });
                }
                conexionDB.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede listar información" + ex.ToString());
            }
        }   
    }
}

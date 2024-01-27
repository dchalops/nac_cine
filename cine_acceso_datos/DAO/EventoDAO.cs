using cine_acceso_datos;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineAccesoDatos.DAO
{
    public class EventoDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();


        public void InsertarEvento(Evento nuevoEvento)
        {
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand ejecutarConsulta = new SqlCommand())
                {
                    ejecutarConsulta.Connection = conexion;
                    ejecutarConsulta.CommandText = "INSERT INTO Eventos (titulo, fechaEvento, descripcion, trailerUrl, idPelicula, estadoLogico) " +
                                                   "VALUES(@Titulo, @FechaEvento, @Descripcion, @TrailerUrl, @IdPelicula, @EstadoLogico)";

                    ejecutarConsulta.Parameters.AddWithValue("@Titulo", nuevoEvento.titulo);
                    ejecutarConsulta.Parameters.AddWithValue("@FechaEvento", nuevoEvento.fechaEvento);
                    ejecutarConsulta.Parameters.AddWithValue("@Descripcion", nuevoEvento.descripcion);
                    ejecutarConsulta.Parameters.AddWithValue("@TrailerUrl", nuevoEvento.trailerUrl);
                    ejecutarConsulta.Parameters.AddWithValue("@IdPelicula", nuevoEvento.idPelicula);
                    ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", nuevoEvento.estadoLogico);

                    try
                    {
                        ejecutarConsulta.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: no se pudo insertar Evento", ex);
                    }
                }
            }
            
        }

        public DataTable ListarEventos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("ListarEventos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        tabla.Load(leer);
                    }
                }
            }
            
            return tabla;
        }

    }
}

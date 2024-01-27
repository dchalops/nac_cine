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
    public class SalaDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();


        public void InsertarSala(Sala nuevaSala)
        {
            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand ejecutarConsulta = new SqlCommand())
                {
                    ejecutarConsulta.Connection = conexion;
                    ejecutarConsulta.CommandText = "INSERT INTO Sala (nombreSala, capacidad, estadoLogico) " +
                                                   "VALUES(@NombreSala, @Capacidad, @EstadoLogico)";

                    ejecutarConsulta.Parameters.AddWithValue("@NombreSala", nuevaSala.nombreSala);
                    ejecutarConsulta.Parameters.AddWithValue("@Capacidad", nuevaSala.capacidad);
                    ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", nuevaSala.estadoLogico);

                    try
                    {
                        ejecutarConsulta.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: no se pudo insertar Sala", ex);
                    }
                }
            }
        }

        public DataTable ListarSalas()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("ListarSalas", conexion))
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

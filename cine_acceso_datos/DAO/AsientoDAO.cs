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
    public class AsientoDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();


        //crud

        public void InsertarAsiento(Asiento nuevoAsiento)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();

            try
            {
                ejecutarConsulta.CommandText = "INSERT INTO asientos (id_sala, numero_asiento, estado_logico) VALUES (@IdSala, @NumeroAsiento, @EstadoLogico)";
                ejecutarConsulta.Parameters.AddWithValue("@IdSala", nuevoAsiento.IdSala);
                ejecutarConsulta.Parameters.AddWithValue("@NumeroAsiento", nuevoAsiento.NumeroAsiento);
                ejecutarConsulta.Parameters.AddWithValue("@EstadoLogico", nuevoAsiento.EstadoLogico);
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se pudo insertar Asiento"+ex.ToString());
            }

        }

        public DataTable ListarAsientos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("ListarAsientos", conexion))
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

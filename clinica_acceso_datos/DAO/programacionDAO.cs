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
    public class programacionDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        //crud
        public void InsertarProgramacion(programacion nuevaProgramacion)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarConsulta.CommandText = "insert into programacion(id_programacion,id_sala,id_pelicula,Fecha_hora_proyeccion,Estado_logico)" + "values('" + nuevaProgramacion.fecha_hora_proyeccion + "','" + nuevaProgramacion.estado_logico  + ")";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:no se pudo isertar la programacion.." + ex.Message);
            }
        }
        public DataTable ListarProgramacion()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from programacion";
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar programacion:" + ex.Message);
            }
        }

        public DataTable BuscarProgramacionF(DateTime fecha_hora_programacion)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from programacion where f='" + fecha_hora_programacion + "'";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la Programacion:" + ex.Message);
            }
        }
        public void Insertar(programacion nuevo)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            ejecutarConsulta.CommandText = "InsertarProgramacion";
            ejecutarConsulta.CommandType = CommandType.StoredProcedure;
            ejecutarConsulta.Parameters.AddWithValue("@Fecha_hora_proyeccion", nuevo.fecha_hora_proyeccion);
            ejecutarConsulta.Parameters.AddWithValue("@Estado_logico", nuevo.estado_logico);
            ejecutarConsulta.ExecuteNonQuery();
            ejecutarConsulta.Parameters.Clear();
            conexionDB.CerrarConexion();
        }


    }
}


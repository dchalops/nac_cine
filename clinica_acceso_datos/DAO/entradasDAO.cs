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
    public class entradasDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        //crud
        public void InsertarEntradas(entradas nuevaEntrada)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarConsulta.CommandText = "insert into entradas(id_entrada,id_cliente,id_programacion,Asiento,Codigo_compra,Estado_logico)" + "values('" + nuevaEntrada.asiento + "','" + nuevaEntrada.codigo_compra + "','" + "','" + nuevaEntrada.estado_logico +")";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:no se pudo isertar las Entradas.." + ex.Message);
            }
        }
        public DataTable ListarEntradas()
        {
            DataTable dt = new DataTable();
            try
            {
                //1 conectar a la base de datos
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                //2 sacar la iformacion de la BD
                ejecutarConsulta.CommandText = "Select * from entradas";
                //3 almacenar resultados en un contenedor 
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                //4 returnar el contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Entradas:" + ex.Message);
            }
        }

        public DataTable BuscarEntradasC(string codigo_compra)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from entradas where c='" +codigo_compra+ "'";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las Entradas:" + ex.Message);
            }
        }
        public void Insertar(entradas nuevo)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            ejecutarConsulta.CommandText = "InsertarEntradas";
            ejecutarConsulta.CommandType = CommandType.StoredProcedure;
            ejecutarConsulta.Parameters.AddWithValue("@Asiento", nuevo.asiento);
            ejecutarConsulta.Parameters.AddWithValue("@Codigo_compra", nuevo.codigo_compra);
            ejecutarConsulta.Parameters.AddWithValue("@Estado_Logico", nuevo.estado_logico);
            ejecutarConsulta.ExecuteNonQuery();
            ejecutarConsulta.Parameters.Clear();
            conexionDB.CerrarConexion();
        }

    }
}


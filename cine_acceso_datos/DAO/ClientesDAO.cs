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
    public class ClientesDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        //crud
        public void InsertarClientes(Clientes nuevoCliente)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();

            try
            {
                ejecutarConsulta.CommandText = "INSERT INTO Clientes(id_cliente,Doc_identidad,Nombre,Apellido,Email,Telefono)" + "values('" + nuevoCliente.doc_identidad + "','" + nuevoCliente.nombre + "','" + "','" + nuevoCliente.apellido + "','" + nuevoCliente.email + "','" + nuevoCliente.telefono + ")";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            } catch (Exception ex)
            {
                throw new Exception("Error:no se pudo isertar cliente.." + ex.Message);
            }
        }
        public DataTable ListarCliente()
        {
            DataTable dt = new DataTable();
            try
            {
                //1 conectar a la base de datos
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                //2 sacar la iformacion de la BD
                ejecutarConsulta.CommandText = "Select * from cliente";
                //3 almacenar resultados en un contenedor 
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                //4 returnar el contenedor con el resultado
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al listar Cliente:" + ex.Message);
            }
        }
       
        public DataTable BuscarClienteCI(string doc_identidad)
        {
            DataTable dt = new DataTable();
            try
            {
                //1 conectar a la base de datos
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                //2 sacar la iformacion de la BD
                ejecutarConsulta.CommandText = "Select * from cliente where ci='" +doc_identidad+ "'";
                ejecutarSql = ejecutarConsulta.ExecuteReader();
                //3 almacenar resultados en un contenedor 
                dt.Load(ejecutarSql);
                conexionDB.CerrarConexion();
                //4 returnar el contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Cliente:" + ex.Message);
            }
        }
        public void Insertar(Clientes nuevo)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            ejecutarConsulta.CommandText = "InsertarClientes";
            ejecutarConsulta.CommandType = CommandType.StoredProcedure;
            ejecutarConsulta.Parameters.AddWithValue("@Doc_identidad", nuevo.doc_identidad);
            ejecutarConsulta.Parameters.AddWithValue("@Nombre", nuevo.nombre);
            ejecutarConsulta.Parameters.AddWithValue("@Apellido", nuevo.apellido);
            ejecutarConsulta.Parameters.AddWithValue("@Email", nuevo.email);
            ejecutarConsulta.Parameters.AddWithValue("@Telefono", nuevo.telefono);
            ejecutarConsulta.ExecuteNonQuery();
            ejecutarConsulta.Parameters.Clear();
            conexionDB.CerrarConexion();
        }
       
    }
}

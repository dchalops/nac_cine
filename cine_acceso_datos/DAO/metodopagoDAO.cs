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
    public class metodopagoDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarConsulta = new SqlCommand();
        SqlDataReader ejecutarSql;
        //crud

        public void Insertarmetodo_de_pago(metodo_de_pago nuevometododepago)
        {
            ejecutarConsulta.Connection = conexionDB.AbrirConexion();
            try
            {
                ejecutarConsulta.CommandText = "insert into metodos_pago (id_metodo_pago,tipo,detalles,fecha_expiracion,estado_logico)" +
                    "values('" + nuevometododepago.tipo + "','" + nuevometododepago.detalles + "','" + nuevometododepago.fecha_expiracion + "','" + nuevometododepago.estado_logico + "')";
                ejecutarConsulta.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se puede insertar metodo de pago" + ex.ToString());
            }
        }

        public DataTable Listarmetododepago()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from metodos_pago";
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

        public DataTable Buscarmetododepago(string tipo)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarConsulta.Connection = conexionDB.AbrirConexion();
                ejecutarConsulta.CommandText = "Select * from where tipo= '" + tipo + "'";
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

    }
}

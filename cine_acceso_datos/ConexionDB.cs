using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos
{
    public class ConexionDB
    {

        private SqlConnection connection = new SqlConnection("Server=RAGNAROK; DataBase=Cine; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            return connection;
        }
        public SqlConnection CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }



}

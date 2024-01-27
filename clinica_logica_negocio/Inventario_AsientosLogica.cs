using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_logica_negocio
{
    public class Inventario_AsientosLogica
    {





        private Inventario_AsientosDAO inventario_asientosDAO = new Inventario_AsientosDAO();
        public int InsertarInventario_Asientos(inventario_asientos inventario_asientos)
        {





            inventario_asientosDAO.InsertarInventarioAsientos(inventario_asientos);
            DataTable resultado = inventario_asientosDAO.BuscarInventarioAsientos(inventario_asientos.estado_asiento);
            return int.Parse(resultado.Rows[0]["id_inventario"].ToString());
        }
        public DataTable ListarInventarioAsientos()
        {
            return inventario_asientosDAO.ListarInventarioAsientos();
        }
    }
}

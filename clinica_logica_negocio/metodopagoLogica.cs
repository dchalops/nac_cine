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
    public class metodopagoLogica
    {
        private metodopagoDAO metodopagoDAO = new metodopagoDAO();

        public bool Insertarmetodo_de_pago(metodo_de_pago nuevometododepago)
        {
            metodopagoDAO.Insertarmetodo_de_pago(nuevometododepago);
            return true;
        }

        public DataTable Listarmetododepago()
        {
            return metodopagoDAO.Listarmetododepago();
        }
    }
}

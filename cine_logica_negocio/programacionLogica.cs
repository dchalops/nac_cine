using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocio
{
    public class programacionLogica
    {
        private programacionDAO ProgramacionDao = new programacionDAO();
        public Boolean InsertarProgramacion(programacion nuevoprogramacion)
        {
            ProgramacionDao.InsertarProgramacion(nuevoprogramacion);
            DataTable resultado = ProgramacionDao.BuscarProgramacionF(nuevoprogramacion.fecha_hora_proyeccion);
            return Boolean.Parse(resultado.Rows[0]["id_programacion"].ToString());
        }
        public DataTable ListarProgramacion()
        {
            return ProgramacionDao.ListarProgramacion();
        }
    }
}

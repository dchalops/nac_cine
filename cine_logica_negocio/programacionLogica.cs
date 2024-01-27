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
    internal class programacionLogica
    {
        private programacionDAO ProgramacionDao = new programacionDAO();
        public int InsertarProgramacion(programacion programacion)
        {
            ProgramacionDao.InsertarProgramacion(programacion);
            DataTable resultado = ProgramacionDao.BuscarProgramacionF(programacion.fecha_hora_proyeccion);
            return int.Parse(resultado.Rows[0]["id_programacion"].ToString());
        }
        public DataTable ListarProgramacion()
        {
            return ProgramacionDao.ListarProgramacion();
        }
    }
}

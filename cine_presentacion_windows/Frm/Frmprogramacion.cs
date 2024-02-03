using cine_acceso_datos.Entidades;
using cine_logica_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_presentacion_windows.Frm
{
    public partial class Frmprogramacion : Form
    {
        private programacion programacion;
        private programacionLogica ProgramacionLogica;
        public Frmprogramacion()
        {
            InitializeComponent();
            programacion = new programacion();
            ProgramacionLogica = new programacionLogica();
        }
        private void insertarProgramacion()
        {
            programacion.fecha_hora_proyeccion = dtfecha.Value;
            programacion.estado_logico = cbestado.Text;

            if (ProgramacionLogica.InsertarProgramacion(programacion))
            {
                MessageBox.Show("programacion insertada correctamente");
            }
            else
            {
                MessageBox.Show("ERROR: Al intentar registrar programacion");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            insertarProgramacion();
        }
    }
}

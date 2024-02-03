using cine_acceso_datos.Entidades;
using cine_logica_negocio;
using CineLogicaNegocio;
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
    public partial class FrmSalas : Form
    {
        private Sala sala;
        private SalaLogica salaLogica;

        public FrmSalas()
        {
            InitializeComponent();
            sala = new Sala();
        }

        private void insertarSala()
        {
            sala.nombreSala = txtNombreSala.Text;
            sala.capacidad  = int.Parse( txtCapacidad.Text);
            sala.estadoLogico = true;

            if (salaLogica.InsertarSala(sala))
            {
                MessageBox.Show("sala insertado correctamente");
            }
            else
            {
                MessageBox.Show("ERRROR: Al intentar registrar Sala");
            }


        }








        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarSala();
        }


    }
}

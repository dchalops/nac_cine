using cine_acceso_datos.Entidades;
using cine_logica_negocio;
using Cine_logica_negocio;
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
    public partial class FrmAsientos : Form
    {

        private Asiento asiento;
        private AsientoLogica asientoLogica;

        public FrmAsientos()
        {
            InitializeComponent();
            asiento = new Asiento();
        }

        private void insertarAsiento()
        {
            asiento.IdSala = int.Parse(txtSala.Text);
            asiento.NumeroAsiento = int.Parse(txtNumAsiento.Text);
            asiento.EstadoLogico = true;

            if (asientoLogica.InsertarAsiento(asiento))
            {
                MessageBox.Show("asiento insertado correctamente");
            }
            else
            {
                MessageBox.Show("ERRROR: Al intentar registrar Asiento");
            }


        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarAsiento();
        }
    }
}

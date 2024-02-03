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
    
    public partial class Frmentradas : Form
    {
       private entradas Entradas;
       private entradasLogica Entradaslogica;
        public Frmentradas()
        {
            InitializeComponent();
            Entradas = new entradas();
            Entradaslogica = new entradasLogica();
        }
        private void insertarEntradas()
        {
            Entradas.asiento = txtasiento.Text;
            Entradas.codigo_compra = txtcompra.Text;
            Entradas.estado_logico = cbestado.Text;

            if (Entradaslogica.InsertarEntradas(Entradas))
            {
                MessageBox.Show("entradas insertada correctamente");
            }
            else
            {
                MessageBox.Show("ERROR: Al intentar registrar entradas");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            insertarEntradas();
        }
    }
}

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

namespace cine_presentacion_windows
{
    public partial class Facturas : Form
    {
        private FacturasLogica facturasLogica = new FacturasLogica();
        public Facturas()
        {
            InitializeComponent();
            facturasLogica = new FacturasLogica();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            CargarDatosFactura();
        }

        private void CargarDatosFactura()
        {
            try
            {
                DataTable facturas = facturasLogica.MostrarFacturas();
                dataGridView1.DataSource = facturas;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

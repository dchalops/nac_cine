using cine_logica_negocio;
using clinica_presentacion_windows;
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
            CargarDatosFac();
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
        public void CargarDatosFac()
        {
            try
            {
                dataGridView2.DataSource  = facturasLogica.MostrarFacturas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Direcciones Dir = new Direcciones();
            Dir.Show();
            this.Hide();
        }
    }
}

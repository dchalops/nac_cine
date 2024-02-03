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
        }

        private void CargarDatosFactura()
        {
            try
            {
                DataTable facturas = facturasLogica.MostrarFacturas();
                dataGridView1.DataSource = facturas;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    switch (column.Name)
                    {
                        case "id_factura":
                            column.HeaderText = "ID";
                            break;
                        case "fecha":
                            column.HeaderText = "Fecha";
                            break;
                        case "total":
                            column.HeaderText = "Total";
                            break;
                        case "id_cliente":
                            column.HeaderText = "ID Cliente";
                            break;
                        case "id_metodo_pago":
                            column.HeaderText = "Método Pago";
                            break;
                        case "autorizacion_sri":
                            column.HeaderText = "Autorización SRI";
                            break;
                        case "estado_factura":
                            column.HeaderText = "Estado Factura";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FacturaAgregar().ShowDialog();
        }
    }
}

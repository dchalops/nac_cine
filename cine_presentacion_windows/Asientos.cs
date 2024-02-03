using cine_acceso_datos.Entidades;
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

namespace clinica_presentacion_windows
{
    public partial class Asientos : Form
    {
        private Inventario_AsientosLogica asientosLogica = new Inventario_AsientosLogica();
        public Asientos()
        {
            InitializeComponent();
            asientosLogica = new Inventario_AsientosLogica();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos()
        {
            try
            {
                dataGridView1.DataSource = asientosLogica.ListarInventarioAsientos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inventario_asientos nuevoasiento = new inventario_asientos();
            nuevoasiento.id_sala = int.Parse(txtSala.Text);
            nuevoasiento.id_programacion = int.Parse(txtProgramacion.Text);
            nuevoasiento.id_asiento = int.Parse(txtAsiento.Text);
            nuevoasiento.estado_asiento = txtEstadoAs.Text;
            nuevoasiento.fecha = DateTime.Parse(txtFecha.Text);
            if (chkEstado.Checked)
            {
                nuevoasiento.estado_logico = 1;
            }
            else
            {
                nuevoasiento.estado_logico = 0;
            }
            int idInsertado = asientosLogica.InsertarInventario_Asientos(nuevoasiento);
            asientosLogica.ListarInventarioAsientos();
            MessageBox.Show("Asiento insertado: " + idInsertado);
            asientosLogica.ListarInventarioAsientos();
            CargarDatos();
            txtSala.Text = "";
            txtProgramacion.Text = "";
            txtAsiento.Text = "";
            txtEstadoAs.Text = "";
            txtFecha.Text = "";
        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Direcciones Dir = new Direcciones();
            Dir.Show();
            this.Hide();
        }
    }
}

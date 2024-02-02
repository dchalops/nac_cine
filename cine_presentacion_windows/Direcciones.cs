using cine_acceso_datos.DAO;
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

namespace clinica_presentacion_windows
{
    public partial class Direcciones : Form
    {
        private DireccionesLogica direccionesLogica = new DireccionesLogica();
        public Direcciones()
        {
            InitializeComponent();
            direccionesLogica = new DireccionesLogica();
        }

        private void Direcciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            try
            {
                dataGridView1.DataSource = direccionesLogica.ListarDireccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Direcciones Dir = new Direcciones();
            Dir.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            direcciones nuevodireccion = new direcciones();
            nuevodireccion.id_cliente = int.Parse(txtCliente.Text);
            nuevodireccion.calle = txtCalle.Text;
            nuevodireccion.ciudad = txtCiudad.Text;
            nuevodireccion.estado = txtEstado.Text;
            nuevodireccion.codigo_postal = txtPostal.Text;
            nuevodireccion.pais = txtPais.Text;
            if (chkEstado.Checked)
            {
                nuevodireccion.estado_logico = 1;
            }
            else
            {
                nuevodireccion.estado_logico = 0;
            }
            int idInsertado = direccionesLogica.InsertarDirecciones(nuevodireccion);
            direccionesLogica.ListarDireccion();
            MessageBox.Show("Cliente insertado: " + idInsertado);
            direccionesLogica.ListarDireccion();
            CargarDatos();
            txtCliente.Text = "";
            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtPostal.Text = "";
            txtPais.Text = "";
        }
    }
}

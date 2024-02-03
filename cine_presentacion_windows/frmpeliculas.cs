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

namespace cine_presentacion_windows
{
       public partial class frmpeliculas : Form
    {
        private peliculas peliculas;
        private peliculasLogica peliculasLogica;
              public frmpeliculas()
        {
            InitializeComponent();
            peliculas = new peliculas();    
            peliculasLogica = new peliculasLogica();

        }

        private void insertarPelicula()
        {
            peliculas.titulo= txtTitulo.Text;
            peliculas.duracion= txtDuracion.Text;
            peliculas.sinopsis= txtSinopsis.Text;
            peliculas.trailer_url = txtTrailer.Text;
            peliculas.estado_logico = 1;

            if (peliculasLogica.Insertarpeliculas(peliculas))
            {
                MessageBox.Show("Pelicula ingresada correctamente");
                listarpelicula();
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar película");
            }
        }
        private void listarpelicula()
        {
            dgvPeliculas.DataSource= peliculasLogica.listarpelicula();  

        }

        private void buscarpelicula()
        {
            peliculas.titulo= txtTitulo.Text;  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            insertarPelicula();
            txtTitulo.Text = "";
            txtDuracion.Text = "";
            txtSinopsis.Text = "";
            txtTrailer.Text = "";
        }

        private void frmpeliculas_Load(object sender, EventArgs e)
        {
            listarpelicula();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarpelicula();   
        }
    }
}

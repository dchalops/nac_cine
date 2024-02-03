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
    public partial class frmStockPeliculas : Form
    {
        private stock_peliculas stock_Peliculas;
        private stockpeliculasLogica stockpeliculasLogica;

        public frmStockPeliculas()
        {
            InitializeComponent();
            stock_Peliculas = new stock_peliculas();
            stockpeliculasLogica = new stockpeliculasLogica();
        }


        private void insertarstockpeliculas()
        {
            stock_Peliculas.cantidad= txtCantidad.Text;
            stock_Peliculas.id_peliculas = txtCodigoPelicula.Text;
            stock_Peliculas.fecha_ultimo_pedido = dtFechaUP.Value;
            stock_Peliculas.estado_logico = 1;

            if (stockpeliculasLogica.insertarstockpeliculas(stock_Peliculas))
            {
                MessageBox.Show("Stock ingresado correctamente");
                Listarstockpeliculas();
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar Stock Peliculas");
            }

        }

        private void Listarstockpeliculas()
        {
            dgvStockP.DataSource = stockpeliculasLogica.Listarstockpeliculas();
        }

        private void Buscarstockpeliculas()
        {
            stock_Peliculas.id_peliculas= txtCodigoPelicula.Text;
        }
        private void GRABAR_Click(object sender, EventArgs e)
        {
            insertarstockpeliculas();
            txtCantidad.Text = "";
            txtCodigoPelicula.Text = "";
        }

        private void frmStockPeliculas_Load(object sender, EventArgs e)
        {
            Listarstockpeliculas();
        }
    }
}

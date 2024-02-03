using cine_acceso_datos.Entidades;
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
    public partial class FrmEventos : Form
    {
        private Evento evento;
        private EventoLogica eventoLogica;

        public FrmEventos()
        {
            InitializeComponent();
            evento = new Evento();
        }

        private void insertarEvento()
        {
            evento.titulo = txtTitulo.Text;
            evento.idPelicula = int.Parse(txtIdPelicula.Text);
            evento.descripcion = txtDescripcion.Text;
            evento.trailerUrl = txtTrailerUrl.Text; 
            evento.estadoLogico = true;

            if (eventoLogica.InsertarEvento(evento))
            {
                MessageBox.Show("evento insertado correctamente");
            }
            else
            {
                MessageBox.Show("ERRROR: Al intentar registrar Evento");
            }


        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarEvento();
        }


    }
}

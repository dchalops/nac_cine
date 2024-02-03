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
    public partial class frmMetodoPago : Form

    {
        private metodo_de_pago Metodo_De_Pago;
        private metodopagoLogica MetodopagoLogica;
        public frmMetodoPago()
        {
            InitializeComponent();
            Metodo_De_Pago = new metodo_de_pago();  
            MetodopagoLogica = new metodopagoLogica();
        }
         private void Insertarmetodo_de_pago()
        {
            Metodo_De_Pago.tipo = txtTipoPago.Text;
            Metodo_De_Pago.detalles = txtxDetalles.Text;
            Metodo_De_Pago.fecha_expiracion = dtFechaExpiracion.Value;
            Metodo_De_Pago.estado_logico = 1;

            if (MetodopagoLogica.Insertarmetodo_de_pago(Metodo_De_Pago))
            {
                MessageBox.Show("Método de pago ingresado correctamente");
                Listarmetododepago();
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar método de pago");
            }
        }

        private void Listarmetododepago()
        {
            dgvMetodoPago.DataSource = MetodopagoLogica.Listarmetododepago();
        }

        private void Buscarmetododepago()
        {
            Metodo_De_Pago.tipo = txtTipoPago.Text;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Insertarmetodo_de_pago();
            txtTipoPago.Text = "";
            txtxDetalles.Text = "";
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {
            Listarmetododepago();
        }
    }
}

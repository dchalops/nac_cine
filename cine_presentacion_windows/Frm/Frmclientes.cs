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
    public partial class Frmclientes : Form
    {
        private Clientes cliente;
        public Frmclientes()
        {
            InitializeComponent();
            cliente = new Clientes();
        }
        private void insertarClientes()
        {
            cliente.nombre = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.doc_identidad = txtcedula.Text;
            cliente.telefono = txtelefono.Text;
            cliente.email = txtemail.Text;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }
    }
}

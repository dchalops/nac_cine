using cine_acceso_datos.DAO;
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

namespace clinica_presentacion_windows
{
    public partial class FacturaAgregar : Form
    {
        private FacturasLogica facturasLogica = new FacturasLogica();
        public FacturaAgregar()
        {
            InitializeComponent();
            facturasLogica = new FacturasLogica();
        }

        public void refrescar()
        {
            comboCliente.Items.Clear();
            comboProducto.Items.Clear();
            
            foreach (Clientes cliente in facturasLogica.Clientes())
            {
                string nombreCompleto = cliente.nombre + " " + cliente.apellido;
                
                comboCliente.Items.Add(nombreCompleto);
            }
            
            foreach (peliculas producto in facturasLogica.Productos())
            {
                comboProducto.Items.Add(producto.titulo);
            }
        }
        private void FacturaVista_Load(object sender, EventArgs e)
        {
            //refrescar();
            CargarClientesEnComboBox();
            CargarPeliculasEnComboBox();
        }
        private void CargarClientesEnComboBox()
        {
            List<Clientes> listaClientes = facturasLogica.Clientes();
            comboCliente.DataSource = listaClientes;
            comboCliente.DisplayMember = "NombreCompleto";
            comboCliente.ValueMember = "id_cliente";
        }

        private void CargarPeliculasEnComboBox()
        {
            List<peliculas> listaPeliculas = facturasLogica.Productos();
            comboProducto.DataSource = listaPeliculas;
            comboProducto.DisplayMember = "titulo";
            comboProducto.ValueMember = "id_pelicula";
            
        }

        private int ObtenerIdClienteSeleccionado()
        {
            if (comboCliente.SelectedValue != null)
            {
                return (int)comboCliente.SelectedValue;
            }
            return -1;
        }

        private int ObtenerIdPeliculaSeleccionada()
        {
            if (comboProducto.SelectedValue != null)
            {
                return (int)comboProducto.SelectedValue;
            }
            return -1;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            
            if (comboProducto.SelectedItem is peliculas productoSeleccionado)
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal total = cantidad * 2;

                bool productoYaAgregado = false;
                foreach (DataGridViewRow row in dataDescripcion.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Codigo"].Value) == productoSeleccionado.id_pelicula)
                    {
                        productoYaAgregado = true;
                        break;
                    }
                }

                if (!productoYaAgregado)
                {
                    txtCantidad.Text = "";
                    dataDescripcion.Rows.Add(productoSeleccionado.id_pelicula, productoSeleccionado.titulo, cantidad, 2, total);
                    sumar();
                }
                else
                {
                    MessageBox.Show("Este producto ya ha sido agregado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataDescripcion.SelectedRows.Count; i++)
            {
                dataDescripcion.Rows.Remove(dataDescripcion.SelectedRows[i]);
            }
            sumar();
        }

        public void sumar()
        {
            double subtotal = 0;

            for (int i = 0; i < dataDescripcion.Rows.Count; i++)
            {
                subtotal = subtotal + Convert.ToDouble(dataDescripcion.Rows[i].Cells[4].Value);
            }

            double descuento = 0;

            try
            {
                descuento = double.Parse(
                        (txtDescuento.Text == "") ? "0" : txtDescuento.Text
                    );
            }
            catch
            {
                MessageBox.Show("Revise que el descuento sea numerico");
            }

            double total = 0;
            double isv = subtotal * 0.15;
            total = subtotal + isv - descuento;

            txtTotal.Text = total + "";
            txtIsv.Text = isv + "";
            txtSubtotal.Text = subtotal + "";
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            sumar();
        }

        private void txtIsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboCliente.Text != "")
            {
                try
                {
                    
                    decimal subtotal = 0;

                    for (int i = 0; i < dataDescripcion.Rows.Count; i++)
                    {
                        subtotal = subtotal + Convert.ToDecimal(dataDescripcion.Rows[i].Cells[4].Value);
                    }

                    decimal descuento = 0;

                    try
                    {
                        descuento = decimal.Parse(
                                (txtDescuento.Text == "") ? "0" : txtDescuento.Text
                            );
                    }
                    catch
                    {
                        MessageBox.Show("Revise que el descuento sea numerico");
                    }

                    decimal total = 0;
                    decimal isv = subtotal * (decimal)0.15;
                    total = subtotal + isv - descuento;

                    int idCliente = ObtenerIdClienteSeleccionado();
                    int idPelicula = ObtenerIdPeliculaSeleccionada();

                    Factura venta = new Factura();
                    venta.IdCliente = idCliente;
                    venta.Fecha = DateTime.Now;
                    venta.Total = total;
                    venta.IdMetodoPago = 1;
                    venta.AutorizacionSri = "www22";
                    venta.EstadoFactura = "AITORIZADA";
                    venta.EstadoLogico = true;

                    List<DetalleFactura> detalles = new List<DetalleFactura>();

                    for (int i = 0; i < dataDescripcion.Rows.Count; i++)
                    {
                        if (dataDescripcion.Rows[i].IsNewRow) continue; 

                        DetalleFactura detalle = new DetalleFactura
                        {
                            IdEntrada = Convert.ToInt32(dataDescripcion.Rows[i].Cells[0].Value),
                            Cantidad = Convert.ToInt32(dataDescripcion.Rows[i].Cells[2].Value),
                            Precio = Convert.ToDecimal(dataDescripcion.Rows[i].Cells[3].Value),
                            EstadoLogico = true
                        };

                        detalles.Add(detalle);
                    }

                    try
                    {
                        FacturaDAO facturaDAO = new FacturaDAO();
                        facturaDAO.InsertarFacturaConDetalles(venta, detalles);
                        MessageBox.Show("Factura guardada con éxito");
                    }
                    catch (Exception ex)
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la factura: " + ex.Message);

                }
            }
        }
        /*private void Guardar_Click(object sender, EventArgs e)
{
int idCliente = ObtenerIdClienteSeleccionado();
int idPelicula = ObtenerIdPeliculaSeleccionada();

// Aquí va la lógica para guardar la factura usando idCliente e idPelicula
}*/

    }
}

using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocio
{
    public class FacturasLogica
    {
        private FacturaDAO facturaDAO = new FacturaDAO();
        private ClientesDAO clientesDAO = new ClientesDAO();
        private peliculasDAO peliculasDAO = new peliculasDAO();

        public DataTable MostrarFacturas()
        {
            
            return facturaDAO.MostrarFactura();

        }

        public List<Clientes> Clientes()
        {
            return clientesDAO.findAll();
        }

        public List<peliculas> Productos()
        {
            return peliculasDAO.findAll();
        }

        public void InsertarFacturaConDetalles(Factura factura, List<DetalleFactura> detalles)
        {
            
            facturaDAO.InsertarFacturaConDetalles(factura, detalles);
            
        }

        public void EditarFacturaConDetalles(int idFactura, List<DetalleFactura> detallesEditados)
        {
            facturaDAO.EditarFacturaConDetalles(idFactura, detallesEditados);
        }

        public void EliminarFactura(Factura factura)
        {
            facturaDAO.EliminarFacturaConDetalle(factura);
        }

    }
}

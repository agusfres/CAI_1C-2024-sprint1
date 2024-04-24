using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    public class NegocioProveedor
    {
        private ProveedorService proveedorService = new ProveedorService();
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");


        public void AgregarProveedor(string nombre, string apellido, string email, string cuit)
        {
            AltaProveedor altaProveedor = new AltaProveedor(idAdministrador, nombre, apellido, email, cuit);
            proveedorService.AgregarProveedor(altaProveedor);
        }


        public void BajaProveedor(Guid id)
        {
            proveedorService.BajaProveedor(id, idAdministrador);
        }
    }
}

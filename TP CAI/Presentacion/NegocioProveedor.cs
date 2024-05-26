using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    public class NegocioProveedor
    {
        private ProveedorService proveedorService = new ProveedorService();
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string docPathAdaptado = @"C:\Users\USUARIOSISTEMA\ProveedoresLocales.txt".Replace("USUARIOSISTEMA", Environment.UserName);



        public void AgregarProveedor(string nombre, string apellido, string email, string cuit, List <int> seleccionCategoriaProd)
        {
            AltaProveedor altaProveedor = new AltaProveedor(idAdministrador, nombre, apellido, email, cuit);
            proveedorService.AgregarProveedor(altaProveedor);
            Proveedor proveedorAuxiliar = BuscarProveedor(nombre);

            Guid idProveedorAuxiliar = proveedorAuxiliar.Id;
            Proveedor proveedor = new Proveedor(idProveedorAuxiliar, nombre, apellido, email, cuit, DateTime.Now, null, seleccionCategoriaProd);
            AgregarProveedorBaseLocal(proveedor);

        }


        public Proveedor BuscarProveedor(string nombreProveedor)
        {
            List<Proveedor> listaProveedores = TraerProveedoresActivos();

            if (listaProveedores != null)
            {
                foreach (Proveedor proveedor in listaProveedores)
                {
                    if (proveedor.Nombre == nombreProveedor)
                    {
                        return proveedor;
                    }
                }
            }

            return null;
        }


        public List<Proveedor> TraerProveedoresActivos()
        {
            return proveedorService.TraerProveedoresActivos();
        }


        public void BajaProveedor(Guid id)
        {
            proveedorService.BajaProveedor(id, idAdministrador);
        }


        private void AgregarProveedorBaseLocal(Proveedor proveedor)
        {
            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(proveedor.Id + "+" + proveedor.Nombre + "+" + proveedor.Apellido + "+" + proveedor.Email + "+" + proveedor.Cuit + "+" + proveedor.FechaAlta + "+null+" + proveedor.SeleccionCategoriaProd );
            }
            catch
            {
                Console.WriteLine("error");
            }

            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Proveedor : Persona
    {
        string cuit;
        DateTime fechaAlta;
        DateTime? fechaBaja;
        List<int> seleccionCategoriaProd;


        public Proveedor(Guid id, string nombre, string apellido, string email, string cuit, DateTime fechaAlta, DateTime? fechaBaja, List<int> seleccionCategoriaProd) : base(id, nombre, apellido, email)
        {
            this.cuit = cuit;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.seleccionCategoriaProd = seleccionCategoriaProd;
        }

        public string Cuit { get => cuit; set => cuit = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public List<int> SeleccionCategoriaProd { get => seleccionCategoriaProd; set => seleccionCategoriaProd = value;  }

    }
}

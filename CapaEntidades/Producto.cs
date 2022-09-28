using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        //Atributos
        private string codProducto;
        private string nombre;
        private string unidadMedida;
        private int precio;
        private int stock;
        private string codCategoria;

        //Propiedades
        public string CodProducto { get => codProducto; set => codProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string CodCategoria { get => codCategoria; set => codCategoria = value; }
    }
}

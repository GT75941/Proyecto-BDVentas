using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IProducto
    {
        //declaracion de metodos de la clase producto
        DataSet ListarP();
        string[] AgregarP(Producto producto);
        string[] ActualizarP(Producto producto);
        string[] EliminarP(Producto producto);
        DataSet BuscarP(string criterio, string codProducto);
    }
}

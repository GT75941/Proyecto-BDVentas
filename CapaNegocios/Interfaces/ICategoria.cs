using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface ICategoria
    {
        //declaracion de metodos de la clase clientes
        DataSet ListarC();
        string[] AgregarC(Categoria categoria);
        string[] EliminarC(Categoria categoria);
        string[] ActualizarC(Categoria categoria);
        DataSet BuscarC(string criterio, string codCategoria);
    }
}

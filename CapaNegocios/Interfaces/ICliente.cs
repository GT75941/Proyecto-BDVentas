using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface ICliente
    {
        //declaracion de metodos de la clase clientes
        DataSet Listar();
        string[] Agregar(Cliente cliente);
        string[] Eliminar(Cliente cliente);
        string[] Actualizar(Cliente cliente);
        DataSet Buscar(string texto, string criterio);
    }
}

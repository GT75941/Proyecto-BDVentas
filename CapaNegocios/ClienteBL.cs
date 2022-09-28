using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class ClienteBL : Interfaces.ICliente
    {
        //un objeto para accedera la capa datos
        Datos datos = new DatosSQL();

        public string[] Actualizar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("uspActualizarCliente", cliente.CodCliente, cliente.Apellidos, cliente.Direccion);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }

        public string[] Agregar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("uspAgregarCliente", cliente.CodCliente, cliente.Nombres, cliente.Apellidos, cliente.Direccion);
            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("uspBuscarCliente", texto, criterio);
        }

        public string[] Eliminar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("uspEliminarCliente", cliente.CodCliente);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("uspListarCliente");
        }
    }
}

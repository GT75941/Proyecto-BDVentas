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
    public class ProductoBL
    {
        Datos datos = new DatosSQL();
        public DataSet ListarP()
        {
            return datos.TraerDataSet("sp_ListarProducto");
        }
        public DataSet BuscarP(string criterio, string codProducto)
        {
            return datos.TraerDataSet("sp_BuscarProducto", criterio, codProducto);
        }
        public string[] AgregarP(Producto producto)
        {
            DataRow fila = datos.TraerDataRow("sp_AgregarProducto", producto.CodProducto, producto.Nombre, producto.UnidadMedida, producto.Precio, producto.Stock, producto.CodCategoria);
            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
        public string[] ActualizarP(Producto producto)
        {
            DataRow fila = datos.TraerDataRow("sp_ActualizarProducto", producto.CodProducto, producto.Nombre, producto.UnidadMedida, producto.Precio, producto.Stock, producto.CodCategoria);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
        public string[] EliminarP(Producto producto)
        {
            DataRow fila = datos.TraerDataRow("sp_EliminarProducto", producto.CodProducto);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
    }
}

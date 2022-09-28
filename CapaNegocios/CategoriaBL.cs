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
    public class CategoriaBL : Interfaces.ICategoria
    {
        Datos datos = new DatosSQL();
        public DataSet ListarC()
        {
            return datos.TraerDataSet("sp_ListarCategoria");
        }
        public DataSet BuscarC(string criterio, string codCategoria)
        {
            return datos.TraerDataSet("sp_BuscarCategoria", criterio, codCategoria);
        }
        public string[] AgregarC(Categoria categoria)
        {
            DataRow fila = datos.TraerDataRow("sp_AgregarCategoria", categoria.CodCategoria, categoria.Nombre, categoria.CategoriaPadre);
            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
        public string[] ActualizarC(Categoria categoria)
        {
            DataRow fila = datos.TraerDataRow("sp_ActualizarCategoria", categoria.CodCategoria, categoria.Nombre, categoria.CategoriaPadre);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
        public string[] EliminarC(Categoria categoria)
        {
            DataRow fila = datos.TraerDataRow("sp_EliminarCategoria", categoria.CodCategoria);

            string[] msj = new string[2];
            msj[0] = Convert.ToString(fila["CodError"]);
            msj[1] = fila["mensaje"].ToString();
            return msj;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Categoria
    {
        //atributos
        private string codCategoria;
        private string nombre;
        private string categoriaPadre;

        //entidades
        public string CodCategoria { get => codCategoria; set => codCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CategoriaPadre { get => categoriaPadre; set => categoriaPadre = value; }
    }
}

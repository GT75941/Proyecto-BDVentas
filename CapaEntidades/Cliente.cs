using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        //Atributos
        private string codCliente;
        private string apellidos;
        private string nombres;
        private string direccion;

        //Propiedades
        public string CodCliente { get => codCliente; set => codCliente = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}

using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        // mapeado objeto relacional
        public string CodCliente { get; set; }
        public string Apellidos  { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public object Listar { get; set; }
    }
}

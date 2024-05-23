using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Usar los buffer de memoria
using CapaEntidad;

namespace CapaNegocio.Interface
{
    public interface ICliente
    {
        //declarr los metosdos de la calse Cliente de la Capa de Negocios
        DataTable Listar();
        bool Agregar (Cliente cliente);
        bool Eliminar (String codCliente);
        bool Actualizar (Cliente cliente);

        DataTable Buscar(String codCliente);
    }
}

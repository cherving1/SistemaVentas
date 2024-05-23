using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; //esto llama a los drives de sql server
using System.Data;// buffer de memorias
using System.Configuration;
using CapaEntidad;//esto extrae la cadena de conexion de la capa de presentacion de windows

namespace CapaNegocio
{
    public class ClienteBL : Interface.ICliente
    {
        //extres la cadena de conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TCliente";
                //llevar la consulta a al base de datos y traer lso registros de la tabla
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
        public bool Actualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Cliente cliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadena)) {

                string consulta = "insert into TCliente values (@CodCliente, @Apellidos,@Nombres,@Direccion)";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@CodCliente", cliente.CodCliente);
                comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                comando.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);

                conexion.Open();

                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
        }

        public DataTable Buscar(string codCliente)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string codCliente)
        {
            throw new NotImplementedException();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacionWindows.Mantenimiento
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            ClienteBL clienteBL = new ClienteBL();
            dgvCliente.DataSource= clienteBL.Listar();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar un cliente a la base de datos
            Cliente cliente = new Cliente();
            ClienteBL clienteBl = new ClienteBL();
            cliente.CodCliente = txtCodCliente.Text.Trim();
            cliente.Apellidos = txtApellido.Text.Trim();
            cliente.Nombres = txtNombre.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            if (clienteBl.Agregar(cliente))
            {
                
                MessageBox.Show("Datos agregados correctamente");
                Listar();
            }
            else
            {
                MessageBox.Show("Error al agragar Cliente");
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWindows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar al formulario del cliente
            Mantenimiento.frmCliente frm= new Mantenimiento.frmCliente();
            frm.MdiParent = this;// es hijo del formulario principal
            frm.Show();


        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

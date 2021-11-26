using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoGrupo4.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        ClienteView vistaClientes;
        ClaseView vistaClase;
        DestinoView vistaDestino;

       
        private void ClienteToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaClientes == null)
            {
                vistaClientes = new ClienteView();
                vistaClientes.MdiParent = this;
                vistaClientes.FormClosed += VistaClientes_FormClosed;
                vistaClientes.Show();
            }
            else
            {
                vistaClientes.Activate();
            }
        }

        private void VistaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClientes = null;
        }

        private void ClaseToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaClase == null)
            {
                vistaClase = new ClaseView();
                vistaClase.MdiParent = this;
                vistaClase.FormClosed += VistaClase_FormClosed;
                vistaClase.Show();
            }
            else
            {
                vistaClase.Activate();
            }
        }

        private void VistaClase_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClase = null;
        }

        private void DestinoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDestino == null)
            {
                vistaDestino = new DestinoView();
                vistaDestino.MdiParent = this;
                vistaDestino.FormClosed += VistaDestino_FormClosed;
                vistaDestino.Show();
            }
            else
            {
                vistaDestino.Activate();
            }
        }

        private void VistaDestino_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaDestino = null;
        }
    }
}

using ProyectoGrupo4.Modelos.DAO;
using ProyectoGrupo4.Modelos.Entidades;
using ProyectoGrupo4.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Controladores
{
    public class GenerarBoletoController
    {
        GenerarBoletoView vista;

        GenerarBoletoDAO gener = new GenerarBoletoDAO();


        BoletoGenerado generacion = new BoletoGenerado();

        ClienteDAO cliente = new ClienteDAO();

        Cliente client = new Cliente();

        ClaseDAO clas = new ClaseDAO();

        int total,TotalFinal;

        public GenerarBoletoController(GenerarBoletoView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
            vista.btn_calcularTotal.Click += new EventHandler(Calcular);



        }

        private void Calcular(object sender, EventArgs e)
        {
            total = Convert.ToInt32(vista.PrecioTextBox.Text);

            TotalFinal = total;

            vista.txt_total.Text = TotalFinal.ToString();


        }

        private void Load(object sender, EventArgs e)
        {

            //vista.NombreTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            //vista.IdTextBox.Text = client.Nombre;
            vista.NombreTextBox.Text = cliente.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.PrecioTextBox.Text = clas.GetUsuarioClase();
            //client = cliente.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            //vista.NombreTextBox.Text = client.Nombre;

        }
    }
}

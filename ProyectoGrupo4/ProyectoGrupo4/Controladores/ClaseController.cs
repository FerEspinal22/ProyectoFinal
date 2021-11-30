using ProyectoGrupo4.Modelos.DAO;
using ProyectoGrupo4.Modelos.Entidades;
using ProyectoGrupo4.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo4.Controladores
{
    public class ClaseController
    {
        ClaseView vista; // instancia objeto ClaseView del Formulario
        ClaseDAO Class = new ClaseDAO(); // Instancia Objeto ClaseDAO de Modelo
        TipoClase TipoClass = new TipoClase(); // Instancia TipoClase de la Entidad


        public ClaseController(ClaseView view)
        {
            vista = view;
            vista.btn_Guardar.Click += new EventHandler(guardar);
            vista.btn_Cancelar.Click += new EventHandler(Cancelar);


        }

        private void Cancelar(object serder, EventArgs e)
        {
            vista.Close();
        }


        private void guardar(object serder, EventArgs e)
        {
            int precio;
            string nombre = "";
            if (vista.rdb_PrimeraClase.Checked == true)
            {

                MessageBox.Show("Selecciono Primera Clase");
                nombre = "Primera Clase";
                vista.rdb_ClaseEmpresarial.Enabled = false;
                vista.rdb_ClasePremiumEconomic.Enabled = false;
                vista.rdb_claseEconomica.Enabled = false;

                precio = 250;
                TipoClass.Precio = precio;
                vista.txt_PrimeraClase.Text = precio.ToString();

            }
            if (vista.rdb_ClaseEmpresarial.Checked == true)
            {

                MessageBox.Show("Selecciono Clase Empresarial");
                nombre = "Clase Empresarial";
                vista.rdb_PrimeraClase.Enabled = false;
                vista.rdb_ClasePremiumEconomic.Enabled = false;
                vista.rdb_claseEconomica.Enabled = false;

                precio = 150;
                TipoClass.Precio = precio;
                vista.txt_ClaseEmpresarial.Text = precio.ToString();

            }
            if (vista.rdb_ClasePremiumEconomic.Checked == true)
            {

                MessageBox.Show("Selecciono Clase Premium Economica");
                nombre = "Clase Premium Economica";
                vista.rdb_PrimeraClase.Enabled = false;
                vista.rdb_ClaseEmpresarial.Enabled = false;
                vista.rdb_claseEconomica.Enabled = false;

                precio = 100;
                TipoClass.Precio = precio;
                vista.txt_ClasePremiumEconomica.Text = precio.ToString();

            }
            if (vista.rdb_claseEconomica.Checked == true)
            {

                MessageBox.Show("Selecciono Economica");
                nombre = "Clase Economica";
                vista.rdb_PrimeraClase.Enabled = false;
                vista.rdb_ClaseEmpresarial.Enabled = false;
                vista.rdb_ClasePremiumEconomic.Enabled = false;

                precio = 50;
                TipoClass.Precio = precio;
                vista.txt_ClaseEconomica.Text = precio.ToString();

            }
            TipoClass.Clase = nombre;

            bool inserto = Class.InsertarTipoClase(TipoClass);



            if (inserto)
            {
                MessageBox.Show("Insertado Satisfactoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error");
            }
        }


    }
}

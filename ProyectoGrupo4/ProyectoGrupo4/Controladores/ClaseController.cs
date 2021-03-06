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
            TipoClase TipoClass = new TipoClase();
            string precio;
            string nombre = "";
            if (vista.rdb_PrimeraClase.Checked == true)
            {
                
                MessageBox.Show("Selecciono Primera Clase");
                nombre = "Primera Clase";
                TipoClass.Clase = nombre;
                //vista.rdb_ClaseEmpresarial.Enabled = false;
                //vista.rdb_ClasePremiumEconomic.Enabled = false;
                //vista.rdb_claseEconomica.Enabled = false;

                precio = Convert.ToString( 250);
                TipoClass.Precio =Convert.ToInt32( precio);
                vista.txt_PrimeraClase.Text = precio.ToString();

            }
            //else
            //{
            //    precio = 0;
            //    TipoClass.Precio = precio;
            //    nombre = string.Empty;
            //    TipoClass.Clase = nombre;
            //}
            if (vista.rdb_ClaseEmpresarial.Checked == true)
            {
                
                MessageBox.Show("Selecciono Clase Empresarial");
                nombre = "Clase Empresarial";
                TipoClass.Clase = nombre;
                //vista.rdb_PrimeraClase.Enabled = false;
                //vista.rdb_ClasePremiumEconomic.Enabled = false;
                //vista.rdb_claseEconomica.Enabled = false;

                precio = Convert.ToString(150);
                TipoClass.Precio = Convert.ToInt32(precio);
                vista.txt_ClaseEmpresarial.Text = precio.ToString();

            }
            //else
            //{
            //    precio = 0;
            //    TipoClass.Precio = precio;
            //    nombre = string.Empty;
            //    TipoClass.Clase = nombre;
            //}
            if (vista.rdb_ClasePremiumEconomic.Checked == true)
            {
                
                MessageBox.Show("Selecciono Clase Premium Economica");
                nombre = "Clase Premium Economica";
                TipoClass.Clase = nombre;
                //vista.rdb_PrimeraClase.Enabled = false;
                //vista.rdb_ClaseEmpresarial.Enabled = false;
                //vista.rdb_claseEconomica.Enabled = false;

                precio = Convert.ToString(100);
                TipoClass.Precio = Convert.ToInt32(precio);
                vista.txt_ClasePremiumEconomica.Text = precio.ToString();

            }
            //else
            //{
            //    precio = 0;
            //    TipoClass.Precio = precio;
            //    nombre = string.Empty;
            //    TipoClass.Clase = nombre;
            //}
            
            if (vista.rdb_claseEconomica.Checked == true)
            {
                
                MessageBox.Show("Selecciono Economica");
                nombre = "Clase Economica";
                TipoClass.Clase = nombre;
                //vista.rdb_PrimeraClase.Enabled = false;
                //vista.rdb_ClaseEmpresarial.Enabled = false;
                //vista.rdb_ClasePremiumEconomic.Enabled = false;

                precio = Convert.ToString(250);
                TipoClass.Precio = Convert.ToInt32(precio);
                vista.txt_ClaseEconomica.Text = precio.ToString();

            }
            //else
            //{
            //    precio = 0;
            //    TipoClass.Precio = precio;
            //    nombre = string.Empty;
            //    TipoClass.Clase = nombre;
            //}
            //TipoClass.Clase = nombre;

            bool inserto = Class.InsertarTipoClase(TipoClass);



            if (inserto)
            {
                

                MessageBox.Show("Insertado Satisfactoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //System.Security.Principal.GenericIdentity  identidad = new System.Security.Principal.GenericIdentity(vista.txt_PrimeraClase.Text);
                //System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, null);
                //System.Threading.Thread.CurrentPrincipal = principal;

                System.Security.Principal.GenericIdentity Nombre = new System.Security.Principal.GenericIdentity(vista.rdb_ClaseEmpresarial.Text);
                System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(Nombre, null);
                System.Threading.Thread.CurrentPrincipal = principal;


                System.Security.Principal.GenericIdentity E = new System.Security.Principal.GenericIdentity(vista.rdb_claseEconomica.Text);
                System.Security.Principal.GenericPrincipal prin = new System.Security.Principal.GenericPrincipal(E, null);
                System.Threading.Thread.CurrentPrincipal = prin;

                System.Security.Principal.GenericIdentity P = new System.Security.Principal.GenericIdentity(vista.rdb_PrimeraClase.Text);
                System.Security.Principal.GenericPrincipal pri = new System.Security.Principal.GenericPrincipal(P, null);
                System.Threading.Thread.CurrentPrincipal = pri;

                System.Security.Principal.GenericIdentity CE = new System.Security.Principal.GenericIdentity(vista.rdb_ClasePremiumEconomic.Text);
                System.Security.Principal.GenericPrincipal princi = new System.Security.Principal.GenericPrincipal(CE, null);
                System.Threading.Thread.CurrentPrincipal = princi;

               
            }

            else
            {
                MessageBox.Show("Error");
            }
        }


    }
}

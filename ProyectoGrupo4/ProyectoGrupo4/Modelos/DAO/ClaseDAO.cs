using ProyectoGrupo4.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo4.Modelos.DAO
{
    public class ClaseDAO:Conexion
    {

        SqlCommand comando = new SqlCommand();
        public bool InsertarTipoClase(TipoClase tip)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TIPOCLASE");// pasando las sentencia con el metodo appen
                sql.Append(" VALUES (@NombreClase,@Precio)");
                comando.Connection = MiConexion; // accedemos a nuestro objeto comando y le pasamos la conexion de la cual heredamos de conexion
                MiConexion.Open(); // abrimos la  conexion a la base de datos con .open
                comando.CommandType = System.Data.CommandType.Text;                    // tipoo de sentencia que vamos a ejecutar
                comando.CommandText = sql.ToString(); // le pasamos la sentencia sql

                comando.Parameters.Add("@NombreClase", SqlDbType.NVarChar, 90).Value = tip.Clase;
                comando.Parameters.Add("@Precio", SqlDbType.Int).Value = tip.Precio;


                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return false;
                throw;
            }





        }

    }
}

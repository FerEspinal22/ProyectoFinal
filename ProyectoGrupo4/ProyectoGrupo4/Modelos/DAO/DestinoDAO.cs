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
    public class DestinoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoDestino(Destino destino)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO DESTINO ");
                sql.Append(" VALUES (@CiudadSalida, @LugarDestino, @CantidadAdultos, @CantidadNinios, @CantidadBebes, @FechaSalida, @FechaRegreso); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@CiudadSalida", SqlDbType.NVarChar, 80).Value = destino.CiudadDeSalida;
                comando.Parameters.Add("@LugarDestino", SqlDbType.NVarChar, 80).Value = destino.LugarDestino;
                comando.Parameters.Add("@CantidadAdultos", SqlDbType.Int).Value = destino.CantidadAdultos;
                comando.Parameters.Add("@CantidadNinios", SqlDbType.Int).Value = destino.CantidadNinios;
                comando.Parameters.Add("@CantidadBebes", SqlDbType.Int).Value = destino.CantidadBebes;
                comando.Parameters.Add("@FechaSalida", SqlDbType.Date).Value = destino.FechaDeSalida;
                comando.Parameters.Add("@FechaRegreso", SqlDbType.Date).Value = destino.FechaDeRegreso;
                comando.ExecuteNonQuery();
                MiConexion.Close();
                inserto = true;
            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetDestino()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM DESTINO ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool ActualizarDestino(Destino destino)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE DESTINO ");
                sql.Append(" SET CIUDADSALIDA = @CiudadSalida, LUGARDESTINO =@LugarDestino, CANTIDADADULTOS = @CantidadAdultos, CANTIDADNINIOS = @CantidadNinios, CANTIDADBEBES = @CantidadBebes, FECHASALIDA = @FechaSalida, FECHAREGRESO = @FechaRegreso ");
                sql.Append(" WHERE IDDESTINO = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = destino.id;
                comando.Parameters.Add("@CiudadSalida", SqlDbType.NVarChar, 80).Value = destino.CiudadDeSalida;
                comando.Parameters.Add("@LugarDestino", SqlDbType.NVarChar, 80).Value = destino.LugarDestino;
                comando.Parameters.Add("@CantidadAdultos", SqlDbType.Int).Value = destino.CantidadAdultos;
                comando.Parameters.Add("@CantidadNinios", SqlDbType.Int).Value = destino.CantidadNinios;
                comando.Parameters.Add("@CantidadBebes", SqlDbType.Int).Value = destino.CantidadBebes;
                comando.Parameters.Add("@FechaSalida", SqlDbType.Date).Value = destino.FechaDeSalida;
                comando.Parameters.Add("@FechaRegreso", SqlDbType.Date).Value = destino.FechaDeRegreso;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }

        public bool EliminarDestino(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM DESTINO ");
                sql.Append(" WHERE IDDESTINO = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }

        public string GetprimerDestino()
        {
            string precio = string.Empty;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT LUGARDESTINO FROM DESTINO WHERE IDDESTINO=(SELECT max(IDDESTINO) FROM DESTINO);");
                // sql.Append(" SELECT NOMBRE FROM CLIENTE WHERE ID=(SELECT max(ID) FROM CLIENTE ");




                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                precio = Convert.ToString(comando.ExecuteScalar());


                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return precio;
            }
            return precio;
        }

        public string GetFechaSalida()
        {
            string precio = string.Empty;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT FECHASALIDA FROM DESTINO WHERE IDDESTINO=(SELECT max(IDDESTINO) FROM DESTINO);");
                // sql.Append(" SELECT NOMBRE FROM CLIENTE WHERE ID=(SELECT max(ID) FROM CLIENTE ");




                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                precio = Convert.ToString(comando.ExecuteScalar());


                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return precio;
            }
            return precio;
        }

        public string GetFechaLlegada()
        {
            string precio = string.Empty;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT FECHAREGRESO FROM DESTINO WHERE IDDESTINO=(SELECT max(IDDESTINO) FROM DESTINO);");
                // sql.Append(" SELECT NOMBRE FROM CLIENTE WHERE ID=(SELECT max(ID) FROM CLIENTE ");




                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                precio = Convert.ToString(comando.ExecuteScalar());


                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return precio;
            }
            return precio;


        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace librerías
{
    public class CD_ConsultaClientes
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            //Procedimiento almacenado (primero se ocupa crear uno)
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public void Insertar(string numero, string apellido, string nombre, int puntaje)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "AgregarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@celular", numero);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@puntaje", puntaje);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Editar(string numero, string apellido, string nombre, int puntaje, int IDcliente)
        {
            //Procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@celular", numero);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@puntaje", puntaje);
            comando.Parameters.AddWithValue("@id", IDcliente);
            comando.ExecuteNonQuery();
            //comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Eliminar( int ID)
        {
            //Procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id", ID);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
    }
}

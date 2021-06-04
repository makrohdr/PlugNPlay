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

        public void Insertar(string Telefono, string RedSocial, string Contacto, string Apellido, string Nombre, int Puntaje)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "AgregarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@RedSocial", RedSocial);
            comando.Parameters.AddWithValue("@Contacto", Contacto);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@puntaje", Puntaje);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Editar(string Telefono, string RedSocial, string Contacto, string Nombre, string Apellido, 
            int Puntaje, string IDCliente)
        {
            //Procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@RedSocial", RedSocial);
            comando.Parameters.AddWithValue("@Contacto", Contacto);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@puntaje", Puntaje);
            comando.Parameters.AddWithValue("@IDCliente", IDCliente);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Eliminar( string IDTelefono)
        {
            //Procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Telefono", IDTelefono);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
    }
}

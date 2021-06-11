using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace librerías
{
    public class CD_Annetys
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        #region Filtros
        public DataTable FiltroSencillo(string Auxiliar1, string Auxiliar2)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from Annetys where " + Auxiliar1 + " like '" + Auxiliar2 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public DataTable FiltroAvanzado(string Auxiliar1, string Auxiliar2, string Auxiliar3, string Auxiliar4)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from Annetys where " + Auxiliar1 + " like '" + Auxiliar2 + "%' and " + Auxiliar3 + " like '" + Auxiliar4 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        #endregion

        public DataTable Mostrar()
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from Annetys";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public void Insertar(string Categoria, string Nombre, string Descripcion, double Precio, int Cantidad, int Puntaje)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "AgregarAnnetys";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Categoria", Categoria);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();

        }

        public void Editar(string Categoria, string Nombre, string Descripcion, double Precio, int Cantidad, int Puntaje, int IDannetys)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EditarInventario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Categoria", Categoria);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.Parameters.AddWithValue("@IDannetys", IDannetys);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EliminarAnnetys";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDannetys", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
    }
}

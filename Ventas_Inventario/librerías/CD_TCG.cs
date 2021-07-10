using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace librerías
{
    public class CD_TCG
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        #region Filtros
        public DataTable FiltroSencillo(string Auxiliar1, string Auxiliar2)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from TCG where " + Auxiliar1 + " like '" + Auxiliar2 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public DataTable FiltroAvanzado(string Auxiliar1, string Auxiliar2, string Auxiliar3, string Auxiliar4)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from TCG where " + Auxiliar1 + " like '" + Auxiliar2 + "%' and " + Auxiliar3 + " like '" + Auxiliar4 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        #endregion

        public DataTable Mostrar()
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from TCG";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public void Insertar(string Nombre, string Producto, string Descripcion, double Precio,
            int Cantidad, int Puntaje)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "AgregarTCG";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Producto", Producto);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();

        }

        public void Editar(string Nombre, string Producto, string Descripcion, double Precio,
            int Cantidad, int Puntaje, int IDTCG)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EditarTCG";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Producto", Producto);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.Parameters.AddWithValue("@IDTCG", IDTCG);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EliminarTCG";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDTCG", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
    }
}

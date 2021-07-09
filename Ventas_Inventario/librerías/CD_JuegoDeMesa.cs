using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace librerías
{
    public class CD_JuegoDeMesa
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        #region Filtros
        public DataTable FiltroSencillo(string Auxiliar1, string Auxiliar2)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from JuegosDeMesa where " + Auxiliar1 + " like '" + Auxiliar2 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public DataTable FiltroAvanzado(string Auxiliar1, string Auxiliar2, string Auxiliar3, string Auxiliar4)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from JuegosDeMesa where " + Auxiliar1 + " like '" + Auxiliar2 + "%' and " + Auxiliar3 + " like '" + Auxiliar4 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        #endregion

        public DataTable Mostrar()
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from JuegosDeMesa";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }

        public void Insertar(string Nombre, double Precio, int Cantidad, int Puntaje)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "AgregarJuegosDeMesa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();

        }

        public void Editar(string Nombre, double Precio, int Cantidad, int Puntaje, int IDTCG)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EditarJuegosDeMesa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Puntaje", Puntaje);
            comando.Parameters.AddWithValue("@IDJuegosDeMesa", IDTCG);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "EliminarJuegosDeMesa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDJuegosDeMesa", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
    }
}

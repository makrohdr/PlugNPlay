using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace librerías
{
   public class CD_Ventas
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable FiltroSencillo(string Auxiliar1, string Auxiliar2)
        {
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select * from Inventario where " + Auxiliar1 + " like '" + Auxiliar2 + "%'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        
        public DataTable CategoriaL()
        {
            //Llenado de datos sin repeticiones de Combobox Categoria-Libros (Sin condicion)
            comando.Connection = conexion.abriConexion();
            comando.CommandText = "Select distinct Categoria From Inventario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

        

        /*
        public void Autocompletar()
        {
            //procedimiento almacenado
            comando.Connection = conexion.abriConexion();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            comando.CommandText = "Select * From Inventario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            SqlDataAdapter adaptador = new SqlDataAdapter("Select * From Inventario", conexion);
            comando.Connection = conexion.cerrarConexion();
            comando.Parameters.Clear();
        }
        */


    }
}

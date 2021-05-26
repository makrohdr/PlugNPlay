using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace librerías
{
    public class Conexion
    {
        SqlConnection miConexion = new SqlConnection
            (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ControlVentas;user ID=makro;Password=mxclhdr");

        public SqlConnection abriConexion()
        {
            if (miConexion.State == ConnectionState.Closed)
            {
                miConexion.Open();
            }
            return miConexion;
        }

        public SqlConnection cerrarConexion()
        {
            if (miConexion.State == ConnectionState.Open)
            {
                miConexion.Close();
            }
            return miConexion;
        }
    }
}

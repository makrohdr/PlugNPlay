using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using librerías;
using System.Data.SqlClient;

namespace LibreriasNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas OBinventario = new CD_Ventas();
        public DataTable ObCategoriaL()
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.CategoriaL();
            return tabla;
        }
        public DataTable OBNombreL(string Categoria)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.NombreL(Categoria);
            return tabla;
        }
    } 
}

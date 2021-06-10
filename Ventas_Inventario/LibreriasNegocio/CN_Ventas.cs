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

        private CD_Ventas OBVentas = new CD_Ventas();
        //Se obtiene la tabla
        public string[] MostrarCategoriaL(string categoria)
        {
            
            tabla = OBVentas.MostrarCatL();
            return tabla;
        }
    } 
}

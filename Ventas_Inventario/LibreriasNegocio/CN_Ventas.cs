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
        public DataTable OBEditorialL(string Nombre)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.EditorialL(Nombre);
            return tabla;
        }
        public DataTable OBPortadaL(string Nombre)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.PortadaL(Nombre);
            return tabla;
        }
        public DataTable OBVolumenL(string Nombre)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.VolumenL(Nombre);
            return tabla;
        }
        public DataTable OBPrecioL(string Nombre , string Volumen, string Portada)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.PrecioL(Nombre , Volumen, Portada);
            return tabla;
        }
        public DataTable OBPuntajeL(string Nombre, string Volumen, string Portada)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.PrecioL(Nombre, Volumen, Portada);
            return tabla;
        }
    }
} 


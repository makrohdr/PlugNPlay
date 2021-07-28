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
        DataTable tabla = new DataTable();

        //private string pasarInfo;

        public DataTable ObCategoriaL()
        {
            tabla = OBinventario.CategoriaL();
            return tabla;
        }
        public DataTable OBNombreL(string Categoria)
        {
            tabla = OBinventario.NombreL(Categoria);
            return tabla;
        }
        public DataTable OBEditorialL(string Nombre)
        {
            tabla = OBinventario.EditorialL(Nombre);
            return tabla;
        }
        public DataTable OBPortadaL(string Nombre)
        {
            tabla = OBinventario.PortadaL(Nombre);
            return tabla;
        }
        public DataTable OBVolumenL(string Nombre)
        {
            tabla = OBinventario.VolumenL(Nombre);
            return tabla;
        }
        public string precioL(string nombre, string volumen, string portada, string cantidad)
        {
            OBinventario.PrecioL(nombre, volumen, portada, cantidad);

            return OBinventario.PasarInfoPrecioL;
        }
        
        public string Puntaje(string nombre , string volumen, string portada, string cantidad)
        {
            OBinventario.PuntajeL(nombre, volumen, portada, cantidad);
            return OBinventario.PasarInfoPuntajeL;
        }
        

        /*
        public DataTable OBPuntajeL(string Nombre, string Volumen, string Portada)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.PrecioL(Nombre, Volumen, Portada);
            return tabla;
        }
        */
    }
} 


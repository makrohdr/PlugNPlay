using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using librerías;

namespace LibreriasNegocio
{
    public class CN_Inventario
    {
        private CD_Inventario OBinventario = new CD_Inventario();

        public DataTable MostrarIn()
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.Mostrar();
            return tabla;
        }

        public DataTable FiltroNombre(string Aux1)
        {
            DataTable tabla = new DataTable();
            tabla = OBinventario.FiltroNombre(Aux1);
            return tabla;
        }

        public void Insertar(string nombre, string volumen, string portada, string categoria, string editorial, string precio,
            string cantidad, string punataje)
        {
            OBinventario.Insertar(nombre, volumen, portada, categoria, editorial, Convert.ToDouble(precio), 
                int.Parse(cantidad), int.Parse(punataje));
        }

        public void Editar(string nombre, string volumen, string portada, string categoria, string editorial, string precio,
            string cantidad, string punataje, string id)
        {
            OBinventario.Editar(nombre, volumen, portada, categoria, editorial, Convert.ToDouble(precio),
                int.Parse(cantidad), int.Parse(punataje), int.Parse(id));
        }

        public void Eliminar(string id)
        {
            OBinventario.Eliminar(int.Parse(id));
        }
    }
}

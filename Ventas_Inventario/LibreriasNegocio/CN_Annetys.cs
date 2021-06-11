using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using librerías;

namespace LibreriasNegocio
{
    public class CN_Annetys
    {
        private CD_Annetys OBannetysCD = new CD_Annetys();

        #region filtro
        public DataTable FiltroSencillo(string Aux1, string Aux2)
        {
            DataTable tabla = new DataTable();
            tabla = OBannetysCD.FiltroSencillo(Aux1, Aux2);
            return tabla;
        }

        public DataTable FiltroAvanzado(string Aux1, string Aux2, string Aux3, string Aux4)
        {
            DataTable tabla = new DataTable();
            tabla = OBannetysCD.FiltroAvanzado(Aux1, Aux2, Aux3, Aux4);
            return tabla;
        }
        #endregion

        #region basico de la tabla
        public DataTable MostrarAnnetys()
        {
            DataTable tabla = new DataTable();
            tabla = OBannetysCD.Mostrar();
            return tabla;
        }

        public void Insertar(string categoria, string nombre, string descripcion, string precio, string cantidad, string puntaje)
        {
            OBannetysCD.Insertar(categoria, nombre, descripcion, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje));
        }

        public void Editar(string categoria, string nombre, string descripcion, string precio, string cantidad, string puntaje, 
            string id)
        {
            OBannetysCD.Editar(categoria, nombre, descripcion, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje), 
                int.Parse(id));
        }

        public void Eliminar(string id)
        {
            OBannetysCD.Eliminar(int.Parse(id));
        }
        #endregion
    }
}

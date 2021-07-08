using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using librerías;

namespace LibreriasNegocio
{
    public class CN_TCG
    {
        CD_TCG OBtcg_CD = new CD_TCG();

        #region filtro
        public DataTable FiltroSencillo(string Aux1, string Aux2)
        {
            DataTable tabla = new DataTable();
            tabla = OBtcg_CD.FiltroSencillo(Aux1, Aux2);
            return tabla;
        }

        public DataTable FiltroAvanzado(string Aux1, string Aux2, string Aux3, string Aux4)
        {
            DataTable tabla = new DataTable();
            tabla = OBtcg_CD.FiltroAvanzado(Aux1, Aux2, Aux3, Aux4);
            return tabla;
        }
        #endregion

        #region basico de la tabla
        public DataTable MostrarAnnetys()
        {
            DataTable tabla = new DataTable();
            tabla = OBtcg_CD.Mostrar();
            return tabla;
        }

        public void Insertar(string nombre, string producto, string descripcion, string precio, string cantidad, string puntaje)
        {
            OBtcg_CD.Insertar(nombre, producto, descripcion, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje));
        }

        public void Editar(string nombre, string producto, string descripcion, string precio, string cantidad, string puntaje,
            string id)
        {
            OBtcg_CD.Editar(nombre, producto, descripcion, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje),
                int.Parse(id));
        }

        public void Eliminar(string id)
        {
            OBtcg_CD.Eliminar(int.Parse(id));
        }
        #endregion
    }
}

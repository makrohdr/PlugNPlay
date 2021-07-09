using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using librerías;
using System.Data;

namespace LibreriasNegocio
{
    public class CN_JuegosDeMesa
    {
        CD_JuegoDeMesa OBJuegosDeMesa_CD = new CD_JuegoDeMesa();

        #region filtro
        public DataTable FiltroSencillo(string Aux1, string Aux2)
        {
            DataTable tabla = new DataTable();
            tabla = OBJuegosDeMesa_CD.FiltroSencillo(Aux1, Aux2);
            return tabla;
        }

        public DataTable FiltroAvanzado(string Aux1, string Aux2, string Aux3, string Aux4)
        {
            DataTable tabla = new DataTable();
            tabla = OBJuegosDeMesa_CD.FiltroAvanzado(Aux1, Aux2, Aux3, Aux4);
            return tabla;
        }
        #endregion

        #region basico de la tabla
        public DataTable MostrarTCG()
        {
            DataTable tabla = new DataTable();
            tabla = OBJuegosDeMesa_CD.Mostrar();
            return tabla;
        }

        public void Insertar(string nombre, string precio, string cantidad, string puntaje)
        {
            OBJuegosDeMesa_CD.Insertar(nombre, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje));
        }

        public void Editar(string nombre, string precio, string cantidad, string puntaje,
            string id)
        {
            OBJuegosDeMesa_CD.Editar(nombre, int.Parse(precio), int.Parse(cantidad), int.Parse(puntaje),
                int.Parse(id));
        }

        public void Eliminar(string id)
        {
            OBJuegosDeMesa_CD.Eliminar(int.Parse(id));
        }
        #endregion
    }
}

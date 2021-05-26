using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using librerías;

namespace LibreriasNegocio
{
    public class CN_Cliente
    {
        private CD_ConsultaClientes ConsultaClientesOB = new CD_ConsultaClientes();

        public DataTable MostrarCl()
        {
            DataTable tabla = new DataTable();
            tabla = ConsultaClientesOB.Mostrar();
            return tabla;
        }

        public void InsertarCliente (string numero, string apellido, string nombre, string puntaje)
        {
            ConsultaClientesOB.Insertar(numero, apellido, nombre, int.Parse(puntaje));
        }

        public void EditarCliente(string numero, string apellido, string nombre, string puntaje, string IDcliente)
        {
            ConsultaClientesOB.Editar(numero, apellido, nombre, int.Parse(puntaje), int.Parse(IDcliente));
        }

        public void EliminarCliente(string id)
        {
            ConsultaClientesOB.Eliminar(int.Parse(id));
        }
    }
}

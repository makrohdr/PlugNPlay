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

        public void InsertarCliente(string telefono, string redSocial, string contacto, string nombre, 
            string apellido, string puntaje)
        {
            ConsultaClientesOB.Insertar(telefono, redSocial, contacto, nombre, apellido, int.Parse(puntaje));
        }

        public void EditarCliente(string telefono, string redSocial, string contacto, string nombre,
            string apellido, string puntaje, string idCliente)
        {
            ConsultaClientesOB.Editar(telefono, redSocial, contacto, nombre, apellido, int.Parse(puntaje), idCliente);
        }

        public void EliminarCliente(string telefono)
        {
            ConsultaClientesOB.Eliminar(telefono);
        }
    }
}

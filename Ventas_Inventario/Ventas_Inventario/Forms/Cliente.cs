using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriasNegocio;

namespace Ventas_Inventario.Forms
{
    public partial class Cliente : Form
    {
        CN_Cliente clienteOB = new CN_Cliente();
        private string IDcliente = null;
        private bool Editar = false;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            CN_Cliente cliente = new CN_Cliente();
            dataGridView1.DataSource = cliente.MostrarCl();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {
                try
                {
                    clienteOB.InsertarCliente(txtCelular.Text, txtApellido.Text, txtNombre.Text, txtPuntaje.Text);
                    MessageBox.Show("Tus datos se insertaron");
                    MostrarClientes();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo realizar la siguente accion: " + ex);
                }
            }
            //Editar
            if (Editar == true)
            {
                try
                {
                    clienteOB.EditarCliente(txtCelular.Text, txtApellido.Text, txtNombre.Text, txtPuntaje.Text, IDcliente);
                    MessageBox.Show("Tus datos se editaron");
                    MostrarClientes();
                    Limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCelular.Text = dataGridView1.CurrentRow.Cells["Celular"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPuntaje.Text = dataGridView1.CurrentRow.Cells["Puntaje"].Value.ToString();
                IDcliente = dataGridView1.CurrentRow.Cells["IDcliente"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila por editar");
            }
        }

        private void Limpiar()
        {
            txtCelular.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtPuntaje.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDcliente = dataGridView1.CurrentRow.Cells["IDcliente"].Value.ToString();
                if (
                MessageBox.Show("Esta seguro que quiere eliminar a este cliente?", 
                    "Aviso", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha eliminado el registro del cliente.");
                    clienteOB.EliminarCliente(IDcliente);
                }
                else
                {
                    MostrarClientes();
                }
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion.");
            }
        }
    }
}

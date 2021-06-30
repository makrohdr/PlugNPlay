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

        private void Limpiar()
        {
            txtTelefono.Clear();
            txtRedSocial.Items.Clear();
            txtContacto.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPuntaje.Clear();
        }

        //CheckBox para activar el textbox de puntaje.
        private void CBpuntaje_CheckedChanged(object sender, EventArgs e)
        {
            if (CBpuntaje.Checked == true)
            {
                txtPuntaje.Enabled = true;
            }
            else if (CBpuntaje.Checked == false)
            {
                txtPuntaje.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {
                try
                {
                    clienteOB.InsertarCliente(txtTelefono.Text, txtRedSocial.Text, txtContacto.Text, txtNombre.Text, 
                        txtApellido.Text, txtPuntaje.Text);
                    MessageBox.Show("Tus datos se insertaron");
                    MostrarClientes();
                    
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puedieron insertar los datos.");
                }
            }
            //Editar
            if (Editar == true)
            {
                try
                {
                    clienteOB.EditarCliente(txtTelefono.Text, txtRedSocial.Text, txtContacto.Text, txtNombre.Text,
                        txtApellido.Text, txtPuntaje.Text, IDcliente);
                    MessageBox.Show("Tus datos se editaron");
                    MostrarClientes();
                    Limpiar();
                    Editar = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo editar los datos.");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["IDTelefono"].Value.ToString();
                txtRedSocial.Text = dataGridView1.CurrentRow.Cells["RedSocial"].Value.ToString();
                txtContacto.Text = dataGridView1.CurrentRow.Cells["Contacto"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtPuntaje.Text = dataGridView1.CurrentRow.Cells["Puntaje"].Value.ToString();
                IDcliente = dataGridView1.CurrentRow.Cells["IDTelefono"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila por editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDcliente = dataGridView1.CurrentRow.Cells["IDTelefono"].Value.ToString();
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


        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }

        //Exportar datos
        #region exportar datos
        public void ExportarDatos(DataGridView dataGridView1)
        {
            Microsoft.Office.Interop.Excel.Application ExportarExcel = new Microsoft.Office.Interop.Excel.Application();

            ExportarExcel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                IndiceColumna++;

                ExportarExcel.Cells[1, IndiceColumna] = column.Name;
            }

            int IndiceFila = 0;
            foreach (DataGridViewRow fILA in dataGridView1.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    IndiceColumna++;
                    ExportarExcel.Cells[IndiceFila + 1, IndiceColumna] = fILA.Cells[column.Name].Value;
                }
            }

            ExportarExcel.Visible = true;
        }
        #endregion

        
    }
}

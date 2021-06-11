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
using SpreadsheetLight;


namespace Ventas_Inventario.Forms
{
    public partial class Libros : Form
    {
        CN_Inventario obInventario = new CN_Inventario();
        private string IDinventario = null;
        private bool Editar = false;

        DataTable tabla = new DataTable();

        public Libros()
        {
            InitializeComponent();

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarInventario();
        }

        private void MostrarInventario()
        {
            try
            {
                CN_Inventario inventario = new CN_Inventario();
                dataGridView1.DataSource = inventario.MostrarIn();
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido cargar la base de datos");
            }

        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtVolumen.Clear();
            txtPortada.Clear();
            cbCategoria.Items.Clear();
            cbAuxiliar.Items.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtPuntaje.Clear();
        }
        
        //crear evento en un nevo textbox para lector de barras 
        /*
        if (e.KeyChar == (char) Keys.Enter)
	        {

	        }
        */


        private void FiltroSencillo()
        {
            try
            {
                CN_Inventario filtro = new CN_Inventario();
                dataGridView1.DataSource = filtro.FiltroSencillo(txtFiltro1.Text, txtFiltro2.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FiltroAvanzado()
        {
            try
            {
                CN_Inventario filtro = new CN_Inventario();
                dataGridView1.DataSource = filtro.FiltroAvanzado(txtFiltro1.Text, txtFiltro2.Text, txtFiltro3.Text, txtFiltro4.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Buscar
        private void btsBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro2.Text != "" && txtFiltro4.Text == "" || txtFiltro4.Text != "" && txtFiltro2.Text == "")
                {
                    obInventario.FiltroSencillo(txtFiltro1.Text, txtFiltro2.Text);
                }
                else if (txtFiltro2.Text != "" && txtFiltro4.Text != "")
                {
                    obInventario.FiltroAvanzado(txtFiltro1.Text, txtFiltro2.Text, txtFiltro3.Text, txtFiltro4.Text);
                }

                FiltroSencillo();
                FiltroAvanzado();
            }
            catch (Exception)
            {
                //MessageBox.Show("No se ha podido encontrar un articulo.");
                txtFiltro2.Focus();
            }
        }

        //Regresar a la tabla a la normalidad
        private void btnTabla_Click(object sender, EventArgs e)
        {
            txtFiltro1.Items.Clear();
            txtFiltro2.Clear();
            txtFiltro3.Items.Clear();
            txtFiltro4.Clear();
            MostrarInventario();
        }

        //seleccionar categoria
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem.ToString() == "Comic")
            {
                cbAuxiliar.Items.Add("Panini");
                cbAuxiliar.Items.Add("Kamite");
                cbAuxiliar.Items.Add("Smash");
            }
            else if (cbCategoria.SelectedItem.ToString() == "Manga")
            {
                cbAuxiliar.Items.Add("Panini");
                cbAuxiliar.Items.Add("Kamite");
            }
            else if (cbCategoria.SelectedItem.ToString() == "Libro")
            {

            }
        }
        
        //Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    obInventario.Insertar(txtNombre.Text, txtVolumen.Text, txtPortada.Text, cbCategoria.Text, cbAuxiliar.Text,
                        txtPrecio.Text, txtCantidad.Text, txtPuntaje.Text);
                    MessageBox.Show("Tus datos se insertaron");
                    MostrarInventario();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo realizar la siguente accion: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    obInventario.Editar(txtNombre.Text, txtVolumen.Text, txtPortada.Text, cbCategoria.Text, cbAuxiliar.Text,
                       txtPrecio.Text, txtCantidad.Text, txtPuntaje.Text, IDinventario);
                    MessageBox.Show("Tus datos se editaron");
                    MostrarInventario();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo realizar la siguente accion: " + ex);
                }
            }
        }

        //Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtVolumen.Text = dataGridView1.CurrentRow.Cells["Volumen"].Value.ToString();
                txtPortada.Text = dataGridView1.CurrentRow.Cells["Portada"].Value.ToString();
                cbCategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                cbAuxiliar.Text = dataGridView1.CurrentRow.Cells["Editorial"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtPuntaje.Text = dataGridView1.CurrentRow.Cells["Puntaje"].Value.ToString();
                IDinventario = dataGridView1.CurrentRow.Cells["IDinventario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila por editar");
            }
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDinventario = dataGridView1.CurrentRow.Cells["IDinventario"].Value.ToString();
                if (
                MessageBox.Show("Esta seguro que quiere eliminar a este producto?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha eliminado el registro del producto.");
                    obInventario.Eliminar(IDinventario);
                }
                else
                {
                    MostrarInventario();
                }
                MostrarInventario();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion.");
            }
        }

        //exportar a excel
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

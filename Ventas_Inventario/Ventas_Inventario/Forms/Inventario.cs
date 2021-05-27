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
    public partial class Inventario : Form
    {
        CN_Inventario obInventario = new CN_Inventario();
        private string IDinventario = null;
        private bool Editar = false;
        private string Aux1;

        DataTable tabla = new DataTable();

        public Inventario()
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
        
        
        
        
        private void txtFiltro2_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DefaultView.RowFilter = $"nombre LIKE '{txtFiltro2.Text}%'";
        }
        
        /// <summary>
        /// 
        /// 
        /// </summary>

        private void Limpiar()
        {
            txtNombre.Clear();
            txtVolumen.Clear();
            txtPortada.Clear();
            cbCategoria.SelectedIndex = 0;
            cbAuxiliar.SelectedIndex = 0;
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtPuntaje.Clear();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem.ToString() == "Comic")
            {
                cbAuxiliar.Items.Add("Panini");
                cbAuxiliar.Items.Add("Kamite");
                cbAuxiliar.Items.Add("Smach");
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



        //crear evento en un nevo textbox para lector de barras 
        /*
        if (e.KeyChar == (char) Keys.Enter)
	        {

	        }
        */

        //trabando aquí
        private void FiltroNombre()
        {
            try
            {
                
                CN_Inventario filtro = new CN_Inventario();
                dataGridView1.DataSource = filtro.FiltroNombre(Aux1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btsBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro1.Text == "Nombre")
                {
                    obInventario.FiltroNombre(txtFiltro2.Text);
                    
                }

                FiltroNombre();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido encontrar un articulo.");
                txtFiltro1.Focus();
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

        //no usar, lo coloque por error
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //no sirve
            //obInventario.filtrar(txtFiltro.Text.Trim());
            //MostrarInventario();

            //if (txtFiltro.Text != "")
            //{
            //    dataGridView1.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView1.Rows)
            //    {
            //        r.Visible = false;
            //    }
            //    foreach (DataGridViewRow r in dataGridView1.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if (c.Value.ToString().ToUpper().IndexOf(txtFiltro.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }

            //}
            //else
            //{
            //    MostrarInventario();
            //}
        }
    }
}

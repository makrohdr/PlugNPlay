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
    public partial class JuegosDeMesa : Form
    {
        CN_JuegosDeMesa obJuegosDeMesa_CN = new CN_JuegosDeMesa();
        private string IDJuegosDeMesa = null;
        private bool Editar = false;

        public JuegosDeMesa()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtPuntaje.Clear();
        }

        #region area de busqueda

        #region filtros
        private void FiltroSencillo()
        {
            try
            {
                CN_JuegosDeMesa filtro = new CN_JuegosDeMesa();
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
                CN_JuegosDeMesa filtro = new CN_JuegosDeMesa();
                dataGridView1.DataSource = filtro.FiltroAvanzado(txtFiltro1.Text, txtFiltro2.Text, txtFiltro3.Text, txtFiltro4.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        private void btsBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro2.Text != "" && txtFiltro4.Text == "" || txtFiltro4.Text != "" && txtFiltro2.Text == "")
                {
                    obJuegosDeMesa_CN.FiltroSencillo(txtFiltro1.Text, txtFiltro2.Text);
                }
                else if (txtFiltro2.Text != "" && txtFiltro4.Text != "")
                {
                    obJuegosDeMesa_CN.FiltroAvanzado(txtFiltro1.Text, txtFiltro2.Text, txtFiltro3.Text, txtFiltro4.Text);
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
            MostrarJuegosDeMesa();
        }
        #endregion

        #region area de tabla
        private void MostrarJuegosDeMesa()
        {
            try
            {
                CN_TCG MostrarDatos = new CN_TCG();
                dataGridView1.DataSource = MostrarDatos.MostrarTCG();
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido cargar la base de datos");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    obJuegosDeMesa_CN.Insertar(txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtPuntaje.Text);
                    MessageBox.Show("Tus datos se insertaron");
                    MostrarJuegosDeMesa();
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
                    obJuegosDeMesa_CN.Editar(txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtPuntaje.Text, IDJuegosDeMesa);
                    MessageBox.Show("Tus datos se editaron");
                    MostrarJuegosDeMesa();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo realizar la siguente accion: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtPuntaje.Text = dataGridView1.CurrentRow.Cells["Puntaje"].Value.ToString();
                IDJuegosDeMesa = dataGridView1.CurrentRow.Cells["IDJuegosDeMesa"].Value.ToString();
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
                IDJuegosDeMesa = dataGridView1.CurrentRow.Cells["IDTCG"].Value.ToString();
                if (
                MessageBox.Show("Esta seguro que quiere eliminar a este producto?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha eliminado el registro del producto.");
                    obJuegosDeMesa_CN.Eliminar(IDJuegosDeMesa);
                }
                else
                {
                    MostrarJuegosDeMesa();
                }
                MostrarJuegosDeMesa();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion.");
            }
        }
        #endregion

        #region area de exportar datos
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }

        //Exportar datos
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

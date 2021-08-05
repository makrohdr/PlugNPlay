using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriasNegocio;

namespace Ventas_Inventario.Forms
{
    public partial class Venta : Form
    {
        //Variables para Libro
        string CategoriaL;
        string NombreL;

        public Venta()
        {
            
            InitializeComponent();
            
        }

        #region Libro

        #region metodos
        private void ComboboxCategoriaL()
        {
            try
            {
                CN_Ventas inventario = new CN_Ventas();
                DataTable dt;

                dt = inventario.ObCategoriaL();

                foreach (DataRow dr in dt.Rows)
                {
                    CbCategoriaL.Items.Add(dr["Categoria"].ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido cargar la base de datos");
            }

        }

        private void ComboboxNombreL()
        {
            CN_Ventas inventario = new CN_Ventas();
            DataTable dt;

            CategoriaL = CbCategoriaL.Text;

            dt = inventario.OBNombreL(CategoriaL);

            foreach (DataRow dr in dt.Rows)
            {
                CbNombreL.Items.Add(dr["Nombre"].ToString());
            }
        }

        private void ComboboxEditorialL()
        {
            CN_Ventas inventario = new CN_Ventas();
            DataTable dt;

            NombreL = CbNombreL.Text;

            dt = inventario.OBEditorialL(NombreL);

            foreach (DataRow dr in dt.Rows)
            {
                CbEditorialL.Items.Add(dr["Editorial"].ToString());
            }
        }

        private void ComboboxPortadaL()
        {
            CN_Ventas inventario = new CN_Ventas();
            DataTable dt;

            NombreL = CbNombreL.Text;

            dt = inventario.OBPortadaL(NombreL);

            foreach (DataRow dr in dt.Rows)
            {
                CbPortadaL.Items.Add(dr["Portada"].ToString());
            }
        }

        private void ComboboxVolumenL()
        {
            CN_Ventas inventario = new CN_Ventas();
            DataTable dt;

            NombreL = CbNombreL.Text;

            dt = inventario.OBVolumenL(NombreL);
        
            foreach (DataRow dr in dt.Rows)
            {
                CbVolumenL.Items.Add(dr["Volumen"].ToString());
            }
        }

        private void LabelPrecioL()
        {
            CN_Ventas inventario = new CN_Ventas();
            
            lblPrecioL.Text = 
                "$" + inventario.precioL(CbNombreL.Text, CbVolumenL.Text, CbPortadaL.Text, nuCantidadL.Text);
        }

        private void LabelPuntaje()
        {
            CN_Ventas inventario = new CN_Ventas();

            lblPuntajeL.Text =
                inventario.Puntaje(CbNombreL.Text, CbVolumenL.Text, CbPortadaL.Text, nuCantidadL.Text);
        }

        private void LlenarListaL()
        {
            string NombreL = CbNombreL.Text, CantidadL = nuCantidadL.Text,VolumenL = "Volumen: " + CbVolumenL.Text, PrecioL = lblPrecioL.Text, PuntajeL = lblPuntajeL.Text;
            //string PrecioOperacionL = lblPrecioL.Text.Substring(1);
            double SumaPrecio = 0, SumaPuntaje = 0; 
            if (CbAreaVenta.SelectedIndex == 0)
            {
                
                
                ListViewItem ListaL = new ListViewItem(NombreL);
                ListaL.SubItems.Add(VolumenL);
                ListaL.SubItems.Add(CantidadL);
                ListaL.SubItems.Add(PrecioL);
                ListaL.SubItems.Add(PuntajeL);
                ListVentas.Items.Add(ListaL);
            }

            foreach (ListViewItem ListaL in ListVentas.Items) 
            {
                SumaPrecio += double.Parse(ListaL.SubItems[3].Text.Substring(1));
                SumaPuntaje += double.Parse(ListaL.SubItems[4].Text);
            }

            
            lblTotalPrecio.Text = "$" + SumaPrecio.ToString();
            lblTotalPuntaje.Text = SumaPuntaje.ToString();

        }
        #endregion

        #region comboBox, TextBox, Label, etc...
        private void CbCategoriaL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbNombreL.Items.Clear();
            if (CategoriaL != "")
            {
                ComboboxNombreL();
            }
        }

        private void CbEditorialL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbPortadaL.Items.Clear();
            if (NombreL != "")
            {
                ComboboxPortadaL();
            }
        }

        private void CbNombreL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbEditorialL.Items.Clear();
            if (NombreL != "")
            {
                ComboboxEditorialL();
            }


        }

        private void CbPortadaL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbVolumenL.Items.Clear();
            if (NombreL != "")
            {
                ComboboxVolumenL();
            }
        }
        //Hace funcionar a los label de precio y puntaje
        private void nuCantidadL_Click(object sender, EventArgs e)
        {
            LabelPrecioL();
            LabelPuntaje();
        }

        private void CheckClienteL_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckClienteL.Checked)
            {
                lblTextoClienteL.Show();
                txtClienteL.Show();

            }
            else
            {
                lblTextoClienteL.Hide();
                txtClienteL.Hide();
            }
        }

        private void CheckPinaL_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPinaL.Checked)
            {
                lblPina.Show();
                txtPina.Show();

            }
            else
            {
                lblPina.Hide();
                txtPina.Hide();
            }
        }
        //No se usa, borrar
        private void CbVolumenL_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        //No se usa, borrar
        private void txtCantidadL_TextChanged(object sender, EventArgs e)
        {
           
        }
        //No se usa, borrar
        private void nuCantidadL_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        private void Venta_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'dBplugYplayDataSet.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.dBplugYplayDataSet.Inventario);

            
            GroupJuegosMesa.Hide();
            GroupLibros.Hide();
            GroupTCG.Hide();
            GroupAnnetys.Hide();
         
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecioL.Text = (0).ToString("C");
            lblPrecioA.Text = (0).ToString("C");
            lblPrecioT.Text = (0).ToString("C");
            lblPrecioJ.Text = (0).ToString("C");
            lblPuntajeL.Text = (0).ToString("");
            lblPuntajeA.Text = (0).ToString("");
            lblPuntajeT.Text = (0).ToString("");
            lblPuntajeJ.Text = (0).ToString("");
            
            
        }

        #region Area Ventas seleccion
        private void CbAreaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seccion de Libros
            if (CbAreaVenta.SelectedIndex == 0)
            {
                GroupLibros.Show();
                GroupLibros.Location = new Point(12, 72);

                GroupJuegosMesa.Hide();
                GroupTCG.Hide();
                GroupAnnetys.Hide();
                ComboboxCategoriaL();

                CheckClienteL.Checked = false;
                lblTextoClienteL.Hide();
                txtClienteL.Hide();
                
                CheckPinaL.Checked = false;
                lblPina.Hide();
                txtPina.Hide();
            }

            if (CbAreaVenta.SelectedIndex == 1)
            {
                GroupAnnetys.Show();
                GroupAnnetys.Location = new Point(12, 72);
                GroupJuegosMesa.Hide();
                GroupLibros.Hide();
                GroupTCG.Hide();
                CbCategoriaL.Items.Clear();
                CbNombreL.Items.Clear();
                CbEditorialL.Items.Clear();
            }
            if (CbAreaVenta.SelectedIndex == 2)
            {
                GroupTCG.Show();
                GroupTCG.Location = new Point(12, 72);
                GroupLibros.Hide();
                GroupJuegosMesa.Hide();
                GroupAnnetys.Hide();
                CbCategoriaL.Items.Clear();
                CbNombreL.Items.Clear();
                CbEditorialL.Items.Clear();
            }
            if (CbAreaVenta.SelectedIndex == 3)
            {
                GroupJuegosMesa.Show();
                GroupJuegosMesa.Location = new Point(12, 72);
                GroupTCG.Hide();
                GroupLibros.Hide();
                GroupAnnetys.Hide();
                CbCategoriaL.Items.Clear();
                CbNombreL.Items.Clear();
                CbEditorialL.Items.Clear();
            }

        }
        #endregion

        #region BtnGuardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
           
           /* 
            if (CbAreaVenta.SelectedIndex > 0 && CbAreaVenta.SelectedIndex < 3)
            {
                MessageBox.Show("Debe de seleccionar un Area de ventas...!!!");
            }

            if (txtNombreJ.Text == "" && CbNombreL.Text == "" && txtNombreA.Text == "" && txtProductoT.Text == "")
            {
                MessageBox.Show("Debe de seleccionar un Producto...!!!");
            }

            if (!CheckClienteA.Checked && !CheckClienteJ.Checked && !CheckClienteT.Checked && !CheckClienteL.Checked)
            {
                if (txtClienteL.Text == "" && txtClienteA.Text == "" && txtClienteT.Text == "" && txtClienteJ.Text == "")
                MessageBox.Show("Favor de ingresar el numero de telefono del cliente...!!!");
            }
           */

            LlenarListaL();
        }
        #endregion

        
    }
}


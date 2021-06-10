﻿using System;
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
        public Venta()
        {
            InitializeComponent();
        }

      
        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBplugYplayDataSet.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.dBplugYplayDataSet.Inventario);

            GroupJuegosMesa.Hide();
            GroupLibros.Hide();
            GroupTCG.Hide();
            GroupAnnetys.Hide();
            lblTextoClienteA.Hide();
            lblTextoClienteL.Hide();
            lblTextoClienteJ.Hide();
            lblTextoClienteT.Hide();
            txtClienteA.Hide();
            txtClienteL.Hide();
            txtClienteJ.Hide();
            txtClienteT.Hide();
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

        private void CbAreaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbAreaVenta.SelectedIndex == 0)
            {
                GroupLibros.Show();
                GroupLibros.Location = new Point(12, 72);
                GroupJuegosMesa.Hide();
                GroupTCG.Hide();
                GroupAnnetys.Hide();
                

            }
            if (CbAreaVenta.SelectedIndex == 1)
            {
                GroupAnnetys.Show();
                GroupAnnetys.Location = new Point(12, 72);
                GroupJuegosMesa.Hide();
                GroupLibros.Hide();
                GroupTCG.Hide();

            }
            if (CbAreaVenta.SelectedIndex == 2)
            {
                GroupTCG.Show();
                GroupTCG.Location = new Point(12, 72);
                GroupLibros.Hide();
                GroupTCG.Hide();
                GroupAnnetys.Hide();
            }
            if (CbAreaVenta.SelectedIndex == 3)
            {
                GroupJuegosMesa.Show();
                GroupJuegosMesa.Location = new Point(12, 72);
                GroupJuegosMesa.Hide();
                GroupLibros.Hide();
                GroupAnnetys.Hide();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
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
        }
            
        }
    }


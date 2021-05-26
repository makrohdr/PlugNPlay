using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlugnPlayTest2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoProducto : ContentPage
    {

        SqlConnection miconexion = new SqlConnection
         (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Plug&Play;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void BtnIdentificar_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Se agrego el producto en Inventario Jorge","Ok");
           /* if (!string.IsNullOrEmpty(txtCat.Text) && !string.IsNullOrEmpty(txtNom.Text) && !string.IsNullOrEmpty(txtCan.Text) && !string.IsNullOrEmpty(txtVen.Text) && !string.IsNullOrEmpty(txtInf.Text))
            {
                miconexion.Open();
                SqlCommand cmd = miconexion.CreateCommand();
                cmd.CommandText =
                    "Insert into Jazmin values('"
                    + txtCat.Text + " ',' "
                    + txtNom.Text + " ',' "
                    + int.Parse(txtCan.Text) + " ',' "
                    + int.Parse(txtVen.Text) + " ',' "
                    + txtInf.Text + "')";
                cmd.ExecuteNonQuery();
                miconexion.Close();


            }
            */




        }

        private void btnAgregarJorge_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Favor de no dejar campos vacios", "Ok");
        }
    }
}
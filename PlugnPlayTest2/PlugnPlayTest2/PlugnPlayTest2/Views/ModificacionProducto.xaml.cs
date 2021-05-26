using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlugnPlayTest2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModificacionProducto : ContentPage
    {
        public ModificacionProducto()
        {
            InitializeComponent();
            InvPicker.Items.Add("Inventario Jorge");
            InvPicker.Items.Add("Inventario Jazmin");
        }

        private void BtnIdentificar_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Dato modificado", "Ok");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlugnPlayTest2.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateralViewMaster : ContentPage
    {
        public ListView ListView;

        public MenuLateralViewMaster()
        {
            InitializeComponent();

            BindingContext = new MenuLateralViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenuLateralViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuLateralViewMenuItem> MenuItems { get; set; }

            public MenuLateralViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuLateralViewMenuItem>(new[]
                {
                    new MenuLateralViewMenuItem { Id = 0, Title = "Inventario Jorge", TargetType = typeof(Views.InventarioJorge)},
                    new MenuLateralViewMenuItem { Id = 0, Title = "Inventario Jasmin", TargetType = typeof(Views.InventarioJasmin)},
                    new MenuLateralViewMenuItem { Id = 0, Title = "Nuevo Producto", TargetType = typeof(Views.NuevoProducto)},
                    new MenuLateralViewMenuItem { Id = 0, Title = "Modificar Producto", TargetType = typeof(Views.ModificacionProducto)},
                    new MenuLateralViewMenuItem { Id = 0, Title = "Eliminar Producto", TargetType = typeof(Views.EliminarProducto)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
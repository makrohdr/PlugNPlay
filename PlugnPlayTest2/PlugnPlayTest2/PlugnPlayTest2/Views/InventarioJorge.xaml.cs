using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfDataGrid.XForms;

namespace PlugnPlayTest2.Views
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InventarioJorge : ContentPage
    {
        /*
        SfDataGrid sfGrid;
        SqlConnection miconexion = new SqlConnection
                (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Plug&Play;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public InventarioJorge()
        {
            InitializeComponent();
            sfGrid = new SfDataGrid();
            // sfGrid.ItemsSource = miconexion.Getitems();
            sfGrid.ColumnSizer = ColumnSizer.Star;
        }

        */
        public InventarioJorge()
        {
            InitializeComponent();
        }
    }
}
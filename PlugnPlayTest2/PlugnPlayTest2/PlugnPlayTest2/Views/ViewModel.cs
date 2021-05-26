using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlugnPlayTest2.Views
{
    public class ViewModel
    {
        
        public ObservableCollection<OrderInfo> OrdersInfo { get; set; }

        public ViewModel()
        {
            this.OrdersInfo = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }

        private void GenerateOrders()
        {
            OrdersInfo.Add(new OrderInfo(1,"Juegos de Mesa", "Jenga", 50, 10 , "Jenga BOOM" ));
            OrdersInfo.Add(new OrderInfo(2,"Juegos de Mesa", "Pictionary", 55, 10, "Pictionary air"));
            OrdersInfo.Add(new OrderInfo(3,"Juegos de Mesa", "Monopoly", 12, 30, "Monopoly Game of thrones"));
            OrdersInfo.Add(new OrderInfo(4,"Juegos de Mesa", "Ajedrez", 32, 56, "Ajedrez Harry Potter"));
            OrdersInfo.Add(new OrderInfo(5,"Juegos de Mesa", "Uno", 10, 78, "Uno"));
            OrdersInfo.Add(new OrderInfo(7,"Manga", "My Hero Academia", 2, 25, "Volumen 7"));
            OrdersInfo.Add(new OrderInfo(8,"Manga", "My Hero Academia", 6, 78, "Volumen 2"));
            OrdersInfo.Add(new OrderInfo(9,"Manga", "Dragon Ball Z", 4, 116, "Volumen 65"));
            OrdersInfo.Add(new OrderInfo(10,"Comic", "Scott Pilgrim", 5, 7, "Issue #26"));
            OrdersInfo.Add(new OrderInfo(11,"VideoJuego", "Super Mario Galaxy", 3, 0, "Nintendo Wii"));
        }
    }
}

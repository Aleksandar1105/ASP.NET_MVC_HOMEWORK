using PizzaApp.Models;

namespace PizzaApp
{
    public class OrderListDb
    {
        public static List<Order> Orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 800 },
            new Order { OrderId = 2, CustomerName = "Jane Smith", TotalAmount = 900 },
            new Order { OrderId = 3, CustomerName = "Alice Johnson", TotalAmount = 750 }
        };

    }
}

using WarehouseManagementSystem.Business;
using WarehouseManagementSystem.Domain;

var order = new Order
{
    LineItems = new[] {
         new  Item{Name ="PS1", Price = 50},
         new  Item{Name ="PS2", Price = 60},
         new  Item{Name ="PS3", Price = 40},
         new  Item{Name ="PS4", Price = 70},
    }
};
var isReadyForShipment = (Order order) =>
{
    return order.IsReadyForShipment;
};

var processor = new OrderProcessor
{
    OnOrderIntitilize = isReadyForShipment
};

var onCompleted = (Order order) =>
{
    Console.WriteLine($"Processed {order.OrderNumber}");
};

processor.Process(order, onCompleted);

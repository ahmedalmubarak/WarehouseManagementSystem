using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{

    public class OrderProcessor
    {
        // public delegate bool OrderIntitilize(Order order);
        // public delegate void ProccessCompleted(Order order);
        public Func<Order, bool> OnOrderIntitilize { get; set; }
        private void Initialize(Order order)
        {
            if (OnOrderIntitilize?.Invoke(order) == false)
            {
                throw new Exception($"Couldn't proccess {order.OrderNumber}");
            }

        }

        public void Process(Order order, Action<Order> OnComplete)
        {
            // Run some code..

            Initialize(order);
            OnComplete?.Invoke(order);

            // How do I produce a shipping label?
        }
    }
}
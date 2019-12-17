using System;

namespace DistributedStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int StorageId { get; set; }

        public Order(int id, DateTime orderDate, int clientId, int productId, int quantity, int storageId)
        {
            Id = id;
            OrderDate = orderDate;
            ClientId = clientId;
            ProductId = productId;
            Quantity = quantity;
            StorageId = storageId;
        }
    }
}

namespace DistributedStore.Models
{
    public class ProductStorage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string LocationCode { get; set; }
        public int Quantity { get; set; }

        public ProductStorage(int id, int productId, string locationCode, int quantity)
        {
            Id = id;
            ProductId = productId;
            LocationCode = locationCode;
            Quantity = quantity;
        }
    }
}

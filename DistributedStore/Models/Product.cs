namespace DistributedStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitCost { get; set; }
        public int CategoryId { get; set; }

        public Product(int id, string name, int unitCost, int categoryId)
        {
            Id = id;
            Name = name;
            UnitCost = unitCost;
            CategoryId = categoryId;
        }
    }
}

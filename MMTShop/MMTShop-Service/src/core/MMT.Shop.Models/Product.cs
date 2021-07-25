namespace MMT.Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public int CategoryId { get; set; }
        
        public string Sku { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public bool IsFeature { get; set; }
    }
}
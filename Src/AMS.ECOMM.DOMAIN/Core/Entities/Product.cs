namespace AMS.ECOMM.DOMAIN.Core.Entities
{
    public class Product
    {
        
        public Product(){ }
        
        public Product(Guid id, string description, decimal price, Guid colorid, Guid categoryid, bool isactive)
        {
          Id = id;
          Description = description;
          Price = price;
          ColorId = colorid;
          CategoryId = categoryid;
          IsActive = isactive;
        }

        public Guid Id {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public Guid ColorId {get; set;}
        public Guid CategoryId {get; set;}
        public bool IsActive{get; set;}
        
        
    }
}
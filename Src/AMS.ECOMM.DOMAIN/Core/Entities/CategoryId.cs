namespace AMS.ECOMM.DOMAIN.Core.Entities
{
    public class CategoryId
    {
        public CategoryId(){}

        public CategoryId(Guid id, string description)
        {
            Id = id;
            Description = description;
        }
        
        
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
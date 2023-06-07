namespace AMS.ECOMM.DOMAIN.Core.Entities
{
    public class ColorId
    {
        public ColorId(){}

        public ColorId(Guid id, string description, bool isactive)
        {
            Id = id;
            Description = description;
            IsActive = isactive;
        }
        
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive {get; set;}
    }
}

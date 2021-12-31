using Core.Entities.Abstracts;

namespace Core.Entities.Concretes
{
    public interface Shop:IEntity
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}

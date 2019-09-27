using ChubbRestaurantChain.Core.Entities.Interfaces;

namespace ChubbRestaurantChain.Core.Entities
{
    public class MenuItem : ISingleEntity
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int PortionsPerItem { get; set; }
    }
}

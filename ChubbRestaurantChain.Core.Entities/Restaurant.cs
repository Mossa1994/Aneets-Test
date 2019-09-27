using ChubbRestaurantChain.Core.Entities.Interfaces;

namespace ChubbRestaurantChain.Core.Entities
{
    public class Restaurant : ISingleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}

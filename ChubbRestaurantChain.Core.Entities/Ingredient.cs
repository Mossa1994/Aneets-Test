using ChubbRestaurantChain.Core.Entities.Interfaces;

namespace ChubbRestaurantChain.Core.Entities
{
    public class Ingredient : ISingleEntity
    {
        public int Id { get; set; }
        public string Item { get; set; }
    }
}

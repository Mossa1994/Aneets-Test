using ChubbRestaurantChain.Core.Entities.Interfaces;

namespace ChubbRestaurantChain.Core.Entities
{
    public class MenuItemIngredient : ISingleEntity
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
    }
}

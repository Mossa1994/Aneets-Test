using ChubbRestaurantChain.Core.Entities;

namespace ChubbRestaurantChain.Core.Repository.Intefaces
{
    public interface IRepositories
    {
        ISingleEntityReadRepository<ClientOrder> ClientOrderRepository { get; }
        ISingleEntityReadRepository<Ingredient> IngredientRepository { get; }
        ISingleEntityReadRepository<MenuItem> MenuItemRepository { get; }
        ISingleEntityReadRepository<MenuItemIngredient> MenuItemIngredientRepository { get; }
        ISingleEntityReadRepository<Restaurant> RestaurantRepository { get; }

    }
}

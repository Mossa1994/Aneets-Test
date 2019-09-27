using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Intefaces;

namespace ChubbRestaurantChain.Core.Repository
{
    public class Repositories : IRepositories
    {
        public Repositories(ISingleEntityReadRepository<ClientOrder> clientOrderRepository, ISingleEntityReadRepository<Ingredient> ingredientRepository, ISingleEntityReadRepository<MenuItem> menuItemRepository,
            ISingleEntityReadRepository<MenuItemIngredient> menuItemIngredientRepository, ISingleEntityReadRepository<Restaurant> restaurantRepository)
        {
            ClientOrderRepository = clientOrderRepository;
            IngredientRepository = ingredientRepository;
            MenuItemRepository = menuItemRepository;
            MenuItemIngredientRepository = menuItemIngredientRepository;
            RestaurantRepository = restaurantRepository;
        }

        public ISingleEntityReadRepository<ClientOrder> ClientOrderRepository { get; private set; }

        public ISingleEntityReadRepository<Ingredient> IngredientRepository { get; private set; }

        public ISingleEntityReadRepository<MenuItem> MenuItemRepository { get; private set; }

        public ISingleEntityReadRepository<MenuItemIngredient> MenuItemIngredientRepository { get; private set; }

        public ISingleEntityReadRepository<Restaurant> RestaurantRepository { get; private set; }
    }
}

using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository
{
    public class MenuItemIngredientRepository : SingleEntityReadRepositoryBase<MenuItemIngredient>
    {
        public MenuItemIngredientRepository(IEnumerable<MenuItemIngredient> repository) : base(repository) { }
    }
}

using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository
{
    public class IngredientRepository : SingleEntityReadRepositoryBase<Ingredient>
    {
        public IngredientRepository(IEnumerable<Ingredient> repository) : base(repository) { }
    }
}

using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository
{
    public class RestaurantRepository : SingleEntityReadRepositoryBase<Restaurant>
    {
        public RestaurantRepository(IEnumerable<Restaurant> repository) : base(repository) { }
    }
}

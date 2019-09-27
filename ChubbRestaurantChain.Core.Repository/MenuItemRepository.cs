using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository
{
    public class MenuItemRepository : SingleEntityReadRepositoryBase<MenuItem>
    {
        public MenuItemRepository(IEnumerable<MenuItem> repository) : base(repository) { }
    }
}

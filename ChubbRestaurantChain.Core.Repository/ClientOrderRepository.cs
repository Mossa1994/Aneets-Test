using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Repository
{
    public class ClientOrderRepository : SingleEntityReadRepositoryBase<ClientOrder>, ISingleEntityReadRepository<ClientOrder>
    {
        public ClientOrderRepository(IEnumerable<ClientOrder> repository) : base(repository) { }
    }
}

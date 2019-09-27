using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Tests.TestData;

namespace ChubbRestaurantChain.Reports.Tests.FakeRepositories
{
    public class FakeClientOrderRepository : SingleEntityReadRepositoryBase<ClientOrder>, ISingleEntityReadRepository<ClientOrder>
    {
        public FakeClientOrderRepository() : base(ClientOrderTestData.GetData()) { }
    }
}

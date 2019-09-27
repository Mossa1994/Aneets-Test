using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Tests.TestData;

namespace ChubbRestaurantChain.Reports.Tests.FakeRepositories
{
    public class FakeMenuItemRepository : SingleEntityReadRepositoryBase<MenuItem>, ISingleEntityReadRepository<MenuItem>
    {
        public FakeMenuItemRepository() : base(MenuItemTestData.GetData()) { }
    }
}

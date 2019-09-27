using ChubbRestaurantChain.Core.Entities;
using ChubbRestaurantChain.Core.Repository.Bases;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Tests.TestData;

namespace ChubbRestaurantChain.Reports.Tests.FakeRepositories
{
    public class FakeIngredientRepository : SingleEntityReadRepositoryBase<Ingredient>, ISingleEntityReadRepository<Ingredient>
    {
        public FakeIngredientRepository() : base(IngredientTestData.GetData()) { }
    }
}

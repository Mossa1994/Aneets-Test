using ChubbRestaurantChain.Core.Entities;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Tests.TestData
{
    public static class IngredientTestData
    {
        public static List<Ingredient> GetData()
        {
            var data = new List<Ingredient>()
            {
                new Ingredient()
                {
                    Id = 1,
                    Item = "Eggs"
                }
            };

            return data;
        }
    }
}

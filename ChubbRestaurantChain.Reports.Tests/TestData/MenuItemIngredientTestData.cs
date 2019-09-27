using ChubbRestaurantChain.Core.Entities;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Tests.TestData
{
    public static class MenuItemIngredientTestData
    {
        public static List<MenuItemIngredient> GetData()
        {
            var data = new List<MenuItemIngredient>()
            {
                new MenuItemIngredient()
                {
                    Id = 1,
                    MenuItemId = 1,
                    IngredientId = 1,
                    Quantity = 3
                }
            };

            return data;
        }
    }
}

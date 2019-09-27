using ChubbRestaurantChain.Core.Entities;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Tests.TestData
{
    public static class MenuItemTestData
    {
        public static List<MenuItem> GetData()
        {
            var data = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id = 1,
                    Item = "Tiramisu",
                    PortionsPerItem = 8
                },
                new MenuItem()
                {
                    Id = 2,
                    Item = "Zuppa Inglese",
                    PortionsPerItem = 4
                }
            };

            return data;
        }
    }
}

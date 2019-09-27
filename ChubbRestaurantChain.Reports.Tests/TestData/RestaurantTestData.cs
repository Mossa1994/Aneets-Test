using ChubbRestaurantChain.Core.Entities;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Tests.TestData
{
    public static class RestaurantTestData
    {
        public static List<Restaurant> GetData()
        {
            var data = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name = "Le Beccherie",
                    Location = "London Bridge"
                },
                new Restaurant()
                {
                    Id = 2,
                    Name = "Vetturino",
                    Location = "St Pauls"
                }
            };

            return data;
        }
    }
}

using ChubbRestaurantChain.Core.Entities;
using System;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Reports.Tests.TestData
{
    public static class ClientOrderTestData
    {
        public static List<ClientOrder> GetData()
        {
            var data = new List<ClientOrder>();

            var id = 1;

            for (var day = 5; day <= 25; day++)
            {
                data.Add(new ClientOrder()
                {
                    Id = id,
                    RestuarantId = 1,
                    MenuItemId = 1,
                    NumOfPortions = 5,
                    OrderDateTime = new DateTime(2018, 11, day)
                });
                id++;
            }

            for (var day = 5; day <= 25; day++)
            {
                data.Add(new ClientOrder()
                {
                    Id = id,
                    RestuarantId = 1,
                    MenuItemId = 1,
                    NumOfPortions = 10,
                    OrderDateTime = new DateTime(2018, 12, day)
                });
                id++;
            }

            for (var day = 5; day <= 25; day++)
            {
                data.Add(new ClientOrder()
                {
                    Id = id,
                    RestuarantId = 2,
                    MenuItemId = 1,
                    NumOfPortions = 7,
                    OrderDateTime = new DateTime(2018, 11, day)
                });
                id++;
            }

            for (var day = 5; day <= 25; day++)
            {
                data.Add(new ClientOrder()
                {
                    Id = id,
                    RestuarantId = 2,
                    MenuItemId = 1,
                    NumOfPortions = 14,
                    OrderDateTime = new DateTime(2018, 12, day)
                });
                id++;
            }

            return data;
        }
    }
}

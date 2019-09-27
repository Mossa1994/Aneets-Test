using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Models;
using System;
using System.Linq;

namespace ChubbRestaurantChain.Reports
{
    public class KeyIngredientToOrderForMenuItemBasedOnPortionsSold
    {
        private IRepositories _repos;

        public KeyIngredientToOrderForMenuItemBasedOnPortionsSold(IRepositories repositories)
        {
            _repos = repositories;
        }

        public SupplierOrderDetails CreateReport(int menuItemId, int ingredientId, int month, int year)
        {
            var menuItem = _repos.MenuItemRepository.GetById(menuItemId);
            var ingredient = _repos.IngredientRepository.GetById(ingredientId).Item;
            
            var resMenuItem = _repos.ClientOrderRepository.Get()
                .Where(x => x.MenuItemId == menuItemId && x.OrderDateTime.Month == month && x.OrderDateTime.Year == year);

            var resPortions = _repos.ClientOrderRepository.Get()
                .Where(x => x.MenuItemId == menuItemId && x.OrderDateTime.Month == month && x.OrderDateTime.Year == year)
                .GroupBy(x => x.RestuarantId)
                .Select(x => new RestaurantPortion()
                {
                    Restaurant = _repos.RestaurantRepository.GetById(x.Key).Name,
                    Portions = x.Sum(y => y.NumOfPortions)
                }).ToList();

            var totalPortions = resMenuItem
                .Sum(x => x.NumOfPortions);

            var ingredientQuantityForMenuItem = _repos.MenuItemIngredientRepository.Get().Where(x => x.MenuItemId == menuItemId && x.IngredientId == ingredientId)
                .FirstOrDefault().Quantity;

            var quantityToOrder = (int)Math.Ceiling((decimal)totalPortions / menuItem.PortionsPerItem * ingredientQuantityForMenuItem);

            var supplierOrderDetails = new SupplierOrderDetails()
            {
                MenuItem = menuItem.Item,
                KeyIngredientToOrderForNextMonth = ingredient,
                RestaurantPortions = resPortions,
                Quantity = quantityToOrder
            };

            return supplierOrderDetails;
        }
    }
}

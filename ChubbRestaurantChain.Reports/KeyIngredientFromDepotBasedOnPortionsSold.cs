using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Models;
using System;
using System.Linq;

namespace ChubbRestaurantChain.Reports
{
    public class KeyIngredientFromDepotBasedOnPortionsSold
    {
        private IRepositories _repos;

        public KeyIngredientFromDepotBasedOnPortionsSold(IRepositories repositories)
        {
            _repos = repositories;
        }

        public FromDepotDetails CreateReport(int restaurantId, int menuItemId, int ingredientId, int month, int year)
        {
            var menuItem = _repos.MenuItemRepository.GetById(menuItemId);
            var ingredient = _repos.IngredientRepository.GetById(ingredientId).Item;

            var totalPortions = _repos.ClientOrderRepository.Get()
                .Where(x => x.RestuarantId == restaurantId && x.MenuItemId == menuItemId && x.OrderDateTime.Month == month && x.OrderDateTime.Year == year)
                .Sum(x => x.NumOfPortions);

            var ingredientQuantityForMenuItem = _repos.MenuItemIngredientRepository.Get().Where(x => x.MenuItemId == menuItemId && x.IngredientId == ingredientId)
                .FirstOrDefault().Quantity;

            var quantityFromDepot = (int)Math.Ceiling((decimal)totalPortions / menuItem.PortionsPerItem * ingredientQuantityForMenuItem);

            var fromDepotDetails = new FromDepotDetails()
            {
                MenuItem = menuItem.Item,
                KeyIngredientFromCentralDepot = ingredient,
                Quantity = quantityFromDepot
            };

            return fromDepotDetails;
        }
    }
}

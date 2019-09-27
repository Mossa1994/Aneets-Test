using ChubbRestaurantChain.Core.Repository;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Tests.FakeRepositories;
using NUnit.Framework;

namespace ChubbRestaurantChain.Reports.Tests
{
    [TestFixture]
    public class KeyIngredientFromDepotBasedOnPortionsSoldTests
    {
        private IRepositories fakeRepos;
        const int mentItemIdForTiramisu = 1;
        const int ingredientIdForEggs = 1;

        [SetUp]
        public void Setup()
        {
            fakeRepos = new Repositories(new FakeClientOrderRepository(),
                new FakeIngredientRepository(),
                new FakeMenuItemRepository(),
                new FakeMenuItemIngredientRepository(),
                new FakeRestaurantRepository());
        }

        [Test]
        public void CreateReport_CalculatesQuantityOfIngredient_ForSpecificMenuItemForSpecifcRestaurant_Expect40()
        {
            // Arrange
            var reporter = new KeyIngredientFromDepotBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(1, 1, 1, 11, 2018);

            // Assert
            Assert.AreEqual(40, result.Quantity);
        }

        [Test]
        public void CreateReport_CalculatesNumOfEggsTheDepotWillSendToARestaurant_ForMakingTiramisuForASpecificMonth_Expect40()
        {
            // Arrange
            const int restaurantId = 1;
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientFromDepotBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(restaurantId, mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual(40, result.Quantity);
        }

        [Test]
        public void CreateReport_SetsTheMenuItemOnTheReport_BasedOnProvidedMenuItemId_ExpectTiramisu()
        {
            // Arrange
            const int restaurantId = 1;
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientFromDepotBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(restaurantId, mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual("Tiramisu", result.MenuItem);
        }

        [Test]
        public void CreateReport_SetsKeyIngredientFromCentralDepot_BasedOnProvidedIngredientId_ExpectEggs()
        {
            // Arrange
            const int restaurantId = 1;
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientFromDepotBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(restaurantId, mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual("Eggs", result.KeyIngredientFromCentralDepot);
        }
    }
}

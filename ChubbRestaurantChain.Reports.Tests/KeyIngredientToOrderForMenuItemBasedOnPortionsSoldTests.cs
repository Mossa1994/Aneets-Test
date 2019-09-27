using ChubbRestaurantChain.Core.Repository;
using ChubbRestaurantChain.Core.Repository.Intefaces;
using ChubbRestaurantChain.Reports.Tests.FakeRepositories;
using NUnit.Framework;
using System.Linq;

namespace ChubbRestaurantChain.Reports.Tests
{
    [TestFixture]
    public class KeyIngredientToOrderForMenuItemBasedOnPortionsSoldTests
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
        public void CreateReport_CalculatesQuantityOfSpecificIngredient_ForSpecificMenuItem_Expect95()
        {
            // Arrange
            var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(1, 1, 11, 2018);

            // Assert
            Assert.AreEqual(95, result.Quantity);
        }

        [Test]
        public void CreateReport_CalculatesNumOfEggsToOrderFromSuppliers_ForMakingTiramisuForAllRestaurantsForASpecificMonth_Expect95()
        {
            // Arrange
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual(95, result.Quantity);
        }

        [Test]
        public void CreateReport_SetsTheMenuItemOnTheReport_BasedOnProvidedMenuItemId_ExpectTiramisu()
        {
            // Arrange
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual("Tiramisu", result.MenuItem);
        }

        [Test]
        public void CreateReport_SetKeyIngredientToOrderForNextMonth_BasedOnProvidedIngredientId_ExpectEggs()
        {
            // Arrange
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

            // Act
            var result = reporter.CreateReport(mentItemIdForTiramisu, ingredientIdForEggs, month, year);

            // Assert
            Assert.AreEqual("Eggs", result.KeyIngredientToOrderForNextMonth);
        }

        //[Test]
        //public void CreateReport_GetListOfRestaurantsAndPortionsForASpecificMenuItemSold_ForSpecificMonth_ExpectDetailsFromTwoRestaurants()
        //{
        //    // Arrange
        //    var mentItemIdForTiramisu = 1;
        //    var ingredientIdForEggs = 1;
        //    var month = 11;
        //    var year = 2018;
        //    var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

        //    // Act
        //    var result = reporter.CreateReport(mentItemIdForTiramisu, ingredientIdForEggs, month, year);

        //    // Assert
        //    Assert.AreEqual("Le Beccherie", result.RestaurantPortions[0].Restaurant);
        //    Assert.AreEqual(105, result.RestaurantPortions[0].Portions);
        //    Assert.AreEqual("Vetturino", result.RestaurantPortions[1].Restaurant);
        //    Assert.AreEqual(147, result.RestaurantPortions[1].Portions);
        //}

        [Test]
        public void CreateReport_GetListOfRestaurantsAndPortionsForASpecificMenuItemSold_ForSpecificMonth_ExpectRestaurantNamesInList()
        {
            // Arrange
            const int month = 11;
            const int year = 2018;
            var reporter = new KeyIngredientToOrderForMenuItemBasedOnPortionsSold(fakeRepos);

            // Act
            var report = reporter.CreateReport(mentItemIdForTiramisu, ingredientIdForEggs, month, year);
            var result = report.RestaurantPortions.Where(x => !string.IsNullOrEmpty(x.Restaurant)).Count();

            // Assert
            Assert.AreEqual(report.RestaurantPortions.Count, result);
        }
    }
}

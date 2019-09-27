using ChubbRestaurantChain.Core.Entities.Interfaces;
using ChubbRestaurantChain.Core.Repository.Bases;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ChubbRestaurantChain.Core.Tests
{
    [TestFixture]
    public class SingleEntityReadRepositoryBaseTests
    {
        private Mock<IEnumerable<ISingleEntity>> singleEntities;
        private Mock<ISingleEntity> singleEntity;
        private Mock<List<ISingleEntity>> dataSource;

        [SetUp]
        public void Setup()
        {
            singleEntities = new Mock<IEnumerable<ISingleEntity>>();
            singleEntity = new Mock<ISingleEntity>();
            dataSource = new Mock<List<ISingleEntity>>();
        }

        [Test]
        public void Get_WithoutData_ExpectNull()
        {
            // Arrange
            var testClass = new Mock<SingleEntityReadRepositoryBase<ISingleEntity>>(null);

            // Act
            var result = testClass.Object.Get();

            // Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Get_WithData_ExpectData()
        {
            // Arrange
            var testClass = new Mock<SingleEntityReadRepositoryBase<ISingleEntity>>(singleEntities.Object);

            // Act
            var result = testClass.Object.Get();

            // Assert
            Assert.AreEqual(singleEntities.Object, result);
        }

        [Test]
        public void GetById_WithoutData_ExpectNull()
        {
            // Arrange
            var testClass = new Mock<SingleEntityReadRepositoryBase<ISingleEntity>>(null);

            // Assert
            Assert.Throws<ArgumentNullException>(() => testClass.Object.GetById(1234));
        }

        //[Test]
        //public void GetById_WithData_ExpectSingleEntity()
        //{
        //    // Arrange
        //    dataSource.Setup(x => x.GetById(1234)).Returns(singleEntity.Object);
        //    var testClass = new Mock<SingleEntityReadRepositoryBase<ISingleEntity>>(dataSource);
        //    testClass.CallBase = true;

        //    // Act
        //    var result = testClass.Object.GetById(1234);

        //    // Assert
        //    Assert.AreEqual(singleEntity.Object, result);
        //}
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest.Data;
using Moq;
using Microsoft.Practices.Unity;
using CodeTest.Repository;
using System.Collections.Generic;

namespace CodeTest.Tests.DataAccess.Repositories
{
    [TestClass]
    public class CodeTestRepositoryTest
    {

        IUnityContainer testContainer;
        Mock<ICodeTestData> mockData;
        CodeTestRepository testRepo;

        [TestInitialize]
        public void InitializeTest()
        {
            testContainer = new UnityContainer();
            mockData = new Mock<ICodeTestData>();
            testContainer.RegisterInstance(mockData.Object);
            testRepo = new CodeTestRepository(mockData.Object);
        }

        [TestMethod()]
        public void GetAllProductsTest()
        {
            //arrange
            var products = new List<Product>()
            {
             new Product() { ProductId = 1, ProductName = "Computer", Price = 500.12M, IsDiscount = true },
             new Product() { ProductId = 2, ProductName = "Surface Pro", Price = 799.99M, IsDiscount = false }
            };

            mockData.Setup(x => x.GetAllProducts()).Returns(products);
            //act
            var result = testRepo.GetAllProducts();

            //assert
            mockData.VerifyAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(products, result);
        }



        [TestMethod()]
        public void GetProductTest()
        {

            var product = new Product() { ProductId = 1, ProductName = "Computer", Price = 500.12M, IsDiscount = true };

            mockData.Setup(x => x.GetProduct(product.ProductId)).Returns(product);

            var result = testRepo.GetProduct(product.ProductId);

            mockData.VerifyAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(product, result);
        }



        [TestMethod()]
        public void GetAllStates()
        {
            var states = new List<State>()
            {
             new State() { StateId = "AL", StateName = "Alabama", Tax = 5 },
             new State() { StateId = "TX", StateName = "Alabama", Tax = 0 },
            };
            mockData.Setup(x => x.GetAllStates()).Returns(states);
            var result = testRepo.GetAllStates();
            mockData.VerifyAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(states, result);
        }



        [TestMethod()]
        public void GetStateTest()
        {

            var state = new State() { StateId = "AL", StateName = "Alabama", Tax = 5 };

            mockData.Setup(x => x.GetState(state.StateId)).Returns(state);

            var result = testRepo.GetState(state.StateId);

            mockData.VerifyAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(state, result);
        }

    }
}

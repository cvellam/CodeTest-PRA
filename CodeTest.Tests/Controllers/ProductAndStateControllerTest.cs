using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Moq;
using CodeTest;
using CodeTest.Controllers;
using CodeTest.Repository;
using CodeTest.Data;
using System.Web.Mvc;
using CodeTest.ViewModels;

namespace CodeTest.Tests.Controllers
{
    [TestClass()]
    public class ProductAndStateControllerTest
    {
        IUnityContainer testContainer;
        Mock<ICodeTestRepository> testRepository;
        ProductAndStateController testController;

        [TestInitialize]
        public void InitializeTest()
        {
            testContainer = new UnityContainer();
            testRepository = new Mock<ICodeTestRepository>();
            testContainer.RegisterInstance(testRepository);
            testController = new ProductAndStateController(testRepository.Object);
        }

        [TestMethod()]
        public void GetStateTest()
        {

            var state = new State() { StateId = "AL", StateName = "Alabama", Tax = 5 };

            testRepository.Setup(x => x.GetState(state.StateId)).Returns(state);

            var result = testController.GetState(state.StateId) as JsonResult;

            testRepository.VerifyAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(state, result.Data);
        }

        [TestMethod()]
        public void IndexTest()
        {
            var products = new List<Product>()
            {
             new Product() { ProductId = 1, ProductName = "Computer", Price = 500.12M, IsDiscount = true },
             new Product() { ProductId = 2, ProductName = "Surface Pro", Price = 799.99M, IsDiscount = false }
            };

            var states = new List<State>()
            {
                new State() { StateId = "AL", StateName = "Alabama", Tax = 5 },
                new State() { StateId = "AK", StateName = "Arkansas", Tax = 5 }
            };

            var viewModel = new ProductAndState() { Products = products, States = states };

            testRepository.Setup(x => x.GetAllStates()).Returns(states);
            testRepository.Verify();
            testRepository.Setup(x => x.GetAllProducts()).Returns(products);
            testRepository.Verify();

            var result = testController.Index() as ActionResult;
            var viewResult = result as ViewResult;
            ProductAndState modelfromController = (ProductAndState) viewResult.Model;

            Assert.AreEqual(viewModel.Products, modelfromController.Products);
            Assert.AreEqual(viewModel.States, modelfromController.States);

        }
    }


}

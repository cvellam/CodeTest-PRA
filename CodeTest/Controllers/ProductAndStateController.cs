using CodeTest.Data;
using CodeTest.Repository;
using CodeTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTest.Controllers
{
    public class ProductAndStateController : Controller
    {

        readonly ICodeTestRepository _repository;

        public ProductAndStateController(ICodeTestRepository repository)
        {
            _repository = repository;
        }

        //public ProductAndStateController()
        //{
        //   _repository = new CodeTestRepository();           

        //}

        public ActionResult Index()
        {
            var products = _repository.GetAllProducts();
            var states = _repository.GetAllStates();

            ProductAndState productAndStateViewModel = new ProductAndState();

            productAndStateViewModel.States = states;
            productAndStateViewModel.Products = products;

            return View(productAndStateViewModel);

        }
        
        public JsonResult GetState(string id)
        {
            return Json(_repository.GetState(id), JsonRequestBehavior.AllowGet);
        }

    }
}
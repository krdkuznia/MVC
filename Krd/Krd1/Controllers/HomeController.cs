using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Krd1.Models;

namespace Krd1.Controllers
{
    public class HomeController : Controller
    {
        private BeerRecipeRepository _repository;

        public HomeController()
        {
            _repository = new BeerRecipeRepository();
        }
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllRecipes()
        {
            return View(_repository.GetAllRecipes());
        }



 
    }
}
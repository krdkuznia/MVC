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
        private readonly BeerRecipeRepository _repository;
        public HomeController()
        {
            _repository = BeerRecipeRepository.Current;
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult AllRecipies()
        {
            ViewBag.Title = "Receptury piwne";
            return View(_repository.GetAllRecipes());
        }

        public ActionResult ShowRecipe(int id)
        {
            ViewBag.Title = "Receptura";
            return View(_repository.GetBeerRecipe(id));
        }

        public ActionResult EditRecipe(int id)
        {
            return View(_repository.GetBeerRecipe(id));
        }

        [HttpPost]
        public ActionResult EditRecipe(BeerRecipe beerRecipe)
        {
         
            return View(beerRecipe);
        }

 
    }
}
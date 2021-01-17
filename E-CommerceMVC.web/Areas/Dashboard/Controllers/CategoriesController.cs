using E_CommerceMVC.Entities;
using E_CommerceMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_CommerceMVC.web.Areas.Dashboard.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Dashboard/Categories
        public ActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            var AllCategories = categoryService.GetAllCategories();
            return View(AllCategories);
        }
        [HttpGet]
        public ActionResult Action()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Action(Category category)
        {
            CategoryService categoryService = new CategoryService();
            categoryService.SaveCategry(category);
            return RedirectToAction("Index");
        }
    }
}
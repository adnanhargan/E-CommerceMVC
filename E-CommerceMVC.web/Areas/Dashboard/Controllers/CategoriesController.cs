using E_CommerceMVC.Entities;
using E_CommerceMVC.Services;
using E_CommerceMVC.web.Areas.Dashboard.ViewModels;
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
        public ActionResult Action(int? ID)
        {
            var model = new CategoryActionViewModels();
            CategoryService categoryService = new CategoryService();
            if (ID.HasValue)
            {
                var category = categoryService.GetCategoryById(ID.Value);
                if (category == null) return HttpNotFound();

                model.ID = category.ID;
                model.Name = category.Name;
                model.Description = category.Description;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(CategoryActionViewModels model)
        {
            CategoryService categoryService = new CategoryService();
            var category = new Category()
            {
                ID = model.ID.HasValue ? model.ID.Value : 0,
                Name = model.Name,
                Description = model.Description
            };
            if(model.ID.HasValue)
            {
            categoryService.UpdateCategory(category);
            }
            else
            {
            categoryService.SaveCategry(category);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Delete(int ID)
        {
            CategoryService categoryService = new CategoryService();

            JsonResult json = new JsonResult();
            var result = categoryService.DeleteCategory(ID);
            json.Data = new { isSuccess = result };
            return json;
        }
    }
}
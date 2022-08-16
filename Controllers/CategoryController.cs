using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class CategoryController :Controller
    {
        private readonly ICategoryService CategoryService;

        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }
        [Authorize(Roles="Administrator")]
        public IActionResult Index()
        {
            var categories= CategoryService.GetCategories();
            return View(categories);
        }
        public IActionResult GetCategories()
        {
            var categories= CategoryService.GetCategories();
            return View(categories);
        }
        public IActionResult GetCategory(int id)
        {
            var thecategory= CategoryService.GetCategoryById(id);
            return View(thecategory);
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
       [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel model)
        {
            CategoryService.CreateCategory(model);
            return RedirectToAction("AdminDashboard","User");
        }
        public IActionResult UpdateCategory(int id)
        {
            var getcategorytoupdate= CategoryService.GetCategoryById(id);
            if(getcategorytoupdate==null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCategory(int id, UpdateCategoryRequestModel model)
        {
           CategoryService.UpdateCategory(id,model);
           return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
           var delete= CategoryService.GetCategoryById(id);
           if(delete==null)
           {
               return NotFound();
           }
          return View(delete);
        }
        [HttpPost,ActionName("DeleteCategory")]
        public IActionResult DeletionSuccess(int id)
        {
            CategoryService.DeleteCategory(id);
            return RedirectToAction("DeletionSuccess");
        }
        public IActionResult DeletionSuccess()
        {
            return View();
        }
        public IActionResult DiscreteIndex()
        {
            var categories= CategoryService.GetCategories();
            return View(categories);
        }
    }
}
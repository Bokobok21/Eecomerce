using Eecomerce.Models.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Eecomerce.Models.Entities;

namespace Eecomerce.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _categoryService.GetCategoryList();
            return View(categoryList);
        }
    }
}

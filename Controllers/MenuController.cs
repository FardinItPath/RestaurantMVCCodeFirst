using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.Services;
using System.Threading.Tasks;

namespace RestaurantMVCCodeFirst.Controllers
{
    [Route("menu")]
    [Authorize(Roles = "Admin")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly ICategoryService _categoryService;

        public MenuController(IMenuService menuService, ICategoryService categoryService)
        {
            _menuService = menuService;
            _categoryService = categoryService;
        }

        [Route("list")]
        public async Task<IActionResult> Index() // Added async
        {
            var menuItems = await _menuService.GetAllMenusAsync(); // Fixed method name
            return View(menuItems);
        }

        [Route("create")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync(); // Fixed method name
            return View();
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(MenuModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _menuService.MenuExistsAsync(model.MenuId))
                {
                    ModelState.AddModelError("", "Menu already exists.");
                    ViewBag.Categories = await _categoryService.GetAllCategoriesAsync(); // Fixed method name
                    return View(model);
                }

                await _menuService.AddMenuAsync(model); // Fixed method name
                return RedirectToAction("Index");
            }
            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync(); // Fixed method name
            return View(model);
        }
    }
}

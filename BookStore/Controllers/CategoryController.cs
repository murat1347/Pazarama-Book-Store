using BookStore.Models;
using BookStore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x => x.CategoryName == p));

            }
            return View(categoryRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.GetT(id);
            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                ID = x.ID,
            };
            return View(ct);
        }

        public IActionResult CategoryUpdate(Category p)
        {

            var x = categoryRepository.GetT(p.ID);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.GetT(id);
            x.Status = false;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}

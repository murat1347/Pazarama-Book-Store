using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace BookStore.ViewComponents
{
    public class CategoryListGet : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categoryList = categoryRepository.TList();
            return View(categoryList);
        }
    }
}

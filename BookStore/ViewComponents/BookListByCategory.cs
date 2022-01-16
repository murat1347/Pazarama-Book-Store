using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.ViewComponents
{
    public class BookListByCategory:ViewComponent
    {
        private ICategoryRepository categoryRepository;

        public BookListByCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke(int id)
        {
            BookRepository bookRepository = new BookRepository();

            var bookList = id == 0 ? bookRepository.TList() : bookRepository.List(x => x.CategoryId == id);
            return View(bookList);
        }
    }
}

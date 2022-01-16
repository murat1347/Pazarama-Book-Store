using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BookStore.ViewComponents
{
    public class BookGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BookRepository bookRepository = new BookRepository();
            var bookList = bookRepository.TList();
            return View(bookList);
        }
    }
}

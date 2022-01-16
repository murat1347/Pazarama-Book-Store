using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BookStore.Context;
using BookStore.Models;
using BookStore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private BookContext c = new BookContext();
        private BookRepository bookRepository = new BookRepository();
        public IActionResult Index(int page = 1)
        {
            BookRepository foodRepository = new BookRepository();
            return View(bookRepository.TList("Category").ToPagedList(page, 3));
        }

        [AllowAnonymous]
        public IActionResult Info(int id)
        {
            var value = c.Books.Where(x => x.Id == id).ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult bookAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.cat = values;
            return View();
        }
        [HttpPost]
        public IActionResult bookAdd(BookAddModel p)
        {
            Book f = new Book();
            if (p.ImageUrl != null)
            {
                var extension = Path.GetExtension(p.ImageUrl.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                f.ImageUrl = newimagename;
            }

            f.Name = p.Name;
            f.Description = p.Description;
            f.Stock = p.Stock;
            f.Price = p.Price;
            f.CategoryId = p.CategoryId;

            bookRepository.TAdd(f);
            return RedirectToAction("Index");
        }

        public IActionResult bookDelete(int id)
        {
            bookRepository.TDelete(new Book { Id = id });
            return RedirectToAction("Index");
        }

        public IActionResult bookGet(int id)
        {
            var x = bookRepository.GetT(id);
            List<SelectListItem> values = (from x1 in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x1.CategoryName,
                                               Value = x1.ID.ToString()
                                           }).ToList();
            ViewBag.cat1 = values;
            Book f = new Book()
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                Description = x.Description,
                ImageUrl = x.ImageUrl

            };
            return View(f);

        }
        [HttpPost]
        public IActionResult bookUpdate(Book p)
        {
            var x = bookRepository.GetT(p.Id);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.ImageUrl = p.ImageUrl;
            x.Description = p.Description;
            x.CategoryId = p.CategoryId;
            bookRepository.TUpdate(x);
            return RedirectToAction("index");
        }

        public IActionResult bookDetail(Book p)
        {
            var value = c.Books.Where(x => x.Id == p.Id).ToList();
            return View(value);
        }
    }
}


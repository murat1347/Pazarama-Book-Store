using System;
using System.Collections.Generic;
using BookStore.Models;

namespace BookStore.Repositories
{
    public class CategoryRepository :GenericRepository<Category>, ICategoryRepository
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookStore.Context;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> List(Expression<Func<Category, bool>> filter);

        List<Category> TList();
        Category GetT(int id);
        void TUpdate(Category category);
        void TAdd(Category category);
    }
}

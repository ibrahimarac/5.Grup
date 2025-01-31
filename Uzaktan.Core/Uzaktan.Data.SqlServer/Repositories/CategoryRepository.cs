﻿using System.Collections.Generic;
using Uzaktan.Core.Domain.Entites;
using Uzaktan.Core.Repositories;

namespace Uzaktan.Data.SqlServer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopContext _context;

        public CategoryRepository()
        {
            _context = new ShopContext();
        }

        public bool AddCategory(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChanges()!=0;
        }

        public bool DeleteCategory(int id)
        {
            var categoryInDb = _context.Categories.Find(id);
            _context.Categories.Remove(categoryInDb);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public bool UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            return _context.SaveChanges() != 0;
        }
    }
}

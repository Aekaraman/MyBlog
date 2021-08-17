using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;

namespace BlogInstance.Views.Shared.Components.CategoryList
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly BlogDbContext _context;
        CategoryRepository categoryRepository;

        public CategoryListViewComponent(BlogDbContext dbContext)
        {
            _context = dbContext;
            categoryRepository = new CategoryRepository(dbContext);
        }
        public IViewComponentResult Invoke()
        {
            List<Category> categories = categoryRepository.GetCategories();

            return View(model: categories);
        }

    }
}

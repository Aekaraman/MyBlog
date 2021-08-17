using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;

namespace BlogInstance.Views.Shared.Components.TopArticleList
{
    public class TopArticleListViewComponent : ViewComponent
    {
        private readonly BlogDbContext _context;
        ArticleRepository articleRepository;

        public TopArticleListViewComponent(BlogDbContext dbContext)
        {
            _context = dbContext;
            articleRepository = new ArticleRepository(dbContext);
        }
        public IViewComponentResult Invoke()
        {
            List<Article> articles = articleRepository.GetTopArticles();

            return View(model: articles);
        }
    }
}

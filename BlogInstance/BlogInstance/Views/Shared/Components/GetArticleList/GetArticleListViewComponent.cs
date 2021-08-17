using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogInstance.Views.Shared.Components.GetArticleList
{
    public class GetArticleListViewComponent:ViewComponent
    {
        private readonly BlogDbContext _context;
        ArticleRepository articleRepository;

        public GetArticleListViewComponent(BlogDbContext dbContext)
        {
            _context = dbContext;
            articleRepository = new ArticleRepository(dbContext);
        }
        public IViewComponentResult Invoke()
        {
            List<Article> articles = articleRepository.GetArticles();

            return View(model: articles);
        }
    }
}

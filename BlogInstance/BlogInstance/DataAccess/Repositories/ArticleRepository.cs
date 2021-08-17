using System;
using System.Collections.Generic;
using System.Linq;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.DataAccess.Repositories
{
    public class ArticleRepository
    {
        BlogDbContext dbContext;
        public ArticleRepository(BlogDbContext blogDb)
        {
            dbContext = blogDb;
        }

        public Article AddArticle(Article article)
        {
            article.ViewsCount = 0;
            article.IsActive = true;
            article.CreatedDate = DateTime.Now;
            article.CommentCount = 0;
            dbContext.Articles.Add(article);
            dbContext.SaveChanges();
            return article;
        }
        public void DeleteArticle(int id)
        {
            Article selected = dbContext.Articles.SingleOrDefault(a => a.ArticleID == id);
            selected.IsActive = false;
            //or remove
            dbContext.SaveChanges();
        }
        public void UpdateArticle(Article article)
        {
            article.IsActive = true;
            article.CreatedDate = DateTime.Now;
            article.ViewsCount = 0;
            dbContext.Articles.Add(article);
            dbContext.SaveChanges();



            //var post = dbContext.Entry(article);
            //post.State = EntityState.Modified;
            //dbContext.SaveChanges();

        }
        public List<Article> SearchArticles(string searchStr)
        {
            List<Article> articles = dbContext.Articles.Where(a => a.Content.Contains(searchStr) || a.Title.Contains(searchStr) || a.User.UserName.Contains(searchStr)).ToList();

            return articles;
        }

        //tüm makaleler
        public List<Article> GetArticles()
        {
            var articleList = dbContext.Articles.ToList();
            return articleList;
        }

        //en çok okunan makaleler
        public List<Article> GetTopArticles()
        {
            var articleList = dbContext.Articles.OrderByDescending(a => a.ViewsCount).Take(6).ToList();
            return articleList;
        }
        public Article GetArticleByID(int id)
        {
            return dbContext.Articles.Find(id);
        }
        
        public void ReadedNote(int id)
        {
            Article article = dbContext.Articles.Where(a => a.ArticleID == id).SingleOrDefault();
           
            //article.ViewsCount++;
            dbContext.SaveChanges();
        }
        public List<Article> ArticleListByint()
        {
            return dbContext.Articles.ToList();
        }
        //public List<ArticleAndCategory> GetArticleOfCategories(int id)
        //{
        //    var articleList = dbContext.ArticleAndCategories.Include(a => a.Category).Include(a => a.Article).Where(k => k.ArticleID == id).ToList();
        //    return articleList;
        //}

        //seçilen makale
        public List<Article> GetArticleOfCategoryByID(int id)
        {
            List<ArticleAndCategory>articleAndCategories= dbContext.ArticleAndCategories.Include(a => a.Category).Include(a => a.Article).Where(k => k.ArticleID == id).ToList();
            List<Article> articles = new List<Article>();
            Article article;
            foreach (var item in articleAndCategories)
            {
                article = new Article();
                article.ArticleID = item.ArticleID;
                article.CreatedDate = item.Article.CreatedDate;
                article.IsActive = item.Article.IsActive;
                article.ModifiedDate = item.Article.ModifiedDate;
                article.Content = item.Article.Content;
                article.ViewsCount = item.Article.ViewsCount;
                article.ThumbNail = item.Article.ThumbNail;
                article.Title = item.Article.Title;

            }
            return articles;
        }
        //kullanıcıya göre makale
        public List<Article> GeArticlesByUser(int id)
        {
            List<Article> articleList = dbContext.Articles.Include(a => a.ArticleID).Where(a => a.User.UserID == id).ToList();
            List<Article> articles = new List<Article>();
            Article article;
            foreach (var item in articleList)
            {
                article = new Article();
                article.ArticleID = item.ArticleID;
                article.CreatedDate = item.CreatedDate;
                article.IsActive = item.IsActive;
                article.ModifiedDate = item.ModifiedDate;
                article.Content = item.Content;
                article.ViewsCount = item.ViewsCount;
                article.ThumbNail = item.ThumbNail;
                article.Title = item.Title;

            }
            return articles;
        }

        public void ArticleAddbyint(Article article)
        {
            dbContext.Articles.Add(article);
            dbContext.SaveChanges();
        }
        public void ArticleRemoveByint(Article article)
        {
            dbContext.Articles.Remove(article);
            dbContext.SaveChanges();
        }
        public void ArticleUpdatebyint(Article article)
        {
            dbContext.Articles.Update(article);
            dbContext.SaveChanges();
        }
    }
}

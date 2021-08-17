using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;
using BlogInstance.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.Controllers
{
    public class ArticlesController : Controller
    {
        
        private readonly BlogDbContext _context;
        CategoryRepository _category;
        ArticleRepository _articleRepository;
        public ArticlesController(BlogDbContext context)
        {
            _context = context;
            _articleRepository = new ArticleRepository(context);
            _category=new CategoryRepository(context);
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var blogDbContext = _context.Articles.Include(a => a.User);
            return View(await blogDbContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.ArticleID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "CreatedByName");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Article article)
        {
            string content = HttpContext.Request.Form["Content"];

            if (ModelState.IsValid)
            {
                article.Content = content;
                _context.Add(article);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "CreatedByName", article.UserID);
            return View(article);
        }
        public ActionResult Read(int id)
        {
            _articleRepository.GetArticleByID(id);
            _articleRepository.ReadedNote(id);
            return View();
        }
        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "CreatedByName", article.UserID);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArticleID,Title,Content,ThumbNail,Date,ViewsCount,CommentCount,UserID,Id,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName")] Article article)
        {
            if (id != article.ArticleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "CreatedByName", article.UserID);
            return View(article);
        }



        public IActionResult AddCategory(int id)
        {
            List<CategoryforArticleViewModel> categories = _category.GetCategories().Select(a => new CategoryforArticleViewModel() { CategoryId = a.CategoryID, CategoryName = a.CategoryName, IsSelected = false }).ToList();
            List<ArticleAndCategory> and = _context.ArticleAndCategories.Where(a => a.ArticleID == id).ToList();


            foreach (var articletoselect in and)
            {
                foreach (var myarticle in categories)
                {
                    if (articletoselect.CategoryID == myarticle.CategoryId)
                    {
                        myarticle.IsSelected = true;
                    }
                }
            }

            CategoryforArticleViewModel categoryforArticle= new CategoryforArticleViewModel();
            //categoryforArticle.categoryfornote = categories;
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(16);
            Response.Cookies.Append("NoteId", id.ToString(), options);
            return View(categoryforArticle);
        }
        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.ArticleID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ArticleID == id);
        }


    }
}

using BlogInstance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace BlogInstance.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogDbContext _blogDb;

        ArticleRepository articleRepository;
        CategoryRepository categoryRepository;
        UserRepository userRepository;
        public HomeController(BlogDbContext blogDb)
        {
            _blogDb = blogDb; 
            articleRepository = new ArticleRepository(blogDb);
            categoryRepository = new CategoryRepository(blogDb);
            userRepository = new UserRepository(blogDb);
        }
        
        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Categories()
        {
            List<Category> categories = categoryRepository.GetCategories();
            return View(categories);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SaveMail(User user)
        {
           
            CookieOptions options = new CookieOptions();
            options.Expires = new DateTimeOffset(DateTime.Now.AddMinutes(5));
            options.Domain = ".bilgeadam.com";
            options.Path = "/home/";

            if (!HttpContext.Request.Cookies.ContainsKey("MailName")
                || HttpContext.Request.Cookies["MailName"] == "")
            {
                HttpContext.Response.Cookies.Append("MailName", user.UserEmail);

            }


            if (!HttpContext.Request.Cookies.ContainsKey("FirstLoginTime")
                || HttpContext.Request.Cookies["FirstLoginTime"] == "")
            {

                HttpContext.Response.Cookies.Append("FirstLoginTime", DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            }

            return RedirectToAction("Index", "Home");

        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("MailName", "");

           
            HttpContext.Response.Cookies.Delete("MailName");
            HttpContext.Response.Cookies.Delete("FirstLoginTime");

            return RedirectToAction("Index");

        }
        //public IActionResult SaveMailName(string mail)
        //{
        //    //session yaz
        //    //HttpContext.Session.SetString("Kullanıcı", userName);
        //    //Cookie yaz


        //    if (!HttpContext.Request.Cookies.ContainsKey("MailName")
        //        || HttpContext.Request.Cookies["MailName"] == "")
        //    {
        //        HttpContext.Response.Cookies.Append("MailName", mail);

        //    }


        //    if (!HttpContext.Request.Cookies.ContainsKey("FirstLoginTime")
        //        || HttpContext.Request.Cookies["FirstLoginTime"] == "")
        //    {

        //        HttpContext.Response.Cookies.Append("FirstLoginTime", DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        //    }

        //    return RedirectToAction("Index");

        //}


        

    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;

namespace BlogInstance.Controllers
{
    public class LoginController : Controller
    {
        private readonly BlogDbContext _blogDb;

        UserRepository userRepository;
        public LoginController(BlogDbContext context)
        {
            _blogDb = context;
            userRepository = new UserRepository(context);

        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        // GET: LoginController
        [HttpPost]
        public  IActionResult Index(User user)
        {
            var value = _blogDb.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail && x.IsActive == true);
            if (value != null)
            {
                AddCookie(value.UserEmail);
                return RedirectToAction("SaveMail", "Home", value);
            }
            return View();
        }
     
        //public ActionResult LoginV2(User user)
        //{
        //    var bilgiler = _blogDb.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail);
        //    if (bilgiler != null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        //public async Task<IActionResult> GirisYap(User user)
        //{
        //    var bilgiler = _blogDb.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail);
        //    if (bilgiler!=null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Email,user.UserEmail)
        //        };
        //        var useridentity=new ClaimsIdentity(claims,"Login");
        //        ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View();
        //}


        private void AddCookie(string email)
        {
            if (Request.Cookies["Email"] == null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Append("Email", email, options);
            }
        }
        private void DeleteCookie() /*(string email)*/
        {
            if (Request.Cookies["Email"] != null)
            {
                Response.Cookies.Delete("Email");
            }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            DeleteCookie();/*(Request.Cookies["Email"])*/
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logoutv2()
        {
            DeleteCookie();
            return RedirectToAction("Logout", "Home");
        }
        public IActionResult ToTheLogin()
        {

            return View();

        }


        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

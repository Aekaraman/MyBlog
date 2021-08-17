using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using BlogInstance.DataAccess;
using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.Controllers
{
    public class UsersController : Controller
    {
        private readonly BlogDbContext _context;
        private UserRepository userRep;
        public UsersController(BlogDbContext context)
        {
            userRep = new UserRepository(context);
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var blogDbContext = _context.Users.Include(u => u.Role);
            return View(await blogDbContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "CreatedByName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            //if (ModelState.IsValid)
            
                if (!userRep.CheckEmail(user))
                {
                   throw new Exception("Hatalı giriş yaptınız!!");
                }
                userRep.AddUser(user);
                SendActivationMail(user.UserID);
                //await _context.SaveChangesAsync();
                return RedirectToAction("SendActivationMail");
            
           
            //return View(user);
        }

        public IActionResult SendMail()
        {
            return View();
        }

        private void SendActivationMail(int userID)
        {
            User user =new User();
            user = userRep.GetUserById(userID);
            string controller = user.UserID.ToString();
            string url = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host) + "/Users/Verify?Id=" + controller;
            
            string message = string.Format("Üyeliğinizin onaylanması için lütfen linke tıklayınız.");
            message += url;
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("DenemeBaBoost@gmail.com");
            mail.To.Add(user.UserEmail);
            mail.Subject = "Deneme";
            mail.Body = message;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("DenemeBaBoost@gmail.com", "DenemeBaBoost123");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
        }



        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "CreatedByName", user.RoleId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserID,UserFirstName,UserLastName,UserName,UserEmail,UserDescription,UserThumbnail,UserPassword,RoleId,Id,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName")] User user)
        {
            if (id != user.UserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserID))
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
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "CreatedByName", user.RoleId);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }

    }
}

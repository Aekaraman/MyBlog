using System;
using System.Collections.Generic;
using System.Linq;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.DataAccess.Repositories
{
    public class UserRepository
    {
        BlogDbContext dbContext;

        public UserRepository(BlogDbContext context)
        {
            dbContext = context;
        }
        public User GetUserById(int id)
        {
            return dbContext.Users.SingleOrDefault(a => a.UserID == id);
        }
        public bool UpdateUser(User user)
        {
            User selected = GetUserById(user.UserID);
            selected.UserFirstName = user.UserFirstName;
            selected.UserLastName = user.UserLastName;
            selected.UserName = user.UserName;
            selected.UserEmail = user.UserEmail;


            return dbContext.SaveChanges() > 0;
        }

        public string CreateUserNameByMail(User user) //Otomatik UserName belirle
        {

            string otoUserName = "";
            char[] userName = user.UserEmail.ToCharArray();
            char[] userNameArray = new char[userName.Length];
           
            for (int i = 0; i < userName.Length; i++)
            {
                if (userName[i].Equals('@'))
                {
                    break;
                }
                userNameArray[i] = userName[i];
            }

            foreach (var item in userNameArray)
            {
                otoUserName += item;
            }
            return otoUserName;
            
        }

        public bool DeleteUser(int id)
        {
            User selected = dbContext.Users.SingleOrDefault(a => a.UserID == id);
            selected.IsActive = false;
            //or remove
            return dbContext.SaveChanges() > 0;
        }
        public void AddUser(User user)
        {
            user.IsActive = false;
            
            user.UserFirstName = user.UserEmail;
            if (user.UserEmail == null)
            {
                throw new Exception("E-mail boş bırakılamaz...");
            }

            user.RoleId = 1;
            user.UserName = "baboost13";
            //user.UserName = CreateUserNameByMail(user);
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public bool CheckEmail(User user)
        {
            if (user.UserEmail == null && dbContext.Users.Where(a=>a.UserEmail.Contains(user.UserEmail)).Count()>0 )
            {
                return false;
            }

            return true;
        }
        //tüm konular listesi
        public List<Category> GetCategories()
        {
            var categoryList = dbContext.Categories.ToList();
            return categoryList;
        }
        //kullanıcıya göre makaleler
        public List<User> GetArticlesByUserId(int id)
        {
            var articleList = dbContext.Users.Include(a => a.Articles).Where(a => a.UserID == id).ToList();
            return articleList;
        }

        public List<UserAndCategory> GetFollowArticles(User user)
        {
            var followList = dbContext.UserAndCategories.Include(s => s.User).Include(a => a.Category).Include(b => b.User.Articles).Where(a => a.UserID == user.UserID).ToList();
            return followList;
        }

    }
}

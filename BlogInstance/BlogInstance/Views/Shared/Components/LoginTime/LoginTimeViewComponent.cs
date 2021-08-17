using System;
using Microsoft.AspNetCore.Mvc;

namespace BlogInstance.Views.Shared.Components.LoginTime
{
    public class loginTimeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string logintime = "";
            
            if (HttpContext.Request.Cookies.ContainsKey("FirstLoginTime"))
            {
                logintime = HttpContext.Request.Cookies["FirstLoginTime"];
                HttpContext.Response.Cookies.Append("LoginTime", DateTime.Now.ToUniversalTime().ToString());
            }
            return View(model: logintime);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOdev.Controllers
{
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var usr = userManager.GetByUserName(user.UserName);

            if (usr.UserPassword==user.UserPassword)
            {
                return RedirectToAction("Index", "Article");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}

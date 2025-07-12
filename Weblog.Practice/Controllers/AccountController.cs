using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Weblog.Practice.Data;
using Weblog.Practice.Models;

namespace Weblog.Practice.Controllers
{
    public class AccountController : Controller
    {
        private readonly WeblogDbContext context;

        public AccountController(WeblogDbContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid && user is not null)
            {
                var usez = context.Users.FirstOrDefault((x) => x.Username == user.Username && x.Password == user.Password);
                if (usez != null)
                {
                    return RedirectToAction("Index", "Home");

                }
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "somthing went wrong";
                return View();
            }
        }
    }
}

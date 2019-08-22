using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_CoffeeShopPart4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab18_CoffeeShopPart4.Controllers
{
    public class CoffeeShopController : Controller
    {
        //field
        private readonly CoffeeShopDbContext _context;

        //controller
        public CoffeeShopController(CoffeeShopDbContext context)
        {
            _context = context;
        }
        List<User> users = new List<User>();

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            string userJson = HttpContext.Session.GetString("LoginSession");
            if (userJson != null)
            {
                TempData["LoggedIn"] = "Please log out before another user can log in.";
                return RedirectToAction("LogOut");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    User user = _context.User.Find(Email);
                    if (user != null)
                    {
                        if (user.Password == Password)
                        {
                            HttpContext.Session.SetString("LoginSession", JsonConvert.SerializeObject(user));
                            //HttpContext.Session.SetString("LoginSession", Email);
                            return RedirectToAction("Welcome", user);
                        }
                        else
                        {
                            TempData["InvalidPass"] = "Invalid Password";
                        }
                    }
                    else
                    {
                        TempData["InvalidEmail"] = "Email not registered";
                    }
                }
            }
            return View();
        }
        public IActionResult Welcome(User user)
        {
            string userJson = HttpContext.Session.GetString("LoginSession");
            if (userJson != null)
            {
                //users = JsonConvert.DeserializeObject<List<User>>(userJson);
            }
            //users.Add(user);
            return View("Welcome", user);
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogOut(User user)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
    
}
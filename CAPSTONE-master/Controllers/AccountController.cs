﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace Viaggiatore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Dettagli()
        {
            return View("dettagli");
        }
    }

}
